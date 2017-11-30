using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A215057
{
public static readonly long[] Value={ 0L,0L,8L,92L,606L,4835L,41059L };
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
public class A215057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215057Inst : IEnumerable<long>
{
public static readonly long[] Value=A215057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215057.Bytes);
public long this[int i]=>Value[i];

public static A215057Inst Instance=new A215057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215058
{
public static readonly long[] Value={ 0L,0L,7L,25L,242L,1933L,16080L };
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
public class A215058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215058Inst : IEnumerable<long>
{
public static readonly long[] Value=A215058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215058.Bytes);
public long this[int i]=>Value[i];

public static A215058Inst Instance=new A215058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215059
{
public static readonly long[] Value={ 1L,10L,11L,12L,13L,15L,20L,21L,30L,31L,50L,51L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1100L,1101L,1102L,1110L,1111L,1112L,1120L,1121L,1200L,1201L,1210L,1211L,1339L,1344L,1345L,1354L,1356L,1359L,1365L,1366L,1368L,1386L,1393L,1395L,1434L,1435L,1443L };
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
public class A215059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215059Inst : IEnumerable<long>
{
public static readonly long[] Value=A215059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215059.Bytes);
public long this[int i]=>Value[i];

public static A215059Inst Instance=new A215059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215060
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,-1L,0L,0L,1L,0L,-4L,0L,0L,1L,0L,0L,-10L,0L,0L,1L,19L,0L,0L,-20L,0L,0L,1L,0L,133L,0L,0L,-35L,0L,0L,1L,0L,0L,532L,0L,0L,-56L,0L,0L,1L,-1513L,0L,0L,1596L,0L,0L,-84L,0L,0L,1L,0L,-15130L,0L,0L,3990L,0L,0L,-120L,0L,0L,1L,0L,0L,-83215L,0L };
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
public class A215060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215060Inst : IEnumerable<long>
{
public static readonly long[] Value=A215060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215060.Bytes);
public long this[int i]=>Value[i];

public static A215060Inst Instance=new A215060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215061
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,4L,0L,0L,1L,0L,0L,10L,0L,0L,1L,1L,0L,0L,20L,0L,0L,1L,0L,7L,0L,0L,35L,0L,0L,1L,0L,0L,28L,0L,0L,56L,0L,0L,1L,1L,0L,0L,84L,0L,0L,84L,0L,0L,1L,0L,10L,0L,0L,210L,0L,0L,120L,0L,0L,1L,0L,0L,55L,0L,0L,462L,0L,0L,165L,0L,0L,1L,1L,0L,0L };
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
public class A215061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215061Inst : IEnumerable<long>
{
public static readonly long[] Value=A215061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215061.Bytes);
public long this[int i]=>Value[i];

public static A215061Inst Instance=new A215061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215062
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,0L,3L,3L,1L,-3L,0L,6L,4L,1L,-9L,-15L,0L,10L,5L,1L,0L,-54L,-45L,0L,15L,6L,1L,99L,0L,-189L,-105L,0L,21L,7L,1L,477L,792L,0L,-504L,-210L,0L,28L,8L,1L,0L,4293L,3564L,0L,-1134L,-378L,0L,36L,9L,1L,-11259L,0L,21465L,11880L,0L,-2268L };
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
public class A215062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215062Inst : IEnumerable<long>
{
public static readonly long[] Value=A215062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215062.Bytes);
public long this[int i]=>Value[i];

public static A215062Inst Instance=new A215062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215063
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,0L,3L,-3L,1L,-3L,0L,6L,-4L,1L,9L,-15L,0L,10L,-5L,1L,-18L,54L,-45L,0L,15L,-6L,1L,27L,-126L,189L,-105L,0L,21L,-7L,1L,-27L,216L,-504L,504L,-210L,0L,28L,-8L,1L,0L,-243L,972L,-1512L,1134L,-378L,0L,36L,-9L,1L,81L,0L,-1215L };
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
public class A215063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215063Inst : IEnumerable<long>
{
public static readonly long[] Value=A215063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215063.Bytes);
public long this[int i]=>Value[i];

public static A215063Inst Instance=new A215063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215064
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,-1L,3L,3L,1L,-3L,-4L,6L,4L,1L,-9L,-15L,-10L,10L,5L,1L,19L,-54L,-45L,-20L,15L,6L,1L,99L,133L,-189L,-105L,-35L,21L,7L,1L,477L,792L,532L,-504L,-210L,-56L,28L,8L,1L,-1513L,4293L,3564L,1596L,-1134L,-378L,-84L,36L,9L,1L,-11259L };
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
public class A215064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215064Inst : IEnumerable<long>
{
public static readonly long[] Value=A215064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215064.Bytes);
public long this[int i]=>Value[i];

public static A215064Inst Instance=new A215064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215065
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,1L,3L,-3L,1L,-11L,4L,6L,-4L,1L,49L,-55L,10L,10L,-5L,1L,-137L,294L,-165L,20L,15L,-6L,1L,-127L,-959L,1029L,-385L,35L,21L,-7L,1L,5573L,-1016L,-3836L,2744L,-770L,56L,28L,-8L,1L,-50399L,50157L,-4572L,-11508L,6174L,-1386L,84L };
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
public class A215065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215065Inst : IEnumerable<long>
{
public static readonly long[] Value=A215065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215065.Bytes);
public long this[int i]=>Value[i];

public static A215065Inst Instance=new A215065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215066
{
public static readonly BigInteger[] Value={ 1L,1L,7L,127L,4315L,235831L,18911467L,2091412807L,305035062955L,56729101908151L,13102338649018027L,3679320979659518887L,BigInteger.Parse("1234515698986458346795"),BigInteger.Parse("487763952468349266962071"),BigInteger.Parse("224150079034073231822617387"),BigInteger.Parse("118541831524545132821950527367") };
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
public class A215066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215066Inst Instance=new A215066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215067
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,10L,21L,37L,80L,146L,322L,602L,1347L,2563L,5798L,11181L,25512L,49720L,114236L,224540L,518848L,1027038L,2384538L,4748042L,11068567L,22150519L,51817118L,104146733L,244370806L,493012682L,1159883685L,2347796965L };
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
public class A215067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215067Inst : IEnumerable<long>
{
public static readonly long[] Value=A215067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215067.Bytes);
public long this[int i]=>Value[i];

public static A215067Inst Instance=new A215067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215068
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,16L,24L,31L,48L,127L,8191L,131071L,524287L };
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
public class A215068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215068Inst : IEnumerable<long>
{
public static readonly long[] Value=A215068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215068.Bytes);
public long this[int i]=>Value[i];

public static A215068Inst Instance=new A215068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215069
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,9L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,52L,53L,54L,55L };
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
public class A215069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215069Inst : IEnumerable<long>
{
public static readonly long[] Value=A215069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215069.Bytes);
public long this[int i]=>Value[i];

public static A215069Inst Instance=new A215069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215070
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,40L,154L,660L,3114L,15930L,87645L,514851L,3211220L,21166029L,146849903L,1068808441L,8136559688L,64621235409L,534207882566L };
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
public class A215070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215070Inst : IEnumerable<long>
{
public static readonly long[] Value=A215070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215070.Bytes);
public long this[int i]=>Value[i];

