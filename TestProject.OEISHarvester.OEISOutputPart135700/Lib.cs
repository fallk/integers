using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A165005
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,4L,3L,3L,2L,2L,5L,3L,3L,2L,2L,6L,5L,3L,3L,2L,3L,2L,4L,2L,6L,5L,3L,3L,2L,5L,3L,2L,4L,4L,4L,2L,6L,5L,3L,3L,2L,3L,3L,2L,9L,4L,4L,4L,2L,6L,5L,3L,3L,2L,2L,3L,3L,2L,6L,3L,9L,4L,4L,4L,2L,6L,5L,3L,3L,2L,5L,2L,3L,3L,2L,11L,6L,3L,9L,4L,4L,4L,2L,6L,5L,3L,3L,2L,5L,2L,3L,3L,2L,10L,2L,11L,6L,3L,9L,4L,4L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165005Inst : IEnumerable<long>
{
public static readonly long[] Value=A165005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165005.Bytes);
public long this[int i]=>Value[i];

public static A165005Inst Instance=new A165005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165006
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,1L,3L,2L,5L,2L,6L,3L,7L,4L,10L,5L,12L,6L,13L,7L,16L,8L,17L,9L,19L,10L,22L,11L,23L,14L,26L,15L,30L,16L,33L,18L,34L,19L,37L,20L,39L,23L,42L,24L,47L,25L,48L,26L,50L,28L,55L,29L,56L,32L,59L,33L,63L,34L,64L,37L,65L,40L,72L,41L,78L,44L,79L,46L,82L,49L,83L,51L,87L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165006Inst : IEnumerable<long>
{
public static readonly long[] Value=A165006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165006.Bytes);
public long this[int i]=>Value[i];

public static A165006Inst Instance=new A165006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165007
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,3L,3L,1L,6L,5L,10L,3L,15L,4L,21L,7L,28L,12L,36L,11L,45L,13L,55L,18L,66L,19L,78L,25L,91L,28L,105L,35L,120L,41L,136L,43L,153L,47L,171L,56L,190L,58L,210L,68L,231L,73L,253L,84L,276L,85L,300L,97L,325L,103L,351L,116L,378L,119L,406L,133L,435L,140L,465L,155L,496L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165007Inst : IEnumerable<long>
{
public static readonly long[] Value=A165007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165007.Bytes);
public long this[int i]=>Value[i];

