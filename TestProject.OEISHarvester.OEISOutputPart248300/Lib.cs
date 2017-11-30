using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A072043
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,3L,8L,60L,1728L,967680L,114661785600L,BigInteger.Parse("215698302044209000000"),BigInteger.Parse("26592225368515593301597083402240000000"),BigInteger.Parse("723457119656730571214801208759677424070060705650559470796800000000000") };
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
public class A072043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072043Inst Instance=new A072043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072044
{
public static readonly BigInteger[] Value={ 4L,3L,25L,1225L,29645L,715715L,206841635L,14933966047L,718188003533L,86285158710179L,82920037520482019L,5974606913975783369L,BigInteger.Parse("10043314222393291843289"),BigInteger.Parse("1688189817927745147112851") };
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
public class A072044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072044Inst Instance=new A072044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072045
{
public static readonly BigInteger[] Value={ 3L,2L,16L,768L,18432L,442368L,127401984L,9172942848L,440301256704L,52836150804480L,50722704772300800L,3652034743605657600L,BigInteger.Parse("6135418369257504768000"),BigInteger.Parse("1030750286035260801024000"),BigInteger.Parse("98952027459385036898304000"),BigInteger.Parse("21373637931227167970033664000") };
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
public class A072045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072045.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072045Inst Instance=new A072045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072046
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,2L,3L,4L,1L,144L,1L,4L,45L,32L,1L,72L,1L,320L,63L,4L,1L,82944L,125L,4L,729L,448L,1L,162000L,1L,32768L,99L,4L,1225L,3359232L,1L,4L,117L,2560000L,1L,63504L,1L,704L,91125L,4L,1L,254803968L,343L,125000L,153L,832L,1L,8503056L,3025L,9834496L,171L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072046Inst : IEnumerable<long>
{
public static readonly long[] Value=A072046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072046.Bytes);
public long this[int i]=>Value[i];

public static A072046Inst Instance=new A072046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072047
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,2L,2L,1L,3L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,3L,1L,2L,3L,1L,1L,2L,2L,3L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,3L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,2L,2L,2L,2L,1L,2L,3L,1L,2L,2L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072047Inst : IEnumerable<long>
{
public static readonly long[] Value=A072047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072047.Bytes);
public long this[int i]=>Value[i];

public static A072047Inst Instance=new A072047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072048
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,4L,2L,8L,2L,4L,4L,4L,2L,4L,4L,2L,8L,2L,4L,2L,4L,2L,4L,4L,4L,2L,2L,4L,4L,8L,2L,4L,8L,2L,2L,4L,4L,8L,2L,4L,2L,4L,4L,4L,2L,4L,4L,4L,4L,2L,2L,8L,2L,8L,4L,2L,2L,8L,4L,2L,8L,4L,4L,4L,4L,4L,2L,4L,8L,2L,4L,4L,2L,8L,2L,4L,4L,4L,4L,4L,2L,2L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072048Inst : IEnumerable<long>
{
public static readonly long[] Value=A072048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072048.Bytes);
public long this[int i]=>Value[i];

public static A072048Inst Instance=new A072048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072049
{
public static readonly long[] Value={ 2L,4L,8L,16L,32L,64L,128L,256L,512L,32L,45L,64L,90L,128L,181L,256L,362L,64L,80L,101L,128L,161L,203L,256L,322L,406L,107L,128L,152L,181L,215L,256L,304L,362L,430L,512L,168L,194L,222L,256L,294L,337L,388L,445L,512L,203L,228L,256L,287L,322L,362L,406L,456L,512L,574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072049Inst : IEnumerable<long>
{
public static readonly long[] Value=A072049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072049.Bytes);
public long this[int i]=>Value[i];

public static A072049Inst Instance=new A072049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072050
{
public static readonly long[] Value={ 7L,18718L,343L,125204947L,231012215L,11298657013L,211066659013L,117088913464607L,2846847905744815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072050Inst : IEnumerable<long>
{
public static readonly long[] Value=A072050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072050.Bytes);
public long this[int i]=>Value[i];

public static A072050Inst Instance=new A072050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072051
{
public static readonly long[] Value={ 11L,121L,1331L,14641L,121110352L,1332213872L,105923336431682L,4676049710123077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072051Inst : IEnumerable<long>
{
public static readonly long[] Value=A072051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072051.Bytes);
public long this[int i]=>Value[i];

public static A072051Inst Instance=new A072051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072484
{
public static readonly long[] Value={ 1L,2L,12L,3L,13L,23L,4L,14L,24L,34L,5L,15L,25L,35L,45L,6L,16L,26L,36L,46L,56L,7L,17L,27L,37L,47L,57L,67L,8L,18L,28L,38L,48L,58L,68L,78L,9L,19L,29L,39L,49L,59L,69L,79L,89L,10L,100L,101L,102L,103L,104L,105L,106L,107L,108L,11L,110L,111L,112L,113L,114L,115L,116L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072484Inst : IEnumerable<long>
{
public static readonly long[] Value=A072484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072484.Bytes);
public long this[int i]=>Value[i];

public static A072484Inst Instance=new A072484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072485
{
public static readonly long[] Value={ 1L,12L,23L,34L,45L,56L,67L,78L,89L,108L,119L,212L,313L,414L,515L,616L,717L,818L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072485Inst : IEnumerable<long>
{
public static readonly long[] Value=A072485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072485.Bytes);
public long this[int i]=>Value[i];

public static A072485Inst Instance=new A072485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072486
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,120L,840L,1680L,5040L,10080L,110880L,221760L,2882880L,5765760L,17297280L,34594560L,588107520L,1176215040L,22348085760L,44696171520L,134088514560L,268177029120L,6168071669760L,12336143339520L,61680716697600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072486Inst : IEnumerable<long>
{
public static readonly long[] Value=A072486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072486.Bytes);
public long this[int i]=>Value[i];

public static A072486Inst Instance=new A072486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072487
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,180L,1260L,5040L,15120L,75600L,831600L,4989600L,64864800L,454053600L,2270268000L,18162144000L,308756448000L,2778808032000L,52797352608000L,527973526080000L,3695814682560000L,40653961508160000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072487Inst : IEnumerable<long>
{
public static readonly long[] Value=A072487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072487.Bytes);
public long this[int i]=>Value[i];

public static A072487Inst Instance=new A072487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072488
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,4L,8L,24L,48L,48L,144L,144L,288L,864L,3456L,3456L,10368L,10368L,41472L,124416L,248832L,248832L,995328L,4976640L,9953280L,29859840L,119439360L,119439360L,597196800L,597196800L,2388787200L,7166361600L,14332723200L,71663616000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072488Inst : IEnumerable<long>
{
public static readonly long[] Value=A072488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072488.Bytes);
public long this[int i]=>Value[i];

public static A072488Inst Instance=new A072488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072489
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,180L,1260L,5040L,15120L,75600L,831600L,3326400L,43243200L,302702400L,1513512000L,6054048000L,102918816000L,617512896000L,11732745024000L,58663725120000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072489Inst : IEnumerable<long>
{
public static readonly long[] Value=A072489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072489.Bytes);
public long this[int i]=>Value[i];

public static A072489Inst Instance=new A072489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072490
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,4L,5L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,11L,12L,12L,13L,14L,15L,15L,15L,16L,16L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,25L,25L,26L,27L,28L,28L,28L,29L,30L,30L,30L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072490Inst : IEnumerable<long>
{
public static readonly long[] Value=A072490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072490.Bytes);
public long this[int i]=>Value[i];

public static A072490Inst Instance=new A072490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072491
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,3L,2L,1L,2L,1L,2L,2L,2L,3L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,3L,2L,1L,2L,2L,2L,3L,2L,1L,2L,1L,2L,2L,2L,3L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,3L,2L,1L,2L,2L,2L,1L,2L,2L,2L,3L,2L,1L,2L,2L,2L,3L,2L,3L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072491Inst : IEnumerable<long>
{
public static readonly long[] Value=A072491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072491.Bytes);
public long this[int i]=>Value[i];

public static A072491Inst Instance=new A072491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072492
{
public static readonly long[] Value={ 27L,35L,51L,57L,65L,77L,87L,93L,95L,117L,119L,121L,122L,123L,125L,135L,143L,145L,147L,148L,155L,161L,171L,177L,185L,187L,189L,190L,203L,205L,207L,208L,209L,215L,217L,219L,220L,221L,237L,245L,247L,249L,250L,255L,261L,267L,275L,287L,289L,291L,292L,297L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072492Inst : IEnumerable<long>
{
public static readonly long[] Value=A072492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072492.Bytes);
public long this[int i]=>Value[i];

public static A072492Inst Instance=new A072492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072493
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,16L,22L,29L,39L,52L,69L,92L,123L,164L,218L,291L,388L,517L,690L,920L,1226L,1635L,2180L,2907L,3876L,5168L,6890L,9187L,12249L,16332L,21776L,29035L,38713L,51618L,68824L,91765L,122353L,163138L,217517L,290023L,386697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072493Inst : IEnumerable<long>
{
public static readonly long[] Value=A072493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072493.Bytes);
public long this[int i]=>Value[i];

public static A072493Inst Instance=new A072493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072494
{
public static readonly long[] Value={ 1880L,4780L,4870L,7480L,7839L,7840L,8180L,8470L,8739L,8740L,8810L,10880L,11248L,11249L,11519L,12148L,12149L,13898L,15119L,18080L,18800L,21148L,21149L,23308L,25680L,25860L,26580L,26850L,28560L,28650L,31898L,32308L,33208L,33319L,40780L,40870L,44488L,44489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072494Inst : IEnumerable<long>
{
public static readonly long[] Value=A072494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072494.Bytes);
public long this[int i]=>Value[i];

public static A072494Inst Instance=new A072494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072495
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,16L,17L,19L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,36L,37L,39L,43L,44L,47L,48L,49L,51L,52L,53L,56L,57L,59L,61L,63L,64L,67L,68L,69L,71L,72L,73L,75L,76L,77L,79L,81L,83L,84L,87L,88L,89L,91L,92L,93L,96L,97L,99L,101L,107L,125L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072495Inst : IEnumerable<long>
{
public static readonly long[] Value=A072495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072495.Bytes);
public long this[int i]=>Value[i];

public static A072495Inst Instance=new A072495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072496
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,9L,11L,16L,19L,21L,24L,25L,29L,31L,36L,39L,41L,44L,49L,51L,56L,59L,61L,64L,69L,71L,75L,76L,79L,81L,84L,89L,91L,96L,99L,101L,125L,149L,151L,176L,199L,201L,224L,249L,251L,299L,301L,349L,351L,375L,376L,399L,401L,424L,449L,451L,499L,501L,549L,551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072496Inst : IEnumerable<long>
{
public static readonly long[] Value=A072496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072496.Bytes);
public long this[int i]=>Value[i];

public static A072496Inst Instance=new A072496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072497
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072497Inst : IEnumerable<long>
{
public static readonly long[] Value=A072497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072497.Bytes);
public long this[int i]=>Value[i];

public static A072497Inst Instance=new A072497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072498
{
public static readonly long[] Value={ 4L,9L,12L,16L,18L,20L,25L,28L,32L,36L,42L,44L,45L,48L,49L,50L,52L,54L,60L,63L,66L,68L,72L,75L,76L,78L,80L,81L,84L,88L,90L,92L,96L,98L,99L,100L,102L,104L,108L,110L,112L,114L,116L,117L,121L,124L,126L,128L,130L,132L,136L,138L,140L,147L,148L,150L,152L,153L,156L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072498Inst : IEnumerable<long>
{
public static readonly long[] Value=A072498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072498.Bytes);
public long this[int i]=>Value[i];

public static A072498Inst Instance=new A072498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072499
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,6L,1L,2L,3L,8L,1L,6L,1L,8L,3L,2L,1L,24L,5L,2L,3L,8L,1L,30L,1L,8L,3L,2L,5L,144L,1L,2L,3L,40L,1L,36L,1L,8L,15L,2L,1L,144L,7L,10L,3L,8L,1L,36L,5L,56L,3L,2L,1L,720L,1L,2L,21L,64L,5L,36L,1L,8L,3L,70L,1L,1152L,1L,2L,15L,8L,7L,36L,1L,320L,27L,2L,1L,1008L,5L,2L,3L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072499Inst : IEnumerable<long>
{
public static readonly long[] Value=A072499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072499.Bytes);
public long this[int i]=>Value[i];

public static A072499Inst Instance=new A072499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072724
{
public static readonly long[] Value={ 1L,4L,8227L,3427918353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072724Inst : IEnumerable<long>
{
public static readonly long[] Value=A072724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072724.Bytes);
public long this[int i]=>Value[i];

public static A072724Inst Instance=new A072724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072725
{
public static readonly long[] Value={ 1L,4L,823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072725Inst : IEnumerable<long>
{
public static readonly long[] Value=A072725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072725.Bytes);
public long this[int i]=>Value[i];

public static A072725Inst Instance=new A072725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072726
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,9L,9L,12L,8L,13L,17L,22L,13L,20L,22L,29L,10L,17L,25L,32L,25L,38L,40L,53L,17L,28L,38L,49L,32L,49L,53L,70L,12L,21L,33L,42L,37L,56L,58L,77L,33L,54L,72L,93L,58L,89L,97L,128L,21L,36L,54L,69L,56L,85L,89L,118L,42L,69L,93L,120L,77L,118L,128L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072726Inst : IEnumerable<long>
{
public static readonly long[] Value=A072726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072726.Bytes);
public long this[int i]=>Value[i];

public static A072726Inst Instance=new A072726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072727
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,4L,5L,1L,2L,4L,5L,6L,9L,9L,12L,1L,2L,4L,5L,6L,9L,9L,12L,8L,13L,17L,22L,13L,20L,22L,29L,1L,2L,4L,5L,6L,9L,9L,12L,8L,13L,17L,22L,13L,20L,22L,29L,10L,17L,25L,32L,25L,38L,40L,53L,17L,28L,38L,49L,32L,49L,53L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072727Inst : IEnumerable<long>
{
public static readonly long[] Value=A072727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072727.Bytes);
public long this[int i]=>Value[i];

public static A072727Inst Instance=new A072727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072728
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,8L,7L,8L,12L,13L,11L,12L,13L,19L,19L,21L,17L,18L,19L,19L,21L,29L,31L,30L,31L,34L,27L,26L,29L,29L,31L,30L,31L,34L,46L,45L,50L,46L,49L,49L,50L,55L,41L,44L,41L,43L,47L,46L,45L,50L,46L,49L,49L,50L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072728Inst : IEnumerable<long>
{
public static readonly long[] Value=A072728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072728.Bytes);
public long this[int i]=>Value[i];

public static A072728Inst Instance=new A072728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072729
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,5L,5L,5L,5L,8L,7L,8L,8L,7L,8L,12L,13L,11L,12L,13L,12L,13L,11L,12L,13L,19L,19L,21L,17L,18L,19L,19L,21L,19L,19L,21L,17L,18L,19L,19L,21L,29L,31L,30L,31L,34L,27L,26L,29L,29L,31L,30L,31L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072729Inst : IEnumerable<long>
{
public static readonly long[] Value=A072729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072729.Bytes);
public long this[int i]=>Value[i];

public static A072729Inst Instance=new A072729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072730
{
public static readonly long[] Value={ 788L,789L,3098L,5408L,7718L,10028L,12338L,14648L,15804L,16958L,19268L,21578L,23888L,26198L,28508L,30818L,30819L,33128L,35438L,37748L,40058L,40830L,42368L,44678L,45834L,46988L,49298L,51608L,53918L,56228L,58538L,60848L,60849L,63158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072730Inst : IEnumerable<long>
{
public static readonly long[] Value=A072730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072730.Bytes);
public long this[int i]=>Value[i];

public static A072730Inst Instance=new A072730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072731
{
public static readonly long[] Value={ 0L,-1L,-2L,-1L,-2L,-1L,-2L,-1L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,8L,9L,8L,9L,8L,9L,10L,11L,12L,13L,12L,13L,14L,15L,14L,15L,14L,15L,16L,17L,16L,17L,18L,19L,20L,21L,20L,21L,22L,23L,24L,25L,24L,25L,24L,25L,26L,27L,28L,29L,28L,29L,30L,31L,30L,31L,30L,31L,32L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072731Inst : IEnumerable<long>
{
public static readonly long[] Value=A072731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072731.Bytes);
public long this[int i]=>Value[i];

public static A072731Inst Instance=new A072731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072732
{
public static readonly long[] Value={ 0L,1L,4L,7L,12L,2L,3L,17L,24L,8L,11L,31L,40L,18L,5L,6L,23L,49L,60L,32L,13L,16L,39L,71L,84L,50L,25L,9L,10L,30L,59L,97L,112L,72L,41L,19L,22L,48L,83L,127L,144L,98L,61L,33L,14L,15L,38L,70L,111L,161L,180L,128L,85L,51L,26L,29L,58L,96L,143L,199L,220L,162L,113L,73L,42L,20L,21L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072732Inst : IEnumerable<long>
{
public static readonly long[] Value=A072732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072732.Bytes);
public long this[int i]=>Value[i];

public static A072732Inst Instance=new A072732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072733
{
public static readonly long[] Value={ 0L,1L,5L,6L,2L,14L,15L,3L,9L,27L,28L,10L,4L,20L,44L,45L,21L,7L,13L,35L,65L,66L,36L,16L,8L,26L,54L,90L,91L,55L,29L,11L,19L,43L,77L,119L,120L,78L,46L,22L,12L,34L,64L,104L,152L,153L,105L,67L,37L,17L,25L,53L,89L,135L,189L,190L,136L,92L,56L,30L,18L,42L,76L,118L,170L,230L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072733Inst : IEnumerable<long>
{
public static readonly long[] Value=A072733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072733.Bytes);
public long this[int i]=>Value[i];

public static A072733Inst Instance=new A072733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072734
{
public static readonly long[] Value={ 0L,1L,2L,3L,12L,4L,7L,17L,18L,5L,6L,23L,40L,24L,8L,11L,31L,49L,50L,25L,9L,10L,30L,59L,84L,60L,32L,13L,16L,39L,71L,97L,98L,61L,33L,14L,15L,38L,70L,111L,144L,112L,72L,41L,19L,22L,48L,83L,127L,161L,162L,113L,73L,42L,20L,21L,47L,82L,126L,179L,220L,180L,128L,85L,51L,26L,29L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072734Inst : IEnumerable<long>
{
public static readonly long[] Value=A072734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072734.Bytes);
public long this[int i]=>Value[i];

public static A072734Inst Instance=new A072734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072735
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,9L,10L,6L,14L,20L,21L,15L,4L,27L,35L,36L,28L,7L,8L,44L,54L,55L,45L,11L,13L,19L,65L,77L,78L,66L,22L,16L,26L,34L,90L,104L,105L,91L,37L,29L,12L,43L,53L,119L,135L,136L,120L,56L,46L,17L,18L,64L,76L,152L,170L,171L,153L,79L,67L,23L,25L,33L,89L,103L,189L,209L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072735Inst : IEnumerable<long>
{
public static readonly long[] Value=A072735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072735.Bytes);
public long this[int i]=>Value[i];

public static A072735Inst Instance=new A072735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072736
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,0L,5L,2L,0L,0L,7L,4L,1L,0L,0L,9L,6L,2L,1L,0L,0L,11L,8L,4L,1L,1L,0L,0L,13L,10L,6L,3L,1L,1L,0L,0L,15L,12L,8L,5L,2L,1L,1L,0L,0L,17L,14L,10L,7L,3L,2L,1L,1L,0L,0L,19L,16L,12L,9L,5L,2L,2L,1L,1L,0L,0L,21L,18L,14L,11L,7L,4L,2L,2L,1L,1L,0L,0L,23L,20L,16L,13L,9L,6L,3L,2L,2L,1L,1L,0L,0L,25L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072736Inst : IEnumerable<long>
{
public static readonly long[] Value=A072736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072736.Bytes);
public long this[int i]=>Value[i];

public static A072736Inst Instance=new A072736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072737
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,4L,0L,0L,3L,6L,0L,0L,1L,5L,8L,0L,0L,1L,3L,7L,10L,0L,0L,1L,2L,5L,9L,12L,0L,0L,1L,1L,4L,7L,11L,14L,0L,0L,1L,1L,2L,6L,9L,13L,16L,0L,0L,1L,1L,2L,4L,8L,11L,15L,18L,0L,0L,1L,1L,2L,3L,6L,10L,13L,17L,20L,0L,0L,1L,1L,2L,2L,5L,8L,12L,15L,19L,22L,0L,0L,1L,1L,2L,2L,3L,7L,10L,14L,17L,21L,24L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072737Inst : IEnumerable<long>
{
public static readonly long[] Value=A072737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072737.Bytes);
public long this[int i]=>Value[i];

public static A072737Inst Instance=new A072737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072738
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,0L,2L,3L,3L,1L,3L,4L,4L,2L,0L,3L,4L,5L,5L,3L,1L,4L,5L,6L,6L,4L,2L,0L,4L,5L,6L,7L,7L,5L,3L,1L,5L,6L,7L,8L,8L,6L,4L,2L,0L,5L,6L,7L,8L,9L,9L,7L,5L,3L,1L,6L,7L,8L,9L,10L,10L,8L,6L,4L,2L,0L,6L,7L,8L,9L,10L,11L,11L,9L,7L,5L,3L,1L,7L,8L,9L,10L,11L,12L,12L,10L,8L,6L,4L,2L,0L,7L,8L,9L,10L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072738Inst : IEnumerable<long>
{
public static readonly long[] Value=A072738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072738.Bytes);
public long this[int i]=>Value[i];

public static A072738Inst Instance=new A072738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072739
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,0L,2L,3L,2L,1L,3L,4L,3L,2L,0L,2L,4L,5L,4L,3L,1L,3L,5L,6L,5L,4L,3L,0L,2L,4L,6L,7L,6L,5L,4L,1L,3L,5L,7L,8L,7L,6L,5L,4L,0L,2L,4L,6L,8L,9L,8L,7L,6L,5L,1L,3L,5L,7L,9L,10L,9L,8L,7L,6L,5L,0L,2L,4L,6L,8L,10L,11L,10L,9L,8L,7L,6L,1L,3L,5L,7L,9L,11L,12L,11L,10L,9L,8L,7L,6L,0L,2L,4L,6L,8L,10L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072739Inst : IEnumerable<long>
{
public static readonly long[] Value=A072739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072739.Bytes);
public long this[int i]=>Value[i];

public static A072739Inst Instance=new A072739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072772
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,1L,0L,0L,4L,5L,6L,7L,8L,2L,3L,1L,0L,0L,1L,0L,0L,0L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,4L,5L,6L,7L,8L,2L,3L,1L,0L,0L,1L,0L,0L,0L,2L,3L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072772Inst : IEnumerable<long>
{
public static readonly long[] Value=A072772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072772.Bytes);
public long this[int i]=>Value[i];

public static A072772Inst Instance=new A072772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072773
{
public static readonly long[] Value={ 1L,3L,6L,7L,16L,42L,8L,19L,51L,52L,17L,44L,126L,127L,385L,18L,47L,135L,136L,413L,414L,20L,53L,154L,155L,475L,476L,477L,21L,56L,163L,164L,503L,504L,505L,506L,22L,60L,177L,178L,551L,552L,553L,554L,555L,45L,128L,390L,391L,1243L,1244L,1245L,1246L,1247L,4089L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072773Inst : IEnumerable<long>
{
public static readonly long[] Value=A072773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072773.Bytes);
public long this[int i]=>Value[i];

public static A072773Inst Instance=new A072773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072774
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072774Inst : IEnumerable<long>
{
public static readonly long[] Value=A072774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072774.Bytes);
public long this[int i]=>Value[i];

public static A072774Inst Instance=new A072774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072775
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,10L,11L,13L,14L,15L,2L,17L,19L,21L,22L,23L,5L,26L,3L,29L,30L,31L,2L,33L,34L,35L,6L,37L,38L,39L,41L,42L,43L,46L,47L,7L,51L,53L,55L,57L,58L,59L,61L,62L,2L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,3L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,10L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072775Inst : IEnumerable<long>
{
public static readonly long[] Value=A072775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072775.Bytes);
public long this[int i]=>Value[i];

public static A072775Inst Instance=new A072775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072776
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,5L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072776Inst : IEnumerable<long>
{
public static readonly long[] Value=A072776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072776.Bytes);
public long this[int i]=>Value[i];

public static A072776Inst Instance=new A072776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072777
{
public static readonly long[] Value={ 4L,8L,9L,16L,25L,27L,32L,36L,49L,64L,81L,100L,121L,125L,128L,169L,196L,216L,225L,243L,256L,289L,343L,361L,441L,484L,512L,529L,625L,676L,729L,841L,900L,961L,1000L,1024L,1089L,1156L,1225L,1296L,1331L,1369L,1444L,1521L,1681L,1764L,1849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072777Inst : IEnumerable<long>
{
public static readonly long[] Value=A072777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072777.Bytes);
public long this[int i]=>Value[i];

public static A072777Inst Instance=new A072777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072778
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,11L,12L,13L,14L,15L,16L,16L,17L,17L,18L,19L,20L,20L,21L,22L,23L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,34L,35L,36L,37L,37L,37L,38L,39L,39L,40L,40L,41L,41L,42L,42L,43L,43L,44L,45L,46L,46L,47L,48L,48L,49L,50L,51L,52L,52L,53L,54L,55L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072778Inst : IEnumerable<long>
{
public static readonly long[] Value=A072778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072778.Bytes);
public long this[int i]=>Value[i];

public static A072778Inst Instance=new A072778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072779
{
public static readonly long[] Value={ 2L,8L,18L,35L,50L,74L,98L,145L,169L,202L,242L,322L,338L,394L,452L,589L,578L,689L,722L,882L,884L,970L,1058L,1330L,1271L,1354L,1540L,1722L,1682L,1876L,1922L,2373L,2180L,2314L,2452L,3003L,2738L,2890L,3044L,3650L,3362L,3652L,3698L,4242L,4238L,4234L,4418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072779Inst : IEnumerable<long>
{
public static readonly long[] Value=A072779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072779.Bytes);
public long this[int i]=>Value[i];

public static A072779Inst Instance=new A072779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072780
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,2L,0L,17L,7L,2L,0L,34L,0L,2L,2L,77L,0L,41L,0L,82L,2L,2L,0L,178L,21L,2L,82L,154L,0L,76L,0L,325L,2L,2L,2L,411L,0L,2L,2L,450L,0L,124L,0L,370L,188L,2L,0L,786L,43L,115L,2L,514L,0L,428L,2L,858L,2L,2L,0L,948L,0L,2L,356L,1333L,2L,268L,0L,874L,2L,156L,0L,2047L,0L,2L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072780Inst : IEnumerable<long>
{
public static readonly long[] Value=A072780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072780.Bytes);
public long this[int i]=>Value[i];

public static A072780Inst Instance=new A072780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072781
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,1L,2L,3L,2L,0L,3L,4L,4L,3L,1L,3L,4L,5L,4L,2L,0L,4L,5L,6L,6L,5L,3L,1L,4L,5L,6L,7L,6L,4L,2L,0L,5L,6L,7L,8L,8L,7L,5L,3L,1L,5L,6L,7L,8L,9L,8L,6L,4L,2L,0L,6L,7L,8L,9L,10L,10L,9L,7L,5L,3L,1L,6L,7L,8L,9L,10L,11L,10L,8L,6L,4L,2L,0L,7L,8L,9L,10L,11L,12L,12L,11L,9L,7L,5L,3L,1L,7L,8L,9L,10L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072781Inst : IEnumerable<long>
{
public static readonly long[] Value=A072781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072781.Bytes);
public long this[int i]=>Value[i];

public static A072781Inst Instance=new A072781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072782
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,1L,2L,3L,2L,0L,2L,4L,3L,2L,1L,3L,4L,5L,4L,3L,0L,2L,4L,6L,5L,4L,3L,1L,3L,5L,6L,7L,6L,5L,4L,0L,2L,4L,6L,8L,7L,6L,5L,4L,1L,3L,5L,7L,8L,9L,8L,7L,6L,5L,0L,2L,4L,6L,8L,10L,9L,8L,7L,6L,5L,1L,3L,5L,7L,9L,10L,11L,10L,9L,8L,7L,6L,0L,2L,4L,6L,8L,10L,12L,11L,10L,9L,8L,7L,6L,1L,3L,5L,7L,9L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072782Inst : IEnumerable<long>
{
public static readonly long[] Value=A072782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072782.Bytes);
public long this[int i]=>Value[i];

public static A072782Inst Instance=new A072782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072783
{
public static readonly long[] Value={ 0L,0L,0L,-1L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,1L,-1L,0L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,1L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072783Inst : IEnumerable<long>
{
public static readonly long[] Value=A072783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072783.Bytes);
public long this[int i]=>Value[i];

public static A072783Inst Instance=new A072783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072784
{
public static readonly long[] Value={ 0L,0L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072784Inst : IEnumerable<long>
{
public static readonly long[] Value=A072784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072784.Bytes);
public long this[int i]=>Value[i];

public static A072784Inst Instance=new A072784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072785
{
public static readonly long[] Value={ 0L,0L,-1L,0L,0L,1L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072785Inst : IEnumerable<long>
{
public static readonly long[] Value=A072785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072785.Bytes);
public long this[int i]=>Value[i];

public static A072785Inst Instance=new A072785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072786
{
public static readonly long[] Value={ 0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072786Inst : IEnumerable<long>
{
public static readonly long[] Value=A072786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072786.Bytes);
public long this[int i]=>Value[i];

public static A072786Inst Instance=new A072786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072787
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,5L,13L,8L,4L,14L,10L,36L,20L,9L,25L,19L,24L,11L,12L,18L,38L,16L,7L,44L,27L,209L,77L,21L,105L,66L,104L,28L,35L,65L,230L,54L,15L,34L,33L,75L,43L,26L,85L,50L,40L,37L,22L,31L,191L,67L,23L,51L,41L,69L,107L,68L,49L,92L,30L,29L,32L,56L,211L,46L,17L,299L,120L,5671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072787Inst : IEnumerable<long>
{
public static readonly long[] Value=A072787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072787.Bytes);
public long this[int i]=>Value[i];

public static A072787Inst Instance=new A072787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072868
{
public static readonly BigInteger[] Value={ 4L,8L,32L,128L,8192L,131072L,524288L,2147483648L,2305843009213693952L,BigInteger.Parse("618970019642690137449562112") };
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
public class A072868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072868Inst Instance=new A072868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072869
{
public static readonly long[] Value={ 1L,1L,4L,1L,12L,1L,8L,7L,15L,1L,31L,1L,18L,13L,24L,1L,32L,1L,36L,12L,24L,1L,91L,12L,31L,14L,56L,1L,96L,1L,32L,24L,42L,14L,72L,1L,36L,18L,93L,1L,120L,1L,90L,48L,42L,1L,140L,15L,44L,32L,72L,1L,144L,18L,127L,24L,63L,1L,280L,1L,54L,42L,104L,20L,168L,1L,90L,40L,114L,1L,168L,1L,90L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072869Inst : IEnumerable<long>
{
public static readonly long[] Value=A072869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072869.Bytes);
public long this[int i]=>Value[i];

public static A072869Inst Instance=new A072869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072870
{
public static readonly long[] Value={ 6941L,283580L,6769195L,113677620L,1481094208L,15885002990L,145842897285L,1178181997670L,8545476792825L,56509982606938L,344819851018601L,1960225745409515L,10463156294045765L,52780423989098940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072870Inst : IEnumerable<long>
{
public static readonly long[] Value=A072870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072870.Bytes);
public long this[int i]=>Value[i];

public static A072870Inst Instance=new A072870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072871
{
public static readonly long[] Value={ 1L,2L,3L,56L,5L,30L,7L,56L,135L,30L,11L,792L,3718L,42L,15L,176L,386155L,792L,627L,715220L,42L,22L,8349L,792L,1575L,3718L,135L,56L,2436L,30L,75175L,2323520L,231L,92669720L,385L,792L,34262962L,124754L,4835271870L,2323520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072871Inst : IEnumerable<long>
{
public static readonly long[] Value=A072871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072871.Bytes);
public long this[int i]=>Value[i];

public static A072871Inst Instance=new A072871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072872
{
public static readonly long[] Value={ 1L,2L,4L,4L,3L,4L,11L,8L,5L,14L,7L,4L,10L,16L,16L,16L,30L,16L,30L,16L,11L,58L,75L,16L,34L,10L,5L,16L,6L,16L,8L,32L,58L,30L,16L,16L,58L,30L,10L,16L,33L,16L,54L,92L,16L,118L,224L,16L,36L,34L,59L,16L,36L,34L,63L,16L,130L,6L,64L,16L,43L,8L,16L,64L,16L,58L,210L,84L,118L,16L,43L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072872Inst : IEnumerable<long>
{
public static readonly long[] Value=A072872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072872.Bytes);
public long this[int i]=>Value[i];

public static A072872Inst Instance=new A072872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072873
{
public static readonly long[] Value={ 1L,4L,16L,27L,64L,108L,256L,432L,729L,1024L,1728L,2916L,3125L,4096L,6912L,11664L,12500L,16384L,19683L,27648L,46656L,50000L,65536L,78732L,84375L,110592L,186624L,200000L,262144L,314928L,337500L,442368L,531441L,746496L,800000L,823543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072873Inst : IEnumerable<long>
{
public static readonly long[] Value=A072873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072873.Bytes);
public long this[int i]=>Value[i];

public static A072873Inst Instance=new A072873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072874
{
public static readonly long[] Value={ 2L,4L,8L,16L,24L,28L,32L,36L,47L,53L,56L,64L,72L,80L,94L,103L,106L,128L,163L,192L,199L,206L,256L,257L,269L,311L,326L,336L,384L,397L,398L,401L,419L,421L,456L,499L,512L,514L,536L,538L,587L,599L,617L,622L,683L,700L,757L,768L,773L,794L,802L,838L,842L,863L,883L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072874Inst : IEnumerable<long>
{
public static readonly long[] Value=A072874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072874.Bytes);
public long this[int i]=>Value[i];

public static A072874Inst Instance=new A072874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072875
{
public static readonly long[] Value={ 2L,3L,61L,193L,15121L,838561L,807905281L,19896463921L,3059220303001L,3931520917431241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072875Inst : IEnumerable<long>
{
public static readonly long[] Value=A072875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072875.Bytes);
public long this[int i]=>Value[i];

public static A072875Inst Instance=new A072875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072876
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,3L,11L,49L,739L,41926L,36876163L,1504578225617L,BigInteger.Parse("67856786028033600651"),BigInteger.Parse("81238311359334144709516343054051"),BigInteger.Parse("8472940010945536421401513734595877223414710434640386") };
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
public class A072876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072876Inst Instance=new A072876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072877
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,3L,19L,119L,65339L,67258454L,959259994615659593L,BigInteger.Parse("171965197021698738644442682357"),BigInteger.Parse("12959040525296547835480490169418622922155526267774117749963303914461") };
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
public class A072877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072877Inst Instance=new A072877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072878
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,11L,131L,17291L,99665321L,903016046275353L,BigInteger.Parse("6224717403288400029624460201"),BigInteger.Parse("2240882930472585840954332388399544581477407095086361"),BigInteger.Parse("50384188378657848181032338163962292285660644698840136656562636145266593550842871302412156442811") };
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
public class A072878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072878Inst Instance=new A072878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072879
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,19L,379L,144019L,20741616379L,BigInteger.Parse("107553662508585672001"),BigInteger.Parse("608831069421618273050865038881215685876"),BigInteger.Parse("978035016076705458999330010986670207956236476587064788804921180339451725001") };
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
public class A072879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072879Inst Instance=new A072879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072880
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,5L,29L,869L,756029L,571580604869L,BigInteger.Parse("326704387862983487112029"),BigInteger.Parse("21347151409785350408171299054974277225256721769"),BigInteger.Parse("15713823217665540462976624783900822313284439536736221766688609460305249837839107387688348185") };
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
public class A072880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072880Inst Instance=new A072880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072881
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,31L,85L,393L,1093L,5071L,14119L,65523L,182449L,846721L,2357713L,10941843L,30467815L,141397231L,393723877L,1827222153L,5087942581L,23612490751L,65749529671L,305135157603L,849655943137L,3943144558081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072881Inst : IEnumerable<long>
{
public static readonly long[] Value=A072881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072881.Bytes);
public long this[int i]=>Value[i];

public static A072881Inst Instance=new A072881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072882
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,25L,841L,187489L,1418727556L,2393959458891025L,BigInteger.Parse("30567386265691995561839449"),BigInteger.Parse("658593751358960570203157512237008273218521"),BigInteger.Parse("181183406309644143341701434158730639946454023369335051404405528107396") };
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
public class A072882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072882Inst Instance=new A072882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072883
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,16L,3L,2L,1L,32L,1L,118L,417L,2L,1L,14L,1L,22L,81L,76L,1L,12L,55L,28L,15L,0L,1L,110L,1L,232L,117L,230L,3L,12L,1L,4L,375L,2L,1L,48L,1L,46L,15L,218L,1L,78L,7L,100L,993L,28L,1L,624L,13L,252L,183L,226L,1L,104L,1L,1348L,777L,1294L,0L,1806L,1L,306L,1815L,10L,1L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072883Inst : IEnumerable<long>
{
public static readonly long[] Value=A072883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072883.Bytes);
public long this[int i]=>Value[i];

public static A072883Inst Instance=new A072883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072884
{
public static readonly long[] Value={ 1L,136L,153L,244L,370L,371L,407L,919L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072884Inst : IEnumerable<long>
{
public static readonly long[] Value=A072884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072884.Bytes);
public long this[int i]=>Value[i];

public static A072884Inst Instance=new A072884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072885
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072885Inst : IEnumerable<long>
{
public static readonly long[] Value=A072885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072885.Bytes);
public long this[int i]=>Value[i];

public static A072885Inst Instance=new A072885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072886
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072886Inst : IEnumerable<long>
{
public static readonly long[] Value=A072886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072886.Bytes);
public long this[int i]=>Value[i];

public static A072886Inst Instance=new A072886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072887
{
public static readonly long[] Value={ 1L,9L,31L,36L,98L,107L,156L,164L,210L,221L,266L,312L,358L,365L,405L,415L,460L,467L,509L,519L,548L,556L,564L,566L,571L,577L,587L,598L,608L,613L,618L,623L,630L,641L,651L,661L,671L,673L,680L,686L,698L,711L,723L,730L,735L,742L,749L,762L,774L,792L,800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072887Inst : IEnumerable<long>
{
public static readonly long[] Value=A072887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072887.Bytes);
public long this[int i]=>Value[i];

public static A072887Inst Instance=new A072887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072888
{
public static readonly long[] Value={ -2L,-14L,70L,910L,-7280L,-138320L,1521520L,38038000L,-532532000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072888Inst : IEnumerable<long>
{
public static readonly long[] Value=A072888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072888.Bytes);
public long this[int i]=>Value[i];

public static A072888Inst Instance=new A072888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072889
{
public static readonly long[] Value={ 1L,136L,153L,244L,370L,371L,407L,919L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072889Inst : IEnumerable<long>
{
public static readonly long[] Value=A072889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072889.Bytes);
public long this[int i]=>Value[i];

public static A072889Inst Instance=new A072889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072890
{
public static readonly long[] Value={ 14316L,19116L,31704L,47616L,83328L,177792L,295488L,629072L,589786L,294896L,358336L,418904L,366556L,274924L,275444L,243760L,376736L,381028L,285778L,152990L,122410L,97946L,48976L,45946L,22976L,22744L,19916L,17716L,14316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072890Inst : IEnumerable<long>
{
public static readonly long[] Value=A072890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072890.Bytes);
public long this[int i]=>Value[i];

public static A072890Inst Instance=new A072890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072891
{
public static readonly long[] Value={ 12496L,14288L,15472L,14536L,14264L,12496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072891Inst : IEnumerable<long>
{
public static readonly long[] Value=A072891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072891.Bytes);
public long this[int i]=>Value[i];

public static A072891Inst Instance=new A072891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072892
{
public static readonly long[] Value={ 1264460L,1547860L,1727636L,1305184L,1264460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072892Inst : IEnumerable<long>
{
public static readonly long[] Value=A072892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072892.Bytes);
public long this[int i]=>Value[i];

public static A072892Inst Instance=new A072892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072893
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,11L,13L,18L,21L,23L,28L,31L,33L,43L,46L,51L,53L,56L,58L,66L,71L,73L,78L,83L,86L,88L,91L,93L,96L,98L,101L,106L,111L,113L,121L,123L,128L,131L,133L,136L,138L,141L,146L,153L,158L,161L,171L,173L,176L,178L,181L,183L,188L,193L,201L,203L,206L,211L,216L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072893Inst : IEnumerable<long>
{
public static readonly long[] Value=A072893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072893.Bytes);
public long this[int i]=>Value[i];

public static A072893Inst Instance=new A072893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072894
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,6L,7L,7L,8L,9L,10L,10L,11L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,22L,23L,23L,24L,25L,26L,26L,27L,28L,29L,29L,30L,31L,32L,32L,33L,33L,34L,34L,35L,36L,37L,37L,38L,38L,39L,39L,40L,41L,42L,42L,43L,43L,44L,44L,45L,46L,47L,47L,48L,49L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072894Inst : IEnumerable<long>
{
public static readonly long[] Value=A072894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072894.Bytes);
public long this[int i]=>Value[i];

public static A072894Inst Instance=new A072894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072895
{
public static readonly long[] Value={ 17L,54L,110L,186L,281L,396L,532L,686L,861L,1055L,1269L,1503L,1757L,2030L,2323L,2636L,2968L,3320L,3692L,4084L,4495L,4927L,5377L,5848L,6338L,6849L,7378L,7928L,8497L,9087L,9695L,10324L,10972L,11640L,12328L,13036L,13763L,14510L,15277L,16063L,16869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072895Inst : IEnumerable<long>
{
public static readonly long[] Value=A072895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072895.Bytes);
public long this[int i]=>Value[i];

public static A072895Inst Instance=new A072895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072896
{
public static readonly long[] Value={ 1L,4150L,4151L,54748L,58618L,76438L,89883L,92727L,93084L,157596L,194979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072896Inst : IEnumerable<long>
{
public static readonly long[] Value=A072896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072896.Bytes);
public long this[int i]=>Value[i];

public static A072896Inst Instance=new A072896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072897
{
public static readonly BigInteger[] Value={ 136L,2178L,58618L,63804L,2755907L,0L,144839908L,304162700L,4370652168L,0L,0L,0L,0L,0L,21914086555935085L,187864919457180831L,0L,13397885590701080090UL,0L,0L,0L,BigInteger.Parse("19095442247273220984552"),BigInteger.Parse("1553298727699254868304830"),BigInteger.Parse("1539325689516673750004702"),BigInteger.Parse("242402817739393059296681797") };
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
public class A072897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A072897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072897Inst Instance=new A072897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072898
{
public static readonly long[] Value={ 1L,2L,2L,5L,13L,38L,58L,191L,655L,2374L,4462L,17519L,71063L,298810L,646846L,2887921L,13237457L,62332114L,150303170L,742458253L,3748521653L,19340144966L,50903810666L,273315477775L,1495006933759L,8327893878134L,23599037077934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072898Inst : IEnumerable<long>
{
public static readonly long[] Value=A072898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072898.Bytes);
public long this[int i]=>Value[i];

public static A072898Inst Instance=new A072898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072899
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,13L,19L,58L,191L,655L,1187L,4462L,17519L,71063L,149405L,646846L,2887921L,13237457L,31166057L,150303170L,742458253L,3748521653L,9670072483L,50903810666L,273315477775L,1495006933759L,4163946939067L,23599037077934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072899Inst : IEnumerable<long>
{
public static readonly long[] Value=A072899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072899.Bytes);
public long this[int i]=>Value[i];

public static A072899Inst Instance=new A072899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072916
{
public static readonly long[] Value={ 3L,8L,19L,41L,117L,254L,616L,1642L,3766L,9461L,24183L,60252L,151368L,385600L,979844L,2507393L,6428977L,16513542L,42642649L,110283280L,285776799L,742428731L,1932223170L,5038580446L,13159683245L,34423463648L,90173540312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072916Inst : IEnumerable<long>
{
public static readonly long[] Value=A072916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072916.Bytes);
public long this[int i]=>Value[i];

public static A072916Inst Instance=new A072916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072917
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,1L,3L,1L,1L,1L,3L,3L,1L,1L,1L,1L,3L,1L,1L,3L,1L,5L,1L,1L,1L,5L,1L,1L,1L,1L,3L,5L,1L,1L,1L,1L,3L,5L,5L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,5L,5L,3L,1L,5L,3L,5L,1L,5L,1L,1L,1L,1L,1L,5L,1L,5L,5L,1L,1L,5L,3L,1L,3L,1L,1L,5L,1L,3L,1L,1L,1L,5L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072917Inst : IEnumerable<long>
{
public static readonly long[] Value=A072917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072917.Bytes);
public long this[int i]=>Value[i];

public static A072917Inst Instance=new A072917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072918
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,1L,3L,2L,4L,1L,1L,1L,3L,5L,5L,6L,1L,2L,3L,1L,5L,1L,5L,1L,6L,1L,1L,3L,1L,1L,5L,4L,5L,5L,5L,6L,3L,1L,3L,7L,1L,1L,3L,5L,1L,1L,5L,3L,2L,4L,1L,3L,5L,7L,1L,7L,3L,7L,1L,5L,5L,1L,3L,4L,5L,5L,3L,1L,1L,5L,1L,2L,5L,13L,3L,9L,1L,5L,3L,5L,6L,1L,5L,3L,1L,5L,7L,1L,7L,5L,1L,5L,3L,5L,7L,5L,3L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072918Inst : IEnumerable<long>
{
public static readonly long[] Value=A072918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072918.Bytes);
public long this[int i]=>Value[i];

public static A072918Inst Instance=new A072918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072919
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,5L,1L,19L,3L,21L,5L,1L,3L,7L,31L,43L,61L,17L,1L,101L,59L,1L,11L,11L,5L,13L,57L,73L,73L,39L,65L,127L,73L,29L,121L,97L,51L,1L,51L,9L,191L,227L,37L,107L,109L,1L,223L,317L,23L,37L,35L,185L,139L,13L,5L,55L,65L,19L,121L,313L,61L,1L,227L,43L,223L,91L,197L,1L,151L,7L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072919Inst : IEnumerable<long>
{
public static readonly long[] Value=A072919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072919.Bytes);
public long this[int i]=>Value[i];

public static A072919Inst Instance=new A072919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072920
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,12L,14L,16L,17L,19L,20L,24L,26L,28L,29L,35L,36L,46L,48L,50L,51L,53L,56L,60L,62L,66L,67L,69L,70L,80L,83L,85L,88L,90L,91L,95L,100L,102L,103L,105L,106L,110L,112L,116L,117L,123L,125L,129L,131L,133L,134L,136L,138L,144L,146L,150L,151L,163L,164L,170L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072920Inst : IEnumerable<long>
{
public static readonly long[] Value=A072920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072920.Bytes);
public long this[int i]=>Value[i];

public static A072920Inst Instance=new A072920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072921
{
public static readonly long[] Value={ 1L,2L,5L,13L,25L,44L,71L,106L,148L,203L,263L,334L,415L,506L,608L,724L,853L,998L,1169L,1357L,1561L,1778L,2018L,2269L,2539L,2828L,3137L,3460L,3796L,4157L,4535L,4930L,5341L,5765L,6212L,6670L,7147L,7643L,8159L,8698L,9268L,9863L,10484L,11122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072921Inst : IEnumerable<long>
{
public static readonly long[] Value=A072921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072921.Bytes);
public long this[int i]=>Value[i];

public static A072921Inst Instance=new A072921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072922
{
public static readonly long[] Value={ 1652100L,31946L,38760L,49537526L,732051L,724298L,36969L,47723135L,24375809L,1097258L,38111L,882492287L,1807948346L,2310701170991L,1242626638127L,33766692143L,62095095599L,1165465079087L,1137277763375L,1842973464623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072922Inst : IEnumerable<long>
{
public static readonly long[] Value=A072922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072922.Bytes);
public long this[int i]=>Value[i];

public static A072922Inst Instance=new A072922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072923
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,5L,4L,6L,5L,8L,5L,7L,6L,7L,7L,10L,8L,9L,8L,11L,12L,10L,12L,14L,10L,15L,13L,13L,17L,16L,16L,17L,14L,18L,18L,17L,22L,18L,22L,16L,21L,23L,20L,20L,24L,22L,24L,26L,23L,23L,26L,25L,26L,25L,28L,25L,31L,29L,26L,31L,27L,28L,31L,32L,31L,37L,32L,29L,32L,34L,31L,35L,34L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072923Inst : IEnumerable<long>
{
public static readonly long[] Value=A072923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072923.Bytes);
public long this[int i]=>Value[i];

public static A072923Inst Instance=new A072923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072924
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,4L,3L,3L,3L,3L,6L,8L,7L,6L,6L,7L,5L,11L,2L,2L,9L,4L,6L,10L,5L,9L,5L,6L,4L,7L,10L,11L,7L,6L,4L,3L,10L,4L,4L,3L,5L,4L,17L,6L,11L,7L,5L,14L,12L,8L,6L,11L,4L,14L,8L,7L,3L,16L,4L,21L,8L,12L,7L,8L,7L,7L,18L,12L,8L,17L,10L,12L,28L,6L,24L,16L,12L,16L,18L,7L,6L,6L,7L,11L,8L,14L,24L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072924Inst : IEnumerable<long>
{
public static readonly long[] Value=A072924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072924.Bytes);
public long this[int i]=>Value[i];

public static A072924Inst Instance=new A072924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072925
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,36L,78L,171L,379L,888L,1944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072925Inst : IEnumerable<long>
{
public static readonly long[] Value=A072925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072925.Bytes);
public long this[int i]=>Value[i];

public static A072925Inst Instance=new A072925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072926
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,4L,6L,7L,7L,8L,8L,9L,11L,12L,12L,13L,13L,14L,16L,17L,17L,18L,20L,23L,25L,26L,26L,27L,27L,28L,30L,33L,35L,36L,36L,37L,39L,40L,40L,41L,41L,42L,44L,45L,45L,46L,48L,51L,53L,54L,54L,55L,57L,60L,62L,63L,63L,64L,64L,65L,67L,70L,72L,73L,73L,74L,76L,77L,77L,78L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072926Inst : IEnumerable<long>
{
public static readonly long[] Value=A072926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072926.Bytes);
public long this[int i]=>Value[i];

public static A072926Inst Instance=new A072926Inst();

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