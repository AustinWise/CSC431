	.section        ".text"
	.align 4
	.global wait
.type    wait, #function
wait:
save %sp, -96, %sp
.L3099:
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
be %icc, .L3105
nop
ba %icc, .L3123
nop
.L3105:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L3099
nop
.L3123:
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
sethi %hi(1), %l3
or %l3, %lo(1), %l3
.L3138:
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
be %icc, .L3144
nop
ba %icc, .L3171
nop
.L3144:
or %l3, 0, %l1
mov %i0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l3
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ba %icc, .L3138
nop
.L3171:
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
be %icc, .L3190
nop
ba %icc, .L3266
nop
.L3190:
mov %i0, %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
mov %i0, %l1
or %l0, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3227
nop
ba %icc, .L3243
nop
.L3227:
mov %i1, %l0
sethi %hi(2), %l2
or %l2, %lo(2), %l2
mov %i2, %l1
mov %l2, %o0
mov %l1, %o1
call power
nop
mov %o0, %l1
add %l0, %l1, %l0
mov %l0, %i1
ba %icc, .L3248
nop
.L3243:
ba %icc, .L3248
nop
.L3248:
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
ba %icc, .L3271
nop
.L3266:
ba %icc, .L3271
nop
.L3271:
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
mov %i0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
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
.L3326:
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
be %icc, .L3332
nop
ba %icc, .L3354
nop
.L3332:
or %l0, 0, %l2
mov %l2, %o0
call wait
nop
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L3326
nop
.L3354:
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

