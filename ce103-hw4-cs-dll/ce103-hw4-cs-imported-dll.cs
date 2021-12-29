﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ce103_hw4_cs_dll2
{
    public class ce103_functions
    {

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_fibonacciNumber_cpp(int fiIndex);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string ce103_strrev_cpp(string fiStr);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strlen_cpp(string fiStr);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string ce103_strcat_cpp(string fiDest, string fiSrc);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strcmp_cpp(string fiLhs, string fiRhs);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string ce103_strcpy_cpp( string foDestination, string fiSource);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_hex2bin_cpp(string fiHex, int fiHexLen, byte[] foBin);


        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_bin2hex_cpp([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex);



        public int ce103_fibonacciNumber_cs_2(int fiIndex)
        {
            return ce103_fibonacciNumber_cpp(fiIndex);
        }

        public string ce103_strrev_cs_2(string fiStr)
        {
            return ce103_strrev_cpp(fiStr);
        }

        public int ce103_strlen_cs_2(string fiStr)
        {
            return ce103_strlen_cpp(fiStr);
        }

        public string ce103_strcat_cs_2(string fiDest, string fiSrc)
        {
            return ce103_strcat_cpp(fiDest, fiSrc);
        }

        public int ce103_strcmp_cs_2(string fiLhs, string fiRhs)
        {
            return ce103_strcmp_cpp(fiLhs, fiRhs);
        }
        
        public string ce103_strcpy_cs_2(string foDestination, string fiSource)
        {
            return ce103_strcpy_cpp(foDestination, fiSource);
        }

        public void ce103_hex2bin_cs_2(string fiHex, int fiHexlen, byte[] foBin)
        {
             ce103_hex2bin_cpp(fiHex, fiHexlen, foBin);
        }

        public void ce103_bin2hex_cs_2([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex)
        {
             ce103_bin2hex_cpp(fiBin, fiBinLen, foHex);
        }


    }
}