public static A215070Inst Instance=new A215070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215071
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,39L,138L,503L,1864L,6936L,25868L,96512L,360203L,1344408L,5018051L,18729944L,69910398L,260943079L,973980990L,3635421345L,13569354266L,50648137765L,189046143161L };
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
public class A215071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215071Inst : IEnumerable<long>
{
public static readonly long[] Value=A215071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215071.Bytes);
public long this[int i]=>Value[i];

public static A215071Inst Instance=new A215071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215072
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,40L,153L,638L,2825L,12938L,60458L,285664L,1358283L,6480694L,30979999L,148249768L,709832688L,3399805736L,16286469156L,78026226228L,373832145200L,1791120945112L };
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
public class A215072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215072Inst : IEnumerable<long>
{
public static readonly long[] Value=A215072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215072.Bytes);
public long this[int i]=>Value[i];

public static A215072Inst Instance=new A215072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215073
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,40L,154L,659L,3085L,15438L,81200L,442206L,2465945L,13968206L,79933735L,460447075L,2663586832L,15450089345L,89773528848L,522212524474L };
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
public class A215073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215073Inst : IEnumerable<long>
{
public static readonly long[] Value=A215073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215073.Bytes);
public long this[int i]=>Value[i];

public static A215073Inst Instance=new A215073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215074
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,40L,154L,660L,3113L,15893L,86857L,502092L,3036032L,19006591L,122119857L,799665333L,5308126648L,35576413852L,240063646519L,1627605038848L };
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
public class A215074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215074Inst : IEnumerable<long>
{
public static readonly long[] Value=A215074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215074.Bytes);
public long this[int i]=>Value[i];

public static A215074Inst Instance=new A215074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215075
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,2L,3L,0L,1L,1L,2L,4L,5L,0L,1L,1L,2L,4L,11L,7L,0L,1L,1L,2L,4L,12L,29L,10L,0L,1L,1L,2L,4L,12L,39L,77L,13L,0L,1L,1L,2L,4L,12L,40L,138L,202L,18L,0L,1L,1L,2L,4L,12L,40L,153L,503L,532L,24L,0L,1L,1L,2L,4L,12L,40L,154L,638L,1864L,1395L,34L,0L,1L,1L,2L,4L,12L,40L,154L,659L };
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
public class A215075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215075Inst : IEnumerable<long>
{
public static readonly long[] Value=A215075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215075.Bytes);
public long this[int i]=>Value[i];

public static A215075Inst Instance=new A215075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215076
{
public static readonly long[] Value={ 3L,3L,17L,66L,269L,1088L,4406L,17839L,72229L,292449L,1184102L,4794331L,19411850L,78596976L,318232659L,1288497731L,5217020805L,21123285998L,85526438945L,346289481632L,1402097486674L,5676976825495L,22985609904813L,93066834503093L,376819919954026L,1525712707779263L };
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
public class A215076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215076Inst : IEnumerable<long>
{
public static readonly long[] Value=A215076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215076.Bytes);
public long this[int i]=>Value[i];

public static A215076Inst Instance=new A215076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215077
{
public static readonly BigInteger[] Value={ 0L,1L,7L,66L,852L,14020L,280472L,6609232L,179317056L,5505532992L,188717617280L,7143999854464L,296013377405440L,13325516967972352L,647610246703508480L,BigInteger.Parse("33794224057227356160"),BigInteger.Parse("1884620857353101983744"),BigInteger.Parse("111857608180484932648960"),BigInteger.Parse("7040178644779119413723136"),BigInteger.Parse("468349192560992552808841216"),BigInteger.Parse("32836927387372039917034405888") };
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
public class A215077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215077Inst Instance=new A215077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215078
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,5L,0L,3L,27L,36L,0L,4L,102L,392L,354L,0L,5L,330L,2760L,6500L,4425L,0L,6L,975L,15880L,73350L,123090L,67171L,0L,7L,2709L,81060L,654500L,2033325L,2637327L,1200304L,0L,8L,7196L,381808L,5064780L,25926824L,59992660L,63259168L,24684612L,0L,9L,18468L,1696464L,35574840L,281668590L,1034305524L,1896003648L,1681960464L,574304985L,0L,10L,46125L,7208880L,232816500L,2740317300L,14981494710L,42457884000L,64240088580L,49143419250L,14914341925L };
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
public class A215078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215078Inst : IEnumerable<long>
{
public static readonly long[] Value=A215078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215078.Bytes);
public long this[int i]=>Value[i];

public static A215078Inst Instance=new A215078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215079
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,4L,0L,7L,32L,27L,0L,15L,176L,405L,256L,0L,31L,832L,3888L,6144L,3125L,0L,63L,3648L,30618L,90112L,109375L,46656L,0L,127L,15360L,216513L,1048576L,2265625L,2239488L,823543L,0L,255L,63232L,1436859L,10682368L,36328125L,62145792L,51883209L,16777216L,0L,511L,257024L,9172278L,100139008L,500000000L,1310100480L,1856265922L,1342177280L,387420489L,0L,1023L,1037312L,57159432L,889192448L,6230468750L,23339943936L,49715643824L,60129542144L,38354628411L,10000000000L };
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
public class A215079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215079Inst : IEnumerable<long>
{
public static readonly long[] Value=A215079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215079.Bytes);
public long this[int i]=>Value[i];

public static A215079Inst Instance=new A215079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215080
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,6L,0L,1L,11L,54L,0L,1L,20L,151L,680L,0L,1L,37L,413L,2569L,11000L,0L,1L,70L,1128L,9450L,52431L,217392L,0L,1L,135L,3104L,34416L,243255L,1251921L,5076400L,0L,1L,264L,8637L,125248L,1113027L,7025016L,34282879L,136761984L,0L,1L,521L,24327L,457807L,5064143L,38811015L,225930121L,1059812993L,4175432064L,0L,1L,1034L,69334L,1685266L,23031680L,212609518L,1465077802L,8026643702L,36519075583L,142469423360L };
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
public class A215080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215080Inst : IEnumerable<long>
{
public static readonly long[] Value=A215080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215080.Bytes);
public long this[int i]=>Value[i];

public static A215080Inst Instance=new A215080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215081
{
public static readonly long[] Value={ 2L,6L,15L,10L,21L,14L,55L,0L,33L,22L,39L,26L,85L,0L,51L,34L,57L,38L,115L,0L,69L,46L,203L,0L,145L,0L,87L,58L,93L,62L,259L,0L,185L,0L,111L,74L,205L,0L,123L,82L,129L,86L,235L,0L,141L,94L,371L,0L,265L,0L,159L,106L,413L,0L,295L,0L,177L,118L,183L,122L,469L,0L,335L,0L };
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
public class A215081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215081Inst : IEnumerable<long>
{
public static readonly long[] Value=A215081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215081.Bytes);
public long this[int i]=>Value[i];

public static A215081Inst Instance=new A215081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215082
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,5L,8L,12L,17L,23L,35L,43L,66L,81L,124L,148L,229L,266L,414L,476L,742L,842L,1318L,1478L,2320L,2581L,4059L,4481L,7062L,7743L,12224L,13328L,21071L,22857L,36185L,39073L,61930L,66605L,105678L,113242L,179847L,192084L,305326L,325128L,517212L,549252L };
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
public class A215082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215082Inst : IEnumerable<long>
{
public static readonly long[] Value=A215082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215082.Bytes);
public long this[int i]=>Value[i];

