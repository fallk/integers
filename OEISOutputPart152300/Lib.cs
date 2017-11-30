using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195405
{
public static readonly long[] Value={ 9L,2L,4L,8L,7L,5L,3L,9L,1L,0L,5L,0L,2L,2L,5L,1L,3L,0L,6L,6L,2L,6L,2L,5L,1L,7L,3L,5L,1L,2L,7L,4L,5L,4L,1L,0L,7L,5L,2L,6L,0L,3L,3L,5L,1L,6L,5L,1L,0L,7L,9L,4L,9L,3L,7L,5L,4L,9L,9L,2L,8L,7L,4L,8L,9L,5L,6L,7L,6L,4L,5L,9L,7L,1L,1L,9L,6L,7L,4L,8L,8L,3L,6L,5L,6L,5L,2L,1L,1L,4L,4L,1L,6L,1L,0L,2L,5L,4L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195405Inst : IEnumerable<long>
{
public static readonly long[] Value=A195405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195405.Bytes);
public long this[int i]=>Value[i];

public static A195405Inst Instance=new A195405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195406
{
public static readonly long[] Value={ 6L,0L,2L,5L,6L,1L,3L,9L,1L,2L,8L,6L,1L,1L,4L,8L,6L,1L,7L,9L,4L,1L,5L,7L,2L,2L,9L,1L,1L,6L,8L,4L,7L,1L,7L,8L,6L,3L,8L,5L,7L,4L,5L,3L,6L,2L,9L,6L,6L,4L,0L,6L,1L,3L,7L,0L,4L,5L,5L,2L,3L,8L,4L,6L,2L,3L,4L,6L,6L,8L,3L,6L,1L,2L,1L,4L,7L,7L,2L,7L,4L,9L,7L,8L,2L,7L,2L,9L,9L,9L,0L,1L,8L,7L,3L,1L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195406Inst : IEnumerable<long>
{
public static readonly long[] Value=A195406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195406.Bytes);
public long this[int i]=>Value[i];

public static A195406Inst Instance=new A195406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195407
{
public static readonly long[] Value={ 5L,1L,2L,5L,2L,2L,2L,7L,2L,3L,6L,2L,2L,2L,5L,3L,7L,9L,2L,6L,3L,5L,4L,9L,4L,5L,5L,8L,1L,0L,7L,3L,5L,5L,1L,6L,9L,4L,7L,8L,2L,1L,9L,0L,8L,2L,6L,1L,4L,2L,4L,2L,5L,7L,4L,2L,0L,1L,3L,0L,4L,2L,4L,3L,2L,2L,0L,8L,9L,6L,5L,5L,7L,2L,5L,0L,5L,7L,7L,4L,0L,5L,1L,8L,9L,2L,2L,1L,3L,7L,8L,5L,6L,1L,3L,0L,7L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195407Inst : IEnumerable<long>
{
public static readonly long[] Value=A195407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195407.Bytes);
public long this[int i]=>Value[i];

public static A195407Inst Instance=new A195407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195408
{
public static readonly long[] Value={ 6L,1L,1L,9L,2L,5L,9L,5L,8L,1L,2L,5L,9L,0L,9L,7L,6L,8L,1L,1L,4L,8L,3L,8L,0L,1L,4L,4L,0L,1L,1L,7L,0L,7L,3L,8L,9L,1L,9L,7L,3L,5L,9L,3L,3L,2L,2L,6L,3L,5L,9L,0L,0L,3L,8L,0L,1L,2L,5L,7L,4L,9L,5L,7L,9L,0L,0L,8L,0L,7L,8L,3L,8L,6L,7L,6L,4L,6L,9L,8L,7L,4L,1L,9L,9L,1L,3L,8L,6L,4L,4L,5L,1L,1L,6L,1L,9L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195408Inst : IEnumerable<long>
{
public static readonly long[] Value=A195408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195408.Bytes);
public long this[int i]=>Value[i];

public static A195408Inst Instance=new A195408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195409
{
public static readonly long[] Value={ 7L,1L,2L,7L,8L,7L,9L,1L,7L,3L,8L,5L,2L,0L,1L,2L,3L,3L,8L,0L,1L,6L,0L,9L,4L,6L,9L,7L,2L,6L,8L,2L,7L,1L,4L,1L,7L,5L,3L,6L,0L,7L,6L,5L,8L,6L,6L,8L,5L,4L,6L,6L,9L,8L,4L,2L,4L,8L,1L,2L,2L,8L,5L,5L,4L,1L,6L,3L,4L,0L,6L,1L,1L,8L,1L,9L,2L,3L,1L,9L,4L,8L,0L,4L,3L,8L,8L,6L,7L,5L,2L,7L,4L,6L,6L,0L,0L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195409Inst : IEnumerable<long>
{
public static readonly long[] Value=A195409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195409.Bytes);
public long this[int i]=>Value[i];

public static A195409Inst Instance=new A195409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195410
{
public static readonly long[] Value={ 4L,6L,2L,9L,9L,9L,2L,8L,1L,8L,7L,2L,9L,4L,5L,1L,4L,5L,2L,5L,2L,4L,9L,1L,5L,0L,8L,8L,0L,0L,5L,4L,7L,8L,7L,1L,6L,2L,5L,0L,7L,4L,6L,2L,2L,4L,2L,6L,4L,0L,6L,4L,3L,1L,7L,5L,1L,9L,0L,9L,4L,4L,8L,2L,9L,9L,3L,2L,7L,6L,6L,5L,8L,4L,3L,7L,5L,6L,1L,8L,7L,5L,0L,9L,0L,4L,1L,7L,1L,3L,4L,1L,1L,0L,7L,0L,4L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195410Inst : IEnumerable<long>
{
public static readonly long[] Value=A195410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195410.Bytes);
public long this[int i]=>Value[i];

public static A195410Inst Instance=new A195410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195411
{
public static readonly long[] Value={ 6L,2L,9L,7L,8L,7L,2L,0L,2L,2L,0L,0L,9L,1L,5L,1L,1L,5L,5L,8L,4L,3L,1L,7L,8L,2L,0L,2L,0L,7L,6L,2L,4L,2L,9L,0L,1L,2L,4L,9L,2L,0L,7L,0L,2L,7L,5L,8L,5L,4L,9L,3L,4L,3L,9L,5L,9L,7L,0L,0L,0L,9L,8L,1L,3L,7L,7L,3L,1L,1L,3L,4L,1L,0L,7L,7L,9L,5L,2L,1L,2L,0L,6L,7L,3L,6L,7L,6L,7L,3L,0L,7L,0L,5L,6L,2L,8L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195411Inst : IEnumerable<long>
{
public static readonly long[] Value=A195411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195411.Bytes);
public long this[int i]=>Value[i];

public static A195411Inst Instance=new A195411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195412
{
public static readonly long[] Value={ 3L,2L,6L,8L,5L,0L,5L,3L,9L,8L,0L,7L,1L,2L,0L,6L,3L,7L,7L,1L,0L,0L,2L,1L,3L,3L,3L,6L,8L,5L,3L,8L,6L,5L,8L,9L,3L,3L,0L,4L,0L,5L,7L,8L,5L,6L,4L,9L,3L,4L,6L,0L,1L,3L,3L,6L,0L,9L,8L,0L,3L,4L,6L,4L,6L,2L,9L,0L,5L,1L,3L,6L,7L,8L,6L,1L,7L,0L,4L,5L,2L,8L,9L,0L,5L,2L,8L,9L,7L,5L,7L,9L,2L,6L,9L,2L,9L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195412Inst : IEnumerable<long>
{
public static readonly long[] Value=A195412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195412.Bytes);
public long this[int i]=>Value[i];

public static A195412Inst Instance=new A195412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195413
{
public static readonly long[] Value={ 7L,7L,7L,7L,7L,3L,1L,7L,7L,7L,5L,1L,2L,1L,1L,5L,6L,6L,8L,6L,8L,4L,0L,3L,3L,8L,9L,2L,2L,1L,5L,4L,7L,4L,5L,8L,6L,3L,0L,2L,5L,5L,4L,4L,9L,2L,3L,1L,4L,4L,4L,0L,4L,7L,4L,0L,9L,4L,4L,8L,6L,0L,5L,7L,1L,5L,7L,9L,1L,1L,4L,8L,5L,8L,4L,2L,2L,6L,3L,9L,6L,6L,9L,8L,1L,4L,7L,1L,6L,1L,7L,5L,0L,7L,0L,6L,0L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195413Inst : IEnumerable<long>
{
public static readonly long[] Value=A195413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195413.Bytes);
public long this[int i]=>Value[i];

public static A195413Inst Instance=new A195413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195414
{
public static readonly long[] Value={ 6L,4L,9L,5L,1L,6L,0L,5L,0L,2L,9L,2L,0L,9L,4L,5L,3L,2L,4L,4L,9L,9L,3L,9L,5L,2L,6L,3L,7L,4L,2L,5L,2L,4L,7L,5L,8L,1L,4L,1L,8L,7L,5L,7L,5L,9L,9L,5L,3L,5L,1L,0L,7L,5L,6L,6L,3L,8L,3L,8L,5L,2L,2L,9L,2L,8L,8L,4L,5L,4L,9L,7L,1L,6L,2L,6L,9L,8L,8L,7L,3L,3L,6L,7L,7L,6L,6L,2L,9L,4L,8L,0L,8L,7L,6L,3L,4L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195414Inst : IEnumerable<long>
{
public static readonly long[] Value=A195414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195414.Bytes);
public long this[int i]=>Value[i];

public static A195414Inst Instance=new A195414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195415
{
public static readonly BigInteger[] Value={ 1L,2L,10L,92L,1351L,28982L,855100L,33214232L,1642999501L,100843185962L,7520379392890L,669760178257172L,70211429619908851L,8558006664633638942L,BigInteger.Parse("1200128210993564085880"),BigInteger.Parse("191861070874818576596912"),BigInteger.Parse("34685967730611200643509401"),BigInteger.Parse("7041037426518318365605795922") };
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
public class A195415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195415Inst Instance=new A195415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195416
{
public static readonly long[] Value={ 2L,3L,19L,29L,31L,59L,73L,149L,179L,199L,211L,271L,281L,311L,337L,347L,349L,359L,433L,449L,479L,523L,547L,659L,661L,683L,727L,733L,809L,821L,823L,829L,857L,877L,947L,977L,983L,1049L,1129L,1181L,1201L,1213L,1291L,1297L,1301L,1307L,1321L,1367L,1429L,1433L,1439L,1451L,1489L,1493L,1511L,1553L,1567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195416Inst : IEnumerable<long>
{
public static readonly long[] Value=A195416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195416.Bytes);
public long this[int i]=>Value[i];

public static A195416Inst Instance=new A195416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195417
{
public static readonly long[] Value={ 1L,3L,9L,25L,63L,171L,471L,1193L,3209L,8841L,22537L,60393L,165489L,424451L,1134849L,3093893L,7987289L,21288933L,57973543L,150409931L,399788279L,1085870421L,2831439537L,7501994181L,20330726077L,53274740933L,140615421393L,380366331549L,1002078031627L,2634444052559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195417Inst : IEnumerable<long>
{
public static readonly long[] Value=A195417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195417.Bytes);
public long this[int i]=>Value[i];

public static A195417Inst Instance=new A195417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195418
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,33L,5L,33L,341L,1045L,189L,1299L,891L,4437L,9477L,581L,3855L,105525L,27825L,23751L,173043L,10531345L,56511L,2386125L,380955L,256861L,24926139L,5108467L,32397379L,930343095L,930291L,36512775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195418Inst : IEnumerable<long>
{
public static readonly long[] Value=A195418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195418.Bytes);
public long this[int i]=>Value[i];

public static A195418Inst Instance=new A195418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195419
{
public static readonly long[] Value={ 8L,18L,27L,28L,33L,34L,36L,37L,38L,44L,46L,47L,48L,49L,57L,58L,68L,75L,76L,77L,78L,81L,82L,83L,85L,86L,87L,88L,89L,94L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195419Inst : IEnumerable<long>
{
public static readonly long[] Value=A195419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195419.Bytes);
public long this[int i]=>Value[i];

public static A195419Inst Instance=new A195419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195420
{
public static readonly long[] Value={ 125L,126L,127L,2500L,2501L,2502L,2503L,2504L,2505L,2506L,2507L,2508L,6144L,11663L,11664L,12100L,12101L,12102L,12103L,12104L,12105L,12106L,12107L,12108L,12768L,13822L,13823L,13824L,13825L,15378L,15567L,15585L,15612L,15617L,15620L,15621L,15622L,15623L,15624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195420Inst : IEnumerable<long>
{
public static readonly long[] Value=A195420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195420.Bytes);
public long this[int i]=>Value[i];

public static A195420Inst Instance=new A195420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195421
{
public static readonly BigInteger[] Value={ 3L,17L,3L,253124999L,4076863487L,578415690713087L,139967L,BigInteger.Parse("14097567309074239886172287"),BigInteger.Parse("73099303486215558911"),BigInteger.Parse("8954942912818222989311"),BigInteger.Parse("213770812332484473348458269897727733773465812991"),578415690713087L,BigInteger.Parse("66266428660760838427050496741110705203446361497484562431") };
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
public class A195421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195421Inst Instance=new A195421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195422
{
public static readonly long[] Value={ -3L,2L,2L,-8L,16L,-16L,80L,384L,4160L,43008L,494336L,6136832L,82118656L,1178294272L,18053433344L,294241402880L,5083946115072L,92835116318720L,1786595439869952L,36144509314138112L,766933328068345856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195422Inst : IEnumerable<long>
{
public static readonly long[] Value=A195422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195422.Bytes);
public long this[int i]=>Value[i];

public static A195422Inst Instance=new A195422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195423
{
public static readonly long[] Value={ 0L,4L,6L,1L,9L,1L,4L,1L,7L,9L,3L,2L,2L,4L,2L,0L,6L,7L,6L,2L,8L,6L,2L,0L,4L,9L,5L,8L,1L,2L,9L,9L,0L,5L,8L,3L,2L,4L,3L,8L,6L,4L,2L,5L,4L,3L,0L,4L,1L,0L,1L,5L,1L,9L,0L,5L,0L,7L,8L,4L,1L,4L,4L,4L,2L,5L,9L,4L,2L,7L,1L,2L,9L,5L,3L,4L,4L,9L,1L,5L,9L,9L,4L,1L,5L,9L,7L,1L,3L,9L,0L,2L,3L,4L,1L,9L,6L,6L,6L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195423Inst : IEnumerable<long>
{
public static readonly long[] Value=A195423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195423.Bytes);
public long this[int i]=>Value[i];

public static A195423Inst Instance=new A195423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195424
{
public static readonly long[] Value={ 5L,8L,4L,7L,1L,3L,2L,5L,5L,9L,5L,0L,1L,4L,2L,2L,4L,5L,6L,7L,6L,1L,2L,1L,4L,1L,6L,4L,2L,7L,0L,6L,2L,1L,7L,4L,5L,9L,1L,6L,1L,6L,2L,7L,0L,2L,9L,2L,0L,4L,7L,0L,4L,5L,4L,7L,8L,0L,8L,9L,1L,5L,8L,3L,6L,9L,1L,8L,0L,5L,9L,4L,1L,7L,7L,6L,9L,8L,5L,7L,4L,3L,1L,8L,8L,1L,4L,1L,4L,4L,1L,1L,7L,3L,8L,7L,4L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195424Inst : IEnumerable<long>
{
public static readonly long[] Value=A195424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195424.Bytes);
public long this[int i]=>Value[i];

public static A195424Inst Instance=new A195424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195425
{
public static readonly long[] Value={ 4L,6L,1L,9L,7L,4L,5L,4L,3L,9L,8L,3L,9L,2L,0L,2L,0L,4L,1L,2L,3L,3L,4L,1L,3L,5L,5L,1L,1L,2L,8L,8L,7L,5L,1L,3L,2L,9L,8L,3L,3L,3L,9L,2L,9L,7L,2L,3L,9L,9L,1L,7L,2L,4L,3L,7L,1L,4L,5L,8L,3L,1L,5L,5L,8L,0L,6L,0L,9L,4L,1L,2L,3L,1L,3L,1L,7L,1L,1L,6L,7L,7L,8L,1L,2L,3L,0L,2L,3L,2L,0L,7L,4L,5L,6L,0L,8L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195425Inst : IEnumerable<long>
{
public static readonly long[] Value=A195425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195425.Bytes);
public long this[int i]=>Value[i];

public static A195425Inst Instance=new A195425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195426
{
public static readonly long[] Value={ 1L,3L,8L,2L,1L,1L,5L,8L,6L,0L,2L,8L,3L,0L,9L,9L,8L,8L,2L,6L,2L,0L,7L,5L,3L,9L,9L,1L,3L,0L,7L,2L,8L,0L,2L,7L,9L,6L,5L,1L,8L,4L,5L,0L,4L,8L,2L,3L,5L,7L,9L,5L,9L,2L,6L,9L,4L,3L,5L,8L,5L,0L,5L,0L,6L,0L,8L,5L,3L,2L,2L,1L,3L,5L,1L,9L,2L,4L,4L,8L,4L,5L,0L,1L,0L,0L,3L,8L,2L,2L,7L,4L,4L,9L,2L,4L,2L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195426Inst : IEnumerable<long>
{
public static readonly long[] Value=A195426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195426.Bytes);
public long this[int i]=>Value[i];

public static A195426Inst Instance=new A195426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195427
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,4L,4L,2L,3L,2L,2L,5L,9L,6L,9L,8L,0L,5L,1L,3L,3L,2L,5L,9L,6L,3L,6L,3L,2L,5L,9L,7L,9L,7L,9L,3L,1L,2L,0L,8L,2L,0L,5L,9L,2L,3L,8L,6L,3L,6L,7L,9L,5L,7L,6L,4L,6L,8L,9L,2L,4L,2L,6L,6L,4L,9L,6L,6L,3L,4L,6L,2L,0L,7L,7L,2L,0L,8L,7L,9L,0L,4L,1L,4L,8L,0L,4L,8L,3L,2L,3L,8L,8L,1L,7L,7L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195427Inst : IEnumerable<long>
{
public static readonly long[] Value=A195427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195427.Bytes);
public long this[int i]=>Value[i];

public static A195427Inst Instance=new A195427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195428
{
public static readonly long[] Value={ 5L,4L,7L,5L,5L,9L,7L,9L,0L,6L,2L,3L,7L,4L,8L,1L,9L,4L,9L,7L,8L,0L,9L,9L,1L,0L,4L,0L,6L,1L,8L,1L,2L,0L,6L,8L,9L,4L,1L,2L,4L,9L,9L,2L,3L,2L,7L,6L,0L,9L,9L,2L,1L,5L,8L,8L,6L,0L,5L,9L,9L,6L,3L,0L,0L,6L,9L,2L,9L,4L,7L,9L,9L,8L,3L,8L,6L,1L,5L,7L,2L,0L,0L,1L,0L,8L,4L,5L,1L,6L,4L,1L,2L,8L,5L,3L,7L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195428Inst : IEnumerable<long>
{
public static readonly long[] Value=A195428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195428.Bytes);
public long this[int i]=>Value[i];

public static A195428Inst Instance=new A195428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195429
{
public static readonly long[] Value={ 5L,1L,7L,3L,5L,3L,1L,7L,6L,9L,8L,3L,7L,2L,5L,8L,2L,9L,8L,7L,7L,0L,6L,2L,9L,5L,8L,5L,1L,6L,9L,4L,5L,9L,7L,3L,6L,9L,1L,8L,7L,6L,6L,2L,8L,8L,3L,4L,7L,7L,9L,1L,4L,5L,8L,0L,7L,8L,6L,2L,8L,2L,2L,6L,5L,2L,8L,7L,0L,9L,0L,5L,8L,2L,6L,1L,4L,0L,1L,9L,2L,3L,8L,7L,1L,8L,8L,0L,3L,9L,1L,8L,1L,3L,2L,8L,6L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195429Inst : IEnumerable<long>
{
public static readonly long[] Value=A195429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195429.Bytes);
public long this[int i]=>Value[i];

public static A195429Inst Instance=new A195429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195430
{
public static readonly long[] Value={ 1L,0L,6L,7L,1L,1L,6L,5L,0L,3L,6L,7L,1L,3L,5L,9L,4L,3L,5L,0L,4L,0L,6L,6L,1L,9L,1L,8L,2L,1L,2L,5L,9L,6L,0L,2L,6L,8L,7L,8L,6L,6L,7L,0L,4L,4L,8L,6L,1L,3L,2L,0L,4L,4L,4L,6L,5L,3L,9L,1L,7L,8L,9L,4L,6L,0L,7L,8L,6L,0L,5L,1L,2L,1L,4L,6L,9L,3L,4L,5L,5L,7L,5L,6L,2L,3L,1L,7L,9L,8L,4L,7L,6L,0L,2L,9L,4L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195430Inst : IEnumerable<long>
{
public static readonly long[] Value=A195430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195430.Bytes);
public long this[int i]=>Value[i];

public static A195430Inst Instance=new A195430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195431
{
public static readonly long[] Value={ 8L,4L,5L,5L,7L,1L,8L,1L,7L,5L,1L,2L,6L,5L,2L,7L,6L,2L,6L,9L,2L,1L,0L,8L,8L,0L,8L,0L,5L,4L,2L,1L,9L,2L,0L,8L,2L,2L,4L,0L,4L,3L,6L,0L,1L,4L,3L,4L,1L,9L,9L,2L,7L,6L,2L,8L,4L,5L,8L,1L,0L,0L,3L,1L,4L,5L,7L,9L,6L,3L,5L,7L,2L,1L,3L,9L,1L,2L,0L,9L,7L,2L,3L,0L,7L,6L,9L,8L,2L,9L,1L,1L,1L,6L,1L,9L,2L,3L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195431Inst : IEnumerable<long>
{
public static readonly long[] Value=A195431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195431.Bytes);
public long this[int i]=>Value[i];

public static A195431Inst Instance=new A195431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195432
{
public static readonly long[] Value={ 6L,0L,7L,5L,1L,0L,3L,7L,4L,5L,4L,1L,9L,3L,4L,5L,0L,6L,9L,0L,2L,4L,5L,8L,4L,2L,1L,1L,9L,5L,9L,4L,0L,3L,0L,2L,1L,9L,8L,6L,4L,6L,8L,1L,8L,7L,8L,2L,5L,7L,4L,7L,1L,6L,6L,8L,6L,5L,9L,0L,4L,3L,0L,1L,0L,1L,6L,3L,1L,9L,4L,3L,7L,9L,6L,7L,4L,6L,7L,1L,1L,7L,9L,5L,0L,6L,8L,9L,6L,3L,2L,6L,3L,3L,1L,0L,6L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195432Inst : IEnumerable<long>
{
public static readonly long[] Value=A195432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195432.Bytes);
public long this[int i]=>Value[i];

public static A195432Inst Instance=new A195432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195433
{
public static readonly long[] Value={ 6L,1L,4L,7L,5L,7L,2L,2L,7L,2L,3L,3L,3L,9L,0L,6L,2L,1L,5L,9L,3L,3L,1L,9L,2L,4L,8L,0L,9L,1L,1L,9L,0L,0L,9L,9L,4L,7L,1L,1L,6L,2L,5L,4L,4L,6L,2L,5L,6L,9L,8L,3L,6L,3L,8L,5L,8L,2L,6L,4L,6L,7L,2L,6L,2L,1L,6L,2L,5L,6L,1L,1L,4L,6L,1L,7L,9L,6L,2L,0L,4L,1L,6L,1L,6L,8L,8L,1L,5L,6L,9L,9L,9L,1L,9L,3L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195433Inst : IEnumerable<long>
{
public static readonly long[] Value=A195433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195433.Bytes);
public long this[int i]=>Value[i];

public static A195433Inst Instance=new A195433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195434
{
public static readonly long[] Value={ 6L,4L,8L,7L,8L,2L,1L,3L,4L,1L,2L,6L,1L,6L,1L,2L,8L,5L,3L,8L,8L,8L,0L,3L,0L,3L,8L,0L,7L,6L,6L,9L,3L,5L,6L,0L,6L,1L,9L,4L,0L,3L,5L,5L,7L,0L,5L,8L,6L,7L,9L,5L,2L,3L,3L,9L,6L,4L,1L,2L,8L,3L,6L,3L,6L,8L,3L,3L,2L,9L,8L,5L,3L,3L,9L,6L,2L,2L,6L,7L,3L,0L,3L,5L,9L,1L,4L,7L,7L,3L,5L,6L,8L,8L,4L,0L,8L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195434Inst : IEnumerable<long>
{
public static readonly long[] Value=A195434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195434.Bytes);
public long this[int i]=>Value[i];

public static A195434Inst Instance=new A195434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195435
{
public static readonly long[] Value={ 1L,3L,8L,7L,3L,1L,2L,7L,2L,8L,3L,1L,3L,8L,2L,0L,9L,1L,7L,4L,6L,3L,3L,6L,0L,2L,4L,0L,9L,8L,2L,2L,3L,3L,2L,1L,2L,5L,9L,6L,4L,4L,1L,8L,6L,2L,5L,1L,6L,9L,7L,6L,7L,6L,7L,4L,7L,6L,5L,4L,1L,2L,8L,4L,2L,3L,5L,6L,2L,8L,3L,4L,5L,5L,0L,0L,9L,7L,1L,9L,7L,9L,4L,1L,5L,3L,7L,9L,6L,0L,7L,3L,5L,5L,9L,4L,5L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195435Inst : IEnumerable<long>
{
public static readonly long[] Value=A195435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195435.Bytes);
public long this[int i]=>Value[i];

public static A195435Inst Instance=new A195435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195436
{
public static readonly long[] Value={ 6L,3L,6L,2L,5L,8L,8L,2L,1L,0L,6L,1L,8L,3L,8L,3L,0L,8L,3L,9L,1L,0L,4L,9L,4L,6L,4L,7L,1L,0L,4L,3L,7L,5L,9L,8L,2L,9L,4L,2L,4L,3L,3L,0L,0L,8L,7L,6L,1L,6L,2L,8L,8L,5L,0L,0L,2L,6L,7L,6L,5L,8L,5L,1L,0L,8L,4L,8L,1L,3L,7L,7L,6L,0L,3L,6L,0L,0L,4L,4L,4L,8L,7L,7L,2L,6L,6L,5L,6L,5L,0L,1L,9L,9L,7L,7L,4L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195436Inst : IEnumerable<long>
{
public static readonly long[] Value=A195436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195436.Bytes);
public long this[int i]=>Value[i];

public static A195436Inst Instance=new A195436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195437
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,14L,17L,19L,21L,23L,26L,28L,30L,32L,34L,37L,39L,41L,43L,45L,47L,50L,52L,54L,56L,58L,60L,62L,65L,67L,69L,71L,73L,75L,77L,79L,82L,84L,86L,88L,90L,92L,94L,96L,98L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,122L,124L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195437Inst : IEnumerable<long>
{
public static readonly long[] Value=A195437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195437.Bytes);
public long this[int i]=>Value[i];

public static A195437Inst Instance=new A195437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195438
{
public static readonly long[] Value={ 141494L,143413L,144113L,144417L,144453L,144533L,144544L,144744L,148334L,150908L,150918L,151153L,151157L,151688L,151767L,151787L,151898L,154144L,155113L,155133L,155138L,155158L,155577L,155707L,155757L,155788L,155813L,157157L,157557L,157753L,157813L,158113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195438Inst : IEnumerable<long>
{
public static readonly long[] Value=A195438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195438.Bytes);
public long this[int i]=>Value[i];

public static A195438Inst Instance=new A195438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195439
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,16L,23L,26L,32L,37L,64L,89L,149L,173L,251L,307L,317L,956L,30197L,46058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195439Inst : IEnumerable<long>
{
public static readonly long[] Value=A195439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195439.Bytes);
public long this[int i]=>Value[i];

public static A195439Inst Instance=new A195439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195440
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,134L,968L,7662L,65135L,587040L,5559342L,54965230L,564651110L,6004908296L,65920345700L,745289233564L,8661959227407L,103330815828292L,1263608418272768L,15823268263301680L,202712359166886406L,2654710188935753950L,BigInteger.Parse("35514167158635839770") };
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
public class A195440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195440Inst Instance=new A195440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195441
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,2L,6L,3L,10L,2L,6L,2L,210L,30L,6L,3L,30L,10L,210L,42L,330L,30L,30L,30L,546L,42L,14L,2L,30L,2L,462L,231L,3570L,210L,6L,2L,51870L,2730L,210L,42L,2310L,330L,2310L,210L,4830L,210L,210L,210L,6630L,1326L,858L,66L,330L,110L,798L,114L,870L,30L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195441Inst : IEnumerable<long>
{
public static readonly long[] Value=A195441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195441.Bytes);
public long this[int i]=>Value[i];

public static A195441Inst Instance=new A195441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195442
{
public static readonly BigInteger[] Value={ 1L,4L,38L,604L,13797L,416168L,15711490L,715565508L,38278167466L,2356801113088L,164391501446500L,12826066272723832L,1107734575497955773L,BigInteger.Parse("104985517080964044744"),BigInteger.Parse("10838759916371136482170"),BigInteger.Parse("1211294776167588947134004"),BigInteger.Parse("145737426974188872882131694") };
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
public class A195442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195442Inst Instance=new A195442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195443
{
public static readonly BigInteger[] Value={ 1L,2L,17L,268L,6218L,191092L,7331943L,338203880L,18267488524L,1132962942756L,79464790795184L,6226443470442668L,539554771302358998L,BigInteger.Parse("51273487668881045852"),BigInteger.Parse("5305090125544931178395"),BigInteger.Parse("593952571797108683880684"),BigInteger.Parse("71571203087218842477715328"),BigInteger.Parse("9238664328667537859230164188") };
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
public class A195443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195443Inst Instance=new A195443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195444
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,6L,4L,8L,6L,9L,4L,3L,5L,2L,7L,6L,7L,1L,8L,6L,7L,5L,9L,0L,8L,9L,5L,5L,5L,1L,8L,7L,7L,7L,3L,5L,1L,2L,3L,8L,9L,1L,0L,5L,1L,4L,0L,2L,3L,5L,9L,5L,2L,4L,1L,1L,9L,9L,6L,4L,0L,3L,7L,9L,6L,8L,4L,1L,2L,6L,3L,7L,5L,2L,0L,3L,6L,5L,0L,4L,8L,6L,0L,7L,9L,5L,8L,1L,1L,3L,9L,7L,2L,3L,4L,1L,9L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195444Inst : IEnumerable<long>
{
public static readonly long[] Value=A195444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195444.Bytes);
public long this[int i]=>Value[i];

public static A195444Inst Instance=new A195444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195445
{
public static readonly long[] Value={ 6L,0L,1L,9L,5L,1L,6L,4L,4L,9L,0L,2L,1L,0L,9L,2L,7L,8L,2L,6L,3L,3L,7L,5L,8L,2L,4L,3L,3L,0L,3L,7L,4L,1L,6L,3L,5L,4L,2L,6L,3L,8L,1L,1L,4L,9L,5L,6L,4L,2L,9L,1L,5L,9L,5L,5L,0L,8L,2L,4L,1L,1L,2L,1L,3L,9L,3L,7L,1L,4L,5L,5L,3L,6L,4L,4L,0L,6L,2L,4L,0L,7L,4L,7L,6L,8L,6L,1L,9L,7L,6L,4L,4L,6L,6L,2L,0L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195445Inst : IEnumerable<long>
{
public static readonly long[] Value=A195445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195445.Bytes);
public long this[int i]=>Value[i];

public static A195445Inst Instance=new A195445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195446
{
public static readonly long[] Value={ 6L,5L,8L,0L,5L,2L,5L,9L,6L,8L,2L,3L,1L,4L,3L,9L,7L,9L,5L,9L,1L,2L,2L,6L,4L,9L,3L,8L,8L,7L,8L,9L,4L,3L,8L,6L,6L,6L,0L,8L,2L,7L,9L,8L,0L,7L,1L,5L,6L,3L,6L,8L,4L,9L,1L,7L,5L,2L,8L,9L,9L,0L,2L,6L,1L,5L,7L,1L,6L,3L,0L,5L,6L,9L,9L,4L,8L,4L,7L,7L,6L,5L,9L,2L,8L,5L,4L,3L,4L,9L,0L,5L,1L,8L,7L,7L,6L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195446Inst : IEnumerable<long>
{
public static readonly long[] Value=A195446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195446.Bytes);
public long this[int i]=>Value[i];

public static A195446Inst Instance=new A195446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195447
{
public static readonly long[] Value={ 1L,8L,0L,1L,8L,6L,6L,2L,4L,2L,4L,7L,4L,4L,9L,4L,6L,0L,8L,4L,7L,6L,8L,6L,9L,5L,5L,0L,8L,9L,8L,5L,4L,1L,3L,2L,7L,3L,2L,0L,1L,3L,0L,8L,1L,3L,4L,9L,9L,3L,3L,7L,6L,7L,8L,8L,7L,9L,9L,2L,0L,1L,0L,7L,7L,9L,9L,5L,3L,6L,2L,0L,2L,8L,4L,4L,8L,8L,8L,3L,8L,7L,8L,2L,5L,1L,0L,5L,9L,0L,6L,4L,2L,0L,4L,3L,1L,0L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195447Inst : IEnumerable<long>
{
public static readonly long[] Value=A195447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195447.Bytes);
public long this[int i]=>Value[i];

public static A195447Inst Instance=new A195447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195448
{
public static readonly long[] Value={ 1L,5L,6L,3L,1L,9L,1L,0L,3L,6L,6L,7L,5L,6L,7L,7L,4L,9L,2L,4L,7L,0L,0L,3L,6L,7L,4L,1L,2L,9L,7L,1L,4L,5L,4L,0L,4L,7L,4L,4L,9L,8L,0L,7L,0L,3L,8L,3L,7L,4L,3L,2L,0L,7L,6L,5L,2L,1L,0L,8L,7L,5L,3L,3L,7L,0L,4L,0L,4L,6L,2L,7L,2L,9L,1L,3L,4L,7L,9L,3L,3L,8L,8L,2L,5L,8L,0L,1L,4L,2L,1L,0L,5L,6L,0L,3L,3L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195448Inst : IEnumerable<long>
{
public static readonly long[] Value=A195448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195448.Bytes);
public long this[int i]=>Value[i];

public static A195448Inst Instance=new A195448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195449
{
public static readonly long[] Value={ 5L,6L,1L,7L,0L,8L,1L,6L,9L,7L,8L,3L,3L,4L,4L,5L,9L,5L,1L,7L,8L,9L,1L,5L,7L,7L,2L,9L,4L,0L,4L,7L,3L,9L,5L,6L,0L,3L,4L,0L,3L,8L,8L,0L,0L,2L,4L,5L,9L,2L,5L,6L,8L,4L,0L,2L,5L,6L,5L,9L,8L,4L,3L,8L,4L,8L,9L,1L,0L,8L,5L,4L,3L,8L,7L,7L,7L,9L,4L,2L,7L,1L,9L,7L,7L,1L,3L,4L,8L,3L,9L,8L,9L,9L,0L,9L,4L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195449Inst : IEnumerable<long>
{
public static readonly long[] Value=A195449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195449.Bytes);
public long this[int i]=>Value[i];

public static A195449Inst Instance=new A195449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195450
{
public static readonly long[] Value={ 1L,2L,7L,5L,7L,0L,6L,9L,9L,4L,4L,4L,0L,0L,5L,5L,2L,7L,6L,4L,5L,0L,3L,7L,8L,5L,5L,6L,2L,9L,1L,5L,3L,5L,2L,8L,7L,5L,2L,2L,8L,4L,4L,7L,8L,4L,4L,9L,8L,3L,3L,3L,9L,8L,7L,9L,3L,6L,7L,0L,3L,0L,2L,3L,1L,4L,9L,2L,5L,0L,0L,7L,8L,6L,0L,5L,6L,3L,7L,3L,4L,3L,6L,0L,6L,4L,1L,4L,5L,3L,9L,6L,2L,7L,5L,9L,0L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195450Inst : IEnumerable<long>
{
public static readonly long[] Value=A195450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195450.Bytes);
public long this[int i]=>Value[i];

public static A195450Inst Instance=new A195450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195451
{
public static readonly long[] Value={ 2L,3L,4L,1L,1L,6L,0L,7L,9L,3L,0L,7L,3L,3L,2L,1L,9L,7L,5L,6L,1L,4L,8L,5L,3L,3L,8L,1L,3L,7L,6L,3L,8L,3L,4L,9L,3L,4L,2L,4L,4L,2L,5L,3L,8L,8L,6L,7L,8L,4L,4L,6L,8L,7L,5L,5L,7L,4L,6L,5L,0L,5L,2L,2L,5L,5L,1L,8L,6L,1L,7L,6L,4L,9L,3L,5L,2L,2L,3L,4L,7L,9L,6L,5L,6L,5L,8L,7L,1L,7L,9L,4L,6L,1L,0L,5L,3L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195451Inst : IEnumerable<long>
{
public static readonly long[] Value=A195451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195451.Bytes);
public long this[int i]=>Value[i];

public static A195451Inst Instance=new A195451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195452
{
public static readonly long[] Value={ 1L,7L,4L,9L,9L,9L,1L,1L,3L,2L,9L,1L,2L,7L,8L,8L,9L,6L,8L,3L,6L,6L,2L,7L,9L,5L,8L,7L,7L,9L,2L,2L,9L,5L,9L,7L,1L,0L,5L,1L,7L,8L,7L,3L,1L,6L,4L,8L,6L,5L,0L,4L,1L,1L,6L,0L,4L,8L,8L,9L,1L,7L,8L,9L,6L,4L,1L,7L,7L,5L,9L,5L,4L,0L,7L,2L,3L,8L,6L,3L,2L,5L,0L,1L,6L,9L,8L,0L,5L,3L,2L,4L,3L,0L,6L,8L,2L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195452Inst : IEnumerable<long>
{
public static readonly long[] Value=A195452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195452.Bytes);
public long this[int i]=>Value[i];

public static A195452Inst Instance=new A195452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195453
{
public static readonly long[] Value={ 6L,2L,3L,6L,5L,0L,7L,9L,8L,0L,2L,9L,4L,1L,4L,9L,0L,5L,4L,9L,6L,6L,3L,8L,8L,6L,2L,5L,2L,9L,4L,7L,9L,7L,6L,9L,0L,5L,1L,3L,3L,9L,4L,3L,5L,5L,3L,4L,5L,7L,7L,0L,7L,0L,5L,1L,6L,0L,9L,6L,5L,2L,8L,9L,6L,5L,5L,7L,5L,9L,6L,2L,1L,5L,8L,4L,9L,4L,6L,8L,1L,8L,4L,6L,7L,2L,5L,6L,4L,1L,9L,5L,2L,3L,2L,9L,4L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195453Inst : IEnumerable<long>
{
public static readonly long[] Value=A195453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195453.Bytes);
public long this[int i]=>Value[i];

public static A195453Inst Instance=new A195453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195454
{
public static readonly long[] Value={ 8L,8L,7L,3L,6L,6L,3L,8L,9L,6L,4L,8L,5L,9L,1L,6L,1L,8L,6L,2L,7L,9L,8L,1L,8L,0L,5L,9L,7L,3L,8L,0L,8L,7L,5L,8L,1L,3L,5L,9L,3L,9L,8L,5L,0L,2L,4L,3L,8L,6L,0L,9L,1L,1L,2L,1L,6L,9L,3L,1L,1L,7L,8L,6L,5L,9L,7L,8L,4L,4L,4L,6L,5L,3L,6L,2L,5L,9L,2L,1L,0L,0L,7L,0L,0L,8L,7L,0L,0L,3L,9L,6L,5L,8L,9L,1L,5L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195454Inst : IEnumerable<long>
{
public static readonly long[] Value=A195454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195454.Bytes);
public long this[int i]=>Value[i];

public static A195454Inst Instance=new A195454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195455
{
public static readonly long[] Value={ 1L,4L,8L,0L,6L,3L,4L,6L,1L,0L,1L,1L,1L,7L,3L,9L,3L,2L,9L,2L,8L,0L,6L,7L,8L,6L,5L,6L,4L,1L,5L,6L,3L,5L,3L,1L,5L,8L,9L,4L,1L,0L,1L,5L,1L,8L,3L,5L,9L,9L,8L,2L,3L,8L,2L,1L,5L,1L,7L,7L,4L,5L,3L,3L,9L,2L,3L,8L,6L,3L,2L,4L,5L,6L,4L,3L,9L,1L,0L,6L,4L,8L,7L,8L,7L,2L,9L,1L,2L,1L,5L,7L,7L,3L,5L,5L,9L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195455Inst : IEnumerable<long>
{
public static readonly long[] Value=A195455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195455.Bytes);
public long this[int i]=>Value[i];

public static A195455Inst Instance=new A195455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195456
{
public static readonly long[] Value={ 1L,0L,3L,9L,0L,8L,1L,4L,7L,6L,5L,9L,6L,9L,8L,9L,2L,3L,0L,5L,5L,0L,3L,1L,1L,6L,2L,1L,1L,2L,9L,7L,8L,9L,1L,0L,3L,0L,4L,1L,8L,7L,9L,6L,3L,9L,5L,4L,0L,3L,7L,6L,8L,1L,8L,9L,3L,8L,7L,8L,7L,0L,8L,0L,5L,9L,7L,8L,5L,4L,1L,3L,5L,3L,1L,5L,9L,9L,7L,9L,0L,3L,1L,4L,5L,6L,9L,5L,2L,5L,5L,6L,5L,2L,3L,6L,1L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195456Inst : IEnumerable<long>
{
public static readonly long[] Value=A195456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195456.Bytes);
public long this[int i]=>Value[i];

public static A195456Inst Instance=new A195456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195457
{
public static readonly long[] Value={ 6L,3L,3L,0L,1L,2L,2L,8L,1L,0L,0L,0L,5L,8L,0L,7L,6L,6L,0L,0L,5L,5L,6L,0L,8L,8L,7L,9L,4L,6L,0L,6L,8L,1L,5L,1L,7L,2L,5L,3L,4L,0L,2L,4L,6L,5L,2L,9L,0L,7L,5L,0L,4L,5L,1L,5L,4L,9L,5L,2L,8L,3L,3L,1L,1L,6L,7L,6L,6L,2L,4L,7L,2L,9L,7L,3L,8L,1L,6L,8L,8L,9L,2L,9L,3L,3L,2L,0L,4L,4L,9L,1L,9L,5L,7L,6L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195457Inst : IEnumerable<long>
{
public static readonly long[] Value=A195457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195457.Bytes);
public long this[int i]=>Value[i];

public static A195457Inst Instance=new A195457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195458
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,16L,32L,96L,288L,864L,2592L,7776L,23328L,69984L,279936L,1119744L,4478976L,17915904L,71663616L,286654464L,1146617856L,4586471424L,18345885696L,91729428480L,458647142400L,2293235712000L,11466178560000L,57330892800000L,286654464000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195458Inst : IEnumerable<long>
{
public static readonly long[] Value=A195458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195458.Bytes);
public long this[int i]=>Value[i];

public static A195458Inst Instance=new A195458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195459
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,3L,6L,4L,9L,4L,10L,6L,12L,6L,12L,8L,16L,9L,18L,8L,18L,10L,22L,12L,20L,12L,27L,12L,28L,12L,30L,16L,30L,16L,24L,18L,36L,18L,36L,16L,40L,18L,42L,20L,36L,22L,46L,24L,42L,20L,48L,24L,52L,27L,40L,24L,54L,28L,58L,24L,60L,30L,54L,32L,48L,30L,66L,32L,66L,24L,70L,36L,72L,36L,60L,36L,60L,36L,78L,32L,81L,40L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195459Inst : IEnumerable<long>
{
public static readonly long[] Value=A195459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195459.Bytes);
public long this[int i]=>Value[i];

public static A195459Inst Instance=new A195459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195460
{
public static readonly long[] Value={ 1L,19L,103L,463L,1951L,7999L,32383L,130303L,522751L,2094079L,8382463L,33542143L,134193151L,536821759L,2147385343L,8589737983L,34359345151L,137438167039L,549754241023L,2199020109823L,8796086730751L,35184359505919L,140737463189503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195460Inst : IEnumerable<long>
{
public static readonly long[] Value=A195460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195460.Bytes);
public long this[int i]=>Value[i];

public static A195460Inst Instance=new A195460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195461
{
public static readonly BigInteger[] Value={ 19L,103L,463L,1951L,130303L,8589737983L,36028796616310783L,144115187270549503L,BigInteger.Parse("147573952563906609151"),BigInteger.Parse("9444732965533131997183"),BigInteger.Parse("158456325028527830762157768703"),BigInteger.Parse("10889035741470030830606626508932068147199"),BigInteger.Parse("3064991081731777716716694050586798249381337419669831679") };
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
public class A195461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195461Inst Instance=new A195461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195462
{
public static readonly BigInteger[] Value={ 1L,3L,22L,600L,78912L,60963840L,325173657600L,13743074967552000L,BigInteger.Parse("5190968541142056960000"),BigInteger.Parse("19502847300506769948672000000"),BigInteger.Parse("802654006697267902579055001600000000"),BigInteger.Parse("395082050396018659026474786525020160000000000") };
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
public class A195462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195462Inst Instance=new A195462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195463
{
public static readonly long[] Value={ 11L,23L,71L,263L,1031L,4103L,16391L,65543L,262151L,1048583L,4194311L,16777223L,67108871L,268435463L,1073741831L,4294967303L,17179869191L,68719476743L,274877906951L,1099511627783L,4398046511111L,17592186044423L,70368744177671L,281474976710663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195463Inst : IEnumerable<long>
{
public static readonly long[] Value=A195463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195463.Bytes);
public long this[int i]=>Value[i];

public static A195463Inst Instance=new A195463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195464
{
public static readonly BigInteger[] Value={ 13L,139L,2083L,32899L,524803L,8390659L,134225923L,2147516419L,34359869443L,549756338179L,8796095119363L,140737496743939L,2251799847239683L,36028797153181699L,576460752840294403L,9223372039002259459UL,BigInteger.Parse("147573952598266347523"),BigInteger.Parse("2361183241469182345219") };
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
public class A195464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195464Inst Instance=new A195464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195465
{
public static readonly long[] Value={ 0L,5L,5L,17L,5L,6L,14L,6L,24L,75L,2L,4L,27L,11L,48L,50L,46L,9L,21L,7L,16L,137L,4L,55L,85L,14L,111L,24L,102L,291L,67L,89L,155L,180L,137L,330L,127L,413L,250L,241L,332L,619L,139L,234L,453L,929L,94L,160L,169L,22L,131L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195465Inst : IEnumerable<long>
{
public static readonly long[] Value=A195465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195465.Bytes);
public long this[int i]=>Value[i];

public static A195465Inst Instance=new A195465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195466
{
public static readonly BigInteger[] Value={ 45L,945L,14175L,467775L,638512875L,1915538625L,488462349375L,7795859096025L,32157918771103125L,316985199315159375L,BigInteger.Parse("3028793579456347828125"),BigInteger.Parse("478230565177318078125"),BigInteger.Parse("3952575621190533915703125"),BigInteger.Parse("28304394023345413370350078125"),BigInteger.Parse("7217620475953080409439269921875"),BigInteger.Parse("21652861427859241228317809765625") };
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
public class A195466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195466Inst Instance=new A195466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195467
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,0L,1L,3L,2L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,3L,2L,6L,7L,5L,4L,12L,13L,15L,14L,10L,11L,9L,8L,0L,1L,2L,3L,5L,4L,7L,6L,10L,11L,8L,9L,15L,14L,13L,12L,0L,1L,3L,2L,7L,6L,4L,5L,15L,14L,12L,13L,8L,9L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195467Inst : IEnumerable<long>
{
public static readonly long[] Value=A195467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195467.Bytes);
public long this[int i]=>Value[i];

public static A195467Inst Instance=new A195467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195468
{
public static readonly long[] Value={ 85487L,104651L,253241L,280601L,458987L,580337L,1082399L,1207361L,1251947L,1678541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195468Inst : IEnumerable<long>
{
public static readonly long[] Value=A195468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195468.Bytes);
public long this[int i]=>Value[i];

public static A195468Inst Instance=new A195468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195469
{
public static readonly long[] Value={ 101L,103L,106L,183L,255L,266L,271L,272L,278L,312L,300L,323L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195469Inst : IEnumerable<long>
{
public static readonly long[] Value=A195469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195469.Bytes);
public long this[int i]=>Value[i];

public static A195469Inst Instance=new A195469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195470
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,2L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,1L,0L,0L,0L,5L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195470Inst : IEnumerable<long>
{
public static readonly long[] Value=A195470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195470.Bytes);
public long this[int i]=>Value[i];

public static A195470Inst Instance=new A195470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195471
{
public static readonly long[] Value={ 6L,3L,5L,0L,7L,4L,3L,6L,8L,6L,2L,0L,6L,6L,8L,1L,3L,7L,5L,6L,2L,1L,5L,7L,6L,6L,1L,6L,4L,5L,4L,6L,4L,6L,0L,8L,6L,9L,7L,6L,8L,0L,5L,0L,0L,0L,7L,5L,5L,5L,1L,9L,3L,1L,3L,2L,1L,8L,6L,7L,4L,2L,2L,9L,2L,7L,5L,7L,4L,9L,4L,0L,4L,3L,3L,5L,5L,5L,9L,7L,7L,8L,3L,2L,0L,1L,1L,3L,4L,1L,5L,5L,5L,7L,0L,6L,3L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195471Inst : IEnumerable<long>
{
public static readonly long[] Value=A195471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195471.Bytes);
public long this[int i]=>Value[i];

public static A195471Inst Instance=new A195471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195472
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,4L,8L,9L,8L,3L,6L,7L,2L,5L,6L,4L,4L,8L,0L,4L,2L,5L,9L,7L,1L,2L,5L,1L,8L,3L,3L,8L,0L,3L,5L,9L,6L,8L,2L,9L,8L,2L,7L,8L,2L,9L,1L,7L,5L,7L,2L,5L,8L,7L,9L,4L,6L,3L,3L,8L,7L,3L,8L,2L,7L,8L,3L,1L,4L,6L,7L,6L,3L,1L,5L,0L,5L,5L,9L,5L,0L,5L,5L,3L,6L,6L,3L,7L,1L,0L,8L,6L,8L,9L,0L,6L,1L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195472Inst : IEnumerable<long>
{
public static readonly long[] Value=A195472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195472.Bytes);
public long this[int i]=>Value[i];

public static A195472Inst Instance=new A195472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195473
{
public static readonly long[] Value={ 8L,3L,1L,9L,7L,7L,5L,6L,0L,2L,8L,9L,1L,6L,3L,2L,0L,4L,5L,9L,3L,0L,2L,3L,8L,1L,1L,4L,8L,1L,9L,6L,7L,8L,2L,7L,4L,4L,1L,2L,5L,0L,3L,0L,4L,9L,9L,1L,9L,8L,6L,7L,8L,3L,5L,4L,9L,3L,4L,1L,1L,3L,7L,0L,4L,5L,9L,1L,4L,2L,8L,7L,4L,9L,7L,7L,6L,9L,9L,2L,5L,9L,7L,0L,5L,8L,3L,3L,2L,4L,3L,6L,9L,8L,7L,6L,3L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195473Inst : IEnumerable<long>
{
public static readonly long[] Value=A195473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195473.Bytes);
public long this[int i]=>Value[i];

public static A195473Inst Instance=new A195473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195474
{
public static readonly long[] Value={ 6L,2L,6L,9L,5L,0L,1L,1L,2L,3L,5L,3L,4L,9L,0L,9L,2L,5L,3L,9L,3L,5L,2L,7L,5L,2L,4L,8L,8L,7L,7L,1L,5L,8L,9L,1L,9L,9L,9L,2L,6L,8L,6L,2L,7L,2L,9L,9L,8L,6L,9L,2L,3L,1L,1L,3L,4L,7L,5L,9L,8L,0L,7L,8L,6L,2L,3L,7L,0L,1L,9L,8L,1L,6L,3L,6L,7L,0L,3L,1L,8L,5L,3L,1L,4L,0L,2L,9L,7L,1L,5L,8L,4L,8L,9L,9L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195474Inst : IEnumerable<long>
{
public static readonly long[] Value=A195474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195474.Bytes);
public long this[int i]=>Value[i];

public static A195474Inst Instance=new A195474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195475
{
public static readonly long[] Value={ 6L,4L,3L,8L,4L,6L,3L,1L,3L,2L,9L,8L,7L,4L,3L,5L,3L,1L,5L,6L,9L,3L,7L,2L,1L,0L,7L,2L,1L,1L,8L,0L,9L,7L,2L,0L,6L,7L,5L,1L,9L,8L,1L,6L,0L,8L,2L,1L,8L,5L,8L,7L,2L,8L,7L,9L,9L,8L,8L,4L,7L,9L,2L,4L,7L,7L,6L,0L,4L,9L,3L,3L,7L,6L,7L,7L,9L,9L,8L,3L,9L,1L,9L,0L,0L,8L,7L,9L,2L,8L,3L,1L,3L,7L,8L,0L,4L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195475Inst : IEnumerable<long>
{
public static readonly long[] Value=A195475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195475.Bytes);
public long this[int i]=>Value[i];

public static A195475Inst Instance=new A195475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195476
{
public static readonly long[] Value={ 1L,2L,7L,2L,2L,2L,4L,6L,5L,6L,0L,9L,0L,3L,5L,2L,3L,3L,6L,6L,0L,8L,1L,4L,1L,9L,8L,1L,3L,6L,9L,2L,1L,8L,6L,0L,9L,5L,4L,9L,2L,0L,7L,5L,8L,8L,9L,4L,2L,5L,6L,3L,3L,0L,6L,9L,5L,6L,9L,4L,3L,5L,5L,8L,7L,1L,3L,6L,7L,4L,5L,3L,7L,4L,5L,2L,9L,4L,1L,8L,2L,3L,6L,0L,9L,7L,8L,6L,3L,3L,3L,5L,0L,1L,1L,8L,1L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195476Inst : IEnumerable<long>
{
public static readonly long[] Value=A195476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195476.Bytes);
public long this[int i]=>Value[i];

public static A195476Inst Instance=new A195476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195477
{
public static readonly long[] Value={ 9L,8L,8L,6L,5L,9L,2L,6L,2L,9L,8L,1L,9L,3L,8L,8L,4L,1L,7L,1L,3L,0L,9L,5L,8L,6L,3L,8L,8L,3L,8L,2L,5L,2L,4L,0L,3L,0L,6L,3L,3L,4L,0L,6L,3L,5L,4L,4L,3L,7L,8L,5L,1L,8L,2L,0L,8L,1L,0L,0L,4L,8L,2L,6L,1L,1L,8L,6L,8L,8L,8L,2L,0L,4L,0L,6L,8L,1L,2L,5L,5L,6L,8L,6L,4L,5L,6L,7L,3L,2L,1L,8L,6L,2L,9L,0L,6L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195477Inst : IEnumerable<long>
{
public static readonly long[] Value=A195477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195477.Bytes);
public long this[int i]=>Value[i];

public static A195477Inst Instance=new A195477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195478
{
public static readonly long[] Value={ 6L,1L,3L,8L,4L,1L,7L,2L,5L,3L,9L,4L,1L,8L,6L,8L,1L,0L,6L,6L,0L,3L,6L,7L,2L,4L,6L,0L,0L,1L,3L,9L,4L,0L,2L,6L,6L,0L,7L,4L,8L,2L,7L,9L,6L,4L,8L,4L,2L,3L,9L,2L,9L,9L,9L,3L,8L,3L,0L,9L,0L,1L,7L,7L,7L,0L,9L,5L,7L,8L,7L,7L,1L,4L,1L,7L,5L,6L,4L,4L,4L,3L,6L,8L,4L,1L,2L,8L,9L,0L,4L,7L,2L,2L,2L,1L,4L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195478Inst : IEnumerable<long>
{
public static readonly long[] Value=A195478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195478.Bytes);
public long this[int i]=>Value[i];

public static A195478Inst Instance=new A195478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195479
{
public static readonly long[] Value={ 1L,2L,4L,4L,0L,6L,2L,1L,5L,6L,7L,5L,4L,7L,3L,6L,9L,8L,9L,2L,5L,4L,6L,9L,2L,9L,7L,6L,1L,3L,4L,4L,1L,4L,4L,0L,6L,9L,0L,1L,1L,4L,2L,6L,7L,9L,8L,3L,5L,1L,2L,6L,3L,8L,8L,2L,6L,0L,1L,5L,8L,3L,0L,3L,1L,7L,0L,7L,6L,7L,2L,1L,2L,4L,1L,2L,7L,3L,4L,6L,1L,2L,0L,3L,4L,7L,1L,6L,2L,2L,1L,5L,0L,0L,5L,1L,5L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195479Inst : IEnumerable<long>
{
public static readonly long[] Value=A195479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195479.Bytes);
public long this[int i]=>Value[i];

public static A195479Inst Instance=new A195479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195480
{
public static readonly long[] Value={ 1L,9L,9L,5L,8L,6L,7L,2L,4L,7L,8L,9L,6L,3L,9L,1L,3L,9L,0L,9L,8L,1L,6L,3L,6L,0L,0L,6L,7L,8L,2L,6L,5L,0L,4L,1L,5L,8L,1L,1L,5L,7L,4L,4L,8L,7L,2L,2L,1L,5L,9L,4L,7L,8L,1L,0L,0L,0L,3L,0L,2L,0L,0L,2L,1L,7L,3L,1L,6L,3L,9L,8L,4L,2L,4L,8L,7L,8L,1L,9L,7L,8L,8L,4L,2L,1L,1L,1L,5L,7L,8L,0L,4L,1L,3L,3L,4L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195480Inst : IEnumerable<long>
{
public static readonly long[] Value=A195480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195480.Bytes);
public long this[int i]=>Value[i];

public static A195480Inst Instance=new A195480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195481
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,1L,7L,4L,0L,3L,9L,3L,7L,7L,6L,0L,3L,6L,5L,7L,9L,2L,8L,0L,7L,7L,5L,9L,7L,6L,7L,0L,7L,8L,5L,4L,9L,7L,6L,1L,1L,2L,8L,6L,4L,0L,3L,9L,0L,3L,9L,1L,2L,0L,2L,3L,9L,6L,2L,7L,2L,4L,9L,7L,5L,2L,9L,7L,0L,0L,4L,2L,7L,4L,9L,4L,9L,7L,9L,5L,3L,7L,5L,0L,6L,9L,6L,2L,0L,8L,5L,1L,9L,0L,4L,8L,6L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195481Inst : IEnumerable<long>
{
public static readonly long[] Value=A195481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195481.Bytes);
public long this[int i]=>Value[i];

public static A195481Inst Instance=new A195481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195482
{
public static readonly long[] Value={ 6L,3L,5L,2L,6L,8L,6L,0L,4L,8L,3L,9L,3L,3L,6L,2L,1L,8L,8L,1L,1L,5L,0L,6L,2L,7L,8L,2L,7L,6L,4L,4L,5L,8L,5L,2L,0L,1L,9L,8L,1L,8L,7L,6L,3L,7L,9L,6L,2L,3L,1L,6L,4L,1L,6L,6L,5L,4L,9L,0L,3L,9L,5L,0L,9L,2L,3L,2L,4L,9L,7L,4L,7L,8L,4L,8L,9L,0L,1L,9L,2L,5L,2L,7L,0L,1L,9L,9L,5L,0L,1L,6L,9L,5L,6L,6L,2L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195482Inst : IEnumerable<long>
{
public static readonly long[] Value=A195482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195482.Bytes);
public long this[int i]=>Value[i];

public static A195482Inst Instance=new A195482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195483
{
public static readonly long[] Value={ 9L,0L,5L,3L,4L,7L,0L,9L,3L,0L,8L,3L,6L,4L,7L,2L,1L,7L,2L,3L,6L,0L,7L,6L,5L,7L,6L,7L,8L,5L,6L,8L,4L,5L,4L,6L,1L,7L,8L,0L,0L,6L,3L,3L,9L,6L,0L,4L,8L,0L,3L,3L,7L,3L,8L,2L,0L,9L,5L,3L,7L,3L,3L,6L,5L,1L,5L,7L,8L,5L,9L,6L,6L,5L,7L,7L,8L,9L,2L,5L,8L,5L,0L,0L,9L,0L,3L,9L,2L,4L,7L,4L,0L,7L,0L,6L,2L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195483Inst : IEnumerable<long>
{
public static readonly long[] Value=A195483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195483.Bytes);
public long this[int i]=>Value[i];

public static A195483Inst Instance=new A195483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195484
{
public static readonly long[] Value={ 1L,7L,0L,6L,0L,4L,6L,3L,5L,0L,3L,4L,4L,2L,3L,2L,4L,4L,2L,2L,8L,5L,4L,1L,9L,9L,0L,4L,0L,9L,8L,4L,7L,0L,6L,0L,7L,6L,2L,3L,6L,8L,0L,2L,8L,8L,7L,3L,0L,0L,1L,5L,3L,3L,5L,0L,3L,6L,2L,4L,1L,9L,6L,8L,3L,9L,0L,7L,0L,1L,0L,6L,1L,2L,2L,0L,0L,2L,7L,4L,7L,9L,4L,9L,7L,7L,8L,4L,3L,2L,5L,8L,8L,0L,1L,6L,8L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195484Inst : IEnumerable<long>
{
public static readonly long[] Value=A195484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195484.Bytes);
public long this[int i]=>Value[i];

public static A195484Inst Instance=new A195484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195485
{
public static readonly long[] Value={ 1L,2L,9L,4L,2L,3L,8L,9L,2L,3L,6L,9L,2L,2L,7L,3L,8L,7L,4L,3L,3L,4L,5L,6L,7L,8L,9L,9L,6L,5L,6L,5L,5L,0L,5L,9L,4L,6L,4L,0L,8L,1L,9L,5L,8L,2L,9L,5L,1L,9L,7L,0L,1L,8L,3L,0L,3L,2L,9L,5L,3L,4L,0L,2L,4L,7L,2L,2L,1L,7L,9L,1L,1L,7L,9L,0L,2L,0L,9L,5L,3L,6L,0L,0L,2L,8L,4L,7L,7L,3L,2L,3L,6L,3L,9L,2L,3L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195485Inst : IEnumerable<long>
{
public static readonly long[] Value=A195485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195485.Bytes);
public long this[int i]=>Value[i];

public static A195485Inst Instance=new A195485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195486
{
public static readonly long[] Value={ 6L,2L,0L,3L,3L,2L,2L,7L,2L,6L,5L,3L,0L,2L,5L,8L,3L,8L,0L,5L,5L,6L,8L,6L,8L,3L,7L,2L,0L,6L,0L,7L,6L,8L,8L,6L,4L,8L,3L,6L,1L,3L,4L,8L,2L,5L,4L,2L,4L,8L,1L,9L,1L,4L,6L,1L,8L,9L,3L,2L,4L,2L,5L,0L,2L,3L,7L,3L,1L,4L,7L,9L,0L,4L,8L,7L,0L,3L,3L,4L,1L,5L,9L,1L,5L,2L,4L,7L,6L,8L,7L,4L,2L,0L,1L,3L,7L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195486Inst : IEnumerable<long>
{
public static readonly long[] Value=A195486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195486.Bytes);
public long this[int i]=>Value[i];

public static A195486Inst Instance=new A195486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195487
{
public static readonly long[] Value={ 1L,6L,4L,8L,0L,4L,0L,7L,3L,4L,5L,9L,5L,5L,1L,8L,8L,1L,2L,3L,3L,0L,7L,4L,0L,7L,0L,0L,9L,4L,8L,4L,8L,8L,9L,2L,2L,2L,3L,4L,2L,5L,1L,2L,5L,1L,9L,9L,2L,0L,3L,5L,7L,8L,6L,0L,3L,5L,7L,3L,9L,0L,9L,3L,4L,3L,2L,9L,9L,6L,6L,9L,6L,6L,4L,8L,2L,3L,6L,9L,4L,9L,7L,1L,6L,9L,3L,2L,4L,3L,7L,6L,2L,1L,9L,6L,0L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195487Inst : IEnumerable<long>
{
public static readonly long[] Value=A195487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195487.Bytes);
public long this[int i]=>Value[i];

public static A195487Inst Instance=new A195487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195488
{
public static readonly long[] Value={ 2L,6L,5L,9L,6L,8L,4L,7L,2L,2L,7L,6L,3L,0L,1L,5L,7L,8L,2L,8L,6L,9L,3L,1L,5L,8L,7L,6L,5L,0L,6L,1L,2L,3L,1L,9L,7L,2L,2L,0L,9L,7L,7L,0L,3L,4L,5L,3L,4L,2L,9L,3L,4L,0L,4L,1L,2L,1L,6L,6L,2L,3L,1L,6L,8L,7L,6L,3L,1L,8L,7L,1L,6L,8L,8L,0L,8L,1L,7L,7L,1L,2L,0L,1L,7L,2L,9L,6L,9L,9L,7L,2L,9L,4L,0L,2L,1L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195488Inst : IEnumerable<long>
{
public static readonly long[] Value=A195488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195488.Bytes);
public long this[int i]=>Value[i];

public static A195488Inst Instance=new A195488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195489
{
public static readonly long[] Value={ 1L,8L,1L,7L,3L,6L,3L,6L,0L,0L,5L,7L,5L,5L,1L,7L,6L,2L,3L,7L,6L,2L,6L,3L,8L,9L,1L,1L,6L,4L,7L,5L,9L,5L,6L,6L,8L,5L,4L,1L,3L,7L,5L,2L,6L,2L,5L,3L,1L,7L,7L,8L,7L,3L,9L,7L,1L,8L,3L,3L,8L,4L,8L,0L,5L,1L,0L,8L,2L,7L,7L,5L,8L,9L,2L,3L,7L,3L,9L,2L,9L,8L,2L,4L,3L,6L,3L,5L,9L,0L,1L,2L,3L,5L,2L,5L,2L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195489Inst : IEnumerable<long>
{
public static readonly long[] Value=A195489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195489.Bytes);
public long this[int i]=>Value[i];

public static A195489Inst Instance=new A195489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195490
{
public static readonly long[] Value={ 6L,3L,5L,0L,0L,3L,8L,3L,3L,3L,3L,6L,2L,3L,7L,3L,5L,2L,4L,7L,0L,2L,1L,2L,1L,9L,0L,3L,6L,9L,3L,5L,0L,3L,5L,9L,3L,1L,9L,3L,7L,8L,2L,0L,9L,4L,7L,3L,1L,4L,8L,3L,5L,1L,7L,0L,6L,8L,1L,4L,0L,6L,5L,2L,9L,7L,0L,2L,5L,4L,4L,1L,6L,5L,9L,8L,5L,1L,3L,1L,3L,7L,7L,1L,4L,9L,2L,3L,0L,8L,8L,2L,4L,9L,0L,9L,4L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195490Inst : IEnumerable<long>
{
public static readonly long[] Value=A195490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195490.Bytes);
public long this[int i]=>Value[i];

public static A195490Inst Instance=new A195490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195491
{
public static readonly long[] Value={ 6L,2L,9L,5L,8L,1L,0L,6L,1L,3L,8L,7L,7L,1L,6L,0L,4L,4L,0L,4L,5L,4L,9L,5L,8L,7L,5L,6L,8L,8L,5L,4L,0L,6L,9L,2L,2L,3L,1L,6L,8L,4L,9L,0L,8L,3L,8L,6L,6L,0L,7L,0L,2L,9L,6L,5L,1L,1L,2L,3L,1L,3L,4L,9L,6L,2L,5L,2L,6L,6L,6L,5L,0L,5L,1L,3L,5L,9L,2L,3L,4L,6L,8L,8L,9L,9L,4L,9L,2L,9L,6L,9L,8L,9L,0L,2L,8L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195491Inst : IEnumerable<long>
{
public static readonly long[] Value=A195491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195491.Bytes);
public long this[int i]=>Value[i];

public static A195491Inst Instance=new A195491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195492
{
public static readonly long[] Value={ 1L,0L,6L,8L,4L,7L,3L,0L,1L,7L,1L,9L,8L,6L,1L,0L,0L,3L,5L,7L,5L,3L,9L,8L,2L,0L,2L,5L,9L,9L,5L,6L,9L,6L,7L,6L,0L,9L,5L,0L,5L,7L,8L,8L,0L,8L,5L,2L,8L,7L,9L,5L,2L,7L,3L,0L,6L,8L,4L,1L,0L,7L,5L,1L,9L,4L,3L,6L,2L,1L,9L,6L,3L,2L,3L,0L,8L,7L,8L,6L,8L,7L,7L,9L,0L,6L,8L,1L,0L,2L,4L,5L,0L,6L,6L,9L,5L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195492Inst : IEnumerable<long>
{
public static readonly long[] Value=A195492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195492.Bytes);
public long this[int i]=>Value[i];

public static A195492Inst Instance=new A195492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195493
{
public static readonly long[] Value={ 7L,5L,9L,3L,1L,0L,7L,7L,8L,3L,7L,3L,7L,3L,4L,9L,5L,6L,8L,1L,1L,8L,4L,2L,6L,9L,0L,4L,9L,7L,7L,6L,7L,3L,6L,8L,7L,0L,2L,8L,5L,5L,3L,5L,3L,7L,4L,8L,7L,0L,3L,2L,3L,0L,0L,0L,4L,2L,2L,3L,8L,7L,9L,7L,5L,8L,9L,9L,1L,7L,4L,6L,7L,7L,7L,2L,2L,6L,0L,4L,6L,7L,1L,3L,9L,8L,3L,0L,8L,0L,4L,2L,3L,1L,3L,3L,2L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195493Inst : IEnumerable<long>
{
public static readonly long[] Value=A195493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195493.Bytes);
public long this[int i]=>Value[i];

public static A195493Inst Instance=new A195493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195494
{
public static readonly long[] Value={ 6L,3L,1L,7L,0L,4L,6L,2L,0L,4L,1L,6L,6L,7L,9L,6L,8L,2L,9L,8L,0L,6L,1L,4L,4L,4L,6L,4L,1L,6L,4L,7L,6L,0L,8L,3L,3L,4L,2L,8L,5L,0L,2L,9L,6L,8L,3L,1L,0L,3L,5L,0L,6L,6L,4L,3L,3L,8L,3L,1L,3L,0L,2L,6L,2L,7L,8L,1L,5L,8L,1L,7L,4L,0L,4L,4L,1L,6L,7L,8L,8L,4L,7L,9L,7L,0L,1L,9L,2L,0L,0L,2L,5L,2L,0L,4L,3L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195494Inst : IEnumerable<long>
{
public static readonly long[] Value=A195494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195494.Bytes);
public long this[int i]=>Value[i];

public static A195494Inst Instance=new A195494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195495
{
public static readonly long[] Value={ 4L,0L,5L,1L,7L,7L,8L,2L,9L,7L,2L,0L,5L,7L,1L,7L,7L,7L,8L,8L,0L,3L,0L,7L,3L,9L,4L,9L,8L,0L,5L,1L,4L,5L,8L,4L,6L,8L,8L,3L,2L,3L,9L,3L,7L,4L,0L,8L,9L,2L,3L,7L,6L,9L,9L,0L,7L,8L,5L,6L,5L,8L,0L,7L,3L,8L,9L,5L,8L,9L,0L,4L,6L,6L,4L,6L,2L,1L,3L,2L,6L,2L,2L,8L,4L,4L,7L,6L,8L,9L,3L,7L,6L,0L,2L,9L,7L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195495Inst : IEnumerable<long>
{
public static readonly long[] Value=A195495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195495.Bytes);
public long this[int i]=>Value[i];

public static A195495Inst Instance=new A195495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195496
{
public static readonly long[] Value={ 1L,0L,1L,7L,1L,5L,3L,4L,4L,6L,7L,5L,4L,8L,0L,4L,4L,6L,6L,2L,5L,6L,7L,9L,8L,1L,8L,7L,8L,1L,6L,6L,0L,6L,3L,3L,6L,9L,7L,4L,3L,6L,7L,9L,8L,2L,5L,5L,3L,7L,4L,6L,3L,9L,5L,6L,4L,0L,3L,4L,9L,5L,5L,6L,1L,7L,5L,7L,7L,6L,1L,4L,7L,5L,2L,9L,8L,5L,3L,2L,8L,9L,2L,4L,2L,4L,6L,6L,6L,3L,7L,8L,4L,1L,8L,4L,8L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195496Inst : IEnumerable<long>
{
public static readonly long[] Value=A195496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195496.Bytes);
public long this[int i]=>Value[i];

public static A195496Inst Instance=new A195496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195497
{
public static readonly long[] Value={ 8L,6L,2L,9L,6L,8L,7L,9L,2L,1L,4L,1L,0L,3L,7L,4L,3L,4L,1L,3L,6L,0L,1L,0L,4L,3L,3L,0L,1L,6L,1L,7L,3L,1L,2L,5L,4L,9L,8L,3L,6L,2L,2L,2L,5L,5L,0L,0L,4L,9L,0L,7L,6L,8L,0L,7L,3L,5L,7L,1L,1L,5L,5L,4L,5L,8L,2L,8L,9L,7L,8L,6L,0L,7L,8L,9L,7L,7L,8L,0L,1L,6L,6L,5L,7L,3L,0L,5L,7L,8L,9L,6L,9L,2L,3L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195497Inst : IEnumerable<long>
{
public static readonly long[] Value=A195497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195497.Bytes);
public long this[int i]=>Value[i];

public static A195497Inst Instance=new A195497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195498
{
public static readonly long[] Value={ 5L,7L,5L,9L,1L,5L,2L,3L,6L,5L,1L,3L,4L,8L,2L,3L,7L,3L,6L,1L,8L,7L,8L,7L,3L,6L,9L,1L,8L,7L,4L,1L,9L,9L,1L,8L,7L,6L,7L,2L,7L,0L,2L,3L,9L,6L,1L,3L,6L,8L,7L,5L,2L,7L,5L,5L,1L,8L,3L,3L,7L,7L,6L,9L,9L,0L,3L,4L,1L,9L,4L,4L,8L,1L,4L,5L,3L,5L,3L,8L,0L,7L,2L,2L,4L,9L,3L,7L,8L,8L,2L,0L,7L,2L,7L,0L,5L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195498Inst : IEnumerable<long>
{
public static readonly long[] Value=A195498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195498.Bytes);
public long this[int i]=>Value[i];

public static A195498Inst Instance=new A195498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195499
{
public static readonly long[] Value={ 3L,8L,33L,120L,451L,1680L,6273L,23408L,87363L,326040L,1216801L,4541160L,16947843L,63250208L,236052993L,880961760L,3287794051L,12270214440L,45793063713L,170902040408L,637815097923L,2380358351280L,8883618307201L,33154114877520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195499Inst : IEnumerable<long>
{
public static readonly long[] Value=A195499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195499.Bytes);
public long this[int i]=>Value[i];

public static A195499Inst Instance=new A195499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195500
{
public static readonly long[] Value={ 3L,228L,308L,5289L,543900L,706180L,1244791L,51146940L,76205040L,114835995824L,106293119818725L,222582887719576L,3520995103197240L,17847666535865852L,18611596834765355L,106620725307595884L,269840171418387336L,357849299891217865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195500Inst : IEnumerable<long>
{
public static readonly long[] Value=A195500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195500.Bytes);
public long this[int i]=>Value[i];

public static A195500Inst Instance=new A195500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195501
{
public static readonly long[] Value={ 4L,325L,435L,7480L,769189L,998691L,1760400L,72332699L,107770201L,162402622743L,150321171634588L,314779738565193L,4979439027990791L,25240412071733925L,26320772661145332L,150784475760058387L,381611630092964177L,506075333191877232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195501Inst : IEnumerable<long>
{
public static readonly long[] Value=A195501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195501.Bytes);
public long this[int i]=>Value[i];

public static A195501Inst Instance=new A195501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195502
{
public static readonly long[] Value={ 5L,397L,533L,9161L,942061L,1223141L,2156041L,88589101L,131991001L,198901779305L,184105084021037L,385524870425705L,6098542411938841L,30913065236666477L,32236231327801693L,184672513372600885L,467376886819742065L,619813168864541257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195502Inst : IEnumerable<long>
{
public static readonly long[] Value=A195502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195502.Bytes);
public long this[int i]=>Value[i];

public static A195502Inst Instance=new A195502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195503
{
public static readonly long[] Value={ 4L,15L,56L,209L,780L,2911L,10864L,40545L,151316L,564719L,2107560L,7865521L,29354524L,109552575L,408855776L,1525870529L,5694626340L,21252634831L,79315912984L,296011017105L,1104728155436L,4122901604639L,15386878263120L,57424611447841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195503Inst : IEnumerable<long>
{
public static readonly long[] Value=A195503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195503.Bytes);
public long this[int i]=>Value[i];

public static A195503Inst Instance=new A195503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195504
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,6L,6L,6L,6L,60L,60L,720L,720L,10080L,10080L,10080L,10080L,181440L,181440L,3628800L,3628800L,79833600L,79833600L,79833600L,79833600L,2075673600L,2075673600L,58118860800L,58118860800L,1743565824000L,1743565824000L,1743565824000L,1743565824000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195504Inst : IEnumerable<long>
{
public static readonly long[] Value=A195504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195504.Bytes);
public long this[int i]=>Value[i];

public static A195504Inst Instance=new A195504Inst();

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