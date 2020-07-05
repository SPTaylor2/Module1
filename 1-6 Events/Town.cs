using _1_6_Events.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_6_Events
{
    public partial class Town : Form
    {
        Person person1, person2, person3, person4;
        List<Person> people = new List<Person>();

        Queue<string> queueList = new Queue<string>();
        Stack<string> stackList = new Stack<string>();

        public event EventHandler BasketDelivered;

        public virtual void OnBasketDelivered(EventArgs e)
        {
            EventHandler handler = BasketDelivered;
            handler?.Invoke(this, e);
        }

        public Town()
        {
            InitializeComponent();
        }

        private void Town_Load(object sender, EventArgs e)
        {
            loadTownsPeople();
        }

        private void loadTownsPeople()
        {
            // this would usually be done from a data sourse 
            // manually creating 
            people = new List<Person>();

            person1 = new Person("Johnson", "LaToyna", btnHouse1, 2);
            this.BasketDelivered += new System.EventHandler(person1.onBasketDelivered);
            people.Add(person1);

            person2 = new Person("Barros", "Julio", btnHouse2, 4);
            this.BasketDelivered += new System.EventHandler(person2.onBasketDelivered);
            people.Add(person2);

            person3 = new Person() { LastName = "Han", FirstName = "Jen", Distance = 1, HouseButton = btnHouse3 };
            this.BasketDelivered += new System.EventHandler(person3.onBasketDelivered);
            people.Add(person3);
            
            person4 = new Person() { LastName = "Anand", FirstName = "Prishna", Distance = 4, HouseButton = btnHouse4 };            
            this.BasketDelivered += new System.EventHandler(person4.onBasketDelivered);
            people.Add(person4);
        }

        private void deliverBasket(Person deliveredTo)
        {
            System.Threading.Thread.Sleep(deliveredTo.Distance * 1000);
            OnBasketDelivered(new deliveryInfo(deliveredTo));

            queueList.Enqueue("Delivered to: " + deliveredTo.LastName);
            printList(queueList.ToArray(), lblQueueList);

            stackList.Push("Delivered to: " + deliveredTo.LastName);
            printList(stackList.ToArray(), lblStackList);
            
        }

        private void btnDeliverBaskets_Click(object sender, EventArgs e)
        {
            foreach (Person p in people)
            {
                deliverBasket(p);
                this.Refresh();
            }

            //deliverBasket(person1);
            //this.Refresh();
            //deliverBasket(person2);
            //this.Refresh();
            //deliverBasket(person3);
        }

        private void printList(string[] inArry, Label destination)
        {
            destination.Text = "";

            foreach(string s in inArry)
            {
                destination.Text += s + Environment.NewLine;
            }
        }
    }
}
