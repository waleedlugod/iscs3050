using System;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;

namespace Lugod_LongExercise2
{
    public partial class Form1 : Form
    {
        private List<Meal> meals = new List<Meal>();
        private int orderCount = 0;
        private XmlDocument doc;
        private XmlElement rootNode;
        private string path = "C:\\Users\\lugod\\source\\repos\\waleedlugod\\iscs3050\\Lugod-LongExercise2\\orders.xml";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxResponse.Text = "";
            comboBoxSideType.Items.AddRange([
                "Fries (50 PHP for Medium, 75 PHP for Large)",
                "Onion Rings (60 PHP for Medium, 90 PHP for Large)",
                "Bacon Chips (70 PHP for Medium, 105 PHP for Large)"
                ]);
            comboBoxSideSize.Items.AddRange([
                "Medium",
                "Large"
                ]);
            comboBoxWrapSpice.Items.AddRange([
                "Mild",
                "Spicy",
                "Very Spicy"
                ]);
            doc = new XmlDocument();
            rootNode = doc.CreateElement("orders");
            doc.AppendChild(rootNode);
            doc.Save(path);
        }
        private void ListItems()
        {
            int idx = 0;
            foreach (Meal order in meals)
            {
                idx++;
                textBoxResponse.AppendText($"({idx}) {order.GetDescription()} ({order.cost} PHP)\r\n");
            }
        }

        private void buttonOrderBurger_Click(object sender, EventArgs e)
        {
            int patties;
            int cheese;
            bool veggies = checkBoxVeggies.Checked;
            if (int.TryParse(textBoxBurgerPatties.Text, out patties) && int.TryParse(textBoxBurgerCheese.Text, out cheese) && patties >= 0 && cheese >= 0)
            {
                Burger burger = new Burger(patties, cheese, veggies);
                meals.Add(burger);
                textBoxResponse.Text = $"{burger.GetDescription()} added! Subtotal: {burger.cost} PHP";
            }
            else
            {
                textBoxResponse.Text = "Could not add burger to order";
            }
        }
        private void buttonOrderSide_Click(object sender, EventArgs e)
        {
            int type = comboBoxSideType.SelectedIndex;
            int size = comboBoxSideSize.SelectedIndex;

            if (type != -1 & size != -1)
            {
                Side side = new Side(type, size);
                meals.Add(side);
                textBoxResponse.Text = $"{side.GetDescription()} added! Subtotal: {side.cost} PHP";
            }
            else
            {
                textBoxResponse.Text = "Could not add side to order";
            }
        }

