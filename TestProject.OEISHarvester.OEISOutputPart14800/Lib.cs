using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A086184
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,14L,14L,14L,14L,19L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,45L,18L,18L,18L,18L,18L,52L,52L,52L,52L,52L,52L,73L,73L,75L,75L,75L,75L,75L,32L };
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
public class A086184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086184Inst : IEnumerable<long>
{
public static readonly long[] Value=A086184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086184.Bytes);
public long this[int i]=>Value[i];

public static A086184Inst Instance=new A086184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086183
{
public static readonly long[] Value={ 3L,1L,4L,1L,5L,9L,9L,9L,9L,9L,9L,26L,26L,26L,26L,79L,79L,79L,79L,84L,97L,97L,97L,97L,97L,97L,97L,97L,97L,97L,97L,97L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L,592L };
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
public class A086183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086183Inst : IEnumerable<long>
{
public static readonly long[] Value=A086183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086183.Bytes);
public long this[int i]=>Value[i];

public static A086183Inst Instance=new A086183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086182
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,15L,22L,32L,46L,64L,89L,122L,165L,222L,296L,390L,512L,668L,864L,1113L,1426L };
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
public class A086182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086182Inst : IEnumerable<long>
{
public static readonly long[] Value=A086182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086182.Bytes);
public long this[int i]=>Value[i];

public static A086182Inst Instance=new A086182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086181
{
public static readonly long[] Value={ 3L,5L,4L,4L,0L,9L,0L,3L,5L,9L,5L,5L,1L,9L,2L,2L,8L,5L,3L,6L,1L,5L,9L,6L,5L,9L,8L,6L,6L,0L,4L,8L,0L,4L,5L,4L,0L,5L,8L,3L,0L,9L,9L,8L,4L,5L,4L,4L,4L,5L,7L,3L,6L,7L,5L,4L,5L,7L,8L,1L,2L,5L,3L,0L,3L,0L,5L,8L,4L,2L,9L,4L,2L,8L,5L,8L,8L,6L,3L,0L,1L,2L,2L,5L,6L,2L,5L,8L,5L,6L,6L,4L,2L,4L,8L,9L,1L,7L,9L,9L,9L,6L };
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
public class A086181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086181Inst : IEnumerable<long>
{
public static readonly long[] Value=A086181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086181.Bytes);
public long this[int i]=>Value[i];

public static A086181Inst Instance=new A086181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086180
{
public static readonly long[] Value={ 3L,4L,4L,9L,4L,8L,9L,7L,4L,2L,7L,8L,3L,1L,7L,8L,0L,9L,8L,1L,9L,7L,2L,8L,4L,0L,7L,4L,7L,0L,5L,8L,9L,1L,3L,9L,1L,9L,6L,5L,9L,4L,7L,4L,8L,0L,6L,5L,6L,6L,7L,0L,1L,2L,8L,4L,3L,2L,6L,9L,2L,5L,6L,7L,2L,5L,0L,9L,6L,0L,3L,7L,7L,4L,5L,7L,3L,1L,5L,0L,2L,6L,5L,3L,9L,8L,5L,9L,4L,3L,3L,1L,0L,4L,6L,4L,0L,2L,3L,4L,8L,1L };
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
public class A086180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086180Inst : IEnumerable<long>
{
public static readonly long[] Value=A086180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086180.Bytes);
public long this[int i]=>Value[i];

public static A086180Inst Instance=new A086180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086163
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,7L,7L,10L,13L,13L,16L,18L,19L,23L,27L,28L,32L,36L,39L,43L,48L,50L,56L,61L,65L,71L,77L,81L,90L,95L,100L,108L,116L,121L,132L,139L,145L,156L,167L,172L,185L,194L,202L,215L,228L,235L,250L,262L,273L,287L,302L,311L,329L,343L,356L,373L,390L,402L,424L,439L,454L };
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
public class A086163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086163Inst : IEnumerable<long>
{
public static readonly long[] Value=A086163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086163.Bytes);
public long this[int i]=>Value[i];

public static A086163Inst Instance=new A086163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086162
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,5L,5L,7L,8L,8L,11L,11L,11L,14L,15L,15L,19L,19L,19L,23L,24L,24L,29L,29L,29L,34L,35L,35L,41L,41L,41L,47L,48L,48L,55L,55L,55L,62L,63L,63L,71L,71L,71L,79L,80L,80L,89L,89L,89L,98L,99L,99L,109L,109L,109L,119L };
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
public class A086162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086162Inst : IEnumerable<long>
{
public static readonly long[] Value=A086162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086162.Bytes);
public long this[int i]=>Value[i];

public static A086162Inst Instance=new A086162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086161
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L };
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
public class A086161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086161Inst : IEnumerable<long>
{
public static readonly long[] Value=A086161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086161.Bytes);
public long this[int i]=>Value[i];

public static A086161Inst Instance=new A086161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086160
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,4L,4L,4L,6L,7L,7L,10L,11L,11L,14L,16L,16L,20L,22L,23L,27L,30L,31L,36L,39L,41L };
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
public class A086160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086160Inst : IEnumerable<long>
{
public static readonly long[] Value=A086160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086160.Bytes);
public long this[int i]=>Value[i];

public static A086160Inst Instance=new A086160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086159
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,4L,4L,4L,6L,6L,6L,9L,9L,9L,12L,12L,12L,16L,16L,16L,20L,20L,20L,25L,25L,25L,30L,30L,30L,36L,36L,36L,42L,42L,42L,49L,49L,49L,56L,56L,56L,64L,64L,64L,72L,72L,72L,81L,81L,81L,90L,90L,90L,100L,100L,100L,110L };
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
public class A086159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086159Inst : IEnumerable<long>
{
public static readonly long[] Value=A086159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086159.Bytes);
public long this[int i]=>Value[i];

public static A086159Inst Instance=new A086159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086158
{
public static readonly BigInteger[] Value={ 3L,5L,35L,3511L,351117L,35111729L,3511172941L,351117294159L,35111729415971L,35111729415971101L,BigInteger.Parse("35111729415971101107"),BigInteger.Parse("35111729415971101107137"),BigInteger.Parse("35111729415971101107137149"),BigInteger.Parse("35111729415971101107137149179") };
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
public class A086158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086158Inst Instance=new A086158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086157
{
public static readonly BigInteger[] Value={ 1L,13L,715L,137047L,151063807L,473437527487L,8759301830031103L,BigInteger.Parse("476009298383159238655"),BigInteger.Parse("124804541542651896036171775"),BigInteger.Parse("116591664734096391445571274997759"),BigInteger.Parse("528358596232540118601239210575638560767"),BigInteger.Parse("7144378940562638409529946721196600858719027199") };
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
public class A086157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086157Inst Instance=new A086157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086156
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,19L,1L,7L,4L,37L,1L,67L,1L,63L,43L,15L,1L,145L,1L,121L,69L,139L,1L,211L,6L,189L,13L,199L,1L,661L,1L,31L,145L,313L,87L,475L,1L,387L,195L,337L,1L,1155L,1L,427L,241L,559L,1L,691L,8L,817L,319L,577L,1L,1171L,163L,519L,393L,877L,1L,2413L,1L,999L,345L,63L,213L,2599L };
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
public class A086156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086156Inst : IEnumerable<long>
{
public static readonly long[] Value=A086156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086156.Bytes);
public long this[int i]=>Value[i];

public static A086156Inst Instance=new A086156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086155
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,4L,5L,5L,6L,5L,6L,7L,8L,7L,8L,9L,9L,10L,11L,11L,12L,11L,12L,13L,12L,13L,14L,15L,14L,15L,16L,16L,17L,18L,17L,18L,19L,19L,20L,19L,20L,21L,19L,20L,21L,22L,22L,23L,24L,24L,25L,26L,26L,27L,23L,24L,25L,25L,26L,27L,28L,28L,29L,28L,29L,30L,31L,29L,30L,30L,31L,32L,33L,32L };
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
public class A086155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086155Inst : IEnumerable<long>
{
public static readonly long[] Value=A086155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086155.Bytes);
public long this[int i]=>Value[i];

