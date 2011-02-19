	.section        ".text"
	.align 4
	.global calcPower
.type    calcPower, #function
calcPower:
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l0
.L3695:
mov %i1, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movg %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L3701
nop
ba %icc, .L3728
nop
.L3701:
or %l0, 0, %l1
mov %i0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
mov %i1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
mov %l1, %i1
ba %icc, .L3695
nop
.L3728:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    calcPower, .-calcPower
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l2, 0, %l3
or %l0, 0, %l0
stw %l0, [%l3 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l0, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L3758
nop
ba %icc, .L3764
nop
.L3758:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L3769
nop
.L3764:
ba %icc, .L3769
nop
.L3769:
or %l2, 0, %l3
or %l0, 0, %l0
stw %l0, [%l3 + 4]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L3779:
or %l0, 0, %l4
sethi %hi(1000000), %l3
or %l3, %lo(1000000), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L3785
nop
ba %icc, .L3815
nop
.L3785:
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l2, 0, %l1
ldsw [%l1 + 0], %l3
or %l2, 0, %l1
ldsw [%l1 + 4], %l1
mov %l3, %o0
mov %l1, %o1
call calcPower
nop
mov %o0, %l1
or %l1, 0, %l1
ba %icc, .L3779
nop
.L3815:
or %l1, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(1), %l0
or %l0, %lo(1), %l0
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