public static A165007Inst Instance=new A165007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165008
{
public static readonly BigInteger[] Value={ 0L,32L,320L,26240L,1240024L,11160256L,BigInteger.Parse("2297798771761759543384"),BigInteger.Parse("15075857741528904364175224"),8135830264L,5931020266096L,659002251784L,350220815692997944L };
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
public class A165008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165008.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165008Inst Instance=new A165008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165009
{
public static readonly long[] Value={ 0L,28L,82L,244L,730L,737L,2188L,6562L,6569L,6587L,19684L,19691L,59050L,59057L,59062L,59075L,59129L,177148L,177173L,531442L,531449L,531467L,531485L,531521L,531683L,1594324L,1594331L,1594403L,4782970L,4782977L,4782995L,4783049L,4783103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165009Inst : IEnumerable<long>
{
public static readonly long[] Value=A165009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165009.Bytes);
public long this[int i]=>Value[i];

public static A165009Inst Instance=new A165009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165010
{
public static readonly long[] Value={ 0L,32L,184L,320L,1696L,2008L,5332L,15304L,18208L,19144L,26240L,55360L,137776L,164008L,146488L,172720L,175528L,433012L,520372L,1240024L,1476208L,1554904L,1502344L,1581040L,1589464L,3975844L,4487680L,4749760L,11160256L,13286008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165010Inst : IEnumerable<long>
{
public static readonly long[] Value=A165010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165010.Bytes);
public long this[int i]=>Value[i];

public static A165010Inst Instance=new A165010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165011
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,1L,3L,2L,1L,4L,1L,3L,3L,1L,2L,1L,2L,1L,5L,3L,3L,1L,2L,1L,1L,2L,1L,6L,5L,3L,3L,1L,2L,1L,3L,1L,2L,1L,4L,6L,2L,5L,3L,1L,3L,1L,2L,1L,5L,3L,1L,2L,1L,4L,4L,4L,6L,2L,5L,3L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,9L,4L,4L,4L,6L,2L,5L,3L,1L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,1L,6L,9L,3L,4L,4L,4L,6L,2L,5L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165011Inst : IEnumerable<long>
{
public static readonly long[] Value=A165011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165011.Bytes);
public long this[int i]=>Value[i];

public static A165011Inst Instance=new A165011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165012
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,3L,6L,6L,3L,0L,3L,9L,6L,3L,0L,15L,15L,30L,45L,15L,0L,15L,30L,30L,15L,15L,30L,45L,30L,30L,30L,30L,30L,30L,45L,30L,15L,15L,30L,30L,15L,0L,15L,45L,30L,15L,15L,45L,45L,45L,45L,45L,30L,30L,30L,45L,30L,15L,15L,45L,30L,15L,0L,63L,75L,138L,201L,75L,63L,126L,189L,138L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165012Inst : IEnumerable<long>
{
public static readonly long[] Value=A165012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165012.Bytes);
public long this[int i]=>Value[i];

public static A165012Inst Instance=new A165012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165013
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,2L,2L,1L,0L,1L,3L,2L,1L,0L,5L,5L,10L,15L,5L,0L,5L,10L,10L,5L,5L,10L,15L,10L,10L,10L,10L,10L,10L,15L,10L,5L,5L,10L,10L,5L,0L,5L,15L,10L,5L,5L,15L,15L,15L,15L,15L,10L,10L,10L,15L,10L,5L,5L,15L,10L,5L,0L,21L,25L,46L,67L,25L,21L,42L,63L,46L,42L,46L,67L,67L,63L,67L,71L,25L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165013Inst : IEnumerable<long>
{
public static readonly long[] Value=A165013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165013.Bytes);
public long this[int i]=>Value[i];

public static A165013Inst Instance=new A165013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165014
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,3L,3L,2L,1L,2L,3L,3L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165014Inst : IEnumerable<long>
{
public static readonly long[] Value=A165014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165014.Bytes);
public long this[int i]=>Value[i];

public static A165014Inst Instance=new A165014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165015
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,3L,4L,4L,3L,2L,3L,4L,4L,3L,2L,3L,3L,2L,3L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,1L,2L,2L,2L,2L,3L,2L,3L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,3L,4L,3L,3L,3L,2L,2L,4L,2L,4L,3L,3L,3L,4L,3L,2L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,2L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165015Inst : IEnumerable<long>
{
public static readonly long[] Value=A165015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165015.Bytes);
public long this[int i]=>Value[i];

public static A165015Inst Instance=new A165015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165016
{
public static readonly long[] Value={ 0L,30L,201L,2550L,3369L,3873L,14565L,54441L,62625L,64641L,171990L,234405L,254865L,873129L,954261L,1004193L,1036929L,1044993L,3755685L,4083345L,4165185L,11140950L,13978281L,15285909L,16075425L,16399953L,16599681L,16730625L,16762881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165016Inst : IEnumerable<long>
{
public static readonly long[] Value=A165016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165016.Bytes);
public long this[int i]=>Value[i];

public static A165016Inst Instance=new A165016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165017
{
public static readonly long[] Value={ 0L,30L,126L,138L,201L,570L,765L,2550L,3369L,3873L,14565L,41958L,42966L,54441L,57333L,62625L,64641L,171990L,234405L,254865L,873129L,954261L,1004193L,1036929L,1044993L,2788950L,3489705L,3755685L,3833685L,4083345L,4165185L,11140950L,13978281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165017Inst : IEnumerable<long>
{
public static readonly long[] Value=A165017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165017.Bytes);
public long this[int i]=>Value[i];

public static A165017Inst Instance=new A165017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165018
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,1L,3L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165018Inst : IEnumerable<long>
{
public static readonly long[] Value=A165018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165018.Bytes);
public long this[int i]=>Value[i];

public static A165018Inst Instance=new A165018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165019
{
public static readonly long[] Value={ 126L,138L,570L,765L,41958L,42966L,57333L,2788950L,3489705L,3833685L,178846038L,240385701L,245890389L,11451491670L,15657335445L,15745414485L,732979762518L,1006431627861L,1007840908629L,46912048616790L,64481417734485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165019Inst : IEnumerable<long>
{
public static readonly long[] Value=A165019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165019.Bytes);
public long this[int i]=>Value[i];

public static A165019Inst Instance=new A165019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165020
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165020Inst : IEnumerable<long>
{
public static readonly long[] Value=A165020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165020.Bytes);
public long this[int i]=>Value[i];

public static A165020Inst Instance=new A165020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165021
{
public static readonly long[] Value={ 0L,30L,126L,201L,570L,2550L,3369L,3873L,14565L,41958L,54441L,62625L,64641L,171990L,234405L,254865L,873129L,954261L,1004193L,1036929L,1044993L,2788950L,3755685L,4083345L,4165185L,11140950L,13978281L,15285909L,16075425L,16399953L,16599681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165021Inst : IEnumerable<long>
{
public static readonly long[] Value=A165021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165021.Bytes);
public long this[int i]=>Value[i];

public static A165021Inst Instance=new A165021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165022
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165022Inst : IEnumerable<long>
{
public static readonly long[] Value=A165022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165022.Bytes);
public long this[int i]=>Value[i];

public static A165022Inst Instance=new A165022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165023
{
public static readonly BigInteger[] Value={ 126L,570L,41958L,2788950L,178846038L,11451491670L,732979762518L,46912048616790L,3002392592864598L,192153469566932310L,12297827549946664278UL,BigInteger.Parse("787061051157936166230"),BigInteger.Parse("50371908681484475913558") };
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
public class A165023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165023Inst Instance=new A165023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165024
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165024Inst : IEnumerable<long>
{
public static readonly long[] Value=A165024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165024.Bytes);
public long this[int i]=>Value[i];

public static A165024Inst Instance=new A165024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165025
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,3L,1L,4L,3L,5L,4L,8L,5L,10L,8L,12L,10L,16L,12L,19L,16L,22L,19L,27L,22L,31L,27L,35L,31L,41L,35L,46L,41L,51L,46L,58L,51L,64L,58L,70L,64L,78L,70L,85L,78L,92L,85L,101L,92L,109L,101L,117L,109L,127L,117L,136L,127L,145L,136L,156L,145L,166L,156L,176L,166L,188L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165025Inst : IEnumerable<long>
{
public static readonly long[] Value=A165025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165025.Bytes);
public long this[int i]=>Value[i];

public static A165025Inst Instance=new A165025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165026
{
public static readonly long[] Value={ 1L,0L,1L,3L,2L,3L,1L,6L,3L,5L,6L,8L,5L,12L,8L,12L,12L,16L,12L,21L,16L,22L,21L,27L,22L,33L,27L,35L,33L,41L,35L,48L,41L,51L,48L,58L,51L,66L,58L,70L,66L,78L,70L,87L,78L,92L,87L,101L,92L,111L,101L,117L,111L,127L,117L,138L,127L,145L,138L,156L,145L,168L,156L,176L,168L,188L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165026Inst : IEnumerable<long>
{
public static readonly long[] Value=A165026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165026.Bytes);
public long this[int i]=>Value[i];

public static A165026Inst Instance=new A165026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165027
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,3L,1L,3L,3L,5L,3L,8L,5L,9L,8L,12L,9L,16L,12L,18L,16L,22L,18L,27L,22L,30L,27L,35L,30L,41L,35L,45L,41L,51L,45L,58L,51L,63L,58L,70L,63L,78L,70L,84L,78L,92L,84L,101L,92L,108L,101L,117L,108L,127L,117L,135L,127L,145L,135L,156L,145L,165L,156L,176L,165L,188L,176L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165027Inst : IEnumerable<long>
{
public static readonly long[] Value=A165027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165027.Bytes);
public long this[int i]=>Value[i];

public static A165027Inst Instance=new A165027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165028
{
public static readonly long[] Value={ 0L,126L,41958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165028Inst : IEnumerable<long>
{
public static readonly long[] Value=A165028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165028.Bytes);
public long this[int i]=>Value[i];

public static A165028Inst Instance=new A165028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165029
{
public static readonly long[] Value={ 0L,18L,65L,66L,257L,1025L,1039L,1050L,4097L,16385L,16386L,16399L,16447L,65537L,65551L,65898L,262145L,262146L,262207L,262239L,262399L,1048577L,1048578L,1048591L,1048639L,4194305L,4194310L,4194319L,4194399L,4194559L,4194687L,4195327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165029Inst : IEnumerable<long>
{
public static readonly long[] Value=A165029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165029.Bytes);
public long this[int i]=>Value[i];

public static A165029Inst Instance=new A165029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165030
{
public static readonly long[] Value={ 0L,30L,201L,126L,570L,3369L,3873L,2550L,14565L,41958L,54441L,62625L,64641L,234405L,254865L,171990L,873129L,954261L,1036929L,1004193L,1044993L,3755685L,2788950L,4083345L,4165185L,15285909L,13978281L,16075425L,16399953L,16730625L,16599681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165030Inst : IEnumerable<long>
{
public static readonly long[] Value=A165030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165030.Bytes);
public long this[int i]=>Value[i];

public static A165030Inst Instance=new A165030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165031
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165031Inst : IEnumerable<long>
{
public static readonly long[] Value=A165031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165031.Bytes);
public long this[int i]=>Value[i];

public static A165031Inst Instance=new A165031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165032
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,0L,4L,8L,12L,8L,4L,0L,4L,8L,12L,8L,4L,0L,4L,16L,12L,8L,4L,0L,24L,24L,48L,72L,96L,24L,0L,24L,48L,72L,48L,24L,24L,48L,72L,72L,48L,48L,48L,72L,96L,72L,72L,72L,72L,48L,48L,48L,72L,96L,48L,24L,24L,48L,72L,48L,24L,0L,24L,48L,72L,48L,24L,24L,48L,96L,72L,48L,48L,48L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165032Inst : IEnumerable<long>
{
public static readonly long[] Value=A165032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165032.Bytes);
public long this[int i]=>Value[i];

public static A165032Inst Instance=new A165032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165033
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,4L,3L,2L,1L,0L,6L,6L,12L,18L,24L,6L,0L,6L,12L,18L,12L,6L,6L,12L,18L,18L,12L,12L,12L,18L,24L,18L,18L,18L,18L,12L,12L,12L,18L,24L,12L,6L,6L,12L,18L,12L,6L,0L,6L,12L,18L,12L,6L,6L,12L,24L,18L,12L,12L,12L,18L,18L,18L,18L,24L,18L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165033Inst : IEnumerable<long>
{
public static readonly long[] Value=A165033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165033.Bytes);
public long this[int i]=>Value[i];

public static A165033Inst Instance=new A165033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165034
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,0L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165034Inst : IEnumerable<long>
{
public static readonly long[] Value=A165034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165034.Bytes);
public long this[int i]=>Value[i];

public static A165034Inst Instance=new A165034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165035
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,2L,3L,1L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,4L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,2L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,4L,3L,2L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,4L,3L,3L,3L,3L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165035Inst : IEnumerable<long>
{
public static readonly long[] Value=A165035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165035.Bytes);
public long this[int i]=>Value[i];

public static A165035Inst Instance=new A165035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165036
{
public static readonly long[] Value={ 0L,8L,392L,1831056L,48217776L,1217651376L,30502319376L,144640604656L,762863159376L,3774960835776L,19073104859376L,95168749491376L,476835250859376L,2383192380269376L,11320075681132656L,11920919418359376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165036Inst : IEnumerable<long>
{
public static readonly long[] Value=A165036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165036.Bytes);
public long this[int i]=>Value[i];

public static A165036Inst Instance=new A165036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165037
{
public static readonly long[] Value={ 0L,8L,48L,72L,392L,1992L,2232L,2616L,2856L,7488L,9992L,10712L,11432L,13736L,53712L,57432L,66216L,73056L,249992L,272312L,284832L,287432L,347336L,349936L,1831056L,6249992L,8687336L,8785936L,9236656L,45781056L,45874056L,46264656L,48217776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165037Inst : IEnumerable<long>
{
public static readonly long[] Value=A165037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165037.Bytes);
public long this[int i]=>Value[i];

public static A165037Inst Instance=new A165037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165038
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,4L,4L,4L,5L,5L,5L,5L,5L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,1L,4L,4L,4L,4L,3L,3L,3L,1L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,5L,5L,5L,3L,3L,3L,1L,5L,5L,4L,5L,5L,4L,4L,5L,4L,4L,4L,6L,2L,6L,6L,4L,4L,6L,6L,2L,6L,5L,5L,5L,5L,5L,3L,3L,3L,1L,5L,4L,4L,5L,5L,5L,5L,4L,4L,1L,4L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,4L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165038Inst : IEnumerable<long>
{
public static readonly long[] Value=A165038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165038.Bytes);
public long this[int i]=>Value[i];

public static A165038Inst Instance=new A165038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165039
{
public static readonly long[] Value={ 48L,72L,1992L,2232L,2616L,2856L,7488L,9992L,10712L,11432L,13736L,53712L,57432L,66216L,73056L,249992L,272312L,284832L,287432L,347336L,349936L,6249992L,8687336L,8785936L,9236656L,45781056L,45874056L,46264656L,170312312L,178124832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165039Inst : IEnumerable<long>
{
public static readonly long[] Value=A165039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165039.Bytes);
public long this[int i]=>Value[i];

public static A165039Inst Instance=new A165039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165040
{
public static readonly long[] Value={ 2L,2L,4L,4L,4L,4L,5L,5L,5L,5L,5L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,4L,4L,4L,4L,3L,3L,3L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,5L,5L,5L,3L,3L,3L,5L,5L,4L,5L,5L,4L,4L,5L,4L,4L,4L,6L,2L,6L,6L,4L,4L,6L,6L,2L,6L,5L,5L,5L,5L,5L,3L,3L,3L,5L,4L,4L,5L,5L,5L,5L,4L,4L,4L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,4L,6L,2L,6L,6L,6L,6L,2L,6L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165040Inst : IEnumerable<long>
{
public static readonly long[] Value=A165040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165040.Bytes);
public long this[int i]=>Value[i];

public static A165040Inst Instance=new A165040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165041
{
public static readonly long[] Value={ 0L,8L,48L,392L,1992L,7488L,53712L,249992L,1831056L,6249992L,45781056L,48217776L,170312312L,1144531056L,1205467776L,1217651376L,4514058432L,4576557032L,22460937432L,28613281056L,28671874056L,30136717776L,30441401376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165041Inst : IEnumerable<long>
{
public static readonly long[] Value=A165041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165041.Bytes);
public long this[int i]=>Value[i];

public static A165041Inst Instance=new A165041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165042
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,4L,6L,1L,4L,3L,1L,8L,5L,3L,1L,5L,4L,4L,6L,2L,5L,3L,1L,5L,4L,1L,4L,2L,2L,4L,6L,2L,5L,3L,1L,5L,1L,3L,4L,4L,4L,4L,4L,2L,2L,4L,6L,2L,5L,3L,1L,3L,1L,9L,9L,3L,4L,4L,4L,4L,4L,2L,2L,4L,6L,2L,5L,3L,1L,5L,5L,3L,1L,6L,6L,2L,6L,3L,3L,1L,9L,9L,3L,4L,4L,4L,4L,4L,2L,2L,4L,6L,2L,5L,3L,1L,11L,5L,3L,1L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165042Inst : IEnumerable<long>
{
public static readonly long[] Value=A165042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165042.Bytes);
public long this[int i]=>Value[i];

public static A165042Inst Instance=new A165042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165043
{
public static readonly long[] Value={ 48L,1992L,7488L,53712L,249992L,6249992L,45781056L,170312312L,1144531056L,1205467776L,4514058432L,4576557032L,22460937432L,28613281056L,28671874056L,30136717776L,30441401376L,106445312312L,112304687432L,715332031056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165043Inst : IEnumerable<long>
{
public static readonly long[] Value=A165043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165043.Bytes);
public long this[int i]=>Value[i];

public static A165043Inst Instance=new A165043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165044
{
public static readonly long[] Value={ 2L,4L,5L,4L,6L,4L,3L,8L,5L,3L,5L,4L,4L,6L,2L,5L,3L,5L,4L,4L,2L,2L,4L,6L,2L,5L,3L,5L,3L,4L,4L,4L,4L,4L,2L,2L,4L,6L,2L,5L,3L,3L,9L,9L,3L,4L,4L,4L,4L,4L,2L,2L,4L,6L,2L,5L,3L,5L,5L,3L,6L,6L,2L,6L,3L,3L,9L,9L,3L,4L,4L,4L,4L,4L,2L,2L,4L,6L,2L,5L,3L,11L,5L,3L,11L,11L,11L,6L,6L,2L,6L,3L,3L,9L,9L,3L,4L,4L,4L,4L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165044Inst : IEnumerable<long>
{
public static readonly long[] Value=A165044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165044.Bytes);
public long this[int i]=>Value[i];

public static A165044Inst Instance=new A165044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165045
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,2L,6L,3L,9L,2L,14L,2L,16L,4L,23L,4L,26L,4L,30L,5L,36L,7L,40L,11L,54L,11L,68L,14L,77L,16L,83L,18L,95L,19L,107L,25L,126L,27L,144L,29L,150L,30L,160L,33L,188L,35L,196L,41L,209L,42L,238L,46L,247L,50L,257L,63L,313L,64L,367L,78L,378L,82L,397L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165045Inst : IEnumerable<long>
{
public static readonly long[] Value=A165045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165045.Bytes);
public long this[int i]=>Value[i];

public static A165045Inst Instance=new A165045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165046
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,4L,6L,1L,4L,4L,8L,9L,9L,21L,10L,29L,6L,48L,4L,66L,14L,93L,20L,126L,19L,166L,17L,214L,27L,270L,34L,339L,36L,410L,46L,495L,55L,591L,70L,699L,82L,819L,97L,952L,107L,1103L,135L,1260L,142L,1436L,175L,1628L,183L,1836L,231L,2061L,232L,2304L,288L,2565L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165046Inst : IEnumerable<long>
{
public static readonly long[] Value=A165046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165046.Bytes);
public long this[int i]=>Value[i];

public static A165046Inst Instance=new A165046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165047
{
public static readonly BigInteger[] Value={ 0L,48L,45781056L,1992L,7488L,249992L,BigInteger.Parse("26648194761946797370910644531056"),170312312L,447082519531056L,953674316406249992L,43487548828124832L,BigInteger.Parse("68219378590583801269531056") };
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
public class A165047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165047Inst Instance=new A165047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165048
{
public static readonly long[] Value={ 0L,8L,27L,126L,626L,3126L,15626L,78126L,390626L,1953126L,9765626L,9765824L,48828126L,244140626L,244140699L,244141624L,1220703126L,1220703127L,6103515626L,6103515639L,6103515656L,6103515699L,6103515999L,6103520624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165048Inst : IEnumerable<long>
{
public static readonly long[] Value=A165048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165048.Bytes);
public long this[int i]=>Value[i];

public static A165048Inst Instance=new A165048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165049
{
public static readonly long[] Value={ 0L,8L,48L,392L,1992L,7488L,53712L,249992L,1831056L,6249992L,45781056L,48217776L,170312312L,1144531056L,1205467776L,1217651376L,4576557032L,4514058432L,28613281056L,28671874056L,22460937432L,30136717776L,30441401376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165049Inst : IEnumerable<long>
{
public static readonly long[] Value=A165049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165049.Bytes);
public long this[int i]=>Value[i];

public static A165049Inst Instance=new A165049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165050
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,4L,6L,1L,4L,3L,1L,8L,5L,3L,1L,4L,5L,6L,2L,4L,5L,3L,1L,4L,1L,5L,4L,4L,2L,2L,2L,6L,5L,3L,1L,5L,1L,4L,4L,4L,4L,3L,2L,4L,4L,2L,6L,5L,2L,3L,1L,3L,1L,9L,3L,9L,4L,4L,4L,2L,4L,4L,4L,2L,6L,5L,2L,3L,1L,5L,5L,3L,1L,6L,3L,2L,6L,6L,3L,9L,1L,9L,4L,4L,3L,4L,2L,4L,4L,4L,2L,6L,5L,2L,3L,1L,11L,5L,3L,1L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165050Inst : IEnumerable<long>
{
public static readonly long[] Value=A165050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165050.Bytes);
public long this[int i]=>Value[i];

public static A165050Inst Instance=new A165050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165051
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,5L,0L,5L,10L,15L,20L,10L,5L,0L,5L,10L,15L,15L,10L,5L,0L,5L,10L,20L,15L,10L,5L,0L,5L,25L,20L,15L,10L,5L,0L,35L,35L,70L,105L,140L,175L,35L,0L,35L,70L,105L,140L,70L,35L,35L,70L,105L,140L,105L,70L,70L,70L,105L,140L,140L,105L,105L,105L,105L,140L,175L,140L,140L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165051Inst : IEnumerable<long>
{
public static readonly long[] Value=A165051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165051.Bytes);
public long this[int i]=>Value[i];

public static A165051Inst Instance=new A165051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165052
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,3L,4L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,1L,2L,4L,3L,2L,1L,0L,1L,5L,4L,3L,2L,1L,0L,7L,7L,14L,21L,28L,35L,7L,0L,7L,14L,21L,28L,14L,7L,7L,14L,21L,28L,21L,14L,14L,14L,21L,28L,28L,21L,21L,21L,21L,28L,35L,28L,28L,28L,28L,28L,14L,14L,14L,21L,28L,35L,14L,7L,7L,14L,21L,28L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165052Inst : IEnumerable<long>
{
public static readonly long[] Value=A165052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165052.Bytes);
public long this[int i]=>Value[i];

public static A165052Inst Instance=new A165052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165053
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,2L,3L,1L,2L,3L,2L,1L,2L,3L,1L,2L,3L,2L,2L,3L,1L,2L,1L,3L,3L,3L,1L,2L,2L,1L,1L,1L,1L,2L,3L,2L,2L,2L,2L,2L,3L,3L,3L,1L,2L,3L,3L,2L,2L,3L,1L,2L,3L,2L,1L,2L,3L,1L,1L,3L,2L,2L,3L,1L,2L,1L,3L,3L,3L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165053Inst : IEnumerable<long>
{
public static readonly long[] Value=A165053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165053.Bytes);
public long this[int i]=>Value[i];

public static A165053Inst Instance=new A165053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165054
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,3L,2L,3L,5L,4L,4L,5L,3L,2L,3L,5L,4L,4L,5L,3L,2L,3L,5L,4L,4L,5L,3L,2L,3L,5L,4L,4L,5L,3L,2L,3L,3L,4L,2L,3L,4L,3L,2L,3L,4L,2L,3L,4L,3L,3L,4L,2L,3L,2L,4L,4L,4L,2L,3L,3L,2L,2L,2L,2L,3L,4L,3L,3L,3L,3L,3L,4L,4L,4L,2L,3L,4L,4L,3L,3L,4L,2L,3L,4L,3L,2L,3L,4L,2L,2L,4L,3L,3L,4L,2L,3L,2L,4L,4L,4L,2L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165054Inst : IEnumerable<long>
{
public static readonly long[] Value=A165054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165054.Bytes);
public long this[int i]=>Value[i];

public static A165054Inst Instance=new A165054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165055
{
public static readonly long[] Value={ 0L,105L,5600L,27195L,33860L,42925L,1275170L,1657225L,6018495L,45962330L,47681900L,56319925L,60331825L,277695950L,348285175L,1305060855L,2151904825L,2175976225L,10363227560L,12973622725L,59994427550L,60063064790L,73115587525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165055Inst : IEnumerable<long>
{
public static readonly long[] Value=A165055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165055.Bytes);
public long this[int i]=>Value[i];

public static A165055Inst Instance=new A165055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165056
{
public static readonly long[] Value={ 0L,105L,430L,675L,705L,860L,890L,920L,4305L,5180L,5600L,16840L,27195L,33860L,35510L,42745L,42925L,218960L,259105L,895275L,996315L,1174130L,1221860L,1275170L,1276250L,1282910L,1285070L,1338380L,1548445L,1563925L,1601755L,1657225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165056Inst : IEnumerable<long>
{
public static readonly long[] Value=A165056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165056.Bytes);
public long this[int i]=>Value[i];

public static A165056Inst Instance=new A165056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165057
{
public static readonly long[] Value={ 1L,1L,6L,6L,6L,6L,6L,6L,2L,2L,1L,3L,1L,1L,3L,3L,1L,2L,2L,7L,7L,7L,2L,1L,2L,7L,7L,7L,2L,2L,7L,1L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165057Inst : IEnumerable<long>
{
public static readonly long[] Value=A165057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165057.Bytes);
public long this[int i]=>Value[i];

public static A165057Inst Instance=new A165057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165058
{
public static readonly long[] Value={ 430L,675L,705L,860L,890L,920L,4305L,5180L,16840L,35510L,42745L,218960L,259105L,895275L,996315L,1174130L,1221860L,1276250L,1282910L,1285070L,1338380L,1548445L,1563925L,1601755L,7892360L,9392845L,44002820L,46288670L,55760125L,56412805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165058Inst : IEnumerable<long>
{
public static readonly long[] Value=A165058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165058.Bytes);
public long this[int i]=>Value[i];

public static A165058Inst Instance=new A165058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165059
{
public static readonly long[] Value={ 6L,6L,6L,6L,6L,6L,2L,2L,3L,3L,3L,2L,2L,7L,7L,7L,2L,2L,7L,7L,7L,2L,2L,7L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165059Inst : IEnumerable<long>
{
public static readonly long[] Value=A165059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165059.Bytes);
public long this[int i]=>Value[i];

public static A165059Inst Instance=new A165059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165060
{
public static readonly long[] Value={ 0L,105L,430L,4305L,5600L,16840L,27195L,33860L,42925L,218960L,895275L,1221860L,1275170L,1548445L,1657225L,6018495L,7892360L,44002820L,45962330L,47681900L,55760125L,56319925L,59679145L,60331825L,277695950L,284180120L,348285175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165060Inst : IEnumerable<long>
{
public static readonly long[] Value=A165060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165060.Bytes);
public long this[int i]=>Value[i];

public static A165060Inst Instance=new A165060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165061
{
public static readonly long[] Value={ 1L,1L,6L,2L,1L,3L,1L,1L,1L,2L,7L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,2L,2L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165061Inst : IEnumerable<long>
{
public static readonly long[] Value=A165061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165061.Bytes);
public long this[int i]=>Value[i];

public static A165061Inst Instance=new A165061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165062
{
public static readonly long[] Value={ 430L,4305L,16840L,218960L,895275L,1221860L,1548445L,7892360L,44002820L,55760125L,59679145L,284180120L,1584195140L,1654738970L,2007458365L,2027613685L,2148546025L,2172060145L,10230811640L,12538603735L,57031585220L,59571164570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165062Inst : IEnumerable<long>
{
public static readonly long[] Value=A165062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165062.Bytes);
public long this[int i]=>Value[i];

public static A165062Inst Instance=new A165062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165063
{
public static readonly long[] Value={ 6L,2L,3L,2L,7L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165063Inst : IEnumerable<long>
{
public static readonly long[] Value=A165063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165063.Bytes);
public long this[int i]=>Value[i];

public static A165063Inst Instance=new A165063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165064
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,4L,1L,5L,2L,7L,3L,9L,4L,13L,7L,17L,8L,24L,11L,30L,16L,37L,21L,46L,27L,57L,34L,68L,42L,83L,52L,96L,64L,113L,77L,132L,90L,153L,107L,175L,125L,200L,145L,226L,168L,256L,191L,288L,217L,323L,247L,358L,278L,399L,312L,441L,348L,487L,387L,536L,429L,587L,475L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165064Inst : IEnumerable<long>
{
public static readonly long[] Value=A165064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165064.Bytes);
public long this[int i]=>Value[i];

public static A165064Inst Instance=new A165064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165065
{
public static readonly long[] Value={ 1L,0L,1L,6L,3L,6L,2L,13L,3L,10L,4L,15L,6L,21L,10L,29L,13L,40L,18L,52L,26L,65L,35L,82L,46L,101L,59L,123L,74L,149L,92L,176L,114L,207L,138L,243L,164L,282L,195L,325L,229L,372L,267L,423L,310L,479L,355L,541L,405L,607L,461L,677L,521L,754L,586L,836L,656L,924L,731L,1019L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165065Inst : IEnumerable<long>
{
public static readonly long[] Value=A165065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165065.Bytes);
public long this[int i]=>Value[i];

public static A165065Inst Instance=new A165065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165066
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,2L,1L,4L,2L,3L,2L,5L,4L,5L,3L,8L,4L,8L,6L,9L,7L,10L,8L,13L,9L,13L,10L,17L,12L,16L,14L,19L,16L,21L,16L,24L,19L,25L,21L,28L,23L,29L,26L,33L,27L,35L,29L,39L,33L,39L,35L,44L,38L,46L,40L,50L,43L,53L,46L,56L,50L,58L,53L,64L,55L,66L,59L,71L,63L,73L,66L,78L,71L,81L,73L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165066Inst : IEnumerable<long>
{
public static readonly long[] Value=A165066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165066.Bytes);
public long this[int i]=>Value[i];

public static A165066Inst Instance=new A165066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165067
{
public static readonly long[] Value={ 0L,4305L,16840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165067Inst : IEnumerable<long>
{
public static readonly long[] Value=A165067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165067.Bytes);
public long this[int i]=>Value[i];

public static A165067Inst Instance=new A165067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165068
{
public static readonly long[] Value={ 0L,38L,217L,1297L,1311L,7777L,7779L,7790L,7833L,46657L,279937L,279938L,279986L,280043L,280238L,1679617L,1681257L,10077697L,10077698L,10077710L,10077803L,10077962L,10078343L,10079524L,60466177L,60466179L,60475766L,362797057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165068Inst : IEnumerable<long>
{
public static readonly long[] Value=A165068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165068.Bytes);
public long this[int i]=>Value[i];

public static A165068Inst Instance=new A165068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165069
{
public static readonly long[] Value={ 0L,105L,430L,5600L,4305L,16840L,42925L,33860L,27195L,218960L,895275L,1548445L,1221860L,1657225L,1275170L,7892360L,6018495L,45962330L,55760125L,56319925L,59679145L,44002820L,60331825L,47681900L,284180120L,348285175L,277695950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165069Inst : IEnumerable<long>
{
public static readonly long[] Value=A165069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165069.Bytes);
public long this[int i]=>Value[i];

public static A165069Inst Instance=new A165069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165070
{
public static readonly long[] Value={ 1L,1L,6L,1L,2L,3L,1L,1L,1L,2L,7L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165070Inst : IEnumerable<long>
{
public static readonly long[] Value=A165070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165070.Bytes);
public long this[int i]=>Value[i];

public static A165070Inst Instance=new A165070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165071
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,6L,0L,6L,12L,18L,24L,30L,12L,6L,0L,6L,12L,18L,24L,18L,12L,6L,0L,6L,12L,18L,24L,18L,12L,6L,0L,6L,12L,30L,24L,18L,12L,6L,0L,6L,36L,30L,24L,18L,12L,6L,0L,48L,48L,96L,144L,192L,240L,288L,48L,0L,48L,96L,144L,192L,240L,96L,48L,48L,96L,144L,192L,240L,144L,96L,96L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165071Inst : IEnumerable<long>
{
public static readonly long[] Value=A165071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165071.Bytes);
public long this[int i]=>Value[i];

public static A165071Inst Instance=new A165071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165072
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,3L,4L,5L,2L,1L,0L,1L,2L,3L,4L,3L,2L,1L,0L,1L,2L,3L,4L,3L,2L,1L,0L,1L,2L,5L,4L,3L,2L,1L,0L,1L,6L,5L,4L,3L,2L,1L,0L,8L,8L,16L,24L,32L,40L,48L,8L,0L,8L,16L,24L,32L,40L,16L,8L,8L,16L,24L,32L,40L,24L,16L,16L,16L,24L,32L,40L,32L,24L,24L,24L,24L,32L,40L,40L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165072Inst : IEnumerable<long>
{
public static readonly long[] Value=A165072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165072.Bytes);
public long this[int i]=>Value[i];

public static A165072Inst Instance=new A165072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165073
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,3L,4L,2L,4L,3L,2L,1L,2L,3L,4L,2L,4L,3L,2L,1L,2L,3L,4L,2L,4L,3L,2L,1L,2L,3L,4L,2L,4L,3L,2L,1L,2L,3L,4L,2L,4L,3L,2L,1L,2L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,1L,1L,2L,3L,2L,2L,3L,1L,1L,2L,1L,3L,3L,3L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,3L,2L,2L,2L,2L,2L,2L,3L,3L,3L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165073Inst : IEnumerable<long>
{
public static readonly long[] Value=A165073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165073.Bytes);
public long this[int i]=>Value[i];

public static A165073Inst Instance=new A165073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165074
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,4L,5L,3L,5L,4L,3L,2L,3L,4L,5L,3L,5L,4L,3L,2L,3L,4L,5L,3L,5L,4L,3L,2L,3L,4L,5L,3L,5L,4L,3L,2L,3L,4L,5L,3L,5L,4L,3L,2L,3L,3L,5L,3L,3L,4L,5L,3L,2L,3L,5L,3L,3L,4L,5L,3L,3L,5L,3L,3L,4L,3L,5L,5L,5L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,4L,5L,4L,4L,4L,4L,4L,4L,5L,5L,5L,3L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165074Inst : IEnumerable<long>
{
public static readonly long[] Value=A165074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165074.Bytes);
public long this[int i]=>Value[i];

public static A165074Inst Instance=new A165074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165075
{
public static readonly long[] Value={ 0L,1922263344L,94197649008L,96503566608L,4615731883344L,4728721980144L,4744863403344L,226171191723408L,231707706601008L,232498637278608L,232611627241008L,11082390700389744L,11353679929526544L,11392435533669744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165075Inst : IEnumerable<long>
{
public static readonly long[] Value=A165075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165075.Bytes);
public long this[int i]=>Value[i];

public static A165075Inst Instance=new A165075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165076
{
public static readonly long[] Value={ 0L,144L,192L,1068L,1752L,1836L,9936L,10608L,13008L,13680L,15072L,55500L,72012L,77388L,89112L,91212L,91800L,640992L,643344L,660144L,674592L,760992L,780144L,3562968L,4605036L,4642668L,4772952L,5445336L,5464152L,31412208L,31680336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165076Inst : IEnumerable<long>
{
public static readonly long[] Value=A165076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165076.Bytes);
public long this[int i]=>Value[i];

public static A165076Inst Instance=new A165076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165077
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,2L,2L,2L,2L,2L,2L,1L,2L,2L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,1L,6L,1L,9L,9L,9L,2L,2L,9L,9L,9L,9L,9L,9L,2L,1L,2L,1L,1L,2L,2L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165077Inst : IEnumerable<long>
{
public static readonly long[] Value=A165077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165077.Bytes);
public long this[int i]=>Value[i];

public static A165077Inst Instance=new A165077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165078
{
public static readonly long[] Value={ 144L,192L,1068L,1752L,1836L,9936L,10608L,13008L,13680L,15072L,55500L,72012L,77388L,89112L,91212L,91800L,640992L,643344L,660144L,674592L,760992L,780144L,3562968L,4605036L,4642668L,4772952L,5445336L,5464152L,31412208L,31680336L,32353344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165078Inst : IEnumerable<long>
{
public static readonly long[] Value=A165078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165078.Bytes);
public long this[int i]=>Value[i];

public static A165078Inst Instance=new A165078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165079
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,2L,2L,2L,2L,2L,2L,2L,2L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,9L,9L,9L,2L,2L,9L,9L,9L,9L,9L,9L,2L,2L,2L,2L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,2L,2L,2L,2L,4L,4L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165079Inst : IEnumerable<long>
{
public static readonly long[] Value=A165079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165079.Bytes);
public long this[int i]=>Value[i];

public static A165079Inst Instance=new A165079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165080
{
public static readonly long[] Value={ 0L,144L,1068L,9936L,55500L,640992L,3562968L,31412208L,220709400L,227429400L,228238488L,1922263344L,11150046252L,11432420652L,75796404672L,94197649008L,96503566608L,419850417612L,546394287000L,3939440152944L,4615731883344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165080Inst : IEnumerable<long>
{
public static readonly long[] Value=A165080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165080.Bytes);
public long this[int i]=>Value[i];

public static A165080Inst Instance=new A165080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165081
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,6L,6L,11L,2L,2L,2L,1L,2L,5L,6L,1L,1L,9L,2L,2L,1L,1L,1L,2L,12L,1L,2L,1L,1L,1L,2L,4L,1L,2L,1L,2L,1L,1L,1L,2L,5L,7L,2L,2L,1L,1L,2L,3L,1L,2L,1L,2L,1L,1L,1L,2L,5L,1L,2L,1L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,1L,1L,1L,2L,5L,5L,1L,1L,2L,1L,2L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,1L,1L,1L,2L,24L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165081Inst : IEnumerable<long>
{
public static readonly long[] Value=A165081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165081.Bytes);
public long this[int i]=>Value[i];

public static A165081Inst Instance=new A165081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165082
{
public static readonly long[] Value={ 144L,1068L,9936L,55500L,640992L,3562968L,31412208L,220709400L,227429400L,228238488L,11150046252L,11432420652L,75796404672L,419850417612L,546394287000L,3939440152944L,26773614188652L,26884299308652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165082Inst : IEnumerable<long>
{
public static readonly long[] Value=A165082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165082.Bytes);
public long this[int i]=>Value[i];

public static A165082Inst Instance=new A165082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165083
{
public static readonly long[] Value={ 2L,3L,5L,6L,6L,6L,11L,2L,2L,2L,2L,5L,6L,9L,2L,2L,2L,12L,2L,2L,4L,2L,2L,2L,5L,7L,2L,2L,2L,3L,2L,2L,2L,5L,2L,2L,3L,2L,3L,2L,2L,2L,5L,5L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,24L,2L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,7L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,25L,2L,2L,3L,2L,2L,3L,3L,2L,3L,3L,2L,3L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165083Inst : IEnumerable<long>
{
public static readonly long[] Value=A165083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165083.Bytes);
public long this[int i]=>Value[i];

public static A165083Inst Instance=new A165083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165084
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,3L,2L,4L,2L,5L,1L,8L,6L,10L,5L,13L,7L,18L,7L,20L,8L,25L,12L,30L,13L,35L,15L,43L,16L,51L,20L,56L,25L,63L,29L,71L,33L,79L,38L,89L,42L,99L,48L,112L,53L,123L,57L,137L,63L,150L,71L,164L,79L,177L,87L,190L,95L,210L,101L,229L,109L,246L,119L,263L,132L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165084Inst : IEnumerable<long>
{
public static readonly long[] Value=A165084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165084.Bytes);
public long this[int i]=>Value[i];

public static A165084Inst Instance=new A165084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165085
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,6L,6L,6L,11L,6L,1L,7L,8L,11L,5L,14L,6L,2L,13L,19L,15L,11L,21L,17L,31L,32L,35L,16L,45L,42L,55L,31L,65L,34L,84L,24L,107L,45L,117L,39L,138L,54L,164L,53L,184L,67L,212L,70L,240L,81L,277L,90L,310L,97L,350L,108L,388L,125L,436L,140L,481L,155L,526L,179L,591L,181L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165085Inst : IEnumerable<long>
{
public static readonly long[] Value=A165085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165085.Bytes);
public long this[int i]=>Value[i];

public static A165085Inst Instance=new A165085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165086
{
public static readonly long[] Value={ 0L,144L,1068L,9458722410775248L,9936L,55500L,65945195409025452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165086Inst : IEnumerable<long>
{
public static readonly long[] Value=A165086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165086.Bytes);
public long this[int i]=>Value[i];

public static A165086Inst Instance=new A165086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165087
{
public static readonly long[] Value={ 0L,51L,344L,2402L,16808L,117650L,823544L,5764802L,40353608L,40353623L,40354466L,282475250L,1977326744L,1977326763L,13841287202L,13841287211L,13841290483L,96889010408L,96889010409L,678223072850L,678223072851L,678223072995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165087Inst : IEnumerable<long>
{
public static readonly long[] Value=A165087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165087.Bytes);
public long this[int i]=>Value[i];

public static A165087Inst Instance=new A165087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165088
{
public static readonly long[] Value={ 0L,144L,1068L,9936L,55500L,640992L,3562968L,31412208L,228238488L,227429400L,220709400L,1922263344L,11432420652L,11150046252L,75796404672L,94197649008L,96503566608L,546394287000L,419850417612L,4615731883344L,3939440152944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165088Inst : IEnumerable<long>
{
public static readonly long[] Value=A165088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165088.Bytes);
public long this[int i]=>Value[i];

public static A165088Inst Instance=new A165088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165089
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,6L,6L,11L,2L,2L,2L,1L,5L,2L,6L,1L,1L,2L,9L,1L,2L,1L,1L,12L,2L,2L,1L,1L,1L,1L,2L,2L,1L,4L,2L,1L,1L,1L,1L,5L,7L,1L,2L,2L,2L,3L,1L,2L,1L,2L,2L,1L,1L,1L,1L,5L,2L,1L,2L,1L,1L,2L,3L,3L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,5L,5L,2L,1L,1L,2L,2L,1L,3L,3L,2L,2L,1L,3L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,24L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165089Inst : IEnumerable<long>
{
public static readonly long[] Value=A165089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165089.Bytes);
public long this[int i]=>Value[i];

public static A165089Inst Instance=new A165089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165090
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,7L,14L,21L,28L,35L,42L,14L,7L,0L,7L,14L,21L,28L,35L,21L,14L,7L,0L,7L,14L,21L,28L,28L,21L,14L,7L,0L,7L,14L,21L,35L,28L,21L,14L,7L,0L,7L,14L,42L,35L,28L,21L,14L,7L,0L,7L,49L,42L,35L,28L,21L,14L,7L,0L,63L,63L,126L,189L,252L,315L,378L,441L,63L,0L,63L,126L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165090Inst : IEnumerable<long>
{
public static readonly long[] Value=A165090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165090.Bytes);
public long this[int i]=>Value[i];

public static A165090Inst Instance=new A165090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165091
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,3L,4L,5L,6L,2L,1L,0L,1L,2L,3L,4L,5L,3L,2L,1L,0L,1L,2L,3L,4L,4L,3L,2L,1L,0L,1L,2L,3L,5L,4L,3L,2L,1L,0L,1L,2L,6L,5L,4L,3L,2L,1L,0L,1L,7L,6L,5L,4L,3L,2L,1L,0L,9L,9L,18L,27L,36L,45L,54L,63L,9L,0L,9L,18L,27L,36L,45L,54L,18L,9L,9L,18L,27L,36L,45L,54L,27L,18L,18L,18L,27L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165091Inst : IEnumerable<long>
{
public static readonly long[] Value=A165091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165091.Bytes);
public long this[int i]=>Value[i];

public static A165091Inst Instance=new A165091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165092
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,4L,1L,3L,3L,2L,4L,2L,1L,2L,4L,0L,3L,3L,1L,4L,2L,1L,2L,4L,1L,3L,3L,1L,4L,2L,1L,2L,4L,1L,3L,3L,1L,4L,2L,1L,2L,4L,2L,3L,3L,1L,4L,2L,1L,2L,4L,2L,3L,3L,1L,4L,2L,1L,2L,2L,4L,3L,1L,2L,3L,4L,2L,1L,2L,4L,3L,1L,2L,3L,4L,2L,2L,4L,3L,1L,2L,3L,3L,4L,4L,4L,3L,1L,2L,3L,1L,3L,3L,3L,3L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165092Inst : IEnumerable<long>
{
public static readonly long[] Value=A165092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165092.Bytes);
public long this[int i]=>Value[i];

public static A165092Inst Instance=new A165092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165093
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,5L,2L,4L,4L,3L,5L,3L,2L,3L,5L,1L,4L,4L,2L,5L,3L,2L,3L,5L,2L,4L,4L,2L,5L,3L,2L,3L,5L,2L,4L,4L,2L,5L,3L,2L,3L,5L,3L,4L,4L,2L,5L,3L,2L,3L,5L,3L,4L,4L,2L,5L,3L,2L,3L,3L,5L,4L,2L,3L,4L,5L,3L,2L,3L,5L,4L,2L,3L,4L,5L,3L,3L,5L,4L,2L,3L,4L,4L,5L,5L,5L,4L,2L,3L,4L,2L,4L,4L,4L,4L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165093Inst : IEnumerable<long>
{
public static readonly long[] Value=A165093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165093.Bytes);
public long this[int i]=>Value[i];

public static A165093Inst Instance=new A165093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165094
{
public static readonly long[] Value={ 0L,21L,252L,147420L,213402L,1711962L,16092433L,76545756L,1068263553L,39258683100L,57497839826L,58573445322L,68675650561L,3680015145170L,3749808363210L,4238480197777L,4397695901697L,20104741893852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165094Inst : IEnumerable<long>
{
public static readonly long[] Value=A165094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165094.Bytes);
public long this[int i]=>Value[i];

public static A165094Inst Instance=new A165094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165095
{
public static readonly long[] Value={ 0L,21L,252L,1022L,1589L,2044L,2212L,2723L,3122L,3178L,3290L,17892L,20475L,21483L,21987L,25578L,26586L,102837L,147420L,177443L,213402L,217938L,1445787L,1449819L,1646442L,1707930L,1711962L,1715994L,1740690L,1752786L,1777482L,1941345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165095Inst : IEnumerable<long>
{
public static readonly long[] Value=A165095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165095.Bytes);
public long this[int i]=>Value[i];

public static A165095Inst Instance=new A165095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165096
{
public static readonly long[] Value={ 1L,1L,1L,5L,3L,5L,5L,3L,5L,3L,5L,2L,2L,4L,4L,4L,4L,3L,1L,3L,1L,3L,7L,7L,7L,4L,1L,7L,4L,7L,7L,7L,4L,4L,3L,3L,3L,3L,3L,3L,1L,1L,5L,5L,4L,4L,5L,5L,5L,5L,5L,4L,4L,5L,5L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,6L,4L,6L,4L,2L,6L,6L,4L,2L,4L,6L,6L,3L,1L,3L,3L,3L,3L,3L,3L,4L,1L,3L,2L,3L,3L,3L,3L,1L,4L,4L,3L,3L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165096Inst : IEnumerable<long>
{
public static readonly long[] Value=A165096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165096.Bytes);
public long this[int i]=>Value[i];

public static A165096Inst Instance=new A165096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165097
{
public static readonly long[] Value={ 1022L,1589L,2044L,2212L,2723L,3122L,3178L,3290L,17892L,20475L,21483L,21987L,25578L,26586L,102837L,177443L,217938L,1445787L,1449819L,1646442L,1707930L,1715994L,1740690L,1752786L,1777482L,1941345L,1978137L,1982169L,6589877L,11381027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165097Inst : IEnumerable<long>
{
public static readonly long[] Value=A165097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165097.Bytes);
public long this[int i]=>Value[i];

public static A165097Inst Instance=new A165097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165098
{
public static readonly long[] Value={ 5L,3L,5L,5L,3L,5L,3L,5L,2L,2L,4L,4L,4L,4L,3L,3L,3L,7L,7L,7L,4L,7L,4L,7L,7L,7L,4L,4L,3L,3L,3L,3L,3L,3L,5L,5L,4L,4L,5L,5L,5L,5L,5L,4L,4L,5L,5L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,6L,4L,6L,4L,2L,6L,6L,4L,2L,4L,6L,6L,3L,3L,3L,3L,3L,3L,3L,4L,3L,2L,3L,3L,3L,3L,4L,4L,3L,3L,3L,4L,2L,3L,3L,3L,3L,3L,3L,5L,9L,9L,9L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165098Inst : IEnumerable<long>
{
public static readonly long[] Value=A165098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165098.Bytes);
public long this[int i]=>Value[i];

public static A165098Inst Instance=new A165098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165099
{
public static readonly long[] Value={ 0L,21L,252L,1022L,1589L,17892L,21483L,102837L,147420L,213402L,1445787L,1707930L,1711962L,6589877L,13667738L,16092433L,76545756L,93093147L,110132442L,111443346L,421817781L,874802586L,878996762L,1029991697L,1068263553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165099Inst : IEnumerable<long>
{
public static readonly long[] Value=A165099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165099.Bytes);
public long this[int i]=>Value[i];

public static A165099Inst Instance=new A165099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165100
{
public static readonly long[] Value={ 1L,1L,1L,5L,3L,2L,4L,3L,1L,1L,7L,4L,1L,3L,3L,1L,1L,5L,5L,4L,3L,3L,3L,3L,1L,6L,4L,2L,3L,1L,3L,3L,3L,4L,1L,2L,1L,3L,3L,3L,1L,5L,9L,3L,3L,3L,3L,3L,3L,1L,1L,3L,3L,3L,1L,3L,3L,3L,1L,1L,12L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,3L,3L,3L,1L,2L,5L,1L,3L,1L,3L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,6L,2L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165100Inst : IEnumerable<long>
{
public static readonly long[] Value=A165100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165100.Bytes);
public long this[int i]=>Value[i];

public static A165100Inst Instance=new A165100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165101
{
public static readonly long[] Value={ 1022L,1589L,17892L,21483L,102837L,1445787L,1707930L,6589877L,13667738L,93093147L,110132442L,111443346L,421817781L,874802586L,878996762L,1029991697L,7034104602L,7168322322L,7302540042L,26996862389L,55987891610L,56256326938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165101Inst : IEnumerable<long>
{
public static readonly long[] Value=A165101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165101.Bytes);
public long this[int i]=>Value[i];

public static A165101Inst Instance=new A165101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165102
{
public static readonly long[] Value={ 5L,3L,2L,4L,3L,7L,4L,3L,3L,5L,5L,4L,3L,3L,3L,3L,6L,4L,2L,3L,3L,3L,3L,4L,2L,3L,3L,3L,5L,9L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,12L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,6L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165102Inst : IEnumerable<long>
{
public static readonly long[] Value=A165102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165102.Bytes);
public long this[int i]=>Value[i];

public static A165102Inst Instance=new A165102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165103
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,3L,4L,5L,3L,13L,2L,16L,3L,21L,5L,34L,5L,45L,12L,62L,13L,82L,22L,104L,35L,137L,45L,170L,61L,215L,82L,264L,111L,323L,139L,389L,179L,466L,223L,564L,275L,657L,338L,774L,410L,905L,498L,1048L,587L,1212L,696L,1392L,818L,1598L,958L,1811L,1110L,2058L,1281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165103Inst : IEnumerable<long>
{
public static readonly long[] Value=A165103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165103.Bytes);
public long this[int i]=>Value[i];

public static A165103Inst Instance=new A165103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165104
{
public static readonly long[] Value={ 1L,1L,1L,8L,6L,5L,12L,7L,15L,13L,12L,31L,14L,40L,14L,59L,12L,96L,11L,137L,24L,184L,35L,234L,64L,300L,102L,391L,134L,494L,175L,630L,232L,782L,311L,954L,402L,1147L,521L,1374L,659L,1649L,814L,1943L,992L,2294L,1203L,2687L,1454L,3117L,1731L,3597L,2060L,4130L,2430L,4734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165104Inst : IEnumerable<long>
{
public static readonly long[] Value=A165104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165104.Bytes);
public long this[int i]=>Value[i];

public static A165104Inst Instance=new A165104Inst();

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