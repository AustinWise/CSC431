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
be %icc, .L29
nop
ba %icc, .L40
nop
.L29:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L54
nop
.L40:
ba %icc, .L54
nop
.L54:
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
be %icc, .L65
nop
ba %icc, .L82
nop
.L65:
or %l3, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l3
ba %icc, .L54
nop
.L82:
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
be %icc, .L194
nop
ba %icc, .L200
nop
.L194:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L205
nop
.L200:
ba %icc, .L205
nop
.L205:
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
be %icc, .L256
nop
ba %icc, .L263
nop
.L256:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L268
nop
.L263:
ba %icc, .L268
nop
.L268:
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
be %icc, .L311
nop
ba %icc, .L338
nop
.L311:
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
ba %icc, .L343
nop
.L338:
ba %icc, .L343
nop
.L343:
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
be %icc, .L356
nop
ba %icc, .L373
nop
.L356:
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
ba %icc, .L378
nop
.L373:
ba %icc, .L378
nop
.L378:
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
be %icc, .L391
nop
ba %icc, .L402
nop
.L391:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeList
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L407
nop
.L402:
ba %icc, .L407
nop
.L407:
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
be %icc, .L433
nop
ba %icc, .L449
nop
.L433:
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
ba %icc, .L454
nop
.L449:
ba %icc, .L454
nop
.L454:
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
be %icc, .L467
nop
ba %icc, .L508
nop
.L467:
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
ba %icc, .L513
nop
.L508:
ba %icc, .L513
nop
.L513:
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
be %icc, .L530
nop
ba %icc, .L556
nop
.L530:
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
ba %icc, .L561
nop
.L556:
ba %icc, .L561
nop
.L561:
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
be %icc, .L596
nop
ba %icc, .L630
nop
.L596:
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
ba %icc, .L662
nop
.L630:
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
ba %icc, .L662
nop
.L662:
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
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l5
or %l5, %lo(0), %l5
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
be %icc, .L719
nop
ba %icc, .L725
nop
.L719:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L730
nop
.L725:
ba %icc, .L730
nop
.L730:
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
add %l1, %l0, %l0
sra %l0, 1, %l0
or %l0, 0, %l3
mov %i0, %l0
or %l0, 0, %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L766:
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
be %icc, .L772
nop
ba %icc, .L845
nop
.L772:
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
be %icc, .L786
nop
ba %icc, .L803
nop
.L786:
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
ba %icc, .L823
nop
.L803:
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
ba %icc, .L823
nop
.L823:
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L766
nop
.L845:
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
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
be %icc, .L915
nop
ba %icc, .L982
nop
.L915:
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
be %icc, .L925
nop
ba %icc, .L930
nop
.L925:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L935
nop
.L930:
ba %icc, .L935
nop
.L935:
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
be %icc, .L947
nop
ba %icc, .L952
nop
.L947:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L957
nop
.L952:
ba %icc, .L957
nop
.L957:
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
be %icc, .L969
nop
ba %icc, .L974
nop
.L969:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L984
nop
.L974:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L984
nop
.L984:
ba %icc, .L987
nop
.L982:
ba %icc, .L987
nop
.L987:
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
be %icc, .L1003
nop
ba %icc, .L1041
nop
.L1003:
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
ba %icc, .L1049
nop
.L1041:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1049
nop
.L1049:
	.size    inOrder, .-inOrder
	.align 4
	.global bintreesearch
.type    bintreesearch, #function
bintreesearch:
save %sp, -96, %sp
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
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
be %icc, .L1067
nop
ba %icc, .L1122
nop
.L1067:
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
be %icc, .L1077
nop
ba %icc, .L1082
nop
.L1077:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1087
nop
.L1082:
ba %icc, .L1087
nop
.L1087:
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
be %icc, .L1095
nop
ba %icc, .L1107
nop
.L1095:
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
ba %icc, .L1124
nop
.L1107:
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
ba %icc, .L1124
nop
.L1124:
ba %icc, .L1127
nop
.L1122:
ba %icc, .L1127
nop
.L1127:
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
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L1145:
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
be %icc, .L1154
nop
ba %icc, .L1190
nop
.L1154:
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
ba %icc, .L1145
nop
.L1190:
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l2
or %l2, %lo(-999), %l2
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
sethi %hi(-999), %l2
or %l2, %lo(-999), %l2
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(-2), %l0
or %l0, %lo(-2), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(-2), %l0
or %l0, %lo(-2), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
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
be %icc, .L1441
nop
ba %icc, .L1446
nop
.L1441:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1451
nop
.L1446:
ba %icc, .L1451
nop
.L1451:
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
sethi %hi(0), %l3
or %l3, %lo(0), %l3
.L1482:
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
be %icc, .L1488
nop
ba %icc, .L1547
nop
.L1488:
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
ba %icc, .L1482
nop
.L1547:
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