public static A086155Inst Instance=new A086155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086154
{
public static readonly BigInteger[] Value={ 1L,3L,126L,2220075L,33594090947249085L,BigInteger.Parse("9812294412288780842726471233974791140221"),BigInteger.Parse("747581321238203931168470352555568799370148397202082975882483140118428447896681620077224288595") };
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
public class A086154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086154Inst Instance=new A086154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086153
{
public static readonly long[] Value={ 3L,7L,3L,23L,5L,89L,23L,3L,139L,19L,7L,3L,199L,47L,17L,5L,113L,83L,23L,17L,3L,1831L,211L,43L,13L,7L,3L,523L,109L,79L,19L,11L,5L,887L,317L,107L,47L,17L,11L,3L,1129L,619L,109L,79L,19L,7L,1669L,199L,113L,73L,43L,13L,5L,2477L,1373L,197L,113L,71L,41L,11L,3L,2971L,1123L,199L,109L };
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
public class A086153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086153Inst : IEnumerable<long>
{
public static readonly long[] Value=A086153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086153.Bytes);
public long this[int i]=>Value[i];

public static A086153Inst Instance=new A086153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086152
{
public static readonly long[] Value={ 2L,4L,2L,4L,2L,8L,2L,4L,2L,5L,2L,8L,2L,5L,3L,4L,2L,8L,2L,5L,3L,4L,2L,8L,2L,4L,2L,5L,2L,13L,2L,4L,3L,4L,2L,8L,2L,4L,3L,5L,2L,11L,2L,4L,3L,4L,2L,8L,2L,5L,3L,4L,2L,8L,2L,5L,2L,4L,2L,13L,2L,4L,3L,4L,2L,9L,2L,4L,2L,7L,2L,8L,2L,4L,3L,4L,2L,9L,2L,5L,2L,4L,2L,11L,2L,4L,2L,4L,2L,13L,2L,4L,2L,4L,2L,8L,2L,5L,3L,5L,2L,9L,2L };
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
public class A086152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086152Inst : IEnumerable<long>
{
public static readonly long[] Value=A086152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086152.Bytes);
public long this[int i]=>Value[i];

public static A086152Inst Instance=new A086152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086151
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,0L,2L,4L,0L,0L,5L,19L,10L,3L,87L,9L,0L,377L,293L,84L,9L,265L,142L,502L };
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
public class A086151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086151Inst : IEnumerable<long>
{
public static readonly long[] Value=A086151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086151.Bytes);
public long this[int i]=>Value[i];

public static A086151Inst Instance=new A086151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086150
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,0L,1L,1L,1L,1L,2L,0L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,0L,2L,0L,1L,2L,1L,1L,2L,0L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,0L,1L,1L,3L,1L,6L,3L,4L,6L };
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
public class A086150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086150Inst : IEnumerable<long>
{
public static readonly long[] Value=A086150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086150.Bytes);
public long this[int i]=>Value[i];

public static A086150Inst Instance=new A086150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086149
{
public static readonly long[] Value={ 29L,41L,416387L,626597L,6560987L,6937937L,25658429L,25658441L,29597411L,49136357L,51448361L,57405419L,90279461L,128469149L,137943341L,162189089L,165531251L,175182587L };
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
public class A086149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086149Inst : IEnumerable<long>
{
public static readonly long[] Value=A086149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086149.Bytes);
public long this[int i]=>Value[i];

public static A086149Inst Instance=new A086149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086148
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,33L,57L,59L,79L,83L,133L,101L,183L,157L,177L,203L,307L,219L,381L,271L,343L,377L,553L,349L,571L,523L,601L,529L,871L,501L,993L,747L,843L,887L,973L,743L,1407L,1105L,1177L,983L,1723L,987L,1893L,1309L,1371L,1613L,2257L,1293L,2199L,1663L,2013L };
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
public class A086148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086148Inst : IEnumerable<long>
{
public static readonly long[] Value=A086148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086148.Bytes);
public long this[int i]=>Value[i];

public static A086148Inst Instance=new A086148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086131
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,5L,0L,3L,3L,7L,0L,2L,0L,3L,2L,2L,0L,7L,0L,3L,5L,13L,0L,11L,5L,5L,3L,2L,0L,31L,0L,5L,7L,19L,3L,5L,0L,7L,2L,17L,0L,41L,0L,3L,13L,5L,0L,7L,7L,5L,5L,7L,0L,3L,2L,23L,11L,31L,0L,23L,0L,11L,17L,3L,3L,61L,0L,3L,13L,59L,0L,13L,0L,13L,11L,5L,3L,71L,0L,11L,3L,43L,0L,31L,11L,5L,2L,7L,0L,41L,5L,3L };
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
public class A086131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086131Inst : IEnumerable<long>
{
public static readonly long[] Value=A086131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086131.Bytes);
public long this[int i]=>Value[i];

public static A086131Inst Instance=new A086131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086130
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,30L,7L,24L,18L,70L,11L,48L,13L,126L,120L,32L,17L,126L,19L,120L,210L,286L,23L,264L,50L,390L,27L,224L,29L,930L,31L,160L,462L,646L,420L,180L,37L,798L,624L,680L,41L,1722L,43L,528L,585L,1150L,47L,336L,98L,450L,1020L,728L,53L,162L,880L,1288L,1254L,1798L,59L };
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
public class A086130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086130Inst : IEnumerable<long>
{
public static readonly long[] Value=A086130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086130.Bytes);
public long this[int i]=>Value[i];