public static A215082Inst Instance=new A215082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215083
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,5L,0L,1L,9L,36L,0L,1L,17L,98L,354L,0L,1L,33L,276L,1300L,4425L,0L,1L,65L,794L,4890L,20515L,67171L,0L,1L,129L,2316L,18700L,96825L,376761L,1200304L,0L,1L,257L,6818L,72354L,462979L,2142595L,7907396L,24684612L,0L,1L,513L,20196L,282340L,2235465L,12313161L,52666768L,186884496L,574304985L,0L,1L,1025L,60074L,1108650L,10874275L,71340451L,353815700L,1427557524L,4914341925L,14914341925L };
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
public class A215083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215083Inst : IEnumerable<long>
{
public static readonly long[] Value=A215083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215083.Bytes);
public long this[int i]=>Value[i];

public static A215083Inst Instance=new A215083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215084
{
public static readonly BigInteger[] Value={ 0L,1L,6L,46L,470L,6035L,93436L,1695036L,35277012L,828707925L,21693441550L,626254969978L,19766667410282L,677231901484775L,25031756512858200L,992872579254244088L,BigInteger.Parse("42066929594261568840"),BigInteger.Parse("1896157095455962952169"),BigInteger.Parse("90601933352843530354170"),BigInteger.Parse("4574495282686422755339734"),BigInteger.Parse("243359175218492577008763726") };
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
public class A215084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215084Inst Instance=new A215084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215085
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,19L,17L,1L,2567L,3350L,128928L,3706896L,1290179L,100170428L,39080794L,61998759572L,7833495265L,45119290746L,581075656330L,8672770990L,15792702394898740L,594681417768520250L,25509154378676494L,BigInteger.Parse("1642780344643617537867"),BigInteger.Parse("480931910076867717575") };
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
public class A215085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215085Inst Instance=new A215085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215086
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,3L,4L,0L,1L,1L,3L,8L,10L,0L,1L,1L,3L,9L,26L,26L,0L,1L,1L,3L,9L,32L,92L,76L,0L,1L,1L,3L,9L,33L,126L,372L,232L,0L,1L,1L,3L,9L,33L,134L,564L,1566L,764L,0L,1L,1L,3L,9L,33L,135L,622L,2700L,7086L,2620L,0L,1L,1L,3L,9L,33L,135L,632L,3106L,13802L,33550L,9496L,0L };
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
public class A215086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215086Inst : IEnumerable<long>
{
public static readonly long[] Value=A215086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215086.Bytes);
public long this[int i]=>Value[i];

public static A215086Inst Instance=new A215086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215087
{
public static readonly long[] Value={ 1L,1L,3L,8L,26L,92L,372L,1566L,7086L,33550L,167504L,873226L,4764614L,26947632L,157926628L,954523378L,5945067490L,38060781922L,250345198424L,1688978186742L,11679437620552L,82652840640478L,598018846154666L,4418072084681592L,33298670603875846L,255782905412464810L };
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
public class A215087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215087Inst : IEnumerable<long>
{
public static readonly long[] Value=A215087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215087.Bytes);
public long this[int i]=>Value[i];

public static A215087Inst Instance=new A215087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215088
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,2L,3L,4L,5L,6L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,8L,9L,10L,11L,12L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,8L,9L,10L,11L,12L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,14L,15L,16L,17L,18L,16L,17L,18L,19L,20L,12L,13L,14L,15L,16L,14L,15L,16L,17L,18L,16L,17L,18L,19L,20L,18L,19L,20L,21L,22L,20L,21L,22L,23L };
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
public class A215088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215088Inst : IEnumerable<long>
{
public static readonly long[] Value=A215088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215088.Bytes);
public long this[int i]=>Value[i];

public static A215088Inst Instance=new A215088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215089
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,15L,4L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,15L,12L,13L,14L,15L,16L,17L,14L,15L,16L,17L,18L,19L,8L,9L,10L,11L,12L,13L,10L };
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
public class A215089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215089Inst : IEnumerable<long>
{
public static readonly long[] Value=A215089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215089.Bytes);
public long this[int i]=>Value[i];

public static A215089Inst Instance=new A215089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215090
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,18L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,30L,27L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,36L,36L,37L,38L,39L,27L,28L,29L,30L,30L,31L,32L };
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
public class A215090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215090Inst : IEnumerable<long>
{
public static readonly long[] Value=A215090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215090.Bytes);
public long this[int i]=>Value[i];

public static A215090Inst Instance=new A215090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215091
{
public static readonly long[] Value={ 2L,5L,11L,25L,55L,123L,275L,615L,1375L,3075L,6875L,15373L,34375L,76865L,171875L,384325L,859376L,1921624L,4296881L,9608119L,21484407L,48040595L,107422036L,240202975L,537110180L,1201014874L,2685550900L,6005074370L,13427754501L };
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
public class A215091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215091Inst : IEnumerable<long>
{
public static readonly long[] Value=A215091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215091.Bytes);
public long this[int i]=>Value[i];

public static A215091Inst Instance=new A215091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215092
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,11L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,15L,16L,17L,18L,19L,20L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,16L,17L,15L,16L,17L,18L,19L,20L,18L,19L,20L,21L,22L,23L,21L,22L,23L,24L,25L,26L,24L,25L,26L,27L,28L,29L,18L };
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
public class A215092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215092Inst : IEnumerable<long>
{
public static readonly long[] Value=A215092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215092.Bytes);
public long this[int i]=>Value[i];

public static A215092Inst Instance=new A215092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215093
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,165L,1801L,24003L,378379L,6880485L,141757201L,3263757123L,83046239299L,2314209491685L,70093262093401L,2292753819807363L,80548997707137979L,3024937662747436965L,BigInteger.Parse("120925183043471954401"),BigInteger.Parse("5127013172890341294723"),BigInteger.Parse("229794790034059392232819") };
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
public class A215093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215093Inst Instance=new A215093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215094
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,211L,2296L,30619L,482455L,8768596L,180603511L,4157281129L,105764735440L,2946911156281L,89247262497121L,2919028298593684L,102543779766289705L,3850690682004992491L,BigInteger.Parse("153927330069247143976"),BigInteger.Parse("6525942204725963508259"),BigInteger.Parse("292483420180063453725175") };
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
public class A215094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215094Inst Instance=new A215094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215095
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,17L,35L,68L,136L,273L,547L,1092L,2184L,4369L,8739L,17476L,34952L,69905L,139811L,279620L,559240L,1118481L,2236963L,4473924L,8947848L,17895697L,35791395L,71582788L,143165576L,286331153L,572662307L,1145324612L,2290649224L,4581298449L,9162596899L };
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
public class A215095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215095Inst : IEnumerable<long>
{
public static readonly long[] Value=A215095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215095.Bytes);
public long this[int i]=>Value[i];

