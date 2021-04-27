using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShoppingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //class-level lists
        List<Customer> customers = new List<Customer>();
        List<Furniture> products = new List<Furniture>();
        List<Cart> lineItems = new List<Cart>();


        //global variable customerIndex
        public int customerIndex;

        private void Form1_Load(object sender, EventArgs e)
        {
            //3. form load code
            //only grpLogin is available
            ShowGroupboxes(false);

            //4.
            //5.
            PopulateProducts();
            ReadInCustomers();
        }

        //method ShowGroupboxes(bool)
        //send: bool
        //return: nothing
        //This method flips the groupboxes, changing them to visible or not
        public void ShowGroupboxes(bool show)
        {
            if (show == true)
            {
                grpCart.Show();
                grpCustomer.Show();
                grpProducts.Show();
                grpLogin.Hide();
            }
            else
            {
                grpCart.Hide();
                grpCustomer.Hide();
                grpProducts.Hide();
                grpLogin.Show();
                cboNames.SelectedIndex = -1;
            }
        }

        private void PopulateProducts()
        {   
            products.Add(new Sofas("SKW", "Key West", 799.99m, "Blue", 3));
            products.Add(new DiningRoom("DS", "Sabrina", 1599m, "Rectangular", 6));
            products.Add(new Sofas("SMO", "Monica", 545m, "Red", 2));
            products.Add(new DiningRoom("DJ", "Jericho", 2150m, "Oval", 4));
            products.Add(new Sofas("SIK", "IKEA", 1299.5m, "Green", 6));
            products.Add(new DiningRoom("DH", "Hatfield", 899.6m, "Square", 2));

            //use foreach to display all products
            // in combobox with type and description
            foreach (var item in products)
            {
                cboProducts.Items.Add(item.GetType().Name + ": " + item.Description);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if Name in combobox selected 
            if (cboNames.SelectedIndex >= 0)
            {
                //find the customer from list
                foreach (Customer item in customers)
                {
                    //when find the customer, populate Customer Group info
                    if (cboNames.SelectedItem.ToString() == item.LastName)
                    {
                        //change global variable index to the customer index from the list
                        //will be used later in the btn2nd card click
                        customerIndex = customers.IndexOf(item);

                        //display properties in the labels
                        lblID.Text = item.ID;
                        lblFirstName.Text = item.FirstName;
                        lblLastName.Text = item.LastName;

                        //show groupboxes
                        ShowGroupboxes(true);

                        //disable button 2nd card
                        btn2ndCard.Enabled = false;

                        //if customer found is Goldstar,
                        //and does not have a 2nd card
                        //enable 2nd card button
                        if (item.GetType() == typeof(GoldStar) && (item as GoldStar).Cards < 2)
                        {
                            btn2ndCard.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Last Name", "Alert");
            }
        }


            public void ReadInCustomers()
            {
                try
                {    //hard coded filename     
                    StreamReader inputFile = new StreamReader(@"c:\files\Customers.txt");
                    string inID, inLastName, inFirstName;
                    while (inputFile.Peek() != -1)
                    {
                        string row = inputFile.ReadLine();
                        string[] columns = row.Split('|');

                        inID = columns[0];
                        inLastName = columns[1];
                        inFirstName = columns[2];

                        //add lastnames to combobox
                        cboNames.Items.Add(inLastName);

                        //determine type of customer based on length of code                    
                        if (inID.Length == 2)
                        {
                            GoldStar g = new GoldStar(inID, inLastName, inFirstName);

                            // place in customers list  
                            customers.Add(g);
                        }

                        else
                        {
                            Customer c = new Customer(inID, inLastName, inFirstName);

                            // place in customers list  
                            customers.Add(c);
                        }
                    }
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Closing Program", "File Error");
                    Close();
                }
            }
        

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // if a product selected, place in lstCart
            // and add to lineItems List
            int i = cboProducts.SelectedIndex;

            if (i >= 0)
            {
                //instantiate a new cart
                Cart c = new Cart(products[i].Code, products[i].Description, products[i].Price, (int)nudNumber.Value);

                //add cart to lineItems list
                lineItems.Add(c);

                //display in the cart listbox
                lstCart.Items.Add(c.ToString());
            }
        }

        private void btn2ndCard_Click(object sender, EventArgs e)
        {
            // clone the customer            
            GoldStar g = (GoldStar)customers[customerIndex].Clone();

            //disable btn2ndCard
            btn2ndCard.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            //if there are items in the cart, ask for confirmation
            // Yes - process the order and logout
            // No -  stay to complete order
            //Cancel - cancel order and logout 

            if (lineItems.Count > 0)
            {
                DialogResult button =
                    MessageBox.Show("Are you sure? \n" +
                    "Yes: Order processed and Logout \n" +
                    "No: Return and finish order \n" +
                    "Cancel: Cancel order and Logout",
                    "Confirm Order",
                    MessageBoxButtons.YesNoCancel);

                if (button == DialogResult.Yes)
                {
                    //declare variable for the grand total
                    decimal grandTotal = 0m;

                    //sum all linetotals from lineitems list
                    foreach (Cart item in lineItems)
                    {
                        grandTotal += item.LineTotal;
                    }

                    //intantiate new order, using grandTotal calculated
                    Orders newOrder = new Orders(grandTotal);

                    //add order to invpices lits of the customer
                    customers[customerIndex].Invoices.Add(newOrder);

                    //display order info
                    MessageBox.Show("Order Number: " + newOrder.OrderNumber +
                        "\n Date: " + newOrder.OrderDate.ToString("MM/dd/yyyy") +
                        "\n Grand Total: " + newOrder.GrandTotal.ToString("c"),
                        "Order Confirmed");

                    //logout 
                    //empty lineitems list and listbox
                    lineItems.Clear();
                    lstCart.Items.Clear();

                    //hide groupbox and show login empty
                    ShowGroupboxes(false);
                }
                else if (button == DialogResult.No)
                {
                    //does nothing
                }
                else if (button == DialogResult.Cancel)
                {
                    //logout
                    //empty lineitems list and listbox
                    lineItems.Clear();
                    lstCart.Items.Clear();

                    //hide groupbox and show login empty
                    ShowGroupboxes(false);
                }
            }
        }


        private void btnCompare_Click(object sender, EventArgs e)
        {
            //both a product and cart item have to be selected
            //compare prices of the two products
            if (cboProducts.SelectedIndex >= 0 && lstCart.SelectedIndex >= 0)
            {
                int i = cboProducts.SelectedIndex;

                foreach (Cart c in lineItems)
                {
                    if (c.ToString() == lstCart.SelectedItem.ToString())
                    {
                        //use method product.CompareTo
                        //use a switch to display different messages
                        switch (products[i].CompareTo(c))
                        {
                            case 1:
                                MessageBox.Show(products[i].Description +
                            " in product list is more expensive than "
                            + c.Description + " cart item");
                                break;
                            case -1:
                                MessageBox.Show(products[i].Description +
                           " in product list is less expensive than "
                           + c.Description + " cart item");
                                break;
                            case 0:
                                MessageBox.Show(products[i].Description +
                            " in product list is same price as "
                            + c.Description + " cart item");
                                break;
                        } // end switch
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //for each customer in the list, if they have orders, add to a string
            string ordersPlaced = "";

            foreach (Customer item in customers)
            {
                if (item.Invoices.Count > 0)
                {
                    ordersPlaced += "Customer: " + item.LastName +
                        " placed " + item.Invoices.Count + " order(s).\n";
                }
            }
            //display all customers who places orders
            //with their last name and number of orders placed
            MessageBox.Show(ordersPlaced, "Orders Placed");
        }
    } // end Form Class


    /* all other classes here */

    public class Orders
    {
        //auto-implemented properties
        private static int nextID = 1;
        public int OrderNumber;
        public DateTime OrderDate;
        public decimal GrandTotal;

        //Default constructor
        public Orders() { }

        //Custom constructor
        public Orders(decimal grandtotal)
        {
            //set ORderNumber to nextID
            OrderNumber = nextID++;

            //set OrderDate to today's date
            OrderDate = DateTime.Now;

            //set GRandTotal to data sent in
            GrandTotal = grandtotal;
        }
    }

    public class Customer : ICloneable
    {
        //auto implemented properties 
        public string ID, LastName, FirstName;

        //property list of orders
        public List<Orders> Invoices;

        //default constructor
        public Customer() { }

        //custom constructor
        public Customer(string id, string lastname, string firstname)
        {
            //check that ID is 2 characters or less. If more, delete the rest and leave the first 2 only.
            if (id.Length > 2)
                id = id.Remove(2);

            //set properties to data entered
            ID = id;
            LastName = lastname;
            FirstName = firstname;

            //Set Invoices to new List of Orders
            Invoices = new List<Orders>();
        }
        public virtual object Clone()
        {
            //returns null customer
            return null;
        }

    }

    public sealed class GoldStar : Customer, ICloneable
    {
        //autoimplemented property
        public int Cards;

        //const maximum cards
        private const int MAXCARDS = 2;

        //default constructor
        public GoldStar() { }

        //custom constructor - calls base
        public GoldStar(string id, string lastname, string firstname)
            : base(id, lastname, firstname) => Cards = 1;


        public override object Clone()
        {
            GoldStar g;

            //if does not have 2 cards, make a deep copy
            if (this.Cards < MAXCARDS)
            {
                g = new GoldStar
                {
                    ID = ID,
                    LastName = LastName,
                    FirstName = FirstName
                };

                this.Cards = MAXCARDS;
                g.Cards = this.Cards;

            }
            //if already has 2 cards, return null object
            else
                g = null;

            return g;

        }
    }

    public abstract class Furniture : IComparable<Furniture>
    {
        //autoimplemented properties
        public string Code, Description;
        public decimal Price;

        //default constructor
        public Furniture() { }

        //custom constructor
        public Furniture(string code, string description, decimal price)
        {
            //If price not between $5 -$2500, reset to $599.99
            if (price < 5m || price > 2500m)
                price = 599.99m;

            //set properties
            Code = code;
            Description = description;
            Price = price;
        }

        public int CompareTo(Furniture other) => Price < other.Price ? -1 : (Price == other.Price ? 0 : 1);

        //override method ToString()
        //send: nothing
        //return: string with Code, Description and Price
        public override string ToString() => String.Format("{0,-12}{1, -37}{2, -15}", Code, Description, Price.ToString("c"));
    }

    public sealed class Sofas : Furniture
    {
        //autoimplemented properties
        public string Color;
        public int Seats;

        //default constructor
        public Sofas() { }

        //custom constructor
        public Sofas(string code, string description, decimal price, string color, int seats)
            : base(code, description, price)
        {
            //if seats not between 1 and 4, reset it to 3
            if (seats < 1 || seats > 4)
                seats = 3;

            //set properties
            Color = color;
            Seats = seats;
        }

        //override ToString() - return base.ToString() and color and seats 
        public override string ToString() => base.ToString()
            + String.Format("{0, -10}{1, -5}", Color, Seats);

    }

    public sealed class DiningRoom : Furniture
    {
        //autoimplemented properties
        public string TableShape;
        public int Chairs;

        //default constructor
        public DiningRoom() { }

        //custom constructor
        public DiningRoom(string code, string description, decimal price, string shape, int chairs)
            : base(code, description, price)
        {
            //if chairs not between 2 and 6, reset it to 4
            if (chairs < 2 || chairs > 6)
                chairs = 4;

            //set properties
            TableShape = shape;
            Chairs = chairs;
        }

        //override ToString() - return base.ToString() and shape and chairs
        public override string ToString() => base.ToString()
            + String.Format("{0, 10}{1, 5}", TableShape, Chairs);
    }

    public sealed class Cart : Furniture
    {
        //autoimplemented properties
        public int Amount;
        public decimal LineTotal;

        //default constructor
        public Cart() { }

        //custom constructor
        public Cart(string code, string description, decimal price, int amount)
     : base(code, description, price)
        {
            //if amount not between 1 and 10, reset it to 1
            if (amount < 1 || amount > 10)
                amount = 1;

            //set properties
            Amount = amount;
            LineTotal = amount * price;
        }

        //override ToString() - return base.ToString() and amount and linetotal
        public override string ToString() => base.ToString()
            + String.Format("{0, -12}{1, -15}", Amount, LineTotal.ToString("c"));
    }



}

