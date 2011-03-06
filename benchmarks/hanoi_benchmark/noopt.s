	.section        ".text"
	.align 4
	.global move
.type    move, #function
move:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L18545
nop
ba %icc, .L18558
nop
.L18545:
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l0
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
ldsw [%l1 + 4], %l2
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
stw %l2, [%l1 + 0]
ba %icc, .L18598
nop
.L18558:
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L18566
nop
ba %icc, .L18579
nop
.L18566:
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l0
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
ldsw [%l1 + 4], %l2
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
stw %l2, [%l1 + 0]
ba %icc, .L18596
nop
.L18579:
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l0
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
ldsw [%l1 + 4], %l2
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
stw %l2, [%l1 + 0]
ba %icc, .L18596
nop
.L18596:
ba %icc, .L18598
nop
.L18598:
mov %i1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
move %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L18604
nop
ba %icc, .L18617
nop
.L18604:
or %l0, 0, %l2
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l1, [%l0 + 0]
ba %icc, .L18657
nop
.L18617:
mov %i1, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
move %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L18625
nop
ba %icc, .L18638
nop
.L18625:
or %l0, 0, %l2
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
stw %l1, [%l0 + 0]
ba %icc, .L18655
nop
.L18638:
or %l0, 0, %l2
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
ba %icc, .L18655
nop
.L18655:
ba %icc, .L18657
nop
.L18657:
sethi %hi(numMoves), %l0
or %l0, %lo(numMoves), %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l1
sethi %hi(numMoves), %l0
or %l0, %lo(numMoves), %l0
stw %l1, [%l0 + 0]
ret
restore
	.size    move, .-move
	.align 4
	.global hanoi
.type    hanoi, #function
hanoi:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L18681
nop
ba %icc, .L18690
nop
.L18681:
mov %i1, %l1
mov %i2, %l0
mov %l1, %o0
mov %l0, %o1
call move
nop
ba %icc, .L18734
nop
.L18690:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l3
mov %i1, %l2
mov %i3, %l1
mov %i2, %l0
mov %l3, %o0
mov %l2, %o1
mov %l1, %o2
mov %l0, %o3
call hanoi
nop
mov %i1, %l1
mov %i2, %l0
mov %l1, %o0
mov %l0, %o1
call move
nop
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l3
mov %i3, %l2
mov %i2, %l1
mov %i1, %l0
mov %l3, %o0
mov %l2, %o1
mov %l1, %o2
mov %l0, %o3
call hanoi
nop
ba %icc, .L18734
nop
.L18734:
ret
restore
	.size    hanoi, .-hanoi
	.align 4
	.global printPeg
.type    printPeg, #function
printPeg:
save %sp, -96, %sp
mov %i0, %l0
or %l0, 0, %l0
.L18746:
or %l0, 0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movne %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L18752
nop
ba %icc, .L18773
nop
.L18752:
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
ba %icc, .L18746
nop
.L18773:
ret
restore
	.size    printPeg, .-printPeg
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(numMoves), %l0
or %l0, %lo(numMoves), %l0
stw %l1, [%l0 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l0, 0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movge %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L18803
nop
ba %icc, .L18942
nop
.L18803:
or %l0, 0, %l1
or %l1, 0, %l1
.L18810:
or %l1, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movne %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L18816
nop
ba %icc, .L18855
nop
.L18816:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l2
or %l2, 0, %l4
or %l4, 0, %l3
or %l1, 0, %l2
stw %l2, [%l3 + 0]
or %l4, 0, %l3
sethi %hi(peg1), %l2
or %l2, %lo(peg1), %l2
ldsw [%l2 + 0], %l2
stw %l2, [%l3 + 4]
or %l4, 0, %l3
sethi %hi(peg1), %l2
or %l2, %lo(peg1), %l2
stw %l3, [%l2 + 0]
or %l1, 0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
or %l1, 0, %l1
ba %icc, .L18810
nop
.L18855:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
mov %l1, %o0
call printPeg
nop
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
mov %l1, %o0
call printPeg
nop
sethi %hi(3), %l1
or %l1, %lo(3), %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
mov %l1, %o0
call printPeg
nop
or %l0, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sethi %hi(3), %l1
or %l1, %lo(3), %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l3, %o0
mov %l2, %o1
mov %l1, %o2
mov %l0, %o3
call hanoi
nop
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
ldsw [%l0 + 0], %l0
mov %l0, %o0
call printPeg
nop
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
ldsw [%l0 + 0], %l0
mov %l0, %o0
call printPeg
nop
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
ldsw [%l0 + 0], %l0
mov %l0, %o0
call printPeg
nop
sethi %hi(numMoves), %l0
or %l0, %lo(numMoves), %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
.L18911:
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
ldsw [%l0 + 0], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L18917
nop
ba %icc, .L18944
nop
.L18917:
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l4
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
ldsw [%l0 + 0], %l0
ldsw [%l0 + 4], %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
or %l4, 0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L18911
nop
.L18944:
ba %icc, .L18947
nop
.L18942:
ba %icc, .L18947
nop
.L18947:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common peg1,4,4
	.common peg2,4,4
	.common peg3,4,4
	.common numMoves,4,4
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

