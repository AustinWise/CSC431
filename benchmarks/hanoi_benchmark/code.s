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
be %icc, .L5317
nop
ba %icc, .L5330
nop
.L5317:
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
ba %icc, .L5370
nop
.L5330:
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
be %icc, .L5338
nop
ba %icc, .L5351
nop
.L5338:
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
ba %icc, .L5368
nop
.L5351:
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
ba %icc, .L5368
nop
.L5368:
ba %icc, .L5370
nop
.L5370:
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
be %icc, .L5376
nop
ba %icc, .L5389
nop
.L5376:
or %l0, 0, %l2
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l1, [%l0 + 0]
ba %icc, .L5429
nop
.L5389:
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
be %icc, .L5397
nop
ba %icc, .L5410
nop
.L5397:
or %l0, 0, %l2
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
stw %l1, [%l0 + 0]
ba %icc, .L5427
nop
.L5410:
or %l0, 0, %l2
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
ba %icc, .L5427
nop
.L5427:
ba %icc, .L5429
nop
.L5429:
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
be %icc, .L5453
nop
ba %icc, .L5462
nop
.L5453:
mov %i1, %l1
mov %i2, %l0
mov %l1, %o0
mov %l0, %o1
call move
nop
ba %icc, .L5506
nop
.L5462:
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
ba %icc, .L5506
nop
.L5506:
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
.L5518:
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
be %icc, .L5524
nop
ba %icc, .L5545
nop
.L5524:
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
ba %icc, .L5518
nop
.L5545:
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
be %icc, .L5575
nop
ba %icc, .L5714
nop
.L5575:
or %l0, 0, %l1
or %l1, 0, %l1
.L5582:
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
be %icc, .L5588
nop
ba %icc, .L5627
nop
.L5588:
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
ba %icc, .L5582
nop
.L5627:
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
.L5683:
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
be %icc, .L5689
nop
ba %icc, .L5716
nop
.L5689:
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
ba %icc, .L5683
nop
.L5716:
ba %icc, .L5719
nop
.L5714:
ba %icc, .L5719
nop
.L5719:
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

