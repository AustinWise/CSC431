	.section        ".text"
	.align 4
	.global getRands
.type    getRands, #function
getRands:
save %sp, -104, %sp
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
.L10959:
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
be %icc, .L10965
nop
ba %icc, .L11032
nop
.L10965:
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
ba %icc, .L10959
nop
.L11032:
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
.L11054:
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
be %icc, .L11060
nop
ba %icc, .L11094
nop
.L11060:
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
ba %icc, .L11054
nop
.L11094:
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
be %icc, .L11100
nop
ba %icc, .L11111
nop
.L11100:
or %l2, 0, %l2
or %l1, 0, %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L11116
nop
.L11111:
ba %icc, .L11116
nop
.L11116:
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
.L11139:
or %l2, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11146
nop
ba %icc, .L11179
nop
.L11146:
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
ba %icc, .L11139
nop
.L11179:
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
.L11189:
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
be %icc, .L11195
nop
ba %icc, .L11218
nop
.L11195:
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
ba %icc, .L11189
nop
.L11218:
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
.L11236:
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
be %icc, .L11242
nop
ba %icc, .L11326
nop
.L11242:
or %l0, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l4, %l3
be %icc, .L11247
nop
ba %icc, .L11265
nop
.L11247:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
ba %icc, .L11312
nop
.L11265:
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
be %icc, .L11275
nop
ba %icc, .L11283
nop
.L11275:
mov %i0, %l2
ldsw [%l2 + 0], %l2
or %l2, 0, %l2
ba %icc, .L11310
nop
.L11283:
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
be %icc, .L11293
nop
ba %icc, .L11301
nop
.L11293:
mov %i0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
ba %icc, .L11307
nop
.L11301:
ba %icc, .L11307
nop
.L11307:
ba %icc, .L11310
nop
.L11310:
ba %icc, .L11312
nop
.L11312:
mov %i0, %l3
ldsw [%l3 + 4], %l3
mov %l3, %i0
ba %icc, .L11236
nop
.L11326:
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

