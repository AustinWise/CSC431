	.section        ".text"
	.align 4
	.global concatLists
.type    concatLists, #function
concatLists:
save %sp, -96, %sp
mov %i0, %l0
or %l0, 0, %l3
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
be %icc, .L14498
nop
ba %icc, .L14504
nop
.L14498:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14509
nop
.L14504:
ba %icc, .L14509
nop
.L14509:
or %l3, 0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14516
nop
ba %icc, .L14533
nop
.L14516:
or %l3, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l3
ba %icc, .L14509
nop
.L14533:
or %l3, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    concatLists, .-concatLists
	.align 4
	.global add
.type    add, #function
add:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
mov %i0, %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    add, .-add
	.align 4
	.global size
.type    size, #function
size:
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
be %icc, .L14584
nop
ba %icc, .L14589
nop
.L14584:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14594
nop
.L14589:
ba %icc, .L14594
nop
.L14594:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call size
nop
mov %o0, %l1
add %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
	.size    size, .-size
	.align 4
	.global get
.type    get, #function
get:
save %sp, -96, %sp
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
be %icc, .L14618
nop
ba %icc, .L14625
nop
.L14618:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14630
nop
.L14625:
ba %icc, .L14630
nop
.L14630:
mov %i0, %l0
ldsw [%l0 + 4], %l2
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l2, %o0
mov %l0, %o1
call get
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    get, .-get
	.align 4
	.global pop
.type    pop, #function
pop:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    pop, .-pop
	.align 4
	.global printList
.type    printList, #function
printList:
save %sp, -96, %sp
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
be %icc, .L14673
nop
ba %icc, .L14685
nop
.L14673:
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call printList
nop
ba %icc, .L14690
nop
.L14685:
ba %icc, .L14690
nop
.L14690:
ret
restore
	.size    printList, .-printList
	.align 4
	.global treeprint
.type    treeprint, #function
treeprint:
save %sp, -96, %sp
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
be %icc, .L14703
nop
ba %icc, .L14720
nop
.L14703:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call treeprint
nop
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
mov %l0, %o0
call treeprint
nop
ba %icc, .L14725
nop
.L14720:
ba %icc, .L14725
nop
.L14725:
ret
restore
	.size    treeprint, .-treeprint
	.align 4
	.global freeList
.type    freeList, #function
freeList:
save %sp, -96, %sp
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
be %icc, .L14738
nop
ba %icc, .L14749
nop
.L14738:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeList
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L14754
nop
.L14749:
ba %icc, .L14754
nop
.L14754:
ret
restore
	.size    freeList, .-freeList
	.align 4
	.global freeTree
.type    freeTree, #function
freeTree:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
xor %l2, 1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L14768
nop
ba %icc, .L14784
nop
.L14768:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeTree
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
mov %l0, %o0
call freeTree
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L14789
nop
.L14784:
ba %icc, .L14789
nop
.L14789:
ret
restore
	.size    freeTree, .-freeTree
	.align 4
	.global postOrder
.type    postOrder, #function
postOrder:
save %sp, -96, %sp
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
be %icc, .L14802
nop
ba %icc, .L14840
nop
.L14802:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 4]
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call postOrder
nop
mov %o0, %l0
mov %i0, %l2
ldsw [%l2 + 8], %l2
mov %l2, %o0
call postOrder
nop
mov %o0, %l2
mov %l0, %o0
mov %l2, %o1
call concatLists
nop
mov %o0, %l2
or %l1, 0, %l0
mov %l2, %o0
mov %l0, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14845
nop
.L14840:
ba %icc, .L14845
nop
.L14845:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    postOrder, .-postOrder
	.align 4
	.global treeadd
