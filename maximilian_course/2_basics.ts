/*

2. BASICS: Variables, operators, data types & functions

JS code can be called inside .html files, in the tag <script> JS code </script>
or using <script src="/path/to/script.js"> (you can place several of those if you want)
OBS: code gets executed from top to bottom. The place you put it matters!

* VARIABLES
Variable naming: use camelCase in most cases
human-readable and meaningful names
keep it clean without special characters (excluding $ and _, which can be used)
when naming hard-coded values, you could also go for something like: 
*/

const COLOR_RED: string = "#ff0000";

/*

OBS: don't name consts like that when their value is unknown at first.

'var' isn't used anymore. Always go for 'let' or 'const'.

a 'shadowed variable' is a local variable which also exists as a global one

* OPERATORS 
+, -, *, /, %, **
= is an assignment operator, not a comparison one

typeof operator returns the type of something
some special events:
typeof Math is "object" (a built-in object for math operations)
typeof null is "object" (it's an error. null is not an object.)

* DATA TYPES
1. NUMBER: integer or float
! special numeric values: Infinity, -Infinity, NaN

*/

const myInfinity: number = (1 / 0);
const directInfinity: number = Infinity;

const alsoNaN: number = 3 * NaN;
const one: number = NaN ** 0;

Number.MAX_VALUE // The largest number that can be represented in JavaScript. Equal to approximately 1.79E+308.
// Positive values greater than Number.MAX_VALUE are converted to +Infinity.
Number.MIN_VALUE // The closest number to zero that can be represented in JavaScript. Equal to approximately 5.00E-324.
Number.MAX_SAFE_INTEGER // The value of the largest integer n such that n and n + 1 are both exactly representable as a Number value. 
Number.NEGATIVE_INFINITY // -infinity
Number.EPSILON // The value of Number.EPSILON is the difference between 1 and the smallest value greater than 1 that is representable as a Number value

Number.isSafeInteger(93743847);
Number.isNaN(alsoNaN);

/*
yes, NaN ^ 0 is 1!

const myNaN: number = ("word" / 2);
typescript won't even let me do that, as it prevents this kind of thing
also, doing any kind of math is safe on JS. it won't crash.

2. BIGINT: for values bigger than 9007199254740991, positive or negative
number type could even store them, but as an approximate value.

you could declare a BigInt like that, with the 'n' on the end,
or calling the BigInt() function:
*/

const bigNumber: BigInt = 1234567890123456789012345678901234567890n;
const anotherBigNumber = BigInt(Number.MAX_SAFE_INTEGER); // 9007199254740991n

/*

3. STRING: "hi", 'hi' or `hi`
there's no character type in JS (like char in C or Java)

*/

const word: string = 'nice';
`interpolation is a ${word} feature for strings`

/*

4. BOOLEAN: true XOR false (it's an exclusive or)
they can come as a result of a comparison.

5. NULL: it's its own type.
a special value for: nothing. emptiness.

6. UNDEFINED: also its own type.
it means "value not assigned". it's the default initial value for unassigned things

7. OBJECT: a remarkable type. this one isn't primitive like the others.
objects are used to store collections of data, in key-value pairs
functions are callable objects!

*/

const user = {
    name: 'Gabi',
    age: 25
};
const myName = user.name;

/*

8. SYMBOL: is used to create unique identifiers for objects. yes it's a type!

converting types:
parseInt(), parseFloat()

3 + '3' = 33
3 * '3' = 9
3 - '3' = 0
strings only support + operator

! is ARRAY a data type? no! it's considered a data structure. it can store values of
any data type, but isn't one itself.
MDN says that "arrays are regular objects for which there is a particular relationship between integer-keyed properties and the length property.
Additionally, arrays inherit from Array.prototype, which provides a handful of convenient methods to manipulate arrays"
we'll take a look at that further, in data structures.

* FUNCTIONS

function name(param: ParamType) {}

fun fact: JS will read your file before executing it, take all functions and
put them first, so there's no difference in where you put them in the code.
you can call a function first and later define it.

return stops a function, anything after it won't be read

const button = document.getElementById("click-me-btn");
button.addEventListener('click', addNumbers(1, 2));


*/


