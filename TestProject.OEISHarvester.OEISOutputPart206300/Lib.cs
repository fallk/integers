using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244682
{
public static readonly long[] Value={ 1L,1L,6L,7L,1L,8L,2L,2L,5L,4L,5L,8L,8L,9L,0L,1L,7L,2L,5L,1L,2L,3L,2L,2L,5L,7L,9L,3L,6L,3L,8L,4L,5L,2L,8L,5L,2L,4L,0L,6L,7L,9L,3L,7L,0L,6L,7L,9L,1L,6L,0L,0L,6L,2L,4L,1L,2L,0L,9L,4L,3L,4L,1L,9L,1L,5L,6L,7L,0L,4L,7L,8L,9L,2L,3L,0L,0L,7L,6L,7L,2L,3L,2L,2L,8L,5L,5L,2L,9L,5L,8L,8L,8L,8L,7L,1L,1L,1L,9L,6L,4L,4L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244682Inst : IEnumerable<long>
{
public static readonly long[] Value=A244682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244682.Bytes);
public long this[int i]=>Value[i];

public static A244682Inst Instance=new A244682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244683
{
public static readonly long[] Value={ 1L,5L,3L,3L,7L,5L,7L,0L,2L,1L,7L,9L,2L,6L,9L,3L,7L,2L,4L,1L,7L,6L,8L,4L,8L,7L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,8L,7L,8L,1L,6L,3L,2L,3L,6L,1L,1L,0L,1L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244683Inst : IEnumerable<long>
{
public static readonly long[] Value=A244683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244683.Bytes);
public long this[int i]=>Value[i];

public static A244683Inst Instance=new A244683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244684
{
public static readonly long[] Value={ 1L,1L,8L,7L,3L,1L,2L,0L,3L,4L,3L,6L,8L,2L,0L,8L,5L,1L,5L,2L,2L,2L,2L,9L,7L,2L,9L,0L,0L,3L,8L,2L,1L,4L,9L,8L,0L,5L,0L,7L,7L,7L,3L,8L,2L,8L,7L,2L,5L,9L,0L,5L,8L,2L,1L,1L,6L,6L,9L,3L,3L,4L,5L,3L,5L,5L,7L,6L,3L,7L,7L,6L,8L,8L,9L,0L,2L,2L,0L,2L,2L,3L,7L,8L,4L,5L,0L,4L,2L,7L,8L,3L,3L,1L,0L,1L,3L,3L,7L,3L,4L,8L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244684Inst : IEnumerable<long>
{
public static readonly long[] Value=A244684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244684.Bytes);
public long this[int i]=>Value[i];

public static A244684Inst Instance=new A244684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244685
{
public static readonly long[] Value={ 1L,6L,4L,2L,9L,5L,0L,4L,1L,1L,3L,2L,2L,6L,3L,3L,3L,4L,4L,4L,5L,6L,9L,7L,8L,8L,9L,1L,8L,1L,1L,4L,9L,1L,4L,1L,2L,1L,7L,0L,7L,1L,0L,3L,4L,2L,4L,9L,3L,2L,7L,9L,4L,3L,2L,1L,7L,3L,6L,7L,2L,4L,1L,6L,9L,4L,6L,8L,8L,5L,1L,3L,9L,5L,7L,2L,2L,6L,3L,3L,7L,6L,0L,8L,4L,7L,6L,6L,3L,8L,4L,8L,4L,8L,1L,2L,7L,9L,9L,2L,0L,0L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244685Inst : IEnumerable<long>
{
public static readonly long[] Value=A244685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244685.Bytes);
public long this[int i]=>Value[i];

public static A244685Inst Instance=new A244685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244686
{
public static readonly long[] Value={ 1L,1L,0L,8L,2L,7L,2L,0L,8L,4L,8L,9L,8L,5L,0L,1L,3L,4L,5L,1L,2L,5L,2L,2L,9L,9L,0L,3L,4L,6L,9L,4L,7L,5L,9L,5L,8L,8L,0L,6L,7L,3L,3L,7L,4L,1L,7L,9L,9L,1L,0L,1L,0L,2L,5L,1L,1L,2L,1L,6L,3L,1L,4L,0L,7L,5L,1L,6L,9L,8L,7L,1L,8L,8L,9L,0L,2L,1L,7L,0L,2L,2L,3L,6L,1L,5L,2L,6L,5L,2L,8L,2L,9L,4L,3L,1L,3L,2L,3L,4L,4L,3L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244686Inst : IEnumerable<long>
{
public static readonly long[] Value=A244686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244686.Bytes);
public long this[int i]=>Value[i];

public static A244686Inst Instance=new A244686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244687
{
public static readonly long[] Value={ 1L,7L,5L,6L,1L,0L,3L,1L,7L,1L,1L,5L,2L,2L,7L,3L,3L,3L,4L,5L,3L,6L,6L,7L,8L,8L,5L,0L,5L,1L,2L,2L,7L,3L,0L,5L,1L,6L,0L,8L,7L,9L,2L,1L,5L,3L,6L,5L,5L,7L,2L,9L,7L,1L,0L,3L,1L,5L,0L,7L,7L,0L,2L,2L,5L,5L,6L,8L,5L,0L,2L,3L,7L,6L,0L,9L,1L,2L,0L,5L,7L,8L,2L,2L,5L,5L,6L,8L,5L,2L,2L,6L,7L,9L,0L,3L,1L,7L,0L,0L,0L,4L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244687Inst : IEnumerable<long>
{
public static readonly long[] Value=A244687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244687.Bytes);
public long this[int i]=>Value[i];

public static A244687Inst Instance=new A244687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244688
{
public static readonly long[] Value={ 1L,1L,2L,8L,1L,8L,2L,3L,1L,4L,5L,0L,8L,9L,0L,9L,1L,1L,5L,4L,2L,2L,2L,2L,1L,2L,0L,2L,8L,3L,9L,6L,3L,4L,9L,2L,6L,5L,1L,1L,7L,7L,3L,2L,6L,8L,7L,7L,3L,9L,0L,5L,1L,1L,6L,1L,3L,1L,1L,4L,3L,1L,1L,1L,3L,5L,2L,1L,1L,5L,7L,4L,1L,1L,8L,0L,7L,2L,2L,2L,2L,2L,2L,2L,8L,5L,9L,2L,2L,6L,8L,8L,2L,2L,5L,1L,8L,3L,3L,6L,4L,9L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244688Inst : IEnumerable<long>
{
public static readonly long[] Value=A244688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244688.Bytes);
public long this[int i]=>Value[i];

public static A244688Inst Instance=new A244688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244689
{
public static readonly BigInteger[] Value={ 1L,6L,73L,1934L,157857L,56192650L,92426525425L,666550826226318L,BigInteger.Parse("20291280723841291105"),BigInteger.Parse("2550027209175411070031954"),BigInteger.Parse("1305537190872353152721812616649"),BigInteger.Parse("2701765523097192231845112449534664934"),BigInteger.Parse("22497928378023184347083511140879821373194561"),BigInteger.Parse("751862888756012808502475142804126477229231539927258") };
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
public class A244689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244689Inst Instance=new A244689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244690
{
public static readonly long[] Value={ 1L,1L,4L,8L,1L,1L,2L,4L,3L,4L,3L,7L,8L,8L,0L,1L,9L,6L,6L,1L,2L,7L,2L,2L,3L,2L,0L,3L,2L,9L,9L,4L,9L,9L,9L,5L,4L,1L,1L,6L,7L,7L,4L,7L,8L,5L,8L,9L,7L,6L,0L,6L,7L,1L,1L,1L,5L,8L,3L,1L,3L,4L,9L,5L,1L,5L,3L,0L,7L,1L,8L,2L,1L,9L,1L,0L,1L,2L,1L,2L,2L,0L,3L,4L,2L,5L,9L,4L,7L,2L,8L,8L,5L,0L,3L,1L,7L,6L,3L,3L,4L,6L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244690Inst : IEnumerable<long>
{
public static readonly long[] Value=A244690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244690.Bytes);
public long this[int i]=>Value[i];

public static A244690Inst Instance=new A244690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244691
{
public static readonly long[] Value={ 1L,9L,7L,9L,5L,5L,9L,1L,1L,1L,3L,2L,2L,9L,3L,3L,9L,4L,4L,3L,5L,6L,1L,7L,8L,3L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,7L,7L,9L,3L,9L,0L,0L,3L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244691Inst : IEnumerable<long>
{
public static readonly long[] Value=A244691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244691.Bytes);
public long this[int i]=>Value[i];

public static A244691Inst Instance=new A244691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244692
{
public static readonly long[] Value={ 1L,1L,0L,6L,1L,8L,2L,2L,9L,4L,5L,6L,7L,9L,0L,5L,3L,1L,5L,8L,2L,2L,1L,5L,9L,2L,9L,4L,4L,3L,8L,6L,7L,4L,8L,1L,8L,5L,9L,9L,7L,6L,2L,9L,4L,8L,6L,3L,9L,9L,0L,1L,0L,6L,7L,1L,1L,2L,5L,8L,3L,1L,4L,4L,9L,5L,1L,6L,3L,0L,7L,1L,8L,2L,1L,0L,2L,1L,1L,2L,2L,2L,3L,0L,3L,5L,2L,6L,9L,4L,8L,2L,9L,8L,5L,0L,3L,2L,7L,6L,4L,3L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244692Inst : IEnumerable<long>
{
public static readonly long[] Value=A244692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244692.Bytes);
public long this[int i]=>Value[i];

public static A244692Inst Instance=new A244692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244693
{
public static readonly long[] Value={ 14L,111L,661L,3582L,19309L,107995L,636642L,3968291L,26107708L,180739086L,1312462869L,9968432106L,78988145772L,651486251644L,5581801486248L,49587865220286L,456026409915745L,4334757419499766L,42530730236808465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244693Inst : IEnumerable<long>
{
public static readonly long[] Value=A244693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244693.Bytes);
public long this[int i]=>Value[i];

public static A244693Inst Instance=new A244693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244694
{
public static readonly long[] Value={ 39L,111L,317L,908L,2602L,7459L,21383L,61302L,175745L,503841L,1444456L,4141097L,11872072L,34035934L,97577307L,279743489L,801994051L,2299229415L,6591639797L,18897511895L,54177104154L,155319844796L,445285043640L,1276583622333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244694Inst : IEnumerable<long>
{
public static readonly long[] Value=A244694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244694.Bytes);
public long this[int i]=>Value[i];

public static A244694Inst Instance=new A244694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244695
{
public static readonly long[] Value={ 49L,176L,661L,2540L,9858L,38440L,150208L,587527L,2299087L,8998528L,35223120L,137880423L,539741489L,2112870328L,8271068957L,32378091171L,126748027162L,496170960208L,1942323447926L,7603469333490L,29764737739051L,116517814264327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244695Inst : IEnumerable<long>
{
public static readonly long[] Value=A244695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244695.Bytes);
public long this[int i]=>Value[i];

public static A244695Inst Instance=new A244695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244696
{
public static readonly long[] Value={ 50L,191L,801L,3582L,16673L,79535L,384984L,1879575L,9222654L,45385845L,223728645L,1103952328L,5450384180L,26918312059L,132969494589L,656908143379L,3245528085657L,16035496065995L,79229859441587L,391472138972739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244696Inst : IEnumerable<long>
{
public static readonly long[] Value=A244696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244696.Bytes);
public long this[int i]=>Value[i];

public static A244696Inst Instance=new A244696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244697
{
public static readonly long[] Value={ 50L,192L,822L,3848L,19309L,102127L,561161L,3166917L,18201193L,105893207L,621089263L,3662332727L,21671238176L,128530941331L,763458928009L,4539335270638L,27007213540325L,160750196255316L,957070841674474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244697Inst : IEnumerable<long>
{
public static readonly long[] Value=A244697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244697.Bytes);
public long this[int i]=>Value[i];

public static A244697Inst Instance=new A244697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244698
{
public static readonly long[] Value={ 50L,192L,823L,3876L,19771L,107995L,624776L,3787558L,23822643L,154111782L,1018069938L,6829108505L,46316803213L,316615323825L,2176466957877L,15020655481036L,103953176630054L,720844789379037L,5005517246373317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244698Inst : IEnumerable<long>
{
public static readonly long[] Value=A244698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244698.Bytes);
public long this[int i]=>Value[i];

public static A244698Inst Instance=new A244698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244699
{
public static readonly long[] Value={ 50L,192L,823L,3877L,19807L,108745L,636642L,3946032L,25709683L,174808033L,1231576387L,8930829569L,66261447244L,500451094399L,3831652303294L,29641331551873L,231089791940516L,1812103169942265L,14271203280327465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244699Inst : IEnumerable<long>
{
public static readonly long[] Value=A244699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244699.Bytes);
public long this[int i]=>Value[i];

public static A244699Inst Instance=new A244699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244700
{
public static readonly long[] Value={ 50L,192L,823L,3877L,19808L,108790L,637797L,3968291L,26068401L,179921359L,1298251473L,9743759935L,75670367779L,604957634338L,4954615669121L,41386737045460L,351237461377850L,3018626309147443L,26200935632153559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244700Inst : IEnumerable<long>
{
public static readonly long[] Value=A244700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244700.Bytes);
public long this[int i]=>Value[i];

public static A244700Inst Instance=new A244700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244701
{
public static readonly long[] Value={ 50L,192L,823L,3877L,19808L,108791L,637852L,3969996L,26107708L,180673040L,1310878363L,9936630366L,78410615256L,641745990003L,5426657117884L,47225199713541L,421301933548486L,3838582073808844L,35596716460818879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244701Inst : IEnumerable<long>
{
public static readonly long[] Value=A244701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244701.Bytes);
public long this[int i]=>Value[i];

public static A244701Inst Instance=new A244701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244702
{
public static readonly long[] Value={ 14L,39L,25L,49L,111L,44L,50L,176L,317L,79L,50L,191L,661L,908L,141L,50L,192L,801L,2540L,2602L,253L,50L,192L,822L,3582L,9858L,7459L,452L,50L,192L,823L,3848L,16673L,38440L,21383L,809L,50L,192L,823L,3876L,19309L,79535L,150208L,61302L,1446L,50L,192L,823L,3877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244702Inst : IEnumerable<long>
{
public static readonly long[] Value=A244702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244702.Bytes);
public long this[int i]=>Value[i];

public static A244702Inst Instance=new A244702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244703
{
public static readonly long[] Value={ 1L,1L,3L,4L,9L,13L,26L,42L,81L,138L,262L,467L,885L,1620L,3076L,5743L,10953L,20721L,39714L,75873L,146139L,281259L,544230L,1053552L,2047147L,3981790L,7766018L,15165195L,29676887L,58148087L,114129308L,224278526L,441368913L,869583189L,1715365690L,3387344619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244703Inst : IEnumerable<long>
{
public static readonly long[] Value=A244703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244703.Bytes);
public long this[int i]=>Value[i];

public static A244703Inst Instance=new A244703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244704
{
public static readonly long[] Value={ 1L,1L,3L,6L,13L,25L,55L,107L,224L,454L,938L,1916L,3969L,8163L,16918L,35010L,72724L,151093L,314749L,656115L,1370348L,2864948L,5998547L,12572884L,26385837L,55431031L,116577538L,245415158L,517152607L,1090771973L,2302729115L,4865449045L,10288826434L,21774842539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244704Inst : IEnumerable<long>
{
public static readonly long[] Value=A244704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244704.Bytes);
public long this[int i]=>Value[i];

public static A244704Inst Instance=new A244704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244705
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,29L,68L,140L,312L,660L,1443L,3084L,6710L,14425L,31278L,67508L,146300L,316424L,685955L,1486008L,3223480L,6992012L,15179437L,32960891L,71617874L,155661971L,338508703L,736401503L,1602712182L,3489454243L,7600403101L,16560519877L,36097320801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244705Inst : IEnumerable<long>
{
public static readonly long[] Value=A244705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244705.Bytes);
public long this[int i]=>Value[i];

public static A244705Inst Instance=new A244705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244706
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,72L,153L,346L,752L,1673L,3661L,8108L,17814L,39349L,86646L,191251L,421596L,930519L,2052789L,4531648L,10002857L,22088709L,48780279L,107757048L,238069894L,526096509L,1162775782L,2570487392L,5683401236L,12568472173L,27799055016L,61496981626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244706Inst : IEnumerable<long>
{
public static readonly long[] Value=A244706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244706.Bytes);
public long this[int i]=>Value[i];

public static A244706Inst Instance=new A244706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244707
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,74L,157L,359L,786L,1766L,3895L,8710L,19287L,42987L,95437L,212468L,472204L,1050940L,2337221L,5201558L,11573156L,25759514L,57332239L,127633669L,284148877L,632704464L,1408925270L,3137861761L,6989057709L,15568767849L,34684141315L,77277619879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244707Inst : IEnumerable<long>
{
public static readonly long[] Value=A244707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244707.Bytes);
public long this[int i]=>Value[i];

public static A244707Inst Instance=new A244707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244708
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,74L,159L,363L,799L,1800L,3988L,8945L,19893L,44486L,99153L,221520L,494187L,1103789L,2463834L,5502927L,12288076L,27448039L,61308387L,136966368L,305999360L,683733350L,1527844853L,3414432569L,7631131801L,17056871547L,38127833992L,85235556468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244708Inst : IEnumerable<long>
{
public static readonly long[] Value=A244708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244708.Bytes);
public long this[int i]=>Value[i];

public static A244708Inst Instance=new A244708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244709
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,74L,159L,365L,803L,1813L,4022L,9038L,20128L,45093L,100656L,225263L,503320L,1126045L,2517487L,5631913L,12596046L,28181168L,63045684L,141071758L,315668674L,706452161L,1581088178L,3538954508L,7921759060L,17733983146L,39702719910L,88893039358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244709Inst : IEnumerable<long>
{
public static readonly long[] Value=A244709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244709.Bytes);
public long this[int i]=>Value[i];

public static A244709Inst Instance=new A244709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244710
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,74L,159L,365L,805L,1817L,4035L,9072L,20221L,45328L,101263L,226767L,507067L,1135206L,2539827L,5685851L,12725874L,28491634L,63785789L,142828392L,319826118L,716260116L,1604170013L,3593139239L,8048694851L,18030750419L,40395321587L,90506748160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244710Inst : IEnumerable<long>
{
public static readonly long[] Value=A244710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244710.Bytes);
public long this[int i]=>Value[i];

public static A244710Inst Instance=new A244710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244711
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,74L,159L,365L,805L,1819L,4039L,9085L,20255L,45421L,101498L,227374L,508571L,1138954L,2548992L,5708220L,12779899L,28621759L,64097135L,143571116L,321590093L,720437987L,1614033142L,3616368570L,8103267171L,18158695095L,40694685268L,91205979165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244711Inst : IEnumerable<long>
{
public static readonly long[] Value=A244711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244711.Bytes);
public long this[int i]=>Value[i];

public static A244711Inst Instance=new A244711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244712
{
public static readonly long[] Value={ 0L,1L,1L,3L,6L,15L,31L,74L,159L,365L,805L,1819L,4041L,9091L,20274L,45474L,101644L,227755L,509559L,1141446L,2555232L,5723626L,12817678L,28713594L,64319189L,144104857L,322867573L,723482538L,1621264326L,3633487621L,8143682973L,18253865341L,40918282628L,91730206467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244712Inst : IEnumerable<long>
{
public static readonly long[] Value=A244712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244712.Bytes);
public long this[int i]=>Value[i];

public static A244712Inst Instance=new A244712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244713
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,16L,18L,19L,22L,25L,27L,28L,31L,34L,37L,40L,43L,45L,46L,49L,52L,54L,55L,58L,61L,64L,67L,70L,72L,73L,76L,79L,81L,82L,85L,88L,91L,94L,97L,99L,100L,103L,106L,108L,109L,112L,115L,118L,121L,124L,126L,127L,130L,133L,135L,136L,139L,142L,145L,148L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244713Inst : IEnumerable<long>
{
public static readonly long[] Value=A244713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244713.Bytes);
public long this[int i]=>Value[i];

public static A244713Inst Instance=new A244713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244714
{
public static readonly long[] Value={ 1L,4L,14L,29L,56L,100L,148L,230L,322L,446L,573L,778L,953L,1215L,1456L,1806L,2134L,2542L,2944L,3477L,3968L,4600L,5186L,5872L,6657L,7446L,8304L,9217L,10258L,11172L,12465L,13564L,14867L,16072L,17716L,18816L,20832L,22055L,24144L,25504L,27904L,29168L,32051L,33375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244714Inst : IEnumerable<long>
{
public static readonly long[] Value=A244714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244714.Bytes);
public long this[int i]=>Value[i];

public static A244714Inst Instance=new A244714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244715
{
public static readonly long[] Value={ 2L,10L,36L,86L,200L,374L,680L,1122L,1796L,2694L,3954L,5600L,7752L,10448L,13798L,18072L,23032L,29218L,36390L,45044L,54870L,66852L,79790L,95550L,112662L,132938L,154752L,180614L,207764L,239784L,273898L,312922L,354240L,401826L,451598L,508134L,567756L,634634L,705506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244715Inst : IEnumerable<long>
{
public static readonly long[] Value=A244715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244715.Bytes);
public long this[int i]=>Value[i];

public static A244715Inst Instance=new A244715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244716
{
public static readonly long[] Value={ 1L,6L,31L,99L,278L,654L,1390L,2714L,4927L,8531L,13963L,22134L,33767L,50283L,72470L,102891L,142375L,194202L,260093L,343973L,447906L,577636L,735540L,928009L,1159312L,1436145L,1765079L,2152787L,2608321L,3137866L,3755214L,4464420L,5284570L,6216275L,7287298L,8494233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244716Inst : IEnumerable<long>
{
public static readonly long[] Value=A244716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244716.Bytes);
public long this[int i]=>Value[i];

public static A244716Inst Instance=new A244716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244717
{
public static readonly long[] Value={ 2L,16L,78L,274L,814L,2058L,4752L,9930L,19574L,36186L,63924L,108078L,176672L,279260L,429800L,645222L,947142L,1363678L,1927532L,2681804L,3673786L,4967774L,6630024L,8752102L,11422254L,14770528L,18913112L,24022400L,30253734L,37831400L,46953628L,57914360L,70960394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244717Inst : IEnumerable<long>
{
public static readonly long[] Value=A244717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244717.Bytes);
public long this[int i]=>Value[i];

public static A244717Inst Instance=new A244717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244718
{
public static readonly long[] Value={ 1L,8L,52L,225L,813L,2444L,6563L,15837L,35304L,73544L,144542L,270622L,485229L,838813L,1401911L,2277346L,3601229L,5565741L,8415746L,12487185L,18197114L,26097804L,36868409L,51383060L,70693900L,96130946L,129286606L,172104111L,226920654L,296516361L,384211698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244718Inst : IEnumerable<long>
{
public static readonly long[] Value=A244718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244718.Bytes);
public long this[int i]=>Value[i];

public static A244718Inst Instance=new A244718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244719
{
public static readonly long[] Value={ 2L,22L,136L,618L,2278L,7180L,20140L,51100L,120046L,263192L,545644L,1075414L,2031190L,3690972L,6485546L,11052982L,18333194L,29664162L,46934548L,72757550L,110684340L,165506866L,243561442L,353198516L,505188930L,713484770L,995688310L,1374225240L,1876917926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244719Inst : IEnumerable<long>
{
public static readonly long[] Value=A244719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244719.Bytes);
public long this[int i]=>Value[i];

public static A244719Inst Instance=new A244719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244720
{
public static readonly long[] Value={ 1L,10L,77L,415L,1825L,6692L,21587L,62225L,164197L,401173L,919007L,1989942L,4102426L,8100013L,15388485L,28249241L,50273708L,87007800L,146783168L,241958083L,390411308L,617752456L,959909294L,1466853260L,2206861654L,3272535062L,4787597429L,6916184121L,9873403733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244720Inst : IEnumerable<long>
{
public static readonly long[] Value=A244720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244720.Bytes);
public long this[int i]=>Value[i];

public static A244720Inst Instance=new A244720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244721
{
public static readonly long[] Value={ 2L,28L,210L,1158L,5112L,19206L,63494L,189092L,516528L,1310128L,3119942L,7027866L,15082152L,30994832L,61292380L,117063670L,216690678L,389814504L,683256278L,1169346934L,1957831816L,3212249500L,5172450680L,8185057350L,12743907242L,19544000940L,29551096298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244721Inst : IEnumerable<long>
{
public static readonly long[] Value=A244721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244721.Bytes);
public long this[int i]=>Value[i];

public static A244721Inst Instance=new A244721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244722
{
public static readonly long[] Value={ 1L,12L,106L,677L,3494L,15072L,56687L,189836L,578105L,1621690L,4241828L,10434473L,24323694L,54053172L,115100757L,235866109L,466850629L,895363599L,1668452274L,3028132617L,5364010992L,9291348726L,15763537852L,26234025046L,42882816586L,68933785785L,109087903602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244722Inst : IEnumerable<long>
{
public static readonly long[] Value=A244722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244722.Bytes);
public long this[int i]=>Value[i];

public static A244722Inst Instance=new A244722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244723
{
public static readonly long[] Value={ 1L,8L,12L,14L,16L,20L,22L,24L,25L,27L,28L,32L,36L,40L,44L,45L,46L,48L,50L,52L,54L,56L,60L,63L,64L,68L,72L,75L,76L,80L,81L,84L,88L,90L,92L,94L,96L,99L,100L,104L,108L,112L,116L,117L,118L,120L,124L,125L,126L,128L,132L,135L,136L,140L,144L,147L,148L,150L,152L,153L,156L,160L,162L,164L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244723Inst : IEnumerable<long>
{
public static readonly long[] Value=A244723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244723.Bytes);
public long this[int i]=>Value[i];

public static A244723Inst Instance=new A244723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244724
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,8L,9L,7L,10L,11L,12L,13L,16L,14L,15L,17L,20L,18L,19L,21L,22L,23L,24L,25L,28L,26L,27L,29L,30L,32L,35L,31L,36L,33L,34L,38L,41L,37L,42L,39L,40L,44L,45L,43L,46L,47L,50L,48L,49L,51L,52L,53L,54L,56L,57L,55L,58L,59L,68L,60L,67L,61L,66L,62L,65L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244724Inst : IEnumerable<long>
{
public static readonly long[] Value=A244724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244724.Bytes);
public long this[int i]=>Value[i];

public static A244724Inst Instance=new A244724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244725
{
public static readonly long[] Value={ 0L,5L,40L,135L,320L,625L,1080L,1715L,2560L,3645L,5000L,6655L,8640L,10985L,13720L,16875L,20480L,24565L,29160L,34295L,40000L,46305L,53240L,60835L,69120L,78125L,87880L,98415L,109760L,121945L,135000L,148955L,163840L,179685L,196520L,214375L,233280L,253265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244725Inst : IEnumerable<long>
{
public static readonly long[] Value=A244725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244725.Bytes);
public long this[int i]=>Value[i];

public static A244725Inst Instance=new A244725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244726
{
public static readonly long[] Value={ 0L,6L,48L,162L,384L,750L,1296L,2058L,3072L,4374L,6000L,7986L,10368L,13182L,16464L,20250L,24576L,29478L,34992L,41154L,48000L,55566L,63888L,73002L,82944L,93750L,105456L,118098L,131712L,146334L,162000L,178746L,196608L,215622L,235824L,257250L,279936L,303918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244726Inst : IEnumerable<long>
{
public static readonly long[] Value=A244726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244726.Bytes);
public long this[int i]=>Value[i];

public static A244726Inst Instance=new A244726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244727
{
public static readonly long[] Value={ 0L,7L,56L,189L,448L,875L,1512L,2401L,3584L,5103L,7000L,9317L,12096L,15379L,19208L,23625L,28672L,34391L,40824L,48013L,56000L,64827L,74536L,85169L,96768L,109375L,123032L,137781L,153664L,170723L,189000L,208537L,229376L,251559L,275128L,300125L,326592L,354571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244727Inst : IEnumerable<long>
{
public static readonly long[] Value=A244727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244727.Bytes);
public long this[int i]=>Value[i];

public static A244727Inst Instance=new A244727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244728
{
public static readonly long[] Value={ 0L,9L,72L,243L,576L,1125L,1944L,3087L,4608L,6561L,9000L,11979L,15552L,19773L,24696L,30375L,36864L,44217L,52488L,61731L,72000L,83349L,95832L,109503L,124416L,140625L,158184L,177147L,197568L,219501L,243000L,268119L,294912L,323433L,353736L,385875L,419904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244728Inst : IEnumerable<long>
{
public static readonly long[] Value=A244728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244728.Bytes);
public long this[int i]=>Value[i];

public static A244728Inst Instance=new A244728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244729
{
public static readonly long[] Value={ 0L,10L,80L,270L,640L,1250L,2160L,3430L,5120L,7290L,10000L,13310L,17280L,21970L,27440L,33750L,40960L,49130L,58320L,68590L,80000L,92610L,106480L,121670L,138240L,156250L,175760L,196830L,219520L,243890L,270000L,297910L,327680L,359370L,393040L,428750L,466560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244729Inst : IEnumerable<long>
{
public static readonly long[] Value=A244729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244729.Bytes);
public long this[int i]=>Value[i];

public static A244729Inst Instance=new A244729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244730
{
public static readonly long[] Value={ 0L,2L,32L,162L,512L,1250L,2592L,4802L,8192L,13122L,20000L,29282L,41472L,57122L,76832L,101250L,131072L,167042L,209952L,260642L,320000L,388962L,468512L,559682L,663552L,781250L,913952L,1062882L,1229312L,1414562L,1620000L,1847042L,2097152L,2371842L,2672672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244730Inst : IEnumerable<long>
{
public static readonly long[] Value=A244730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244730.Bytes);
public long this[int i]=>Value[i];

public static A244730Inst Instance=new A244730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244731
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,11L,12L,13L,17L,21L,22L,23L,24L,25L,29L,30L,46L,47L,51L,52L,53L,54L,58L,59L,69L,70L,71L,76L,79L,88L,89L,90L,98L,101L,111L,112L,113L,114L,118L,119L,120L,133L,137L,141L,142L,143L,148L,151L,160L,161L,177L,183L,184L,185L,189L,190L,191L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244731Inst : IEnumerable<long>
{
public static readonly long[] Value=A244731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244731.Bytes);
public long this[int i]=>Value[i];

public static A244731Inst Instance=new A244731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244732
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,9L,7L,8L,10L,11L,12L,13L,15L,16L,14L,17L,19L,20L,18L,21L,22L,23L,24L,25L,27L,28L,26L,29L,30L,33L,31L,35L,36L,32L,34L,39L,37L,41L,42L,38L,40L,45L,43L,44L,46L,47L,49L,50L,48L,51L,52L,53L,54L,57L,55L,56L,58L,59L,61L,63L,65L,67L,68L,66L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244732Inst : IEnumerable<long>
{
public static readonly long[] Value=A244732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244732.Bytes);
public long this[int i]=>Value[i];

public static A244732Inst Instance=new A244732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244733
{
public static readonly long[] Value={ 38L,86L,161L,614L,662L,998L,1145L,1355L,1829L,2189L,2483L,4607L,5027L,5315L,6377L,7199L,8258L,11435L,13214L,15611L,17933L,19574L,20153L,21305L,21878L,24014L,26867L,30599L,32738L,34199L,36077L,38387L,38777L,40778L,42422L,46211L,51509L,52874L,56618L,58541L,59987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244733Inst : IEnumerable<long>
{
public static readonly long[] Value=A244733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244733.Bytes);
public long this[int i]=>Value[i];

public static A244733Inst Instance=new A244733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244734
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,7L,4L,3L,5L,11L,6L,13L,7L,3L,16L,17L,6L,19L,4L,7L,22L,23L,8L,25L,26L,9L,4L,29L,15L,31L,8L,33L,17L,5L,9L,37L,19L,13L,10L,41L,7L,43L,11L,5L,46L,47L,16L,49L,10L,17L,52L,53L,6L,11L,56L,57L,58L,59L,12L,61L,62L,63L,64L,13L,6L,67L,34L,23L,35L,71L,12L,73L,37L,25L,38L,7L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244734Inst : IEnumerable<long>
{
public static readonly long[] Value=A244734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244734.Bytes);
public long this[int i]=>Value[i];

public static A244734Inst Instance=new A244734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244735
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244735Inst : IEnumerable<long>
{
public static readonly long[] Value=A244735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244735.Bytes);
public long this[int i]=>Value[i];

public static A244735Inst Instance=new A244735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244736
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,12L,15L,17L,19L,22L,24L,25L,28L,29L,31L,33L,34L,35L,37L,39L,41L,45L,46L,49L,50L,52L,55L,57L,59L,63L,66L,68L,69L,70L,72L,73L,75L,77L,78L,80L,81L,85L,87L,88L,91L,92L,93L,95L,97L,101L,102L,104L,106L,107L,109L,111L,113L,114L,118L,120L,123L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244736Inst : IEnumerable<long>
{
public static readonly long[] Value=A244736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244736.Bytes);
public long this[int i]=>Value[i];

public static A244736Inst Instance=new A244736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244737
{
public static readonly long[] Value={ 2L,5L,6L,9L,11L,13L,14L,16L,18L,20L,21L,23L,26L,27L,30L,32L,36L,38L,40L,42L,43L,44L,47L,48L,51L,53L,54L,56L,58L,60L,61L,62L,64L,65L,67L,71L,74L,76L,79L,82L,83L,84L,86L,89L,90L,94L,96L,98L,99L,100L,103L,105L,108L,110L,112L,115L,116L,117L,119L,121L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244737Inst : IEnumerable<long>
{
public static readonly long[] Value=A244737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244737.Bytes);
public long this[int i]=>Value[i];

public static A244737Inst Instance=new A244737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244738
{
public static readonly long[] Value={ 2L,0L,0L,2L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,2L,0L,1L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,1L,1L,2L,0L,2L,0L,1L,1L,1L,0L,2L,1L,1L,0L,2L,1L,0L,1L,1L,1L,2L,0L,1L,1L,2L,1L,0L,0L,2L,1L,0L,2L,1L,2L,2L,1L,0L,1L,2L,0L,1L,0L,1L,2L,1L,1L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244738Inst : IEnumerable<long>
{
public static readonly long[] Value=A244738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244738.Bytes);
public long this[int i]=>Value[i];

public static A244738Inst Instance=new A244738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244739
{
public static readonly long[] Value={ 2L,3L,6L,9L,14L,16L,21L,23L,27L,30L,38L,40L,44L,48L,51L,56L,61L,62L,65L,71L,74L,76L,84L,86L,90L,96L,99L,103L,108L,112L,117L,119L,122L,124L,130L,132L,137L,143L,147L,150L,153L,162L,166L,170L,174L,179L,183L,185L,188L,191L,192L,196L,198L,200L,208L,213L,220L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244739Inst : IEnumerable<long>
{
public static readonly long[] Value=A244739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244739.Bytes);
public long this[int i]=>Value[i];

public static A244739Inst Instance=new A244739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244740
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,3L,2L,2L,1L,1L,5L,1L,2L,1L,1L,1L,4L,3L,2L,1L,2L,1L,1L,1L,5L,1L,3L,2L,2L,1L,1L,1L,1L,3L,3L,4L,1L,3L,1L,2L,1L,1L,1L,1L,5L,3L,2L,2L,4L,1L,2L,1L,2L,1L,1L,1L,1L,1L,7L,1L,4L,2L,2L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,8L,3L,2L,2L,3L,1L,3L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244740Inst : IEnumerable<long>
{
public static readonly long[] Value=A244740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244740.Bytes);
public long this[int i]=>Value[i];

public static A244740Inst Instance=new A244740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244741
{
public static readonly long[] Value={ 1L,4L,7L,12L,15L,19L,25L,28L,31L,33L,37L,39L,45L,49L,55L,59L,63L,66L,68L,69L,73L,78L,88L,91L,93L,101L,102L,106L,107L,111L,113L,118L,123L,129L,134L,138L,139L,144L,148L,151L,154L,155L,159L,161L,163L,165L,168L,181L,184L,187L,195L,199L,203L,206L,211L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244741Inst : IEnumerable<long>
{
public static readonly long[] Value=A244741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244741.Bytes);
public long this[int i]=>Value[i];

public static A244741Inst Instance=new A244741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244742
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,19L,32L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244742Inst : IEnumerable<long>
{
public static readonly long[] Value=A244742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244742.Bytes);
public long this[int i]=>Value[i];

public static A244742Inst Instance=new A244742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244743
{
public static readonly long[] Value={ 6L,12L,24L,108L,720L,1440L,81648L,2041200L,612360000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244743Inst : IEnumerable<long>
{
public static readonly long[] Value=A244743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244743.Bytes);
public long this[int i]=>Value[i];

public static A244743Inst Instance=new A244743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244744
{
public static readonly long[] Value={ 46L,253L,649L,6049L,69989L,166213L,551137L,9064261L,68444596L,347562415L,612220081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244744Inst : IEnumerable<long>
{
public static readonly long[] Value=A244744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244744.Bytes);
public long this[int i]=>Value[i];

public static A244744Inst Instance=new A244744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244745
{
public static readonly long[] Value={ 1L,-6L,134L,760L,3345L,12256L,39350L,114096L,307060L,776000L,1867170L,4298600L,9540169L,20487360L,42756520L,86967184L,172859325L,336450560L,642489660L,1205572920L,2226005750L,4049168800L,7264172196L,12864273920L,22507811570L,38936117376L,66640520250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244745Inst : IEnumerable<long>
{
public static readonly long[] Value=A244745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244745.Bytes);
public long this[int i]=>Value[i];

public static A244745Inst Instance=new A244745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244746
{
public static readonly long[] Value={ 1L,1L,4L,25L,116L,164L,194L,16481L,11690L,1664364L,136498136L,2564496436L,4064014L,491648100L,436491616160L,81368116641625L,9259254936490L,148136161649810L,164949369644900L,149364943691810L,362536161401640L,41616363643649040L,811166442536936160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244746Inst : IEnumerable<long>
{
public static readonly long[] Value=A244746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244746.Bytes);
public long this[int i]=>Value[i];

public static A244746Inst Instance=new A244746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244747
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,12L,17L,29L,45L,48L,81L,105L,108L,177L,245L,323L,324L,569L,648L,893L,1277L,1296L,2121L,2592L,3221L,4853L,5184L,7697L,11015L,15333L,15552L,25841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244747Inst : IEnumerable<long>
{
public static readonly long[] Value=A244747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244747.Bytes);
public long this[int i]=>Value[i];

public static A244747Inst Instance=new A244747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244748
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,12L,14L,16L,21L,22L,23L,25L,27L,28L,32L,38L,41L,44L,45L,46L,49L,52L,54L,58L,61L,64L,66L,69L,72L,78L,82L,83L,85L,87L,94L,96L,111L,112L,114L,116L,121L,122L,123L,125L,127L,128L,132L,138L,141L,144L,145L,146L,149L,152L,154L,158L,161L,164L,166L,169L,172L,178L,182L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244748Inst : IEnumerable<long>
{
public static readonly long[] Value=A244748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244748.Bytes);
public long this[int i]=>Value[i];

public static A244748Inst Instance=new A244748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244749
{
public static readonly long[] Value={ 2L,5L,6L,9L,10L,28L,29L,85L,86L,256L,257L,769L,770L,2308L,2309L,6925L,6926L,20776L,20777L,62329L,62330L,186988L,186989L,560965L,560966L,1682896L,1682897L,5048689L,5048690L,15146068L,15146069L,45438205L,45438206L,136314616L,136314617L,408943849L,408943850L,1226831548L,1226831549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244749Inst : IEnumerable<long>
{
public static readonly long[] Value=A244749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244749.Bytes);
public long this[int i]=>Value[i];

public static A244749Inst Instance=new A244749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244750
{
public static readonly long[] Value={ 0L,2L,3L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244750Inst : IEnumerable<long>
{
public static readonly long[] Value=A244750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244750.Bytes);
public long this[int i]=>Value[i];

public static A244750Inst Instance=new A244750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244751
{
public static readonly BigInteger[] Value={ 1L,4L,41L,1062L,98609L,41449418L,76876688017L,598204174499998L,BigInteger.Parse("19069330205237985089"),BigInteger.Parse("2462229757725772974948882"),BigInteger.Parse("1280330698557681260125588062425"),BigInteger.Parse("2672924626047136512609733349657605334"),BigInteger.Parse("22366552104466938320449948223074809365901745") };
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
public class A244751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244751Inst Instance=new A244751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244752
{
public static readonly long[] Value={ 17L,33L,37L,49L,73L,65L,65L,109L,129L,80L,81L,145L,193L,82L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244752Inst : IEnumerable<long>
{
public static readonly long[] Value=A244752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244752.Bytes);
public long this[int i]=>Value[i];

public static A244752Inst Instance=new A244752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244753
{
public static readonly BigInteger[] Value={ 1L,4L,45L,1494L,167321L,70339178L,118127981277L,818113700595166L,BigInteger.Parse("23602509419592675345"),BigInteger.Parse("2828610325004443707717522"),BigInteger.Parse("1397057668479359172475738134221"),BigInteger.Parse("2819825298850525709434498781240666534"),BigInteger.Parse("23097546959835633409694123795378169234099369") };
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
public class A244753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244753Inst Instance=new A244753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244754
{
public static readonly BigInteger[] Value={ 1L,3L,11L,51L,311L,2583L,30011L,495771L,11740271L,399511023L,19531952051L,1369534859091L,137461591250951L,19708614005005383L,4029559971566918891L,BigInteger.Parse("1172950335844577723211"),BigInteger.Parse("485515762655939377001951"),BigInteger.Parse("285459356061242116657495263"),BigInteger.Parse("238215406681004045293498284131") };
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
public class A244754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244754Inst Instance=new A244754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244755
{
public static readonly BigInteger[] Value={ 1L,3L,13L,87L,985L,19563L,697573L,44195007L,4985202865L,987432857043L,344306650353853L,209169206074748967L,BigInteger.Parse("222262777197258910345"),BigInteger.Parse("409907753371580011362363"),BigInteger.Parse("1317924525238880964004945813"),BigInteger.Parse("7341603216747343890845790989967"),BigInteger.Parse("71176841502529490992224798115792225") };
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
public class A244755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244755Inst Instance=new A244755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244756
{
public static readonly BigInteger[] Value={ 1L,4L,20L,136L,1424L,25504L,831680L,49526656L,5359464704L,1033951896064L,354410768092160L,213011725510260736L,BigInteger.Parse("224795751647646224384"),BigInteger.Parse("412813583857427719266304"),BigInteger.Parse("1323683536183041967893954560"),BigInteger.Parse("7361415226356149639592083685376"),BigInteger.Parse("71294465534894253722438522191806464") };
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
public class A244756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244756Inst Instance=new A244756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244757
{
public static readonly BigInteger[] Value={ 0L,1L,2L,37L,162L,3068518062211324L,BigInteger.Parse("1079268324684171943515797470873767312825026176345571319042096689270") };
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
public class A244757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244757Inst Instance=new A244757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244758
{
public static readonly long[] Value={ 0L,1L,3L,2L,1L,3L,3L,2L,2L,1L,3L,3L,1L,2L,9L,1L,3L,1L,1L,2L,9L,3L,2L,3L,1L,2L,1L,2L,1L,1L,23L,1L,3L,3L,1L,2L,1L,3L,1L,5L,1L,3L,1L,3L,3L,1L,3L,1L,3L,1L,2L,1L,3L,2L,2L,6L,2L,4L,1L,4L,2L,3L,2L,5L,53L,1L,1L,7L,1L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244758Inst : IEnumerable<long>
{
public static readonly long[] Value=A244758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244758.Bytes);
public long this[int i]=>Value[i];

public static A244758Inst Instance=new A244758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244759
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,5L,1L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,33L,1L,1L,1L,2L,3L,1L,1L,1L,2L,1L,3L,1L,3L,1L,1L,2L,2L,6L,1L,139L,1L,1L,1L,2L,2L,3L,2L,1L,3L,1L,1L,2L,4L,1L,2L,2L,1L,4L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244759Inst : IEnumerable<long>
{
public static readonly long[] Value=A244759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244759.Bytes);
public long this[int i]=>Value[i];

public static A244759Inst Instance=new A244759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244760
{
public static readonly BigInteger[] Value={ 1L,4L,24L,232L,3840L,111904L,5785344L,529662592L,85449338880L,24204383609344L,11986829259362304L,10361640102119729152UL,BigInteger.Parse("15589910824599107174400"),BigInteger.Parse("40815393380277274447519744"),BigInteger.Parse("185575767151388880816233447424"),BigInteger.Parse("1465910356757779350231777997914112") };
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
public class A244760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244760Inst Instance=new A244760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244761
{
public static readonly long[] Value={ 4L,1L,9L,16L,49L,11L,164L,481L,1649L,4936L,149L,18181L,944L,2541L,64169L,193616L,44049L,925491L,25494964L,8191681L,1251449L,416164936L,9813609L,361604981L,10936644L,1364949361L,449116169L,169814016L,4910361649L,11168164251L,164360168164L,901091681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244761Inst : IEnumerable<long>
{
public static readonly long[] Value=A244761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244761.Bytes);
public long this[int i]=>Value[i];

public static A244761Inst Instance=new A244761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244762
{
public static readonly long[] Value={ 1L,3L,10L,32L,99L,301L,908L,2730L,8197L,24599L,73806L,221428L,664295L,1992897L,5978704L,17936126L,53808393L,161425195L,484275602L,1452826824L,4358480491L,13075441493L,39226324500L,117678973522L,353036920589L,1059110761791L,3177332285398L,9531996856220L,28595990568687L,85787971706089L,257363915118296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244762Inst : IEnumerable<long>
{
public static readonly long[] Value=A244762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244762.Bytes);
public long this[int i]=>Value[i];

public static A244762Inst Instance=new A244762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244763
{
public static readonly long[] Value={ 13L,113L,313L,613L,1013L,1213L,1613L,1913L,2113L,2213L,2713L,3313L,3413L,3613L,4013L,4513L,4813L,5113L,5413L,5813L,6113L,7013L,7213L,8513L,8713L,9013L,9413L,9613L,10313L,10513L,10613L,11113L,11213L,11813L,12113L,12413L,12613L,12713L,13313L,13513L,13613L,13913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244763Inst : IEnumerable<long>
{
public static readonly long[] Value=A244763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244763.Bytes);
public long this[int i]=>Value[i];

public static A244763Inst Instance=new A244763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244764
{
public static readonly long[] Value={ 17L,317L,617L,1117L,1217L,2017L,2417L,2617L,2917L,3217L,3517L,3617L,3917L,4217L,4517L,4817L,5417L,5717L,6217L,6317L,6917L,7417L,7517L,7717L,7817L,8017L,8117L,8317L,9817L,11117L,11317L,11617L,11717L,12517L,12917L,13217L,13417L,14717L,15017L,15217L,15817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244764Inst : IEnumerable<long>
{
public static readonly long[] Value=A244764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244764.Bytes);
public long this[int i]=>Value[i];

public static A244764Inst Instance=new A244764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244765
{
public static readonly long[] Value={ 19L,419L,619L,719L,919L,1019L,1319L,1619L,2719L,2819L,3019L,3119L,3319L,3719L,3919L,4019L,4219L,4519L,4919L,5119L,5419L,5519L,6619L,6719L,7019L,7219L,7919L,8219L,8419L,8719L,8819L,9319L,9419L,9619L,9719L,11119L,11519L,11719L,12119L,12619L,12919L,13219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244765Inst : IEnumerable<long>
{
public static readonly long[] Value=A244765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244765.Bytes);
public long this[int i]=>Value[i];

public static A244765Inst Instance=new A244765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244766
{
public static readonly long[] Value={ 23L,223L,523L,823L,1123L,1223L,1423L,1523L,1723L,1823L,2423L,3023L,3323L,3623L,3823L,3923L,4423L,4523L,4723L,5023L,5323L,5623L,5923L,6323L,6823L,7523L,7723L,7823L,8123L,8423L,8623L,8923L,9323L,9623L,9923L,10223L,10723L,11423L,11923L,12323L,12823L,12923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244766Inst : IEnumerable<long>
{
public static readonly long[] Value=A244766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244766.Bytes);
public long this[int i]=>Value[i];

public static A244766Inst Instance=new A244766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244767
{
public static readonly long[] Value={ 29L,229L,829L,929L,1129L,1229L,1429L,2029L,2129L,2729L,3229L,3329L,3529L,3929L,4129L,4229L,4729L,6029L,6229L,6329L,6529L,6829L,7129L,7229L,7529L,7829L,8329L,8429L,8629L,8929L,9029L,9629L,9829L,9929L,10429L,10529L,10729L,11329L,12329L,12829L,13229L,13729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244767Inst : IEnumerable<long>
{
public static readonly long[] Value=A244767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244767.Bytes);
public long this[int i]=>Value[i];

public static A244767Inst Instance=new A244767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244768
{
public static readonly long[] Value={ 37L,137L,337L,937L,1237L,1637L,2137L,2237L,2437L,2837L,3037L,3137L,3637L,4337L,4637L,4937L,5237L,5437L,5737L,6037L,6337L,6637L,6737L,7237L,7537L,7937L,8237L,8537L,8737L,8837L,9137L,9337L,9437L,10037L,10337L,10837L,10937L,11437L,12037L,12437L,12637L,13037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244768Inst : IEnumerable<long>
{
public static readonly long[] Value=A244768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244768.Bytes);
public long this[int i]=>Value[i];

public static A244768Inst Instance=new A244768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244769
{
public static readonly long[] Value={ 43L,443L,643L,743L,1543L,2143L,2243L,2543L,2843L,3343L,3643L,3943L,4243L,4643L,4943L,5443L,5743L,5843L,6043L,6143L,6343L,7043L,7243L,7643L,8243L,8443L,8543L,9043L,9343L,9643L,9743L,10243L,10343L,11243L,11443L,11743L,12043L,12143L,12343L,12743L,13043L,14143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244769Inst : IEnumerable<long>
{
public static readonly long[] Value=A244769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244769.Bytes);
public long this[int i]=>Value[i];

public static A244769Inst Instance=new A244769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244770
{
public static readonly long[] Value={ 47L,347L,547L,647L,947L,1447L,1747L,1847L,2347L,2447L,2647L,3347L,3547L,3847L,3947L,4447L,4547L,5147L,5347L,5647L,6047L,6247L,6547L,6947L,7247L,7547L,8147L,8447L,8647L,8747L,9547L,10247L,10847L,11047L,11447L,12347L,12547L,12647L,13147L,14347L,14447L,14747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244770Inst : IEnumerable<long>
{
public static readonly long[] Value=A244770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244770.Bytes);
public long this[int i]=>Value[i];

public static A244770Inst Instance=new A244770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244771
{
public static readonly long[] Value={ 53L,353L,653L,853L,953L,1153L,1453L,1553L,1753L,2053L,2153L,2753L,2953L,3253L,3853L,4153L,4253L,5153L,5653L,5953L,6053L,6353L,6553L,6653L,7253L,7753L,7853L,8053L,8353L,8753L,10253L,10453L,10753L,10853L,11353L,11953L,12253L,12553L,12653L,12853L,12953L,13553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244771Inst : IEnumerable<long>
{
public static readonly long[] Value=A244771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244771.Bytes);
public long this[int i]=>Value[i];

public static A244771Inst Instance=new A244771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244772
{
public static readonly long[] Value={ 59L,359L,659L,859L,1259L,1459L,1559L,1759L,2459L,2659L,3259L,3359L,3559L,3659L,4159L,4259L,4759L,5059L,5659L,6359L,6659L,6959L,7159L,7459L,7559L,7759L,8059L,9059L,9859L,10159L,10259L,10459L,10559L,10859L,11059L,11159L,11959L,12659L,12959L,13159L,13259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244772Inst : IEnumerable<long>
{
public static readonly long[] Value=A244772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244772.Bytes);
public long this[int i]=>Value[i];

public static A244772Inst Instance=new A244772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244773
{
public static readonly long[] Value={ 67L,167L,367L,467L,967L,1367L,1567L,1667L,1867L,2267L,2467L,2767L,3067L,3167L,3467L,3767L,3967L,4567L,4967L,5167L,5867L,6067L,6367L,6967L,7867L,8167L,8467L,8867L,9067L,9467L,9767L,9967L,10067L,10267L,10567L,10667L,10867L,11467L,11867L,12967L,13267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244773Inst : IEnumerable<long>
{
public static readonly long[] Value=A244773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244773.Bytes);
public long this[int i]=>Value[i];

public static A244773Inst Instance=new A244773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244774
{
public static readonly long[] Value={ 73L,173L,373L,673L,773L,1373L,1873L,1973L,2273L,2473L,3373L,3673L,4073L,4273L,4373L,4673L,4973L,5273L,5573L,6073L,6173L,6373L,6473L,6673L,7573L,7673L,7873L,8273L,8573L,9173L,9473L,9973L,10273L,10973L,11173L,11273L,12073L,12373L,12473L,12973L,13873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244774Inst : IEnumerable<long>
{
public static readonly long[] Value=A244774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244774.Bytes);
public long this[int i]=>Value[i];

public static A244774Inst Instance=new A244774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244775
{
public static readonly long[] Value={ 79L,179L,379L,479L,1279L,1579L,1879L,1979L,2179L,2579L,2879L,3079L,3779L,4079L,4679L,5179L,5279L,5479L,5779L,5879L,6079L,6379L,6679L,6779L,7079L,7879L,8179L,8779L,9479L,9679L,10079L,10979L,11279L,11579L,11779L,12379L,12479L,12979L,13679L,13879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244775Inst : IEnumerable<long>
{
public static readonly long[] Value=A244775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244775.Bytes);
public long this[int i]=>Value[i];

public static A244775Inst Instance=new A244775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244776
{
public static readonly long[] Value={ 83L,283L,383L,683L,883L,983L,1283L,1483L,1583L,1783L,2083L,2383L,2683L,3083L,3583L,4283L,4483L,4583L,4783L,5483L,5683L,5783L,6883L,6983L,7283L,7583L,7883L,8783L,9283L,9883L,10883L,11083L,11383L,11483L,11783L,12583L,12983L,13183L,13883L,14083L,14683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244776Inst : IEnumerable<long>
{
public static readonly long[] Value=A244776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244776.Bytes);
public long this[int i]=>Value[i];

public static A244776Inst Instance=new A244776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244777
{
public static readonly long[] Value={ 89L,389L,1289L,1489L,1789L,1889L,2089L,2389L,2689L,2789L,3089L,3389L,3889L,3989L,4289L,4789L,4889L,5189L,5689L,6089L,6389L,6689L,7489L,7589L,7789L,8089L,8389L,8689L,9689L,10289L,10589L,10789L,10889L,11489L,11689L,11789L,12289L,12589L,12689L,12889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244777Inst : IEnumerable<long>
{
public static readonly long[] Value=A244777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244777.Bytes);
public long this[int i]=>Value[i];

public static A244777Inst Instance=new A244777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244778
{
public static readonly long[] Value={ 97L,197L,397L,797L,997L,1097L,1297L,1597L,1697L,1997L,2297L,2797L,2897L,3697L,3797L,4297L,4397L,4597L,5197L,5297L,5897L,6197L,6397L,6997L,7297L,8297L,8597L,9397L,9497L,9697L,10597L,11197L,11497L,11597L,11897L,12097L,12197L,12497L,12697L,13297L,13397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244778Inst : IEnumerable<long>
{
public static readonly long[] Value=A244778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244778.Bytes);
public long this[int i]=>Value[i];

public static A244778Inst Instance=new A244778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244779
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,14L,16L,22L,23L,28L,29L,32L,37L,43L,44L,46L,53L,56L,58L,64L,67L,71L,74L,77L,79L,86L,88L,92L,106L,107L,109L,112L,113L,116L,121L,127L,128L,134L,137L,142L,148L,149L,151L,154L,158L,161L,163L,172L,176L,179L,184L,191L,193L,197L,203L,211L,212L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244779Inst : IEnumerable<long>
{
public static readonly long[] Value=A244779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244779.Bytes);
public long this[int i]=>Value[i];

public static A244779Inst Instance=new A244779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244780
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,23L,25L,27L,31L,33L,37L,45L,47L,53L,55L,59L,67L,69L,71L,75L,81L,89L,93L,97L,99L,103L,111L,113L,115L,125L,135L,137L,141L,155L,157L,159L,163L,165L,177L,179L,181L,185L,191L,199L,201L,207L,213L,223L,225L,229L,235L,243L,251L,253L,257L,265L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244780Inst : IEnumerable<long>
{
public static readonly long[] Value=A244780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244780.Bytes);
public long this[int i]=>Value[i];

public static A244780Inst Instance=new A244780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244781
{
public static readonly long[] Value={ 2L,2L,4L,8L,12L,24L,36L,72L,144L,252L,504L,864L,1728L,2952L,5904L,11808L,21888L,43776L,79920L,159840L,290160L,580320L,1051200L,2102400L,4204800L,8010000L,16020000L,30189600L,60379200L,113252400L,226504800L,423828000L,847656000L,1584075600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244781Inst : IEnumerable<long>
{
public static readonly long[] Value=A244781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244781.Bytes);
public long this[int i]=>Value[i];

public static A244781Inst Instance=new A244781Inst();

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