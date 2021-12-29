
#include "ce103-hw4-c-dll.h"

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
int ce103_fibonacciNumber(int fiIndex)
{
	//TODO:Start from Here...
	{

		int x = 0, y = 1, z, i;
		//Variables are defined.
		if (fiIndex == 0)
		//if 'fiIndex' equals '0'.String is terminated.
			return x;
		//Return command given to 'a'.
		for (i = 2; i <= fiIndex; i++)
			
		{
			z = x + y;
			x = y;
			y = z;

			//The value of '2' is assigned 'fiIndex'.
			//If 'i' is less than fiIndex, 'i' is summed with previous value.
		}
		return x;
		//return command given to 'a'.
	}
	;
}
/**
	@name   strrev (ce103_strrev)

	@brief \b Reverse String

	Reverse given string

	@param [in] fiStr [\b char*] The given string which is needed to be reversed.

	@retval [\b char*] This function returns the string after reversing the given string
**/
char* ce103_strrev(char* fiStr)
{
	//TODO:Start from Here...
	char b;
	//Variable 'ch' declared.
	char* x = fiStr;
	char* y = fiStr;
	//Memory address specified.
	for (; *y != '\0'; y++);
	//'b' increases if value multiplied by 'b' is not equal to null character.
	
	y--;
	for (; x < y; x++, y--)
		//if 'a' is less than 'b' then 'a' will increase 'b' will decrease.
	{
		b = *x;
		*x = *y;
		*y = b;
	}
	return fiStr;
	//Return command given.
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
int ce103_strlen(const char* fiStr)
{
	//TODO:Start from Here...

	if (*fiStr == '\0')
		//Equals the empty character.String is terminated.
	{
		return 0;
		//Return command given to '0'.
	}
	return 1 + ce103_strlen(fiStr + 1);

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
char* ce103_strcat(char* fiDest, char* fiSrc)
{
	//TODO:Start from Here...


	char* var = fiDest;
	//char type pointer definition
	//we set variable start to fiDest.
	while (*fiDest != '\0')
		//continue loop if fiDest is not equal to null character ' otherwise exit
	{
		fiDest++;
	}

	while (*fiSrc != '\0')
		//continue loop if fiSrc is not equal to 'null character ' otherwise exit
	{
		*fiDest = *fiSrc;
		fiDest++;
		fiSrc++;
	}

	*fiDest = '\0';
	return var;
	//return command given to 'start'.
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
int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	//TODO:Start from Here...
	int comp;
	//Variable 'ret' are defined.
	while ((comp = *fiLhs - *fiRhs++) == 0 && *fiLhs++);
	//The value 'ret' is assigned as the loop 'fiLhs-fiRhs++' entered. or the value 'fiLhs++' is assigned
	return comp;
	//return command given to 'ret'.
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
char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	//TODO:Start from Here...
	char* copy = foDestination;
	//Memory address specified
	while ((*foDestination++ = *fiSource++) != '\0');
	//'foDestination' value is assigned as 'fiSource' loop .Not equal to a null character.
	return copy;
	//return command given to 'ret'.
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
void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	//TODO:Start from Here...
	int bin1, bin2;
	//We created int type variable named num1 and num2.
	for (;;) {
		bin1 = *fiHex++; if (bin1 == 0) break;
		//we set fihex equal to num1 if num1 equals 0 the loop repeats otherwise exit.
		if (bin1 > 96) bin1 -= 87;
		//if num1 bigger than 96 subtract 87 from num1 and contiue
		else if (bin1 > 64) bin1 -= 55;
		//if num1 bigger than 64 then subtract 55 from num1 and contiue
		else bin1 -= 48;
		bin2 = *fiHex++; if (bin2 == 0) { *foBin = bin1 << 4; break; }
		//We equate fihex to num2 then if num2 equal to 0 then contiue the other function
		if (bin2 > 96) bin2 -= 87;
		//if num2 is bigger than 96 then subtract 87 from num2 and continue
		else if (bin2 > 64) bin2 -= 55;
		else bin2 -= 48;
		*foBin++ = (bin1 << 4) | bin2;
		//num1 shifting the number 1 to the left 0 bits or num2 are equal to fobin++
	}
	return fiHex;
	//Return command given to 'fiHex'.
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
void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	//TODO:Start from Here...
	int hex;
	//we created int type variable named i.
	for (hex = 0; hex < fiBinLen; hex++)
		//continue if i is less than fiBinLen, otherwise exit
	{
		foHex[hex * 2] = "0123456789ABCDEF"[fiBin[hex] >> 4];
		foHex[hex * 2 + 1] = "0123456789ABCDEF"[fiBin[hex] & 0x0F];
	}
	//We changed fohex value one by one and then we converting bin values to hex
	foHex[fiBinLen * 2] = '\0';
	//The resultant value of fohex multiplied by the fiblen value of 2 is equal to 0.
	return foHex;
	//return command given to 'foHex'
}