.type    treeadd, #function
treeadd:
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
be %icc, .L14862
nop
ba %icc, .L14888
nop
.L14862:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14893
nop
.L14888:
ba %icc, .L14893
nop
.L14893:
mov %i1, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14901
nop
ba %icc, .L14915
nop
.L14901:
mov %i0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l2
mov %i1, %l1
mov %l2, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l1
stw %l1, [%l0 + 4]
ba %icc, .L14932
nop
.L14915:
mov %i0, %l0
mov %i0, %l1
ldsw [%l1 + 8], %l2
mov %i1, %l1
mov %l2, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l1
stw %l1, [%l0 + 8]
ba %icc, .L14932
nop
.L14932:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    treeadd, .-treeadd
	.align 4
	.global quickSort
.type    quickSort, #function
quickSort:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l4
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l5
mov %i0, %l0
mov %l0, %o0
call size
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14959
nop
ba %icc, .L14965
nop
.L14959:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14970
nop
.L14965:
ba %icc, .L14970
nop
.L14970:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l1, %o0
mov %l0, %o1
call get
nop
mov %o0, %l1
mov %i0, %l0
mov %i0, %l2
mov %l2, %o0
call size
nop
mov %o0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l2
mov %l0, %o0
mov %l2, %o1
call get
nop
mov %o0, %l0
add %l1, %l0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l3
mov %i0, %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
.L15005:
or %l1, 0, %l6
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movne %icc, 1, %l7
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l7, %l0
be %icc, .L15011
nop
ba %icc, .L15084
nop
.L15011:
mov %i0, %l6
or %l2, 0, %l0
mov %l6, %o0
mov %l0, %o1
call get
nop
mov %o0, %l6
or %l3, 0, %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movg %icc, 1, %l7
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l7, %l0
be %icc, .L15025
nop
ba %icc, .L15042
nop
.L15025:
or %l5, 0, %l0
mov %i0, %l6
or %l2, 0, %l5
mov %l6, %o0
mov %l5, %o1
call get
nop
mov %o0, %l5
mov %l0, %o0
mov %l5, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l5
ba %icc, .L15062
nop
.L15042:
or %l4, 0, %l0
mov %i0, %l6
or %l2, 0, %l4
mov %l6, %o0
mov %l4, %o1
call get
nop
mov %o0, %l4
mov %l0, %o0
mov %l4, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l4
ba %icc, .L15062
nop
.L15062:
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L15005
nop
.L15084:
mov %i0, %l0
mov %l0, %o0
call freeList
nop
or %l4, 0, %l0
mov %l0, %o0
call quickSort
nop
mov %o0, %l0
or %l5, 0, %l1
mov %l1, %o0
call quickSort
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    quickSort, .-quickSort
	.align 4
	.global quickSortMain
.type    quickSortMain, #function
quickSortMain:
save %sp, -96, %sp
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(999), %l1
or %l1, %lo(999), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(999), %l1
or %l1, %lo(999), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(999), %l1
or %l1, %lo(999), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    quickSortMain, .-quickSortMain
	.align 4
	.global treesearch
.type    treesearch, #function
treesearch:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
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
be %icc, .L15154
nop
ba %icc, .L15221
nop
.L15154:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15164
nop
ba %icc, .L15169
nop
.L15164:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15174
nop
.L15169:
ba %icc, .L15174
nop
.L15174:
mov %i0, %l0
ldsw [%l0 + 4], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15186
nop
ba %icc, .L15191
nop
.L15186:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15196
nop
.L15191:
ba %icc, .L15196
nop
.L15196:
mov %i0, %l0
ldsw [%l0 + 8], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15208
nop
ba %icc, .L15213
nop
.L15208:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15223
nop
.L15213:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15223
nop
.L15223:
ba %icc, .L15226
nop
.L15221:
ba %icc, .L15226
nop
.L15226:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    treesearch, .-treesearch
	.align 4
	.global inOrder
.type    inOrder, #function
inOrder:
save %sp, -96, %sp
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
be %icc, .L15242
nop
ba %icc, .L15280
nop
.L15242:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %i0, %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 0]
or %l0, 0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
stw %l1, [%l2 + 4]
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call inOrder
nop
mov %o0, %l1
or %l0, 0, %l0
mov %i0, %l2
ldsw [%l2 + 8], %l2
mov %l2, %o0
call inOrder
nop
mov %o0, %l2
mov %l0, %o0
mov %l2, %o1
call concatLists
nop
mov %o0, %l0
mov %l1, %o0
mov %l0, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15288
nop
.L15280:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15288
nop
.L15288:
	.size    inOrder, .-inOrder
	.align 4
	.global bintreesearch
