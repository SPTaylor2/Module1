using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_6_Events.Model
{
    public class Person 
    {
        public int id;
        public string LastName;
        public string FirstName;
        public Button HouseButton;
        public int Distance;

        delegate void BasketDelivered(object sender, EventArgs e);

        public Person() { }

        public Person(string inLastname, string inFirstName, Button inHouseButton, int inDistance)
        {
            LastName = inLastname;
            FirstName = inFirstName;
            HouseButton = inHouseButton;
            Distance = inDistance;
        }

        public void onBasketDelivered(object sender, EventArgs e)
        {
            deliveryInfo evt = (deliveryInfo)e;
            if (evt.person.LastName == this.LastName)
            {
                HouseButton.BackColor = Color.MidnightBlue;
                HouseButton.ForeColor = Color.White;
                HouseButton.Text = evt.person.FirstName + " says: 'Thank you'";
            }
        }
    }

}
