	.section        ".text"
	.align 4
	.global getRands
.type    getRands, #function
getRands:
save %sp, -120, %sp
mov %i0, %l1
mov %i0, %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 100]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 112]
ldsw [%sp + 112], %l1
ldsw [%sp + 100], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 112], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ldsw [%sp + 100], %l0
stw %l0, [%sp + 104]
.L6758:
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
be %icc, .L6764
nop
ba %icc, .L6831
nop
.L6764:
ldsw [%sp + 104], %l1
ldsw [%sp + 104], %l0
mulx %l1, %l0, %l1
mov %i0, %l0
sdivx %l1, %l0, %l2
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
mulx %l2, %l0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 108]
ldsw [%sp + 108], %l1
ldsw [%sp + 100], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 108], %l0
stw %l0, [%sp + 112]
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ldsw [%sp + 100], %l0
stw %l0, [%sp + 104]
ba %icc, .L6758
nop
.L6831:
ldsw [%sp + 108], %l0
or %l0, 0, %i0
ret
restore
	.size    getRands, .-getRands
	.align 4
	.global calcMean
.type    calcMean, #function
calcMean:
save %sp, -112, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 100]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 104]
.L6853:
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
be %icc, .L6859
nop
ba %icc, .L6893
nop
.L6859:
ldsw [%sp + 100], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 96], %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ba %icc, .L6853
nop
.L6893:
ldsw [%sp + 100], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6899
nop
ba %icc, .L6910
nop
.L6899:
ldsw [%sp + 96], %l1
ldsw [%sp + 100], %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 104]
ba %icc, .L6915
nop
.L6910:
ba %icc, .L6915
nop
.L6915:
ldsw [%sp + 104], %l0
or %l0, 0, %i0
ret
restore
	.size    calcMean, .-calcMean
	.align 4
	.global approxSqrt
.type    approxSqrt, #function
approxSqrt:
save %sp, -112, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
stw %l0, [%sp + 104]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 100]
.L6938:
ldsw [%sp + 100], %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6945
nop
ba %icc, .L6978
nop
.L6945:
ldsw [%sp + 96], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 96], %l0
stw %l0, [%sp + 104]
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L6938
nop
.L6978:
ldsw [%sp + 104], %l0
or %l0, 0, %i0
ret
restore
	.size    approxSqrt, .-approxSqrt
	.align 4
	.global approxSqrtAll
.type    approxSqrtAll, #function
approxSqrtAll:
save %sp, -96, %sp
.L6988:
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
be %icc, .L6994
nop
ba %icc, .L7017
nop
.L6994:
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
ba %icc, .L6988
nop
.L7017:
ret
restore
	.size    approxSqrtAll, .-approxSqrtAll
	.align 4
	.global range
.type    range, #function
range:
save %sp, -112, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 100]
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 104]
.L7035:
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
be %icc, .L7041
nop
ba %icc, .L7125
nop
.L7041:
ldsw [%sp + 104], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L7046
nop
ba %icc, .L7064
nop
.L7046:
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 96]
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 100]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 104]
ba %icc, .L7111
nop
.L7064:
mov %i0, %l0
ldsw [%l0 + 0], %l1
ldsw [%sp + 96], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7074
nop
ba %icc, .L7082
nop
.L7074:
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 96]
ba %icc, .L7109
nop
.L7082:
mov %i0, %l0
ldsw [%l0 + 0], %l1
ldsw [%sp + 100], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7092
nop
ba %icc, .L7100
nop
.L7092:
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 100]
ba %icc, .L7106
nop
.L7100:
ba %icc, .L7106
nop
.L7106:
ba %icc, .L7109
nop
.L7109:
ba %icc, .L7111
nop
.L7111:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ba %icc, .L7035
nop
.L7125:
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 100], %l0
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
save %sp, -112, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 108, %o1
call scanf
nop
ldsw [%sp + 108], %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 108, %o1
call scanf
nop
ldsw [%sp + 108], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mov %l1, %o0
mov %l0, %o1
call getRands
nop
mov %o0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l0
mov %l0, %o0
call calcMean
nop
mov %o0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 100], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 104], %l0
mov %l0, %o0
call range
nop
ldsw [%sp + 104], %l0
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

