using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInference
{
    public interface Interface0
    { }

    public class Class0 : Interface0
    { }

    public interface Interface1
    { }

    public class Class1 : Interface1
    { }

    public class Class3
    {
        public void test1<TCurr, TNext>(IChainCommand<TCurr, TNext> arg)
        {

        }

        public void test1<T>(T arg) where T : ICommand
        {
            arg.Do();
        }

        public void test1<TCurr, TNext>(ChainCommand<TCurr, TNext> arg)
            where TCurr : IChainableCommand, ICommand
            where TNext : IChainableCommand, ICommand
        {
            test1(arg.currentCommand);
            test1(arg.nextCommand);
        }

        public void test1(Class1 arg)
        { }
    }

    public class ChainCommand<TCurr, TNext> : IChainCommand<IChainableCommand, IChainableCommand>, IChainableCommand
        where TCurr : IChainableCommand
        where TNext : IChainableCommand
    {
        public TNext nextCommand;
        public TCurr currentCommand;
        public ChainCommand(TCurr currentCommand, TNext nextCommand)
        {
            this.currentCommand = currentCommand;
            this.nextCommand = nextCommand;
        }

        void ICommand.Do()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICommand { void Do(); }
    public interface IChainCommand<TCurr, TNext> : IChainableCommand { }
    public interface IChainableCommand : ICommand { }

    public class SampleCommand : ICommand, IChainableCommand
    {
        public void Do() { Console.WriteLine( "SampleCommand"); }
    }

    public class SampleCommand1 : ICommand, IChainableCommand
    {
        public void Do() { Console.WriteLine( "SampleCommand1"); }
    }

    public static class CommandExtension
    {
        public static ChainCommand<TCurrent, TNext> ConcatCommand<TCurrent, TNext>(this TCurrent currentCommand, TNext nextCommand)
            where TCurrent : IChainableCommand
            where TNext : IChainableCommand
        {
            return new ChainCommand<TCurrent, TNext>(currentCommand, nextCommand);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            //var c0 = new Class0();
            //var c1 = new Class1();

            //var c3 = new Class3();

            ////c3.test1(c0);
            //c3.test1(c1);

            ////Command comm = new Command();
            ////Command<string> comm1 = new Command<String>();

            ////c3.test1(comm);
            ////c3.test1(comm1);

            var command1 = new SampleCommand();
            var command2 = new SampleCommand1();
            var command3 = new SampleCommand()
                                  .ConcatCommand(new SampleCommand1());

            var command4 = new SampleCommand()
                                    .ConcatCommand(
                                                    new SampleCommand1().ConcatCommand(new SampleCommand())
                                                    );
            var c3 = new Class3();

            c3.test1(command1);
            c3.test1(command2);
            c3.test1(command3);
            c3.test1(command4);

        }
    }
}

