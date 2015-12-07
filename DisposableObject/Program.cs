
namespace ConsoleApplication2
{
    class Program
    {
        // Used to give objects different names.
        private int ObjectNumber = 1;

        // Create an object and do not dispose of it.
        private void createButton_Click()
        {
            // Make an object.
            DisposableClass obj = new DisposableClass();
            obj.Name = "Create " + ObjectNumber.ToString();
            ObjectNumber++;
        }

        // Create an object and dispose of it.
        private void createAndDisposeButton_Click()
        {
            // Make an object.
            DisposableClass obj = new DisposableClass();
            obj.Name = "CreateAndDispose " + ObjectNumber.ToString();
            ObjectNumber++;
            // Dispose of the object.
            obj.Dispose();
        }


        static void Main(string[] args)
        {
            var p = new Program();
            p.createAndDisposeButton_Click();
            p.createButton_Click();
            p.createButton_Click();
            p.createAndDisposeButton_Click();
        }

    }
}
