	.section        ".text"
	.align 4
	.global getIntList
.type    getIntList, #function
getIntList:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l0, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sub %l2, %l3, %l2
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l4, %l2
move %icc, 1, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l3, %l2
be %icc, .L1553
nop
ba %icc, .L1559
nop
.L1553:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1579
nop
.L1559:
or %l1, 0, %l2
or %l0, 0, %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l2
call getIntList
nop
mov %o0, %l0
stw %l0, [%l2 + 4]
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1579
nop
.L1579:
	.size    getIntList, .-getIntList
	.align 4
	.global biggest
.type    biggest, #function
biggest:
save %sp, -104, %sp
mov %i0, %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L1592
nop
ba %icc, .L1598
nop
.L1592:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1607
nop
.L1598:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1607
nop
.L1607:
	.size    biggest, .-biggest
	.align 4
	.global biggestInList
.type    biggestInList, #function
biggestInList:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l0
.L1619:
mov %i0, %l1
ldsw [%l1 + 4], %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movne %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L1626
nop
ba %icc, .L1654
nop
.L1626:
or %l0, 0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call biggest
nop
mov %o0, %l0
or %l0, 0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %i0
ba %icc, .L1619
nop
.L1654:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    biggestInList, .-biggestInList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
call getIntList
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
mov %l0, %o0
call biggestInList
nop
mov %o0, %l0
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

