	.section        ".text"
	.align 4
	.global isqrt
.type    isqrt, #function
isqrt:
save %sp, -96, %sp
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(3), %l3
or %l3, %lo(3), %l3
.L9798:
or %l4, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L9805
nop
ba %icc, .L9833
nop
.L9805:
or %l4, 0, %l1
or %l3, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l4
or %l3, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ba %icc, .L9798
nop
.L9833:
or %l3, 0, %l0
sra %l0, 1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    isqrt, .-isqrt
	.align 4
	.global prime
.type    prime, #function
prime:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L9856
nop
ba %icc, .L9861
nop
.L9856:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L9939
nop
.L9861:
mov %i0, %l0
mov %l0, %o0
call isqrt
nop
mov %o0, %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
.L9874:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movle %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L9881
nop
ba %icc, .L9933
nop
.L9881:
mov %i0, %l4
mov %i0, %l3
or %l0, 0, %l2
sdivx %l3, %l2, %l3
or %l0, 0, %l2
mulx %l3, %l2, %l2
sub %l4, %l2, %l2
or %l2, 0, %l2
or %l2, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L9906
nop
ba %icc, .L9911
nop
.L9906:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L9916
nop
.L9911:
ba %icc, .L9916
nop
.L9916:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L9874
nop
.L9933:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L9939
nop
.L9939:
	.size    prime, .-prime
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
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
.L9951:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movle %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L9958
nop
ba %icc, .L9993
nop
.L9958:
or %l0, 0, %l2
mov %l2, %o0
call prime
nop
mov %o0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l3, %l2
be %icc, .L9965
nop
ba %icc, .L9971
nop
.L9965:
or %l0, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
ba %icc, .L9976
nop
.L9971:
ba %icc, .L9976
nop
.L9976:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L9951
nop
.L9993:
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

