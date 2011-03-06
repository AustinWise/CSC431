	.section        ".text"
	.align 4
	.global getRands
.type    getRands, #function
getRands:
save %sp, -96, %sp
mov %i0, %l2
mov %i0, %l0
mulx %l2, %l0, %l0
or %l0, 0, %l2
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
sethi %hi(0), %l3
or %l3, %lo(0), %l3
stw %l3, [%l4 + 4]
mov %i1, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sub %l4, %l3, %l3
mov %l3, %i1
or %l2, 0, %l2
or %l2, 0, %l5
.L22383:
mov %i1, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movg %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L22389
nop
ba %icc, .L22456
nop
.L22389:
or %l5, 0, %l2
or %l5, 0, %l1
mulx %l2, %l1, %l2
mov %i0, %l1
sdivx %l2, %l1, %l3
mov %i0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sdivx %l2, %l1, %l1
mulx %l3, %l1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l2, %l1, %l1
or %l1, 0, %l2
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l1
or %l1, 0, %l1
or %l1, 0, %l4
or %l2, 0, %l3
stw %l3, [%l4 + 0]
or %l1, 0, %l3
or %l0, 0, %l0
stw %l0, [%l3 + 4]
or %l1, 0, %l0
or %l0, 0, %l0
mov %i1, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sub %l4, %l3, %l3
mov %l3, %i1
or %l2, 0, %l2
or %l2, 0, %l5
ba %icc, .L22383
nop
.L22456:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    getRands, .-getRands
	.align 4
	.global calcMean
.type    calcMean, #function
calcMean:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L22479:
mov %i0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movne %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L22485
nop
ba %icc, .L22519
nop
.L22485:
or %l1, 0, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l3, %l1, %l1
or %l1, 0, %l1
or %l2, 0, %l3
mov %i0, %l2
ldsw [%l2 + 0], %l2
add %l3, %l2, %l2
or %l2, 0, %l2
mov %i0, %l3
ldsw [%l3 + 4], %l3
mov %l3, %i0
ba %icc, .L22479
nop
.L22519:
or %l1, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movne %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L22525
nop
ba %icc, .L22536
nop
.L22525:
or %l2, 0, %l2
or %l1, 0, %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L22541
nop
.L22536:
ba %icc, .L22541
nop
.L22541:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    calcMean, .-calcMean
	.align 4
	.global approxSqrt
.type    approxSqrt, #function
approxSqrt:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l4
or %l4, 0, %l0
or %l0, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
.L22565:
or %l2, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L22572
nop
ba %icc, .L22605
nop
.L22572:
or %l4, 0, %l1
or %l4, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l2
or %l4, 0, %l0
or %l0, 0, %l3
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ba %icc, .L22565
nop
.L22605:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    approxSqrt, .-approxSqrt
	.align 4
	.global approxSqrtAll
.type    approxSqrtAll, #function
approxSqrtAll:
save %sp, -96, %sp
.L22616:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L22622
nop
ba %icc, .L22645
nop
.L22622:
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l0, %o0
call approxSqrt
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ba %icc, .L22616
nop
.L22645:
ret
restore
	.size    approxSqrtAll, .-approxSqrtAll
	.align 4
	.global range
.type    range, #function
range:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l0
.L22664:
mov %i0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movne %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L22670
nop
ba %icc, .L22754
nop
.L22670:
or %l0, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l4, %l3
be %icc, .L22675
nop
ba %icc, .L22693
nop
.L22675:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
ba %icc, .L22740
nop
.L22693:
mov %i0, %l3
ldsw [%l3 + 0], %l4
or %l2, 0, %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L22703
nop
ba %icc, .L22711
nop
.L22703:
mov %i0, %l2
ldsw [%l2 + 0], %l2
or %l2, 0, %l2
ba %icc, .L22738
nop
.L22711:
mov %i0, %l3
ldsw [%l3 + 0], %l4
or %l1, 0, %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movg %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L22721
nop
ba %icc, .L22729
nop
.L22721:
mov %i0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
ba %icc, .L22735
nop
.L22729:
ba %icc, .L22735
nop
.L22735:
ba %icc, .L22738
nop
.L22738:
ba %icc, .L22740
nop
.L22740:
mov %i0, %l3
ldsw [%l3 + 4], %l3
mov %l3, %i0
ba %icc, .L22664
nop
.L22754:
or %l2, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    range, .-range
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
or %l0, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l1
or %l1, 0, %l2
or %l0, 0, %l1
or %l2, 0, %l0
mov %l1, %o0
mov %l0, %o1
call getRands
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
mov %l1, %o0
call calcMean
nop
mov %o0, %l1
or %l1, 0, %l1
or %l1, 0, %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
or %l0, 0, %l1
mov %l1, %o0
call range
nop
or %l0, 0, %l0
mov %l0, %o0
call approxSqrtAll
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