        private void buttonOrderWrap_Click(object sender, EventArgs e)
        {
            int cheese;
            bool allMeat = checkBoxWrapMeat.Checked;
            int spice = comboBoxWrapSpice.SelectedIndex;
            if (int.TryParse(textBoxWrapCheese.Text, out cheese) && spice != -1 && cheese >= 0)
            {
                Wrap wrap = new Wrap(cheese, allMeat, spice);
                meals.Add(wrap);
                textBoxResponse.Text = $"{wrap.GetDescription()} added! Subtotal: {wrap.cost} PHP";
            }
            else
            {
                textBoxResponse.Text = "Could not add wrap to order";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (meals.Count <= 0)
            {
                textBoxResponse.Text = "No items added!";
            }
            else
            {
                int totalCost = 0;
                foreach (Meal order in meals)
                {
                    totalCost += order.cost;
                }
                orderCount++;
                textBoxResponse.Text = $"Order {orderCount}:\r\n";
                ListItems();
                textBoxResponse.Text += $"Total Price: {meals.Select(order => order.cost).Sum()} PHP";

                XmlElement newOrder = doc.CreateElement("order");

                XmlElement orderNumber = doc.CreateElement("orderNumber");
                XmlText orderNumberValue = doc.CreateTextNode(orderCount.ToString());
                orderNumber.AppendChild(orderNumberValue);
                newOrder.AppendChild(orderNumber);


                foreach (Meal meal in meals)
                {
                    newOrder.AppendChild(meal.CreateXml(doc));
                }

                rootNode.AppendChild(newOrder);
                doc.Save(path);

                meals = new List<Meal>();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (meals.Count <= 0)
            {
                textBoxResponse.Text = "No items added!";
            }
            else
            {
                textBoxResponse.Text = "Your order:\r\n";
                ListItems();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? input = null;
            int choice;

            if (meals.Count <= 0)
            {
                textBoxResponse.Text = "No items added!";
            }
            else if (int.TryParse(textBoxDelete.Text, out choice) && choice >= 1 && choice <= meals.Count)
            {
                textBoxResponse.Text = $"{meals[choice - 1].GetDescription()} removed!";
                meals.RemoveAt(choice - 1);
            }
            else
            {
                textBoxResponse.Text = "Which would you like to remove:\r\n";
                ListItems();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rootNode.ChildNodes.Count <= 0)
            {
                textBoxResponse.Text = "No orders added!";
            }
            else
            {
                textBoxResponse.Text = "Your orders:\r\n";
                foreach (XmlNode order in rootNode.ChildNodes)
                {
                    int totalCost = 0;
                    XmlNodeList nodeList = order.ChildNodes;
                    for (int i = 0; i < nodeList.Count; i++)
                    {
                        XmlNode node = nodeList[i];
                        Meal meal;
                        if (i == 0)
                        {
                            textBoxResponse.AppendText($"Order {node.InnerText}:\r\n");
                        }
                        else
                        {
                            switch (node.Name)
                            {
                                case "burger":
                                    int.TryParse(node.SelectSingleNode("extraPatties").InnerText, out int patties);
                                    int.TryParse(node.SelectSingleNode("extraCheese").InnerText, out int cheese);
                                    bool.TryParse(node.SelectSingleNode("hasVeggies").InnerText, out bool veggies);
                                    meal = new Burger(patties, cheese, veggies);
                                    textBoxResponse.AppendText($"({i}) {meal.GetDescription()} ({meal.cost} PHP)\r\n");
                                    totalCost += meal.cost;
                                    break;
                                case "side":
                                    string type = node.SelectSingleNode("type").InnerText;
                                    string size = node.SelectSingleNode("size").InnerText;
                                    meal = new Side(type, size);
                                    textBoxResponse.AppendText($"({i}) {meal.GetDescription()} ({meal.cost} PHP)\r\n");
                                    totalCost += meal.cost;
                                    break;
                                case "wrap":
                                    int.TryParse(node.SelectSingleNode("extraCheese").InnerText, out int cheeseWrap);
                                    bool.TryParse(node.SelectSingleNode("allMeat").InnerText, out bool allMeat);
                                    string spiceLevel = node.SelectSingleNode("spiceLevel").InnerText;
                                    meal = new Wrap(cheeseWrap, allMeat, spiceLevel);
                                    textBoxResponse.AppendText($"({i}) {meal.GetDescription()} ({meal.cost} PHP)\r\n");
                                    totalCost += meal.cost;
                                    break;
                            }
                        }
                    }
                    textBoxResponse.AppendText($"Total Price: {totalCost} PHP\r\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (orderCount >= 1)
            {
                rootNode.RemoveChild(rootNode.LastChild);
                textBoxResponse.Text = $"Removed order {orderCount}";
                orderCount--;
                doc.Save(path);
            }
            else
            {
                textBoxResponse.Text = "No orders added!";
            }
        }
    }

    abstract class Meal
    {
        public int cost;
        public abstract string GetDescription();
        public abstract XmlElement CreateXml(XmlDocument doc);
    }
    class Burger : Meal
    {
        public int extraPatties;
        public int extraCheese;
        public bool hasVeggies;
        public Burger(int extraPatties, int extraCheese, bool hasVeggies)
        {
            this.extraPatties = extraPatties;
            this.extraCheese = extraCheese;
            this.hasVeggies = hasVeggies;
            cost = 50 + 50 * extraPatties + 25 * extraCheese;
        }
        public override string GetDescription()
        {
            return $"Burger with {extraPatties} extra patties, {(extraCheese > 0 ? extraCheese : "no")} extra cheese slices added, and{(hasVeggies ? "" : " no")} veggies";
        }
        public override XmlElement CreateXml(XmlDocument doc)
        {
            XmlElement el = doc.CreateElement("burger");

            XmlElement pattiesEl = doc.CreateElement("extraPatties");
            XmlText pattiesElValue = doc.CreateTextNode(extraPatties.ToString());
            pattiesEl.AppendChild(pattiesElValue);
            el.AppendChild(pattiesEl);

            XmlElement cheeseEl = doc.CreateElement("extraCheese");
            XmlText cheeseElValue = doc.CreateTextNode(extraCheese.ToString());
            cheeseEl.AppendChild(cheeseElValue);
            el.AppendChild(cheeseEl);

            XmlElement veggiesEl = doc.CreateElement("hasVeggies");
            XmlText veggiesElValue = doc.CreateTextNode(hasVeggies.ToString());
            veggiesEl.AppendChild(veggiesElValue);
            el.AppendChild(veggiesEl);

            return el;
        }
    }

    class Side : Meal
    {
        public string? type;
        public string? size;
        public Side(int type, int size)
        {
            switch (type)
            {
                case 0: this.type = "Fries"; break;
                case 1: this.type = "Onion Rings"; break;
                case 2: this.type = "Bacon Chips"; break;
            }
            switch (size)
            {
                case 0: this.size = "Medium"; break;
                case 1: this.size = "Large"; break;
            }
            switch (this.type)
            {
                case "Fries": cost = this.size == "Medium" ? 50 : 75; break;
                case "Onion Rings": cost = this.size == "Medium" ? 60 : 90; break;
                case "Bacon Chips": cost = this.size == "Medium" ? 70 : 105; break;
            }
        }
        public Side(string type, string size)
        {
            this.type = type;
            this.size = size;
            switch (this.type)
            {
                case "Fries": cost = this.size == "Medium" ? 50 : 75; break;
                case "Onion Rings": cost = this.size == "Medium" ? 60 : 90; break;
                case "Bacon Chips": cost = this.size == "Medium" ? 70 : 105; break;
            }
        }
        public override string GetDescription()
        {
            return $"{size} {type?.ToLower()}";
        }
        public override XmlElement CreateXml(XmlDocument doc)
        {
            XmlElement el = doc.CreateElement("side");

            XmlElement typeEl = doc.CreateElement("type");
            XmlText typeElValue = doc.CreateTextNode(type);
            typeEl.AppendChild(typeElValue);
            el.AppendChild(typeEl);

            XmlElement sizeEl = doc.CreateElement("size");
            XmlText sizeElValue = doc.CreateTextNode(size);
            sizeEl.AppendChild(sizeElValue);
            el.AppendChild(sizeEl);

            return el;
        }
    }

    class Wrap : Meal
    {
        public int extraCheese;
        public bool isAllMeat;
        public string? spiceLevel;
        public Wrap(int extraCheese, bool isAllMeat, int spiceLevel)
        {
            this.extraCheese = extraCheese;
            this.isAllMeat = isAllMeat;
            switch (spiceLevel)
            {
                case 0: this.spiceLevel = "Mild"; break;
                case 1: this.spiceLevel = "Spicy"; break;
                case 2: this.spiceLevel = "Very spicy"; break;
            }
            this.cost = 100 + 20 * extraCheese;
        }
        public Wrap(int extraCheese, bool isAllMeat, string spiceLevel)
        {
            this.extraCheese = extraCheese;
            this.isAllMeat = isAllMeat;
            this.spiceLevel = spiceLevel;
            this.cost = 100 + 20 * extraCheese;
        }
        public override string GetDescription()
        {
            return $"{(isAllMeat ? "All meat " : "")}{(isAllMeat ? spiceLevel?.ToLower() : spiceLevel)} wrap with {(extraCheese > 0 ? extraCheese : "no")} extra cheese";
        }
        public override XmlElement CreateXml(XmlDocument doc)
        {
            XmlElement el = doc.CreateElement("wrap");

            XmlElement cheeseEl = doc.CreateElement("extraCheese");
            XmlText cheeseElValue = doc.CreateTextNode(extraCheese.ToString());
            cheeseEl.AppendChild(cheeseElValue);
            el.AppendChild(cheeseEl);

            XmlElement meatEl = doc.CreateElement("allMeat");
            XmlText meatElValue = doc.CreateTextNode(isAllMeat.ToString());
            meatEl.AppendChild(meatElValue);
            el.AppendChild(meatEl);

            XmlElement spiceEl = doc.CreateElement("spiceLevel");
            XmlText spiceElValue = doc.CreateTextNode(spiceLevel);
            spiceEl.AppendChild(spiceElValue);
            el.AppendChild(spiceEl);

            return el;
        }
    }
}