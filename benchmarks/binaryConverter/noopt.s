	.section        ".text"
	.align 4
	.global wait
.type    wait, #function
wait:
save %sp, -96, %sp
.L17254:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L17260
nop
ba %icc, .L17278
nop
.L17260:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L17254
nop
.L17278:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    wait, .-wait
	.align 4
	.global power
.type    power, #function
power:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l3
.L17293:
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L17299
nop
ba %icc, .L17326
nop
.L17299:
or %l3, 0, %l1
mov %i0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l3
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ba %icc, .L17293
nop
.L17326:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    power, .-power
	.align 4
	.global recursiveDecimalSum
.type    recursiveDecimalSum, #function
recursiveDecimalSum:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L17345
nop
ba %icc, .L17421
nop
.L17345:
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l1
mov %i0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mulx %l2, %l0, %l0
or %l0, 0, %l0
mov %i0, %l2
or %l0, 0, %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
move %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L17382
nop
ba %icc, .L17398
nop
.L17382:
mov %i1, %l0
or %l1, 0, %l2
mov %i2, %l1
mov %l2, %o0
mov %l1, %o1
call power
nop
mov %o0, %l1
add %l0, %l1, %l0
mov %l0, %i1
ba %icc, .L17403
nop
.L17398:
ba %icc, .L17403
nop
.L17403:
mov %i0, %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
sdivx %l1, %l0, %l3
mov %i1, %l2
mov %i2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
mov %l3, %o0
mov %l2, %o1
mov %l0, %o2
call recursiveDecimalSum
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L17426
nop
.L17421:
ba %icc, .L17426
nop
.L17426:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
	.size    recursiveDecimalSum, .-recursiveDecimalSum
	.align 4
	.global convertToDecimal
.type    convertToDecimal, #function
convertToDecimal:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
mov %i0, %l2
or %l0, 0, %l1
or %l3, 0, %l0
mov %l2, %o0
mov %l1, %o1
mov %l0, %o2
call recursiveDecimalSum
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    convertToDecimal, .-convertToDecimal
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l1
or %l1, 0, %l0
mov %l0, %o0
call convertToDecimal
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l2
or %l1, 0, %l0
mulx %l2, %l0, %l0
or %l0, 0, %l0
.L17481:
or %l0, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movg %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L17487
nop
ba %icc, .L17509
nop
.L17487:
or %l0, 0, %l2
mov %l2, %o0
call wait
nop
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L17481
nop
.L17509:
or %l1, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.section        ".rodata"
	.align 8
.ConstantString0:
	.asciz  "%d "
	.align 8
.ConstantString1:
	.asciz  "%d\n"
	.align 8
.ConstantString2:
	.asciz  "%d"

