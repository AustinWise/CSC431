	.section        ".text"
	.align 4
	.global tailrecursive
.type    tailrecursive, #function
tailrecursive:
save %sp, -104, %sp
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
be %icc, .L3835
nop
ba %icc, .L3838
nop
.L3835:
ret
restore
ba %icc, .L3843
nop
.L3838:
ba %icc, .L3843
nop
.L3843:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 96]
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
save %sp, -112, %sp
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
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
stw %l0, [%sp + 100]
ldsw [%sp + 100], %l0
or %g0, 1, %o0
or %g0, 4, %o1
call calloc
nop
mov %o0, %l1
stw %l1, [%l0 + 8]
ldsw [%sp + 96], %l1
mov %i0, %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 100], %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 96], %l0
ldsw [%l0 + 8], %l1
ldsw [%sp + 96], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 100], %l0
ldsw [%l0 + 8], %l1
ldsw [%sp + 100], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l1 + 0]
.L3919:
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
be %icc, .L3925
nop
ba %icc, .L3994
nop
.L3925:
ldsw [%sp + 96], %l0
ldsw [%l0 + 0], %l1
ldsw [%sp + 100], %l0
ldsw [%l0 + 0], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l1
ldsw [%sp + 96], %l0
ldsw [%l0 + 8], %l0
ldsw [%l0 + 0], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 100], %l0
ldsw [%l0 + 0], %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 100], %l0
ldsw [%l0 + 8], %l0
ldsw [%l0 + 0], %l1
ldsw [%sp + 96], %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 100], %l0
ldsw [%l0 + 0], %l1
ldsw [%sp + 96], %l0
ldsw [%l0 + 0], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 104]
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L3919
nop
.L3994:
ldsw [%sp + 96], %l0
mov %l0, %o0
call free
nop
ldsw [%sp + 100], %l0
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
save %sp, -104, %sp
.L4008:
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
be %icc, .L4014
nop
ba %icc, .L4040
nop
.L4014:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
mov %l0, %o0
call free
nop
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L4008
nop
.L4040:
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
be %icc, .L4052
nop
ba %icc, .L4061
nop
.L4052:
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L4066
nop
.L4061:
ba %icc, .L4066
nop
.L4066:
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
be %icc, .L4072
nop
ba %icc, .L4085
nop
.L4072:
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
ba %icc, .L4110
nop
.L4085:
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
ba %icc, .L4110
nop
.L4110:
	.size    ackermann, .-ackermann
	.align 4
	.global main
.type    main, #function
main:
save %sp, -120, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 96]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 100]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 104]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 108]
ldsw [%sp + 92], %l0
mov %l0, %o0
call tailrecursive
nop
ldsw [%sp + 92], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 96], %l0
mov %l0, %o0
call domath
nop
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 100], %l0
mov %l0, %o0
call objinstantiation
nop
ldsw [%sp + 100], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 104], %l1
ldsw [%sp + 108], %l0
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

