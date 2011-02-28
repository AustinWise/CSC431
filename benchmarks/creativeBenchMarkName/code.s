	.section        ".text"
	.align 4
	.global buildList
.type    buildList, #function
buildList:
save %sp, -128, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 100]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 104]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 108]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 112]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 116]
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 100], %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 124, %o1
call scanf
nop
ldsw [%sp + 124], %l1
stw %l1, [%l0 + 0]
ldsw [%sp + 104], %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 124, %o1
call scanf
nop
ldsw [%sp + 124], %l1
stw %l1, [%l0 + 0]
ldsw [%sp + 108], %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 124, %o1
call scanf
nop
ldsw [%sp + 124], %l1
stw %l1, [%l0 + 0]
ldsw [%sp + 112], %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 124, %o1
call scanf
nop
ldsw [%sp + 124], %l1
stw %l1, [%l0 + 0]
ldsw [%sp + 116], %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 124, %o1
call scanf
nop
ldsw [%sp + 124], %l1
stw %l1, [%l0 + 0]
ldsw [%sp + 120], %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 124, %o1
call scanf
nop
ldsw [%sp + 124], %l1
stw %l1, [%l0 + 0]
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 104], %l1
ldsw [%sp + 108], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 112], %l1
ldsw [%sp + 116], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 116], %l1
ldsw [%sp + 120], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 120], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 100], %l0
or %l0, 0, %i0
ret
restore
	.size    buildList, .-buildList
	.align 4
	.global multiple
.type    multiple, #function
multiple:
save %sp, -112, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
mov %i0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 100]
ldsw [%sp + 104], %l0
ldsw [%l0 + 4], %l0
stw %l0, [%sp + 104]
.L2200:
ldsw [%sp + 96], %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2206
nop
ba %icc, .L2244
nop
.L2206:
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 104], %l0
ldsw [%l0 + 4], %l0
stw %l0, [%sp + 104]
ldsw [%sp + 100], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L2200
nop
.L2244:
ldsw [%sp + 100], %l0
or %l0, 0, %i0
ret
restore
	.size    multiple, .-multiple
	.align 4
	.global add
.type    add, #function
add:
save %sp, -112, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
mov %i0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 100]
ldsw [%sp + 104], %l0
ldsw [%l0 + 4], %l0
stw %l0, [%sp + 104]
.L2275:
ldsw [%sp + 96], %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2281
nop
ba %icc, .L2319
nop
.L2281:
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 104], %l0
ldsw [%l0 + 4], %l0
stw %l0, [%sp + 104]
ldsw [%sp + 100], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L2275
nop
.L2319:
ldsw [%sp + 100], %l0
or %l0, 0, %i0
ret
restore
	.size    add, .-add
	.align 4
	.global recurseList
.type    recurseList, #function
recurseList:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2336
nop
ba %icc, .L2343
nop
.L2336:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L2360
nop
.L2343:
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call recurseList
nop
mov %o0, %l1
mulx %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L2360
nop
.L2360:
	.size    recurseList, .-recurseList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -120, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 112]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 108]
call buildList
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
mov %l0, %o0
call multiple
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 92], %l0
mov %l0, %o0
call add
nop
mov %o0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 96], %l2
ldsw [%sp + 100], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
sub %l2, %l0, %l0
stw %l0, [%sp + 104]
.L2404:
ldsw [%sp + 112], %l1
sethi %hi(10000), %l0
or %l0, %lo(10000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2410
nop
ba %icc, .L2439
nop
.L2410:
ldsw [%sp + 108], %l0
ldsw [%sp + 92], %l1
mov %l1, %o0
call recurseList
nop
mov %o0, %l1
add %l0, %l1, %l0
stw %l0, [%sp + 108]
ldsw [%sp + 112], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 112]
ba %icc, .L2404
nop
.L2439:
ldsw [%sp + 108], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
.L2443:
ldsw [%sp + 108], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2449
nop
ba %icc, .L2467
nop
.L2449:
ldsw [%sp + 108], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 108]
ba %icc, .L2443
nop
.L2467:
ldsw [%sp + 104], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 108], %l0
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

