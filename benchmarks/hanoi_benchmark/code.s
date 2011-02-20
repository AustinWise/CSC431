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
be %icc, .L2954
nop
ba %icc, .L2967
nop
.L2954:
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
ba %icc, .L3007
nop
.L2967:
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
be %icc, .L2975
nop
ba %icc, .L2988
nop
.L2975:
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
ba %icc, .L3005
nop
.L2988:
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
ba %icc, .L3005
nop
.L3005:
ba %icc, .L3007
nop
.L3007:
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
be %icc, .L3013
nop
ba %icc, .L3026
nop
.L3013:
or %l0, 0, %l2
sethi %hi(peg1), %l1
or %l1, %lo(peg1), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l1, [%l0 + 0]
ba %icc, .L3066
nop
.L3026:
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
be %icc, .L3034
nop
ba %icc, .L3047
nop
.L3034:
or %l0, 0, %l2
sethi %hi(peg2), %l1
or %l1, %lo(peg2), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg2), %l0
or %l0, %lo(peg2), %l0
stw %l1, [%l0 + 0]
ba %icc, .L3064
nop
.L3047:
or %l0, 0, %l2
sethi %hi(peg3), %l1
or %l1, %lo(peg3), %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 4]
or %l0, 0, %l1
sethi %hi(peg3), %l0
or %l0, %lo(peg3), %l0
stw %l1, [%l0 + 0]
ba %icc, .L3064
nop
.L3064:
ba %icc, .L3066
nop
.L3066:
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
be %icc, .L3086
nop
ba %icc, .L3095
nop
.L3086:
mov %i1, %l1
mov %i2, %l0
mov %l1, %o0
mov %l0, %o1
call move
nop
ba %icc, .L3139
nop
.L3095:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l3
mov %i1, %l0
mov %i3, %l2
mov %i2, %l1
mov %l3, %o0
mov %l0, %o1
mov %l2, %o2
mov %l1, %o3
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
ba %icc, .L3139
nop
.L3139:
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
.L3150:
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
be %icc, .L3156
nop
ba %icc, .L3177
nop
.L3156:
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
ba %icc, .L3150
nop
.L3177:
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
or %l0, 0, %l1
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
movge %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L3207
nop
ba %icc, .L3346
nop
.L3207:
or %l1, 0, %l0
or %l0, 0, %l2
.L3214:
or %l2, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l0
movne %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L3220
nop
ba %icc, .L3259
nop
.L3220:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l4
or %l2, 0, %l3
stw %l3, [%l4 + 0]
or %l0, 0, %l4
sethi %hi(peg1), %l3
or %l3, %lo(peg1), %l3
ldsw [%l3 + 0], %l3
stw %l3, [%l4 + 4]
or %l0, 0, %l3
sethi %hi(peg1), %l0
or %l0, %lo(peg1), %l0
stw %l3, [%l0 + 0]
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L3214
nop
.L3259:
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
or %l1, 0, %l3
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
.L3315:
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
be %icc, .L3321
nop
ba %icc, .L3348
nop
.L3321:
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
or %l0, 0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L3315
nop
.L3348:
ba %icc, .L3351
nop
.L3346:
ba %icc, .L3351
nop
.L3351:
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
