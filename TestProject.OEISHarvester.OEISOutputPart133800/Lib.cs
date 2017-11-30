using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A163105
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,6L,2L,2L,2L,4L,2L,6L,2L,6L,2L,2L,2L,4L,3L,2L,2L,6L,2L,4L,2L,6L,2L,2L,2L,2L,2L,2L,2L,4L,2L,4L,2L,6L,6L,2L,2L,6L,3L,6L,2L,6L,2L,4L,2L,4L,2L,2L,2L,6L,2L,2L,6L,4L,2L,4L,2L,6L,2L,4L,2L,6L,2L,2L,6L,6L,2L,4L,2L,6L,4L,2L,2L,6L,2L,2L,2L,4L,2L,6L,2L,6L,2L,2L,2L,6L,2L,6L,6L,2L,2L,4L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163105Inst : IEnumerable<long>
{
public static readonly long[] Value=A163105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163105.Bytes);
public long this[int i]=>Value[i];

public static A163105Inst Instance=new A163105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163106
{
public static readonly long[] Value={ 1L,4L,4L,7L,4L,8L,4L,8L,7L,8L,4L,28L,4L,8L,8L,12L,4L,28L,4L,28L,8L,8L,4L,24L,7L,8L,8L,28L,4L,24L,4L,28L,8L,8L,8L,14L,4L,8L,8L,24L,4L,24L,4L,28L,28L,8L,4L,39L,7L,28L,8L,28L,4L,24L,8L,24L,8L,8L,4L,56L,4L,8L,28L,15L,8L,24L,4L,28L,8L,24L,4L,56L,4L,8L,28L,28L,8L,24L,4L,39L,12L,8L,4L,56L,8L,8L,8L,24L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163106Inst : IEnumerable<long>
{
public static readonly long[] Value=A163106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163106.Bytes);
public long this[int i]=>Value[i];

public static A163106Inst Instance=new A163106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163107
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,3L,3L,2L,4L,4L,4L,3L,4L,4L,2L,4L,3L,4L,4L,4L,3L,4L,6L,2L,4L,4L,4L,4L,6L,4L,4L,4L,4L,4L,3L,3L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,4L,3L,3L,6L,4L,4L,5L,6L,5L,4L,6L,6L,5L,3L,6L,4L,2L,6L,4L,4L,6L,6L,4L,6L,4L,3L,4L,4L,6L,6L,5L,4L,4L,2L,6L,6L,6L,6L,6L,5L,6L,6L,6L,4L,5L,4L,4L,5L,6L,4L,4L,6L,3L,4L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163107Inst : IEnumerable<long>
{
public static readonly long[] Value=A163107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163107.Bytes);
public long this[int i]=>Value[i];

public static A163107Inst Instance=new A163107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163108
{
public static readonly long[] Value={ 1L,3L,4L,3L,7L,12L,7L,7L,3L,12L,12L,12L,7L,15L,15L,3L,12L,7L,12L,15L,12L,13L,15L,28L,3L,15L,15L,15L,15L,28L,12L,12L,18L,15L,18L,7L,7L,28L,15L,28L,15L,28L,12L,28L,15L,28L,18L,12L,7L,7L,28L,12L,15L,31L,28L,31L,18L,28L,28L,31L,7L,28L,15L,3L,28L,24L,12L,28L,28L,24L,28L,15L,7L,15L,12L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163108Inst : IEnumerable<long>
{
public static readonly long[] Value=A163108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163108.Bytes);
public long this[int i]=>Value[i];

public static A163108Inst Instance=new A163108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163109
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,2L,1L,4L,2L,2L,2L,2L,1L,4L,1L,2L,2L,2L,2L,6L,1L,2L,2L,4L,1L,4L,1L,2L,2L,2L,1L,4L,2L,2L,2L,2L,1L,4L,2L,4L,2L,2L,1L,4L,1L,2L,2L,6L,2L,4L,1L,2L,2L,4L,1L,4L,1L,2L,2L,2L,2L,4L,1L,4L,4L,2L,1L,4L,2L,2L,2L,4L,1L,4L,2L,2L,2L,2L,2L,4L,1L,2L,2L,6L,1L,4L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163109Inst : IEnumerable<long>
{
public static readonly long[] Value=A163109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163109.Bytes);
public long this[int i]=>Value[i];

public static A163109Inst Instance=new A163109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163110
{
public static readonly long[] Value={ 1L,19L,342L,6156L,110637L,1988388L,35735751L,642249324L,11542621410L,207446086881L,3728258709552L,67004941956759L,1204224973728534L,21642549713419572L,388963830112221249L,6990528525469894908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163110Inst : IEnumerable<long>
{
public static readonly long[] Value=A163110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163110.Bytes);
public long this[int i]=>Value[i];

public static A163110Inst Instance=new A163110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163111
{
public static readonly long[] Value={ 3967L,11027L,11657L,14107L,16033L,16787L,18013L,18617L,18637L,18839L,19661L,21247L,23719L,24281L,24571L,29101L,30367L,31357L,32749L,33247L,33679L,33997L,35201L,36037L,37747L,38501L,40063L,40387L,42533L,42611L,43691L,43913L,44417L,46957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163111Inst : IEnumerable<long>
{
public static readonly long[] Value=A163111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163111.Bytes);
public long this[int i]=>Value[i];

public static A163111Inst Instance=new A163111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163112
{
public static readonly long[] Value={ 16033L,16787L,18013L,23719L,24281L,29101L,32749L,33247L,33679L,33997L,37747L,38501L,40063L,40387L,42533L,42611L,44417L,46957L,51109L,51383L,53479L,54217L,55291L,55763L,56333L,56569L,58271L,58511L,58831L,59833L,61441L,61781L,62273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163112Inst : IEnumerable<long>
{
public static readonly long[] Value=A163112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163112.Bytes);
public long this[int i]=>Value[i];

public static A163112Inst Instance=new A163112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163113
{
public static readonly BigInteger[] Value={ 13L,21L,34L,1597L,2584L,6765L,121393L,514229L,14930352L,24157817L,7778742049L,365435296162L,44945570212853L,BigInteger.Parse("184551825793033096366333"),BigInteger.Parse("781774079430987230203437"),BigInteger.Parse("7896325826131730509282738943634332893686268675876375") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163113Inst Instance=new A163113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163114
{
public static readonly long[] Value={ 3L,5L,15L,25L,75L,125L,375L,625L,1875L,3125L,9375L,15625L,46875L,78125L,234375L,390625L,1171875L,1953125L,5859375L,9765625L,29296875L,48828125L,146484375L,244140625L,732421875L,1220703125L,3662109375L,6103515625L,18310546875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163114Inst : IEnumerable<long>
{
public static readonly long[] Value=A163114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163114.Bytes);
public long this[int i]=>Value[i];

public static A163114Inst Instance=new A163114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163115
{
public static readonly BigInteger[] Value={ 2L,5L,43L,8219L,BigInteger.Parse("36893488147419103363"),BigInteger.Parse("38685626227668133590597803"),BigInteger.Parse("862718293348820473429344482784628181556388621521298319395315527975371") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163115Inst Instance=new A163115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163116
{
public static readonly long[] Value={ 2L,4L,5L,6L,9L,13L,20L,27L,36L,50L,65L,84L,105L,127L,152L,181L,215L,250L,290L,333L,376L,423L,473L,528L,590L,655L,720L,788L,857L,928L,1011L,1097L,1188L,1279L,1379L,1480L,1586L,1697L,1810L,1928L,2051L,2175L,2308L,2441L,2576L,2712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163116Inst : IEnumerable<long>
{
public static readonly long[] Value=A163116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163116.Bytes);
public long this[int i]=>Value[i];

public static A163116Inst Instance=new A163116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163117
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,7L,1L,9L,2L,3L,2L,9L,3L,1L,3L,7L,4L,1L,4L,3L,4L,7L,5L,3L,5L,9L,6L,1L,6L,7L,7L,1L,7L,3L,7L,9L,8L,3L,8L,9L,9L,7L,0L,0L,0L,1L,0L,1L,0L,2L,0L,3L,0L,3L,0L,3L,0L,4L,0L,5L,0L,6L,0L,6L,0L,6L,0L,8L,0L,9L,0L,9L,0L,9L,1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,1L,5L,1L,5L,1L,6L,1L,7L,1L,8L,1L,8L,1L,9L,2L,0L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163117Inst : IEnumerable<long>
{
public static readonly long[] Value=A163117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163117.Bytes);
public long this[int i]=>Value[i];

public static A163117Inst Instance=new A163117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163118
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,6L,8L,7L,1L,1L,7L,6L,2L,2L,4L,3L,3L,3L,1L,1L,3L,2L,2L,2L,4L,3L,5L,5L,1L,0L,6L,6L,4L,4L,2L,1L,5L,5L,1L,0L,2L,7L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,5L,5L,6L,6L,6L,6L,6L,6L,8L,8L,9L,9L,9L,9L,9L,8L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,4L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,7L,8L,7L,2L,2L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163118Inst : IEnumerable<long>
{
public static readonly long[] Value=A163118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163118.Bytes);
public long this[int i]=>Value[i];

public static A163118Inst Instance=new A163118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163119
{
public static readonly long[] Value={ 1L,2L,2L,6L,0L,0L,2L,2L,6L,6L,8L,7L,1L,1L,7L,6L,2L,2L,4L,3L,3L,3L,1L,1L,3L,2L,2L,2L,4L,3L,5L,5L,1L,0L,6L,6L,4L,4L,2L,1L,5L,5L,1L,0L,2L,6L,1L,1L,0L,1L,3L,2L,1L,7L,6L,1L,9L,8L,0L,2L,2L,1L,5L,6L,2L,2L,0L,2L,4L,6L,2L,6L,8L,3L,5L,8L,4L,4L,0L,4L,2L,6L,5L,3L,2L,5L,1L,6L,6L,4L,2L,6L,2L,8L,7L,7L,0L,8L,8L,0L,8L,6L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163119Inst : IEnumerable<long>
{
public static readonly long[] Value=A163119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163119.Bytes);
public long this[int i]=>Value[i];

public static A163119Inst Instance=new A163119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163120
{
public static readonly long[] Value={ 0L,1L,5L,11L,19L,28L,29L,29L,30L,32L,33L,37L,38L,43L,44L,50L,51L,59L,61L,61L,63L,64L,66L,68L,70L,74L,76L,81L,83L,89L,91L,98L,100L,108L,111L,111L,114L,116L,119L,122L,125L,129L,132L,137L,140L,146L,149L,157L,160L,169L,173L,173L,177L,179L,183L,187L,191L,196L,200L,206L,210L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163120Inst : IEnumerable<long>
{
public static readonly long[] Value=A163120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163120.Bytes);
public long this[int i]=>Value[i];

public static A163120Inst Instance=new A163120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163121
{
public static readonly long[] Value={ 8L,26L,61L,127L,819L,1468L,3913L,5131L,9423L,21014L,25695L,44821L,60921L,70246L,93175L,135053L,189754L,209405L,281080L,335959L,362017L,460271L,535850L,665665L,869798L,983645L,1037855L,1165724L,1231029L,1368809L,1963199L,2156966L,2474017L,2575027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163121Inst : IEnumerable<long>
{
public static readonly long[] Value=A163121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163121.Bytes);
public long this[int i]=>Value[i];

public static A163121Inst Instance=new A163121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163122
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,21L,22L,25L,27L,33L,35L,44L,49L,55L,66L,77L,88L,99L,121L,202L,242L,262L,302L,303L,362L,363L,382L,393L,403L,404L,453L,484L,505L,524L,543L,573L,605L,606L,626L,655L,689L,706L,707L,726L,746L,755L,766L,783L,786L,808L,840L,847L,905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163122Inst : IEnumerable<long>
{
public static readonly long[] Value=A163122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163122.Bytes);
public long this[int i]=>Value[i];

public static A163122Inst Instance=new A163122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163123
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,2L,7L,3L,10L,4L,8L,9L,15L,7L,19L,14L,11L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163123Inst : IEnumerable<long>
{
public static readonly long[] Value=A163123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163123.Bytes);
public long this[int i]=>Value[i];

public static A163123Inst Instance=new A163123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163124
{
public static readonly ulong[] Value={ 1L,20L,380L,7220L,136990L,2599200L,49316400L,935712000L,17753871510L,336855735180L,6391382632020L,121267853544780L,2300893742387430L,43656351283440360L,828320305398630840L,15716259104684097960UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163124Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A163124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163124.Bytes);
public ulong this[int i]=>Value[i];

public static A163124Inst Instance=new A163124Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163125
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,2L,4L,6L,8L,10L,12L,14L,16L,9L,2L,4L,6L,8L,10L,12L,14L,16L,18L,11L,4L,6L,8L,10L,12L,14L,16L,18L,20L,4L,6L,8L,10L,12L,14L,16L,18L,20L,4L,6L,8L,10L,12L,14L,16L,18L,20L,13L,6L,8L,10L,12L,14L,16L,18L,20L,13L,15L,8L,10L,12L,14L,16L,18L,20L,13L,15L,17L,10L,12L,14L,16L,18L,20L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163125Inst : IEnumerable<long>
{
public static readonly long[] Value=A163125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163125.Bytes);
public long this[int i]=>Value[i];

public static A163125Inst Instance=new A163125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163126
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,4L,6L,6L,7L,4L,9L,7L,11L,9L,12L,9L,12L,12L,13L,11L,16L,14L,15L,15L,18L,15L,19L,17L,17L,19L,22L,20L,22L,22L,21L,24L,26L,23L,27L,25L,27L,26L,31L,24L,27L,27L,29L,31L,35L,29L,35L,36L,36L,35L,39L,34L,39L,35L,39L,39L,42L,39L,40L,39L,38L,43L,47L,37L,47L,44L,46L,47L,50L,46L,47L,49L,50L,52L,48L,51L,52L,54L,52L,53L,56L,52L,58L,55L,53L,60L,59L,60L,59L,60L,60L,61L,60L,60L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163126Inst : IEnumerable<long>
{
public static readonly long[] Value=A163126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163126.Bytes);
public long this[int i]=>Value[i];

public static A163126Inst Instance=new A163126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163127
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,3L,3L,3L,4L,4L,5L,5L,5L,5L,5L,6L,6L,7L,8L,8L,8L,8L,9L,9L,11L,11L,10L,9L,11L,10L,12L,14L,12L,13L,14L,14L,16L,14L,17L,16L,15L,18L,17L,18L,18L,20L,20L,21L,18L,20L,23L,23L,22L,22L,23L,24L,22L,24L,25L,28L,24L,29L,23L,28L,27L,28L,26L,29L,26L,30L,30L,31L,32L,33L,31L,32L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163127Inst : IEnumerable<long>
{
public static readonly long[] Value=A163127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163127.Bytes);
public long this[int i]=>Value[i];

public static A163127Inst Instance=new A163127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163128
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,14L,24L,34L,44L,54L,64L,74L,84L,94L,95L,105L,115L,125L,135L,145L,155L,165L,175L,185L,186L,196L,206L,216L,226L,236L,246L,256L,266L,276L,277L,287L,297L,307L,317L,327L,337L,347L,357L,367L,368L,378L,388L,398L,408L,418L,428L,438L,448L,458L,459L,469L,479L,489L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163128Inst : IEnumerable<long>
{
public static readonly long[] Value=A163128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163128.Bytes);
public long this[int i]=>Value[i];

public static A163128Inst Instance=new A163128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163129
{
public static readonly long[] Value={ 1L,3L,9L,30L,75L,180L,441L,969L,2070L,4431L,8964L,17775L,35094L,66975L,125865L,235053L,429096L,773766L,1386027L,2442372L,4260645L,7384578L,12640320L,21453975L,36192519L,60454713L,100250100L,165311094L,270391857L,439479198L,710631279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163129Inst : IEnumerable<long>
{
public static readonly long[] Value=A163129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163129.Bytes);
public long this[int i]=>Value[i];

public static A163129Inst Instance=new A163129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163130
{
public static readonly long[] Value={ 1L,30L,441L,4431L,35094L,235053L,1386027L,7384578L,36192519L,165311094L,710631279L,2897149824L,11270295093L,42043460145L,151025654781L,524199355128L,1763256696537L,5762466306432L,18337081016448L,56926806819666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163130Inst : IEnumerable<long>
{
public static readonly long[] Value=A163130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163130.Bytes);
public long this[int i]=>Value[i];

public static A163130Inst Instance=new A163130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163131
{
public static readonly long[] Value={ 3L,75L,969L,8964L,66975L,429096L,2442372L,12640320L,60454713L,270391857L,1141260315L,4578160257L,17554638039L,64642406670L,229486544439L,788018124312L,2624648438025L,8499852952224L,26820711864657L,82613109082410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163131Inst : IEnumerable<long>
{
public static readonly long[] Value=A163131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163131.Bytes);
public long this[int i]=>Value[i];

public static A163131Inst Instance=new A163131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163132
{
public static readonly long[] Value={ 9L,180L,2070L,17775L,125865L,773766L,4260645L,21453975L,100250100L,439479198L,1822654251L,7198716870L,27221451885L,98988000120L,347428124352L,1180620288702L,3894719205510L,12501561121560L,39124469772495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163132Inst : IEnumerable<long>
{
public static readonly long[] Value=A163132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163132.Bytes);
public long this[int i]=>Value[i];

public static A163132Inst Instance=new A163132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163133
{
public static readonly long[] Value={ 1L,1L,1L,4L,11L,42L,196L,988L,5314L,30724L,189962L,1244264L,8583042L,62112639L,469917193L,3707053139L,30421506639L,259182853643L,2288352779166L,20904648990227L,197305045507448L,1921509079008868L,19285642292478101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163133Inst : IEnumerable<long>
{
public static readonly long[] Value=A163133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163133.Bytes);
public long this[int i]=>Value[i];

public static A163133Inst Instance=new A163133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163134
{
public static readonly long[] Value={ 1L,2L,6L,20L,71L,266L,1033L,4133L,16919L,70543L,298461L,1277895L,5525308L,24086364L,105730896L,466907516L,2072662801L,9243364577L,41392064353L,186040133239L,838962247305L,3794801298127L,17211872676042L,78262816746849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163134Inst : IEnumerable<long>
{
public static readonly long[] Value=A163134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163134.Bytes);
public long this[int i]=>Value[i];

public static A163134Inst Instance=new A163134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163135
{
public static readonly long[] Value={ 1L,2L,6L,20L,69L,245L,885L,3235L,11923L,44211L,164694L,615721L,2308499L,8675121L,32661637L,123161206L,465018949L,1757672820L,6649722003L,25177228890L,95390000028L,361616383623L,1371545371027L,5204283449684L,19754979558587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163135Inst : IEnumerable<long>
{
public static readonly long[] Value=A163135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163135.Bytes);
public long this[int i]=>Value[i];

public static A163135Inst Instance=new A163135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163136
{
public static readonly long[] Value={ 1L,2L,4L,13L,41L,133L,457L,1626L,5983L,22581L,86273L,332309L,1289466L,5037491L,19814253L,78464829L,312698663L,1253236364L,5047142834L,20408861265L,82804575274L,336913925731L,1374181645807L,5617148927835L,23007022273962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163136Inst : IEnumerable<long>
{
public static readonly long[] Value=A163136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163136.Bytes);
public long this[int i]=>Value[i];

public static A163136Inst Instance=new A163136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163137
{
public static readonly long[] Value={ 1L,2L,4L,13L,39L,113L,359L,1161L,3708L,11961L,38903L,126885L,415509L,1365935L,4501009L,14856863L,49115474L,162590020L,538828790L,1787431873L,5934532485L,19718347615L,65559507987L,218095336290L,725890070743L,2417022095921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163137Inst : IEnumerable<long>
{
public static readonly long[] Value=A163137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163137.Bytes);
public long this[int i]=>Value[i];

public static A163137Inst Instance=new A163137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163138
{
public static readonly BigInteger[] Value={ 1L,3L,20L,329L,22584L,7938470L,12605643936L,84977963809781L,2379247465188706528L,BigInteger.Parse("273419351336298753589802"),BigInteger.Parse("128009562526607810326874017088"),BigInteger.Parse("242979581192696030760182903464959706") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163138Inst Instance=new A163138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163139
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,10L,10L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163139Inst : IEnumerable<long>
{
public static readonly long[] Value=A163139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163139.Bytes);
public long this[int i]=>Value[i];

public static A163139Inst Instance=new A163139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163140
{
public static readonly long[] Value={ 11L,13L,14L,159L,175L,183L,187L,189L,190L,207L,215L,219L,221L,222L,231L,235L,237L,238L,243L,245L,246L,249L,250L,252L,2303L,2431L,2495L,2527L,2543L,2551L,2555L,2557L,2558L,2687L,2751L,2783L,2799L,2807L,2811L,2813L,2814L,2879L,2911L,2927L,2935L,2939L,2941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163140Inst : IEnumerable<long>
{
public static readonly long[] Value=A163140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163140.Bytes);
public long this[int i]=>Value[i];

public static A163140Inst Instance=new A163140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163141
{
public static readonly long[] Value={ 4L,5L,20L,25L,100L,125L,500L,625L,2500L,3125L,12500L,15625L,62500L,78125L,312500L,390625L,1562500L,1953125L,7812500L,9765625L,39062500L,48828125L,195312500L,244140625L,976562500L,1220703125L,4882812500L,6103515625L,24414062500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163141Inst : IEnumerable<long>
{
public static readonly long[] Value=A163141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163141.Bytes);
public long this[int i]=>Value[i];

public static A163141Inst Instance=new A163141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163142
{
public static readonly long[] Value={ 23L,27L,29L,30L,639L,703L,735L,751L,759L,763L,765L,766L,831L,863L,879L,887L,891L,893L,894L,927L,943L,951L,955L,957L,958L,975L,983L,987L,989L,990L,999L,1003L,1005L,1006L,1011L,1013L,1014L,1017L,1018L,1020L,18431L,19455L,19967L,20223L,20351L,20415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163142Inst : IEnumerable<long>
{
public static readonly long[] Value=A163142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163142.Bytes);
public long this[int i]=>Value[i];

public static A163142Inst Instance=new A163142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163143
{
public static readonly long[] Value={ 4L,8L,25L,26L,27L,36L,44L,48L,54L,56L,62L,64L,65L,68L,75L,80L,84L,92L,96L,98L,108L,121L,125L,128L,129L,143L,147L,155L,156L,164L,168L,176L,182L,183L,184L,188L,189L,192L,195L,206L,216L,224L,242L,248L,256L,258L,260L,264L,270L,276L,278L,284L,288L,294L,296L,308L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163143Inst : IEnumerable<long>
{
public static readonly long[] Value=A163143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163143.Bytes);
public long this[int i]=>Value[i];

public static A163143Inst Instance=new A163143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163144
{
public static readonly long[] Value={ 1L,3L,9L,36L,192L,1565L,19295L,878272L,1844953969L,52993098927711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163144Inst : IEnumerable<long>
{
public static readonly long[] Value=A163144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163144.Bytes);
public long this[int i]=>Value[i];

public static A163144Inst Instance=new A163144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163145
{
public static readonly BigInteger[] Value={ 1L,21L,420L,8400L,167790L,3351600L,66948210L,1337288400L,26712295890L,533577313500L,10658190898110L,212897044846500L,4252612111884990L,84945799915397400L,1696789816099808010L,BigInteger.Parse("33893325895893882600") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163145Inst Instance=new A163145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163146
{
public static readonly long[] Value={ 1L,11L,101L,871L,7321L,60851L,503261L,4152751L,34231921L,282047771L,2323383701L,19137123511L,157620587401L,1298196219971L,10692116430221L,88061314343551L,725280162785761L,5973461208779051L,49197849458990021L,405196896035729671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163146Inst : IEnumerable<long>
{
public static readonly long[] Value=A163146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163146.Bytes);
public long this[int i]=>Value[i];

public static A163146Inst Instance=new A163146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163147
{
public static readonly long[] Value={ 1L,12L,124L,1208L,11456L,107232L,997184L,9242368L,85517056L,790574592L,7305293824L,67488831488L,623410712576L,5758241390592L,53185308114944L,491231692423168L,4537090136866816L,41905067449516032L,387038978271084544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163147Inst : IEnumerable<long>
{
public static readonly long[] Value=A163147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163147.Bytes);
public long this[int i]=>Value[i];

public static A163147Inst Instance=new A163147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163148
{
public static readonly long[] Value={ 1L,13L,149L,1617L,17081L,177893L,1838509L,18920457L,194255281L,1991777533L,20407378949L,209003188737L,2140015661801L,21909062453333L,224284075207069L,2295910518566457L,23501807859846241L,240570205162118893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163148Inst : IEnumerable<long>
{
public static readonly long[] Value=A163148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163148.Bytes);
public long this[int i]=>Value[i];

public static A163148Inst Instance=new A163148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163149
{
public static readonly BigInteger[] Value={ 1L,22L,462L,9702L,203511L,4268880L,89544840L,1878307200L,39399681090L,826454197800L,17335839305400L,363639419173800L,7627760320511100L,160001156198268000L,3356210592504924000L,BigInteger.Parse("70400425902447564000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163149Inst Instance=new A163149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163150
{
public static readonly BigInteger[] Value={ 67L,509L,45060624733L,BigInteger.Parse("21424521360255636739"),BigInteger.Parse("404577789549846859589538794509144411672022828773"),BigInteger.Parse("22138618005861522471365237940368652982888104077311") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163150Inst Instance=new A163150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163151
{
public static readonly long[] Value={ 11L,19L,151L,419L,2161L,2311L,2539L,4831L,5563L,6961L,8363L,9007L,9661L,12347L,20533L,21493L,31033L,45737L,45817L,46919L,49363L,59419L,60017L,82883L,86561L,93491L,99709L,104231L,105499L,113381L,125471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163151Inst : IEnumerable<long>
{
public static readonly long[] Value=A163151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163151.Bytes);
public long this[int i]=>Value[i];

public static A163151Inst Instance=new A163151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163152
{
public static readonly BigInteger[] Value={ 2L,3L,7L,101L,80630964769L,BigInteger.Parse("1394313503224447816939"),BigInteger.Parse("87674799670795146675673859587"),BigInteger.Parse("62607220478448273296879161314388228250413") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163152Inst Instance=new A163152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163153
{
public static readonly BigInteger[] Value={ 3L,5L,23L,31L,73L,127L,797L,1301L,9851L,40099L,345953L,570181L,281138239L,48626519377L,91840127431010423L,130050574409983361L,6162297935619708167L,BigInteger.Parse("604490895403729930283"),BigInteger.Parse("3819342674540204978827"),BigInteger.Parse("20395819231612037821523") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163153Inst Instance=new A163153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163154
{
public static readonly BigInteger[] Value={ 5L,103L,3478759199L,116139356908771351L,BigInteger.Parse("37396512239913013823"),BigInteger.Parse("285687842248637730909432643746211633"),BigInteger.Parse("1391541769353191693086710038712557510379751"),BigInteger.Parse("1550980526109101915069808788349000570735950731617761605783") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163154Inst Instance=new A163154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163155
{
public static readonly BigInteger[] Value={ 13L,271L,28284463L,BigInteger.Parse("12610431355437389859745050577282818321295774208230808159"),BigInteger.Parse("421002806942919116087256468214897259565893934905313644799059599") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163155Inst Instance=new A163155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163156
{
public static readonly BigInteger[] Value={ 3L,37L,101L,1867L,193864603L,2084036199823432507L,BigInteger.Parse("268428621074094202095020661268919214060276183552992107"),BigInteger.Parse("491408029979212079502411930639737155545416825790885412525976325862355865559627380323835985032165419224284422111") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163156Inst Instance=new A163156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163157
{
public static readonly BigInteger[] Value={ 2L,3L,7L,41L,1871L,BigInteger.Parse("4599466948725481982057"),BigInteger.Parse("153554501132879618787551305057") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163157Inst Instance=new A163157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163158
{
public static readonly BigInteger[] Value={ 2L,7L,23L,167L,439L,3023L,7919L,54287L,974167L,2550407L,32522920134767L,3372041405099481407L,BigInteger.Parse("9839618880490124200692486211717007"),BigInteger.Parse("724995932728680612729658820311719934835368079") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163158Inst Instance=new A163158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163159
{
public static readonly BigInteger[] Value={ 2L,3L,5L,13L,21L,55L,89L,233L,987L,1597L,5702887L,1836311903L,99194853094755497L,BigInteger.Parse("26925748508234281076009"),BigInteger.Parse("184551825793033096366333"),BigInteger.Parse("468340976726457153752543329995929"),BigInteger.Parse("30010821454963453907530667147829489881"),BigInteger.Parse("1188518561323126046432205871807859915657177") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163159Inst Instance=new A163159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163160
{
public static readonly long[] Value={ 2L,0L,2L,-1L,-3L,1L,-1L,2L,9L,-6L,1L,7L,-1L,-11L,-1L,-5L,-5L,6L,-27L,-17L,-8L,-1L,10L,2L,9L,10L,-2L,7L,-15L,-4L,-8L,0L,-14L,-8L,-4L,-2L,10L,19L,11L,-1L,10L,12L,-39L,-27L,-28L,-20L,-11L,2L,11L,-9L,4L,15L,24L,33L,30L,3L,11L,14L,17L,14L,-11L,-7L,6L,18L,7L,18L,10L,-31L,-19L,-9L,-14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163160Inst : IEnumerable<long>
{
public static readonly long[] Value=A163160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163160.Bytes);
public long this[int i]=>Value[i];

public static A163160Inst Instance=new A163160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163161
{
public static readonly long[] Value={ 5L,9L,14L,30L,44L,47L,64L,67L,72L,89L,99L,124L,125L,194L,198L,200L,208L,213L,214L,249L,267L,270L,320L,333L,372L,373L,374L,393L,455L,460L,475L,519L,586L,603L,643L,701L,704L,712L,770L,774L,789L,814L,825L,828L,836L,891L,906L,930L,941L,970L,974L,982L,983L,988L,1022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163161Inst : IEnumerable<long>
{
public static readonly long[] Value=A163161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163161.Bytes);
public long this[int i]=>Value[i];

public static A163161Inst Instance=new A163161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163162
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163162Inst : IEnumerable<long>
{
public static readonly long[] Value=A163162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163162.Bytes);
public long this[int i]=>Value[i];

public static A163162Inst Instance=new A163162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163163
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,10L,3L,11L,7L,12L,3L,22L,3L,14L,13L,20L,3L,27L,3L,28L,15L,18L,3L,44L,9L,20L,17L,34L,3L,50L,3L,37L,19L,24L,17L,64L,3L,26L,21L,58L,3L,62L,3L,46L,39L,30L,3L,86L,11L,49L,25L,52L,3L,74L,21L,72L,27L,36L,3L,120L,3L,38L,47L,70L,23L,86L,3L,64L,31L,82L,3L,135L,3L,44L,55L,70L,23L,98L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163163Inst : IEnumerable<long>
{
public static readonly long[] Value=A163163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163163.Bytes);
public long this[int i]=>Value[i];

public static A163163Inst Instance=new A163163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163164
{
public static readonly long[] Value={ 1L,4L,6L,10L,12L,14L,16L,18L,20L,21L,22L,24L,25L,26L,28L,30L,34L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,64L,66L,68L,70L,72L,74L,75L,76L,78L,80L,81L,82L,84L,85L,86L,88L,90L,91L,92L,93L,94L,96L,99L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163164Inst : IEnumerable<long>
{
public static readonly long[] Value=A163164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163164.Bytes);
public long this[int i]=>Value[i];

public static A163164Inst Instance=new A163164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163165
{
public static readonly long[] Value={ 1L,10L,104L,1120L,12416L,140800L,1624064L,18964480L,223379456L,2646999040L,31495553024L,375799152640L,4492409962496L,53771480596480L,644158255529984L,7721102973337600L,92582866935873536L,1110431453277061120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163165Inst : IEnumerable<long>
{
public static readonly long[] Value=A163165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163165.Bytes);
public long this[int i]=>Value[i];

public static A163165Inst Instance=new A163165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163166
{
public static readonly long[] Value={ 1L,10L,105L,1150L,13025L,151250L,1787625L,21383750L,257850625L,3125556250L,38015315625L,463378468750L,5656114390625L,69101333281250L,844695798515625L,10329289308593750L,126339685312890625L,1545511221941406250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163166Inst : IEnumerable<long>
{
public static readonly long[] Value=A163166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163166.Bytes);
public long this[int i]=>Value[i];

public static A163166Inst Instance=new A163166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163167
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,3L,6L,5L,6L,5L,15L,5L,9L,6L,10L,10L,20L,6L,21L,10L,9L,15L,36L,10L,25L,9L,21L,9L,41L,10L,30L,20L,25L,20L,18L,9L,33L,21L,18L,20L,50L,9L,51L,25L,18L,36L,72L,20L,51L,25L,40L,18L,65L,21L,50L,18L,33L,41L,87L,20L,45L,30L,33L,40L,36L,25L,75L,40L,61L,18L,120L,18L,66L,33L,50L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163167Inst : IEnumerable<long>
{
public static readonly long[] Value=A163167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163167.Bytes);
public long this[int i]=>Value[i];

public static A163167Inst Instance=new A163167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163168
{
public static readonly long[] Value={ 1L,2L,3L,8L,9L,24L,37L,85L,1115L,29153L,423233L,2208087L,5102497L,9813637L,15922076L,19204759L,106559540L,120015709L,1493877142L,2199074984L,32818755269L,1505298832166L,1507229768977L,2841536357911L,14805574584765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163168Inst : IEnumerable<long>
{
public static readonly long[] Value=A163168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163168.Bytes);
public long this[int i]=>Value[i];

public static A163168Inst Instance=new A163168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163169
{
public static readonly long[] Value={ 0L,2L,0L,2L,0L,2L,3L,2L,0L,2L,4L,2L,3L,2L,4L,2L,0L,2L,3L,2L,5L,2L,4L,2L,3L,2L,4L,2L,7L,2L,3L,2L,0L,2L,4L,2L,3L,2L,4L,2L,5L,2L,3L,2L,8L,2L,4L,2L,3L,2L,4L,2L,8L,2L,3L,2L,7L,2L,4L,2L,3L,2L,4L,2L,0L,2L,3L,2L,8L,2L,4L,2L,3L,2L,4L,2L,8L,2L,3L,2L,5L,2L,4L,2L,3L,2L,4L,2L,11L,2L,3L,2L,8L,2L,4L,2L,3L,2L,4L,2L,5L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163169Inst : IEnumerable<long>
{
public static readonly long[] Value=A163169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163169.Bytes);
public long this[int i]=>Value[i];

public static A163169Inst Instance=new A163169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163170
{
public static readonly long[] Value={ 9L,15L,21L,27L,33L,45L,51L,63L,65L,85L,93L,99L,119L,129L,153L,165L,189L,195L,219L,231L,255L,273L,297L,325L,341L,365L,381L,387L,403L,427L,455L,471L,495L,511L,513L,561L,585L,633L,645L,693L,717L,765L,771L,819L,843L,891L,903L,951L,975L,1023L,1025L,1057L,1105L,1137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163170Inst : IEnumerable<long>
{
public static readonly long[] Value=A163170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163170.Bytes);
public long this[int i]=>Value[i];

public static A163170Inst Instance=new A163170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163171
{
public static readonly BigInteger[] Value={ 1L,23L,506L,11132L,244651L,5376756L,118166433L,2596973148L,57074328696L,1254336803181L,27566873759502L,605844081921771L,13314786972244758L,292622404684911840L,6431035802682200787L,BigInteger.Parse("141336482898202575984") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163171Inst Instance=new A163171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163172
{
public static readonly long[] Value={ 0L,1L,6L,10L,20L,28L,44L,88L,104L,136L,272L,304L,368L,464L,496L,592L,1184L,1312L,1376L,1504L,1696L,1888L,1952L,2144L,4288L,4544L,4672L,5056L,5312L,5696L,6208L,6464L,6592L,6848L,6976L,7232L,8128L,8384L,16768L,17536L,17792L,19072L,19328L,20096L,20864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163172Inst : IEnumerable<long>
{
public static readonly long[] Value=A163172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163172.Bytes);
public long this[int i]=>Value[i];

public static A163172Inst Instance=new A163172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163173
{
public static readonly long[] Value={ 4L,6L,6L,10L,9L,14L,10L,14L,22L,15L,10L,26L,21L,22L,34L,14L,15L,38L,26L,46L,14L,33L,34L,21L,22L,38L,58L,39L,62L,25L,26L,46L,21L,74L,51L,22L,82L,33L,34L,57L,86L,58L,35L,26L,62L,94L,38L,39L,69L,106L,74L,46L,33L,118L,34L,22L,122L,35L,82L,51L,86L,87L,38L,134L,39L,55L,93L,94L,142L,57L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163173Inst : IEnumerable<long>
{
public static readonly long[] Value=A163173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163173.Bytes);
public long this[int i]=>Value[i];

public static A163173Inst Instance=new A163173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163174
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,291732L,6703488L,154034496L,3539441664L,81330144060L,1868823662376L,42942280730712L,986738081076264L,22673505553878564L,520997277758500752L,11971601073631152624UL,BigInteger.Parse("275086336118245407888") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163174Inst Instance=new A163174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163175
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345300L,8280000L,198547500L,4761000000L,114164729700L,2737573095600L,65644673871900L,1574103433035600L,37745661174674100L,905108843301991200L,BigInteger.Parse("21703740051934476300"),BigInteger.Parse("520437222249938431200") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163175Inst Instance=new A163175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163176
{
public static readonly long[] Value={ 1L,1L,4L,2L,48L,16L,576L,144L,3840L,768L,9216L,1536L,3870720L,552960L,442368L,55296L,26542080L,2949120L,2229534720L,222953472L,70071091200L,6370099200L,76441190400L,6370099200L,16694755983360L,1284211998720L,570760888320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163176Inst : IEnumerable<long>
{
public static readonly long[] Value=A163176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163176.Bytes);
public long this[int i]=>Value[i];

public static A163176Inst Instance=new A163176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163177
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,405925L,10140000L,253297200L,6327360000L,158057355300L,3948270300000L,98627731207200L,2463719204700000L,61543667742382800L,1537359871188960000L,BigInteger.Parse("38403225875902867200"),BigInteger.Parse("959311990194611040000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163177Inst Instance=new A163177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163178
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,5L,2L,3L,3L,2L,5L,2L,5L,2L,3L,2L,2L,7L,3L,3L,5L,3L,5L,2L,3L,2L,3L,2L,2L,5L,2L,5L,3L,7L,2L,3L,7L,3L,2L,5L,2L,5L,3L,2L,3L,5L,2L,3L,7L,3L,2L,5L,2L,5L,2L,3L,2L,2L,3L,5L,7L,2L,7L,11L,3L,2L,7L,3L,3L,5L,3L,3L,2L,7L,2L,3L,2L,7L,5L,3L,2L,3L,2L,5L,11L,2L,5L,2L,3L,2L,5L,2L,2L,3L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163178Inst : IEnumerable<long>
{
public static readonly long[] Value=A163178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163178.Bytes);
public long this[int i]=>Value[i];

public static A163178Inst Instance=new A163178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163179
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474201L,12320100L,320085675L,8316067500L,216057716550L,5613342710625L,145838884522500L,3789004401804375L,98441196968058750L,2557576669978687500L,BigInteger.Parse("66447774146243953125"),BigInteger.Parse("1726363373899181062500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163179Inst Instance=new A163179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163180
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,10L,12L,15L,17L,24L,23L,30L,35L,40L,41L,53L,53L,66L,67L,74L,81L,100L,93L,106L,116L,129L,130L,153L,146L,169L,173L,188L,201L,222L,207L,235L,252L,273L,266L,299L,292L,327L,334L,345L,362L,405L,384L,417L,426L,453L,460L,507L,500L,533L,528L,557L,582L,637L,598L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163180Inst : IEnumerable<long>
{
public static readonly long[] Value=A163180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163180.Bytes);
public long this[int i]=>Value[i];

public static A163180Inst Instance=new A163180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163181
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,6L,7L,6L,3L,1L,1L,4L,10L,20L,31L,40L,44L,40L,31L,20L,10L,4L,1L,1L,5L,15L,35L,70L,121L,185L,255L,320L,365L,381L,365L,320L,255L,185L,121L,70L,35L,15L,5L,1L,1L,6L,21L,56L,126L,252L,456L,756L,1161L,1666L,2247L,2856L,3431L,3906L,4221L,4332L,4221L,3906L,3431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163181Inst : IEnumerable<long>
{
public static readonly long[] Value=A163181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163181.Bytes);
public long this[int i]=>Value[i];

public static A163181Inst Instance=new A163181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163182
{
public static readonly long[] Value={ 3L,13L,43L,53L,73L,83L,97L,127L,137L,139L,163L,167L,173L,197L,199L,211L,223L,251L,269L,277L,281L,293L,311L,317L,337L,347L,379L,383L,397L,409L,419L,421L,433L,443L,449L,463L,491L,503L,547L,557L,563L,593L,601L,607L,613L,617L,641L,643L,727L,733L,757L,787L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163182Inst : IEnumerable<long>
{
public static readonly long[] Value=A163182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163182.Bytes);
public long this[int i]=>Value[i];

public static A163182Inst Instance=new A163182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163183
{
public static readonly long[] Value={ 3L,11L,19L,43L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,251L,281L,283L,307L,331L,347L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,587L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,883L,907L,947L,971L,1019L,1033L,1049L,1051L,1091L,1097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163183Inst : IEnumerable<long>
{
public static readonly long[] Value=A163183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163183.Bytes);
public long this[int i]=>Value[i];

public static A163183Inst Instance=new A163183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163184
{
public static readonly long[] Value={ 281L,617L,1033L,1049L,1097L,1193L,1481L,1553L,1753L,1777L,2281L,2393L,2473L,2657L,2833L,2857L,3049L,3529L,3673L,3833L,4049L,4153L,4217L,4273L,4457L,4937L,5113L,5297L,5881L,6121L,6449L,6481L,6521L,6529L,6569L,6761L,6793L,6841L,7121L,7129L,7481L,7577L,7817L,8081L,8233L,8537L,9001L,9137L,9209L,9241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163184Inst : IEnumerable<long>
{
public static readonly long[] Value=A163184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163184.Bytes);
public long this[int i]=>Value[i];

public static A163184Inst Instance=new A163184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163185
{
public static readonly long[] Value={ 17L,41L,73L,89L,97L,113L,137L,193L,233L,241L,257L,313L,337L,353L,401L,409L,433L,449L,457L,521L,569L,577L,593L,601L,641L,673L,761L,769L,809L,857L,881L,929L,937L,953L,977L,1009L,1129L,1153L,1201L,1217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163185Inst : IEnumerable<long>
{
public static readonly long[] Value=A163185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163185.Bytes);
public long this[int i]=>Value[i];

public static A163185Inst Instance=new A163185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163186
{
public static readonly long[] Value={ 25601L,50177L,59393L,65537L,96001L,115201L,195457L,262657L,266369L,267649L,279553L,286721L,295937L,299393L,306689L,331777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163186Inst : IEnumerable<long>
{
public static readonly long[] Value=A163186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163186.Bytes);
public long this[int i]=>Value[i];

public static A163186Inst Instance=new A163186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163187
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,550746L,14859936L,400943088L,10818033408L,291886435386L,7875524871396L,212493231821052L,5733379591597476L,154695004916717538L,4173898512013677720L,BigInteger.Parse("112617914185202621832"),BigInteger.Parse("3038596784018807730264") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163187Inst Instance=new A163187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163188
{
public static readonly long[] Value={ 4L,18L,48L,100L,150L,180L,294L,448L,490L,588L,648L,900L,960L,1134L,1210L,1584L,1620L,2028L,2100L,2178L,2548L,2904L,3150L,3388L,3630L,3718L,3840L,4624L,5040L,5070L,5508L,5850L,6084L,6468L,6498L,6760L,7098L,7600L,8670L,8820L,9900L,9984L,10164L,11638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163188Inst : IEnumerable<long>
{
public static readonly long[] Value=A163188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163188.Bytes);
public long this[int i]=>Value[i];

public static A163188Inst Instance=new A163188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163189
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,14L,40L,159L,812L,5133L,42942L,474619L,6708142L,121367878L,2819170132L,83571532538L,3148951107867L,151069353323782L,9219463980803329L,714951048370178409L,BigInteger.Parse("70448496563603216429"),BigInteger.Parse("8818161368662624534857") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163189Inst Instance=new A163189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163190
{
public static readonly BigInteger[] Value={ 1L,2L,13L,72L,722L,7808L,122538L,2097280L,43444163L,1000262656L,25997950850L,743008372736L,23312187863060L,793714773262336L,29197324076701082L,1152921975865606144L,BigInteger.Parse("48663045048486723204"),BigInteger.Parse("2185911559738696663040") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163190Inst Instance=new A163190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163191
{
public static readonly BigInteger[] Value={ 1L,0L,1L,8L,82L,1024L,15690L,279936L,5771363L,134218240L,3487832978L,100000000000L,3138673052884L,106993205379072L,3937454749863386L,155568096631586816L,6568441588686506948L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("14063102470280932000763") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163191Inst Instance=new A163191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163192
{
public static readonly long[] Value={ 1L,10L,107L,1210L,14249L,172450L,2123843L,26439010L,331262801L,4166428090L,52521121307L,662944613770L,8374427993849L,105834710796370L,1337872412499443L,16914820145926450L,213874268556080801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163192Inst : IEnumerable<long>
{
public static readonly long[] Value=A163192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163192.Bytes);
public long this[int i]=>Value[i];

public static A163192Inst Instance=new A163192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163193
{
public static readonly long[] Value={ 12L,70L,88L,204L,220L,1750L,1888L,2958L,8142L,8632L,9114L,14664L,18414L,18762L,20118L,20712L,25194L,45520L,64206L,65652L,65964L,77814L,79338L,79824L,85096L,90804L,103410L,103644L,117822L,158946L,163938L,176364L,185776L,186612L,194416L,202656L,203898L,245632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163193Inst : IEnumerable<long>
{
public static readonly long[] Value=A163193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163193.Bytes);
public long this[int i]=>Value[i];

public static A163193Inst Instance=new A163193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163194
{
public static readonly BigInteger[] Value={ 0L,0L,112L,2156L,39204L,704700L,12648640L,226979168L,4072998384L,73087049196L,1311494037700L,23533806023420L,422297015415552L,7577812474157376L,135978327526488304L,2440032083021144300L,BigInteger.Parse("43784599166902574820"),BigInteger.Parse("785682752921352087228"),BigInteger.Parse("14098504953417767184064"),BigInteger.Parse("252987406408599326907296") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163194Inst Instance=new A163194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163195
{
public static readonly BigInteger[] Value={ 0L,0L,28L,539L,9801L,176175L,3162160L,56744792L,1018249596L,18271762299L,327873509425L,5883451505855L,105574253853888L,1894453118539344L,33994581881622076L,610008020755286075L,10946149791725643705UL,BigInteger.Parse("196420688230338021807"),BigInteger.Parse("3524626238354441796016"),BigInteger.Parse("63246851602149831726824") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163195Inst Instance=new A163195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163196
{
public static readonly BigInteger[] Value={ -4L,4L,108L,2160L,39200L,704704L,12648636L,226979172L,4072998380L,73087049200L,1311494037696L,23533806023424L,422297015415548L,7577812474157380L,135978327526488300L,2440032083021144304L,BigInteger.Parse("43784599166902574816"),BigInteger.Parse("785682752921352087232"),BigInteger.Parse("14098504953417767184060"),BigInteger.Parse("252987406408599326907300") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163196Inst Instance=new A163196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163197
{
public static readonly BigInteger[] Value={ -1L,1L,27L,540L,9800L,176176L,3162159L,56744793L,1018249595L,18271762300L,327873509424L,5883451505856L,105574253853887L,1894453118539345L,33994581881622075L,610008020755286076L,10946149791725643704UL,BigInteger.Parse("196420688230338021808"),BigInteger.Parse("3524626238354441796015"),BigInteger.Parse("63246851602149831726825") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163197Inst Instance=new A163197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163198
{
public static readonly BigInteger[] Value={ 0L,1L,28L,540L,9801L,176176L,3162160L,56744793L,1018249596L,18271762300L,327873509425L,5883451505856L,105574253853888L,1894453118539345L,33994581881622076L,610008020755286076L,10946149791725643705UL,BigInteger.Parse("196420688230338021808"),BigInteger.Parse("3524626238354441796016"),BigInteger.Parse("63246851602149831726825") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163198Inst Instance=new A163198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163199
{
public static readonly BigInteger[] Value={ -1L,0L,27L,539L,9800L,176175L,3162159L,56744792L,1018249595L,18271762299L,327873509424L,5883451505855L,105574253853887L,1894453118539344L,33994581881622075L,610008020755286075L,10946149791725643704UL,BigInteger.Parse("196420688230338021807"),BigInteger.Parse("3524626238354441796015"),BigInteger.Parse("63246851602149831726824") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163199Inst Instance=new A163199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163200
{
public static readonly BigInteger[] Value={ 0L,1L,9L,134L,2331L,41635L,746604L,13395941L,240376941L,4313380114L,77400441855L,1388894512391L,24922700621784L,447219716262409L,8025032191009041L,144003359719040030L,2584035442744223139L,BigInteger.Parse("46368634609657371691"),BigInteger.Parse("832051387531037141316"),BigInteger.Parse("14930556340948876798829") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163200Inst Instance=new A163200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163201
{
public static readonly BigInteger[] Value={ 0L,-1L,26L,-486L,8775L,-157600L,2828384L,-50754249L,910750554L,-16342762150L,293258984975L,-5262319011456L,94428483336576L,-1694450381348881L,30405678381733850L,-545607760491930150L,9790534010478427479UL,BigInteger.Parse("-175684004428133950624"),BigInteger.Parse("3152521545695969823584"),BigInteger.Parse("-56569703818099420107225") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163201Inst Instance=new A163201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163202
{
public static readonly BigInteger[] Value={ 0L,-1L,7L,-118L,2079L,-37225L,667744L,-11981593L,214999407L,-3858003766L,69229057975L,-1242265012561L,22291541096832L,-400005474543793L,7177807000202839L,-128800520527828150L,2311231562497354959L,BigInteger.Parse("-41473367604415793593"),BigInteger.Parse("744209385316963976032"),BigInteger.Parse("-13354295568100875681481") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163202Inst Instance=new A163202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163203
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,79L,713L,8486L,127372L,2248390L,45527161L,1048442107L,27060812167L,771886991408L,24110090108332L,818871809076474L,30044771201925569L,1184069354974499199L,BigInteger.Parse("49884064948928968400"),BigInteger.Parse("2237283630465903060711") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163203Inst Instance=new A163203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163204
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,8L,13L,6L,8L,48L,75L,26L,24L,48L,368L,541L,150L,104L,144L,368L,3376L,4683L,1082L,600L,624L,1104L,3376L,35824L,47293L,9366L,4328L,3600L,4784L,10128L,35824L,430512L,545835L,94586L,37464L,25968L,27600L,43888L,107472L,430512L,5773936L,7087261L,1091670L,378344L,224784L,199088L,253200L,465712L,1291536L,5773936L,85482032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163204Inst : IEnumerable<long>
{
public static readonly long[] Value=A163204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163204.Bytes);
public long this[int i]=>Value[i];

public static A163204Inst Instance=new A163204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}