using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A241531
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,1L,2L,5L,1L,2L,3L,5L,1L,1L,7L,5L,1L,1L,1L,1L,4L,5L,1L,3L,1L,1L,1L,1L,3L,1L,3L,3L,2L,3L,1L,3L,5L,5L,5L,7L,1L,1L,2L,1L,2L,3L,1L,1L,2L,7L,3L,1L,1L,3L,3L,1L,2L,1L,3L,1L,7L,5L,5L,2L,1L,6L,5L,3L,1L,3L,1L,4L,1L,3L,7L,5L,1L,3L,1L,5L,1L,7L,1L,3L,13L };
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
public class A241531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241531Inst : IEnumerable<long>
{
public static readonly long[] Value=A241531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241531.Bytes);
public long this[int i]=>Value[i];

public static A241531Inst Instance=new A241531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241532
{
public static readonly long[] Value={ 6L,3L,0L,4L,7L,3L,5L,0L,3L,3L,7L,4L,3L,8L,6L,7L,9L,6L,1L,2L,2L,0L,4L,0L,1L,9L,2L,7L,1L,0L,8L,7L,8L,9L,0L,4L,3L,5L,4L,5L,8L,7L,0L,7L,8L,7L,1L,2L,7L,3L,2L,3L,4L,1L,5L,7L,3L,8L,1L,7L,9L,8L,3L,7L,0L,8L,9L,7L,0L,0L,0L,3L,8L,2L,9L,9L,5L,8L,1L,9L,1L,1L,0L,1L,8L,9L,9L,5L,4L,1L,6L,5L,7L,8L,1L,7L,1L,9L,0L,9L };
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
public class A241532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241532Inst : IEnumerable<long>
{
public static readonly long[] Value=A241532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241532.Bytes);
public long this[int i]=>Value[i];

public static A241532Inst Instance=new A241532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241533
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,2L,3L,2L,5L,3L,2L,3L,5L,2L,3L,7L,5L,2L,7L,3L,2L,5L,5L,3L,3L,5L,2L,3L,2L,3L,7L,3L,3L,2L,3L,2L,3L,5L,5L,5L,7L,2L,13L,2L,19L,2L,3L,3L,3L,2L,7L,3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,7L,5L,5L,2L,0L,13L,5L,3L,2L,3L,7L,7L,3L,3L,7L,5L,3L,3L,5L,5L,2L,7L,2L,3L,13L };
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
public class A241533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241533Inst : IEnumerable<long>
{
public static readonly long[] Value=A241533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241533.Bytes);
public long this[int i]=>Value[i];

public static A241533Inst Instance=new A241533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241534
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,3L,3L,2L,1L,7L,1L,2L,6L,6L,1L,6L,1L,7L,6L,2L,1L,16L,3L,2L,6L,7L,1L,12L,1L,10L,6L,2L,6L,18L,1L,2L,6L,16L,1L,12L,1L,7L,15L,2L,1L,29L,3L,6L,6L,7L,1L,12L,6L,16L,6L,2L,1L,34L,1L,2L,15L,15L,6L,12L,1L,7L,6L,12L,1L,39L,1L,2L,15L,7L,6L,12L,1L,29L };
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
public class A241534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241534Inst : IEnumerable<long>
{
public static readonly long[] Value=A241534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241534.Bytes);
public long this[int i]=>Value[i];

public static A241534Inst Instance=new A241534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241535
{
public static readonly long[] Value={ 0L,0L,4L,4L,0L,4L,9L,4L,21L,9L,4L,9L,25L,4L,9L,15L,25L,4L,15L,9L,4L,15L,21L,9L,9L,15L,4L,9L,4L,9L,33L,9L,9L,4L,9L,4L,9L,21L,15L,25L,35L,4L,21L,4L,33L,4L,9L,9L,9L,4L,15L,9L,4L,9L,9L,9L,9L,4L,9L,9L,4L,21L,25L,25L,4L,51L,33L,25L,9L,4L,9L,15L,21L,9L,9L,21L,15L,9L,9L,15L,21L,4L,21L,4L };
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
public class A241535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241535Inst : IEnumerable<long>
{
public static readonly long[] Value=A241535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241535.Bytes);
public long this[int i]=>Value[i];

public static A241535Inst Instance=new A241535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241600
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,47L,791L,37830L };
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
public class A241600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241600Inst : IEnumerable<long>
{
public static readonly long[] Value=A241600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241600.Bytes);
public long this[int i]=>Value[i];

public static A241600Inst Instance=new A241600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241601
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,61L,1L,277L,1L,50521L,691L,41581L,1L,199360981L,3617L,228135437L,43867L,2404879675441L,174611L,14814847529501L,77683L,69348874393137901L,236364091L,238685140977801337L,657931L,BigInteger.Parse("4087072509293123892361"),3392780147L,BigInteger.Parse("454540704683713199807") };
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
public class A241601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241601Inst Instance=new A241601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241602
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,6L,24L,214L };
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
public class A241602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241602Inst : IEnumerable<long>
{
public static readonly long[] Value=A241602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241602.Bytes);
public long this[int i]=>Value[i];

