using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.IO;

namespace CnnTests
{
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver = new FirefoxDriver();
            baseURL = "http://www.cnn.com/";
            verificationErrors = new StringBuilder();

            //DesiredCapabilities capabilities = new DesiredCapabilities();
            //capabilities = DesiredCapabilities.Chrome();
            //capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            //capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            //driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void test0() { TestCode(); }
        [Test]
        public void test1() { TestCode(); }
        [Test]
        public void test2() { TestCode(); }

        #region more tests up to 999
        [Test]
        public void test3() { TestCode(); }
        [Test]
        public void test4() { TestCode(); }
        [Test]
        public void test5() { TestCode(); }
        [Test]
        public void test6() { TestCode(); }
        [Test]
        public void test7() { TestCode(); }
        [Test]
        public void test8() { TestCode(); }
        [Test]
        public void test9() { TestCode(); }
        [Test]
        public void test10() { TestCode(); }
        [Test]
        public void test11() { TestCode(); }
        [Test]
        public void test12() { TestCode(); }
        [Test]
        public void test13() { TestCode(); }
        [Test]
        public void test14() { TestCode(); }
        [Test]
        public void test15() { TestCode(); }
        [Test]
        public void test16() { TestCode(); }
        [Test]
        public void test17() { TestCode(); }
        [Test]
        public void test18() { TestCode(); }
        [Test]
        public void test19() { TestCode(); }
        [Test]
        public void test20() { TestCode(); }
        [Test]
        public void test21() { TestCode(); }
        [Test]
        public void test22() { TestCode(); }
        [Test]
        public void test23() { TestCode(); }
        [Test]
        public void test24() { TestCode(); }
        [Test]
        public void test25() { TestCode(); }
        [Test]
        public void test26() { TestCode(); }
        [Test]
        public void test27() { TestCode(); }
        [Test]
        public void test28() { TestCode(); }
        [Test]
        public void test29() { TestCode(); }
        [Test]
        public void test30() { TestCode(); }
        [Test]
        public void test31() { TestCode(); }
        [Test]
        public void test32() { TestCode(); }
        [Test]
        public void test33() { TestCode(); }
        [Test]
        public void test34() { TestCode(); }
        [Test]
        public void test35() { TestCode(); }
        [Test]
        public void test36() { TestCode(); }
        [Test]
        public void test37() { TestCode(); }
        [Test]
        public void test38() { TestCode(); }
        [Test]
        public void test39() { TestCode(); }
        [Test]
        public void test40() { TestCode(); }
        [Test]
        public void test41() { TestCode(); }
        [Test]
        public void test42() { TestCode(); }
        [Test]
        public void test43() { TestCode(); }
        [Test]
        public void test44() { TestCode(); }
        [Test]
        public void test45() { TestCode(); }
        [Test]
        public void test46() { TestCode(); }
        [Test]
        public void test47() { TestCode(); }
        [Test]
        public void test48() { TestCode(); }
        [Test]
        public void test49() { TestCode(); }
        [Test]
        public void test50() { TestCode(); }
        [Test]
        public void test51() { TestCode(); }
        [Test]
        public void test52() { TestCode(); }
        [Test]
        public void test53() { TestCode(); }
        [Test]
        public void test54() { TestCode(); }
        [Test]
        public void test55() { TestCode(); }
        [Test]
        public void test56() { TestCode(); }
        [Test]
        public void test57() { TestCode(); }
        [Test]
        public void test58() { TestCode(); }
        [Test]
        public void test59() { TestCode(); }
        [Test]
        public void test60() { TestCode(); }
        [Test]
        public void test61() { TestCode(); }
        [Test]
        public void test62() { TestCode(); }
        [Test]
        public void test63() { TestCode(); }
        [Test]
        public void test64() { TestCode(); }
        [Test]
        public void test65() { TestCode(); }
        [Test]
        public void test66() { TestCode(); }
        [Test]
        public void test67() { TestCode(); }
        [Test]
        public void test68() { TestCode(); }
        [Test]
        public void test69() { TestCode(); }
        [Test]
        public void test70() { TestCode(); }
        [Test]
        public void test71() { TestCode(); }
        [Test]
        public void test72() { TestCode(); }
        [Test]
        public void test73() { TestCode(); }
        [Test]
        public void test74() { TestCode(); }
        [Test]
        public void test75() { TestCode(); }
        [Test]
        public void test76() { TestCode(); }
        [Test]
        public void test77() { TestCode(); }
        [Test]
        public void test78() { TestCode(); }
        [Test]
        public void test79() { TestCode(); }
        [Test]
        public void test80() { TestCode(); }
        [Test]
        public void test81() { TestCode(); }
        [Test]
        public void test82() { TestCode(); }
        [Test]
        public void test83() { TestCode(); }
        [Test]
        public void test84() { TestCode(); }
        [Test]
        public void test85() { TestCode(); }
        [Test]
        public void test86() { TestCode(); }
        [Test]
        public void test87() { TestCode(); }
        [Test]
        public void test88() { TestCode(); }
        [Test]
        public void test89() { TestCode(); }
        [Test]
        public void test90() { TestCode(); }
        [Test]
        public void test91() { TestCode(); }
        [Test]
        public void test92() { TestCode(); }
        [Test]
        public void test93() { TestCode(); }
        [Test]
        public void test94() { TestCode(); }
        [Test]
        public void test95() { TestCode(); }
        [Test]
        public void test96() { TestCode(); }
        [Test]
        public void test97() { TestCode(); }
        [Test]
        public void test98() { TestCode(); }
        [Test]
        public void test99() { TestCode(); }
        [Test]
        public void test100() { TestCode(); }
        [Test]
        public void test101() { TestCode(); }
        [Test]
        public void test102() { TestCode(); }
        [Test]
        public void test103() { TestCode(); }
        [Test]
        public void test104() { TestCode(); }
        [Test]
        public void test105() { TestCode(); }
        [Test]
        public void test106() { TestCode(); }
        [Test]
        public void test107() { TestCode(); }
        [Test]
        public void test108() { TestCode(); }
        [Test]
        public void test109() { TestCode(); }
        [Test]
        public void test110() { TestCode(); }
        [Test]
        public void test111() { TestCode(); }
        [Test]
        public void test112() { TestCode(); }
        [Test]
        public void test113() { TestCode(); }
        [Test]
        public void test114() { TestCode(); }
        [Test]
        public void test115() { TestCode(); }
        [Test]
        public void test116() { TestCode(); }
        [Test]
        public void test117() { TestCode(); }
        [Test]
        public void test118() { TestCode(); }
        [Test]
        public void test119() { TestCode(); }
        [Test]
        public void test120() { TestCode(); }
        [Test]
        public void test121() { TestCode(); }
        [Test]
        public void test122() { TestCode(); }
        [Test]
        public void test123() { TestCode(); }
        [Test]
        public void test124() { TestCode(); }
        [Test]
        public void test125() { TestCode(); }
        [Test]
        public void test126() { TestCode(); }
        [Test]
        public void test127() { TestCode(); }
        [Test]
        public void test128() { TestCode(); }
        [Test]
        public void test129() { TestCode(); }
        [Test]
        public void test130() { TestCode(); }
        [Test]
        public void test131() { TestCode(); }
        [Test]
        public void test132() { TestCode(); }
        [Test]
        public void test133() { TestCode(); }
        [Test]
        public void test134() { TestCode(); }
        [Test]
        public void test135() { TestCode(); }
        [Test]
        public void test136() { TestCode(); }
        [Test]
        public void test137() { TestCode(); }
        [Test]
        public void test138() { TestCode(); }
        [Test]
        public void test139() { TestCode(); }
        [Test]
        public void test140() { TestCode(); }
        [Test]
        public void test141() { TestCode(); }
        [Test]
        public void test142() { TestCode(); }
        [Test]
        public void test143() { TestCode(); }
        [Test]
        public void test144() { TestCode(); }
        [Test]
        public void test145() { TestCode(); }
        [Test]
        public void test146() { TestCode(); }
        [Test]
        public void test147() { TestCode(); }
        [Test]
        public void test148() { TestCode(); }
        [Test]
        public void test149() { TestCode(); }
        [Test]
        public void test150() { TestCode(); }
        [Test]
        public void test151() { TestCode(); }
        [Test]
        public void test152() { TestCode(); }
        [Test]
        public void test153() { TestCode(); }
        [Test]
        public void test154() { TestCode(); }
        [Test]
        public void test155() { TestCode(); }
        [Test]
        public void test156() { TestCode(); }
        [Test]
        public void test157() { TestCode(); }
        [Test]
        public void test158() { TestCode(); }
        [Test]
        public void test159() { TestCode(); }
        [Test]
        public void test160() { TestCode(); }
        [Test]
        public void test161() { TestCode(); }
        [Test]
        public void test162() { TestCode(); }
        [Test]
        public void test163() { TestCode(); }
        [Test]
        public void test164() { TestCode(); }
        [Test]
        public void test165() { TestCode(); }
        [Test]
        public void test166() { TestCode(); }
        [Test]
        public void test167() { TestCode(); }
        [Test]
        public void test168() { TestCode(); }
        [Test]
        public void test169() { TestCode(); }
        [Test]
        public void test170() { TestCode(); }
        [Test]
        public void test171() { TestCode(); }
        [Test]
        public void test172() { TestCode(); }
        [Test]
        public void test173() { TestCode(); }
        [Test]
        public void test174() { TestCode(); }
        [Test]
        public void test175() { TestCode(); }
        [Test]
        public void test176() { TestCode(); }
        [Test]
        public void test177() { TestCode(); }
        [Test]
        public void test178() { TestCode(); }
        [Test]
        public void test179() { TestCode(); }
        [Test]
        public void test180() { TestCode(); }
        [Test]
        public void test181() { TestCode(); }
        [Test]
        public void test182() { TestCode(); }
        [Test]
        public void test183() { TestCode(); }
        [Test]
        public void test184() { TestCode(); }
        [Test]
        public void test185() { TestCode(); }
        [Test]
        public void test186() { TestCode(); }
        [Test]
        public void test187() { TestCode(); }
        [Test]
        public void test188() { TestCode(); }
        [Test]
        public void test189() { TestCode(); }
        [Test]
        public void test190() { TestCode(); }
        [Test]
        public void test191() { TestCode(); }
        [Test]
        public void test192() { TestCode(); }
        [Test]
        public void test193() { TestCode(); }
        [Test]
        public void test194() { TestCode(); }
        [Test]
        public void test195() { TestCode(); }
        [Test]
        public void test196() { TestCode(); }
        [Test]
        public void test197() { TestCode(); }
        [Test]
        public void test198() { TestCode(); }
        [Test]
        public void test199() { TestCode(); }
        [Test]
        public void test200() { TestCode(); }
        [Test]
        public void test201() { TestCode(); }
        [Test]
        public void test202() { TestCode(); }
        [Test]
        public void test203() { TestCode(); }
        [Test]
        public void test204() { TestCode(); }
        [Test]
        public void test205() { TestCode(); }
        [Test]
        public void test206() { TestCode(); }
        [Test]
        public void test207() { TestCode(); }
        [Test]
        public void test208() { TestCode(); }
        [Test]
        public void test209() { TestCode(); }
        [Test]
        public void test210() { TestCode(); }
        [Test]
        public void test211() { TestCode(); }
        [Test]
        public void test212() { TestCode(); }
        [Test]
        public void test213() { TestCode(); }
        [Test]
        public void test214() { TestCode(); }
        [Test]
        public void test215() { TestCode(); }
        [Test]
        public void test216() { TestCode(); }
        [Test]
        public void test217() { TestCode(); }
        [Test]
        public void test218() { TestCode(); }
        [Test]
        public void test219() { TestCode(); }
        [Test]
        public void test220() { TestCode(); }
        [Test]
        public void test221() { TestCode(); }
        [Test]
        public void test222() { TestCode(); }
        [Test]
        public void test223() { TestCode(); }
        [Test]
        public void test224() { TestCode(); }
        [Test]
        public void test225() { TestCode(); }
        [Test]
        public void test226() { TestCode(); }
        [Test]
        public void test227() { TestCode(); }
        [Test]
        public void test228() { TestCode(); }
        [Test]
        public void test229() { TestCode(); }
        [Test]
        public void test230() { TestCode(); }
        [Test]
        public void test231() { TestCode(); }
        [Test]
        public void test232() { TestCode(); }
        [Test]
        public void test233() { TestCode(); }
        [Test]
        public void test234() { TestCode(); }
        [Test]
        public void test235() { TestCode(); }
        [Test]
        public void test236() { TestCode(); }
        [Test]
        public void test237() { TestCode(); }
        [Test]
        public void test238() { TestCode(); }
        [Test]
        public void test239() { TestCode(); }
        [Test]
        public void test240() { TestCode(); }
        [Test]
        public void test241() { TestCode(); }
        [Test]
        public void test242() { TestCode(); }
        [Test]
        public void test243() { TestCode(); }
        [Test]
        public void test244() { TestCode(); }
        [Test]
        public void test245() { TestCode(); }
        [Test]
        public void test246() { TestCode(); }
        [Test]
        public void test247() { TestCode(); }
        [Test]
        public void test248() { TestCode(); }
        [Test]
        public void test249() { TestCode(); }
        [Test]
        public void test250() { TestCode(); }
        [Test]
        public void test251() { TestCode(); }
        [Test]
        public void test252() { TestCode(); }
        [Test]
        public void test253() { TestCode(); }
        [Test]
        public void test254() { TestCode(); }
        [Test]
        public void test255() { TestCode(); }
        [Test]
        public void test256() { TestCode(); }
        [Test]
        public void test257() { TestCode(); }
        [Test]
        public void test258() { TestCode(); }
        [Test]
        public void test259() { TestCode(); }
        [Test]
        public void test260() { TestCode(); }
        [Test]
        public void test261() { TestCode(); }
        [Test]
        public void test262() { TestCode(); }
        [Test]
        public void test263() { TestCode(); }
        [Test]
        public void test264() { TestCode(); }
        [Test]
        public void test265() { TestCode(); }
        [Test]
        public void test266() { TestCode(); }
        [Test]
        public void test267() { TestCode(); }
        [Test]
        public void test268() { TestCode(); }
        [Test]
        public void test269() { TestCode(); }
        [Test]
        public void test270() { TestCode(); }
        [Test]
        public void test271() { TestCode(); }
        [Test]
        public void test272() { TestCode(); }
        [Test]
        public void test273() { TestCode(); }
        [Test]
        public void test274() { TestCode(); }
        [Test]
        public void test275() { TestCode(); }
        [Test]
        public void test276() { TestCode(); }
        [Test]
        public void test277() { TestCode(); }
        [Test]
        public void test278() { TestCode(); }
        [Test]
        public void test279() { TestCode(); }
        [Test]
        public void test280() { TestCode(); }
        [Test]
        public void test281() { TestCode(); }
        [Test]
        public void test282() { TestCode(); }
        [Test]
        public void test283() { TestCode(); }
        [Test]
        public void test284() { TestCode(); }
        [Test]
        public void test285() { TestCode(); }
        [Test]
        public void test286() { TestCode(); }
        [Test]
        public void test287() { TestCode(); }
        [Test]
        public void test288() { TestCode(); }
        [Test]
        public void test289() { TestCode(); }
        [Test]
        public void test290() { TestCode(); }
        [Test]
        public void test291() { TestCode(); }
        [Test]
        public void test292() { TestCode(); }
        [Test]
        public void test293() { TestCode(); }
        [Test]
        public void test294() { TestCode(); }
        [Test]
        public void test295() { TestCode(); }
        [Test]
        public void test296() { TestCode(); }
        [Test]
        public void test297() { TestCode(); }
        [Test]
        public void test298() { TestCode(); }
        [Test]
        public void test299() { TestCode(); }
        [Test]
        public void test300() { TestCode(); }
        [Test]
        public void test301() { TestCode(); }
        [Test]
        public void test302() { TestCode(); }
        [Test]
        public void test303() { TestCode(); }
        [Test]
        public void test304() { TestCode(); }
        [Test]
        public void test305() { TestCode(); }
        [Test]
        public void test306() { TestCode(); }
        [Test]
        public void test307() { TestCode(); }
        [Test]
        public void test308() { TestCode(); }
        [Test]
        public void test309() { TestCode(); }
        [Test]
        public void test310() { TestCode(); }
        [Test]
        public void test311() { TestCode(); }
        [Test]
        public void test312() { TestCode(); }
        [Test]
        public void test313() { TestCode(); }
        [Test]
        public void test314() { TestCode(); }
        [Test]
        public void test315() { TestCode(); }
        [Test]
        public void test316() { TestCode(); }
        [Test]
        public void test317() { TestCode(); }
        [Test]
        public void test318() { TestCode(); }
        [Test]
        public void test319() { TestCode(); }
        [Test]
        public void test320() { TestCode(); }
        [Test]
        public void test321() { TestCode(); }
        [Test]
        public void test322() { TestCode(); }
        [Test]
        public void test323() { TestCode(); }
        [Test]
        public void test324() { TestCode(); }
        [Test]
        public void test325() { TestCode(); }
        [Test]
        public void test326() { TestCode(); }
        [Test]
        public void test327() { TestCode(); }
        [Test]
        public void test328() { TestCode(); }
        [Test]
        public void test329() { TestCode(); }
        [Test]
        public void test330() { TestCode(); }
        [Test]
        public void test331() { TestCode(); }
        [Test]
        public void test332() { TestCode(); }
        [Test]
        public void test333() { TestCode(); }
        [Test]
        public void test334() { TestCode(); }
        [Test]
        public void test335() { TestCode(); }
        [Test]
        public void test336() { TestCode(); }
        [Test]
        public void test337() { TestCode(); }
        [Test]
        public void test338() { TestCode(); }
        [Test]
        public void test339() { TestCode(); }
        [Test]
        public void test340() { TestCode(); }
        [Test]
        public void test341() { TestCode(); }
        [Test]
        public void test342() { TestCode(); }
        [Test]
        public void test343() { TestCode(); }
        [Test]
        public void test344() { TestCode(); }
        [Test]
        public void test345() { TestCode(); }
        [Test]
        public void test346() { TestCode(); }
        [Test]
        public void test347() { TestCode(); }
        [Test]
        public void test348() { TestCode(); }
        [Test]
        public void test349() { TestCode(); }
        [Test]
        public void test350() { TestCode(); }
        [Test]
        public void test351() { TestCode(); }
        [Test]
        public void test352() { TestCode(); }
        [Test]
        public void test353() { TestCode(); }
        [Test]
        public void test354() { TestCode(); }
        [Test]
        public void test355() { TestCode(); }
        [Test]
        public void test356() { TestCode(); }
        [Test]
        public void test357() { TestCode(); }
        [Test]
        public void test358() { TestCode(); }
        [Test]
        public void test359() { TestCode(); }
        [Test]
        public void test360() { TestCode(); }
        [Test]
        public void test361() { TestCode(); }
        [Test]
        public void test362() { TestCode(); }
        [Test]
        public void test363() { TestCode(); }
        [Test]
        public void test364() { TestCode(); }
        [Test]
        public void test365() { TestCode(); }
        [Test]
        public void test366() { TestCode(); }
        [Test]
        public void test367() { TestCode(); }
        [Test]
        public void test368() { TestCode(); }
        [Test]
        public void test369() { TestCode(); }
        [Test]
        public void test370() { TestCode(); }
        [Test]
        public void test371() { TestCode(); }
        [Test]
        public void test372() { TestCode(); }
        [Test]
        public void test373() { TestCode(); }
        [Test]
        public void test374() { TestCode(); }
        [Test]
        public void test375() { TestCode(); }
        [Test]
        public void test376() { TestCode(); }
        [Test]
        public void test377() { TestCode(); }
        [Test]
        public void test378() { TestCode(); }
        [Test]
        public void test379() { TestCode(); }
        [Test]
        public void test380() { TestCode(); }
        [Test]
        public void test381() { TestCode(); }
        [Test]
        public void test382() { TestCode(); }
        [Test]
        public void test383() { TestCode(); }
        [Test]
        public void test384() { TestCode(); }
        [Test]
        public void test385() { TestCode(); }
        [Test]
        public void test386() { TestCode(); }
        [Test]
        public void test387() { TestCode(); }
        [Test]
        public void test388() { TestCode(); }
        [Test]
        public void test389() { TestCode(); }
        [Test]
        public void test390() { TestCode(); }
        [Test]
        public void test391() { TestCode(); }
        [Test]
        public void test392() { TestCode(); }
        [Test]
        public void test393() { TestCode(); }
        [Test]
        public void test394() { TestCode(); }
        [Test]
        public void test395() { TestCode(); }
        [Test]
        public void test396() { TestCode(); }
        [Test]
        public void test397() { TestCode(); }
        [Test]
        public void test398() { TestCode(); }
        [Test]
        public void test399() { TestCode(); }
        [Test]
        public void test400() { TestCode(); }
        [Test]
        public void test401() { TestCode(); }
        [Test]
        public void test402() { TestCode(); }
        [Test]
        public void test403() { TestCode(); }
        [Test]
        public void test404() { TestCode(); }
        [Test]
        public void test405() { TestCode(); }
        [Test]
        public void test406() { TestCode(); }
        [Test]
        public void test407() { TestCode(); }
        [Test]
        public void test408() { TestCode(); }
        [Test]
        public void test409() { TestCode(); }
        [Test]
        public void test410() { TestCode(); }
        [Test]
        public void test411() { TestCode(); }
        [Test]
        public void test412() { TestCode(); }
        [Test]
        public void test413() { TestCode(); }
        [Test]
        public void test414() { TestCode(); }
        [Test]
        public void test415() { TestCode(); }
        [Test]
        public void test416() { TestCode(); }
        [Test]
        public void test417() { TestCode(); }
        [Test]
        public void test418() { TestCode(); }
        [Test]
        public void test419() { TestCode(); }
        [Test]
        public void test420() { TestCode(); }
        [Test]
        public void test421() { TestCode(); }
        [Test]
        public void test422() { TestCode(); }
        [Test]
        public void test423() { TestCode(); }
        [Test]
        public void test424() { TestCode(); }
        [Test]
        public void test425() { TestCode(); }
        [Test]
        public void test426() { TestCode(); }
        [Test]
        public void test427() { TestCode(); }
        [Test]
        public void test428() { TestCode(); }
        [Test]
        public void test429() { TestCode(); }
        [Test]
        public void test430() { TestCode(); }
        [Test]
        public void test431() { TestCode(); }
        [Test]
        public void test432() { TestCode(); }
        [Test]
        public void test433() { TestCode(); }
        [Test]
        public void test434() { TestCode(); }
        [Test]
        public void test435() { TestCode(); }
        [Test]
        public void test436() { TestCode(); }
        [Test]
        public void test437() { TestCode(); }
        [Test]
        public void test438() { TestCode(); }
        [Test]
        public void test439() { TestCode(); }
        [Test]
        public void test440() { TestCode(); }
        [Test]
        public void test441() { TestCode(); }
        [Test]
        public void test442() { TestCode(); }
        [Test]
        public void test443() { TestCode(); }
        [Test]
        public void test444() { TestCode(); }
        [Test]
        public void test445() { TestCode(); }
        [Test]
        public void test446() { TestCode(); }
        [Test]
        public void test447() { TestCode(); }
        [Test]
        public void test448() { TestCode(); }
        [Test]
        public void test449() { TestCode(); }
        [Test]
        public void test450() { TestCode(); }
        [Test]
        public void test451() { TestCode(); }
        [Test]
        public void test452() { TestCode(); }
        [Test]
        public void test453() { TestCode(); }
        [Test]
        public void test454() { TestCode(); }
        [Test]
        public void test455() { TestCode(); }
        [Test]
        public void test456() { TestCode(); }
        [Test]
        public void test457() { TestCode(); }
        [Test]
        public void test458() { TestCode(); }
        [Test]
        public void test459() { TestCode(); }
        [Test]
        public void test460() { TestCode(); }
        [Test]
        public void test461() { TestCode(); }
        [Test]
        public void test462() { TestCode(); }
        [Test]
        public void test463() { TestCode(); }
        [Test]
        public void test464() { TestCode(); }
        [Test]
        public void test465() { TestCode(); }
        [Test]
        public void test466() { TestCode(); }
        [Test]
        public void test467() { TestCode(); }
        [Test]
        public void test468() { TestCode(); }
        [Test]
        public void test469() { TestCode(); }
        [Test]
        public void test470() { TestCode(); }
        [Test]
        public void test471() { TestCode(); }
        [Test]
        public void test472() { TestCode(); }
        [Test]
        public void test473() { TestCode(); }
        [Test]
        public void test474() { TestCode(); }
        [Test]
        public void test475() { TestCode(); }
        [Test]
        public void test476() { TestCode(); }
        [Test]
        public void test477() { TestCode(); }
        [Test]
        public void test478() { TestCode(); }
        [Test]
        public void test479() { TestCode(); }
        [Test]
        public void test480() { TestCode(); }
        [Test]
        public void test481() { TestCode(); }
        [Test]
        public void test482() { TestCode(); }
        [Test]
        public void test483() { TestCode(); }
        [Test]
        public void test484() { TestCode(); }
        [Test]
        public void test485() { TestCode(); }
        [Test]
        public void test486() { TestCode(); }
        [Test]
        public void test487() { TestCode(); }
        [Test]
        public void test488() { TestCode(); }
        [Test]
        public void test489() { TestCode(); }
        [Test]
        public void test490() { TestCode(); }
        [Test]
        public void test491() { TestCode(); }
        [Test]
        public void test492() { TestCode(); }
        [Test]
        public void test493() { TestCode(); }
        [Test]
        public void test494() { TestCode(); }
        [Test]
        public void test495() { TestCode(); }
        [Test]
        public void test496() { TestCode(); }
        [Test]
        public void test497() { TestCode(); }
        [Test]
        public void test498() { TestCode(); }
        [Test]
        public void test499() { TestCode(); }
        [Test]
        public void test500() { TestCode(); }
        [Test]
        public void test501() { TestCode(); }
        [Test]
        public void test502() { TestCode(); }
        [Test]
        public void test503() { TestCode(); }
        [Test]
        public void test504() { TestCode(); }
        [Test]
        public void test505() { TestCode(); }
        [Test]
        public void test506() { TestCode(); }
        [Test]
        public void test507() { TestCode(); }
        [Test]
        public void test508() { TestCode(); }
        [Test]
        public void test509() { TestCode(); }
        [Test]
        public void test510() { TestCode(); }
        [Test]
        public void test511() { TestCode(); }
        [Test]
        public void test512() { TestCode(); }
        [Test]
        public void test513() { TestCode(); }
        [Test]
        public void test514() { TestCode(); }
        [Test]
        public void test515() { TestCode(); }
        [Test]
        public void test516() { TestCode(); }
        [Test]
        public void test517() { TestCode(); }
        [Test]
        public void test518() { TestCode(); }
        [Test]
        public void test519() { TestCode(); }
        [Test]
        public void test520() { TestCode(); }
        [Test]
        public void test521() { TestCode(); }
        [Test]
        public void test522() { TestCode(); }
        [Test]
        public void test523() { TestCode(); }
        [Test]
        public void test524() { TestCode(); }
        [Test]
        public void test525() { TestCode(); }
        [Test]
        public void test526() { TestCode(); }
        [Test]
        public void test527() { TestCode(); }
        [Test]
        public void test528() { TestCode(); }
        [Test]
        public void test529() { TestCode(); }
        [Test]
        public void test530() { TestCode(); }
        [Test]
        public void test531() { TestCode(); }
        [Test]
        public void test532() { TestCode(); }
        [Test]
        public void test533() { TestCode(); }
        [Test]
        public void test534() { TestCode(); }
        [Test]
        public void test535() { TestCode(); }
        [Test]
        public void test536() { TestCode(); }
        [Test]
        public void test537() { TestCode(); }
        [Test]
        public void test538() { TestCode(); }
        [Test]
        public void test539() { TestCode(); }
        [Test]
        public void test540() { TestCode(); }
        [Test]
        public void test541() { TestCode(); }
        [Test]
        public void test542() { TestCode(); }
        [Test]
        public void test543() { TestCode(); }
        [Test]
        public void test544() { TestCode(); }
        [Test]
        public void test545() { TestCode(); }
        [Test]
        public void test546() { TestCode(); }
        [Test]
        public void test547() { TestCode(); }
        [Test]
        public void test548() { TestCode(); }
        [Test]
        public void test549() { TestCode(); }
        [Test]
        public void test550() { TestCode(); }
        [Test]
        public void test551() { TestCode(); }
        [Test]
        public void test552() { TestCode(); }
        [Test]
        public void test553() { TestCode(); }
        [Test]
        public void test554() { TestCode(); }
        [Test]
        public void test555() { TestCode(); }
        [Test]
        public void test556() { TestCode(); }
        [Test]
        public void test557() { TestCode(); }
        [Test]
        public void test558() { TestCode(); }
        [Test]
        public void test559() { TestCode(); }
        [Test]
        public void test560() { TestCode(); }
        [Test]
        public void test561() { TestCode(); }
        [Test]
        public void test562() { TestCode(); }
        [Test]
        public void test563() { TestCode(); }
        [Test]
        public void test564() { TestCode(); }
        [Test]
        public void test565() { TestCode(); }
        [Test]
        public void test566() { TestCode(); }
        [Test]
        public void test567() { TestCode(); }
        [Test]
        public void test568() { TestCode(); }
        [Test]
        public void test569() { TestCode(); }
        [Test]
        public void test570() { TestCode(); }
        [Test]
        public void test571() { TestCode(); }
        [Test]
        public void test572() { TestCode(); }
        [Test]
        public void test573() { TestCode(); }
        [Test]
        public void test574() { TestCode(); }
        [Test]
        public void test575() { TestCode(); }
        [Test]
        public void test576() { TestCode(); }
        [Test]
        public void test577() { TestCode(); }
        [Test]
        public void test578() { TestCode(); }
        [Test]
        public void test579() { TestCode(); }
        [Test]
        public void test580() { TestCode(); }
        [Test]
        public void test581() { TestCode(); }
        [Test]
        public void test582() { TestCode(); }
        [Test]
        public void test583() { TestCode(); }
        [Test]
        public void test584() { TestCode(); }
        [Test]
        public void test585() { TestCode(); }
        [Test]
        public void test586() { TestCode(); }
        [Test]
        public void test587() { TestCode(); }
        [Test]
        public void test588() { TestCode(); }
        [Test]
        public void test589() { TestCode(); }
        [Test]
        public void test590() { TestCode(); }
        [Test]
        public void test591() { TestCode(); }
        [Test]
        public void test592() { TestCode(); }
        [Test]
        public void test593() { TestCode(); }
        [Test]
        public void test594() { TestCode(); }
        [Test]
        public void test595() { TestCode(); }
        [Test]
        public void test596() { TestCode(); }
        [Test]
        public void test597() { TestCode(); }
        [Test]
        public void test598() { TestCode(); }
        [Test]
        public void test599() { TestCode(); }
        [Test]
        public void test600() { TestCode(); }
        [Test]
        public void test601() { TestCode(); }
        [Test]
        public void test602() { TestCode(); }
        [Test]
        public void test603() { TestCode(); }
        [Test]
        public void test604() { TestCode(); }
        [Test]
        public void test605() { TestCode(); }
        [Test]
        public void test606() { TestCode(); }
        [Test]
        public void test607() { TestCode(); }
        [Test]
        public void test608() { TestCode(); }
        [Test]
        public void test609() { TestCode(); }
        [Test]
        public void test610() { TestCode(); }
        [Test]
        public void test611() { TestCode(); }
        [Test]
        public void test612() { TestCode(); }
        [Test]
        public void test613() { TestCode(); }
        [Test]
        public void test614() { TestCode(); }
        [Test]
        public void test615() { TestCode(); }
        [Test]
        public void test616() { TestCode(); }
        [Test]
        public void test617() { TestCode(); }
        [Test]
        public void test618() { TestCode(); }
        [Test]
        public void test619() { TestCode(); }
        [Test]
        public void test620() { TestCode(); }
        [Test]
        public void test621() { TestCode(); }
        [Test]
        public void test622() { TestCode(); }
        [Test]
        public void test623() { TestCode(); }
        [Test]
        public void test624() { TestCode(); }
        [Test]
        public void test625() { TestCode(); }
        [Test]
        public void test626() { TestCode(); }
        [Test]
        public void test627() { TestCode(); }
        [Test]
        public void test628() { TestCode(); }
        [Test]
        public void test629() { TestCode(); }
        [Test]
        public void test630() { TestCode(); }
        [Test]
        public void test631() { TestCode(); }
        [Test]
        public void test632() { TestCode(); }
        [Test]
        public void test633() { TestCode(); }
        [Test]
        public void test634() { TestCode(); }
        [Test]
        public void test635() { TestCode(); }
        [Test]
        public void test636() { TestCode(); }
        [Test]
        public void test637() { TestCode(); }
        [Test]
        public void test638() { TestCode(); }
        [Test]
        public void test639() { TestCode(); }
        [Test]
        public void test640() { TestCode(); }
        [Test]
        public void test641() { TestCode(); }
        [Test]
        public void test642() { TestCode(); }
        [Test]
        public void test643() { TestCode(); }
        [Test]
        public void test644() { TestCode(); }
        [Test]
        public void test645() { TestCode(); }
        [Test]
        public void test646() { TestCode(); }
        [Test]
        public void test647() { TestCode(); }
        [Test]
        public void test648() { TestCode(); }
        [Test]
        public void test649() { TestCode(); }
        [Test]
        public void test650() { TestCode(); }
        [Test]
        public void test651() { TestCode(); }
        [Test]
        public void test652() { TestCode(); }
        [Test]
        public void test653() { TestCode(); }
        [Test]
        public void test654() { TestCode(); }
        [Test]
        public void test655() { TestCode(); }
        [Test]
        public void test656() { TestCode(); }
        [Test]
        public void test657() { TestCode(); }
        [Test]
        public void test658() { TestCode(); }
        [Test]
        public void test659() { TestCode(); }
        [Test]
        public void test660() { TestCode(); }
        [Test]
        public void test661() { TestCode(); }
        [Test]
        public void test662() { TestCode(); }
        [Test]
        public void test663() { TestCode(); }
        [Test]
        public void test664() { TestCode(); }
        [Test]
        public void test665() { TestCode(); }
        [Test]
        public void test666() { TestCode(); }
        [Test]
        public void test667() { TestCode(); }
        [Test]
        public void test668() { TestCode(); }
        [Test]
        public void test669() { TestCode(); }
        [Test]
        public void test670() { TestCode(); }
        [Test]
        public void test671() { TestCode(); }
        [Test]
        public void test672() { TestCode(); }
        [Test]
        public void test673() { TestCode(); }
        [Test]
        public void test674() { TestCode(); }
        [Test]
        public void test675() { TestCode(); }
        [Test]
        public void test676() { TestCode(); }
        [Test]
        public void test677() { TestCode(); }
        [Test]
        public void test678() { TestCode(); }
        [Test]
        public void test679() { TestCode(); }
        [Test]
        public void test680() { TestCode(); }
        [Test]
        public void test681() { TestCode(); }
        [Test]
        public void test682() { TestCode(); }
        [Test]
        public void test683() { TestCode(); }
        [Test]
        public void test684() { TestCode(); }
        [Test]
        public void test685() { TestCode(); }
        [Test]
        public void test686() { TestCode(); }
        [Test]
        public void test687() { TestCode(); }
        [Test]
        public void test688() { TestCode(); }
        [Test]
        public void test689() { TestCode(); }
        [Test]
        public void test690() { TestCode(); }
        [Test]
        public void test691() { TestCode(); }
        [Test]
        public void test692() { TestCode(); }
        [Test]
        public void test693() { TestCode(); }
        [Test]
        public void test694() { TestCode(); }
        [Test]
        public void test695() { TestCode(); }
        [Test]
        public void test696() { TestCode(); }
        [Test]
        public void test697() { TestCode(); }
        [Test]
        public void test698() { TestCode(); }
        [Test]
        public void test699() { TestCode(); }
        [Test]
        public void test700() { TestCode(); }
        [Test]
        public void test701() { TestCode(); }
        [Test]
        public void test702() { TestCode(); }
        [Test]
        public void test703() { TestCode(); }
        [Test]
        public void test704() { TestCode(); }
        [Test]
        public void test705() { TestCode(); }
        [Test]
        public void test706() { TestCode(); }
        [Test]
        public void test707() { TestCode(); }
        [Test]
        public void test708() { TestCode(); }
        [Test]
        public void test709() { TestCode(); }
        [Test]
        public void test710() { TestCode(); }
        [Test]
        public void test711() { TestCode(); }
        [Test]
        public void test712() { TestCode(); }
        [Test]
        public void test713() { TestCode(); }
        [Test]
        public void test714() { TestCode(); }
        [Test]
        public void test715() { TestCode(); }
        [Test]
        public void test716() { TestCode(); }
        [Test]
        public void test717() { TestCode(); }
        [Test]
        public void test718() { TestCode(); }
        [Test]
        public void test719() { TestCode(); }
        [Test]
        public void test720() { TestCode(); }
        [Test]
        public void test721() { TestCode(); }
        [Test]
        public void test722() { TestCode(); }
        [Test]
        public void test723() { TestCode(); }
        [Test]
        public void test724() { TestCode(); }
        [Test]
        public void test725() { TestCode(); }
        [Test]
        public void test726() { TestCode(); }
        [Test]
        public void test727() { TestCode(); }
        [Test]
        public void test728() { TestCode(); }
        [Test]
        public void test729() { TestCode(); }
        [Test]
        public void test730() { TestCode(); }
        [Test]
        public void test731() { TestCode(); }
        [Test]
        public void test732() { TestCode(); }
        [Test]
        public void test733() { TestCode(); }
        [Test]
        public void test734() { TestCode(); }
        [Test]
        public void test735() { TestCode(); }
        [Test]
        public void test736() { TestCode(); }
        [Test]
        public void test737() { TestCode(); }
        [Test]
        public void test738() { TestCode(); }
        [Test]
        public void test739() { TestCode(); }
        [Test]
        public void test740() { TestCode(); }
        [Test]
        public void test741() { TestCode(); }
        [Test]
        public void test742() { TestCode(); }
        [Test]
        public void test743() { TestCode(); }
        [Test]
        public void test744() { TestCode(); }
        [Test]
        public void test745() { TestCode(); }
        [Test]
        public void test746() { TestCode(); }
        [Test]
        public void test747() { TestCode(); }
        [Test]
        public void test748() { TestCode(); }
        [Test]
        public void test749() { TestCode(); }
        [Test]
        public void test750() { TestCode(); }
        [Test]
        public void test751() { TestCode(); }
        [Test]
        public void test752() { TestCode(); }
        [Test]
        public void test753() { TestCode(); }
        [Test]
        public void test754() { TestCode(); }
        [Test]
        public void test755() { TestCode(); }
        [Test]
        public void test756() { TestCode(); }
        [Test]
        public void test757() { TestCode(); }
        [Test]
        public void test758() { TestCode(); }
        [Test]
        public void test759() { TestCode(); }
        [Test]
        public void test760() { TestCode(); }
        [Test]
        public void test761() { TestCode(); }
        [Test]
        public void test762() { TestCode(); }
        [Test]
        public void test763() { TestCode(); }
        [Test]
        public void test764() { TestCode(); }
        [Test]
        public void test765() { TestCode(); }
        [Test]
        public void test766() { TestCode(); }
        [Test]
        public void test767() { TestCode(); }
        [Test]
        public void test768() { TestCode(); }
        [Test]
        public void test769() { TestCode(); }
        [Test]
        public void test770() { TestCode(); }
        [Test]
        public void test771() { TestCode(); }
        [Test]
        public void test772() { TestCode(); }
        [Test]
        public void test773() { TestCode(); }
        [Test]
        public void test774() { TestCode(); }
        [Test]
        public void test775() { TestCode(); }
        [Test]
        public void test776() { TestCode(); }
        [Test]
        public void test777() { TestCode(); }
        [Test]
        public void test778() { TestCode(); }
        [Test]
        public void test779() { TestCode(); }
        [Test]
        public void test780() { TestCode(); }
        [Test]
        public void test781() { TestCode(); }
        [Test]
        public void test782() { TestCode(); }
        [Test]
        public void test783() { TestCode(); }
        [Test]
        public void test784() { TestCode(); }
        [Test]
        public void test785() { TestCode(); }
        [Test]
        public void test786() { TestCode(); }
        [Test]
        public void test787() { TestCode(); }
        [Test]
        public void test788() { TestCode(); }
        [Test]
        public void test789() { TestCode(); }
        [Test]
        public void test790() { TestCode(); }
        [Test]
        public void test791() { TestCode(); }
        [Test]
        public void test792() { TestCode(); }
        [Test]
        public void test793() { TestCode(); }
        [Test]
        public void test794() { TestCode(); }
        [Test]
        public void test795() { TestCode(); }
        [Test]
        public void test796() { TestCode(); }
        [Test]
        public void test797() { TestCode(); }
        [Test]
        public void test798() { TestCode(); }
        [Test]
        public void test799() { TestCode(); }
        [Test]
        public void test800() { TestCode(); }
        [Test]
        public void test801() { TestCode(); }
        [Test]
        public void test802() { TestCode(); }
        [Test]
        public void test803() { TestCode(); }
        [Test]
        public void test804() { TestCode(); }
        [Test]
        public void test805() { TestCode(); }
        [Test]
        public void test806() { TestCode(); }
        [Test]
        public void test807() { TestCode(); }
        [Test]
        public void test808() { TestCode(); }
        [Test]
        public void test809() { TestCode(); }
        [Test]
        public void test810() { TestCode(); }
        [Test]
        public void test811() { TestCode(); }
        [Test]
        public void test812() { TestCode(); }
        [Test]
        public void test813() { TestCode(); }
        [Test]
        public void test814() { TestCode(); }
        [Test]
        public void test815() { TestCode(); }
        [Test]
        public void test816() { TestCode(); }
        [Test]
        public void test817() { TestCode(); }
        [Test]
        public void test818() { TestCode(); }
        [Test]
        public void test819() { TestCode(); }
        [Test]
        public void test820() { TestCode(); }
        [Test]
        public void test821() { TestCode(); }
        [Test]
        public void test822() { TestCode(); }
        [Test]
        public void test823() { TestCode(); }
        [Test]
        public void test824() { TestCode(); }
        [Test]
        public void test825() { TestCode(); }
        [Test]
        public void test826() { TestCode(); }
        [Test]
        public void test827() { TestCode(); }
        [Test]
        public void test828() { TestCode(); }
        [Test]
        public void test829() { TestCode(); }
        [Test]
        public void test830() { TestCode(); }
        [Test]
        public void test831() { TestCode(); }
        [Test]
        public void test832() { TestCode(); }
        [Test]
        public void test833() { TestCode(); }
        [Test]
        public void test834() { TestCode(); }
        [Test]
        public void test835() { TestCode(); }
        [Test]
        public void test836() { TestCode(); }
        [Test]
        public void test837() { TestCode(); }
        [Test]
        public void test838() { TestCode(); }
        [Test]
        public void test839() { TestCode(); }
        [Test]
        public void test840() { TestCode(); }
        [Test]
        public void test841() { TestCode(); }
        [Test]
        public void test842() { TestCode(); }
        [Test]
        public void test843() { TestCode(); }
        [Test]
        public void test844() { TestCode(); }
        [Test]
        public void test845() { TestCode(); }
        [Test]
        public void test846() { TestCode(); }
        [Test]
        public void test847() { TestCode(); }
        [Test]
        public void test848() { TestCode(); }
        [Test]
        public void test849() { TestCode(); }
        [Test]
        public void test850() { TestCode(); }
        [Test]
        public void test851() { TestCode(); }
        [Test]
        public void test852() { TestCode(); }
        [Test]
        public void test853() { TestCode(); }
        [Test]
        public void test854() { TestCode(); }
        [Test]
        public void test855() { TestCode(); }
        [Test]
        public void test856() { TestCode(); }
        [Test]
        public void test857() { TestCode(); }
        [Test]
        public void test858() { TestCode(); }
        [Test]
        public void test859() { TestCode(); }
        [Test]
        public void test860() { TestCode(); }
        [Test]
        public void test861() { TestCode(); }
        [Test]
        public void test862() { TestCode(); }
        [Test]
        public void test863() { TestCode(); }
        [Test]
        public void test864() { TestCode(); }
        [Test]
        public void test865() { TestCode(); }
        [Test]
        public void test866() { TestCode(); }
        [Test]
        public void test867() { TestCode(); }
        [Test]
        public void test868() { TestCode(); }
        [Test]
        public void test869() { TestCode(); }
        [Test]
        public void test870() { TestCode(); }
        [Test]
        public void test871() { TestCode(); }
        [Test]
        public void test872() { TestCode(); }
        [Test]
        public void test873() { TestCode(); }
        [Test]
        public void test874() { TestCode(); }
        [Test]
        public void test875() { TestCode(); }
        [Test]
        public void test876() { TestCode(); }
        [Test]
        public void test877() { TestCode(); }
        [Test]
        public void test878() { TestCode(); }
        [Test]
        public void test879() { TestCode(); }
        [Test]
        public void test880() { TestCode(); }
        [Test]
        public void test881() { TestCode(); }
        [Test]
        public void test882() { TestCode(); }
        [Test]
        public void test883() { TestCode(); }
        [Test]
        public void test884() { TestCode(); }
        [Test]
        public void test885() { TestCode(); }
        [Test]
        public void test886() { TestCode(); }
        [Test]
        public void test887() { TestCode(); }
        [Test]
        public void test888() { TestCode(); }
        [Test]
        public void test889() { TestCode(); }
        [Test]
        public void test890() { TestCode(); }
        [Test]
        public void test891() { TestCode(); }
        [Test]
        public void test892() { TestCode(); }
        [Test]
        public void test893() { TestCode(); }
        [Test]
        public void test894() { TestCode(); }
        [Test]
        public void test895() { TestCode(); }
        [Test]
        public void test896() { TestCode(); }
        [Test]
        public void test897() { TestCode(); }
        [Test]
        public void test898() { TestCode(); }
        [Test]
        public void test899() { TestCode(); }
        [Test]
        public void test900() { TestCode(); }
        [Test]
        public void test901() { TestCode(); }
        [Test]
        public void test902() { TestCode(); }
        [Test]
        public void test903() { TestCode(); }
        [Test]
        public void test904() { TestCode(); }
        [Test]
        public void test905() { TestCode(); }
        [Test]
        public void test906() { TestCode(); }
        [Test]
        public void test907() { TestCode(); }
        [Test]
        public void test908() { TestCode(); }
        [Test]
        public void test909() { TestCode(); }
        [Test]
        public void test910() { TestCode(); }
        [Test]
        public void test911() { TestCode(); }
        [Test]
        public void test912() { TestCode(); }
        [Test]
        public void test913() { TestCode(); }
        [Test]
        public void test914() { TestCode(); }
        [Test]
        public void test915() { TestCode(); }
        [Test]
        public void test916() { TestCode(); }
        [Test]
        public void test917() { TestCode(); }
        [Test]
        public void test918() { TestCode(); }
        [Test]
        public void test919() { TestCode(); }
        [Test]
        public void test920() { TestCode(); }
        [Test]
        public void test921() { TestCode(); }
        [Test]
        public void test922() { TestCode(); }
        [Test]
        public void test923() { TestCode(); }
        [Test]
        public void test924() { TestCode(); }
        [Test]
        public void test925() { TestCode(); }
        [Test]
        public void test926() { TestCode(); }
        [Test]
        public void test927() { TestCode(); }
        [Test]
        public void test928() { TestCode(); }
        [Test]
        public void test929() { TestCode(); }
        [Test]
        public void test930() { TestCode(); }
        [Test]
        public void test931() { TestCode(); }
        [Test]
        public void test932() { TestCode(); }
        [Test]
        public void test933() { TestCode(); }
        [Test]
        public void test934() { TestCode(); }
        [Test]
        public void test935() { TestCode(); }
        [Test]
        public void test936() { TestCode(); }
        [Test]
        public void test937() { TestCode(); }
        [Test]
        public void test938() { TestCode(); }
        [Test]
        public void test939() { TestCode(); }
        [Test]
        public void test940() { TestCode(); }
        [Test]
        public void test941() { TestCode(); }
        [Test]
        public void test942() { TestCode(); }
        [Test]
        public void test943() { TestCode(); }
        [Test]
        public void test944() { TestCode(); }
        [Test]
        public void test945() { TestCode(); }
        [Test]
        public void test946() { TestCode(); }
        [Test]
        public void test947() { TestCode(); }
        [Test]
        public void test948() { TestCode(); }
        [Test]
        public void test949() { TestCode(); }
        [Test]
        public void test950() { TestCode(); }
        [Test]
        public void test951() { TestCode(); }
        [Test]
        public void test952() { TestCode(); }
        [Test]
        public void test953() { TestCode(); }
        [Test]
        public void test954() { TestCode(); }
        [Test]
        public void test955() { TestCode(); }
        [Test]
        public void test956() { TestCode(); }
        [Test]
        public void test957() { TestCode(); }
        [Test]
        public void test958() { TestCode(); }
        [Test]
        public void test959() { TestCode(); }
        [Test]
        public void test960() { TestCode(); }
        [Test]
        public void test961() { TestCode(); }
        [Test]
        public void test962() { TestCode(); }
        [Test]
        public void test963() { TestCode(); }
        [Test]
        public void test964() { TestCode(); }
        [Test]
        public void test965() { TestCode(); }
        [Test]
        public void test966() { TestCode(); }
        [Test]
        public void test967() { TestCode(); }
        [Test]
        public void test968() { TestCode(); }
        [Test]
        public void test969() { TestCode(); }
        [Test]
        public void test970() { TestCode(); }
        [Test]
        public void test971() { TestCode(); }
        [Test]
        public void test972() { TestCode(); }
        [Test]
        public void test973() { TestCode(); }
        [Test]
        public void test974() { TestCode(); }
        [Test]
        public void test975() { TestCode(); }
        [Test]
        public void test976() { TestCode(); }
        [Test]
        public void test977() { TestCode(); }
        [Test]
        public void test978() { TestCode(); }
        [Test]
        public void test979() { TestCode(); }
        [Test]
        public void test980() { TestCode(); }
        [Test]
        public void test981() { TestCode(); }
        [Test]
        public void test982() { TestCode(); }
        [Test]
        public void test983() { TestCode(); }
        [Test]
        public void test984() { TestCode(); }
        [Test]
        public void test985() { TestCode(); }
        [Test]
        public void test986() { TestCode(); }
        [Test]
        public void test987() { TestCode(); }
        [Test]
        public void test988() { TestCode(); }
        [Test]
        public void test989() { TestCode(); }
        [Test]
        public void test990() { TestCode(); }
        [Test]
        public void test991() { TestCode(); }
        [Test]
        public void test992() { TestCode(); }
        [Test]
        public void test993() { TestCode(); }
        [Test]
        public void test994() { TestCode(); }
        [Test]
        public void test995() { TestCode(); }
        [Test]
        public void test996() { TestCode(); }
        [Test]
        public void test997() { TestCode(); }
        [Test]
        public void test998() { TestCode(); }
        [Test]
        public void test999() { TestCode(); }
        #endregion

        private void TestCode()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("U.S.")).Click();
            driver.FindElement(By.LinkText("World")).Click();
            driver.FindElement(By.LinkText("Politics")).Click();
            driver.FindElement(By.LinkText("Tech")).Click();
            driver.FindElement(By.LinkText("Health")).Click();
            driver.FindElement(By.LinkText("Entertainment")).Click();
            driver.FindElement(By.LinkText("Living")).Click();
            driver.FindElement(By.LinkText("Travel")).Click();
            Assert.Pass();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
