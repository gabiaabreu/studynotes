/* 

        OPERATORS 

+, -, *, /, % (remainder), ** (exponentiation)
= is an assignment operator, not a comparison one

typeof operator returns the type of something
some special events:
*/
typeof Math // "object" (a built-in object for math operations)
typeof null // "object" (it's an error. null is not an object.)
/*

Bitwise operators:
& and
| or
^ xor
~ not


    * COMPARISONS
>, <, >=, <=, ==, ===, !=
return a boolean value

*/ 

'Z' > 'A' // true. JS uses lexicographical order
'A' > 'a' // false. 'a' has a greater index in the Unicode table
'2' > '12' // true 

/*
JS compares strings letter by letter. if the first letter is bigger, then it is

when comparing different types, JS converts values into numbers
(typescript won't let you do that)

    '2' > 1 // true
    '01' == 1 // true
    true == 1 // true

that can be a problem. maybe I don't want 0 to be equal to false.
we can differenciate them by using the strict equality operator (===)
this operator also checks if both values are the same type.

    null == undefined // true
    null === undefined // false 
* null only equals undefined


    * TERNARY OPERATOR
condition ? (if true) : (if false)

you can also use it one after another like:
condition ? (if true) : condition2 ? (if true) : condition3 ? (if true) : (else)

just like an if-else chain.


    * LOGICAL OPERATORS

    || OR
finds the first truthy value

data.text || 'my text' 
if the first condition is falsy, it will check the next one. the order does matter

    && AND
finds the first falsy value

firstCondition && secondCondition && thirdCondition
checking from left to right, if one of them is false, it's all not happening

*/

1 && 0 // 0
1 && 5 // 5. if the first operand is truthy, returns the second
0 && 'whatever' // 0. if the first one is falsy, returns it
1 && 2 && null && 3 // null. it returns the first falsy
1 && 2 && 3 // 3. if all of them are truthy, returns the last one
/*

it could also be used as an if, like
condition && <component>

    ! NOT
converts value to boolean and returns the inverse

a double not !! is also used to convert something into boolean value, like: 
!!"non empty string" -> true
!![non empty array] -> true


    * NULLISH COALESCING OPERATOR: ??

firstValue ?? secondValue
if first is not null/undefined, first. otherwise, second.

a simplified version of:
(firstValue !== null && firstValue !== undefined) ? (firstValue) : (secondValue)

mostly used for default values.
data.text ?? "my default text"

if you did it with || you would get the same result, but there's a difference
|| returns the first truthy value
?? returns the first *defined* value

|| doesn’t distinguish between false, 0, "" and null/undefined

maybe 0 or "" is what I want.
we use ?? when the variables value is still unknown or not set.

you can't use ?? in direct operations with && and ||, it's forbidden

---------------------------------------------------------------------------
*/
