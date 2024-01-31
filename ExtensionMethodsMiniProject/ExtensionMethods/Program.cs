
// ********** PRO TIP ***********
// Use the tools that make your code 
// easire to read and quicker to develop.

PersonModel person = new PersonModel();

person.FirstName = "What's your first name: ".RequestString();

person.LastName = "What's your last name: ".RequestString();

person.Age = "What's your age: ".RequestInt(0, 140);

bool haveChildren = "Do you have children".RequestBool();
if (haveChildren)
{
    person.NumberOfChilds = "How many childs do you have: ".RequestInt(0, 30);
}

