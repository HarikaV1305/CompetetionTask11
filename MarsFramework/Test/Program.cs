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
                


                ManageListings mangeobj1 = new ManageListings();
                mangeobj1.ValidateAddshareskill();
                mangeobj1.Editshareskill();
                mangeobj1.Validateupdateskill();
                mangeobj1.Deleteshareskill();
                mangeobj1.Validatedeleteskill();
                mangeobj1.Addskillurlvalidate();


            }
        }
    }
}