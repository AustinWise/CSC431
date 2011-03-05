	.section        ".text"
	.align 4
	.global move
.type    move, #function
move:
save %sp, -104, %sp
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
be %icc, .L18388
nop
ba %icc, .L18401
nop
.L18388:
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
ba %icc, .L18441
nop
.L18401:
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
be %icc, .L18409
nop
ba %icc, .L18422
nop
.L18409:
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
ba %icc, .L18439
nop
.L18422:
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
ba %icc, .L18439
nop
.L18439:
ba %icc, .L18441
nop
.L18441:
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
be %icc, .L18447
nop
ba %icc, .L18460
nop
.L18447:
or %l0, 0, %l2
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l1, [%l0 + 0]
ba %icc, .L18500
nop
.L18460:
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
be %icc, .L18468
nop
ba %icc, .L18481
nop
.L18468:
or %l0, 0, %l2
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
stw %l1, [%l0 + 0]
ba %icc, .L18498
nop
.L18481:
or %l0, 0, %l2
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
ba %icc, .L18498
nop
.L18498:
ba %icc, .L18500
nop
.L18500:
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
save %sp, -112, %sp
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
be %icc, .L18520
nop
ba %icc, .L18529
nop
.L18520:
mov %i1, %l1
mov %i2, %l0
mov %l1, %o0
mov %l0, %o1
call move
nop
ba %icc, .L18573
nop
.L18529:
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
ba %icc, .L18573
nop
.L18573:
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
.L18584:
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
be %icc, .L18590
nop
ba %icc, .L18611
nop
.L18590:
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
ba %icc, .L18584
nop
.L18611:
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
be %icc, .L18641
nop
ba %icc, .L18780
nop
.L18641:
or %l0, 0, %l1
or %l1, 0, %l1
.L18648:
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
be %icc, .L18654
nop
ba %icc, .L18693
nop
.L18654:
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
ba %icc, .L18648
nop
.L18693:
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
.L18749:
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
be %icc, .L18755
nop
ba %icc, .L18782
nop
.L18755:
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
ba %icc, .L18749
nop
.L18782:
ba %icc, .L18785
nop
.L18780:
ba %icc, .L18785
nop
.L18785:
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

