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
be %icc, .L6755
nop
ba %icc, .L6758
nop
.L6755:
ret
restore
ba %icc, .L6763
nop
.L6758:
ba %icc, .L6763
nop
.L6763:
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
.L6839:
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
be %icc, .L6845
nop
ba %icc, .L6914
nop
.L6845:
or %l1, 0, %l0
ldsw [%l0 + 8], %l0
ldsw [%l0 + 0], %l3
or %l2, 0, %l0
ldsw [%l0 + 0], %l0
mov %l3, %o0
mov %l0, %o1
call add
nop
mov %i0, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l3, %l0, %l0
mov %l0, %i0
ba %icc, .L6839
nop
.L6914:
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
.L6928:
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
be %icc, .L6934
nop
ba %icc, .L6960
nop
.L6934:
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
ba %icc, .L6928
nop
.L6960:
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
be %icc, .L6972
nop
ba %icc, .L6981
nop
.L6972:
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6986
nop
.L6981:
ba %icc, .L6986
nop
.L6986:
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
be %icc, .L6992
nop
ba %icc, .L7005
nop
.L6992:
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
ba %icc, .L7030
nop
.L7005:
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
ba %icc, .L7030
nop
.L7030:
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

