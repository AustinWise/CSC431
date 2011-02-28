	.section        ".text"
	.align 4
	.global wait
.type    wait, #function
wait:
save %sp, -96, %sp
.L15:
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
be %icc, .L40
nop
ba %icc, .L232
nop
.L40:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L15
nop
.L232:
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
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 100]
.L352:
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
be %icc, .L361
nop
ba %icc, .L508
nop
.L361:
ldsw [%sp + 100], %l1
mov %i0, %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 100]
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ba %icc, .L352
nop
.L508:
ldsw [%sp + 100], %l0
or %l0, 0, %i0
ret
restore
	.size    power, .-power
	.align 4
	.global recursiveDecimalSum
.type    recursiveDecimalSum, #function
recursiveDecimalSum:
save %sp, -120, %sp
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
be %icc, .L524
nop
ba %icc, .L612
nop
.L524:
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 108]
mov %i0, %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 104]
mov %i0, %l1
ldsw [%sp + 104], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L573
nop
ba %icc, .L589
nop
.L573:
mov %i1, %l0
ldsw [%sp + 108], %l2
mov %i2, %l1
mov %l2, %o0
mov %l1, %o1
call power
nop
mov %o0, %l1
add %l0, %l1, %l0
mov %l0, %i1
ba %icc, .L594
nop
.L589:
ba %icc, .L594
nop
.L594:
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
ba %icc, .L617
nop
.L612:
ba %icc, .L617
nop
.L617:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
	.size    recursiveDecimalSum, .-recursiveDecimalSum
	.align 4
	.global convertToDecimal
.type    convertToDecimal, #function
convertToDecimal:
save %sp, -104, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 100]
mov %i0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 96], %l0
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
save %sp, -104, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 100, %o1
call scanf
nop
ldsw [%sp + 100], %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
mov %l0, %o0
call convertToDecimal
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
ldsw [%sp + 92], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 96]
.L682:
ldsw [%sp + 96], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L688
nop
ba %icc, .L732
nop
.L688:
ldsw [%sp + 96], %l0
mov %l0, %o0
call wait
nop
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L682
nop
.L732:
ldsw [%sp + 92], %l0
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

