using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll1;
using ce103_hw4_cs_dll2;
using System.Text;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_1()
        {

            ce103_hw4_functions_csharp fi = new ce103_hw4_functions_csharp();
            int a = fi.ce103_fibonacciNumber_cs(11);

            Assert.AreEqual(a, 89);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_2()
        {
            ce103_hw4_functions_csharp fi = new ce103_hw4_functions_csharp();
            int a = fi.ce103_fibonacciNumber_cs(27);

            Assert.AreEqual(a, 196418);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_3()
        {
            ce103_hw4_functions_csharp fi = new ce103_hw4_functions_csharp();
            int a = fi.ce103_fibonacciNumber_cs(38);

            Assert.AreEqual(a, 39088169);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_2_test_1()
        {
            ce103_functions fi = new ce103_functions();
            int a = fi.ce103_fibonacciNumber_cs_2(39);

            Assert.AreEqual(a, 39088169);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_2_test_2()
        {
            ce103_functions fi = new ce103_functions();
            int a = fi.ce103_fibonacciNumber_cs_2(41);

            Assert.AreEqual(a, 102334155);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_2_test_3()
        {
            ce103_functions fi = new ce103_functions();
            int a = fi.ce103_fibonacciNumber_cs_2(39);

            Assert.AreEqual(a, 39088169);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_vs_cs_2_test_1()
        {
            ce103_functions cs2Fibonacci = new ce103_functions();
            ce103_hw4_functions_csharp csFibonacci = new ce103_hw4_functions_csharp();
            int cs = csFibonacci.ce103_fibonacciNumber_cs(18);
            int cs2 = cs2Fibonacci.ce103_fibonacciNumber_cs_2(19);

            Assert.AreEqual(cs, cs2);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_vs_cs_2_test_2()
        {
            ce103_functions cs2Fionacci = new ce103_functions();
            ce103_hw4_functions_csharp csFibonacci = new ce103_hw4_functions_csharp();
            int cs = csFibonacci.ce103_fibonacciNumber_cs(12);
            int cs2 = cs2Fionacci.ce103_fibonacciNumber_cs_2(13);

            Assert.AreEqual(cs, cs2);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_vs_cs_2_test_3()
        {
            ce103_functions cs2Fibonacci = new ce103_functions();
            ce103_hw4_functions_csharp csFibonacci = new ce103_hw4_functions_csharp();
            int cs = csFibonacci.ce103_fibonacciNumber_cs(49);
            int cs2 = cs2Fibonacci.ce103_fibonacciNumber_cs_2(50);

            Assert.AreEqual(cs, cs2);
        }

        [TestMethod]
        public void ce103_strrev_cs_test_1()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103_hw4_functions_csharp rev = new ce103_hw4_functions_csharp();

            string w = "homework";
            string w2 = "krowemoh";

            Assert.AreEqual(rev.ce103_strrev_cs(w), w2);
        }

        [TestMethod]
        public void ce103_strrev_cs_test_2()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103_hw4_functions_csharp rev = new ce103_hw4_functions_csharp();

            string w = "International";
            string w2 = "lanoitanretnI";

            Assert.AreEqual(rev.ce103_strrev_cs(w), w2);
        }

        [TestMethod]
        public void ce103_strrev_cs_test_3()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103_hw4_functions_csharp rev = new ce103_hw4_functions_csharp();

            string w = "Performance";
            string w2 = "ecnamrofreP";

            Assert.AreEqual(rev.ce103_strrev_cs(w), w2);
        }

    
        [TestMethod]
        public void ce103_strrev_cs_2_test_1()
        {
            ce103_functions rev2 = new ce103_functions();
            Assert.AreEqual(rev2.ce103_strrev_cs_2("Earth"), "htraE");
        }
        [TestMethod]
        public void ce103_strrev_cs_vs_cs_2_test_1()
        {
             ce103_hw4_functions_csharp rev = new  ce103_hw4_functions_csharp();
            ce103_functions rev2 = new ce103_functions();
            Assert.AreEqual(rev.ce103_strrev_cs("Desktop"), "potkseD", rev2.ce103_strrev_cs_2("Desktop"), "potkseD");
        }

        [TestMethod]
        public void ce103_strrev_cs_2_test_2()
        {
            ce103_functions rev2 = new ce103_functions();
            Assert.AreEqual(rev2.ce103_strrev_cs_2("Software Engineer"), "reenignE erawtfoS");
        }
        [TestMethod]
        public void ce103_strrev_cs_vs_cs_2_test_2()
        {
             ce103_hw4_functions_csharp rev = new  ce103_hw4_functions_csharp();
            ce103_functions rev2 = new ce103_functions();
            Assert.AreEqual(rev.ce103_strrev_cs("Computer Engineer"), "reenignE retupmoC", rev2.ce103_strrev_cs_2("Computer Engineer"), "reenignE retupmoC");
        }

        [TestMethod]
        public void ce103_strrev_cs_2_test_3()
        {
            ce103_functions rev2 = new ce103_functions();
            Assert.AreEqual(rev2.ce103_strrev_cs_2("Lock"), "kcoL");
        }
        [TestMethod]
        public void ce103_strrev_cs_vs_cs_2_test_3()
        {
             ce103_hw4_functions_csharp rev = new  ce103_hw4_functions_csharp();
            ce103_functions rev2 = new ce103_functions();
            Assert.AreEqual(rev.ce103_strrev_cs("CanYavuz"), "zuvaYnaC", rev2.ce103_strrev_cs_2("CanYavuz"), "zuvaYnaC");
        }

        [TestMethod]
        public void ce103_strlen_cs_test_1()
        {
            ce103_hw4_functions_csharp len = new ce103_hw4_functions_csharp();
            string w = "Hardware";

            int res = len.ce103_strlen_cs(w);
            Assert.AreEqual(res, 8);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_2()
        {
            ce103_hw4_functions_csharp len = new ce103_hw4_functions_csharp();
            string w = "Space";

            int res = len.ce103_strlen_cs(w);
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_3()
        {
            ce103_hw4_functions_csharp len = new ce103_hw4_functions_csharp();
            string w = "Enter";

            int res = len.ce103_strlen_cs(w);
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void ce103_strlen_cs_2_test_1()
        {
            ce103_functions len2 = new ce103_functions();
            string w = "Leopard";

            int res = len2.ce103_strlen_cs_2(w);
            Assert.AreEqual(res, 7);
        }

        [TestMethod]
        public void ce103_strlen_cs_2_test_2()
        {
            ce103_functions len2 = new ce103_functions();
            string w = "Linux";

            int res = len2.ce103_strlen_cs_2(w);
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void ce103_strlen_cs_2_test_3()
        {
            ce103_functions len2 = new ce103_functions();
            string w = "Dragon";

            int res = len2.ce103_strlen_cs_2(w);
            Assert.AreEqual(res, 6);
        }

        [TestMethod]
        public void ce103_strlen_cs_vs_cs_2_test_1()
        {
            ce103_functions len2 = new ce103_functions();
            ce103_hw4_functions_csharp len = new ce103_hw4_functions_csharp();
            string w = "Debug";

            int cs2 = len2.ce103_strlen_cs_2(w);
            int cs = len.ce103_strlen_cs(w);
            Assert.AreEqual(cs, cs2);
        }

        [TestMethod]
        public void ce103_strlen_cs_vs_cs_2_test_2()
        {
            ce103_functions len2 = new ce103_functions();
            ce103_hw4_functions_csharp len = new ce103_hw4_functions_csharp();
            string w = "Steel";

            int cs2 = len2.ce103_strlen_cs_2(w);
            int cs = len.ce103_strlen_cs(w);
            Assert.AreEqual(cs, cs2);
        }

        [TestMethod]
        public void ce103_strlen_cs_vs_cs_2_test_3()
        {
            ce103_functions len2 = new ce103_functions();
            ce103_hw4_functions_csharp len = new ce103_hw4_functions_csharp();
            string w = "Windows";

            int cs2 = len2.ce103_strlen_cs_2(w);
            int cs = len.ce103_strlen_cs(w);
            Assert.AreEqual(cs, cs2);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_1()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103_hw4_functions_csharp rev = new ce103_hw4_functions_csharp();
            string cat = "Hello";
            string cat2 = "Csharp";

            string res = "HelloCsharp";

            Assert.AreEqual(rev.ce103_strcat_cs(cat, cat2), res);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_2()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103_hw4_functions_csharp rev = new ce103_hw4_functions_csharp();
            string cat = "Visual";
            string cat2 = "Studio";

            string res = "VisualStudio";

            Assert.AreEqual(rev.ce103_strcat_cs(cat, cat2), res);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_3()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103_hw4_functions_csharp rev = new ce103_hw4_functions_csharp();
            string cat = "Microsoft";
            string cat2 = "Word";

            string result = "MicrosoftWord";

            Assert.AreEqual(rev.ce103_strcat_cs(cat, cat2), result);
        }
        [TestMethod]
        public void ce103_strcat_cs_2_test_1()
        {
            ce103_functions strcat = new ce103_functions();
            Assert.AreEqual(strcat.ce103_strcat_cs_2("Good", "Day"), "GoodDay");
        }
        [TestMethod]
        public void ce103_strcat_cs_vs_cs_2_test_1()
        {
            ce103_hw4_functions_csharp strcat = new ce103_hw4_functions_csharp();
            ce103_functions Strcat = new ce103_functions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hello", "Everyone"), "HelloEveryone", Strcat.ce103_strcat_cs_2("Hello", "Everyone"), "HelloEveryone");
        }

        [TestMethod]
        public void ce103_strcat_cs_2_test_2()
        {
            ce103_functions strcat = new ce103_functions();
            Assert.AreEqual(strcat.ce103_strcat_cs_2("Cooler", "Boost"), "CoolerBoost");
        }
        [TestMethod]
        public void ce103_strcat_cs_vs_cs_2_test_2()
        {
            ce103_hw4_functions_csharp strcat = new ce103_hw4_functions_csharp();
            ce103_functions Strcat2 = new ce103_functions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Thin", "Bezel"), "ThinBezel", Strcat2.ce103_strcat_cs_2("Thin", "Bezel"), "ThinBezel");
        }

        [TestMethod]
        public void ce103_strcat_cs_2_test_3()
        {
            ce103_functions strcat2 = new ce103_functions();
            Assert.AreEqual(strcat2.ce103_strcat_cs_2("Steel", "Series"), "SteelSeries");
        }
       
     
        
        [TestMethod]
        public void ce103_strcat_cs_vs_cs_2_test_3()
        {
            ce103_hw4_functions_csharp strcat = new ce103_hw4_functions_csharp();
            ce103_functions Strcat2 = new ce103_functions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Error", "List"), "ErrorList", Strcat2.ce103_strcat_cs_2("Error", "List"), "ErrorList");
        }

        [TestMethod]
        public void Ce103_strcmp_cs_vs_cs_2_test1()
        {
            ce103_hw4_functions_csharp strcmp = new ce103_hw4_functions_csharp();
            const string cmp = "gamingmode";
            const string cmp2 = "gamingmode";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(cmp, cmp2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test2()
        {
            ce103_hw4_functions_csharp strcmp = new ce103_hw4_functions_csharp();
            const string cmp = "gaming";
            const string cmp2 = "mode";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs(cmp, cmp2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test3()
        {
            ce103_hw4_functions_csharp strcmp = new ce103_hw4_functions_csharp();
            const string cmp = "nvidia";
            const string cmp2 = "nvidia";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(cmp, cmp2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_2_test1()
        {
            ce103_functions strcmp = new ce103_functions();
            const string cmp = "master";
            const string cmp2 = "master";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_2(cmp, cmp2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_2_test2()
        {
            ce103_functions strcmp = new ce103_functions();
            const string cmp = "file";
            const string cmp2 = "file";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_2(cmp, cmp2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_2_test3()
        {
            ce103_functions strcmp = new ce103_functions();
            const string cmp = "linkedln";
            const string cmp2 = "github";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_2(cmp, cmp2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_vs_cs_2_test1()
        {
            ce103_functions strcmp2 = new ce103_functions();
            ce103_hw4_functions_csharp strcmp = new ce103_hw4_functions_csharp();
            const string cmp = "whereareyou";
            const string cmp2 = "whereareyou";
            Assert.AreEqual(strcmp2.ce103_strcmp_cs_2(cmp, cmp2), strcmp.ce103_strcmp_cs(cmp, cmp2));
        }

        [TestMethod]
        public void ce103_strcmp_cs_vs_cs_2_test2()
        {
            ce103_functions strcmp2 = new ce103_functions();
            ce103_hw4_functions_csharp strcmp = new ce103_hw4_functions_csharp();
            const string cmp = "howisoutput";
            const string cmp2 = "howisoutput";
            Assert.AreEqual(strcmp2.ce103_strcmp_cs_2(cmp, cmp2), strcmp.ce103_strcmp_cs(cmp, cmp2));
        }

        [TestMethod]
        public void ce103_strcmp_cs_vs_cs_2_test3()
        {
            ce103_functions strcmp2 = new ce103_functions();
            ce103_hw4_functions_csharp strcmp = new ce103_hw4_functions_csharp();
            const string cmp = "whereareyoufrom";
            const string cmp2 = "whereareyoufrom";
            Assert.AreEqual(strcmp2.ce103_strcmp_cs_2(cmp, cmp2), strcmp.ce103_strcmp_cs(cmp, cmp2));
        }

        [TestMethod]
        public void ce103_strcpy_cs_test1()
        {
            ce103_hw4_functions_csharp strcpy = new ce103_hw4_functions_csharp();
            string cpy = "Intel";
            string cpy2 = "core";
            string cpy3 = "core";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(cpy, cpy2), cpy3);
        }

        [TestMethod]
        public void ce103_strcpy_cs_test2()
        {
            ce103_hw4_functions_csharp strcpy = new ce103_hw4_functions_csharp();
            string cpy = "couldntcatchthebus";
            string cpy2 = "Left";
            string cpy3 = "Left";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(cpy, cpy2), cpy3);
        }

        [TestMethod] 
        public void ce103_strcpy_cs_test3()
        {
            ce103_hw4_functions_csharp strcpy = new ce103_hw4_functions_csharp();
            string cpy = "Str";
            string cpy2 = "Cpy";
            string cpy3 = "Cpy";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(cpy, cpy2), cpy3);
        }
        [TestMethod]
        public void ce103_strcpy_cs_2_test_1()
        {
            ce103_functions strcpy2 = new ce103_functions();
            Assert.AreEqual(strcpy2.ce103_strcpy_cs_2("Hello", "csharp"), "csharp");
        }
        [TestMethod]
        public void ce103_strcpy_cs_vs_cs_2_test_1()
        {
            ce103_hw4_functions_csharp strcpy = new ce103_hw4_functions_csharp();
            ce103_functions Strcpy2 = new ce103_functions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Hello", "csharp"), "csharp", Strcpy2.ce103_strcpy_cs_2("csharp", "Hello"), "Hello");
        }

        [TestMethod]
        public void ce103_strcpy_cs_2_test_2()
        {
            ce103_functions strcpy2 = new ce103_functions();
            Assert.AreEqual(strcpy2.ce103_strcpy_cs_2("Git", "Changes"), "Changes");
        }
        [TestMethod]
        public void ce103_strcpy_cs_vs_cs_2_test_2()
        {
            ce103_hw4_functions_csharp strcpy = new ce103_hw4_functions_csharp();
            ce103_functions Strcpy2 = new ce103_functions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Four", "Homework"), "Homework", Strcpy2.ce103_strcpy_cs_2("Four", "Homework"), "Homework");
        }

        [TestMethod]
        public void ce103_strcpy_cs_2_test_3()
        {
            ce103_functions strcpy2 = new ce103_functions();
            Assert.AreEqual(strcpy2.ce103_strcpy_cs_2("Public", "Void"), "Void");
        }
        [TestMethod]
        public void ce103_strcpy_cs_vs_cs_2_test_3()
        {
            ce103_hw4_functions_csharp strcpy = new ce103_hw4_functions_csharp();
            ce103_functions strcpy2 = new ce103_functions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Work", "New"), "New", strcpy2.ce103_strcpy_cs_2("Work", "New"), "New");
        }
        
        [TestMethod]
        public void ce103_hex2bin_cs_test1()
        {
            ce103_hw4_functions_csharp hex2bin = new ce103_hw4_functions_csharp();
            string h = "1010101010101010";
            byte[] con = { 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10 };
            byte[] arr = new byte[h.Length / 2];
            hex2bin.ce103_hex2bin_cs(h, h.Length, arr);

            // assert by sequence
            CollectionAssert.AreEqual(con, arr);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_test2()
        {
            ce103_hw4_functions_csharp hex2bin = new ce103_hw4_functions_csharp();
            string h = "1313131313131313";
            byte[] con = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] arr = new byte[h.Length / 2];
            hex2bin.ce103_hex2bin_cs(h, h.Length, arr);

            // assert by sequence
            CollectionAssert.AreEqual(con, arr);
        }
       // --------------------
        [TestMethod]
        public void ce103_hex2bin_cs_test3()
        {
            ce103_hw4_functions_csharp hex2bin = new ce103_hw4_functions_csharp();
            string h = "FAFAFAFAFAFAFAFA";
            byte[] con = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            byte[] arr = new byte[h.Length / 2];
            hex2bin.ce103_hex2bin_cs(h, h.Length, arr);

            // assert by sequence
            CollectionAssert.AreEqual(con, arr);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_2_test1()
        {
            ce103_functions hex2bin2 = new ce103_functions();
            string h2 = "BCADFC343424";
            byte[] con2 = { 0xBC, 0xAD, 0xFC, 0x34, 0x34, 0x24 };
            byte[] arr2 = new byte[h2.Length / 2];
            hex2bin2.ce103_hex2bin_cs_2(h2, h2.Length, arr2);

            // assert by sequence
            CollectionAssert.AreEqual(con2, arr2);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_2_test2()
        {
            ce103_functions hex2bin2 = new ce103_functions();
            string h2 = "7547256971423567412121";
            byte[] con2 = { 0x75, 0x47, 0x25, 0x69, 0x71, 0x42, 0x35, 0x67, 0x41, 0x21, 0x21 };
            byte[] arr2 = new byte[h2.Length / 2];
            hex2bin2.ce103_hex2bin_cs_2(h2, h2.Length, arr2);

            // assert by sequence
            CollectionAssert.AreEqual(con2, arr2);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_2_test3()
        {
            ce103_functions hex2bin2 = new ce103_functions();
            string h2 = "1212121212121212121212";
            byte[] con2 = { 0x12, 0x12, 0x12, 0x12, 0x12, 0x12, 0x12, 0x12, 0x12, 0x12, 0x12 };
            byte[] arr2 = new byte[h2.Length / 2];
            hex2bin2.ce103_hex2bin_cs_2(h2, h2.Length, arr2);

            // assert by sequence
            CollectionAssert.AreEqual(con2, arr2);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_vs_cs_2_test1()
        {
            ce103_functions hex2bin2 = new ce103_functions();
            ce103_hw4_functions_csharp hex2bin = new ce103_hw4_functions_csharp();
            string h = "EEEEEEEEEE";

            byte[] con = new byte[h.Length / 2];
            hex2bin2.ce103_hex2bin_cs_2(h, h.Length, con);

            byte[] con2 = new byte[h.Length / 2];
            hex2bin.ce103_hex2bin_cs(h, h.Length, con2);

            // assert by sequence
            CollectionAssert.AreEqual(con, con2);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_vs_cs_2_test2()
        {
            ce103_functions hex2bin2 = new ce103_functions();
            ce103_hw4_functions_csharp hex2bin = new ce103_hw4_functions_csharp();
            string h = "FACEDABF";
            byte[] con = { 0xFA, 0xCE, 0xDA, 0xBF };

            byte[] arr = new byte[h.Length / 2];
            hex2bin2.ce103_hex2bin_cs_2(h, h.Length, arr);

            byte[] arr2 = new byte[h.Length / 2];
            hex2bin.ce103_hex2bin_cs(h, h.Length, arr2);

            // assert by sequence
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_vs_cs_2_test3()
        {
            ce103_functions hex2bin2 = new ce103_functions();
            ce103_hw4_functions_csharp hex2bin = new ce103_hw4_functions_csharp();
            string h = "F1473A8B8A275267CB";
            byte[] con = { 0xF1, 0x47, 0x3A, 0x8B, 0x8A, 0x27, 0x52, 0x67, 0xCB };

            byte[] arr = new byte[h.Length / 2];
            hex2bin2.ce103_hex2bin_cs_2(h, h.Length, arr);

            byte[] arr2 = new byte[h.Length / 2];
            hex2bin.ce103_hex2bin_cs(h, h.Length, arr2);

            // assert by sequence
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            ce103_hw4_functions_csharp bin2hex = new ce103_hw4_functions_csharp();
            byte[] con = { 0x24, 0xCD, 0x15, 0xFA, 0xCA, 0xDF };
            char[] arr = new char[con.Length * 2];
            char[] arr2 = { '2', '4', 'C', 'D', '1', '5', 'F', 'A', 'C', 'A', 'D', 'F' };

            bin2hex.ce103_bin2hex_cs(con, con.Length, arr);

            CollectionAssert.AreEqual(arr2, arr);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_test2()
        {
            ce103_hw4_functions_csharp bin2hex = new ce103_hw4_functions_csharp();
            byte[] con = { 0x24, 0x24, 0x24, 0x24, 0x24 };
            char[] arr = new char[con.Length * 2];
            char[] arr2 = { '2', '4', '2', '4', '2', '4', '2', '4', '2', '4' };

            bin2hex.ce103_bin2hex_cs(con, con.Length, arr);

            CollectionAssert.AreEqual(arr2, arr);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_test3()
        {
            ce103_hw4_functions_csharp bin2hex = new ce103_hw4_functions_csharp();
            byte[] con = { 0xDC, 0xDC, 0xDC, 0xDC, 0xDC, 0xDC, 0xDC, 0xDC };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = { 'D', 'C', 'D', 'C', 'D', 'C', 'D', 'C', 'D', 'C', 'D', 'C', 'D', 'C', 'D', 'C' };

            bin2hex.ce103_bin2hex_cs(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_2_test1()
        {
            ce103_functions bin2hex2 = new ce103_functions();
            byte[] con = { 0xBD, 0xBD, 0xBD, 0xBD, 0xBD, 0xBD, 0xBD, 0xBD };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = { 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D' };

            bin2hex2.ce103_bin2hex_cs_2(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_2_test2()
        {
            ce103_functions bin2hex2 = new ce103_functions();
            byte[] con = { 0x33, 0x33, 0x33, 0x33, 0x33 };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = { '3', '3', '3', '3', '3', '3', '3', '3', '3', '3' };

            bin2hex2.ce103_bin2hex_cs_2(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_2_test3()
        {
            ce103_functions bin2hex2 = new ce103_functions();
            byte[] con = { 0xCD, 0xAB, 0x41, 0x36, 0xAA, 0xDF };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = { 'C', 'D', 'A', 'B', '4', '1', '3', '6', 'A', 'A', 'D', 'F' };

            bin2hex2.ce103_bin2hex_cs_2(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_vs_cs_2_test1()
        {
            ce103_hw4_functions_csharp bin2hex = new ce103_hw4_functions_csharp();
            ce103_functions bin2hex2 = new ce103_functions();
            byte[] con = { 0xCD, 0xAB, 0x41, 0x36, 0xAA, 0xDF };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = new char[con.Length * 2];
            bin2hex.ce103_bin2hex_cs(con, con.Length, arr);
            bin2hex2.ce103_bin2hex_cs_2(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_vs_cs_2_test2()
        {
            ce103_hw4_functions_csharp bin2hex = new ce103_hw4_functions_csharp();
            ce103_functions bin2hex2 = new ce103_functions();
            byte[] con = { 0xFF, 0x28, 0x35, 0xDD, 0xAA, 0x14 };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = new char[con.Length * 2];
            bin2hex.ce103_bin2hex_cs(con, con.Length, arr);
            bin2hex2.ce103_bin2hex_cs_2(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_vs_cs_2_test3()
        {
            ce103_hw4_functions_csharp bin2hex = new ce103_hw4_functions_csharp();
            ce103_functions bin2hex2 = new ce103_functions();
            byte[] con = { 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA };
            char[] arr2 = new char[con.Length * 2];
            char[] arr = new char[con.Length * 2];
            bin2hex.ce103_bin2hex_cs(con, con.Length, arr);
            bin2hex2.ce103_bin2hex_cs_2(con, con.Length, arr2);

            CollectionAssert.AreEqual(arr, arr2);
        }
    }
}
