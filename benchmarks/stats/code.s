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
.L11047:
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
be %icc, .L11053
nop
ba %icc, .L11120
nop
.L11053:
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
ba %icc, .L11047
nop
.L11120:
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
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
.L11143:
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
be %icc, .L11149
nop
ba %icc, .L11183
nop
.L11149:
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
ba %icc, .L11143
nop
.L11183:
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
be %icc, .L11189
nop
ba %icc, .L11200
nop
.L11189:
or %l2, 0, %l2
or %l1, 0, %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L11205
nop
.L11200:
ba %icc, .L11205
nop
.L11205:
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
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L11229:
or %l2, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11236
nop
ba %icc, .L11269
nop
.L11236:
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
ba %icc, .L11229
nop
.L11269:
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
.L11280:
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
be %icc, .L11286
nop
ba %icc, .L11309
nop
.L11286:
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
ba %icc, .L11280
nop
.L11309:
ret
restore
	.size    approxSqrtAll, .-approxSqrtAll
	.align 4
	.global range
.type    range, #function
range:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
.L11328:
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
be %icc, .L11334
nop
ba %icc, .L11418
nop
.L11334:
or %l0, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l4, %l3
be %icc, .L11339
nop
ba %icc, .L11357
nop
.L11339:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
ba %icc, .L11404
nop
.L11357:
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
be %icc, .L11367
nop
ba %icc, .L11375
nop
.L11367:
mov %i0, %l2
ldsw [%l2 + 0], %l2
or %l2, 0, %l2
ba %icc, .L11402
nop
.L11375:
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
be %icc, .L11385
nop
ba %icc, .L11393
nop
.L11385:
mov %i0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
ba %icc, .L11399
nop
.L11393:
ba %icc, .L11399
nop
.L11399:
ba %icc, .L11402
nop
.L11402:
ba %icc, .L11404
nop
.L11404:
mov %i0, %l3
ldsw [%l3 + 4], %l3
mov %l3, %i0
ba %icc, .L11328
nop
.L11418:
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

