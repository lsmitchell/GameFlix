using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameFlix
{
    public partial class Form1 : Form
    {
        private bool buttonIsLogin;

        //connection and recset variables for Microsoft Access Database (Login)
        private ADODB.ConnectionClass adodb;
        private ADODB.RecordsetClass recset;

        //connection variable for mysql
        private string MyConString = "SERVER=localhost; DATABASE=gameflix; UID=root; PASSWORD=a;";

        //Quick note: the other mySQL variables were left created on each connection so that
        //scope issues would not break ongoing connections when we need to call
        //a new connection with one already open. Ideally we could have avoided this with a lot
        //of careful work, but this was much easier and accomplished about the same thing.
        //Look at my examples to see how it's done.   - Logan

        //current user's Email (username)
        private string currentUserEmail;
        private string currentUserPassword;
        //No touchy.
        public Form1()
        {
            InitializeComponent();
            buttonIsLogin = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ignore
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //ignore
        }

        /*
        * Logs a user in when they click the login button. 
        *                    ANDREAS---------------------
        * 
        */
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("button has been pressed");
            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            MySqlDataReader dr = null;
            //if the button is currently used to log a user in...
            if (buttonIsLogin)
            {
                //When we have the login db done, check the username/password combo vs the
                //database. Remove the dummy checks when you add the database checks. If the username
                //or password is wrong, clear the textfields and bring up a popup like is already done below.
                //also when they login, change the 'buttonIsLogin' variable to false, so the button changes to logout.
                //Change the userTypeBox to reflect the current level of access the login has.
                //(this means the query should check the successfully logged in user in the database
                //and see what type they are [manager, employee, or customer] to display)

                adodb = new ADODB.ConnectionClass();


                try
                {
                    //get user's input
                    currentUserEmail = emailBox.Text;
                    currentUserPassword = passwordBox.Text;

                    //    Console.WriteLine("u: "+currentUserEmail);
                    //   Console.WriteLine("p: "+currentUserPassword);

                    string sql = "select ID from USER_INFO where Email='" + currentUserEmail + "' and Password ='" + currentUserPassword + "'";
                    //    Console.WriteLine("sql=" + sql);

                    adodb.Open("Provider=Microsoft.Jet.OLEDB.4.0;" +
                               "Data Source='Login.mdb';", "", "", 0);
                    //   Console.WriteLine("connected to login db");

                    recset = new ADODB.RecordsetClass();
                    //   Console.WriteLine("recset obj created");

                    recset.Open(sql, adodb, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, 0); //System.Runtime.InteropServices.COMException
                    //   Console.WriteLine("recset opened");

                    //if recordset is empty the user name and password combination does not exist (see the sql statement)
                    //else record is found

                    if (recset.EOF)
                    {

                        MessageBox.Show("Invalid user name or password.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clearForm();
                    }
                    else
                    {
                        //  Console.WriteLine("in the else statement");
                        //assign the user's id to a variable
                        string id = recset.Fields["ID"].Value.ToString();

                        Console.WriteLine("valid user with ID: " + id);

                        // connection to the MySql database starts here
                        cn = new MySqlConnection();//MySql.Data.MySqlClient.MySqlException' occurred in MySql.Data.dll
                        // Console.WriteLine("sql connection instantiated");

                        cn.ConnectionString = MyConString;
                        //  Console.WriteLine("sonnection string created");

                        cn.Open();
                        //  Console.WriteLine("connection to sql opened");

                        // checking user type starts here
                        cmd = cn.CreateCommand();
                        //   Console.WriteLine("sql command instantiated");

                        cmd.CommandText = "select ID from Manager where ID=" + id;
                        //   Console.WriteLine("sql statement assigned to cmd");

                        dr = cmd.ExecuteReader();
                        //   Console.WriteLine("sql statement executed via datareader");

                        bool manager = false;
                        //true if such record exists wich means that he is an employee
                        if (dr.Read())
                        {
                            //    Console.WriteLine("person is manager");
                            showForm("Manager");
                            populateQueueList();
                            userTypeBox.Text = "Manager";
                            buttonIsLogin = false;
                            loginButton.Text = "Log out";
                            manager = true;
                            
                        }//otherwise it ignores it and checks the other two alternatives
                        dr.Close();

                        if (manager == false)
                        {
                            cmd = null;

                            cmd = cn.CreateCommand();
                            //change the statement so we can check if he is a manager
                            cmd.CommandText = "select ID from Employee where ID=" + id;
                            // Console.WriteLine("new sql that checks manager");
                            dr = cmd.ExecuteReader();
                            //   Console.WriteLine("execute new manager statement");

                            // true if such record exists which means that he is a manager
                            if (dr.Read())
                            {
                                //   Console.WriteLine("person is employee");
                                showForm("Employee");
                                populateQueueList();
                                userTypeBox.Text = "Employee";
                                buttonIsLogin = false;
                                loginButton.Text = "Log out";
                            }
                            else // otherwise he is a customer
                            {
                                //   Console.WriteLine("person is customer");
                                showForm("Customer");
                                populateQueueList();
                                fillPersonalInfoForCustomer();
                                userTypeBox.Text = "Customer";
                                buttonIsLogin = false;
                                loginButton.Text = "Log out";
                            }
                        }
                        dr.Close();
                        cn.Close();
                    }// end of else statement


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);//better message box?
                }
            }
            else
            {
                //(Don't need to change this part)
                //button is being used to log out, so log out when you press it...
                buttonIsLogin = true;
                loginButton.Text = "Log in";
                showForm("Login");
                clearForm();
                currentUserEmail = "";
            }

        }//end of login method

        /* Method completed by Logan.
         * This should be called on login, to populate the info fields with the info
         * for the currently logged in user.
         */        
        private void fillPersonalInfoForCustomer()
        {
            string fname = "";
            string lname = "";
            string address = "";
            string city = "";
            char[] state = { 'Z', 'Z' };
            string zip = "";
            string phoneNum = "";
            string personEmail = "";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = MyConString;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from PERSON where email='" + currentUserEmail + "'";

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                fname = dataReader.GetString(1);
                lname = dataReader.GetString(2);
                address = dataReader.GetString(3);
                city = dataReader.GetString(4);
                dataReader.GetChars(5, 0, state, 0, 2);
                phoneNum = dataReader.GetString(8);
                zip = dataReader.GetString(6);
                personEmail = dataReader.GetString(9);
            }
            conn.Close();

            fnBox.Text = fname;
            lnBox.Text = lname;
            addressBox.Text = address;
            cityBox.Text = city;
            stateBox.Text = "" + state[0] + state[1];
            phoneBox.Text = phoneNum;
            zipBox.Text = zip;
            emailChangeBox.Text = personEmail;

        }
        

        /*
         * showForm unhides the elements of the GUI relating to what level of 
         * access the login has. This is automatically called on successful
         * login. Note this is pretty much done and doesn't need to be altered.
         * 
         * @string type: the type of user that logged in. Acceptable inputs include
         * Customer, Employee, Manager, or Login (when there is nothing but the login.)
         * 
         */
        private void showForm(string type)
        {
            //show the stuff they all see...
            if (type.Equals("Customer") || type.Equals("Employee") || type.Equals("Manager"))
            {

                #region Show universal fields
                userTypeLabel.Visible = true;
                userTypeBox.Visible = true;
                inventoryLabel.Visible = true;
                inventoryBox.Visible = true;
                fnLabel.Visible = true;
                fnBox.Visible = true;
                lnBox.Visible = true;
                addressBox.Visible = true;
                addressLabel.Visible = true;
                cityBox.Visible = true;
                cityLabel.Visible = true;
                stateBox.Visible = true;
                stateLabel.Visible = true;
                zipBox.Visible = true;
                zipLabel.Visible = true;
                phoneBox.Visible = true;
                phoneLabel.Visible = true;
                emailChangeBox.Visible = true;
                emailChangeLabel.Visible = true;
                saveUserButton.Visible = true;
                lnLabel.Visible = true;
                introLabel.Visible = false;
                introLabel2.Visible = false;
                infoButton.Visible = true;
                #endregion

            }

            //show stuff employee AND manager see
            if (type.Equals("Employee") || type.Equals("Manager"))
            {

                #region Employee/Manager Stuff
                itemIdLabel.Visible = true;
                itemIdBox.Visible = true;
                returnButton.Visible = true;
                titleBox.Visible = true;
                titleLabel.Visible = true;
                ratingBox.Visible = true;
                ratingLabel.Visible = true;
                platformBox.Visible = true;
                platformLabel.Visible = true;
                summaryBox.Visible = true;
                summaryLabel.Visible = true;
                addItemButton.Visible = true;
                removeItemButton.Visible = true;
                #endregion

                //populate the selectBox with values from the database for customers.
                //if the Manager wants employees in the list
                //they can hit the radio button.

                populateDropdownMenu("customers");

                selectBox.Visible = true;

            }

            if(type.Equals("Customer"))
            {
                //show customer stuff
                userTypeBox.Text = "Customer";
                queueBox.Visible = true;
                queueLabel.Visible = true;
                addToQueueButton.Visible = true;
                removeFromQueueButton.Visible = true;

            }
            else if (type.Equals("Employee"))
            {
                //show employee stuff
                userTypeBox.Text = "Employee";
                
            }
            else if (type.Equals("Manager"))
            {
                //show manager stuff
                userTypeBox.Text = "Manager";
                customersButton.Visible = true;
                employeeButton.Visible = true;
                deleteUserButton.Visible = true;
                addUserButton.Visible = true;

            }
            else if (type.Equals("Login"))
            {
                //hide all cept login
                #region Hide All Non-Login Fields
                userTypeBox.Text = "";
                userTypeLabel.Visible = false;
                infoButton.Visible = false;
                userTypeBox.Visible = false;
                userTypeLabel.Visible = false;
                userTypeBox.Visible = false;
                inventoryLabel.Visible = false;
                inventoryBox.Visible = false;
                queueBox.Visible = false;
                queueLabel.Visible = false;
                addToQueueButton.Visible = false;
                removeFromQueueButton.Visible = false;
                itemIdLabel.Visible = false;
                itemIdBox.Visible = false;
                returnButton.Visible = false;
                titleBox.Visible = false;
                titleLabel.Visible = false;
                ratingBox.Visible = false;
                ratingLabel.Visible = false;
                platformBox.Visible = false;
                platformLabel.Visible = false;
                summaryBox.Visible = false;
                summaryLabel.Visible = false;
                addItemButton.Visible = false;
                removeItemButton.Visible = false;
                fnLabel.Visible = false;
                fnBox.Visible = false;
                lnBox.Visible = false;
                addressBox.Visible = false;
                addressLabel.Visible = false;
                cityBox.Visible = false;
                cityLabel.Visible = false;
                stateBox.Visible = false;
                stateLabel.Visible = false;
                zipBox.Visible = false;
                zipLabel.Visible = false;
                phoneBox.Visible = false;
                phoneLabel.Visible = false;
                emailChangeBox.Visible = false;
                emailChangeLabel.Visible = false;
                saveUserButton.Visible = false;
                customersButton.Visible = false;
                employeeButton.Visible = false;
                deleteUserButton.Visible = false;
                addUserButton.Visible = false;
                selectBox.Visible = false;
                introLabel.Visible = true;
                introLabel2.Visible = true;
                lnLabel.Visible = false;
                #endregion

            }
            else
            {
                MessageBox.Show("Improper input in method showForm.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* Populates the dropdown menu (employees and managers)
         * with the given type. Only managers should be able to pass
         * employees into this method, and employees should pass in customers.
         * 
         *                      ANDREAS----------------------------------------
         * 
         * @string populateWith: "employees" populates the list with employees
         *  "customers" populates the list with customers.
         */
        private void populateDropdownMenu(string populateWith)
        {
            selectBox.Text = "Select";
            selectBox.Items.Clear();
            if (populateWith.Equals("employees"))
            {
                //This is how you add to the dropdown menu.
                //Dummy addition for now, remove and actually list the names of all the employees in the DB
                // using a cursor loop and a statement.
             //   Console.WriteLine("In employee");
                MySqlConnection conn = new MySqlConnection();
              //  Console.WriteLine("sql con created");
                
                conn.ConnectionString = MyConString;
              //  Console.WriteLine("con string created");
                
                conn.Open();
              //  Console.WriteLine("con opened");

                MySqlCommand command = conn.CreateCommand();
               // Console.WriteLine("command created");

                command.CommandText = "select email from PERSON join EMPLOYEE where person.ID = employee.ID";

                MySqlDataReader dataReader = command.ExecuteReader();
              //  Console.WriteLine("data reader created");
                
                while (dataReader.Read())
                {
                    string email = dataReader.GetString("Email");
                    selectBox.Items.Add(email);
                  //  Console.WriteLine(email+ " added");
                }
                dataReader.Close();
                conn.Close();
            }
            else if(populateWith.Equals("customers"))
            {
              //  Console.WriteLine("In customer");
                MySqlConnection conn = new MySqlConnection();
             //   Console.WriteLine("sql con created");

                conn.ConnectionString = MyConString;
              //  Console.WriteLine("con string created");

                conn.Open();
              //  Console.WriteLine("con opened");

                MySqlCommand command = conn.CreateCommand();
              //  Console.WriteLine("command created");

                command.CommandText = "select email from PERSON join CUSTOMER on person.ID = customer.ID";

                MySqlDataReader dataReader = command.ExecuteReader();
              //  Console.WriteLine("data reader created");

                while (dataReader.Read())
                {
                    string email = dataReader.GetString("Email");
                    selectBox.Items.Add(email);
                  //  Console.WriteLine(email + " added");
                }

                dataReader.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Improper input in method populateDropdownMenu.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* Method completed by Logan.
         * Populates the inventoryList with all the items in the database.
         * Lists ID, title, and availibility in a formatted string to the box.
         */
        private void populateInventoryList()
        {
            //Use a database call to get the ID, name, and rented status of every
            //movie and game in the database, and list them in the inventoryBox.
            //items in the inventoryBox will then be displayed with the following format:
            // ID / Name / Avaliable|Rented (denoted with A or R in parens)
            //Example:    1446GM Example Game64 (A)
            //Another Example:   1555MV Best Movie Ever (R)

            //When we want info on the given game, we can parse the first 6 chars of
            //the list to get the ID and find all info on it from the database.
            //(See selectBox_SelectedIndexChanged method for more information)
            inventoryBox.Items.Clear();

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = MyConString;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select ID, Title, isRented from MEDIA";

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string id = dataReader.GetString(0);
                string name = dataReader.GetString(1);
                char avail = dataReader.GetChar(2);
                if (avail == 'n')
                {
                    avail = 'A';
                }
                else
                {
                    avail = 'R';
                }
                string thisrow = id + " " + name + " " + "(" + avail + ")";
                inventoryBox.Items.Add(thisrow);
            }
            conn.Close();

        }

        //clears all the text fields on the form. Call this to clear the fields.
        private void clearForm()
        {
            #region Clear Textboxes
            emailBox.Text = "";
            passwordBox.Text = "";
            inventoryBox.Text = "";
            titleBox.Text = "";
            itemIdBox.Text = "";
            ratingBox.Text = "";
            platformBox.Text = "";
            summaryBox.Text = "";
            queueBox.Text = "";
            fnBox.Text = "";
            lnBox.Text = "";
            addressBox.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            zipBox.Text = "";
            phoneBox.Text = "";
            emailChangeBox.Text = "";
            customersButton.Checked = false;
            employeeButton.Checked = false;
            #endregion
        }

        //Don't need to touch this.
        //Populates the drop down list with all the customers when the Customer button is hit.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                populateDropdownMenu("customers");
        }

        //Don't need to change this either.
        //Populates the drop down list with employees in the current db.
        private void employeeButton_CheckedChanged(object sender, EventArgs e)
        {
                populateDropdownMenu("employees");
        }

        /* Method completed by Logan.
         * Adds an the currently selected item in the inventory list to the current user's rental queue
         * given that the item is not currently rented already. If it is, a messageBox says so.
         * Gives an errorBox if nothing is selected.
         */
        private void addToQueueButton_Click(object sender, EventArgs e)
        {
            //add things to the user's queue here. Database stuff needed.
            //Pretty easy though. Change the "rented" or whatever we're using
            //variable in the database to true, then move to the current
            //user's queue. Mark item as rented in the inventory list as well, as
            //well as changing the text in inventoryBox to mark is as rented with (R)
            // ------------------------------------------------------------------------
            if (inventoryBox.SelectedItem != null)
            {
                if (itemIsRented(getIDFromListName(inventoryBox.SelectedItem.ToString())) == false)
                {
                    MySqlConnection conn = new MySqlConnection();
                    conn.ConnectionString = MyConString;
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO RENTAL_QUEUE(ID, CustomerID, MediaID) VALUES( 1," + getCurrentUserID() + ",'" + getIDFromListName(inventoryBox.SelectedItem.ToString()) + "')";
                    command.ExecuteNonQuery();
                    toggleMovieAvaliable(getIDFromListName(inventoryBox.SelectedItem.ToString()));
                    
                    conn.Close();

                    populateInventoryList();
                    populateQueueList();

                }
                else
                {
                    MessageBox.Show("We're sorry, that item is rented out.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the Inventory box.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*  Method completed by Logan.
         *  Populates the queueList for customers. Lists the ID and name of every row
         *  in the RENTAL_QUEUE which is assossiated with the current user's ID.
         */
        private void populateQueueList()
        {
            queueBox.Items.Clear();
            List<string> mediaIDList = new List<string>();

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = MyConString;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select mediaID from RENTAL_QUEUE where CustomerID = '" + getCurrentUserID().ToString() + "'";

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                mediaIDList.Add(dataReader.GetString(0));
            }
            conn.Close();

            foreach (string mediaID in mediaIDList)
            {
                conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "select ID, Title, isRented from MEDIA where ID = '" + mediaID + "'";

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string id = dataReader.GetString(0);
                    string name = dataReader.GetString(1);
                    string thisrow = id + " " + name;
                    queueBox.Items.Add(thisrow);
                }
                conn.Close();
            }
        }

        /* Method completed by Logan.
         * Helper method, toggles whether the movie is rented or avaliable when given
         * an item ID.
         * 
         * @itemID       the itemID to have its isRented flag toggled.
         */
        private void toggleMovieAvaliable(string itemID)
        {
            bool rented = itemIsRented(itemID);

            if (!rented)
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE media SET isRented='y' WHERE ID='" + itemID + "'";
                command.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "update media SET isRented='n' where ID='" + itemID + "';";
                command.ExecuteNonQuery();
                conn.Close();
            }
            
        }

        /* Method completed by Logan.
         * Helper method.
         * Gets the ID given the name obtained from InventoryList.selectedItem.toString() or
         * queueList.selectedItem.toString(), by taking the first 6 characters of the string.
         * Useful for doing database searches using the ID of the selected item.
         * 
         * @listName   The list.selectedItem.toString() line
         * 
         * @return     The 6 digit ID of the selected item
         * 
         */
        private string getIDFromListName(string listName)
        {
            string name = "";
            char[] nameChars = listName.ToCharArray();
            for (int i = 0; i < 6; i++)
            {
                name += nameChars[i];
            }
            return name;
        }

        /* Method completed by Logan.
         * Helper method, gets the current user's ID based on their email.
         * The current user's email is stored upon Login, so grab it from
         * the currentUserEmail variable.
         */
        private int getCurrentUserID()
        {
            string email = currentUserEmail;
            int ID = -1;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = MyConString;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select ID from Person where Email='" + email + "'";
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ID = dataReader.GetInt32(0);
            }
            conn.Close();

            return ID;
        }

        /* Method completed by Logan.
         * Helper method. Checks if an item is currently rented based on its ID.
         * 
         * @ID   ID of the item to be checked for isRented
         * @return  returns a bool that represents if the item is currently rented or not.
         */
        private bool itemIsRented(string ID)
        {
            bool rented = false;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = MyConString;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select isRented from Media where ID='" + ID + "'";
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                
                char avail = dataReader.GetChar(0);
                if (avail == 'n')
                {
                    rented = false;
                }
                else
                {
                    rented = true;
                }
            }
            conn.Close();

            return rented;
        }

        /*  Method completed by Logan.
         *  Removes an item from the current user's queue. Gives an error
         *  box if no item in the queue is selected. Toggles the rented status
         *  back to avaliable and refreshes the inventory/queue lists.
         */
        private void removeFromQueueButton_Click(object sender, EventArgs e)
        {
            //remove from queue here. More database required stuff.
            //Remove from the user's queue and uncheck the rented variable in the
            //database for the item whose ID matches the removed item.
            //change the text for the item in inventoryList to be avaliable with (A)

            if (queueBox.SelectedItem != null)
            {
                
                    MySqlConnection conn = new MySqlConnection();
                    conn.ConnectionString = MyConString;
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM RENTAL_QUEUE WHERE MediaID='" + getIDFromListName(queueBox.SelectedItem.ToString()) + "'";
                    command.ExecuteNonQuery();
                    toggleMovieAvaliable(getIDFromListName(queueBox.SelectedItem.ToString()));
                    
                    conn.Close();

                    populateInventoryList();
                    populateQueueList();
            }
            else
            {
                MessageBox.Show("Please select an item from the Queue box.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //                      Carol (I think this is a stored thing?)
        private void saveUserButton_Click(object sender, EventArgs e)
        {
            //Save a user's info. If employee or manager hits the button, save the selected user's
            //info (current selected item from the selectBox). If a customer currently, then
            //save the info using their current login data instead.

            //the property below will give you the currently selected item in the selectBox, which you 
            //can use in the call to save the info based on the name of the selected person.
            //     selectBox.SelectedItem.ToString()

            //give an error box if the current selection is "Select", since that means nothing is selected.
            //----------------------------------------------------------------------------------------------
        }
        
        //                 Carol (this should be a saved procedure)
        private void addUserButton_Click(object sender, EventArgs e)
        {
            //Add a user. Pretty easy, just add a new item in the database for the
            //info given in the fnBox, lnBox, etc.
            //If manager: add customer or employee based on which radio button is checked, default is employee
            //(Radiobuttons have a "checked" property so you can tell if it's checked.)
            //If employee: can only add a customer, so user added is always a customer.

            //Error box if critical data is missing. 
            //------------------------------------------------------------------------------------------------
        }

        //                 Carol (this should be a saved procedure too!)
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            //Remove the selected user from the database. Use the current selected
            //item in the selectBox:
            //    selectBox.SelectedItem.ToString()
            //Then drop based on that, etc.
            //Lastly, repopulate the selectList from the database OR store the name in a variable and remove it from
            //the selectList.Items directly (and save a query).
            //-----------------------------------------------------------------------------------------------
        }

        /* Method completed by Logan.
         * When the selectBox is changed to a new user, this will display
         * their information in the appropriate fields. Will not break if
         * the user does not exist, will simply clear the fields.
         */
        private void selectBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (selectBox.SelectedItem != null)
            {
                string fname = "";
                string lname = "";
                string address = "";
                string city = "";
                char[] state = {'Z','Z'};
                string zip = "";
                string phoneNum = "";
                string personEmail = "";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from PERSON where email='" + selectBox.SelectedItem.ToString() + "'";

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    fname = dataReader.GetString(1);
                    lname = dataReader.GetString(2);
                    address = dataReader.GetString(3);
                    city = dataReader.GetString(4);
                    dataReader.GetChars(5, 0, state, 0, 2);
                    phoneNum = dataReader.GetString(8);
                    zip = dataReader.GetString(6);
                    personEmail = dataReader.GetString(9);
                }
                conn.Close();

                fnBox.Text = fname;
                lnBox.Text = lname;
                addressBox.Text = address;
                cityBox.Text = city;
                stateBox.Text = "" + state[0] + state[1];
                phoneBox.Text = phoneNum;
                zipBox.Text = zip;
                emailChangeBox.Text = personEmail;

            }
            
        }

        //                      ANDREAS----------------------------------------------
        private void addItemButton_Click(object sender, EventArgs e)
        {
            //Add an item to the database given the info in the boxes.
            //Item ID is part of the needed info.
            //Games will end in GM at the end of the ID, else will end in MV.

            //Make sure to give an error message if:
            // - ID doesn't end in MV or GM.
            // - Any text boxes are empty EXCEPT "platformBox" for IDs with MV at the end

            string id = itemIdBox.Text.ToUpper();
            
            string title = titleBox.Text;
            string rating = ratingBox.Text;
            string platform = platformBox.Text;
            string sum = summaryBox.Text;

            if (!(id.Substring(4).Equals("GM") || id.Substring(4).Equals("MV")))
            {
                MessageBox.Show("ID must be 6 characters long and must end in GM or MV", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    MySqlConnection conn = new MySqlConnection();
                    conn.ConnectionString = MyConString;
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "insert into media(ID, Title, Rating, System, Summary, isRented) " +
                        "values('" + id + "','" + title + "','" + rating + "','" + platform + "','" + sum + "','" + "N')";
                    command.ExecuteNonQuery();
                    populateInventoryList();
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);// maybe message box?
                }
            }
        }

        //                      ANDREAS--------------------------------------------
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            //Remove an item from the database given it's info in the itemIdBox.
            //All you need to check for is if the ID in the box is in the database,
            //and if so, remove that whole item. Also remove it from the inventoryListBox.

            //we might want to also remove the item from any customer Queues.

            //Selecting an item from inventory should automatically populate all the
            //data in the Item section, which will automatically fill in the ID
            //for the item you might want to remove from the list. So we don't need
            //to interact with the inventoryBox for this, just make sure the number 
            //in ItemID matches something in the databse.

            //Give an Error if the ID does not match something in the database.
            string id = itemIdBox.Text.ToUpper();
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "delete from media where id='"+id+"'";
                command.ExecuteNonQuery();
                populateInventoryList();
                removeFromAllQueues(id);
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
                      
         
        }

        //                             ANDREAS-------------------------------------
        private void inventoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When a new item is selected, display it's info in the ItemID section
            //IF the user is an employee or a manager. (Check userTypeBox to know.)
            //Basically call a database select statement for the object's data based
            //on the ID of the item in the list.
            //toss the info into temp variables, then set the GUI text boxes below to 
            //represent the info from the database (rating, summary, that stuff).
            string id = getIDFromListName(inventoryBox.SelectedItem.ToString());

            string title = titleBox.Text;
            string rating = ratingBox.Text;
            string platform = platformBox.Text;
            string sum = summaryBox.Text;

            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select Title, Rating, System, Summary from media where id ='" + id + "'";
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    title = dataReader.GetString("Title");
                    rating = dataReader.GetString("Rating");
                    platform = dataReader.GetString("System");
                    sum = dataReader.GetString("Summary");
                    itemIdBox.Text = id;
                    titleBox.Text = title;
                    ratingBox.Text = rating;
                    platformBox.Text = platform;
                    summaryBox.Text = sum;
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  Method completed by Logan
         *  Return Button returns a given movie given either the Item ID in the box
         *  above the button, OR, if nothing is in the box, will use whatever item
         *  is selected in the Inventory List and attempt to return that.
         *  If item is not rented, gives a message saying so.
         *  If entered ID is not found in the database, gives a message as well.
         * 
         */
        private void returnButton_Click(object sender, EventArgs e)
        {
             
            bool blank = false; //if nothing is selected and no ID is in the box, this is true.
            string itemID = ""; //the Item ID to check for in the DB

            if (itemIdBox.Text.Length <= 0)
            {
                if (inventoryBox.SelectedItem != null)
                {
                    itemID = getIDFromListName(inventoryBox.SelectedItem.ToString());
                }
                else
                {
                    blank = true;
                }
            }
            else
            {
                itemID = itemIdBox.Text;
            }


            if (blank == false)
            {
                string title = null;
                char rented = 'x';
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select title, isRented from Media where ID='" + itemID + "'";
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    title = dataReader.GetString(0);
                    rented = dataReader.GetChar(1);
                }
                conn.Close();

                if (title == null)
                {
                    MessageBox.Show("Improper ID, or not found in database\nProper ID is 4 digits + MV for movies, or GM for game.", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (rented == 'n')
                    {
                        MessageBox.Show("\"" + title + "\" is not currently rented, and does not need to be returned.", "Item Not Rented", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        toggleMovieAvaliable(itemID);
                        MessageBox.Show("\"" + title + "\" returned.", "Item Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        removeFromAllQueues(itemID);
                        populateInventoryList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input an ID to return, or select from the Inventory list.", "No ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* Method completed by Logan.
         * Helper method. When an item is returned by the return button (Employee or Manager)
         * this method removes the item from any user queues it happens to be in. Should only
         * be one for our purposes but would do it if there were more than one.
         * 
         * @itemID     the ID of the item to be removed from all queues.
         */
        private void removeFromAllQueues(string itemID)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = MyConString;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM RENTAL_QUEUE WHERE MediaID='" + itemID + "'";
            command.ExecuteNonQuery();

            conn.Close();
        }

        /*
         * This is called when the whole form loads. 
         * Any stuff that needs to be initialized, should be here.
         * Nobody needs to work on this, add stuff if you need to.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            //populate the inventory list when everything is loaded.
            populateInventoryList();

        }

        /* Method completed by Logan.
         * Shows all the information for the selected item in the inventory list.
         * Gives an error box is nothing is selected. Box shows all data about the
         * item from the database, formatted.
         */
        private void infoButton_Click(object sender, EventArgs e)
        {
            if (inventoryBox.SelectedItem != null)
            {
                string id = "";
                string name = "";
                string type = "";
                string rating = "";
                string genre = "";
                string summary = "";
                string system = "";
                char avail = 'n';
                string avail2 = "a";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = MyConString;
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from MEDIA where ID='" + getIDFromListName(inventoryBox.SelectedItem.ToString()) + "'";

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                     id = dataReader.GetString(0);
                     name = dataReader.GetString(1);
                     type = dataReader.GetString(2);
                     rating = dataReader.GetString(3);
                     genre = dataReader.GetString(4);
                     summary = dataReader.GetString(5);
                     system = dataReader.GetString(6);
                     avail = dataReader.GetChar(7);
                    if (avail == 'n')
                    {
                        avail2 = "This " + type + " is avaliable.";
                    }
                    else
                    {
                        avail2 = "This " + type + " is currently rented out.";
                    }
                }
                conn.Close();

                string message = name + "\nType: " + type + "\tRated: " + rating +
                    "\nGenre: " + genre;
                    if(type.Equals("Game"))
                    {
                        message += "\tPlatform: " + system;
                    }
                    message += "\n" + avail2;
                    message += "\nSummary:\n       " + summary;

                MessageBox.Show(message, "Information for " + id, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an item from the Inventory box.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void summaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void queueBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
