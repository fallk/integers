using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A096827
{
public static readonly long[] Value={ 2L,3L,3L,4L,3L,6L,3L,5L,4L,6L,3L,10L,3L,6L,6L,6L,3L,10L,3L,10L,6L,6L,3L,15L,4L,6L,5L,10L,3L,20L,3L,7L,6L,6L,6L,20L,3L,6L,6L,15L,3L,20L,3L,10L,10L,6L,3L,21L,4L,10L,6L,10L,3L,15L,6L,15L,6L,6L,3L,50L,3L,6L,10L,8L,6L,20L,3L,10L,6L,20L,3L,35L,3L,6L,10L,10L,6L,20L,3L,21L,6L,6L,3L,50L,6L,6L,6L,15L,3L,50L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096827Inst : IEnumerable<long>
{
public static readonly long[] Value=A096827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096827.Bytes);
public long this[int i]=>Value[i];

public static A096827Inst Instance=new A096827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096828
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,14L,15L,18L,19L,20L,21L,22L,23L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096828Inst : IEnumerable<long>
{
public static readonly long[] Value=A096828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096828.Bytes);
public long this[int i]=>Value[i];

public static A096828Inst Instance=new A096828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096829
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,12L,14L,15L,18L,19L,20L,21L,22L,23L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096829Inst : IEnumerable<long>
{
public static readonly long[] Value=A096829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096829.Bytes);
public long this[int i]=>Value[i];

public static A096829Inst Instance=new A096829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096830
{
public static readonly long[] Value={ 0L,2L,2L,1L,0L,2L,1L,0L,1L,2L,4L,3L,1L,3L,0L,1L,1L,1L,0L,3L,5L,1L,0L,0L,1L,2L,4L,1L,3L,1L,1L,2L,4L,0L,2L,0L,2L,5L,2L,5L,2L,4L,4L,5L,3L,3L,1L,5L,3L,3L,0L,3L,4L,1L,3L,2L,1L,1L,1L,1L,1L,3L,2L,2L,2L,0L,3L,2L,4L,4L,0L,4L,4L,2L,3L,5L,3L,1L,1L,8L,1L,2L,2L,1L,2L,2L,0L,1L,3L,5L,2L,2L,4L,2L,5L,3L,5L,2L,5L,2L,2L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096830Inst : IEnumerable<long>
{
public static readonly long[] Value=A096830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096830.Bytes);
public long this[int i]=>Value[i];

public static A096830Inst Instance=new A096830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096831
{
public static readonly long[] Value={ 2L,2L,2L,1L,2L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096831Inst : IEnumerable<long>
{
public static readonly long[] Value=A096831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096831.Bytes);
public long this[int i]=>Value[i];

public static A096831Inst Instance=new A096831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096832
{
public static readonly long[] Value={ 2L,4L,4L,2L,3L,4L,1L,2L,1L,1L,1L,1L,3L,3L,1L,4L,2L,1L,4L,1L,2L,4L,1L,7L,1L,4L,2L,3L,0L,2L,3L,3L,0L,1L,6L,2L,1L,2L,4L,2L,3L,2L,2L,0L,3L,0L,2L,5L,3L,3L,1L,5L,2L,6L,3L,4L,3L,2L,2L,4L,2L,4L,1L,4L,7L,5L,2L,7L,1L,3L,2L,2L,6L,6L,3L,1L,3L,5L,4L,1L,4L,5L,6L,2L,5L,2L,4L,2L,0L,6L,1L,3L,5L,2L,5L,4L,4L,4L,3L,4L,3L,1L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096832Inst : IEnumerable<long>
{
public static readonly long[] Value=A096832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096832.Bytes);
public long this[int i]=>Value[i];

public static A096832Inst Instance=new A096832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096833
{
public static readonly long[] Value={ 4L,6L,11L,13L,24L,66L,68L,75L,167L,171L,172L,287L,310L,352L,384L,457L,564L,590L,616L,620L,643L,849L,1391L,1552L,1613L,1849L,2122L,2647L,2673L,4413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096833Inst : IEnumerable<long>
{
public static readonly long[] Value=A096833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096833.Bytes);
public long this[int i]=>Value[i];

public static A096833Inst Instance=new A096833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096834
{
public static readonly BigInteger[] Value={ 211L,30029L,200560490131L,304250263527209L,BigInteger.Parse("23768741896345550770650537601358309") };
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
public class A096834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096834Inst Instance=new A096834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096835
{
public static readonly long[] Value={ 3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,0L,0L,1L,3L,3L,0L,2L,2L,2L,3L,2L,4L,1L,3L,3L,2L,3L,2L,1L,2L,2L,1L,0L,1L,2L,5L,2L,3L,0L,2L,4L,1L,0L,3L,3L,2L,2L,1L,3L,3L,2L,1L,2L,3L,2L,2L,5L,0L,3L,2L,2L,3L,4L,0L,1L,3L,0L,1L,4L,0L,2L,1L,1L,2L,3L,2L,3L,1L,2L,3L,3L,0L,0L,1L,2L,2L,2L,2L,2L,2L,5L,3L,0L,1L,6L,1L,4L,5L,1L,2L,3L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096835Inst : IEnumerable<long>
{
public static readonly long[] Value=A096835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096835.Bytes);
public long this[int i]=>Value[i];

public static A096835Inst Instance=new A096835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096852
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,2L,1L,2L,2L,6L,2L,1L,6L,2L,1L,2L,3L,11L,11L,2L,2L,15L,15L,18L,18L,18L,18L,12L,12L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096852Inst : IEnumerable<long>
{
public static readonly long[] Value=A096852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096852.Bytes);
public long this[int i]=>Value[i];

public static A096852Inst Instance=new A096852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096853
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,48L,64L,144L,288L,512L,576L,2304L,4096L,10240L,18432L,36288L,65536L,184320L,262144L,552960L,718848L,1492992L,2822400L,9123840L,13418496L,44695552L,68762880L,106168320L,109486080L,580386816L,1073741824L,2155507200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096853Inst : IEnumerable<long>
{
public static readonly long[] Value=A096853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096853.Bytes);
public long this[int i]=>Value[i];

public static A096853Inst Instance=new A096853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096854
{
public static readonly long[] Value={ 1L,3L,12L,15L,72L,91L,312L,255L,1240L,1860L,4123L,5080L,26208L,34200L,93600L,65535L,334368L,416560L,1420800L,1596364L,6146800L,5949696L,20485332L,23788842L,120519630L,194016600L,358132380L,458803800L,1674738000L,2166798816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096854Inst : IEnumerable<long>
{
public static readonly long[] Value=A096854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096854.Bytes);
public long this[int i]=>Value[i];

public static A096854Inst Instance=new A096854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096855
{
public static readonly long[] Value={ 2L,2L,12L,6L,16L,24L,80L,84L,320L,360L,864L,1320L,5456L,5184L,15744L,19800L,52800L,69120L,349520L,370080L,1036800L,1425600L,3640896L,4741632L,13989888L,27091584L,76743040L,94656000L,166387200L,412473600L,1407389952L,1420488192L,3459760128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096855Inst : IEnumerable<long>
{
public static readonly long[] Value=A096855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096855.Bytes);
public long this[int i]=>Value[i];

public static A096855Inst Instance=new A096855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096856
{
public static readonly long[] Value={ 3L,7L,12L,31L,42L,124L,224L,511L,847L,1953L,2688L,12264L,18816L,29127L,72540L,131071L,195048L,558523L,1077440L,3164112L,4552020L,10890040L,10342080L,54525848L,73260781L,155671040L,318848400L,1080311232L,964580240L,3070642080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096856Inst : IEnumerable<long>
{
public static readonly long[] Value=A096856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096856.Bytes);
public long this[int i]=>Value[i];

public static A096856Inst Instance=new A096856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096857
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,2L,1L,2L,2L,6L,2L,1L,6L,2L,1L,2L,3L,11L,11L,2L,2L,15L,15L,18L,18L,18L,18L,12L,12L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096857Inst : IEnumerable<long>
{
public static readonly long[] Value=A096857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096857.Bytes);
public long this[int i]=>Value[i];

public static A096857Inst Instance=new A096857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096858
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,5L,6L,7L,6L,9L,11L,12L,13L,11L,17L,20L,22L,23L,24L,20L,31L,37L,40L,42L,43L,44L,40L,60L,71L,77L,80L,82L,83L,84L,77L,117L,137L,148L,154L,157L,159L,160L,161L,148L,225L,265L,285L,296L,302L,305L,307L,308L,309L,285L,433L,510L,550L,570L,581L,587L,590L,592L,593L,594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096858Inst : IEnumerable<long>
{
public static readonly long[] Value=A096858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096858.Bytes);
public long this[int i]=>Value[i];

public static A096858Inst Instance=new A096858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096859
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,1L,2L,3L,3L,1L,3L,2L,2L,3L,3L,4L,2L,2L,4L,2L,2L,3L,4L,2L,4L,4L,2L,3L,4L,4L,4L,5L,4L,3L,5L,4L,4L,4L,2L,5L,3L,4L,4L,4L,4L,2L,4L,3L,4L,6L,5L,5L,4L,5L,5L,4L,4L,2L,4L,5L,3L,4L,4L,3L,5L,4L,5L,3L,4L,2L,4L,4L,3L,3L,5L,3L,5L,3L,4L,4L,4L,3L,4L,5L,5L,3L,4L,3L,3L,3L,5L,3L,5L,2L,6L,4L,3L,7L,5L,3L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096859Inst : IEnumerable<long>
{
public static readonly long[] Value=A096859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096859.Bytes);
public long this[int i]=>Value[i];

public static A096859Inst Instance=new A096859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096860
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,2L,1L,1L,1L,1L,0L,2L,1L,1L,4L,2L,3L,1L,3L,3L,1L,1L,0L,1L,3L,1L,2L,1L,1L,3L,2L,3L,1L,1L,0L,2L,2L,1L,1L,3L,1L,3L,1L,2L,2L,1L,1L,2L,2L,3L,1L,1L,1L,1L,1L,3L,1L,3L,0L,4L,2L,1L,5L,3L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096860Inst : IEnumerable<long>
{
public static readonly long[] Value=A096860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096860.Bytes);
public long this[int i]=>Value[i];

public static A096860Inst Instance=new A096860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096861
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,6L,7L,8L,12L,10L,11L,12L,13L,14L,15L,30L,17L,30L,19L,20L,30L,22L,23L,30L,30L,26L,30L,30L,29L,30L,31L,96L,33L,34L,35L,96L,37L,38L,39L,40L,41L,96L,43L,44L,45L,46L,47L,60L,96L,60L,51L,96L,53L,96L,55L,96L,96L,58L,59L,60L,61L,96L,63L,126L,65L,66L,96L,96L,96L,70L,71L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096861Inst : IEnumerable<long>
{
public static readonly long[] Value=A096861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096861.Bytes);
public long this[int i]=>Value[i];

public static A096861Inst Instance=new A096861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096862
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,2L,3L,3L,3L,4L,2L,2L,3L,1L,2L,4L,3L,5L,2L,2L,4L,3L,2L,3L,2L,5L,1L,5L,2L,3L,4L,3L,4L,4L,2L,4L,5L,4L,4L,5L,2L,6L,3L,4L,3L,4L,4L,6L,3L,5L,4L,7L,5L,5L,4L,4L,5L,5L,3L,3L,4L,4L,5L,3L,3L,4L,5L,5L,4L,4L,3L,3L,4L,5L,4L,3L,4L,3L,5L,6L,5L,5L,4L,5L,6L,6L,5L,4L,4L,3L,5L,3L,4L,3L,5L,3L,6L,3L,5L,8L,5L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096862Inst : IEnumerable<long>
{
public static readonly long[] Value=A096862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096862.Bytes);
public long this[int i]=>Value[i];

public static A096862Inst Instance=new A096862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096863
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,2L,0L,1L,1L,0L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,0L,2L,1L,0L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,4L,2L,1L,2L,1L,1L,4L,2L,3L,1L,5L,2L,2L,1L,2L,2L,2L,0L,1L,1L,2L,3L,1L,2L,2L,3L,2L,1L,2L,0L,1L,2L,2L,2L,1L,1L,1L,3L,4L,2L,3L,1L,3L,4L,4L,2L,2L,1L,1L,2L,1L,1L,1L,3L,1L,4L,1L,2L,6L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096863Inst : IEnumerable<long>
{
public static readonly long[] Value=A096863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096863.Bytes);
public long this[int i]=>Value[i];

public static A096863Inst Instance=new A096863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096864
{
public static readonly long[] Value={ 1L,2L,3L,4L,12L,6L,12L,12L,12L,12L,18L,12L,28L,14L,15L,16L,72L,18L,72L,20L,28L,22L,36L,24L,42L,28L,72L,28L,72L,30L,72L,72L,42L,72L,72L,36L,252L,72L,72L,72L,90L,42L,252L,44L,72L,46L,72L,72L,252L,50L,252L,72L,252L,72L,90L,72L,252L,72L,90L,72L,168L,72L,252L,252L,168L,66L,168L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096864Inst : IEnumerable<long>
{
public static readonly long[] Value=A096864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096864.Bytes);
public long this[int i]=>Value[i];

public static A096864Inst Instance=new A096864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096865
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,4L,8L,9L,4L,4L,12L,4L,8L,8L,16L,4L,16L,8L,12L,16L,12L,8L,16L,16L,12L,16L,16L,8L,16L,16L,32L,16L,16L,16L,36L,16L,16L,16L,16L,12L,32L,12L,16L,16L,16L,16L,48L,36L,48L,16L,32L,16L,32L,16L,32L,32L,16L,16L,48L,16L,32L,48L,64L,16L,48L,32L,36L,32L,48L,16L,72L,36L,36L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096865Inst : IEnumerable<long>
{
public static readonly long[] Value=A096865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096865.Bytes);
public long this[int i]=>Value[i];

public static A096865Inst Instance=new A096865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096866
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,3L,7L,7L,7L,7L,7L,7L,13L,7L,15L,15L,17L,7L,19L,15L,21L,7L,23L,15L,25L,26L,27L,28L,29L,15L,31L,31L,28L,31L,31L,28L,37L,31L,31L,31L,31L,28L,43L,28L,31L,28L,31L,31L,49L,28L,51L,31L,53L,31L,31L,31L,57L,31L,31L,31L,61L,31L,63L,63L,65L,28L,67L,63L,31L,31L,71L,31L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096866Inst : IEnumerable<long>
{
public static readonly long[] Value=A096866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096866.Bytes);
public long this[int i]=>Value[i];

public static A096866Inst Instance=new A096866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096867
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,25L,26L,27L,35L,45L,55L,56L,57L,58L,67L,68L,77L,255L,256L,257L,355L,455L,555L,556L,557L,558L,567L,568L,577L,2555L,2556L,2557L,3555L,4555L,5555L,5556L,5557L,5558L,5567L,5568L,5577L,25555L,25556L,25557L,35555L,45555L,55555L,55556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096867Inst : IEnumerable<long>
{
public static readonly long[] Value=A096867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096867.Bytes);
public long this[int i]=>Value[i];

public static A096867Inst Instance=new A096867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096900
{
public static readonly long[] Value={ 1L,7L,2L,31L,10L,3L,22L,127L,38L,4L,58L,27L,82L,16L,5L,511L,142L,32L,178L,19L,6L,52L,262L,123L,310L,76L,362L,7L,418L,59L,478L,2047L,42L,136L,25L,8L,682L,172L,66L,115L,838L,47L,922L,28L,9L,256L,1102L,507L,1198L,304L,126L,52L,1402L,356L,10L,103L,162L,412L,1738L,80L,1858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096900Inst : IEnumerable<long>
{
public static readonly long[] Value=A096900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096900.Bytes);
public long this[int i]=>Value[i];

public static A096900Inst Instance=new A096900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096901
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,1L,2L,4L,3L,9L,14L,13L,52L,124L,161L,181L,715L,2338L,7073L,8624L,15466L,52858L,150365L,316543L,691771L,1681604L,5324919L,15407311L,37417775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096901Inst : IEnumerable<long>
{
public static readonly long[] Value=A096901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096901.Bytes);
public long this[int i]=>Value[i];

public static A096901Inst Instance=new A096901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096902
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,18L,20L,24L,26L,27L,30L,31L,37L,38L,40L,46L,48L,50L,55L,56L,58L,60L,62L,63L,64L,66L,67L,70L,71L,72L,73L,74L,78L,81L,85L,88L,89L,92L,95L,98L,102L,109L,113L,114L,116L,120L,121L,122L,130L,133L,134L,135L,136L,140L,144L,147L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096902Inst : IEnumerable<long>
{
public static readonly long[] Value=A096902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096902.Bytes);
public long this[int i]=>Value[i];

public static A096902Inst Instance=new A096902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096903
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,18L,16L,24L,54L,30L,32L,36L,48L,162L,60L,90L,150L,64L,72L,108L,96L,486L,120L,270L,750L,128L,144L,324L,180L,300L,450L,192L,1458L,210L,216L,240L,810L,3750L,256L,288L,972L,360L,540L,600L,1350L,1500L,2250L,384L,4374L,420L,630L,1050L,1470L,432L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096903Inst : IEnumerable<long>
{
public static readonly long[] Value=A096903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096903.Bytes);
public long this[int i]=>Value[i];

public static A096903Inst Instance=new A096903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096904
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,4L,0L,0L,4L,4L,5L,1L,2L,1L,1L,1L,1L,2L,3L,7L,3L,10L,6L,5L,1L,1L,4L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,3L,30L,37L,1963L,1289L,1560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096904Inst : IEnumerable<long>
{
public static readonly long[] Value=A096904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096904.Bytes);
public long this[int i]=>Value[i];

public static A096904Inst Instance=new A096904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096905
{
public static readonly long[] Value={ 15L,65L,80L,175L,190L,240L,255L,369L,384L,434L,449L,544L,559L,609L,624L,671L,686L,736L,751L,846L,861L,911L,926L,1040L,1055L,1105L,1120L,1215L,1230L,1235L,1250L,1260L,1270L,1275L,1280L,1285L,1290L,1295L,1300L,1305L,1315L,1345L,1360L,1474L,1489L,1519L,1529L,1534L,1539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096905Inst : IEnumerable<long>
{
public static readonly long[] Value=A096905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096905.Bytes);
public long this[int i]=>Value[i];

public static A096905Inst Instance=new A096905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096906
{
public static readonly long[] Value={ 31L,211L,242L,781L,812L,992L,1023L,2101L,2132L,2312L,2343L,2882L,2913L,3093L,3124L,4651L,4682L,4862L,4893L,5432L,5463L,5643L,5674L,6752L,6783L,6963L,6994L,7533L,7564L,7744L,7775L,9031L,9062L,9242L,9273L,9812L,9843L,10023L,10054L,11132L,11163L,11343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096906Inst : IEnumerable<long>
{
public static readonly long[] Value=A096906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096906.Bytes);
public long this[int i]=>Value[i];

public static A096906Inst Instance=new A096906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096907
{
public static readonly long[] Value={ 1L,2L,4L,1L,6L,2L,3L,2L,2L,8L,1L,6L,6L,1L,8L,4L,4L,4L,6L,3L,3L,12L,9L,7L,10L,2L,2L,2L,12L,11L,3L,14L,6L,6L,5L,17L,8L,7L,4L,8L,4L,1L,15L,6L,1L,6L,8L,12L,3L,3L,19L,14L,2L,13L,2L,10L,23L,12L,9L,4L,4L,18L,7L,9L,2L,6L,2L,20L,4L,16L,13L,8L,5L,18L,18L,6L,11L,2L,6L,23L,12L,9L,4L,15L,12L,4L,22L,14L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096907Inst : IEnumerable<long>
{
public static readonly long[] Value=A096907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096907.Bytes);
public long this[int i]=>Value[i];

public static A096907Inst Instance=new A096907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096908
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,6L,4L,10L,5L,9L,12L,10L,6L,6L,11L,13L,8L,5L,13L,14L,6L,15L,12L,14L,10L,14L,10L,7L,16L,12L,16L,18L,21L,14L,6L,20L,20L,16L,17L,8L,7L,8L,18L,17L,18L,10L,24L,21L,24L,8L,22L,22L,26L,14L,19L,14L,24L,24L,24L,24L,12L,25L,30L,18L,18L,7L,9L,28L,28L,20L,16L,19L,8L,27L,21L,27L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096908Inst : IEnumerable<long>
{
public static readonly long[] Value=A096908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096908.Bytes);
public long this[int i]=>Value[i];

public static A096908Inst Instance=new A096908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096909
{
public static readonly long[] Value={ 2L,6L,7L,8L,7L,9L,12L,11L,14L,12L,12L,15L,17L,18L,16L,16L,19L,20L,18L,18L,22L,16L,20L,22L,23L,23L,25L,26L,21L,24L,24L,21L,22L,27L,30L,20L,25L,28L,28L,31L,32L,32L,26L,30L,30L,33L,27L,28L,28L,36L,26L,29L,29L,34L,34L,35L,24L,31L,32L,33L,39L,30L,30L,38L,39L,42L,42L,29L,35L,37L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096909Inst : IEnumerable<long>
{
public static readonly long[] Value=A096909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096909.Bytes);
public long this[int i]=>Value[i];

public static A096909Inst Instance=new A096909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096910
{
public static readonly long[] Value={ 3L,7L,9L,9L,11L,11L,13L,15L,15L,17L,17L,19L,19L,19L,21L,21L,21L,21L,23L,23L,23L,25L,25L,27L,27L,27L,27L,27L,29L,29L,29L,31L,31L,31L,31L,33L,33L,33L,33L,33L,33L,33L,35L,35L,35L,35L,37L,37L,37L,37L,39L,39L,39L,39L,39L,39L,41L,41L,41L,41L,41L,43L,43L,43L,43L,43L,43L,45L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096910Inst : IEnumerable<long>
{
public static readonly long[] Value=A096910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096910.Bytes);
public long this[int i]=>Value[i];

public static A096910Inst Instance=new A096910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096911
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,8L,10L,11L,13L,15L,18L,20L,23L,26L,30L,34L,38L,43L,49L,55L,61L,69L,77L,86L,95L,106L,118L,131L,144L,160L,177L,195L,214L,236L,260L,285L,312L,342L,375L,410L,447L,488L,534L,581L,632L,688L,749L,813L,882L,957L,1039L,1125L,1217L,1317L,1426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096911Inst : IEnumerable<long>
{
public static readonly long[] Value=A096911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096911.Bytes);
public long this[int i]=>Value[i];

public static A096911Inst Instance=new A096911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096912
{
public static readonly long[] Value={ 8L,16L,20L,62L,64L,76L,100L,142L,230L,670L,2230L,167644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096912Inst : IEnumerable<long>
{
public static readonly long[] Value=A096912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096912.Bytes);
public long this[int i]=>Value[i];

public static A096912Inst Instance=new A096912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096913
{
public static readonly long[] Value={ 0L,13L,72L,80L,91L,120L,137L,163L,188L,251L,275L,281L,317L,321L,360L,388L,391L,440L,495L,527L,627L,840L,891L,960L,1023L,1088L,1148L,1151L,1288L,1363L,1437L,1520L,1591L,1674L,1680L,1757L,1841L,1927L,2024L,2113L,2208L,2303L,2365L,2400L,2464L,2491L,2565L,2600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096913Inst : IEnumerable<long>
{
public static readonly long[] Value=A096913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096913.Bytes);
public long this[int i]=>Value[i];

public static A096913Inst Instance=new A096913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096914
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,17L,25L,36L,50L,69L,93L,124L,163L,212L,273L,349L,442L,556L,695L,863L,1066L,1310L,1602L,1950L,2364L,2854L,3433L,4115L,4916L,5854L,6951L,8229L,9716L,11442L,13441L,15752L,18419L,21490L,25021L,29074L,33718L,39031L,45101L,52024L,59910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096914Inst : IEnumerable<long>
{
public static readonly long[] Value=A096914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096914.Bytes);
public long this[int i]=>Value[i];

public static A096914Inst Instance=new A096914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096915
{
public static readonly long[] Value={ 3L,3L,7L,3L,3L,7L,3L,3L,7L,3L,3L,7L,7L,23L,7L,3L,3L,11L,3L,11L,11L,3L,3L,11L,7L,3L,7L,3L,3L,7L,3L,17L,7L,7L,3L,7L,3L,3L,7L,13L,11L,11L,3L,3L,7L,3L,23L,7L,19L,3L,13L,3L,23L,7L,7L,3L,7L,7L,3L,7L,3L,11L,11L,3L,3L,19L,3L,3L,11L,13L,29L,7L,3L,3L,7L,43L,3L,7L,7L,11L,11L,3L,11L,19L,3L,3L,7L,3L,23L,7L,37L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096915Inst : IEnumerable<long>
{
public static readonly long[] Value=A096915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096915.Bytes);
public long this[int i]=>Value[i];

public static A096915Inst Instance=new A096915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096948
{
public static readonly long[] Value={ 1L,3L,9L,6L,18L,36L,10L,30L,60L,100L,15L,45L,90L,150L,225L,21L,63L,126L,210L,315L,441L,28L,84L,168L,280L,420L,588L,784L,36L,108L,216L,360L,540L,756L,1008L,1296L,45L,135L,270L,450L,675L,945L,1260L,1620L,2025L,55L,165L,330L,550L,825L,1155L,1540L,1980L,2475L,3025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096948Inst : IEnumerable<long>
{
public static readonly long[] Value=A096948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096948.Bytes);
public long this[int i]=>Value[i];

public static A096948Inst Instance=new A096948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096949
{
public static readonly BigInteger[] Value={ 1L,28L,421L,26528L,2148803L,7878956L,2765513941L,74668877408L,3808112752813L,651187280816108L,2511722368895123L,173308843453994432L,7798897955430811787L,BigInteger.Parse("1895132203169713822916"),BigInteger.Parse("54958833891921780540589") };
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
public class A096949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096949Inst Instance=new A096949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096950
{
public static readonly BigInteger[] Value={ 1L,27L,405L,25515L,2066715L,7577955L,2659862205L,71816279535L,3662630256285L,626309773824735L,2415766270466835L,166687872662211615L,7500954269799522675L,BigInteger.Parse("1822731887561284010025"),BigInteger.Parse("52859224739277236290725") };
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
public class A096950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096950Inst Instance=new A096950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096951
{
public static readonly long[] Value={ 1L,7L,55L,463L,4039L,35839L,320503L,2876335L,25854247L,232557151L,2092490071L,18830313487L,169464432775L,1525146340543L,13726182847159L,123535108753519L,1111813831298023L,10006315891747615L,90056808665990167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096951Inst : IEnumerable<long>
{
public static readonly long[] Value=A096951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096951.Bytes);
public long this[int i]=>Value[i];

public static A096951Inst Instance=new A096951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096952
{
public static readonly long[] Value={ 1L,7L,11L,463L,4039L,35839L,320503L,575267L,25854247L,232557151L,298927153L,18830313487L,6778577311L,1525146340543L,13726182847159L,123535108753519L,1111813831298023L,2001263178349523L,90056808665990167L,810511140554958031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096952Inst : IEnumerable<long>
{
public static readonly long[] Value=A096952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096952.Bytes);
public long this[int i]=>Value[i];

public static A096952Inst Instance=new A096952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096953
{
public static readonly BigInteger[] Value={ 1L,108L,1296L,326592L,15116544L,665127936L,28298170368L,235092492288L,47958868426752L,1929639176699904L,10968475320188928L,3027299188372144128L,4738381338321616896L,BigInteger.Parse("4605706660848611622912"),BigInteger.Parse("178087324219479649419264"),BigInteger.Parse("6853291511342734094893056") };
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
public class A096953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096953Inst Instance=new A096953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096954
{
public static readonly BigInteger[] Value={ 951L,1339849258L,9569810428334921L,BigInteger.Parse("19132121777295048135244"),BigInteger.Parse("81963468350564671450762204559"),BigInteger.Parse("1287504688596138051498743351405666674"),BigInteger.Parse("23901655485793371607250742363386659018053931") };
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
public class A096954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096954Inst Instance=new A096954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096955
{
public static readonly BigInteger[] Value={ 1195L,1706489875L,12184551018734375L,BigInteger.Parse("24359780855939418203125"),BigInteger.Parse("104359128170408663038552734375"),BigInteger.Parse("1639301884061026141391921953564453125"),BigInteger.Parse("30432532948821209122295591520605416259765625") };
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
public class A096955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096955Inst Instance=new A096955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096956
{
public static readonly long[] Value={ 6L,1L,6L,1L,7L,6L,1L,8L,13L,6L,1L,9L,21L,19L,6L,1L,10L,30L,40L,25L,6L,1L,11L,40L,70L,65L,31L,6L,1L,12L,51L,110L,135L,96L,37L,6L,1L,13L,63L,161L,245L,231L,133L,43L,6L,1L,14L,76L,224L,406L,476L,364L,176L,49L,6L,1L,15L,90L,300L,630L,882L,840L,540L,225L,55L,6L,1L,16L,105L,390L,930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096956Inst : IEnumerable<long>
{
public static readonly long[] Value=A096956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096956.Bytes);
public long this[int i]=>Value[i];

public static A096956Inst Instance=new A096956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096957
{
public static readonly long[] Value={ 6L,19L,40L,70L,110L,161L,224L,300L,390L,495L,616L,754L,910L,1085L,1280L,1496L,1734L,1995L,2280L,2590L,2926L,3289L,3680L,4100L,4550L,5031L,5544L,6090L,6670L,7285L,7936L,8624L,9350L,10115L,10920L,11766L,12654L,13585L,14560L,15580L,16646L,17759L,18920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096957Inst : IEnumerable<long>
{
public static readonly long[] Value=A096957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096957.Bytes);
public long this[int i]=>Value[i];

public static A096957Inst Instance=new A096957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096958
{
public static readonly long[] Value={ 6L,25L,65L,135L,245L,406L,630L,930L,1320L,1815L,2431L,3185L,4095L,5180L,6460L,7956L,9690L,11685L,13965L,16555L,19481L,22770L,26450L,30550L,35100L,40131L,45675L,51765L,58435L,65720L,73656L,82280L,91630L,101745L,112665L,124431L,137085L,150670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096958Inst : IEnumerable<long>
{
public static readonly long[] Value=A096958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096958.Bytes);
public long this[int i]=>Value[i];

public static A096958Inst Instance=new A096958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096959
{
public static readonly long[] Value={ 6L,31L,96L,231L,476L,882L,1512L,2442L,3762L,5577L,8008L,11193L,15288L,20468L,26928L,34884L,44574L,56259L,70224L,86779L,106260L,129030L,155480L,186030L,221130L,261261L,306936L,358701L,417136L,482856L,556512L,638792L,730422L,832167L,944832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096959Inst : IEnumerable<long>
{
public static readonly long[] Value=A096959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096959.Bytes);
public long this[int i]=>Value[i];

public static A096959Inst Instance=new A096959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096960
{
public static readonly long[] Value={ 1L,32L,244L,1024L,3126L,7808L,16808L,32768L,59293L,100032L,161052L,249856L,371294L,537856L,762744L,1048576L,1419858L,1897376L,2476100L,3201024L,4101152L,5153664L,6436344L,7995392L,9768751L,11881408L,14408200L,17211392L,20511150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096960Inst : IEnumerable<long>
{
public static readonly long[] Value=A096960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096960.Bytes);
public long this[int i]=>Value[i];

public static A096960Inst Instance=new A096960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096961
{
public static readonly long[] Value={ 1L,128L,2188L,16384L,78126L,280064L,823544L,2097152L,4785157L,10000128L,19487172L,35848192L,62748518L,105413632L,170939688L,268435456L,410338674L,612500096L,893871740L,1280016384L,1801914272L,2494358016L,3404825448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096961Inst : IEnumerable<long>
{
public static readonly long[] Value=A096961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096961.Bytes);
public long this[int i]=>Value[i];

public static A096961Inst Instance=new A096961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096962
{
public static readonly long[] Value={ 1L,512L,19684L,262144L,1953126L,10078208L,40353608L,134217728L,387440173L,1000000512L,2357947692L,5160042496L,10604499374L,20661047296L,38445332184L,68719476736L,118587876498L,198369368576L,322687697780L,512000262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096962Inst : IEnumerable<long>
{
public static readonly long[] Value=A096962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096962.Bytes);
public long this[int i]=>Value[i];

public static A096962Inst Instance=new A096962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096963
{
public static readonly long[] Value={ 1L,2048L,177148L,4194304L,48828126L,362799104L,1977326744L,8589934592L,31381236757L,100000002048L,285311670612L,743012564992L,1792160394038L,4049565171712L,8649804864648L,17592186044416L,34271896307634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096963Inst : IEnumerable<long>
{
public static readonly long[] Value=A096963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096963.Bytes);
public long this[int i]=>Value[i];

public static A096963Inst Instance=new A096963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096980
{
public static readonly long[] Value={ 1L,5L,17L,69L,257L,997L,3793L,14565L,55681L,213317L,816401L,3126021L,11966849L,45815845L,175399633L,671510181L,2570817793L,9842206853L,37680138257L,144255724485L,552272416769L,2114334904933L,8094576727249L,30989497789029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096980Inst : IEnumerable<long>
{
public static readonly long[] Value=A096980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096980.Bytes);
public long this[int i]=>Value[i];

public static A096980Inst Instance=new A096980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096981
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,6L,7L,10L,12L,15L,21L,25L,30L,39L,46L,56L,72L,85L,101L,125L,147L,175L,215L,252L,296L,356L,415L,487L,582L,676L,786L,927L,1072L,1244L,1460L,1682L,1939L,2255L,2588L,2976L,3446L,3942L,4510L,5189L,5916L,6751L,7739L,8797L,9999L,11406L,12927L,14657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096981Inst : IEnumerable<long>
{
public static readonly long[] Value=A096981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096981.Bytes);
public long this[int i]=>Value[i];

public static A096981Inst Instance=new A096981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096982
{
public static readonly long[] Value={ 0L,4L,9L,7L,21L,25L,17L,13L,25L,61L,11L,25L,29L,49L,41L,25L,37L,25L,19L,61L,17L,31L,49L,25L,101L,85L,73L,49L,15L,121L,31L,49L,41L,37L,81L,25L,77L,19L,57L,61L,41L,49L,89L,31L,121L,49L,33L,25L,113L,301L,73L,85L,109L,73L,21L,49L,73L,43L,59L,121L,61L,31L,49L,97L,141L,121L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096982Inst : IEnumerable<long>
{
public static readonly long[] Value=A096982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096982.Bytes);
public long this[int i]=>Value[i];

public static A096982Inst Instance=new A096982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096983
{
public static readonly long[] Value={ 23L,233L,7L,73L,11L,4801L,11L,17L,13L,19L,17L,337L,17L,23L,19L,31L,23L,151L,23L,29L,29L,31L,29L,73L,29L,41L,31L,37L,37L,619L,37L,41L,37L,43L,41L,61L,41L,47L,43L,61L,47L,67L,47L,53L,53L,61L,53L,73L,53L,59L,59L,61L,59L,79L,59L,71L,61L,67L,67L,109L,67L,71L,67L,73L,71L,101L,71L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096983Inst : IEnumerable<long>
{
public static readonly long[] Value=A096983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096983.Bytes);
public long this[int i]=>Value[i];

public static A096983Inst Instance=new A096983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096984
{
public static readonly long[] Value={ 2L,0L,4L,5L,96L,427L,6448L,56961L,892720L,11905091L,211153944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096984Inst : IEnumerable<long>
{
public static readonly long[] Value=A096984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096984.Bytes);
public long this[int i]=>Value[i];

public static A096984Inst Instance=new A096984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096985
{
public static readonly long[] Value={ 3L,5L,8L,10L,12L,13L,23L,26L,30L,33L,38L,114L,162L,219L,265L,268L,277L,344L,463L,651L,877L,1128L,2466L,2594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096985Inst : IEnumerable<long>
{
public static readonly long[] Value=A096985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096985.Bytes);
public long this[int i]=>Value[i];

public static A096985Inst Instance=new A096985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096986
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,23L,29L,30L,31L,40L,164L,176L,189L,218L,370L,597L,603L,1473L,1901L,2176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096986Inst : IEnumerable<long>
{
public static readonly long[] Value=A096986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096986.Bytes);
public long this[int i]=>Value[i];

public static A096986Inst Instance=new A096986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096987
{
public static readonly BigInteger[] Value={ 0L,1L,5L,73L,2221L,353777L,19595573L,239046803L,198972350083L,1535302297058707L,100536661265514127L,BigInteger.Parse("8974880059175708288297"),BigInteger.Parse("818810519369821323965929237"),BigInteger.Parse("990666575600755815615137883006341") };
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
public class A096987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096987.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096987Inst Instance=new A096987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096988
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,13L,15L,16L,20L,21L,23L,24L,25L,26L,28L,30L,33L,36L,42L,44L,46L,50L,66L,157L,169L,203L,215L,237L,241L,245L,255L,256L,261L,272L,275L,287L,303L,305L,314L,316L,320L,325L,338L,340L,344L,347L,367L,369L,375L,384L,385L,392L,393L,404L,406L,408L,429L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096988Inst : IEnumerable<long>
{
public static readonly long[] Value=A096988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096988.Bytes);
public long this[int i]=>Value[i];

public static A096988Inst Instance=new A096988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096989
{
public static readonly long[] Value={ 5L,7L,8L,9L,10L,11L,12L,14L,18L,22L,37L,43L,49L,51L,53L,57L,61L,63L,64L,65L,67L,68L,71L,73L,74L,76L,77L,79L,80L,81L,83L,85L,86L,87L,89L,91L,93L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,116L,117L,119L,120L,121L,122L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096989Inst : IEnumerable<long>
{
public static readonly long[] Value=A096989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096989.Bytes);
public long this[int i]=>Value[i];

public static A096989Inst Instance=new A096989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096990
{
public static readonly long[] Value={ 17L,19L,27L,29L,31L,32L,34L,35L,38L,39L,40L,41L,45L,47L,48L,52L,54L,55L,56L,58L,59L,60L,62L,69L,70L,72L,75L,78L,82L,84L,88L,90L,92L,94L,100L,110L,118L,132L,138L,150L,1057L,1117L,1153L,1201L,1237L,1241L,1261L,1271L,1301L,1313L,1321L,1333L,1349L,1351L,1359L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096990Inst : IEnumerable<long>
{
public static readonly long[] Value=A096990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096990.Bytes);
public long this[int i]=>Value[i];

public static A096990Inst Instance=new A096990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096991
{
public static readonly long[] Value={ 401L,451L,489L,491L,505L,513L,567L,577L,629L,631L,652L,661L,673L,679L,685L,691L,713L,731L,737L,751L,757L,769L,773L,791L,802L,808L,811L,817L,825L,829L,833L,847L,851L,853L,859L,867L,869L,871L,873L,877L,889L,893L,899L,901L,902L,907L,911L,917L,919L,923L,931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096991Inst : IEnumerable<long>
{
public static readonly long[] Value=A096991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096991.Bytes);
public long this[int i]=>Value[i];

public static A096991Inst Instance=new A096991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096992
{
public static readonly long[] Value={ 883L,985L,1009L,1025L,1037L,1051L,1067L,1073L,1141L,1145L,1147L,1159L,1199L,1203L,1205L,1217L,1249L,1267L,1285L,1291L,1297L,1303L,1309L,1343L,1345L,1353L,1355L,1361L,1369L,1371L,1373L,1385L,1387L,1417L,1435L,1461L,1463L,1465L,1467L,1471L,1493L,1505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096992Inst : IEnumerable<long>
{
public static readonly long[] Value=A096992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096992.Bytes);
public long this[int i]=>Value[i];

public static A096992Inst Instance=new A096992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096993
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,1L,3L,2L,3L,1L,1L,2L,1L,1L,1L,1L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,2L,3L,3L,3L,3L,1L,2L,1L,3L,1L,3L,3L,2L,1L,2L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,2L,2L,2L,1L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096993Inst : IEnumerable<long>
{
public static readonly long[] Value=A096993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096993.Bytes);
public long this[int i]=>Value[i];

public static A096993Inst Instance=new A096993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096994
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,2L,0L,1L,2L,4L,1L,2L,5L,14L,0L,5L,7L,2L,14L,8L,3L,64L,43L,81L,82L,76L,74L,47L,25L,42L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096994Inst : IEnumerable<long>
{
public static readonly long[] Value=A096994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096994.Bytes);
public long this[int i]=>Value[i];

public static A096994Inst Instance=new A096994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096995
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,3L,3L,1L,2L,3L,5L,2L,3L,6L,15L,1L,6L,8L,3L,15L,9L,4L,65L,44L,82L,83L,77L,75L,48L,26L,43L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096995Inst : IEnumerable<long>
{
public static readonly long[] Value=A096995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096995.Bytes);
public long this[int i]=>Value[i];

public static A096995Inst Instance=new A096995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097028
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,1L,2L,2L,2L,3L,3L,4L,1L,1L,5L,2L,5L,3L,2L,2L,4L,4L,2L,3L,4L,4L,6L,4L,3L,1L,4L,5L,5L,4L,4L,5L,23L,5L,4L,5L,22L,6L,2L,2L,24L,6L,25L,3L,3L,4L,23L,3L,21L,5L,2L,3L,21L,3L,25L,26L,21L,1L,6L,24L,20L,25L,23L,22L,27L,4L,26L,27L,36L,28L,35L,22L,33L,5L,30L,31L,20L,25L,28L,29L,20L,26L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097028Inst : IEnumerable<long>
{
public static readonly long[] Value=A097028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097028.Bytes);
public long this[int i]=>Value[i];

public static A097028Inst Instance=new A097028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097029
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,15L,16L,32L,64L,128L,255L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65535L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,83623935L,134217728L,268435456L,536870912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097029Inst : IEnumerable<long>
{
public static readonly long[] Value=A097029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097029.Bytes);
public long this[int i]=>Value[i];

public static A097029Inst Instance=new A097029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097030
{
public static readonly long[] Value={ 2418L,2958L,3522L,3534L,3582L,3774L,3906L,3954L,3966L,3978L,4146L,4158L,4434L,4446L,24180L,29580L,35220L,35238L,35340L,35820L,37740L,38682L,39060L,39540L,39660L,39780L,41460L,41580L,44340L,44460L,45402L,49878L,65190L,65322L,74430L,74610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097030Inst : IEnumerable<long>
{
public static readonly long[] Value=A097030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097030.Bytes);
public long this[int i]=>Value[i];

public static A097030Inst Instance=new A097030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097031
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097031Inst : IEnumerable<long>
{
public static readonly long[] Value=A097031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097031.Bytes);
public long this[int i]=>Value[i];

public static A097031Inst Instance=new A097031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097032
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,1L,3L,3L,3L,4L,3L,4L,3L,5L,4L,3L,3L,5L,3L,5L,4L,6L,3L,5L,3L,4L,3L,5L,3L,3L,3L,3L,5L,6L,4L,6L,3L,7L,4L,6L,3L,3L,3L,4L,5L,5L,3L,6L,3L,6L,5L,6L,3L,3L,4L,4L,4L,4L,3L,1L,3L,7L,4L,3L,4L,3L,3L,7L,4L,8L,3L,6L,3L,7L,4L,6L,4L,2L,3L,7L,3L,5L,3L,7L,4L,6L,6L,6L,3L,1L,5L,6L,5L,7L,4L,7L,3L,7L,5L,4L,3L,3L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097032Inst : IEnumerable<long>
{
public static readonly long[] Value=A097032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097032.Bytes);
public long this[int i]=>Value[i];

public static A097032Inst Instance=new A097032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097033
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,0L,2L,2L,2L,3L,2L,3L,2L,4L,3L,2L,2L,4L,2L,4L,3L,5L,2L,4L,2L,3L,2L,4L,2L,0L,2L,2L,4L,5L,3L,5L,2L,6L,3L,5L,2L,0L,2L,3L,4L,4L,2L,5L,2L,5L,4L,5L,2L,0L,3L,3L,3L,3L,2L,0L,2L,6L,3L,2L,3L,2L,2L,6L,3L,7L,2L,5L,2L,6L,3L,5L,3L,1L,2L,6L,2L,4L,2L,6L,3L,5L,5L,5L,2L,0L,4L,5L,4L,6L,3L,6L,2L,6L,4L,1L,2L,1L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097033Inst : IEnumerable<long>
{
public static readonly long[] Value=A097033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097033.Bytes);
public long this[int i]=>Value[i];

public static A097033Inst Instance=new A097033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097034
{
public static readonly long[] Value={ 1506L,1518L,1806L,1902L,1914L,1938L,1950L,2226L,2382L,2394L,2406L,2418L,2478L,2826L,2910L,2946L,2958L,3234L,3282L,3294L,3330L,3510L,3522L,3534L,3546L,3582L,3642L,3654L,3774L,3906L,3954L,3966L,3978L,4146L,4158L,4194L,4434L,4446L,4854L,4866L,4878L,5262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097034Inst : IEnumerable<long>
{
public static readonly long[] Value=A097034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097034.Bytes);
public long this[int i]=>Value[i];

public static A097034Inst Instance=new A097034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097035
{
public static readonly long[] Value={ 570L,870L,1230L,1290L,1326L,1482L,1530L,1686L,1698L,1710L,1794L,1866L,1878L,1890L,2058L,2070L,2142L,2154L,2166L,2178L,2238L,2250L,2502L,2802L,2814L,3042L,3222L,3630L,3702L,3714L,3726L,4350L,4494L,4506L,4518L,4914L,5010L,5142L,5154L,5166L,5284L,5418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097035Inst : IEnumerable<long>
{
public static readonly long[] Value=A097035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097035.Bytes);
public long this[int i]=>Value[i];

public static A097035Inst Instance=new A097035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097036
{
public static readonly long[] Value={ 30L,42L,54L,100L,140L,148L,194L,196L,208L,220L,238L,252L,274L,288L,300L,336L,348L,350L,364L,374L,380L,382L,386L,400L,420L,440L,492L,516L,528L,540L,542L,550L,592L,600L,612L,660L,694L,708L,720L,722L,740L,756L,758L,764L,766L,780L,792L,794L,820L,836L,900L,932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097036Inst : IEnumerable<long>
{
public static readonly long[] Value=A097036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097036.Bytes);
public long this[int i]=>Value[i];

public static A097036Inst Instance=new A097036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097037
{
public static readonly long[] Value={ 102L,114L,126L,388L,436L,484L,812L,866L,1020L,1036L,1040L,1116L,1140L,1196L,1260L,1380L,1500L,1524L,1532L,1552L,1618L,1644L,1716L,1724L,1726L,1744L,1916L,2020L,2066L,2068L,2324L,2368L,2386L,2486L,2592L,2684L,2880L,2924L,3032L,3098L,3120L,3124L,3136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097037Inst : IEnumerable<long>
{
public static readonly long[] Value=A097037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097037.Bytes);
public long this[int i]=>Value[i];

public static A097037Inst Instance=new A097037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097038
{
public static readonly long[] Value={ 0L,1L,1L,5L,7L,21L,35L,85L,155L,341L,651L,1365L,2667L,5461L,10795L,21845L,43435L,87381L,174251L,349525L,698027L,1398101L,2794155L,5592405L,11180715L,22369621L,44731051L,89478485L,178940587L,357913941L,715795115L,1431655765L,2863245995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097038Inst : IEnumerable<long>
{
public static readonly long[] Value=A097038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097038.Bytes);
public long this[int i]=>Value[i];

public static A097038Inst Instance=new A097038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097039
{
public static readonly long[] Value={ 0L,1L,7L,19L,47L,102L,210L,413L,789L,1473L,2703L,4892L,8756L,15529L,27331L,47791L,83103L,143810L,247814L,425445L,727985L,1241981L,2113247L,3587064L,6075432L,10269457L,17326975L,29185483L,49083599L,82429278L,138244218L,231565037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097039Inst : IEnumerable<long>
{
public static readonly long[] Value=A097039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097039.Bytes);
public long this[int i]=>Value[i];

public static A097039Inst Instance=new A097039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097040
{
public static readonly long[] Value={ 0L,0L,2L,8L,26L,76L,212L,576L,1542L,4092L,10802L,28424L,74648L,195808L,513242L,1344672L,3521994L,9223284L,24151052L,63235040L,165562430L,433465780L,1134856802L,2971140048L,7778620656L,20364814656L,53315973362L,139583348216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097040Inst : IEnumerable<long>
{
public static readonly long[] Value=A097040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097040.Bytes);
public long this[int i]=>Value[i];

public static A097040Inst Instance=new A097040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097041
{
public static readonly long[] Value={ 1L,1L,1L,10L,10L,19L,100L,109L,271L,1009L,1252L,3448L,10333L,14716L,41365L,107713L,173809L,479998L,1143226L,2044279L,5463208L,12333313L,23861719L,61502185L,134861536L,276257656L,688381201L,1490011480L,3174700105L,7685442289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097041Inst : IEnumerable<long>
{
public static readonly long[] Value=A097041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097041.Bytes);
public long this[int i]=>Value[i];

public static A097041Inst Instance=new A097041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097042
{
public static readonly long[] Value={ 1L,2L,0L,4L,2L,4L,4L,8L,8L,10L,12L,16L,20L,24L,28L,36L,42L,48L,60L,72L,84L,100L,116L,136L,160L,186L,216L,252L,292L,336L,388L,448L,512L,588L,672L,768L,878L,1000L,1136L,1292L,1464L,1656L,1876L,2120L,2388L,2696L,3032L,3408L,3832L,4298L,4816L,5396L,6036L,6744L,7532L,8404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097042Inst : IEnumerable<long>
{
public static readonly long[] Value=A097042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097042.Bytes);
public long this[int i]=>Value[i];

public static A097042Inst Instance=new A097042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097043
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,13L,14L,15L,16L,17L,18L,19L,20L,21L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097043Inst : IEnumerable<long>
{
public static readonly long[] Value=A097043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097043.Bytes);
public long this[int i]=>Value[i];

public static A097043Inst Instance=new A097043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097076
{
public static readonly long[] Value={ 0L,1L,1L,4L,8L,21L,49L,120L,288L,697L,1681L,4060L,9800L,23661L,57121L,137904L,332928L,803761L,1940449L,4684660L,11309768L,27304197L,65918161L,159140520L,384199200L,927538921L,2239277041L,5406093004L,13051463048L,31509019101L,76069501249L,183648021600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097076Inst : IEnumerable<long>
{
public static readonly long[] Value=A097076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097076.Bytes);
public long this[int i]=>Value[i];

public static A097076Inst Instance=new A097076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097077
{
public static readonly BigInteger[] Value={ 111111L,10101010101L,1001001001001001L,BigInteger.Parse("100010001000100010001"),BigInteger.Parse("10000100001000010000100001"),BigInteger.Parse("100000010000001000000100000010000001"),BigInteger.Parse("10000000100000001000000010000000100000001") };
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
public class A097077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097077Inst Instance=new A097077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097078
{
public static readonly long[] Value={ 5L,2L,3L,5L,2L,1L,7L,0L,0L,0L,1L,7L,9L,9L,9L,2L,6L,6L,8L,0L,0L,5L,3L,4L,4L,0L,4L,8L,0L,6L,1L,0L,9L,7L,4L,1L,0L,1L,7L,2L,1L,3L,9L,8L,4L,8L,8L,5L,3L,1L,5L,7L,2L,7L,1L,7L,7L,7L,9L,6L,5L,7L,6L,6L,2L,6L,8L,4L,0L,9L,1L,5L,2L,1L,1L,9L,6L,6L,3L,8L,5L,5L,9L,1L,8L,0L,5L,2L,5L,6L,4L,1L,0L,2L,5L,9L,7L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097078Inst : IEnumerable<long>
{
public static readonly long[] Value=A097078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097078.Bytes);
public long this[int i]=>Value[i];

public static A097078Inst Instance=new A097078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097079
{
public static readonly long[] Value={ 8L,3L,8L,2L,0L,6L,0L,3L,1L,9L,9L,2L,9L,2L,0L,5L,5L,9L,6L,9L,1L,4L,1L,8L,5L,9L,7L,3L,4L,9L,0L,9L,6L,9L,5L,2L,6L,6L,6L,9L,6L,7L,1L,7L,1L,0L,2L,8L,4L,5L,5L,6L,8L,3L,8L,0L,1L,1L,1L,6L,6L,1L,9L,0L,5L,8L,0L,7L,3L,3L,3L,4L,0L,1L,6L,0L,2L,0L,4L,2L,4L,0L,3L,3L,1L,5L,1L,8L,6L,3L,3L,3L,7L,2L,0L,7L,0L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097079Inst : IEnumerable<long>
{
public static readonly long[] Value=A097079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097079.Bytes);
public long this[int i]=>Value[i];

public static A097079Inst Instance=new A097079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097080
{
public static readonly long[] Value={ 3L,7L,15L,27L,43L,63L,87L,115L,147L,183L,223L,267L,315L,367L,423L,483L,547L,615L,687L,763L,843L,927L,1015L,1107L,1203L,1303L,1407L,1515L,1627L,1743L,1863L,1987L,2115L,2247L,2383L,2523L,2667L,2815L,2967L,3123L,3283L,3447L,3615L,3787L,3963L,4143L,4327L,4515L,4707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097080Inst : IEnumerable<long>
{
public static readonly long[] Value=A097080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097080.Bytes);
public long this[int i]=>Value[i];

public static A097080Inst Instance=new A097080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097081
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,11L,31L,71L,145L,289L,601L,1321L,2979L,6683L,14743L,32111L,69697L,151777L,332113L,728689L,1598883L,3503627L,7668079L,16774775L,36704017L,80343361L,175916521L,385196761L,843365379L,1846290395L,4041672871L,8847607391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097081Inst : IEnumerable<long>
{
public static readonly long[] Value=A097081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097081.Bytes);
public long this[int i]=>Value[i];

public static A097081Inst Instance=new A097081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097082
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,2L,1L,4L,4L,20L,4L,5L,1L,20L,24L,8L,96L,200L,24L,4L,25L,1L,3L,200L,48L,288L,48L,64L,2304L,1600L,10800L,288L,432L,8L,675L,650L,1L,26L,9L,10400L,1600L,576L,2304L,23040L,576L,2560L,1024L,368640L,516096L,128000L,2240000L,5832000L,32256L,2304L,46656L,64L,96L,91125L,3750L,84500L,6L,1L,676L,9L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097082Inst : IEnumerable<long>
{
public static readonly long[] Value=A097082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097082.Bytes);
public long this[int i]=>Value[i];

public static A097082Inst Instance=new A097082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097083
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,15L,24L,39L,64L,104L,168L,272L,441L,714L,1155L,1869L,3025L,4895L,7920L,12815L,20736L,33552L,54288L,87840L,142129L,229970L,372099L,602069L,974169L,1576239L,2550408L,4126647L,6677056L,10803704L,17480760L,28284464L,45765225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097083Inst : IEnumerable<long>
{
public static readonly long[] Value=A097083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097083.Bytes);
public long this[int i]=>Value[i];

public static A097083Inst Instance=new A097083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097084
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,4L,10L,10L,1L,1L,5L,18L,28L,17L,1L,1L,6L,27L,74L,69L,26L,1L,1L,7L,39L,137L,245L,151L,37L,1L,1L,8L,52L,236L,586L,676L,298L,50L,1L,1L,9L,68L,372L,1194L,2126L,1634L,540L,65L,1L,1L,10L,85L,552L,2322L,5152L,6620L,3578L,913L,82L,1L,1L,11L,105L,777L,3954L,12002L,19292L,18082L,7249L,1459L,101L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097084Inst : IEnumerable<long>
{
public static readonly long[] Value=A097084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097084.Bytes);
public long this[int i]=>Value[i];

public static A097084Inst Instance=new A097084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097085
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L,70L,204L,618L,1908L,6010L,19316L,63034L,208210L,695594L,2346748L,7983450L,27364842L,94439262L,327922692L,1145029314L,4018618374L,14169874350L,50179643628L,178410716622L,636679332588L,2279906714610L,8190512723940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097085Inst : IEnumerable<long>
{
public static readonly long[] Value=A097085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097085.Bytes);
public long this[int i]=>Value[i];

public static A097085Inst Instance=new A097085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097086
{
public static readonly BigInteger[] Value={ 0L,1L,1L,0L,1L,-5L,9L,287L,-4455L,84249L,-284515L,-35428349L,814639275L,-3434408341L,-1338006522699L,6133774365735L,413520124707781L,-45122925184812203L,-231704968682873565L,BigInteger.Parse("102526632234397695073"),BigInteger.Parse("-2030875572224787003585"),BigInteger.Parse("-76894817276627723872401") };
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
public class A097086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097086Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097086.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097086Inst Instance=new A097086Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}