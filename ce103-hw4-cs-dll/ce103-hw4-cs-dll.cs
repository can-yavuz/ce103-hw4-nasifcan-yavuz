using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll1
{
    public class ce103_hw4_functions_csharp
    {
        /**
      *
      *	  @name   fibonacciNumber (ce103_fibonacciNumber)
      *
      *	  @brief Fibonacci Number Calculator
      *
      *	  Calculates the fibonacci number in the given index and return as output
      *
      *	  @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
      *
      *	  @retval [\b int] calculated fibonacci number
      **/
        public int ce103_fibonacciNumber_cs(int fiIndex)
        {
            //Values assigned to variables
            int one = 1, sec = 1, thrd = 0;
            //The variable "i" is defined and the value '1' is assigned to the variable i and the variable "i" increases by one if the variable "i" is less than the value "fiIndex"
            for (int i = 2; i < fiIndex; i++)
            {

                thrd = one + sec;
                one = sec;
                sec = thrd;
                
            }
            //Third variable returns operation repeats.
            return thrd;
        }
        /**
         @name   strrev (ce103_strrev)

         @brief \b Reverse char*

         Reverse given string

         @param [in] fiStr [\b char*] The given string which is needed to be reversed.

         @retval [\b char*] This function returns the string after reversing the given string
     **/

        public string ce103_strrev_cs(string x)
        {
            // the specified array is defined.
            string rev = "";
            //An array of type integer is defined
            int strlen;

            strlen = x.Length - 1;
            //Executes specified operations when the specified array is greater than "0"
            while (strlen >= 0)
            {
                rev = rev + x[strlen];
                strlen--;
            }
            //Array returns.
            return rev;

        }
        /**
     @name   strlen (ce103_strlen)
     @brief \b Get string length

     Returns the length of the C string str.

     The length of a C string is determined by the terminating null-character:
     A C string is as long as the number of characters between the beginning of
     the string and the terminating null character
     (without including the terminating null character itself).

     see more <a href="https://en.cppreference.com/w/c/string/byte/strlen">strlen reference 1</a>
     see more <a href="https://www.programiz.com/c-programming/library-function/string.h/strlen">strlen reference 2</a>
     see more <a href="https://www.cplusplus.com/reference/cstring/strlen/">strlen reference 3</a>

     @param [in] fiStr [\b const char*] pointer to the null-terminated byte string to be examined

     @retval [\b int] The length of the null-terminated byte string str.
 **/
        public int ce103_strlen_cs(string fiStr)
        {
            //The integer value "len" is defined and assigned the value "0".
            int len = 0;
            //len increments by one when "len" is not equal to "firSt".
            while (len != fiStr.Length)
            {
                len++;
            }
            //Returns the value "len".
            return len;
        }
        /**
        @name   strcat (ce103_strcat)
        @brief \b Concatenate strings

        Appends a copy of the null-terminated byte string pointed to by src to the end of the null-terminated byte string pointed to by dest

        The character src[0] replaces the null terminator at the end of dest. The resulting byte string is null-terminated.

        The behavior is undefined if the destination array is not large enough for the contents of
        both src and dest and the terminating null character. The behavior is undefined if the strings overlap.
        The behavior is undefined if either dest or src is not a pointer to a null-terminated byte string.

        see more <a href="https://en.cppreference.com/w/c/string/byte/strcat">strcat reference</a>
        see more <a href="https://www.cplusplus.com/reference/cstring/strcat/">strcat reference</a>

        @param  [in] fiDest [\b char*] pointer to the null-terminated byte string to append to
        @param  [in] fiSrc  [\b char*] pointer to the null-terminated byte string to copy from

        @retval [\b char*] returns a copy of dest
    **/
        public string ce103_strcat_cs(string fiDest, string fiSrc)
        {
            //text type assigned to "cat"
            string cat = string.Empty;
            //Variables are recognized.
            int i, a, dst, dst2;
            //The value "fiDest" is assigned to the variable "dst".
            dst = fiDest.Length;
            //The value "fiSrc" is assigned to the variable "dst2".
            dst2 = fiSrc.Length;

            //The value "0" is assigned to the variable "i". If the variable "i" is less than the variable "dst", the "i" increases by one.
            for (i = 0; i < dst; i++)
            {
                //New value is assigned to variable "cat".
                cat = cat + fiDest[i];
            }
            //The value "0" is assigned to the variable "a". If the variable "a" is less than the variable "dst2", the "a" increases by one.
            for (a = 0; a < dst2; a++)
            {
                //New value is assigned to variable "cat".
                cat = cat + fiSrc[a];
            }
            //Returns the value "catb".
            return cat;
        }
        /**
	@name   strcmp (ce103_strcmp)
	@brief  \b Compare two strings

	Compares two null-terminated byte strings lexicographically.

	The sign of the result is the sign of the difference between
	the values of the first pair of characters (both interpreted as unsigned char)
	that differ in the strings being compared.The behavior is undefined
	if lhs or rhs are not pointers to null-terminated byte strings.

	see more <a href="https://en.cppreference.com/w/c/string/byte/strcmp">strcmp reference</a>
	see more <a href="https://www.cplusplus.com/reference/cstring/strcmp/">strcmp reference</a>

	@param  [in] fiLhs [\b const char*] pointers to the null-terminated byte strings to compare
	@param  [in] fiRhs [\b const char*] pointers to the null-terminated byte strings to compare

	@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
			Zero if lhs and rhs compare equal.
			Positive value if lhs appears after rhs in lexicographical order.
**/
        public int ce103_strcmp_cs(string fiLhs, string fiRhs)
        {
            //The integer variables "a1" and "a2" are defined and assigned a value.
            int c = 0, c2 = 0;
            //If the integer "i" is defined and assigned a value and "i" is less than the specified expressions, operations are started.
            for (int i = 0; i < (fiLhs.Length > fiRhs.Length ? fiLhs.Length : fiRhs.Length); i++)
            {
                c += (i >= fiLhs.Length ? 0 : fiLhs[i]) - (i >= fiRhs.Length ? 0 : fiRhs[i]);
                //If "a2" value is less than 0, perform operations.
                if (c2 < 0)
                {
                    //If the value "a1" is less than "0", the value "a2" is assigned one more value than the value "a1".
                    if (c < 0)
                        c2 += c;
                    //If the value "a1" is greater than "0", the value "a2" is assigned one less value than the value "a1".
                    if (c > 0)
                        c2 += -c;
                }
                //If this "a2" value is greater than or equal to "0" then apply the operation
                else
                {
                    //One more variable than "a1" is assigned to variable " a2"
                    c2 += c;
                }
            }
            //Returns the value "a2".
            return c2;
        }
        /**
         *
     	@name  strcpy (ce103_strcpy)
	    @brief \b Copy string

	    Copies the C string pointed by source into the array pointed by destination,
     	including the terminating null character (and stopping at that point).

	    To avoid overflows, the size of the array pointed by destination shall be long enough to contain
	    the same C string as source (including the terminating null character),
    	and should not overlap in memory with source.

    	see more <a href="https://en.cppreference.com/w/c/string/byte/strcpy">strcpy reference 1</a>
    	see more <a href="https://www.cplusplus.com/reference/cstring/strcpy/">strcpy reference 2</a>

	    @param [out] foDestination	[\b char*]			Pointer to the destination array where the content is to be copied.
	    @param [in]  fiSource		[\b const char*]	C string to be copied.

	    @retval returns a copy of dest
        **/
        public string ce103_strcpy_cs(string foDestination, string fiSource)
        {
            // declare and initialize the array
            char[] dArr = new char[fiSource.Length];

            // convert source string to char array
            char[] sArr = fiSource.ToCharArray();

            // The variable "i" is defined and the value "0" is assigned. "i" increments by one if target is less than array.
            for (int i = 0; i < fiSource.Length; i++)
            {
                dArr[i] = sArr[i];
            }

            //Temporarily transfer array to another array.
            string tempde = new string(dArr);

            //Replace array with another array
            foDestination = tempde;
            //Variable returns.
            return foDestination;
        }

        /**
         * @name    hex2bin (ce103_hex2bin)
         * @brief   \b Hexadecimal to Binary (BCD)  Conversion
         *
         * Hexadecimal to Binary (BCD)  Conversion
         * Packs hexadecimal string to packed binary array, Example: "AB1234" => 0xAB 0x12 0x34
         * If length of the input string is less than the fiHexLen,remaining bytes is not filled.
         * If odd number of characters processed, last nibble is padded with 0
         *
         * @param   [in]  fiHex    [\b unsigned char*] Ascii hex string.
         * @param   [in]  fiHexLen [\b int]     Ascii data length.
         * @param  [out]  foBin    [\b char*]   Convertion result as binary.
         */
        public void ce103_hex2bin_cs(string fiHex, int fiHexLen, byte[] foBin)
        {

            int[] count = { 0, 0 };  // count array for storing ascii and hex value of selected element 
            for (int x = 0; x < fiHexLen; x += 2)
            {  // The variable "x" is defined and the value "0" is incremented by "2" if the row is less than the specified array.
                char[] temp = new char[2];
                // value "0" is assigned to the specified string
                int hexint = 0;
                // The value "w" is defined, the value "0" is assigned to it, if the variable "w" is less than "2", "w" increases.
                for (int w = 0; w < 2; w++)
                {  // assigning first fiHex element to temp
                    temp[w] = (char)fiHex[x + w];
                    //Skip to steps if variable "w" equals "0".
                    if (w == 0)
                    {
                        //If it provides the stages with the specified characters, continue processing.
                        if (temp[w] >= '0' && temp[w] <= '9')
                        {  
                            count[w] = temp[w] - '0';  
                            // find int value of nibble
                            count[w] *= 16; 
                            // multiply by 16 because of 16^1*hex digit
                        }
                        //Otherwise, if you meet these conditions, do the following steps.
                        else if (temp[w] >= 'A' && temp[w] <= 'F')
                        {
                            // take difference between temp and 'A' then plus 10
                            count[w] = temp[w] - 'A' + 10; 
                            count[w] *= 16;
                        }
                    }
                    //When the above conditions are not met, the following steps should be taken.
                    else
                    {
                        //Necessary conditions are defined.
                        if (temp[w] >= '0' && temp[w] <= '9')
                        {
                            count[w] = temp[w] - '0';  
                            // we're not multiplying by 16 because it's 16^0 digit
                        }
                        //Otherwise, if you meet these conditions, do the following steps.
                        else if (temp[w] >= 'A' && temp[w] <= 'F')
                        {
                            count[w] = temp[w] - 'A' + 10;
                            // we're not multiplying by 16 because it's 16^0 digit

                        }
                    }
                    hexint += count[w];  
                    // get two digit value's sum and assign it to hexint
                }
                foBin[x / 2] = (byte)hexint;  
                // assigning summed values to foBin
            }
        }
        /**
        * @name    bin2hex (ce103_bin2hex)
        * @brief   \b Binary (BCD) to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\b unsigned char*]    Binary data to be converted.
        * @param [in]  fiBinLen   [\b int]				 Binary data length.
        * @param [out] foHex      [\b char*]			 Convertion result as ascii. Doubles the binary length.
        *
        */

        public void ce103_bin2hex_cs(byte[] fiBin, int fiBinLen, char[] foHex)
        {
            //variables are defined in array
            char[] hrr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            //The variable "m" is defined and the variable "m" is assigned the value "0", if it is less than the specified array, "m-" increases.
            for (int m = 0; m < fiBinLen; m++)
            {
                foHex[m * 2] = hrr[fiBin[m] >> 4];
                foHex[m * 2 + 1] = hrr[fiBin[m] & 0x0F];
            }
        }
    }
}
