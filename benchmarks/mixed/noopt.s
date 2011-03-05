	.section        ".text"
	.align 4
	.global tailrecursive
.type    tailrecursive, #function
tailrecursive:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L19269
nop
ba %icc, .L19272
nop
.L19269:
ret
restore
ba %icc, .L19277
nop
.L19272:
ba %icc, .L19277
nop
.L19277:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %o0
call tailrecursive
nop
ret
restore
	.size    tailrecursive, .-tailrecursive
	.align 4
	.global add
.type    add, #function
add:
save %sp, -104, %sp
mov %i0, %l1
mov %i1, %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    add, .-add
	.align 4
	.global domath
.type    domath, #function
domath:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l0
or %g0, 1, %o0
or %g0, 4, %o1
call calloc
nop
mov %o0, %l1
stw %l1, [%l0 + 8]
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l0
or %g0, 1, %o0
or %g0, 4, %o1
call calloc
nop
mov %o0, %l3
stw %l3, [%l0 + 8]
or %l2, 0, %l3
mov %i0, %l0
stw %l0, [%l3 + 0]
or %l1, 0, %l3
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%l3 + 0]
or %l2, 0, %l0
ldsw [%l0 + 8], %l3
or %l2, 0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l3 + 0]
or %l1, 0, %l0
ldsw [%l0 + 8], %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l3 + 0]
.L19353:
mov %i0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l0
movg %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L19359
nop
ba %icc, .L19428
nop
.L19359:
or %l2, 0, %l0
ldsw [%l0 + 0], %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l0
mulx %l3, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l3
or %l2, 0, %l0
ldsw [%l0 + 8], %l0
ldsw [%l0 + 0], %l0
mulx %l3, %l0, %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l0
sdivx %l3, %l0, %l0
or %l0, 0, %l0
or %l1, 0, %l0
ldsw [%l0 + 8], %l0
ldsw [%l0 + 0], %l3
or %l2, 0, %l0
ldsw [%l0 + 0], %l0
mov %l3, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l0
or %l1, 0, %l0
ldsw [%l0 + 0], %l3
or %l2, 0, %l0
ldsw [%l0 + 0], %l0
sub %l3, %l0, %l0
or %l0, 0, %l0
mov %i0, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l3, %l0, %l0
mov %l0, %i0
ba %icc, .L19353
nop
.L19428:
or %l2, 0, %l0
mov %l0, %o0
call free
nop
or %l1, 0, %l0
mov %l0, %o0
call free
nop
ret
restore
	.size    domath, .-domath
	.align 4
	.global objinstantiation
.type    objinstantiation, #function
objinstantiation:
save %sp, -96, %sp
.L19442:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L19448
nop
ba %icc, .L19474
nop
.L19448:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
mov %l0, %o0
call free
nop
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L19442
nop
.L19474:
ret
restore
	.size    objinstantiation, .-objinstantiation
	.align 4
	.global ackermann
.type    ackermann, #function
ackermann:
save %sp, -104, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L19486
nop
ba %icc, .L19495
nop
.L19486:
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L19500
nop
.L19495:
ba %icc, .L19500
nop
.L19500:
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L19506
nop
ba %icc, .L19519
nop
.L19506:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l1, %o0
mov %l0, %o1
call ackermann
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L19544
nop
.L19519:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %i0, %l3
mov %i1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
mov %l3, %o0
mov %l1, %o1
call ackermann
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call ackermann
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L19544
nop
.L19544:
	.size    ackermann, .-ackermann
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
or %l0, 0, %l4
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l3
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l2
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l4, 0, %l5
mov %l5, %o0
call tailrecursive
nop
or %l4, 0, %l4
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l4, %o1
call printf
nop
or %l3, 0, %l4
mov %l4, %o0
call domath
nop
or %l3, 0, %l3
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l3, %o1
call printf
nop
or %l2, 0, %l3
mov %l3, %o0
call objinstantiation
nop
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l1
or %l0, 0, %l0
mov %l1, %o0
mov %l0, %o1
call ackermann
nop
mov %o0, %l0
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
	.common globalfoo,4,4
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