.type    bintreesearch, #function
bintreesearch:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
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
be %icc, .L15306
nop
ba %icc, .L15361
nop
.L15306:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15316
nop
ba %icc, .L15321
nop
.L15316:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15326
nop
.L15321:
ba %icc, .L15326
nop
.L15326:
mov %i1, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L15334
nop
ba %icc, .L15346
nop
.L15334:
mov %i0, %l0
ldsw [%l0 + 4], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15363
nop
.L15346:
mov %i0, %l0
ldsw [%l0 + 8], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15363
nop
.L15363:
ba %icc, .L15366
nop
.L15361:
ba %icc, .L15366
nop
.L15366:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    bintreesearch, .-bintreesearch
	.align 4
	.global buildTree
.type    buildTree, #function
buildTree:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
.L15384:
or %l2, 0, %l0
mov %i0, %l3
mov %l3, %o0
call size
nop
mov %o0, %l3
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l0, %l3
movl %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L15393
nop
ba %icc, .L15429
nop
.L15393:
or %l1, 0, %l0
mov %i0, %l3
or %l2, 0, %l1
mov %l3, %o0
mov %l1, %o1
call get
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L15384
nop
.L15429:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    buildTree, .-buildTree
	.align 4
	.global treeMain
.type    treeMain, #function
treeMain:
save %sp, -96, %sp
mov %i0, %l0
mov %l0, %o0
call buildTree
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l0
mov %l0, %o0
call treeprint
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
mov %l0, %o0
call inOrder
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %l2, %o0
call printList
nop
sethi %hi(999), %l3
or %l3, %lo(999), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sub %l2, %l3, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
or %l1, 0, %l0
mov %l0, %o0
call postOrder
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %l2, %o0
call printList
nop
sethi %hi(999), %l3
or %l3, %lo(999), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sub %l2, %l3, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
mov %l3, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
mov %l3, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(999), %l2
or %l2, %lo(999), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
mov %l0, %o0
call freeTree
nop
ret
restore
	.size    treeMain, .-treeMain
	.align 4
	.global myCopy
.type    myCopy, #function
myCopy:
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
be %icc, .L15680
nop
ba %icc, .L15685
nop
.L15680:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15690
nop
.L15685:
ba %icc, .L15690
nop
.L15690:
sethi %hi(0), %l1
or %l1, %lo(0), %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call myCopy
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    myCopy, .-myCopy
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
or %l2, 0, %l2
sethi %hi(0), %l3
or %l3, %lo(0), %l3
or %l3, 0, %l3
.L15721:
or %l3, 0, %l5
sethi %hi(10), %l4
or %l4, %lo(10), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movl %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L15727
nop
ba %icc, .L15786
nop
.L15727:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l2, 0, %l1
or %l0, 0, %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l0
mov %l0, %o0
call myCopy
nop
mov %o0, %l0
or %l0, 0, %l1
or %l2, 0, %l0
mov %l0, %o0
call myCopy
nop
mov %o0, %l0
or %l0, 0, %l0
or %l1, 0, %l4
mov %l4, %o0
call quickSortMain
nop
mov %o0, %l4
or %l4, 0, %l4
or %l4, 0, %l4
mov %l4, %o0
call freeList
nop
or %l0, 0, %l4
mov %l4, %o0
call treeMain
nop
or %l3, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
add %l4, %l3, %l3
or %l3, 0, %l3
ba %icc, .L15721
nop
.L15786:
or %l2, 0, %l2
mov %l2, %o0
call freeList
nop
or %l1, 0, %l1
mov %l1, %o0
call freeList
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common a,4,4
	.common b,4,4
	.common i,4,4
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

