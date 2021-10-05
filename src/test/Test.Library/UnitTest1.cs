using NUnit.Framework;

namespace RoleplayGame
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestKnightAttacValue()
        {
            Knight templario; 
            templario= new Knight("Templario");
            templario.Sword = new Sword();
            templario.Shield = new Shield();
            templario.Armor = new Armor();

            int expected1 = 20;
            int actual1 = templario.AttackValue;
            Assert.AreEqual(expected1,actual1);
        } 

        [Test]
        public void TestKnightDefenseValue()
        {
            Knight templario; 
            templario= new Knight("Templario");
            templario.Sword = new Sword();
            templario.Shield = new Shield();
            templario.Armor = new Armor();

            int expected2 = 39;
            int actual2 = templario.DefenseValue;
            Assert.AreEqual(expected2,actual2);
        } 
        /*Se testea la clase knight para asegurarse que la implementacion de las interfaces no 
        perjudica el comporatemineto esperado del programa, especialmente el comportamiento de los metodos
        de obtencion del ataque y de la defensa, parte esencial del mismo*/


        [Test]
        public void TestReciveAttack()
        {
            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Archer legolas = new Archer("Legolas");
            legolas.Bow = new Bow();
            legolas.Helmet = new Helmet();
            legolas.ReceiveAttack(gimli.AttackValue);
            int expected= 93;
            int actual = legolas.Health;
            Assert.AreEqual(expected,actual);
        }
        /*Se testea el metodo recivir ataque para determinar si el mismo funciona de manera correcta
        , al igual que para saber si el metodo AttackValue funciona de igual manera, luego de haber agregado 
        las interfaces*/

        [Test]
        public void TestDefenseValue()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf; 
            gandalf= new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            int expected = 170;
            int actual = gandalf.DefenseValue;
            Assert.AreEqual(expected,actual);
        }
        /*Por la misma razon que la del anterior test, este se hace para detemrinar si la implemnetacion de las
        interfaces acarrean algun error en el programa. En este caso, se testea El valor de defensa del ago, el cual esta
        compuesto por el valor de defensa de su arma y el de su hechixo en el libro de hechizos*/ 
        /*
        [Test]
        public void TestCharacterCreator()
        {
            ICharacter legolas = new Archer("Legolas");
            int expected= 100;
            int actual = legolas.Health;
            Assert.AreEqual(expected,actual);
        }/* Se testea la la creacion de los personajes con el tipo ICharacter, en este caso, la del arquero. Esto es para ver si la
            implementacion de la interfaz trae problemas no deseados*/

        [Test]
        public void TestCharacterAttackValueInheritance()
        {
            Character arthur = new Knight("Arthur");
            int expected = 20;
            int actual = arthur.AttackValue;
            Assert.AreEqual(expected,actual);
        }/* Se testea el daño obtenido por una property heredado y sobreescrito de la clase 
        Character, por la clase Knight
        */

        [Test]
        public void TestCharacterReceivedDamageInheritance()
        {
            Character dwarf = new Dwarf("Enano de boca");
            Character archer = new Archer("Sylvanas");
            archer.ReceiveAttack(dwarf.AttackValue);
            int expected = 93;
            int actual = archer.Health;
            Assert.AreEqual(expected,actual);

        }/* Se testea los metodos heredados de Character y sobreescritos por las clases Dwarf y 
        Archer para ver si interactuan sin problemas
        */
    }
}