public static A086130Inst Instance=new A086130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086129
{
public static readonly long[] Value={ 26724377L,121967987L,128975057L,161184857L,190148267L,234742187L,257637647L };
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
public class A086129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086129Inst : IEnumerable<long>
{
public static readonly long[] Value=A086129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086129.Bytes);
public long this[int i]=>Value[i];

public static A086129Inst Instance=new A086129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086128
{
public static readonly long[] Value={ 831167L,1154567L,2502767L,3019787L,3675197L,5056577L,6352487L,14519177L };
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
public class A086128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086128Inst : IEnumerable<long>
{
public static readonly long[] Value=A086128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086128.Bytes);
public long this[int i]=>Value[i];

public static A086128Inst Instance=new A086128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086127
{
public static readonly long[] Value={ 4889L,18059L,62639L,225527L,557093L,604973L,700703L,804077L,806903L,837077L,1341203L,1363403L,1932197L,2004269L,2062703L,2284637L,2797463L,3157379L,3493103L,3746399L,3995687L,4155413L,4227893L,4493297L,5534939L,5708603L };
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
public class A086127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086127Inst : IEnumerable<long>
{
public static readonly long[] Value=A086127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086127.Bytes);
public long this[int i]=>Value[i];

public static A086127Inst Instance=new A086127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086126
{
public static readonly long[] Value={ 61L,101L,1811L,3491L,4091L,5711L,5801L,6361L,7121L,10391L,10771L,11311L,13421L,15131L };
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
public class A086126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086126Inst : IEnumerable<long>
{
public static readonly long[] Value=A086126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086126.Bytes);
public long this[int i]=>Value[i];

public static A086126Inst Instance=new A086126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086125
{
public static readonly long[] Value={ 2L,4L,8L,15L,31L,128L,163L };
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
public class A086125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086125Inst : IEnumerable<long>
{
public static readonly long[] Value=A086125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086125.Bytes);
public long this[int i]=>Value[i];

public static A086125Inst Instance=new A086125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086124
{
public static readonly BigInteger[] Value={ 5L,191L,8831183L,559832762721564181L,BigInteger.Parse("3655022053493602810873312808337814473758207442937") };
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
public class A086124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086124Inst Instance=new A086124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086123
{
public static readonly long[] Value={ 2L,6L,10L,12L,46L,126L,148L,180L,618L,928L,3406L,10948L,13240L,13872L,16518L };
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
public class A086123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086123Inst : IEnumerable<long>
{
public static readonly long[] Value=A086123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086123.Bytes);
public long this[int i]=>Value[i];

public static A086123Inst Instance=new A086123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086122
{
public static readonly BigInteger[] Value={ 31L,19531L,12207031L,305175781L,BigInteger.Parse("177635683940025046467781066894531"),BigInteger.Parse("14693679385278593849609206715278070972733319459651094018859396328480215743184089660644531"),BigInteger.Parse("35032461608120426773093239582247903282006548546912894293926707097244777067146515037165954709053039550781") };
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
public class A086122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086122Inst Instance=new A086122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086121
{
public static readonly long[] Value={ 16L,19L,35L,54L,98L,117L,133L,152L,218L,250L,316L,335L,351L,370L,468L,686L,866L,988L,1206L,1304L,1323L,1339L,1358L,1456L,1674L,1854L,1946L,2072L,2170L,2189L,2205L,2224L,2322L,2540L,2662L,2716L,3528L,3582L,4394L,4570L,4662L,4788L,4886L,4905L,4921L,4940L,5038L };
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
public class A086121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086121Inst : IEnumerable<long>
{
public static readonly long[] Value=A086121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086121.Bytes);
public long this[int i]=>Value[i];

public static A086121Inst Instance=new A086121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086120
{
public static readonly long[] Value={ 19L,98L,117L,218L,316L,335L,866L,988L,1206L,1304L,1323L,1854L,1946L,2072L,2170L,2189L,2716L,3582L,4570L,4662L,4788L,4886L,4905L,5308L,5402L,5528L,6516L,6734L,6832L,6851L,7254L,9970L,10586L,10836L,11824L,12042L,12140L,12159L,12222L,17530L,17624L,18268L };
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
public class A086120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086120Inst : IEnumerable<long>
{
public static readonly long[] Value=A086120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086120.Bytes);
public long this[int i]=>Value[i];

public static A086120Inst Instance=new A086120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086119
{
public static readonly long[] Value={ 16L,35L,54L,133L,152L,250L,351L,370L,468L,686L,1339L,1358L,1456L,1674L,2205L,2224L,2322L,2540L,2662L,3528L,4394L,4921L,4940L,5038L,5256L,6244L,6867L,6886L,6984L,7110L,7202L,8190L,9056L,9826L,11772L,12175L,12194L,12292L,12510L,13498L,13718L,14364L };
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
public class A086119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086119Inst : IEnumerable<long>
{
public static readonly long[] Value=A086119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086119.Bytes);
public long this[int i]=>Value[i];

public static A086119Inst Instance=new A086119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086118
{
public static readonly long[] Value={ 2L,2L,0L,7L,4L,1L,6L,0L,9L,9L,1L,6L,2L,4L,7L,7L,9L,6L,2L,3L,0L,6L,8L,5L,6L,7L,4L,5L,1L,2L,9L,8L,0L,8L,8L,9L,0L,2L,3L,6L,4L,2L,3L,2L,8L,2L,6L,4L,9L,3L,7L,8L,7L,0L,5L,4L,7L,8L,1L,4L,1L,6L,7L,2L,3L,8L,9L,4L,9L,5L,3L,9L,3L,6L,8L,0L,0L,1L,0L,6L,3L,9L,6L,7L,4L,4L,7L,2L,6L,2L,3L,7L,3L,6L,0L,7L,0L,8L,7L,7L,8L,1L };
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
public class A086118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086118Inst : IEnumerable<long>
{
public static readonly long[] Value=A086118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086118.Bytes);
public long this[int i]=>Value[i];

public static A086118Inst Instance=new A086118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086117
{
public static readonly long[] Value={ 2L,2L,4L,4L,16L,16L,32L,32L,256L,256L,512L,512L,2048L,2048L,4096L,4096L,65536L,65536L,131072L,131072L,524288L,524288L,1048576L,1048576L,8388608L,8388608L,16777216L,16777216L,67108864L,67108864L,134217728L,134217728L,4294967296L,4294967296L };
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
public class A086117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086117Inst : IEnumerable<long>
{
public static readonly long[] Value=A086117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086117.Bytes);
public long this[int i]=>Value[i];

public static A086117Inst Instance=new A086117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086116
{
public static readonly long[] Value={ 1L,1L,3L,3L,15L,15L,35L,35L,315L,315L,693L,693L,3003L,3003L,6435L,6435L,109395L,109395L,230945L,230945L,969969L,969969L,2028117L,2028117L,16900975L,16900975L,35102025L,35102025L,145422675L,145422675L,300540195L,300540195L,9917826435L };
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
public class A086116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086116Inst : IEnumerable<long>
{
public static readonly long[] Value=A086116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086116.Bytes);
public long this[int i]=>Value[i];

public static A086116Inst Instance=new A086116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086115
{
public static readonly long[] Value={ 10L,100L,390L,1080L,2470L,4980L,9170L,15760L,25650L,39940L,59950L,87240L,123630L,171220L,232410L,309920L,406810L,526500L,672790L,849880L,1062390L,1315380L,1614370L,1965360L,2374850L,2849860L,3397950L,4027240L,4746430L,5564820L };
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
public class A086115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086115Inst : IEnumerable<long>
{
public static readonly long[] Value=A086115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086115.Bytes);
public long this[int i]=>Value[i];

public static A086115Inst Instance=new A086115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086114
{
public static readonly long[] Value={ 8L,64L,216L,528L,1080L,1968L,3304L,5216L,7848L,11360L,15928L,21744L,29016L,37968L,48840L,61888L,77384L,95616L,116888L,141520L,169848L,202224L,239016L,280608L,327400L,379808L,438264L,503216L,575128L,654480L,741768L,837504L,942216L,1056448L };
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
public class A086114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086114Inst : IEnumerable<long>
{
public static readonly long[] Value=A086114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086114.Bytes);
public long this[int i]=>Value[i];

public static A086114Inst Instance=new A086114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086113
{
public static readonly long[] Value={ 6L,36L,102L,216L,390L,636L,966L,1392L,1926L,2580L,3366L,4296L,5382L,6636L,8070L,9696L,11526L,13572L,15846L,18360L,21126L,24156L,27462L,31056L,34950L,39156L,43686L,48552L,53766L,59340L,65286L,71616L,78342L,85476L,93030L,101016L,109446L,118332L };
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
public class A086113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086113Inst : IEnumerable<long>
{
public static readonly long[] Value=A086113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086113.Bytes);
public long this[int i]=>Value[i];

public static A086113Inst Instance=new A086113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086112
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,2L,7L,1L,9L,2L,11L,1L,13L,2L,15L,1L,17L,2L,19L,1L,21L,2L,23L,1L,25L,2L,27L,1L,29L,2L,31L,1L,33L,2L,35L,1L,37L,2L,39L,1L,41L,2L,43L,1L,45L,2L,47L,1L,49L,2L,51L,1L,53L,2L,55L,1L,57L,2L,59L,1L,61L,2L,63L,1L,65L,2L,67L,1L,69L,2L,71L,1L,73L,2L,75L,1L,77L,2L,79L,1L,81L,2L,83L };
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
public class A086112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086112Inst : IEnumerable<long>
{
public static readonly long[] Value=A086112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086112.Bytes);
public long this[int i]=>Value[i];

public static A086112Inst Instance=new A086112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086111
{
public static readonly long[] Value={ 0L,1L,2L,1L,6L,3L,12L,2L,20L,5L,30L,3L,42L,7L,56L,4L,72L,9L,90L,5L,110L,11L,132L,6L,156L,13L,182L,7L,210L,15L,240L,8L,272L,17L,306L,9L,342L,19L,380L,10L,420L,21L,462L,11L,506L,23L,552L,12L,600L,25L,650L,13L,702L,27L,756L,14L,812L,29L,870L,15L,930L,31L,992L,16L,1056L };
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
public class A086111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086111Inst : IEnumerable<long>
{
public static readonly long[] Value=A086111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086111.Bytes);
public long this[int i]=>Value[i];

public static A086111Inst Instance=new A086111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086110
{
public static readonly long[] Value={ 7L,37L,67L,73L,89L,179L,191L,373L,479L,521L,601L,613L,619L,653L,661L,673L,701L,719L,727L,769L,773L,853L,881L,907L,919L,1553L,1571L,1693L,1709L,1747L,1831L,2003L,2111L,2137L,2309L,2347L,2351L,2543L,2593L,2707L,2719L,2837L,3023L,3361L,3583L,3613L,3673L,3727L };
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
public class A086110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086110Inst : IEnumerable<long>
{
public static readonly long[] Value=A086110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086110.Bytes);
public long this[int i]=>Value[i];

public static A086110Inst Instance=new A086110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086109
{
public static readonly long[] Value={ 4L,12L,19L,21L,24L,41L,43L,74L,92L,98L,110L,112L,114L,119L,121L,122L,126L,128L,129L,136L,137L,147L,152L,155L,157L,245L,248L,264L,267L,272L,282L,304L,318L,322L,343L,348L,349L,372L,378L,394L,397L,412L,434L,474L,502L,505L,513L,520L,528L,534L,535L,536L,551L,553L };
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
public class A086109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086109Inst : IEnumerable<long>
{
public static readonly long[] Value=A086109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086109.Bytes);
public long this[int i]=>Value[i];

public static A086109Inst Instance=new A086109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086108
{
public static readonly long[] Value={ 2L,3L,5L,7L,12L,21L,113L,115L,131L,151L,311L,511L };
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
public class A086108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086108Inst : IEnumerable<long>
{
public static readonly long[] Value=A086108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086108.Bytes);
public long this[int i]=>Value[i];

public static A086108Inst Instance=new A086108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086107
{
public static readonly long[] Value={ 2L,3L,5L,7L,113L,131L,151L,311L };
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
public class A086107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086107Inst : IEnumerable<long>
{
public static readonly long[] Value=A086107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086107.Bytes);
public long this[int i]=>Value[i];

public static A086107Inst Instance=new A086107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086106
{
public static readonly long[] Value={ 1L,3L,8L,0L,2L,7L,7L,5L,6L,9L,0L,9L,7L,6L,1L,4L,1L,1L,5L,6L,7L,3L,3L,0L,1L,6L,9L,1L,8L,2L,2L,7L,3L,1L,8L,7L,7L,8L,1L,6L,6L,2L,6L,7L,0L,1L,5L,5L,8L,7L,6L,3L,0L,2L,5L,4L,1L,1L,7L,7L,1L,3L,3L,1L,2L,1L,1L,2L,4L,9L,5L,7L,4L,1L,1L,8L,6L,4L,1L,5L,2L,6L,1L,8L,7L,8L,6L,4L,5L,6L,8L,2L,4L,9L,0L,3L,5L,5L,0L,9L,3L,7L };
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
public class A086106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086106Inst : IEnumerable<long>
{
public static readonly long[] Value=A086106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086106.Bytes);
public long this[int i]=>Value[i];

public static A086106Inst Instance=new A086106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086105
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,1L,2L,2L,4L,6L,24L,4738381338321616896L,4738381338321616920L,BigInteger.Parse("22452257707354557353808363243511480320") };
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
public class A086105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086105Inst Instance=new A086105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086104
{
public static readonly long[] Value={ 23L,71L,11L,31L,71L,13L,17L,37L,71L,11L,31L,71L,31L,71L,11L,71L,11L,71L,31L,71L,31L,11L,11L,31L,71L,73L,13L,73L,13L,73L,73L,73L,17L,17L,97L,97L,37L,97L,37L,17L,17L,97L,37L,79L,79L,19L,79L,19L,79L,79L,19L,79L,19L,71L,31L,11L,11L,31L,11L,11L,31L,71L,11L,31L,71L,31L,71L,31L,11L };
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
public class A086104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086104Inst : IEnumerable<long>
{
public static readonly long[] Value=A086104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086104.Bytes);
public long this[int i]=>Value[i];

public static A086104Inst Instance=new A086104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086103
{
public static readonly long[] Value={ 3137L,8389L,911L,2713L,9319L,9719L,3323L,7127L,8329L,1733L,6737L,941L,2143L,3343L,761L,1361L,8369L,971L,3373L,6977L,8779L,9199L,311L,911L,2311L,6311L,8111L,113L,313L,1913L,2113L,2713L,6113L,7717L,8317L,719L,1319L,3119L,3319L,4919L,5119L,7919L,8719L };
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
public class A086103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086103Inst : IEnumerable<long>
{
public static readonly long[] Value=A086103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086103.Bytes);
public long this[int i]=>Value[i];

public static A086103Inst Instance=new A086103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086102
{
public static readonly long[] Value={ 11L,23L,29L,31L,44L,45L,51L,58L,61L,66L,73L,80L,82L,84L,111L,112L,124L,127L,130L,136L,138L,167L,185L,186L,188L,192L,194L,212L,213L,215L,216L,217L,218L,275L,276L,292L,293L,294L,295L,296L,297L,299L,300L,301L,302L,319L,321L,326L,344L,345L,346L,348L,352L,353L,355L };
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
public class A086102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086102Inst : IEnumerable<long>
{
public static readonly long[] Value=A086102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086102.Bytes);
public long this[int i]=>Value[i];

public static A086102Inst Instance=new A086102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086101
{
public static readonly long[] Value={ 1L,4L,5L,6L,7L,11L,20L,21L,25L,26L,27L,28L,30L,31L,32L,33L,36L,37L,38L,39L,40L,42L,43L,44L,45L,63L,64L,66L,67L,68L,69L,73L,125L,126L,127L,128L,130L,131L,132L,133L,135L,136L,137L,154L,155L,156L,159L,160L,161L,163L,164L,165L,167L,168L,170L,172L,173L,174L,177L,178L,179L };
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
public class A086101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086101Inst : IEnumerable<long>
{
public static readonly long[] Value=A086101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086101.Bytes);
public long this[int i]=>Value[i];

public static A086101Inst Instance=new A086101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086100
{
public static readonly long[] Value={ 0L,0L,1L,0L,11L,10L,11L,0L,111L,110L,111L,100L,111L,110L,111L,0L,1111L,1110L,1111L,1100L,1111L,1110L,1111L,1000L,1111L,1110L,1111L,1100L,1111L,1110L,1111L,0L,11111L,11110L,11111L,11100L,11111L,11110L,11111L,11000L,11111L,11110L,11111L,11100L };
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
public class A086100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086100Inst : IEnumerable<long>
{
public static readonly long[] Value=A086100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086100.Bytes);
public long this[int i]=>Value[i];

public static A086100Inst Instance=new A086100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086067
{
public static readonly long[] Value={ 1L,10L,100L,1000L,10000L,100000L,1000000L,10000000L,100000000L,1000000000L,11L,10L,110L,1010L,10010L,100010L,1000010L,10000010L,100000010L,1000000010L,101L,110L,100L,1100L,10100L,100100L,1000100L,10000100L,100000100L,1000000100L };
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
public class A086067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086067Inst : IEnumerable<long>
{
public static readonly long[] Value=A086067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086067.Bytes);
public long this[int i]=>Value[i];

public static A086067Inst Instance=new A086067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086066
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,3L,2L,6L,10L,18L,34L,66L,130L,258L,514L,5L,6L,4L,12L,20L,36L,68L,132L,260L,516L,9L,10L,12L,8L,24L,40L,72L,136L,264L,520L,17L,18L,20L,24L,16L,48L,80L,144L,272L,528L,33L,34L,36L,40L,48L,32L,96L,160L,288L,544L,65L,66L,68L,72L,80L };
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
public class A086066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086066Inst : IEnumerable<long>
{
public static readonly long[] Value=A086066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086066.Bytes);
public long this[int i]=>Value[i];

public static A086066Inst Instance=new A086066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086065
{
public static readonly BigInteger[] Value={ 0L,1L,6L,196L,5408L,251132L,16873158L,1420208149L,154380762016L,20646224057048L,3433326930682392L,642182473998511032L,BigInteger.Parse("152740983098362758624"),BigInteger.Parse("40168709084329725908872"),BigInteger.Parse("12234598116934739577149272") };
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
public class A086065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086065Inst Instance=new A086065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086064
{
public static readonly long[] Value={ 2L,10L,6L,10L,6L,3L,6L,10L,6L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,6L,10L,10L,10L,10L,5L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,6L,10L,10L,10L,10L,10L,10L,10L,10L,10L,3L,10L,10L,10L,10L,10L,10L,10L,10L,10L,6L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
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
public class A086064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086064Inst : IEnumerable<long>
{
public static readonly long[] Value=A086064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086064.Bytes);
public long this[int i]=>Value[i];

public static A086064Inst Instance=new A086064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086063
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,3L,3L,3L,2L,3L,3L,5L,3L,4L,3L,3L,2L,3L,3L,6L,3L,6L,5L,3L,3L,5L,5L,2L,3L,3L,3L,3L,2L,3L,3L,6L,3L,8L,6L,3L,3L,2L,9L,4L,5L,6L,5L,5L,3L,5L,5L,4L,5L,6L,2L,5L,3L,5L,3L,6L,3L,6L,3L,3L,2L,3L,3L,6L,3L,7L,6L,10L,3L,9L,11L,5L,7L,8L,4L,5L,3L,9L,2L,8L,9L,7L,4L,6L,5L,6L,6L,3L,5L,5L,5L,5L,3L,5L,5L,3L,5L,9L,11L,7L };
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
public class A086063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086063Inst : IEnumerable<long>
{
public static readonly long[] Value=A086063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086063.Bytes);
public long this[int i]=>Value[i];

public static A086063Inst Instance=new A086063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086062
{
public static readonly long[] Value={ 8L,20L,38L,58L,85L,113L,143L,185L,229L,274L,324L,376L,439L,505L,573L,643L,718L,794L,872L,964L,1062L,1161L,1263L,1368L,1478L,1592L,1708L,1825L,1949L,2074L,2204L,2342L,2489L,2637L,2790L,2944L,3108L,3273L,3443L,3614L,3786L,3960L,4135L,4317L,4503L,4691L,4881L };
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
public class A086062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086062Inst : IEnumerable<long>
{
public static readonly long[] Value=A086062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086062.Bytes);
public long this[int i]=>Value[i];

public static A086062Inst Instance=new A086062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086061
{
public static readonly long[] Value={ 256L,640L,1216L,1856L,2720L,3616L,4576L,5872L,7216L,8624L,10064L,11664L,13328L,15272L,17288L,19400L,21560L,23736L,25976L,28376L,30808L,33304L,36220L,39164L,42188L,45324L,48492L,51732L,54996L,58356L,61876L,65476L,69124L,72836L,76580L };
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
public class A086061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086061Inst : IEnumerable<long>
{
public static readonly long[] Value=A086061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086061.Bytes);
public long this[int i]=>Value[i];

public static A086061Inst Instance=new A086061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086060
{
public static readonly BigInteger[] Value={ 5L,57L,5713L,571319L,57131931L,5713193143L,571319314361L,57131931436173L,57131931436173103L,BigInteger.Parse("57131931436173103109"),BigInteger.Parse("57131931436173103109139"),BigInteger.Parse("57131931436173103109139151"),BigInteger.Parse("57131931436173103109139151181") };
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
public class A086060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086060Inst Instance=new A086060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086059
{
public static readonly long[] Value={ 128L,320L,608L,928L,1360L,1808L,2288L,2936L,3608L,4312L,5032L,5832L,6664L,7636L,8644L,9700L,10780L,11868L,12988L,14188L,15404L,16652L,18110L,19582L,21094L,22662L,24246L,25866L,27498L,29178L,30938L,32738L,34562L,36418L,38290L,40274L,42274L,44354L };
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
public class A086059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086059Inst : IEnumerable<long>
{
public static readonly long[] Value=A086059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086059.Bytes);
public long this[int i]=>Value[i];

public static A086059Inst Instance=new A086059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086058
{
public static readonly long[] Value={ 1L,8L,2L,2L,8L,2L,5L,2L,4L,9L,6L,7L,8L,8L,4L,7L,0L,3L,2L,9L,9L,5L,3L,2L,8L,7L,1L,6L,2L,6L,1L,4L,6L,4L,9L,4L,9L,4L,7L,5L,6L,9L,3L,1L,1L,8L,8L,9L,4L,8L,5L,0L,2L,1L,8L,3L,9L,3L,8L,1L,5L,6L,1L,3L,0L,3L,7L,0L,9L,0L,9L,5L,6L,4L,4L,6L,4L,0L,1L,6L,6L,7L,5L,7L,2L,1L,9L,5L,3L,2L,5L,7L,3L,2L,3L,4L,4L,5L,3L,2L,4L,7L };
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
public class A086058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086058Inst : IEnumerable<long>
{
public static readonly long[] Value=A086058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086058.Bytes);
public long this[int i]=>Value[i];

public static A086058Inst Instance=new A086058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086057
{
public static readonly long[] Value={ 6L,4L,6L,2L,4L,5L,4L,3L,9L,8L,9L,4L,8L,1L,3L,3L,0L,4L,2L,6L,6L,4L,7L,3L,3L,9L,6L,8L,4L,5L,7L,9L,2L,7L,9L,0L,0L,2L,2L,0L,1L,2L,9L,1L,2L,9L,6L,3L,1L,5L,7L,7L,2L,9L,3L,3L,0L,3L,8L,6L,2L,4L,6L,9L,9L,2L,9L,8L,3L,0L,1L,1L,0L,0L,0L,2L,8L,9L,2L,8L,0L,0L,5L,2L,7L,7L,9L,4L,3L,1L,1L,3L,1L,7L,6L,6L,0L,7L,0L,7L,5L,7L };
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
public class A086057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086057Inst : IEnumerable<long>
{
public static readonly long[] Value=A086057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086057.Bytes);
public long this[int i]=>Value[i];

public static A086057Inst Instance=new A086057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086056
{
public static readonly long[] Value={ 5L,7L,7L,8L,6L,3L,6L,7L,4L,8L,9L,5L,4L,6L,0L,8L,5L,8L,9L,5L,5L,0L,4L,6L,5L,9L,1L,6L,5L,6L,3L,4L,8L,1L,4L,9L,5L,6L,0L,4L,2L,5L,5L,1L,1L,5L,8L,2L,2L,0L,7L,9L,1L,0L,2L,4L,9L,8L,5L,3L,2L,6L,7L,6L,6L,3L,6L,4L,4L,3L,1L,5L,9L,2L,0L,4L,5L,8L,4L,6L,9L,7L,2L,0L,0L,9L,4L,2L,1L,7L,1L,1L,7L,8L,3L,6L,7L,7L,9L,4L,0L,2L };
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
public class A086056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086056Inst : IEnumerable<long>
{
public static readonly long[] Value=A086056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086056.Bytes);
public long this[int i]=>Value[i];

public static A086056Inst Instance=new A086056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086055
{
public static readonly long[] Value={ 5L,9L,7L,7L,9L,8L,6L,8L,1L,2L,1L,7L,8L,3L,4L,9L,1L,2L,2L,6L,6L,9L,0L,5L,3L,3L,1L,9L,3L,3L,9L,2L,2L,7L,7L,4L,6L,9L,5L,8L,5L,3L,1L,8L,4L,5L,2L,3L,1L,2L,0L,3L,3L,6L,2L,9L,7L,8L,3L,1L,7L,5L,5L,2L,5L,3L,5L,5L,0L,8L,0L,2L,0L,0L,3L,4L,9L,0L,9L,7L,8L,9L,7L,7L,7L,2L,1L,7L,6L,9L,7L,8L,7L,4L,0L,4L,8L,1L,3L,3L,2L,9L };
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
public class A086055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086055Inst : IEnumerable<long>
{
public static readonly long[] Value=A086055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086055.Bytes);
public long this[int i]=>Value[i];

public static A086055Inst Instance=new A086055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086054
{
public static readonly long[] Value={ 2L,1L,7L,7L,5L,8L,6L,0L,9L,0L,3L,0L,3L,6L,0L,2L,1L,3L,0L,5L,0L,0L,6L,8L,8L,8L,9L,8L,2L,3L,7L,6L,1L,3L,9L,4L,7L,3L,3L,8L,5L,8L,3L,7L,0L,0L,3L,6L,9L,2L,8L,6L,2L,9L,4L,3L,2L,5L,7L,9L,5L,2L,5L,3L,1L,9L,4L,3L,0L,8L,5L,4L,9L,1L,7L,6L,7L,4L,1L,9L,8L,6L,4L,3L,0L,3L,2L,8L,9L,6L,1L,6L,1L,0L,6L,6L,3L,0L,2L,5L,0L,5L,7L,6L,1L };
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
public class A086054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086054Inst : IEnumerable<long>
{
public static readonly long[] Value=A086054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086054.Bytes);
public long this[int i]=>Value[i];

public static A086054Inst Instance=new A086054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086053
{
public static readonly long[] Value={ 1L,0L,9L,8L,6L,8L,5L,8L,0L,5L,5L,2L,5L,1L,8L,7L,0L,1L,3L,0L,1L,7L,7L,4L,6L,3L,2L,5L,7L,2L,1L,3L,3L,1L,8L,0L,7L,9L,3L,1L,2L,2L,2L,0L,7L,1L,0L,6L,4L,4L,2L,6L,8L,4L,0L,7L,4L,1L,0L,4L,2L,7L,8L,1L,5L,7L,8L,3L,2L,1L,7L,4L,4L,3L,6L,9L,6L,6L,5L,6L,0L,8L,2L,3L,2L,2L,4L,2L,3L,9L,1L,7L,4L,4L,7L,4L,9L,7L,9L,9L,0L,6L,6L,0L,5L };
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
public class A086053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086053Inst : IEnumerable<long>
{
public static readonly long[] Value=A086053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086053.Bytes);
public long this[int i]=>Value[i];

public static A086053Inst Instance=new A086053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086052
{
public static readonly long[] Value={ 64L,160L,304L,464L,680L,904L,1144L,1468L,1804L,2156L,2516L,2916L,3332L,3818L,4322L,4850L,5390L,5934L,6494L,7094L,7702L,8326L,9055L,9791L,10547L,11331L,12123L,12933L,13749L,14589L,15469L,16369L,17281L,18209L,19145L,20137L,21137L,22177L,23281L };
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
public class A086052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086052Inst : IEnumerable<long>
{
public static readonly long[] Value=A086052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086052.Bytes);
public long this[int i]=>Value[i];

public static A086052Inst Instance=new A086052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085971
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L };
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
public class A085971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085971Inst : IEnumerable<long>
{
public static readonly long[] Value=A085971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085971.Bytes);
public long this[int i]=>Value[i];

public static A085971Inst Instance=new A085971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085970
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,5L,5L,6L,6L,7L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,15L,16L,17L,17L,18L,19L,20L,20L,21L,21L,22L,23L,24L,24L,25L,25L,26L,27L,28L,28L,29L,30L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,40L,41L,41L,42L,42L,43L };
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
public class A085970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085970Inst : IEnumerable<long>
{
public static readonly long[] Value=A085970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085970.Bytes);
public long this[int i]=>Value[i];

public static A085970Inst Instance=new A085970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085969
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,4L,4L,6L,7L,5L,7L,4L,9L,6L,2L,4L,5L,0L,6L,6L,3L,0L,7L,3L,5L,8L,5L,1L,4L,0L,7L,8L,3L,1L,1L,7L,5L,3L,6L,8L,2L,2L,9L,2L,0L,3L,4L,9L,7L,3L,8L,5L,7L,8L,5L,5L,0L,2L,7L,5L,5L,9L,1L,7L,3L,9L,7L,9L,3L,7L,2L,6L,2L,5L,1L,5L,1L,9L,9L,7L,7L,1L,9L,0L,8L,1L,3L,5L,5L,3L,4L,3L,4L,0L,1L,2L,4L,4L,1L,7L,7L,2L,4L,3L,0L };
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
public class A085969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085969Inst : IEnumerable<long>
{
public static readonly long[] Value=A085969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085969.Bytes);
public long this[int i]=>Value[i];

public static A085969Inst Instance=new A085969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085968
{
public static readonly long[] Value={ 0L,0L,4L,0L,6L,1L,4L,0L,5L,3L,6L,6L,5L,1L,7L,8L,3L,0L,5L,6L,0L,5L,2L,3L,4L,3L,9L,1L,4L,2L,6L,8L,3L,0L,8L,0L,5L,2L,2L,9L,7L,7L,1L,4L,4L,5L,1L,2L,0L,7L,1L,7L,4L,1L,0L,0L,1L,0L,3L,2L,6L,8L,8L,6L,8L,1L,7L,2L,8L,6L,3L,0L,4L,0L,7L,0L,7L,8L,8L,0L,4L,4L,0L,6L,0L,9L,2L,2L,8L,2L,8L,0L,5L,3L,0L,4L,3L,1L,3L,4L,4L,2L,6L,5L,6L };
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
public class A085968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085968Inst : IEnumerable<long>
{
public static readonly long[] Value=A085968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085968.Bytes);
public long this[int i]=>Value[i];

public static A085968Inst Instance=new A085968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085967
{
public static readonly long[] Value={ 0L,0L,8L,2L,8L,3L,8L,3L,2L,8L,5L,6L,1L,3L,3L,5L,9L,2L,5L,3L,5L,1L,2L,4L,1L,3L,8L,7L,2L,9L,4L,4L,8L,7L,2L,3L,0L,8L,9L,1L,8L,3L,3L,2L,8L,8L,8L,5L,3L,0L,7L,8L,0L,6L,2L,4L,4L,6L,4L,1L,9L,2L,1L,6L,3L,8L,6L,5L,5L,4L,8L,9L,4L,1L,1L,0L,0L,7L,8L,5L,8L,1L,8L,4L,3L,1L,6L,6L,1L,3L,4L,1L,8L,1L,9L,1L,8L,2L,0L,0L,4L,3L,2L,8L,1L };
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
public class A085967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085967Inst : IEnumerable<long>
{
public static readonly long[] Value=A085967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085967.Bytes);
public long this[int i]=>Value[i];

public static A085967Inst Instance=new A085967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085966
{
public static readonly long[] Value={ 0L,1L,7L,0L,7L,0L,0L,8L,6L,8L,5L,0L,6L,3L,6L,5L,1L,2L,9L,5L,4L,1L,3L,3L,6L,7L,3L,2L,6L,6L,0L,5L,9L,3L,9L,9L,2L,0L,9L,5L,8L,5L,9L,4L,1L,8L,7L,4L,5L,4L,4L,2L,4L,4L,7L,3L,3L,1L,6L,3L,3L,6L,8L,8L,3L,6L,9L,6L,9L,7L,3L,6L,7L,4L,7L,1L,7L,2L,4L,3L,6L,6L,7L,1L,8L,6L,0L,3L,5L,0L,0L,7L,8L,1L,8L,0L,6L,2L,3L,0L,2L,8L,8L,2L,3L };
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
public class A085966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085966Inst : IEnumerable<long>
{
public static readonly long[] Value=A085966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085966.Bytes);
public long this[int i]=>Value[i];

public static A085966Inst Instance=new A085966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085965
{
public static readonly long[] Value={ 0L,3L,5L,7L,5L,5L,0L,1L,7L,4L,8L,3L,9L,2L,4L,2L,5L,7L,1L,3L,2L,8L,1L,8L,2L,4L,2L,5L,3L,8L,8L,5L,5L,7L,1L,1L,1L,3L,1L,6L,9L,7L,2L,7L,6L,7L,2L,6L,6L,5L,1L,3L,3L,1L,6L,9L,0L,0L,9L,2L,6L,7L,4L,8L,2L,3L,9L,7L,5L,8L,3L,4L,2L,7L,4L,7L,2L,7L,9L,3L,1L,3L,6L,6L,0L,7L,2L,8L,0L,6L,4L,7L,0L,3L,7L,6L,7L,9L,5L,0L,8L,9L,6L,3L,9L };
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
public class A085965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085965Inst : IEnumerable<long>
{
public static readonly long[] Value=A085965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085965.Bytes);
public long this[int i]=>Value[i];

public static A085965Inst Instance=new A085965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085964
{
public static readonly long[] Value={ 0L,7L,6L,9L,9L,3L,1L,3L,9L,7L,6L,4L,2L,4L,6L,8L,4L,4L,9L,4L,2L,6L,1L,9L,2L,9L,5L,9L,3L,3L,1L,5L,7L,8L,7L,0L,1L,6L,2L,0L,4L,1L,0L,5L,9L,7L,1L,4L,8L,4L,3L,1L,9L,0L,2L,6L,4L,9L,3L,8L,0L,0L,8L,8L,5L,9L,2L,1L,6L,5L,7L,0L,4L,8L,7L,5L,6L,4L,2L,0L,6L,5L,1L,0L,3L,3L,3L,1L,0L,6L,7L,8L,5L,3L,9L,6L,2L,8L,9L,5L,4L,2L,0L,2L,9L };
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
public class A085964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085964Inst : IEnumerable<long>
{
public static readonly long[] Value=A085964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085964.Bytes);
public long this[int i]=>Value[i];

public static A085964Inst Instance=new A085964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085963
{
public static readonly long[] Value={ 3L,5L,5L,3L,7L,5L,7L,5L,3L,7L,11L,11L,7L,5L,7L,11L,5L,11L,3L,7L,13L,11L,13L,11L,7L,13L,5L,7L,11L,13L,5L,11L,3L,7L,13L,17L,13L,17L,11L,13L,11L,7L,17L,13L,5L,17L,7L,11L,13L,5L,11L,17L,3L,7L,17L,13L,19L,17L,13L,19L,17L,11L,13L,19L,11L,7L,17L,19L,13L,5L,17L,7L,11L,13L,19L,5L,11L,17L,3L,19L,7L };
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
public class A085963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085963Inst : IEnumerable<long>
{
public static readonly long[] Value=A085963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085963.Bytes);
public long this[int i]=>Value[i];

public static A085963Inst Instance=new A085963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085962
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,3L,3L,2L,5L,2L,3L,2L,2L,3L,5L,3L,7L,2L,5L,2L,2L,3L,3L,2L,5L,2L,3L,5L,7L,3L,7L,2L,5L,11L,2L,2L,3L,2L,3L,3L,2L,5L,5L,2L,7L,3L,5L,7L,3L,7L,11L,2L,5L,13L,11L,2L,2L,2L,3L,3L,2L,3L,5L,3L,2L,5L,7L,5L,2L,7L,3L,5L,7L,11L,3L,7L,11L,2L,13L,5L,13L,11L,17L,2L,2L,2L,3L,2L,3L,3L,2L,5L,3L,5L,3L,2L,5L,7L,7L,5L };
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
public class A085962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085962Inst : IEnumerable<long>
{
public static readonly long[] Value=A085962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085962.Bytes);
public long this[int i]=>Value[i];

public static A085962Inst Instance=new A085962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085961
{
public static readonly long[] Value={ 1L,4L,3L,4L,15L,6L,7L,8L,18L,20L,44L,12L,13L,28L,15L,32L,68L,18L,38L,20L,42L,44L,138L,24L,150L,78L,54L,28L,174L,60L,31L,32L,132L,68L,140L,36L,74L,38L,39L,40L,164L,42L,258L,44L,90L,138L,282L,48L,98L,150L,102L,104L,212L,54L,110L,56L,57L,174L,354L,60L,183L,124L,63L,128L,195L };
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
public class A085961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085961Inst : IEnumerable<long>
{
public static readonly long[] Value=A085961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085961.Bytes);
public long this[int i]=>Value[i];

public static A085961Inst Instance=new A085961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085960
{
public static readonly long[] Value={ 1L,2L,9L,16L,25L,34L,49L,64L,81L,100L,121L,144L,169L,196L,225L,256L,289L,324L,361L,400L,441L,484L,529L,576L,625L,676L,729L,784L,841L,900L,961L,1024L,1089L,1156L,1225L,1296L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2401L,2500L };
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
public class A085960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085960Inst : IEnumerable<long>
{
public static readonly long[] Value=A085960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085960.Bytes);
public long this[int i]=>Value[i];

public static A085960Inst Instance=new A085960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085959
{
public static readonly long[] Value={ 0L,37L,74L,111L,148L,185L,222L,259L,296L,333L,370L,407L,444L,481L,518L,555L,592L,629L,666L,703L,740L,777L,814L,851L,888L,925L,962L,999L,1036L,1073L,1110L,1147L,1184L,1221L,1258L,1295L,1332L,1369L,1406L,1443L,1480L,1517L,1554L,1591L,1628L,1665L,1702L,1739L };
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
public class A085959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085959Inst : IEnumerable<long>
{
public static readonly long[] Value=A085959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085959.Bytes);
public long this[int i]=>Value[i];

public static A085959Inst Instance=new A085959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085958
{
public static readonly long[] Value={ 17L,137L,809L,857L,3209L,6569L,7577L,9209L,11897L,16217L,17657L,19289L,21929L,23417L,30809L,35129L,37529L,41849L,46889L,53609L,56009L,66377L,70457L,74729L,76697L,78809L,80537L,88937L,91577L,95177L,96857L,103289L,129497L,141257L,165449L,166169L };
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
public class A085958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085958Inst : IEnumerable<long>
{
public static readonly long[] Value=A085958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085958.Bytes);
public long this[int i]=>Value[i];

public static A085958Inst Instance=new A085958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085957
{
public static readonly long[] Value={ 13L,103L,283L,367L,607L,787L,907L,1987L,2203L,2767L,3643L,4507L,5623L,5827L,6907L,7927L,7963L,8167L,8887L,9067L,9643L,10867L,11083L,11443L,12487L,13723L,14083L,14143L,16747L,17107L,17827L,19507L,19543L,20743L,20947L,21487L,22567L,24043L };
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
public class A085957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085957Inst : IEnumerable<long>
{
public static readonly long[] Value=A085957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085957.Bytes);
public long this[int i]=>Value[i];

public static A085957Inst Instance=new A085957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085956
{
public static readonly long[] Value={ 5L,13L,13L,17L,31L,61L,239L,0L,127L,41L,0L,73L,131L,0L,61L,1889L,0L,397L,419L,0L,211L,89L,0L,97L,101L,0L,163L,113L,0L,181L,2543L,0L,463L,2789L,211L,5689L,149L,0L,547L,881L,0L,1093L,173L,0L,271L,9293L,0L,673L,491L,0L,1123L,14249L,0L,10909L,3191L,0L,229L,1973L,0L,241L };
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
public class A085956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085956Inst : IEnumerable<long>
{
public static readonly long[] Value=A085956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085956.Bytes);
public long this[int i]=>Value[i];

public static A085956Inst Instance=new A085956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085955
{
public static readonly long[] Value={ 4L,6L,9L,16L,20L,22L,24L,28L,36L,38L,49L,56L,65L,69L,70L,72L,84L,86L,92L,100L,104L,105L,118L,130L,132L,133L,134L,138L,148L,150L,152L,153L,162L,166L,176L,180L,184L,208L,209L,212L,214L,216L,256L,258L,259L,261L,262L,264L,266L,267L,278L,284L,320L,325L,326L,329L,345L };
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
public class A085955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085955Inst : IEnumerable<long>
{
public static readonly long[] Value=A085955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085955.Bytes);
public long this[int i]=>Value[i];

public static A085955Inst Instance=new A085955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085954
{
public static readonly BigInteger[] Value={ 4L,42L,424L,4248L,42480L,42480L,424802L,42480210L,4248021008L,424802100816L,4248021008160L,42480210081603L,424802100816038L,4248021008160384L,424802100816038400L,424802100816038400L,BigInteger.Parse("42480210081603840012") };
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
public class A085954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085954Inst Instance=new A085954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085953
{
public static readonly BigInteger[] Value={ 2L,21L,210L,210L,2101L,210106L,2101064L,210106408L,21010640806L,210106408066L,21010640806615L,2101064080661535L,210106408066153506L,BigInteger.Parse("21010640806615350608"),BigInteger.Parse("2101064080661535060818"),BigInteger.Parse("21010640806615350608186") };
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
public class A085953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085953Inst Instance=new A085953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085952
{
public static readonly long[] Value={ 1L,91L,901L,9001L,90001L,900001L,9000001L,90000001L,900000001L,9000000001L,90000000001L,900000000001L,9000000000001L,90000000000001L,900000000000001L,9000000000000001L,90000000000000001L,900000000000000001L };
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
public class A085952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085952Inst : IEnumerable<long>
{
public static readonly long[] Value=A085952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085952.Bytes);
public long this[int i]=>Value[i];

public static A085952Inst Instance=new A085952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085951
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,91L,11L,13L,31L,15L,51L,17L,71L,19L,93L,33L,35L,53L,37L,73L,39L,95L,55L,57L,75L,59L,97L,77L,79L,99L,901L,101L,103L,301L,105L,501L,107L,701L,109L,903L,303L,305L,503L,307L,703L,309L,905L,505L,507L,705L,509L,907L,707L,709L,909L,911L,111L,113L,311L,115L,511L };
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
public class A085951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085951Inst : IEnumerable<long>
{
public static readonly long[] Value=A085951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085951.Bytes);
public long this[int i]=>Value[i];

public static A085951Inst Instance=new A085951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085950
{
public static readonly long[] Value={ 5L,14L,22L,39L,68L,95L,138L,145L,248L,296L,328L,559L,658L,477L,1416L,854L,1005L,994L,1679L,1422L,1411L,1513L,1358L,3131L,3399L,3638L,3815L,4068L,1651L,2358L,3699L,4865L,3427L,3624L,5966L,12388L,5344L,5709L,15036L,7964L,5730L,5983L,12608L,12935L,6119L };
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
public class A085950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085950Inst : IEnumerable<long>
{
public static readonly long[] Value=A085950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085950.Bytes);
public long this[int i]=>Value[i];

public static A085950Inst Instance=new A085950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085949
{
public static readonly long[] Value={ 9L,10L,21L,33L,39L,51L,57L,115L,116L,124L,185L,123L,129L,235L,106L,236L,244L,335L,213L,292L,395L,415L,623L,291L,303L,309L,321L,327L,1017L,1143L,655L,548L,834L,894L,604L,314L,815L,835L,346L,716L,1086L,1146L,579L,591L,1393L,422L,892L,681L,687L,1165L,956L,1446L };
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
public class A085949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085949Inst : IEnumerable<long>
{
public static readonly long[] Value=A085949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085949.Bytes);
public long this[int i]=>Value[i];

public static A085949Inst Instance=new A085949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085948
{
public static readonly long[] Value={ 1L,3L,10L,27L,74L,176L,431L,987L,2259L,5025L,11168L,24351L,53022L,114204L,245221L,523173L,1112996L,2356796L,4978235L,10480426L,22014499L,46125601L,96457248L,201300980L,419404740L,872360898L,1811883714L,3757979313L,7784511152L };
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
public class A085948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085948Inst : IEnumerable<long>
{
public static readonly long[] Value=A085948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085948.Bytes);
public long this[int i]=>Value[i];

public static A085948Inst Instance=new A085948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085947
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,9L,13L,11L,6L,17L,23L,8L,31L,39L,7L,46L,53L,33L,43L,19L,62L,27L,89L,29L,59L,22L,81L,103L,92L,15L,107L,61L,12L,73L,85L,79L,41L,10L,51L };
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
public class A085947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085947Inst : IEnumerable<long>
{
public static readonly long[] Value=A085947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085947.Bytes);
public long this[int i]=>Value[i];

public static A085947Inst Instance=new A085947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085946
{
public static readonly long[] Value={ 1L,2L,3L,23L,17L,7L,59L,11L,257L,11257L,13L,1125713L,43708571L,19L,9L,199L,9199L,43L,487L,43487L,39L,228881L,811L,1973L,41L,197341L,51L,379L,191L,126397L,21L,731L,31L,57L,77L,53L,7753L,79L,70489L,346543L,121L,346543121L,47L,37L,1579L,101L,526367L,5343493L };
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
public class A085946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085946Inst : IEnumerable<long>
{
public static readonly long[] Value=A085946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085946.Bytes);
public long this[int i]=>Value[i];

public static A085946Inst Instance=new A085946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085945
{
public static readonly long[] Value={ 1L,2L,5L,11L,26L,53L,116L,236L,488L,983L,2006L,4016L,8111L,16238L,32603L,65243L,130778L,261566L,523709L,1047479L,2095988L,4192115L,8386418L,16772858L,33550058L,67100393L,134209001L,268418531L,536853986L,1073707991L };
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
public class A085945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085945Inst : IEnumerable<long>
{
public static readonly long[] Value=A085945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085945.Bytes);
public long this[int i]=>Value[i];

public static A085945Inst Instance=new A085945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085944
{
public static readonly long[] Value={ 1L,2L,3L,4567L,890L,123L,45678L,901L,23L,4567890L,1234L,5L,6L,7L,89012345L,67L,89012345678L,90123L,45678901L,2345L,678L,901234L,5678L,9012345L,67890L,12345L,678901L,2345678L,901234567L,8901234567890L,1234567L,8901234567890123L };
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
public class A085944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085944Inst : IEnumerable<long>
{
public static readonly long[] Value=A085944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085944.Bytes);
public long this[int i]=>Value[i];

public static A085944Inst Instance=new A085944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085943
{
public static readonly long[] Value={ 1L,2L,3L,4567L,89L,10L,11L,1213L,14L,15L,161L,7L,181L,9202L,122L,23L,242526L,27282L,930L,31L,323L,33L,43L,5L,3637L,38L,39L,404142L,434L,445L,46L,47L,4849L,505L,15253L,545L,55L,6L,57L,58L,59L,606L,1626L,3646L,566L,67L,6869L,70L,71L,727L,37L,4757L,677L,78L,79L,8081L,82L };
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
public class A085943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085943Inst : IEnumerable<long>
{
public static readonly long[] Value=A085943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085943.Bytes);
public long this[int i]=>Value[i];

public static A085943Inst Instance=new A085943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085942
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,49L,64L,81L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,8L,16L,24L,32L,40L,48L,56L,64L,72L,0L,10L,20L,30L,40L,50L,60L,70L,80L,90L,0L,12L,24L,36L,48L,60L,72L,84L,96L,108L,0L,14L,28L,42L,56L,70L,84L };
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
public class A085942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085942Inst : IEnumerable<long>
{
public static readonly long[] Value=A085942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085942.Bytes);
public long this[int i]=>Value[i];

public static A085942Inst Instance=new A085942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085941
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,3L,6L,12L,24L,48L,96L,192L,384L,768L,1536L,9L,18L,36L };
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
public class A085941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085941Inst : IEnumerable<long>
{
public static readonly long[] Value=A085941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085941.Bytes);
public long this[int i]=>Value[i];

public static A085941Inst Instance=new A085941Inst();

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