public static A241602Inst Instance=new A241602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241603
{
public static readonly long[] Value={ 1L,5L,10L,21L,26L,44L,36L,61L,55L,80L,56L,120L,66L,110L,110L,141L,86L,179L,96L,196L,150L,170L,116L,280L,151L,200L,190L,266L,146L,344L,156L,301L,230L,260L,236L,435L,186L,290L,270L,436L,206L,464L,216L,406L,380L,350L,236L,600L,281L,455L,350L,476L,266L,584L,356L,586L,390L,440L,296L,820L,306L,470L,510L,621L,416L,704L,336L };
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
public class A241603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241603Inst : IEnumerable<long>
{
public static readonly long[] Value=A241603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241603.Bytes);
public long this[int i]=>Value[i];

public static A241603Inst Instance=new A241603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241604
{
public static readonly long[] Value={ 0L,0L,2L,3L,2L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,2L,2L,2L,13L,5L,3L,2L,3L,5L,2L,3L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,2L,5L,2L,2L,2L,21L,5L,2L,3L,2L,3L,2L,2L,3L,13L,13L,2L,3L,5L,2L,3L,2L,3L,2L,2L,2L,34L,5L,2L,2L,5L,2L,2L,3L,13L,3L,2L,2L,5L,2L,2L,3L,13L };
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
public class A241604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241604Inst : IEnumerable<long>
{
public static readonly long[] Value=A241604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241604.Bytes);
public long this[int i]=>Value[i];

public static A241604Inst Instance=new A241604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241605
{
public static readonly long[] Value={ 0L,0L,2L,2L,1L,3L,2L,3L,1L,3L,2L,4L,2L,4L,2L,5L,3L,3L,6L,3L,4L,2L,5L,2L,4L,4L,3L,4L,3L,4L,2L,2L,5L,4L,7L,2L,6L,5L,4L,4L,5L,3L,2L,3L,6L,4L,3L,4L,5L,5L,4L,2L,4L,4L,3L,3L,3L,3L,3L,5L,6L,7L,8L,2L,5L,7L,6L,3L,5L,7L,5L,3L,4L,4L,6L,3L,6L,7L,4L,3L };
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
public class A241605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241605Inst : IEnumerable<long>
{
public static readonly long[] Value=A241605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241605.Bytes);
public long this[int i]=>Value[i];

public static A241605Inst Instance=new A241605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241606
{
public static readonly long[] Value={ 1L,11L,95L,781L,6336L,51205L,413351L,3335651L,26915305L,217172736L,1752296281L,14138673395L,114079985111L,920471087701L,7426955448000L,59925473898301L,483517428660911L,3901330906652795L,31478457514091281L,253988526230055936L };
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
public class A241606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241606Inst : IEnumerable<long>
{
public static readonly long[] Value=A241606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241606.Bytes);
public long this[int i]=>Value[i];

public static A241606Inst Instance=new A241606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241607
{
public static readonly long[] Value={ 5141923L,6084557L,11403823L,13201987L,17488411L,20017609L,33239291L,37446979L,42070423L,47139347L,72512623L,88747907L,118408673L,129881707L,169708339L,184952323L,201267887L,278376073L,324881567L,406044923L,436421497L,538566199L,616639427L,658920007L,750410069L };
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
public class A241607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241607Inst : IEnumerable<long>
{
public static readonly long[] Value=A241607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241607.Bytes);
public long this[int i]=>Value[i];

public static A241607Inst Instance=new A241607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241608
{
public static readonly long[] Value={ 10L,20L,40L,76L,147L,287L,556L,1077L,2091L,4057L,7868L,15264L,29613L,57445L,111438L,216184L,419380L,813563L,1578253L,3061693L,5939450L,11522085L,22351978L,43361147L,84117349L,163181309L,316559417L,614101361L,1191310271L,2311051970L,4483266305L };
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
public class A241608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241608Inst : IEnumerable<long>
{
public static readonly long[] Value=A241608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241608.Bytes);
public long this[int i]=>Value[i];

public static A241608Inst Instance=new A241608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241609
{
public static readonly long[] Value={ 20L,50L,125L,295L,711L,1730L,4175L,10077L,24377L,58928L,142396L,344201L,832011L,2010980L,4860690L,11748840L,28397936L,68640170L,165909570L,401018224L,969296175L,2342874854L,5662936565L,13687818660L,33084669767L,79968578621L };
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
public class A241609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241609Inst : IEnumerable<long>
{
public static readonly long[] Value=A241609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241609.Bytes);
public long this[int i]=>Value[i];

public static A241609Inst Instance=new A241609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241610
{
public static readonly long[] Value={ 35L,105L,315L,889L,2567L,7483L,21631L,62547L,181255L,524877L,1519408L,4399720L,12740155L,36888358L,106810847L,309276700L,895517750L,2592992001L,7508089778L,21739889599L,62948442860L,182269006155L,527765093824L,1528158677522L };
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
public class A241610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241610Inst : IEnumerable<long>
{
public static readonly long[] Value=A241610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241610.Bytes);
public long this[int i]=>Value[i];

public static A241610Inst Instance=new A241610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241611
{
public static readonly long[] Value={ 56L,196L,686L,2254L,7586L,25774L,86828L,292621L,988303L,3335451L,11253229L,37977866L,128168421L,432512171L,1459576829L,4925618766L,16622258696L,56094381015L,189299674740L,638822175369L,2155807165360L,7275117316894L };
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
public class A241611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241611Inst : IEnumerable<long>
{
public static readonly long[] Value=A241611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241611.Bytes);
public long this[int i]=>Value[i];

public static A241611Inst Instance=new A241611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241612
{
public static readonly long[] Value={ 84L,336L,1344L,5040L,19374L,75180L,289248L,1113348L,4294574L,16553380L,63784786L,245853464L,947613919L,3652200016L,14076313291L,54253546534L,209104275023L,805930938847L,3106231773354L,11972077046301L,46142909963825L };
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
public class A241612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241612Inst : IEnumerable<long>
{
public static readonly long[] Value=A241612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241612.Bytes);
public long this[int i]=>Value[i];

public static A241612Inst Instance=new A241612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241613
{
public static readonly long[] Value={ 120L,540L,2430L,10242L,44274L,193194L,835812L,3617703L,15692003L,68014233L,294705961L,1277336862L,5536267273L,23993714457L,103989408537L,450697682809L,1953337206374L,8465825120096L,36691243404754L,159021259038334L };
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
public class A241613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241613Inst : IEnumerable<long>
{
public static readonly long[] Value=A241613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241613.Bytes);
public long this[int i]=>Value[i];

public static A241613Inst Instance=new A241613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241614
{
public static readonly long[] Value={ 165L,825L,4125L,19305L,92697L,449295L,2159025L,10380183L,50011289L,240772037L,1158816022L,5578909654L,26858310661L,129293730680L,622425498913L,2996413264570L,14424866547232L,69441979827433L,334297722590641L };
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
public class A241614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241614Inst : IEnumerable<long>
{
public static readonly long[] Value=A241614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241614.Bytes);
public long this[int i]=>Value[i];

public static A241614Inst Instance=new A241614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241615
{
public static readonly long[] Value={ 220L,1210L,6655L,34243L,180829L,963886L,5093737L,26932543L,142701909L,755538278L,3999038946L,21172904049L,112098384491L,593455432350L,3141868198978L,16633824615067L,88062718713584L,466221475528171L,2468274573927916L };
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
public class A241615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241615Inst : IEnumerable<long>
{
public static readonly long[] Value=A241615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241615.Bytes);
public long this[int i]=>Value[i];

public static A241615Inst Instance=new A241615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241776
{
public static readonly long[] Value={ 1L,3L,17L,69L,322L,1408L,6440L,29555L,139005L,662522L,3228150L,15994167L,80849918L,415684406L,2177223330L,11594426886L,62826444538L,345909306526L,1935762918301L,10999013559517L,63460591709283L,371497097807233L,2206388300667674L,13286470507994738L };
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
public class A241776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241776Inst : IEnumerable<long>
{
public static readonly long[] Value=A241776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241776.Bytes);
public long this[int i]=>Value[i];

public static A241776Inst Instance=new A241776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241777
{
public static readonly long[] Value={ 1L,4L,23L,104L,510L,2411L,11661L,57226L,283833L,1434373L,7346663L,38317226L,202773341L,1091360787L,5961577175L,33093602158L,186413366123L,1066200757106L,6185213644077L,36404110664402L,217206981954701L,1313899575466329L,8052745347023754L,50003529679287381L };
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
public class A241777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241777Inst : IEnumerable<long>
{
public static readonly long[] Value=A241777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241777.Bytes);
public long this[int i]=>Value[i];

public static A241777Inst Instance=new A241777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241778
{
public static readonly long[] Value={ 1L,4L,28L,137L,751L,3797L,19868L,103169L,544446L,2892654L,15609326L,85185225L,471914661L,2647616529L,15072126865L,86928421109L,508477806633L,3013152898489L,18098553323837L,110098999926894L,678500886312946L,4233264326440478L,26741870913391272L };
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
public class A241778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241778Inst : IEnumerable<long>
{
public static readonly long[] Value=A241778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241778.Bytes);
public long this[int i]=>Value[i];

public static A241778Inst Instance=new A241778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241779
{
public static readonly long[] Value={ 1L,5L,35L,189L,1088L,5896L,32419L,178832L,989799L,5540426L,31252470L,178571351L,1030696863L,6025834797L,35625675885L,213326126842L,1292327704580L,7927146783432L,49194730886734L,309011198106985L,1963433004838204L,12622320085676279L,82061043600221160L };
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
public class A241779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241779Inst : IEnumerable<long>
{
public static readonly long[] Value=A241779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241779.Bytes);
public long this[int i]=>Value[i];

public static A241779Inst Instance=new A241779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241780
{
public static readonly long[] Value={ 1L,5L,42L,238L,1499L,8635L,50873L,294903L,1724689L,10094399L,59679199L,355198229L,2136972743L,12972026795L,79626155414L,493684963581L,3095482758334L,19612796554079L,125656314294772L,813576800235695L,5325370849930701L,35223931484275717L,235474448496780769L };
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
public class A241780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241780Inst : IEnumerable<long>
{
public static readonly long[] Value=A241780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241780.Bytes);
public long this[int i]=>Value[i];

public static A241780Inst Instance=new A241780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241781
{
public static readonly long[] Value={ 1L,6L,50L,312L,2057L,12564L,77299L,473170L,2888809L,17728545L,109114799L,677179838L,4229167424L,26658442671L,169404526564L,1087116872873L,7039620433755L,46044295338658L,304018123809105L,2027563368241999L,13652340968436571L,92841055745572852L,637417951194934534L };
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
public class A241781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241781Inst : IEnumerable<long>
{
public static readonly long[] Value=A241781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241781.Bytes);
public long this[int i]=>Value[i];

public static A241781Inst Instance=new A241781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241782
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,107L,802L,10252L,232850L,9905775L };
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
public class A241782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241782Inst : IEnumerable<long>
{
public static readonly long[] Value=A241782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241782.Bytes);
public long this[int i]=>Value[i];

public static A241782Inst Instance=new A241782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241783
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,21L,22L,23L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,67L,68L,69L,72L,73L,74L,75L,76L,77L };
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
public class A241783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241783Inst : IEnumerable<long>
{
public static readonly long[] Value=A241783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241783.Bytes);
public long this[int i]=>Value[i];

public static A241783Inst Instance=new A241783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241784
{
public static readonly long[] Value={ 1L,1L,2L,6L,13L,44L,144L,577L,2457L,12499L };
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
public class A241784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241784Inst : IEnumerable<long>
{
public static readonly long[] Value=A241784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241784.Bytes);
public long this[int i]=>Value[i];

public static A241784Inst Instance=new A241784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241785
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,49L,322L,2411L,19868L,178832L,1724689L,17728545L,192634930L,2201760840L,26341552085L,328644606302L,4261866683006L,57288746422850L,796337785825197L,11422744246417607L,168765251734898485L,2564015637845130072L,BigInteger.Parse("39998356172536082076"),BigInteger.Parse("639840751503820832346") };
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
public class A241785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241785Inst Instance=new A241785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241786
{
public static readonly long[] Value={ 1L,6L,3L,5L,10L,24L,27L,169L,924L,3168L,720L,3208L,408L,35421L,50878L,73920L,18757L,204513L,134418L,295680L,427684L,2746710L,6867848L,14476645L,7278558L,3668406L,737564L,245340483L,1931850660L,1514239096L,3228582476L,1325085081L,16188866895L,33517640073L };
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
public class A241786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241786Inst : IEnumerable<long>
{
public static readonly long[] Value=A241786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241786.Bytes);
public long this[int i]=>Value[i];

public static A241786Inst Instance=new A241786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241787
{
public static readonly long[] Value={ 1035L,1275L,1326L,1378L,1485L,1540L,1596L,1653L,1830L,1953L,2016L,2145L,2346L,2415L,2485L,2701L,2850L,3081L,3160L,3240L,3486L,3570L,3741L,3916L,4095L,4186L,4278L,4371L,4560L,4753L,4851L,4950L,5460L,5671L,6105L,6328L,6903L,7021L,7140L,7260L,7381L,7503L,8256L };
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
public class A241787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241787Inst : IEnumerable<long>
{
public static readonly long[] Value=A241787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241787.Bytes);
public long this[int i]=>Value[i];

public static A241787Inst Instance=new A241787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241788
{
public static readonly long[] Value={ 10296L,12403L,13695L,14028L,14365L,14706L,16290L,17205L,19306L,19503L,21736L,21945L,23871L,24310L,24531L,24753L,24976L,27495L,29403L,30628L,30876L,32640L,32896L,34716L,34980L,37128L,37401L,37950L,39621L,40186L,41328L,41905L,42195L,43071L,43956L,46971L,47586L };
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
public class A241788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241788Inst : IEnumerable<long>
{
public static readonly long[] Value=A241788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241788.Bytes);
public long this[int i]=>Value[i];

public static A241788Inst Instance=new A241788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241789
{
public static readonly long[] Value={ 102378L,103285L,104653L,106953L,108345L,109278L,109746L,120786L,124750L,132870L,135460L,137026L,138075L,150426L,152076L,154290L,158203L,162735L,168490L,170236L,174936L,178503L,189420L,190653L,194376L,197506L,198765L,203841L,205761L,215496L,219453L,231540L };
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
public class A241789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241789Inst : IEnumerable<long>
{
public static readonly long[] Value=A241789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241789.Bytes);
public long this[int i]=>Value[i];

public static A241789Inst Instance=new A241789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241790
{
public static readonly long[] Value={ 1024596L,1047628L,1053426L,1069453L,1073845L,1078246L,1203576L,1234806L,1345620L,1360425L,1362075L,1386945L,1390278L,1405326L,1430586L,1439056L,1462905L,1486950L,1493856L,1547920L,1549680L,1590436L,1602945L,1624503L,1642578L,1679028L,1684530L,1693720L };
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
public class A241790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241790Inst : IEnumerable<long>
{
public static readonly long[] Value=A241790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241790.Bytes);
public long this[int i]=>Value[i];

public static A241790Inst Instance=new A241790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241791
{
public static readonly long[] Value={ 10348975L,10623745L,10725396L,10869453L,10934826L,12347965L,12357906L,12487503L,12647935L,12673095L,12784096L,13862745L,14756028L,14826735L,15237960L,15298746L,15304278L,15879430L,16247850L,16384950L,17084935L,17502486L,17543926L,17829406L };
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
public class A241791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241791Inst : IEnumerable<long>
{
public static readonly long[] Value=A241791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241791.Bytes);
public long this[int i]=>Value[i];

public static A241791Inst Instance=new A241791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241936
{
public static readonly long[] Value={ 16L,96L,26L,357L,218L,43L,1007L,1043L,509L,71L,2373L,3599L,3150L,1187L,116L,4928L,10031L,13339L,9500L,2727L,186L,9318L,24052L,44063L,49355L,28153L,6105L,300L,16389L,51570L,122162L,193179L,179145L,80983L,13783L,487L,27214L,101421L,297324L,619132L,829867L };
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
public class A241936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241936Inst : IEnumerable<long>
{
public static readonly long[] Value=A241936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241936.Bytes);
public long this[int i]=>Value[i];

public static A241936Inst Instance=new A241936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241937
{
public static readonly long[] Value={ 16L,96L,357L,1007L,2373L,4928L,9318L,16389L,27214L,43120L,65715L,96915L,138971L,194496L,266492L,358377L,474012L,617728L,794353L,1009239L,1268289L,1577984L,1945410L,2378285L,2884986L,3474576L,4156831L,4942267L,5842167L,6868608L,8034488L };
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
public class A241937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241937Inst : IEnumerable<long>
{
public static readonly long[] Value=A241937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241937.Bytes);
public long this[int i]=>Value[i];

public static A241937Inst Instance=new A241937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241938
{
public static readonly long[] Value={ 26L,218L,1043L,3599L,10031L,24052L,51570L,101421L,186208L,323246L,535613L,853307L,1314509L,1966952L,2869396L,4093209L,5724054L,7863682L,10631831L,14168231L,18634715L,24217436L,31129190L,39611845L,49938876L,62418006L,77393953L,95251283L };
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
public class A241938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241938Inst : IEnumerable<long>
{
public static readonly long[] Value=A241938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241938.Bytes);
public long this[int i]=>Value[i];

public static A241938Inst Instance=new A241938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241939
{
public static readonly long[] Value={ 43L,509L,3150L,13339L,44063L,122162L,297324L,654345L,1329163L,2529175L,4558346L,7847619L,12991135L,20788772L,32295512L,48878145L,72279819L,104692945L,148840966L,208069499L,286447359L,388877974L,521221700L,690429545L,904688811L };
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
public class A241939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241939Inst : IEnumerable<long>
{
public static readonly long[] Value=A241939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241939.Bytes);
public long this[int i]=>Value[i];

public static A241939Inst Instance=new A241939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241940
{
public static readonly long[] Value={ 71L,1187L,9500L,49355L,193179L,619132L,1710198L,4211175L,9462805L,19735067L,38684438L,71962709L,128007725L,219049200L,362365540L,581830389L,909790395L,1389318475L,2076889640L,3045529223L,4388486135L,6223486556L,8697626250L };
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
public class A241940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241940Inst : IEnumerable<long>
{
public static readonly long[] Value=A241940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241940.Bytes);
public long this[int i]=>Value[i];

public static A241940Inst Instance=new A241940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241941
{
public static readonly long[] Value={ 116L,2727L,28153L,179145L,829867L,3072022L,9624440L,26502761L,65852820L,150474973L,320706893L,644489313L,1231612799L,2253333900L,3968755944L,6759593329L,11175178396L,17989826867L,28274951385L,43488602905L,65585426555L };
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
public class A241941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241941Inst : IEnumerable<long>
{
public static readonly long[] Value=A241941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241941.Bytes);
public long this[int i]=>Value[i];

public static A241941Inst Instance=new A241941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241942
{
public static readonly long[] Value={ 186L,6105L,80983L,629639L,3446359L,14718452L,52254450L,160807307L,441594824L,1105088193L,2559951329L,5555774861L,11403065597L,22300931280L,41811147828L,75526918317L,131995736038L,223968454353L,370061050107L,596931751339L };
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
public class A241942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241942Inst : IEnumerable<long>
{
public static readonly long[] Value=A241942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241942.Bytes);
public long this[int i]=>Value[i];

public static A241942Inst Instance=new A241942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241943
{
public static readonly long[] Value={ 300L,13783L,235307L,2237881L,14484953L,71410234L,287426800L,988849923L,3001975962L,8229334021L,20724057835L,48580810915L,107107895363L,223936999508L,446973165720L,856397420093L,1582318291368L,2830137107267L,4916257200659L };
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
public class A241943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241943Inst : IEnumerable<long>
{
public static readonly long[] Value=A241943.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241943.Bytes);
public long this[int i]=>Value[i];

public static A241943Inst Instance=new A241943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241944
{
public static readonly long[] Value={ 1L,4L,9L,20L,33L,54L,79L,114L,153L,200L,251L,320L,395L,488L,589L,700L,815L,956L,1105L,1284L,1471L,1670L,1879L,2122L,2373L,2642L,2925L,3226L,3537L,3894L,4261L,4672L,5097L,5542L,6005L,6492L,6985L,7534L,8105L,8700L,9307L,9976L,10661L,11408L,12175L,12960L,13769L };
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
public class A241944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241944Inst : IEnumerable<long>
{
public static readonly long[] Value=A241944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241944.Bytes);
public long this[int i]=>Value[i];

public static A241944Inst Instance=new A241944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241945
{
public static readonly long[] Value={ 2L,3L,6L,17L,27L,30L,48L,53L,57L,68L,94L,137L,138L,143L,156L,157L,248L,259L,269L,289L,296L,316L,360L,369L,402L,425L,429L,430L,432L,446L,474L,500L,522L,580L,596L,631L,656L,760L,777L,810L,828L,875L,906L,951L,994L,1154L,1163L,1233L,1273L,1338L,1346L,1352L,1378L,1381L,1385L,1391L,1402L,1422L,1436L,1495L,1552L,1602L };
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
public class A241945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241945Inst : IEnumerable<long>
{
public static readonly long[] Value=A241945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241945.Bytes);
public long this[int i]=>Value[i];

public static A241945Inst Instance=new A241945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241946
{
public static readonly long[] Value={ 1001L,1111L,1221L,1331L,1441L,1551L,1661L,1771L,1881L,1991L,2002L,2112L,2222L,2332L,2442L,2552L,2662L,2772L,2882L,2992L,3003L,3113L,3223L,3333L,3443L,3553L,3663L,3773L,3883L,3993L,4004L,4114L,4224L,4334L,4444L,4554L,4664L,4774L,4884L,4994L,5005L,5115L,5225L };
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
public class A241946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241946Inst : IEnumerable<long>
{
public static readonly long[] Value=A241946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241946.Bytes);
public long this[int i]=>Value[i];

public static A241946Inst Instance=new A241946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241947
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,20L };
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
public class A241947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241947Inst : IEnumerable<long>
{
public static readonly long[] Value=A241947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241947.Bytes);
public long this[int i]=>Value[i];

public static A241947Inst Instance=new A241947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241948
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,8L,10L,11L,12L,14L,14L,16L,18L,18L,21L,22L,23L,26L,26L,29L,31L,32L,35L,36L,39L,41L,41L,46L,47L,49L,53L,52L,57L,60L,60L,65L,66L,70L,74L,73L,79L,81L,84L,89L,88L,94L,97L,97L,105L,105L,109L,115L,113L,121L,124L,125L,132L,132L,139L,143L,141L,151L,152L,157L,164L,161L,171L,175L };
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
public class A241948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241948Inst : IEnumerable<long>
{
public static readonly long[] Value=A241948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241948.Bytes);
public long this[int i]=>Value[i];

public static A241948Inst Instance=new A241948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241949
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,2L,4L,5L,4L,6L,5L,5L,8L,8L,9L,10L,10L,10L,11L,12L,13L,15L,18L,16L,17L,19L,17L,22L,24L,22L,26L,26L,24L,29L,28L,30L,34L,35L,35L,35L,38L,38L,41L,46L,43L,46L,52L,46L,52L,54L,51L,59L,60L,58L,63L,63L,64L,67L,68L,71L,71L,80L,78L,76L,85L,80L,84L,96L,87L,94L,102L,93L,102L,102L,101L,111L,114L,115L,115L,117L,121L,119L,129L };
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
public class A241949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241949Inst : IEnumerable<long>
{
public static readonly long[] Value=A241949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241949.Bytes);
public long this[int i]=>Value[i];

public static A241949Inst Instance=new A241949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241950
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,1L,3L,2L,2L,3L,3L,2L,5L,4L,3L,5L,6L,4L,6L,6L,4L,7L,8L,7L,7L,10L,8L,10L,11L,9L,10L,12L,12L,11L,13L,11L,14L,14L,15L,15L,16L,17L,19L,18L,17L,20L,19L,20L,22L,22L,20L,26L,25L,23L,27L,27L,25L,29L,30L,24L,31L,30L,29L,31L,34L,32L,35L,39L,34L,39L,39L,39L,39L,42L,39L,44L,44L,43L,47L,47L,48L,51L,51L,48L,56L,52L,53L,55L,56L,54L,61L,62L,56L,66L };
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
public class A241950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241950Inst : IEnumerable<long>
{
public static readonly long[] Value=A241950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241950.Bytes);
public long this[int i]=>Value[i];

public static A241950Inst Instance=new A241950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241951
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,12L,15L,15L,16L,19L,19L,21L,22L,24L,26L,26L,28L,31L,31L,33L,35L,37L,40L,40L,44L,45L,46L,51L,51L,54L,57L,58L,61L,62L,65L,70L,69L,72L,76L,76L,81L,81L,86L,90L,89L,95L,97L,100L,105L,105L,110L,114L,114L,121L,121L,126L,133L,131L,138L,139L,142L,149L,147L,154L,160L,159L,165L,167L };
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
public class A241951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241951Inst : IEnumerable<long>
{
public static readonly long[] Value=A241951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241951.Bytes);
public long this[int i]=>Value[i];

public static A241951Inst Instance=new A241951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242000
{
public static readonly long[] Value={ 6L,5L,1L,6L,7L,3L,7L,8L,8L,1L,0L,3L,8L,2L,2L,9L,4L,0L,9L,4L,5L,8L,2L,5L,3L,8L,0L,7L,9L,7L,7L,3L,1L,1L,4L,5L,1L,2L,0L,1L,4L,4L,9L,1L,7L,8L,7L,6L,4L,3L,9L,1L,0L,8L,9L,4L,4L,5L,1L,9L,8L,8L,8L,4L,2L,2L,8L,5L,4L,6L,0L,5L,1L,8L,5L,8L,7L,1L,6L,7L,2L,6L,4L,1L,4L,2L,7L,9L,5L,0L,4L,1L,7L,5L,3L,8L,8L,9L,3L,9L,7L,4L };
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
public class A242000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242000Inst : IEnumerable<long>
{
public static readonly long[] Value=A242000.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242000.Bytes);
public long this[int i]=>Value[i];

public static A242000Inst Instance=new A242000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242001
{
public static readonly long[] Value={ 2L,6L,6L,1L,5L,7L,0L,0L,1L,8L,7L,1L,6L,3L,7L,5L,6L,2L,5L,9L,6L,4L,1L,5L,5L,1L,2L,4L,4L,6L,5L,7L,9L,6L,8L,9L,7L,2L,6L,2L,1L,7L,9L,9L,9L,3L,9L,5L,1L,2L,7L,7L,5L,5L,7L,1L,2L,5L,0L,7L,7L,5L,4L,0L,6L,1L,3L,0L,1L,5L,8L,1L,2L,0L,9L,2L,7L,9L,2L,4L,1L,3L,4L,5L,4L,5L,2L,4L,0L,7L,3L,1L,1L,9L,7L,3L,4L,2L,6L,0L,0L,4L,3L,4L };
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
public class A242001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242001Inst : IEnumerable<long>
{
public static readonly long[] Value=A242001.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242001.Bytes);
public long this[int i]=>Value[i];

public static A242001Inst Instance=new A242001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242002
{
public static readonly long[] Value={ 2L,-2L,-10L,6L,-26L,38L,-90L,166L,678L,1702L,-346L,3750L,-4442L,11942L,44710L,110246L,-20826L,241318L,-282970L,765606L,2862758L,7057062L,-1331546L,15445670L,49000102L,116108966L,250326694L,518762150L,-18108762L,1055633062L };
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
public class A242002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242002Inst : IEnumerable<long>
{
public static readonly long[] Value=A242002.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242002.Bytes);
public long this[int i]=>Value[i];

public static A242002Inst Instance=new A242002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242003
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,15L,101L,841L,8267L,93259L,1184693L,16718377L,259403303L,4389247891L,80446526037L,1587992497445L,33595010710967L,758426286470763L,18201458396436081L,462778682120158733L,12427549693656564655UL,BigInteger.Parse("351513706699979429223"),BigInteger.Parse("10446113259707687607057") };
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
public class A242003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242003.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242003Inst Instance=new A242003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242004
{
public static readonly BigInteger[] Value={ 1L,1L,2L,13L,136L,1901L,32672L,660213L,15261866L,396260409L,11404802292L,360239943502L,12389377190088L,460921028363253L,18446977179761746L,790450173217191235L,BigInteger.Parse("36112553368752540450"),BigInteger.Parse("1752531204026383726825"),BigInteger.Parse("90044479726218309099544"),BigInteger.Parse("4883556796657253767140501") };
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
public class A242004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242004.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242004Inst Instance=new A242004Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242005
{
public static readonly BigInteger[] Value={ 1L,1L,3L,30L,478L,10146L,264303L,8084338L,282586248L,11085083577L,481673416483L,22956286840062L,1190639094701172L,66770638457654736L,4026673310312982723L,BigInteger.Parse("259904551978501682475"),BigInteger.Parse("17880944480665675868350"),BigInteger.Parse("1306415171298549344015316"),BigInteger.Parse("101032062583779191874828315") };
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
public class A242005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242005.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242005Inst Instance=new A242005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242006
{
public static readonly BigInteger[] Value={ 1L,1L,4L,54L,1156L,32917L,1149264L,47083228L,2203193792L,115647869941L,6721947019280L,428408002112146L,29705584153315352L,2226637865972203345L,BigInteger.Parse("179445974881472237440"),BigInteger.Parse("15475783832452270534780"),BigInteger.Parse("1422388135341144845327744"),BigInteger.Parse("138817119057328298887651613") };
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
public class A242006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242006Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242006.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242006.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242006Inst Instance=new A242006Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242007
{
public static readonly BigInteger[] Value={ 1L,1L,0L,2L,13L,195L,3435L,76414L,2022174L,62187697L,2179140792L,85721566443L,3740826531268L,179358254323264L,9372717617658837L,530222429589968085L,BigInteger.Parse("32283696960793539142"),BigInteger.Parse("2105064707592004243848"),BigInteger.Parse("146354134558836060119604"),BigInteger.Parse("10807595142239085940171930") };
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
public class A242007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242007Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242007.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242007.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242007Inst Instance=new A242007Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242008
{
public static readonly BigInteger[] Value={ 1L,1L,1L,11L,156L,3291L,88226L,2875398L,110100183L,4841244682L,240373761685L,13302190764348L,811959804656631L,54199237928855551L,3927985314859401651L,BigInteger.Parse("307182890826521602838"),BigInteger.Parse("25785326923948811144846"),BigInteger.Parse("2312543296773573900444136"),BigInteger.Parse("220690745096282461500094088") };
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
public class A242008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242008.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242008Inst Instance=new A242008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242009
{
public static readonly BigInteger[] Value={ 1L,1L,2L,27L,540L,15273L,545424L,23441679L,1174939901L,67222626658L,4321856514871L,308474127741229L,24206976396414033L,2071823443548447053L,BigInteger.Parse("192096343794154776046"),BigInteger.Parse("19183353188372473420096"),BigInteger.Parse("2052995326868420586298713"),BigInteger.Parse("234422512754956257129580893") };
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
public class A242009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242009.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242009Inst Instance=new A242009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242010
{
public static readonly long[] Value={ 2L,2L,2L,6L,6L,2L,9L,8L,6L,9L,6L,8L,6L,0L,1L,5L,0L,9L,4L,8L,6L,6L,6L,0L,2L,6L,2L,7L,6L,4L,7L,4L,4L,3L,6L,1L,8L,8L,6L,5L,7L,1L,6L,1L,6L,0L,5L,7L,1L,5L,2L,4L,7L,8L,5L,1L,2L,9L,0L,0L,2L,6L,0L,0L,5L,3L,0L,7L,8L,9L,7L,6L,5L,9L,7L,2L,2L,0L,2L,4L,7L,4L,8L,2L,1L,8L,3L,4L,0L,4L,3L,2L,6L,7L,8L,0L,5L,4L,0L,8L,3L,1L,8L,2L };
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
public class A242010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242010Inst : IEnumerable<long>
{
public static readonly long[] Value=A242010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242010.Bytes);
public long this[int i]=>Value[i];

public static A242010Inst Instance=new A242010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242011
{
public static readonly long[] Value={ 0L,2L,3L,0L,0L,4L,5L,8L,7L,8L,6L,2L,7L,3L,6L,0L,1L,0L,3L,1L,7L,9L,9L,2L,6L,0L,2L,1L,4L,5L,1L,4L,6L,9L,6L,2L,3L,1L,8L,6L,6L,7L,6L,4L,1L,4L,7L,5L,0L,8L,8L,3L,2L,9L,0L,9L,6L,3L,8L,0L,0L,6L,2L,0L,6L,5L,8L,1L,4L,5L,4L,7L,6L,3L,5L,4L,5L,5L,9L,4L,1L,4L,0L,3L,1L,5L,6L,6L,2L,3L,6L,1L,5L,5L,8L,9L,1L,9L,6L,7L };
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
public class A242011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242011Inst : IEnumerable<long>
{
public static readonly long[] Value=A242011.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242011.Bytes);
public long this[int i]=>Value[i];

public static A242011Inst Instance=new A242011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242012
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,4L,1L,1L,3L,1L,3L,1L,1L,2L,5L,1L,1L,2L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,4L,1L,3L,3L,1L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L };
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
public class A242012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242012Inst : IEnumerable<long>
{
public static readonly long[] Value=A242012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242012.Bytes);
public long this[int i]=>Value[i];

public static A242012Inst Instance=new A242012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242013
{
public static readonly long[] Value={ 1L,6L,3L,8L,9L,7L,3L,1L,8L,6L,3L,4L,5L,8L,1L,5L,9L,5L,8L,5L,6L,2L,9L,9L,7L,6L,9L,0L,0L,4L,7L,3L,5L,1L,1L,8L,6L,0L,9L,6L,6L,5L,7L,4L,6L,1L,4L,3L,5L,4L,5L,0L,4L,3L,6L,4L,6L,8L,4L,2L,5L,9L,8L,5L,3L,0L,5L,0L,2L,4L,6L,3L,1L,1L,1L,9L,0L,0L,6L,9L,2L,2L,8L,6L,0L,2L,4L,7L,2L,2L,6L,2L,9L,8L,4L,8L,2L,6L,9L,9L,2L };
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
public class A242013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242013Inst : IEnumerable<long>
{
public static readonly long[] Value=A242013.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242013.Bytes);
public long this[int i]=>Value[i];

public static A242013Inst Instance=new A242013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242014
{
public static readonly long[] Value={ 1L,4L,5L,8L,13L,27L,30L,59L,79L,101L,107L,115L,132L,153L,182L,206L,241L,260L,332L,344L,370L,437L,493L,521L,541L,587L,602L,660L,710L,812L,829L,838L,868L,979L,1040L,1079L,1114L,1240L,1294L,1367L,1634L,1713L,1727L,1779L,1886L,1929L,1940L,1984L,2060L,2246L,2373L };
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
public class A242014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242014Inst : IEnumerable<long>
{
public static readonly long[] Value=A242014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242014.Bytes);
public long this[int i]=>Value[i];

public static A242014Inst Instance=new A242014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242015
{
public static readonly long[] Value={ 4L,0L,9L,5L,0L,6L,9L,0L,3L,4L,1L,1L,8L,9L,5L,7L,6L,8L,2L,4L,5L,1L,1L,6L,3L,9L,5L,1L,8L,3L,7L,9L,7L,6L,3L,7L,0L,4L,3L,1L,9L,9L,5L,2L,9L,0L,9L,8L,4L,7L,1L,6L,6L,3L,2L,3L,4L,8L,9L,0L,9L,7L,6L,6L,8L,2L,7L,2L,5L,6L,9L,2L,7L,8L,0L,6L,3L,7L,6L,8L,8L,9L,2L,1L,2L,7L,2L,9L,8L,5L,0L,7L,0L,4L,4L,6L,0L,5L,2L,8L,7L,7L,5L };
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
public class A242015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242015Inst : IEnumerable<long>
{
public static readonly long[] Value=A242015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242015.Bytes);
public long this[int i]=>Value[i];

public static A242015Inst Instance=new A242015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242064
{
public static readonly long[] Value={ 1L,2L,9L,9L,36L,36L,81L,220L,220L,386L,386L,386L,434L,521L,896L,896L,896L,1167L,1167L,1695L,2065L,2096L,2096L,2968L,2968L,2968L,2968L,3341L,4561L,4561L,4561L,4561L,4672L,4672L,5964L,6203L,7158L,8294L,8294L,8294L,8740L,8740L,10452L,10452L,11075L,11075L,12092L };
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
public class A242064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242064Inst : IEnumerable<long>
{
public static readonly long[] Value=A242064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242064.Bytes);
public long this[int i]=>Value[i];

public static A242064Inst Instance=new A242064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242065
{
public static readonly long[] Value={ 2L,3L,4L,8L,8L,17L,17L,17L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,179L,179L,179L,179L,179L,179L,179L,179L,264L,264L,264L,319L,319L,319L,319L,365L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,4372L,4372L,4372L,4372L,4372L,15504L,15504L };
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
public class A242065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242065Inst : IEnumerable<long>
{
public static readonly long[] Value=A242065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242065.Bytes);
public long this[int i]=>Value[i];

public static A242065Inst Instance=new A242065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242066
{
public static readonly long[] Value={ 16L,22L,34L,40L,70L,70L,70L,112L,112L,112L,130L,130L,142L,160L,184L,184L,202L,214L,310L,310L,310L,310L,310L,310L,310L,340L,340L,340L,382L,412L,412L,490L,490L,490L,490L,490L,502L,544L,544L,544L,574L,580L,634L,634L,634L,754L,754L,754L,754L,754L,754L,754L,772L };
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
public class A242066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242066Inst : IEnumerable<long>
{
public static readonly long[] Value=A242066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242066.Bytes);
public long this[int i]=>Value[i];

public static A242066Inst Instance=new A242066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242067
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,9L,12L,16L,21L,25L,31L,36L,42L,48L,54L,61L,68L,75L,83L,90L,98L,106L,115L,123L,132L,142L,150L,160L,170L,180L,190L,200L,211L,221L,232L,243L,254L,266L,277L,289L,301L,313L,326L,338L,351L,363L,376L,390L,402L,416L,429L,443L,456L,471L,485L,499L,514L,528L,543L,558L };
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
public class A242067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242067Inst : IEnumerable<long>
{
public static readonly long[] Value=A242067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242067.Bytes);
public long this[int i]=>Value[i];

public static A242067Inst Instance=new A242067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242068
{
public static readonly long[] Value={ 102L,170L,230L,238L,255L,282L,285L,366L,399L,429L,430L,434L,438L,598L,602L,606L,609L,615L,638L,642L,645L,651L,663L,741L,759L,805L,822L,826L,854L,902L,935L,969L,986L,1001L,1022L,1030L,1065L,1085L,1086L,1102L,1105L,1130L,1178L,1182L,1221L,1245L,1265L,1295L,1309L,1310L,1334L,1358L,1374L,1406L,1419L,1426L,1434L };
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
public class A242068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242068Inst : IEnumerable<long>
{
public static readonly long[] Value=A242068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242068.Bytes);
public long this[int i]=>Value[i];

public static A242068Inst Instance=new A242068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242069
{
public static readonly long[] Value={ 1L,9L,4L,0L,1L,0L,1L,6L,8L,3L,7L,4L,3L,6L,2L,5L,2L,8L,6L,0L,1L,7L,4L,6L,9L,3L,9L,0L,5L,2L,5L,5L,4L,8L,8L,7L,8L,2L,3L,0L,2L,4L,7L,6L,0L,7L,4L,4L,5L,7L,5L,8L,4L,5L,3L,6L,2L,8L,7L,0L,7L,6L,7L,3L,8L,9L,6L,6L,3L,5L,9L,6L,5L,7L,9L,2L,4L,8L,3L,2L,0L,8L,7L,3L,8L,7L,3L,5L,1L,2L,1L,8L,6L,8L,7L,2L,4L,5L,2L,0L };
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
public class A242069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242069Inst : IEnumerable<long>
{
public static readonly long[] Value=A242069.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242069.Bytes);
public long this[int i]=>Value[i];

public static A242069Inst Instance=new A242069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242070
{
public static readonly long[] Value={ 2L,8L,1L,3L,0L,1L,4L,0L,2L,0L,2L,5L,2L,8L,9L,8L,3L,6L,7L,5L,2L,7L,2L,5L,5L,4L,0L,1L,2L,1L,6L,6L,8L,6L,9L,6L,3L,8L,4L,6L,1L,4L,0L,5L,6L,0L,5L,4L,0L,2L,6L,2L,2L,1L,5L,2L,6L,6L,4L,3L,8L,7L,4L,0L,4L,7L,1L,5L,0L,8L,3L,6L,8L,9L,2L,3L,7L,0L,7L,9L,9L,5L,8L,4L,0L,2L,0L,7L,1L,8L,2L,6L,3L,6L,9L,6L,0L,5L,4L,1L };
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
public class A242070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242070Inst : IEnumerable<long>
{
public static readonly long[] Value=A242070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242070.Bytes);
public long this[int i]=>Value[i];

public static A242070Inst Instance=new A242070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242071
{
public static readonly long[] Value={ 2L,0L,4L,1L,5L,4L,8L,1L,8L,6L,4L,1L,2L,1L,3L,2L,4L,1L,8L,0L,4L,5L,4L,9L,0L,1L,5L,8L,3L,8L,1L,4L,5L,5L,8L,6L,6L,3L,4L,0L,2L,5L,0L,2L,5L,2L,5L,6L,4L,6L,9L,1L,9L,1L,5L,5L,1L,2L,1L,3L,1L,2L,8L,1L,0L,5L,3L,6L,2L,1L,0L,6L,3L,7L,6L,7L,0L,0L,1L,2L,0L,9L,7L,1L,1L,0L,5L,5L,6L,4L,3L,9L,7L,6L,4L,3L,2L,8L,6L,9L,5L,5L };
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
public class A242071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242071Inst : IEnumerable<long>
{
public static readonly long[] Value=A242071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242071.Bytes);
public long this[int i]=>Value[i];

public static A242071Inst Instance=new A242071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242072
{
public static readonly long[] Value={ 3L,1L,8L,2L,4L,8L,1L,5L,8L,4L,0L,5L,8L,4L,4L,8L,6L,9L,4L,2L,5L,9L,6L,2L,0L,2L,7L,4L,8L,1L,4L,0L,6L,9L,4L,2L,4L,3L,8L,0L,6L,2L,3L,6L,5L,6L,4L,0L,6L,8L,4L,8L,8L,4L,0L,6L,7L,6L,7L,6L,0L,6L,3L,2L,2L,1L,4L,7L,6L,7L,3L,0L,9L,2L,5L,7L,5L,8L,7L,9L,1L,0L,3L,9L,7L,4L,5L,6L,9L,5L,4L,1L,9L,5L,2L,5L,5L,7L,0L,3L,7L,4L,5L,3L };
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
public class A242072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242072Inst : IEnumerable<long>
{
public static readonly long[] Value=A242072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242072.Bytes);
public long this[int i]=>Value[i];

public static A242072Inst Instance=new A242072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242073
{
public static readonly long[] Value={ 1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L };
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
public class A242073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242073Inst : IEnumerable<long>
{
public static readonly long[] Value=A242073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242073.Bytes);
public long this[int i]=>Value[i];

public static A242073Inst Instance=new A242073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242074
{
public static readonly long[] Value={ 25L,41L,64L,103L,131L,169L,271L,274L,281L,441L,713L,901L,1156L,1871L,3025L,4894L,7921L,12817L,20736L,21319L,33551L,54289L,87842L,142129L,229969L,372100L,602071L,974169L,1576238L,2550409L,4126649L,6677056L,10803703L,17480761L,28284466L,45765225L,74049689L };
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
public class A242074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242074Inst : IEnumerable<long>
{
public static readonly long[] Value=A242074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242074.Bytes);
public long this[int i]=>Value[i];

public static A242074Inst Instance=new A242074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242075
{
public static readonly BigInteger[] Value={ 1L,50L,3L,2500L,20L,0L,14L,125000L,111111111L,10L,BigInteger.Parse("909090909090909090909"),0L,BigInteger.Parse("769230769230769230769230769"),714L,0L,6250000L,5882L,0L,5263L,500L,BigInteger.Parse("4761904761904761904761904761904761"),454545454L,4347L,0L,400L };
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
public class A242075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242075Inst Instance=new A242075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242076
{
public static readonly long[] Value={ 3L,5L,6L,7L,11L,12L,13L,17L,19L,20L,23L,28L,31L,40L,43L,61L,79L,92L,96L,101L,104L,127L,148L,167L,191L,199L,313L,347L,356L,596L,692L,701L,1004L,1228L,1268L,1709L,2617L,3539L,3824L };
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
public class A242076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242076Inst : IEnumerable<long>
{
public static readonly long[] Value=A242076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242076.Bytes);
public long this[int i]=>Value[i];

public static A242076Inst Instance=new A242076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242077
{
public static readonly long[] Value={ 4L,5L,6L,14L,16L,24L,26L,34L,36L,64L,66L,74L,76L,84L,86L,114L,116L,124L,126L,134L,136L,164L,166L,174L,176L,184L,186L,214L,216L,224L,226L,234L,236L,264L,266L,274L,276L,284L,286L,314L,316L,324L,326L,334L,336L,364L,366L,374L,376L,384L,386L,414L,416L,424L,426L,434L };
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
public class A242077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242077Inst : IEnumerable<long>
{
public static readonly long[] Value=A242077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242077.Bytes);
public long this[int i]=>Value[i];

public static A242077Inst Instance=new A242077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242078
{
public static readonly long[] Value={ 1L,16L,169L,1764L,17689L,177241L,1774224L,17749369L,177502329L,1775105424L,17751298756L,177513070329L,1775132540281L,17751332312289L,177513333968569L,1775133399758224L,17751334196261689L,177513342503762329L };
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
public class A242078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242078Inst : IEnumerable<long>
{
public static readonly long[] Value=A242078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242078.Bytes);
public long this[int i]=>Value[i];

public static A242078Inst Instance=new A242078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242079
{
public static readonly long[] Value={ 1L,4L,12L,28L,73L,163L,343L,867L,1915L,4011L,8203L };
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
public class A242079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242079Inst : IEnumerable<long>
{
public static readonly long[] Value=A242079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242079.Bytes);
public long this[int i]=>Value[i];

public static A242079Inst Instance=new A242079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242224
{
public static readonly long[] Value={ 3L,6L,4L,9L,18L,5L,12L,8L,36L,6L,15L,30L,45L,60L,7L,18L,12L,10L,24L,90L,8L,21L,42L,63L,84L,105L,126L,9L,24L,16L,72L,12L,120L,48L,168L,10L,27L,54L,15L,108L,135L,30L,189L,216L,11L,30L,20L,90L,40L,14L,60L,210L,80L,270L,12L,33L,66L,99L,132L,165L,198L,231L,264L,297L,330L,13L };
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
public class A242224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242224Inst : IEnumerable<long>
{
public static readonly long[] Value=A242224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242224.Bytes);
public long this[int i]=>Value[i];

public static A242224Inst Instance=new A242224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242225
{
public static readonly long[] Value={ 1L,4L,48L,64L,1280L,3072L,86016L,49152L,2949120L,1310720L,11534336L,4194304L,1526726656L,2348810240L,12079595520L,3221225472L,73014444032L,51539607552L,137095356088320L,5772436045824L,3809807790243840L,725677674332160L,2023101395107840L,3166593487994880L };
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
public class A242225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242225Inst : IEnumerable<long>
{
public static readonly long[] Value=A242225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242225.Bytes);
public long this[int i]=>Value[i];

public static A242225Inst Instance=new A242225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242226
{
public static readonly long[] Value={ 45L,54L,63L,72L,81L,90L,99L,108L,117L,126L,135L,144L,153L,162L,171L,180L,189L,198L,207L,216L,225L,234L,252L,261L,270L,279L,288L,315L,324L,333L,342L,378L,387L,396L,432L,441L,450L,459L,486L,495L,504L,513L,549L,558L,567L,576L,594L,603L,612L,621L,630L,666L };
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
public class A242226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242226Inst : IEnumerable<long>
{
public static readonly long[] Value=A242226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242226.Bytes);
public long this[int i]=>Value[i];

public static A242226Inst Instance=new A242226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242227
{
public static readonly BigInteger[] Value={ 1L,2L,5L,23L,156L,1381L,15035L,194074L,2896075L,49039201L,928848744L,19456784423L,446577192985L,11144973040202L,300467694892469L,8702418178841399L,269474495849190900L,8883955944844458301L,BigInteger.Parse("310668983573706849635"),BigInteger.Parse("11485868436282308978194") };
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
public class A242227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242227Inst Instance=new A242227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242228
{
public static readonly BigInteger[] Value={ 1L,17L,1651L,473741L,300257371L,355743405917L,706872713310331L,2182548723605418941L,BigInteger.Parse("9894910566488309801851"),BigInteger.Parse("63052832687428562206049117"),BigInteger.Parse("545439670961897317869306191611"),BigInteger.Parse("6226501736967631584015448186252541"),BigInteger.Parse("91619831483112536750163352484302283131") };
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
public class A242228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242228Inst Instance=new A242228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242229
{
public static readonly BigInteger[] Value={ 1L,129L,121171L,421842405L,3921960731851L,80097035486409669L,BigInteger.Parse("3154805675402432477371"),BigInteger.Parse("218356776433458097793841045"),BigInteger.Parse("24765902586563160053438320367371"),BigInteger.Parse("4359137561016969073655241431827801509"),BigInteger.Parse("1139916274502953599866121961715757905518171") };
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
public class A242229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242229Inst Instance=new A242229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242230
{
public static readonly long[] Value={ 61L,4561L,9511L,17299L,19471L,26737L,30109L,37447L,49957L,69439L,94561L,196699L,209311L,259603L,317539L,333517L,352249L,414097L,427069L,459013L,678157L,845491L,886429L,943819L,1027189L,1217719L,1410163L,1472587L,1647379L,2165323L,2200777L,2230549L,2603389L };
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
public class A242230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242230Inst : IEnumerable<long>
{
public static readonly long[] Value=A242230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242230.Bytes);
public long this[int i]=>Value[i];

public static A242230Inst Instance=new A242230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242231
{
public static readonly long[] Value={ 13L,31L,59L,307L,383L,557L,997L,1409L,1723L,3541L,5113L,5407L,6323L,6977L,8017L,10303L,19469L,52673L,94559L,109897L,151717L,158009L,187927L,193163L,249503L,274069L,326617L,361807L,383791L,419261L,427067L,546863L,573809L,592133L,636017L,684757L,735307L,738743L };
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
public class A242231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242231Inst : IEnumerable<long>
{
public static readonly long[] Value=A242231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242231.Bytes);
public long this[int i]=>Value[i];

public static A242231Inst Instance=new A242231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242232
{
public static readonly BigInteger[] Value={ 6L,71L,10081L,203253121L,82623662392481281L,BigInteger.Parse("13653339174293451118767199870801921"),BigInteger.Parse("372827341216592355174245573447441869623455324379507680549087234580481") };
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
public class A242232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242232Inst Instance=new A242232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242233
{
public static readonly BigInteger[] Value={ 1L,1L,3L,11L,41L,137L,347L,611L,5777L,98321L,677363L,-4192197L,-134908871L,-617972327L,22749265099L,449951818387L,-632325203423L,-163681108703199L,-2324079456844573L,33233931805782635L,1734259111955765577L,14135975420529458857UL,BigInteger.Parse("-777499293367428199109") };
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
public class A242233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242233Inst Instance=new A242233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242234
{
public static readonly long[] Value={ 10L,22L,43L,82L,157L,304L,586L,1129L,2176L,4195L,8086L,15586L,30043L,57910L,111625L,215164L,414742L,799441L,1540972L,2970319L,5725474L,11036206L,21272971L,41004970L,79039621L,152353768L,293671330L,566069689L,1091134408L,2103229195L,4054104622L };
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
public class A242234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242234Inst : IEnumerable<long>
{
public static readonly long[] Value=A242234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242234.Bytes);
public long this[int i]=>Value[i];

public static A242234Inst Instance=new A242234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242235
{
public static readonly long[] Value={ 15L,35L,71L,139L,271L,531L,1047L,2059L,4047L,7955L,15639L,30747L,60447L,118835L,233623L,459291L,902943L,1775139L,3489831L,6860827L,13488031L,26516771L,52130599L,102486059L,201482287L,396103747L,778719463L,1530922155L,3009713711L };
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
public class A242235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242235Inst : IEnumerable<long>
{
public static readonly long[] Value=A242235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242235.Bytes);
public long this[int i]=>Value[i];

public static A242235Inst Instance=new A242235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242236
{
public static readonly long[] Value={ 21L,51L,106L,211L,416L,821L,1626L,3231L,6411L,12716L,25221L,50026L,99231L,196836L,390441L,774471L,1536226L,3047231L,6044436L,11989641L,23782446L,47174451L,93574431L,185612636L,368178041L,730311646L,1448633651L,2873484856L,5699795261L };
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
public class A242236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242236Inst : IEnumerable<long>
{
public static readonly long[] Value=A242236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242236.Bytes);
public long this[int i]=>Value[i];

public static A242236Inst Instance=new A242236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242237
{
public static readonly long[] Value={ 28L,70L,148L,298L,592L,1174L,2332L,4642L,9256L,18442L,36736L,73174L,145756L,290338L,578344L,1152046L,2294836L,4571230L,9105724L,18138274L,36130792L,71971246L,143364148L,285576250L,568857664L,1133144098L,2257182472L,4496226670L };
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
public class A242237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242237Inst : IEnumerable<long>
{
public static readonly long[] Value=A242237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242237.Bytes);
public long this[int i]=>Value[i];

public static A242237Inst Instance=new A242237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242238
{
public static readonly long[] Value={ 36L,92L,197L,400L,799L,1590L,3165L,6308L,12587L,25138L,50184L,100171L,199942L,399085L,796580L,1589995L,3173682L,6334777L,12644416L,25238648L,50377125L,100554308L,200709531L,400622482L,799654969L,1596136256L,3185937735L,6359231054L };
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
public class A242238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242238Inst : IEnumerable<long>
{
public static readonly long[] Value=A242238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242238.Bytes);
public long this[int i]=>Value[i];

public static A242238Inst Instance=new A242238Inst();

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