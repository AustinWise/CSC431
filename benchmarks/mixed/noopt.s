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
be %icc, .L18986
nop
ba %icc, .L18989
nop
.L18986:
ret
restore
ba %icc, .L18994
nop
.L18989:
ba %icc, .L18994
nop
.L18994:
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
save %sp, -96, %sp
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
.L19073:
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
be %icc, .L19079
nop
ba %icc, .L19148
nop
.L19079:
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
ba %icc, .L19073
nop
.L19148:
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
.L19163:
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
be %icc, .L19169
nop
ba %icc, .L19195
nop
.L19169:
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
ba %icc, .L19163
nop
.L19195:
ret
restore
	.size    objinstantiation, .-objinstantiation
	.align 4
	.global ackermann
.type    ackermann, #function
ackermann:
save %sp, -96, %sp
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
be %icc, .L19209
nop
ba %icc, .L19218
nop
.L19209:
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L19223
nop
.L19218:
ba %icc, .L19223
nop
.L19223:
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
be %icc, .L19229
nop
ba %icc, .L19242
nop
.L19229:
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
ba %icc, .L19267
nop
.L19242:
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
ba %icc, .L19267
nop
.L19267:
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

