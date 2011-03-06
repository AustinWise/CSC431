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
be %icc, .L5731
nop
ba %icc, .L5744
nop
.L5731:
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
ba %icc, .L5784
nop
.L5744:
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
be %icc, .L5752
nop
ba %icc, .L5765
nop
.L5752:
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
ba %icc, .L5782
nop
.L5765:
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
ba %icc, .L5782
nop
.L5782:
ba %icc, .L5784
nop
.L5784:
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
be %icc, .L5790
nop
ba %icc, .L5803
nop
.L5790:
or %l0, 0, %l2
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l1, [%l0 + 0]
ba %icc, .L5843
nop
.L5803:
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
be %icc, .L5811
nop
ba %icc, .L5824
nop
.L5811:
or %l0, 0, %l2
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
stw %l1, [%l0 + 0]
ba %icc, .L5841
nop
.L5824:
or %l0, 0, %l2
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
ba %icc, .L5841
nop
.L5841:
ba %icc, .L5843
nop
.L5843:
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
be %icc, .L5863
nop
ba %icc, .L5872
nop
.L5863:
mov %i1, %l1
mov %i2, %l0
mov %l1, %o0
mov %l0, %o1
call move
nop
ba %icc, .L5916
nop
.L5872:
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
ba %icc, .L5916
nop
.L5916:
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
.L5927:
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
be %icc, .L5933
nop
ba %icc, .L5954
nop
.L5933:
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
ba %icc, .L5927
nop
.L5954:
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
be %icc, .L5984
nop
ba %icc, .L6123
nop
.L5984:
or %l0, 0, %l1
or %l1, 0, %l1
.L5991:
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
be %icc, .L5997
nop
ba %icc, .L6036
nop
.L5997:
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
ba %icc, .L5991
nop
.L6036:
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
.L6092:
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
be %icc, .L6098
nop
ba %icc, .L6125
nop
.L6098:
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
ba %icc, .L6092
nop
.L6125:
ba %icc, .L6128
nop
.L6123:
ba %icc, .L6128
nop
.L6128:
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

