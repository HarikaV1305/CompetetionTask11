using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test()
            {
                ShareSkill shareskillobj = new ShareSkill();
                shareskillobj.EnterShareSkill();



            }
        }
    }
}