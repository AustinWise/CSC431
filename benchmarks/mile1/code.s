	.section        ".text"
	.align 4
	.global calcPower
.type    calcPower, #function
calcPower:
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 100]
.L3695:
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
be %icc, .L3701
nop
ba %icc, .L3728
nop
.L3701:
ldsw [%sp + 100], %l1
mov %i0, %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 100]
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ba %icc, .L3695
nop
.L3728:
ldsw [%sp + 100], %l0
or %l0, 0, %i0
ret
restore
	.size    calcPower, .-calcPower
	.align 4
	.global main
.type    main, #function
main:
save %sp, -120, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
stw %l0, [%l1 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
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
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
stw %l0, [%l1 + 4]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 108]
.L3779:
ldsw [%sp + 108], %l1
sethi %hi(1000000), %l0
or %l0, %lo(1000000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3785
nop
ba %icc, .L3815
nop
.L3785:
ldsw [%sp + 108], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 108]
ldsw [%sp + 92], %l0
ldsw [%l0 + 0], %l1
ldsw [%sp + 92], %l0
ldsw [%l0 + 4], %l0
mov %l1, %o0
mov %l0, %o1
call calcPower
nop
mov %o0, %l0
stw %l0, [%sp + 100]
ba %icc, .L3779
nop
.L3815:
ldsw [%sp + 100], %l0
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