public static A215095Inst Instance=new A215095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215096
{
public static readonly BigInteger[] Value={ 0L,1L,2L,5L,22L,115L,698L,4925L,39622L,357955L,3589178L,39558845L,475412422L,6187461955L,86702878778L,1301486906045L,20836087009222L,354385941189955L,6381537618718778L,121290714467642045L,2426520470557921222L,BigInteger.Parse("50969651457241797955"),BigInteger.Parse("1121574207307049758778") };
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
public class A215096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215096Inst Instance=new A215096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215097
{
public static readonly long[] Value={ 0L,1L,8L,26L,56L,99L,160L,244L,352L,485L,648L,846L,1080L,1351L,1664L,2024L,2432L,2889L,3400L,3970L,4600L,5291L,6048L,6876L,7776L,8749L,9800L,10934L,12152L,13455L,14848L,16336L,17920L,19601L,21384L,23274L,25272L,27379L,29600L,31940L,34400L,36981L,39688L,42526L };
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
public class A215097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215097Inst : IEnumerable<long>
{
public static readonly long[] Value=A215097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215097.Bytes);
public long this[int i]=>Value[i];

public static A215097Inst Instance=new A215097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215098
{
public static readonly long[] Value={ 0L,1L,2L,5L,10L,15L,20L,27L,36L,45L,54L,65L,78L,91L,104L,119L,136L,153L,170L,189L,210L,231L,252L,275L,300L,325L,350L,377L,406L,435L,464L,495L,528L,561L,594L,629L,666L,703L,740L,779L,820L,861L,902L,945L,990L,1035L,1080L,1127L,1176L,1225L,1274L,1325L,1378L,1431L };
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
public class A215098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215098Inst : IEnumerable<long>
{
public static readonly long[] Value=A215098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215098.Bytes);
public long this[int i]=>Value[i];

public static A215098Inst Instance=new A215098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215099
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,10L,11L,13L,18L,24L,25L,29L,34L,38L,39L,41L,44L,48L,53L,55L,56L,58L,71L,73L,78L,84L,85L,89L,94L,102L,103L,109L,120L,124L,131L,133L,138L,144L,145L,149L,162L,164L,169L,173L,178L,180L,181L,187L,192L,196L,197L,201L };
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
public class A215099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215099Inst : IEnumerable<long>
{
public static readonly long[] Value=A215099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215099.Bytes);
public long this[int i]=>Value[i];

public static A215099Inst Instance=new A215099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215100
{
public static readonly long[] Value={ 2L,5L,22L,88L,357L,1445L,5851L,23690L,95919L,388368L,1572470L,6366801L,25778651L,104375627L,422608286L,1711106017L,6928126822L,28051412820L,113577851765L,459867333397L,1861964820071L,7538941645566L,30524551550379L,123591386053472L,500411306007498L,2026124013786761L };
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
public class A215100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215100Inst : IEnumerable<long>
{
public static readonly long[] Value=A215100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215100.Bytes);
public long this[int i]=>Value[i];

public static A215100Inst Instance=new A215100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215101
{
public static readonly long[] Value={ 2L,3L,41L,59L,79L,97L,173L,193L,211L,269L,307L,383L,401L,421L,439L,743L,839L,857L,877L,953L,971L,991L,1009L,1123L,1181L,1237L,1409L,1427L,1447L,1523L,1579L,1637L,1693L,1789L,1979L,1997L,2017L,2111L,2131L,2207L,2339L,2377L,2473L,2549L,2663L,2719L,2777L,2833L,2909L };
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
public class A215101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215101Inst : IEnumerable<long>
{
public static readonly long[] Value=A215101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215101.Bytes);
public long this[int i]=>Value[i];

public static A215101Inst Instance=new A215101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215102
{
public static readonly long[] Value={ 2L,3L,5L,13L,47L,71L,79L,101L,113L,137L,157L,167L,179L,181L,211L,223L,233L,269L,277L,311L,313L,379L,401L,409L,421L,431L,443L,467L,487L,509L,541L,563L,577L,599L,607L,619L,641L,643L,673L,709L,739L,751L,761L,773L,797L,827L,839L,863L,883L,907L,929L,937L,971L };
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
public class A215102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215102Inst : IEnumerable<long>
{
public static readonly long[] Value=A215102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215102.Bytes);
public long this[int i]=>Value[i];

public static A215102Inst Instance=new A215102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215103
{
public static readonly long[] Value={ 2L,3L,5L,29L,31L,41L,67L,83L,107L,109L,197L,211L,223L,239L,263L,317L,353L,367L,379L,419L,421L,431L,457L,499L,509L,523L,577L,587L,601L,613L,653L,691L,733L,743L,757L,769L,809L,811L,821L,863L,887L,941L,967L,977L,991L,1019L,1069L,1097L,1123L,1201L,1237L,1277L,1279L };
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
public class A215103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215103Inst : IEnumerable<long>
{
public static readonly long[] Value=A215103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215103.Bytes);
public long this[int i]=>Value[i];

public static A215103Inst Instance=new A215103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215104
{
public static readonly long[] Value={ 2L,3L,5L,19L,37L,53L,71L,73L,107L,139L,173L,223L,241L,257L,277L,311L,359L,379L,461L,479L,547L,563L,617L,631L,683L,719L,733L,751L,787L,821L,853L,887L,937L,971L,991L,1039L,1091L,1093L,1193L,1229L,1277L,1297L,1399L,1433L,1447L,1481L,1499L,1549L,1567L,1583L,1601L };
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
public class A215104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215104Inst : IEnumerable<long>
{
public static readonly long[] Value=A215104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215104.Bytes);
public long this[int i]=>Value[i];

public static A215104Inst Instance=new A215104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215105
{
public static readonly long[] Value={ 2L,3L,5L,41L,43L,59L,79L,97L,157L,173L,193L,211L,233L,269L,271L,307L,347L,383L,401L,421L,439L,461L,499L,613L,727L,743L,839L,857L,877L,953L,971L,991L,1009L,1031L,1069L,1123L,1181L,1237L,1259L,1297L,1373L,1409L,1427L,1447L,1487L,1523L,1579L,1601L,1637L,1693L };
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
public class A215105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215105Inst : IEnumerable<long>
{
public static readonly long[] Value=A215105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215105.Bytes);
public long this[int i]=>Value[i];

public static A215105Inst Instance=new A215105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215106
{
public static readonly long[] Value={ 3L,5L,17L,47L,61L,71L,83L,113L,127L,137L,149L,157L,179L,181L,193L,223L,269L,281L,311L,313L,347L,379L,401L,421L,443L,457L,467L,479L,487L,509L,523L,577L,599L,619L,641L,643L,677L,709L,743L,751L,773L,787L,797L,809L,839L,853L,863L,883L,907L,919L,929L,941L,971L };
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
public class A215106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215106Inst : IEnumerable<long>
{
public static readonly long[] Value=A215106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215106.Bytes);
public long this[int i]=>Value[i];

public static A215106Inst Instance=new A215106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215107
{
public static readonly long[] Value={ 3L,5L,7L,6L,9L,11L,8L,11L,14L,17L,9L,14L,17L,21L,24L,11L,16L,20L,24L,29L,33L,12L,18L,22L,27L,32L,38L,42L,14L,20L,25L,30L,36L,42L,48L,53L };
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
public class A215107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215107Inst : IEnumerable<long>
{
public static readonly long[] Value=A215107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215107.Bytes);
public long this[int i]=>Value[i];

public static A215107Inst Instance=new A215107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215108
{
public static readonly long[] Value={ 0L,1L,4L,8L,17L,35L,66L,124L,229L,414L,742L,1318L,2320L,4059L,7062L,12224L,21071L,36185L,61930L,105678L,179847L,305326L,517212L,874380L,1475472L,2485573L,4180648L,7021544L,11777117L,19728911L,33011202L };
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
public class A215108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215108Inst : IEnumerable<long>
{
public static readonly long[] Value=A215108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215108.Bytes);
public long this[int i]=>Value[i];

public static A215108Inst Instance=new A215108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215109
{
public static readonly long[] Value={ 1L,3L,5L,12L,23L,43L,81L,148L,266L,476L,842L,1478L,2581L,4481L,7743L,13328L,22857L,39073L,66605L,113242L,192084L,325128L,549252L,926220L,1559353L,2621295L,4400249L,7376868L,12352043L,20659159L,34516377L };
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
public class A215109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215109Inst : IEnumerable<long>
{
public static readonly long[] Value=A215109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215109.Bytes);
public long this[int i]=>Value[i];

public static A215109Inst Instance=new A215109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215110
{
public static readonly long[] Value={ 3L,4L,7L,8L,22L,19L,44L,35L,35L,103L,55L,96L,185L,128L,109L,130L,344L,167L,265L,484L,230L,359L,285L,250L,498L,889L,571L,1014L,648L,242L,804L,616L,1524L,447L,1757L,795L,849L,1259L,951L,1009L,2468L,713L,2760L,1721L,2978L,728L,787L,2166L,3733L,2316L,1724L,4170L };
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
public class A215110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215110Inst : IEnumerable<long>
{
public static readonly long[] Value=A215110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215110.Bytes);
public long this[int i]=>Value[i];

public static A215110Inst Instance=new A215110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215111
{
public static readonly long[] Value={ 70L,132L,182L,212L,216L,242L,268L,278L,294L,302L,342L,360L,378L,394L,408L,438L,500L,512L,524L,538L,560L,568L,580L,606L,616L,660L,682L,684L,746L,748L,772L,776L,788L,798L,818L,822L,850L,882L,914L,922L,924L,948L,970L,1032L,1034L,1048L,1068L,1084L,1118L,1148L,1168L };
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
public class A215111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215111Inst : IEnumerable<long>
{
public static readonly long[] Value=A215111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215111.Bytes);
public long this[int i]=>Value[i];

public static A215111Inst Instance=new A215111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215112
{
public static readonly long[] Value={ -1L,-1L,1L,-4L,8L,-19L,42L,-95L,213L,-479L,1076L,-2418L,5433L,-12208L,27431L,-61637L,138497L,-311200L,699260L,-1571223L,3530506L,-7932975L,17825233L,-40052935L,89998128L,-202223958L,454393109L,-1021012048L,2294193247L,-5155005433L,11583192065L };
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
public class A215112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215112Inst : IEnumerable<long>
{
public static readonly long[] Value=A215112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215112.Bytes);
public long this[int i]=>Value[i];

public static A215112Inst Instance=new A215112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215113
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,3L,2L,3L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,2L,2L,2L,2L,2L,3L,1L,3L,3L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,3L };
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
public class A215113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215113Inst : IEnumerable<long>
{
public static readonly long[] Value=A215113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215113.Bytes);
public long this[int i]=>Value[i];

public static A215113Inst Instance=new A215113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215114
{
public static readonly BigInteger[] Value={ 1L,3L,9L,81L,891L,11907L,184437L,3199581L,60932007L,1257133527L,27836230041L,656867748537L,16429561047891L,433686821472747L,12038953175046909L,350402975398982133L,10665927632978564895UL,BigInteger.Parse("338769129913521564735"),BigInteger.Parse("11205026468737167058785") };
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
public class A215114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215114Inst Instance=new A215114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215115
{
public static readonly BigInteger[] Value={ 1L,1L,1L,19L,163L,2269L,34093L,584767L,10989271L,224143489L,4910384809L,114714875755L,2841991084747L,74337591206629L,2045557726962949L,59036247882081847L,1782385894711138303L,BigInteger.Parse("56166016733387381449"),BigInteger.Parse("1843556640469175481985"),BigInteger.Parse("62915735570546535121891") };
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
public class A215115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215115Inst Instance=new A215115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215116
{
public static readonly BigInteger[] Value={ 1L,4L,16L,256L,4864L,111616L,2983936L,89743360L,2970861568L,106768629760L,4125849419776L,170207219286016L,7454572671926272L,345078981839552512L,16822127738969128960UL,BigInteger.Parse("860944587541763325952"),BigInteger.Parse("46137178395559050870784"),BigInteger.Parse("2582843669636660403896320"),BigInteger.Parse("150735442996358913332346880") };
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
public class A215116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215116Inst Instance=new A215116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215117
{
public static readonly BigInteger[] Value={ 1L,1L,1L,49L,721L,17281L,452065L,13511953L,443435185L,15816390241L,606861668161L,24867738772849L,1082158542264721L,49785517156216897L,2412544311495241633L,BigInteger.Parse("122762020478952148177"),BigInteger.Parse("6542028190536528941425"),BigInteger.Parse("364254737003651267997985"),BigInteger.Parse("21146448814786605196994305") };
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
public class A215117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215117Inst Instance=new A215117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215118
{
public static readonly BigInteger[] Value={ 1L,5L,25L,625L,18125L,628125L,25390625L,1158515625L,58308203125L,3190470703125L,187941103515625L,11832996337890625L,791834056298828125L,BigInteger.Parse("56063448811767578125"),BigInteger.Parse("4184231129351806640625"),BigInteger.Parse("328154000925299072265625"),BigInteger.Parse("26970505516268341064453125"),BigInteger.Parse("2317475342690856231689453125") };
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
public class A215118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215118Inst Instance=new A215118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215119
{
public static readonly BigInteger[] Value={ 1L,1L,1L,101L,2301L,82601L,3287001L,149411501L,7474902101L,406765054801L,23836604715601L,1493376284080501L,99459838574595501L,7009748111184956601L,BigInteger.Parse("520845172037612209801"),BigInteger.Parse("40672220108202107951101"),BigInteger.Parse("3328819620490715884626501"),BigInteger.Parse("284871268231239093741932001") };
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
public class A215119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215119Inst Instance=new A215119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215120
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,9L,9L,5L,1L,33L,33L,23L,7L,1L,135L,135L,109L,43L,9L,1L,633L,633L,557L,261L,69L,11L,1L,3207L,3207L,2975L,1641L,507L,101L,13L,1L,17589L,17589L,16825L,10503L,3787L,869L,139L,15L,1L,102627L,102627L,100007L,69077L,28205L,7487L,1369L,183L,17L,1L };
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
public class A215120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215120Inst : IEnumerable<long>
{
public static readonly long[] Value=A215120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215120.Bytes);
public long this[int i]=>Value[i];

public static A215120Inst Instance=new A215120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215121
{
public static readonly long[] Value={ 1L,2L,3L,10L,19L,20L,30L };
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
public class A215121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215121Inst : IEnumerable<long>
{
public static readonly long[] Value=A215121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215121.Bytes);
public long this[int i]=>Value[i];

public static A215121Inst Instance=new A215121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215122
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,0L,8L,8L,0L,0L,30L,174L,30L,0L,0L,112L,2084L,2084L,112L,0L,0L,420L,21025L,52808L,21025L,420L,0L,0L,1584L,194064L,994788L,994788L,194064L,1584L,0L,0L,6006L,1694224L,16074586L,31497284L,16074586L,1694224L,6006L,0L };
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
public class A215122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215122Inst : IEnumerable<long>
{
public static readonly long[] Value=A215122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215122.Bytes);
public long this[int i]=>Value[i];

public static A215122Inst Instance=new A215122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215123
{
public static readonly BigInteger[] Value={ 1L,2L,174L,52808L,31497284L,31113230148L,46190668836656L,96484621769643360L,BigInteger.Parse("270280816277448460968"),BigInteger.Parse("979042561410295182717884"),BigInteger.Parse("4456728497956906393963534248"),BigInteger.Parse("24916868994347706845906490576432"),BigInteger.Parse("167903137478620963997932010166057408") };
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
public class A215123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215123Inst Instance=new A215123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215124
{
public static readonly long[] Value={ 0L,0L,0L,8L,174L,2084L,21025L,194064L,1694224L,14232672L,116228871L,928763000L,7294771770L,56497996620L,432520209420L,3278863236544L,24649138276800L,183964353480832L,1364323157872947L,10061883449658936L,73839952091271730L,539488089621673500L };
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
public class A215124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215124Inst : IEnumerable<long>
{
public static readonly long[] Value=A215124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215124.Bytes);
public long this[int i]=>Value[i];

public static A215124Inst Instance=new A215124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215125
{
public static readonly BigInteger[] Value={ 1L,1L,7L,33L,223L,1753L,14391L,137137L,1382383L,14981673L,174494983L,2135204161L,27643067007L,375548195833L,5326762882903L,78889684038993L,1213984929832591L,19377034523034697L,320293617185965863L,5468629894127442913L,BigInteger.Parse("96328047496084810783"),BigInteger.Parse("1747805367475759936281") };
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
public class A215125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215125Inst Instance=new A215125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215126
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,103L,1071L,16261L,310543L,7712433L,234935473L,8704118611L,385999169421L,20105403167983L,1220933294124943L,85391317006742133L,6817483491016756111L,BigInteger.Parse("617003393602674201721"),BigInteger.Parse("62822626252518811177953"),BigInteger.Parse("7153354574514200634711043"),BigInteger.Parse("905989984031687906166904333") };
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
public class A215126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215126Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215126.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215126Inst Instance=new A215126Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215127
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,271L,5073L,149931L,5629933L,287996871L,18574155561L,1472489126563L,143431714523781L,16629096827674623L,2271941249486405761L,BigInteger.Parse("362871752515734614811"),BigInteger.Parse("66782754543872231839773"),BigInteger.Parse("14054632818067589280068791"),BigInteger.Parse("3359850327080126215443462873") };
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
public class A215127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215127Inst Instance=new A215127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215128
{
public static readonly long[] Value={ 1L,2L,12L,64L,370L,2184L,13132L,79944L,491238L,3040400L,18926336L,118369368L,743199184L,4681668488L,29574616440L,187281906512L,1188494457492L,7556371963488L,48123031011036L,306929964849200L,1960230225450420L,12534313062502440L,80236414444623240L };
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
public class A215128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215128Inst : IEnumerable<long>
{
public static readonly long[] Value=A215128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215128.Bytes);
public long this[int i]=>Value[i];

public static A215128Inst Instance=new A215128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215129
{
public static readonly BigInteger[] Value={ 1L,8L,108L,1604L,25000L,400680L,6539932L,108124704L,1804745052L,30345973020L,513246523504L,8722051475280L,148808353519644L,2547317293116512L,43729600850054640L,752553083643333008L,12978731348733064680UL,BigInteger.Parse("224258766666165861192") };
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
public class A215129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A215129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A215129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A215129Inst Instance=new A215129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215130
{
public static readonly long[] Value={ 37182145L,46881835L,50115065L,59814755L,1078282205L,1152646495L,1375739365L,1453336885L,1524467945L,1598832235L,1734627895L,1747560815L,1759302545L,1854257405L,1922155235L,1966279315L,1970653685L,2015918905L,2054717665L,2099812715L,2154947795L,2193746555L };
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
public class A215130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215130Inst : IEnumerable<long>
{
public static readonly long[] Value=A215130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215130.Bytes);
public long this[int i]=>Value[i];

public static A215130Inst Instance=new A215130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215131
{
public static readonly long[] Value={ 3L,5L,19L,29L,31L,71L,83L,97L,107L,109L,149L,211L,227L,239L,263L,317L,331L,367L,383L,409L,419L,421L,461L,487L,499L,523L,577L,601L,617L,643L,653L,733L,757L,773L,809L,811L,863L,877L,887L,929L,941L,967L,991L,1019L,1033L,1069L,1097L,1123L,1163L,1201L,1277L,1279L };
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
public class A215131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215131Inst : IEnumerable<long>
{
public static readonly long[] Value=A215131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215131.Bytes);
public long this[int i]=>Value[i];

public static A215131Inst Instance=new A215131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215132
{
public static readonly long[] Value={ 3L,5L,23L,37L,71L,73L,107L,139L,173L,193L,227L,241L,277L,311L,379L,397L,431L,479L,499L,547L,601L,617L,683L,719L,751L,787L,821L,839L,853L,887L,907L,941L,991L,1009L,1091L,1093L,1193L,1213L,1229L,1297L,1399L,1433L,1451L,1499L,1553L,1567L,1601L,1621L,1637L,1669L };
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
public class A215132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215132Inst : IEnumerable<long>
{
public static readonly long[] Value=A215132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215132.Bytes);
public long this[int i]=>Value[i];

public static A215132Inst Instance=new A215132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215133
{
public static readonly long[] Value={ 3L,5L,41L,43L,79L,101L,139L,157L,193L,233L,269L,271L,307L,347L,367L,383L,421L,443L,461L,499L,557L,613L,709L,727L,823L,839L,877L,937L,953L,991L,1013L,1031L,1051L,1069L,1181L,1259L,1279L,1297L,1373L,1409L,1447L,1487L,1523L,1583L,1601L,1621L,1637L,1697L,1753L };
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
public class A215133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215133Inst : IEnumerable<long>
{
public static readonly long[] Value=A215133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215133.Bytes);
public long this[int i]=>Value[i];

public static A215133Inst Instance=new A215133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215134
{
public static readonly long[] Value={ 2L,3L,13L,23L,47L,67L,79L,89L,101L,113L,157L,167L,179L,199L,211L,223L,233L,277L,311L,331L,353L,397L,409L,419L,421L,431L,443L,463L,487L,509L,541L,563L,607L,617L,619L,641L,661L,673L,683L,727L,739L,751L,761L,773L,827L,839L,859L,881L,883L,937L,947L,971L,991L };
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
public class A215134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215134Inst : IEnumerable<long>
{
public static readonly long[] Value=A215134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215134.Bytes);
public long this[int i]=>Value[i];

public static A215134Inst Instance=new A215134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215135
{
public static readonly long[] Value={ 2L,3L,29L,41L,53L,67L,79L,107L,131L,157L,197L,211L,223L,263L,313L,353L,367L,379L,419L,431L,443L,457L,509L,521L,523L,547L,587L,599L,601L,613L,653L,677L,691L,743L,757L,769L,809L,821L,859L,887L,911L,937L,977L,991L,1069L,1093L,1171L,1223L,1237L,1249L,1277L,1289L };
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
public class A215135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215135Inst : IEnumerable<long>
{
public static readonly long[] Value=A215135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215135.Bytes);
public long this[int i]=>Value[i];

public static A215135Inst Instance=new A215135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215136
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,1L,6L,1L,8L,3L,2L,1L,2L,1L,2L,1L,2L,1L,4892L,47L,4L,1L,10L,5L,2L,1L,2L,1L,44L,7L,2L,1L,2L,1L,4L,1L,2L,9L,12L,11L,2L,1L,2L,1L,2L,3L,4L,1L,4L,367L,4L,5L,2L,1L,2L,1L,12L,1L,12L,4891L,2L,1L,46L,1L,2L,3L,2L,3L,4L,3L,2L,9L,6L,1L,4L,1L,4L,1L,4L,27L };
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
public class A215136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215136Inst : IEnumerable<long>
{
public static readonly long[] Value=A215136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215136.Bytes);
public long this[int i]=>Value[i];

public static A215136Inst Instance=new A215136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215137
{
public static readonly long[] Value={ 1L,18L,35L,52L,69L,86L,103L,120L,137L,154L,171L,188L,205L,222L,239L,256L,273L,290L,307L,324L,341L,358L,375L,392L,409L,426L,443L,460L,477L,494L,511L,528L,545L,562L,579L,596L,613L,630L,647L,664L,681L,698L,715L,732L,749L,766L,783L,800L,817L,834L,851L,868L,885L,902L,919L,936L,953L,970L };
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
public class A215137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215137Inst : IEnumerable<long>
{
public static readonly long[] Value=A215137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215137.Bytes);
public long this[int i]=>Value[i];

public static A215137Inst Instance=new A215137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215138
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
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
public class A215138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215138Inst : IEnumerable<long>
{
public static readonly long[] Value=A215138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215138.Bytes);
public long this[int i]=>Value[i];

public static A215138Inst Instance=new A215138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215139
{
public static readonly long[] Value={ 5L,4L,22L,17L,91L,69L,364L,273L,1428L,1064L,5537L,4109L,21315L,15778L,81683L,60368L,312130L,230447L,1190553L,878423L,4535832L,3345279L,17267992L,12732160L,65708167L,48440175L,249956105L,184247938L,950654341L,700698236L,3615152086L,2664497745L,13746596563L,10131444477L };
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
public class A215139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215139Inst : IEnumerable<long>
{
public static readonly long[] Value=A215139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215139.Bytes);
public long this[int i]=>Value[i];

public static A215139Inst Instance=new A215139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215140
{
public static readonly long[] Value={ 1L,1L,2L,7L,2L,8L,2L,0L,1L,7L,2L,8L,3L,2L,6L,5L,8L,9L,0L,3L,4L,4L,3L,7L,9L,7L,2L,3L,2L,7L,2L,5L,0L,6L,1L,3L,5L,6L,6L,1L,4L,1L,2L,3L,0L,9L,9L,8L,4L,9L,3L,1L,2L,2L,4L,5L,4L,0L,9L,6L,5L,5L,6L,2L,7L,3L,8L,6L,4L,3L,1L,9L,5L,1L,8L,1L,5L,2L,5L,9L,6L,7L,0L,6L,3L,4L,9L };
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
public class A215140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215140Inst : IEnumerable<long>
{
public static readonly long[] Value=A215140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215140.Bytes);
public long this[int i]=>Value[i];

public static A215140Inst Instance=new A215140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215141
{
public static readonly long[] Value={ 9L,0L,4L,2L,2L,6L,1L,3L,8L,2L,2L,8L,4L,3L,4L,5L,2L,1L,1L,4L,6L,2L,7L,4L,9L,6L,5L,6L,2L,5L,6L,5L,6L,2L,7L,3L,2L,8L,7L,5L,1L,8L,2L,8L,3L,4L,9L,0L,3L,8L,1L,7L,6L,7L,3L,5L,9L,9L,7L,9L,1L,0L,9L,8L,7L,5L,8L,3L,2L,8L,2L,4L,3L,4L,7L,8L,8L,1L,4L,3L,0L,3L,6L,0L,5L,6L,8L };
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
public class A215141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215141Inst : IEnumerable<long>
{
public static readonly long[] Value=A215141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215141.Bytes);
public long this[int i]=>Value[i];

public static A215141Inst Instance=new A215141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215142
{
public static readonly long[] Value={ 6L,12L,18L,24L,36L,48L,54L,72L,96L,108L,144L,162L,192L,216L,231L,288L,324L,330L,384L,432L,455L,486L,546L,576L,648L,660L,663L,693L,768L,864L,935L,972L,990L,1092L,1122L,1152L,1235L,1296L,1311L,1320L,1458L,1463L,1482L,1536L,1617L,1638L,1650L,1728L,1944L,1955L };
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
public class A215142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215142Inst : IEnumerable<long>
{
public static readonly long[] Value=A215142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215142.Bytes);
public long this[int i]=>Value[i];

public static A215142Inst Instance=new A215142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215143
{
public static readonly long[] Value={ 1L,2L,7L,28L,112L,441L,1715L,6615L,25382L,97069L,370440L,1411788L,5375839L,20458921L,77833217L,296038498L,1125816895L,4281011812L,16277915640L,61891962377L,235320000363L,894697938743L,3401649302758L,12933013979445L,49170893188704L,186945601728004L,710757805310287L };
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
public class A215143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215143Inst : IEnumerable<long>
{
public static readonly long[] Value=A215143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215143.Bytes);
public long this[int i]=>Value[i];

public static A215143Inst Instance=new A215143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215144
{
public static readonly long[] Value={ 1L,20L,39L,58L,77L,96L,115L,134L,153L,172L,191L,210L,229L,248L,267L,286L,305L,324L,343L,362L,381L,400L,419L,438L,457L,476L,495L,514L,533L,552L,571L,590L,609L,628L,647L,666L,685L,704L,723L,742L,761L,780L,799L,818L,837L,856L,875L,894L,913L,932L,951L,970L,989L };
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
public class A215144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215144Inst : IEnumerable<long>
{
public static readonly long[] Value=A215144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215144.Bytes);
public long this[int i]=>Value[i];

public static A215144Inst Instance=new A215144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215145
{
public static readonly long[] Value={ 1L,21L,41L,61L,81L,101L,121L,141L,161L,181L,201L,221L,241L,261L,281L,301L,321L,341L,361L,381L,401L,421L,441L,461L,481L,501L,521L,541L,561L,581L,601L,621L,641L,661L,681L,701L,721L,741L,761L,781L,801L,821L,841L,861L,881L,901L,921L,941L,961L,981L };
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
public class A215145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215145Inst : IEnumerable<long>
{
public static readonly long[] Value=A215145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215145.Bytes);
public long this[int i]=>Value[i];

public static A215145Inst Instance=new A215145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215146
{
public static readonly long[] Value={ 1L,22L,43L,64L,85L,106L,127L,148L,169L,190L,211L,232L,253L,274L,295L,316L,337L,358L,379L,400L,421L,442L,463L,484L,505L,526L,547L,568L,589L,610L,631L,652L,673L,694L,715L,736L,757L,778L,799L,820L,841L,862L,883L,904L,925L,946L,967L,988L };
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
public class A215146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215146Inst : IEnumerable<long>
{
public static readonly long[] Value=A215146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215146.Bytes);
public long this[int i]=>Value[i];

public static A215146Inst Instance=new A215146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215147
{
public static readonly long[] Value={ 1L,2L,5L,6L,14L,15L,30L,31L,55L,56L,91L,92L,140L,141L,204L,205L,285L,286L,385L,386L,506L,507L,650L,651L,819L,820L,1015L,1016L,1240L,1241L,1496L };
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
public class A215147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215147Inst : IEnumerable<long>
{
public static readonly long[] Value=A215147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215147.Bytes);
public long this[int i]=>Value[i];

public static A215147Inst Instance=new A215147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215148
{
public static readonly long[] Value={ 1L,24L,47L,70L,93L,116L,139L,162L,185L,208L,231L,254L,277L,300L,323L,346L,369L,392L,415L,438L,461L,484L,507L,530L,553L,576L,599L,622L,645L,668L,691L,714L,737L,760L,783L,806L,829L,852L,875L,898L,921L,944L,967L,990L };
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
public class A215148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215148Inst : IEnumerable<long>
{
public static readonly long[] Value=A215148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215148.Bytes);
public long this[int i]=>Value[i];

public static A215148Inst Instance=new A215148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215149
{
public static readonly long[] Value={ 0L,2L,6L,15L,36L,85L,198L,455L,1032L,2313L,5130L,11275L,24588L,53261L,114702L,245775L,524304L,1114129L,2359314L,4980755L,10485780L,22020117L,46137366L,96469015L,201326616L,419430425L,872415258L,1811939355L,3758096412L };
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
public class A215149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215149Inst : IEnumerable<long>
{
public static readonly long[] Value=A215149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215149.Bytes);
public long this[int i]=>Value[i];

public static A215149Inst Instance=new A215149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215150
{
public static readonly long[] Value={ 13981L,18705L,23001L,55245L,63973L,72885L,75361L,107185L,126217L,129921L,137149L,157641L,158369L,172081L,176149L,188461L,215265L,266305L,272251L,276013L,278545L,285541L,294409L,348161L,387731L,423793L,464185L,488881L,493697L,617093L,625921L,743665L,748657L,825265L };
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
public class A215150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215150Inst : IEnumerable<long>
{
public static readonly long[] Value=A215150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215150.Bytes);
public long this[int i]=>Value[i];

public static A215150Inst Instance=new A215150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215151
{
public static readonly long[] Value={ 1L,2L,3L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,0L,0L,1L,2L,3L,4L,0L,1L,2L,3L,0L,1L,0L,1L,2L,0L,1L,2L,3L,4L,5L,0L,1L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,6L,7L,0L,0L,1L,0L,1L,2L,0L,1L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,1L };
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
public class A215151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215151Inst : IEnumerable<long>
{
public static readonly long[] Value=A215151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215151.Bytes);
public long this[int i]=>Value[i];

public static A215151Inst Instance=new A215151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215152
{
public static readonly long[] Value={ 0L,0L,0L,21L,445L,5457L,55576L };
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
public class A215152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215152Inst : IEnumerable<long>
{
public static readonly long[] Value=A215152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215152.Bytes);
public long this[int i]=>Value[i];

public static A215152Inst Instance=new A215152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215153
{
public static readonly long[] Value={ 2L,3L,19L,37L,53L,71L,103L,137L,139L,173L,223L,239L,241L,257L,307L,359L,409L,443L,461L,479L,547L,563L,613L,631L,647L,683L,733L,751L,853L,887L,919L,937L,953L,971L,1021L,1039L,1091L,1123L,1193L,1259L,1277L,1327L,1361L,1429L,1447L,1481L,1499L };
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
public class A215153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215153Inst : IEnumerable<long>
{
public static readonly long[] Value=A215153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215153.Bytes);
public long this[int i]=>Value[i];

public static A215153Inst Instance=new A215153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215154
{
public static readonly long[] Value={ 2L,3L,41L,59L,79L,97L,173L,191L,193L,211L,229L,269L,307L,383L,401L,419L,421L,439L,457L,571L,647L,743L,761L,839L,857L,877L,953L,971L,991L,1009L,1103L,1123L,1181L,1217L,1237L,1409L,1427L,1447L,1483L,1523L,1559L,1579L,1597L,1637L,1693L,1787L,1789L,1901L,1979L };
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
public class A215154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215154Inst : IEnumerable<long>
{
public static readonly long[] Value=A215154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215154.Bytes);
public long this[int i]=>Value[i];

public static A215154Inst Instance=new A215154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215155
{
public static readonly long[] Value={ 2L,3L,5L,7L,29L,31L,41L,59L,67L,83L,107L,109L,137L,163L,197L,211L,223L,239L,241L,263L,293L,317L,353L,367L,379L,397L,419L,421L,431L,449L,457L,499L,509L,523L,577L,587L,601L,613L,631L,653L,683L,691L,709L,733L,743L,757L,761L,769L,787L,809L,811L,821L,839L,863L };
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
public class A215155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215155Inst : IEnumerable<long>
{
public static readonly long[] Value=A215155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215155.Bytes);
public long this[int i]=>Value[i];

public static A215155Inst Instance=new A215155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A215156
{
public static readonly long[] Value={ 2L,3L,5L,7L,19L,37L,41L,53L,71L,73L,107L,109L,139L,173L,211L,223L,241L,257L,277L,311L,313L,347L,359L,379L,449L,461L,479L,547L,563L,617L,619L,631L,653L,683L,719L,733L,751L,787L,821L,823L,853L,857L,887L,937L,971L,991L,1039L,1061L,1091L,1093L,1129L,1163L,1193L };
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
public class A215156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A215156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A215156Inst : IEnumerable<long>
{
public static readonly long[] Value=A215156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A215156.Bytes);
public long this[int i]=>Value[i];

public static A215156Inst Instance=new A215156Inst();

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