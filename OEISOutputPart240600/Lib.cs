using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019641
{
public static readonly long[] Value={ 2L,4L,3L,1L,0L,1L,8L,4L,4L,3L,6L,0L,1L,4L,6L,6L,4L,3L,4L,3L,9L,3L,7L,5L,9L,9L,3L,1L,9L,4L,1L,0L,8L,9L,7L,9L,3L,7L,9L,1L,4L,8L,3L,4L,8L,0L,5L,8L,3L,1L,2L,2L,6L,1L,8L,5L,6L,2L,7L,3L,6L,0L,3L,1L,6L,4L,5L,8L,5L,7L,6L,0L,5L,0L,0L,7L,8L,9L,2L,3L,7L,1L,9L,7L,7L,9L,5L,3L,1L,5L,4L,3L,8L,5L,5L,6L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019641Inst : IEnumerable<long>
{
public static readonly long[] Value=A019641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019641.Bytes);
public long this[int i]=>Value[i];

public static A019641Inst Instance=new A019641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019642
{
public static readonly long[] Value={ 2L,1L,7L,5L,1L,2L,1L,7L,6L,5L,3L,2L,7L,6L,2L,7L,8L,6L,2L,3L,5L,2L,3L,1L,1L,5L,1L,8L,0L,5L,2L,5L,5L,4L,0L,2L,6L,0L,2L,3L,9L,5L,8L,9L,0L,3L,6L,7L,9L,6L,3L,6L,0L,2L,7L,1L,3L,5L,0L,7L,9L,6L,0L,7L,2L,6L,2L,0L,8L,3L,1L,2L,0L,2L,7L,0L,2L,1L,9L,4L,9L,0L,7L,1L,7L,1L,1L,5L,9L,8L,0L,2L,3L,9L,7L,1L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019642Inst : IEnumerable<long>
{
public static readonly long[] Value=A019642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019642.Bytes);
public long this[int i]=>Value[i];

public static A019642Inst Instance=new A019642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019643
{
public static readonly long[] Value={ 1L,9L,6L,7L,9L,6L,7L,3L,1L,1L,4L,8L,6L,9L,0L,1L,3L,9L,9L,2L,7L,1L,1L,3L,8L,9L,9L,2L,5L,2L,3L,7L,3L,9L,3L,5L,6L,8L,7L,8L,8L,1L,9L,9L,6L,0L,4L,7L,2L,0L,5L,1L,6L,4L,3L,5L,9L,8L,4L,0L,5L,3L,5L,8L,9L,5L,1L,4L,0L,8L,5L,3L,7L,3L,8L,7L,3L,4L,1L,4L,4L,3L,9L,8L,2L,1L,5L,2L,5L,5L,3L,5L,5L,0L,2L,2L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019643Inst : IEnumerable<long>
{
public static readonly long[] Value=A019643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019643.Bytes);
public long this[int i]=>Value[i];

public static A019643Inst Instance=new A019643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019644
{
public static readonly long[] Value={ 1L,7L,9L,6L,8L,3L,9L,7L,1L,9L,1L,8L,3L,6L,9L,2L,5L,8L,1L,9L,4L,3L,2L,1L,3L,8L,6L,2L,7L,3L,9L,0L,6L,6L,3L,6L,9L,3L,2L,4L,1L,3L,9L,9L,6L,3L,9L,0L,9L,2L,6L,4L,5L,4L,4L,1L,5L,5L,0L,6L,5L,7L,6L,2L,5L,2L,0L,8L,5L,1L,2L,7L,3L,2L,6L,6L,7L,0L,3L,0L,5L,7L,5L,4L,8L,9L,2L,1L,8L,9L,6L,7L,1L,9L,7L,6L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019644Inst : IEnumerable<long>
{
public static readonly long[] Value=A019644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019644.Bytes);
public long this[int i]=>Value[i];

public static A019644Inst Instance=new A019644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019645
{
public static readonly long[] Value={ 2L,9L,2L,2L,2L,8L,2L,3L,6L,5L,3L,2L,2L,2L,7L,7L,8L,6L,4L,5L,4L,1L,6L,2L,3L,0L,7L,6L,1L,0L,7L,6L,8L,2L,3L,1L,5L,3L,9L,7L,9L,0L,7L,5L,5L,2L,6L,4L,6L,5L,6L,6L,8L,5L,9L,0L,1L,7L,7L,4L,0L,0L,1L,1L,4L,7L,1L,9L,5L,6L,1L,7L,2L,3L,6L,2L,9L,5L,6L,8L,8L,4L,4L,4L,3L,9L,5L,6L,5L,6L,7L,7L,6L,7L,0L,5L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019645Inst : IEnumerable<long>
{
public static readonly long[] Value=A019645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019645.Bytes);
public long this[int i]=>Value[i];

public static A019645Inst Instance=new A019645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019662
{
public static readonly long[] Value={ 1L,6L,2L,3L,4L,9L,0L,2L,0L,2L,9L,5L,6L,8L,2L,1L,0L,3L,5L,8L,5L,6L,4L,5L,7L,2L,6L,4L,5L,0L,4L,2L,6L,7L,9L,5L,2L,9L,9L,8L,8L,3L,7L,5L,2L,9L,2L,4L,8L,0L,9L,2L,6L,9L,9L,4L,5L,4L,3L,0L,0L,0L,0L,6L,3L,7L,3L,3L,0L,8L,9L,8L,4L,6L,4L,6L,0L,8L,7L,1L,5L,8L,0L,2L,4L,4L,2L,0L,3L,1L,5L,4L,2L,6L,1L,4L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019662Inst : IEnumerable<long>
{
public static readonly long[] Value=A019662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019662.Bytes);
public long this[int i]=>Value[i];

public static A019662Inst Instance=new A019662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019663
{
public static readonly long[] Value={ 1L,5L,3L,8L,0L,4L,3L,3L,5L,0L,1L,6L,9L,6L,1L,9L,9L,2L,8L,7L,0L,6L,1L,1L,7L,4L,0L,8L,4L,7L,7L,7L,2L,7L,5L,3L,4L,4L,1L,9L,9L,5L,1L,3L,4L,3L,4L,9L,8L,1L,9L,3L,0L,8L,3L,6L,9L,3L,5L,4L,7L,3L,7L,4L,4L,5L,8L,9L,2L,4L,3L,0L,1L,2L,4L,3L,6L,6L,1L,5L,1L,8L,1L,2L,8L,3L,9L,8L,1L,9L,3L,5L,6L,1L,6L,0L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019663Inst : IEnumerable<long>
{
public static readonly long[] Value=A019663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019663.Bytes);
public long this[int i]=>Value[i];

public static A019663Inst Instance=new A019663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019664
{
public static readonly long[] Value={ 1L,21L,301L,3669L,40957L,433125L,4418317L,43942773L,428973853L,4128937989L,39306876973L,370937567637L,3475860284989L,32382187083813L,300235508341069L,2772487245505461L,25515330868003165L,234141560259529797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019664Inst : IEnumerable<long>
{
public static readonly long[] Value=A019664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019664.Bytes);
public long this[int i]=>Value[i];

public static A019664Inst Instance=new A019664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019665
{
public static readonly long[] Value={ 1L,3L,9L,1L,5L,6L,3L,0L,3L,1L,1L,0L,5L,8L,4L,6L,6L,0L,2L,1L,6L,2L,6L,7L,7L,6L,5L,5L,2L,8L,9L,3L,7L,2L,5L,3L,1L,1L,4L,1L,8L,6L,0L,7L,3L,9L,3L,5L,5L,5L,0L,8L,0L,2L,8L,1L,0L,3L,6L,8L,5L,7L,1L,9L,7L,4L,8L,5L,5L,0L,5L,5L,8L,2L,6L,8L,0L,7L,4L,7L,0L,6L,8L,7L,8L,0L,7L,4L,5L,5L,6L,0L,7L,9L,5L,5L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019665Inst : IEnumerable<long>
{
public static readonly long[] Value=A019665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019665.Bytes);
public long this[int i]=>Value[i];

public static A019665Inst Instance=new A019665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019666
{
public static readonly long[] Value={ 1L,3L,2L,8L,3L,1L,0L,1L,6L,6L,0L,5L,5L,5L,8L,0L,8L,4L,7L,5L,1L,8L,9L,1L,9L,5L,8L,0L,0L,4L,8L,9L,4L,6L,5L,0L,6L,9L,9L,9L,0L,4L,8L,8L,8L,7L,5L,6L,6L,6L,2L,1L,2L,9L,9L,5L,5L,3L,5L,1L,8L,1L,8L,7L,0L,3L,2L,7L,0L,7L,3L,5L,1L,0L,7L,4L,0L,7L,1L,3L,1L,1L,1L,1L,0L,8L,8L,9L,3L,4L,8L,9L,8L,5L,0L,2L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019666Inst : IEnumerable<long>
{
public static readonly long[] Value=A019666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019666.Bytes);
public long this[int i]=>Value[i];

public static A019666Inst Instance=new A019666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019667
{
public static readonly long[] Value={ 1L,2L,7L,0L,5L,5L,7L,5L,5L,0L,1L,4L,0L,1L,2L,0L,8L,1L,0L,6L,7L,0L,2L,7L,0L,9L,0L,2L,6L,5L,5L,5L,1L,4L,0L,5L,0L,1L,7L,3L,0L,0L,3L,2L,8L,3L,7L,5L,9L,3L,7L,6L,8L,9L,5L,2L,2L,5L,1L,0L,4L,3L,5L,2L,8L,1L,3L,8L,9L,3L,9L,8L,7L,9L,8L,3L,8L,9L,4L,2L,9L,7L,5L,8L,4L,3L,2L,8L,9L,4L,2L,5L,0L,7L,4L,1L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019667Inst : IEnumerable<long>
{
public static readonly long[] Value=A019667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019667.Bytes);
public long this[int i]=>Value[i];

public static A019667Inst Instance=new A019667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019668
{
public static readonly long[] Value={ 1L,2L,1L,7L,6L,1L,7L,6L,5L,2L,2L,1L,7L,6L,1L,5L,7L,7L,6L,8L,9L,2L,3L,4L,2L,9L,4L,8L,3L,7L,8L,2L,0L,0L,9L,6L,4L,7L,4L,9L,1L,2L,8L,1L,4L,6L,9L,3L,6L,0L,6L,9L,5L,2L,4L,5L,9L,0L,7L,2L,5L,0L,0L,4L,7L,7L,9L,9L,8L,1L,7L,3L,8L,4L,8L,4L,5L,6L,5L,3L,6L,8L,5L,1L,8L,3L,1L,5L,2L,3L,6L,5L,6L,9L,6L,0L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019668Inst : IEnumerable<long>
{
public static readonly long[] Value=A019668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019668.Bytes);
public long this[int i]=>Value[i];

public static A019668Inst Instance=new A019668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019669
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,9L,6L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,2L,3L,1L,3L,2L,1L,6L,9L,1L,6L,3L,9L,7L,5L,1L,4L,4L,2L,0L,9L,8L,5L,8L,4L,6L,9L,9L,6L,8L,7L,5L,5L,2L,9L,1L,0L,4L,8L,7L,4L,7L,2L,2L,9L,6L,1L,5L,3L,9L,0L,8L,2L,0L,3L,1L,4L,3L,1L,0L,4L,4L,9L,9L,3L,1L,4L,0L,1L,7L,4L,1L,2L,6L,7L,1L,0L,5L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019669Inst : IEnumerable<long>
{
public static readonly long[] Value=A019669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019669.Bytes);
public long this[int i]=>Value[i];

public static A019669Inst Instance=new A019669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019670
{
public static readonly long[] Value={ 1L,0L,4L,7L,1L,9L,7L,5L,5L,1L,1L,9L,6L,5L,9L,7L,7L,4L,6L,1L,5L,4L,2L,1L,4L,4L,6L,1L,0L,9L,3L,1L,6L,7L,6L,2L,8L,0L,6L,5L,7L,2L,3L,1L,3L,3L,1L,2L,5L,0L,3L,5L,2L,7L,3L,6L,5L,8L,3L,1L,4L,8L,6L,4L,1L,0L,2L,6L,0L,5L,4L,6L,8L,7L,6L,2L,0L,6L,9L,6L,6L,6L,2L,0L,9L,3L,4L,4L,9L,4L,1L,7L,8L,0L,7L,0L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019670Inst : IEnumerable<long>
{
public static readonly long[] Value=A019670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019670.Bytes);
public long this[int i]=>Value[i];

public static A019670Inst Instance=new A019670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019671
{
public static readonly long[] Value={ 1L,22L,332L,4280L,50736L,571872L,6238912L,66567040L,699159296L,7259766272L,74744097792L,764616652800L,7783588704256L,78935331561472L,798149140201472L,8051859072450560L,81081536382959616L,815318946277097472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019671Inst : IEnumerable<long>
{
public static readonly long[] Value=A019671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019671.Bytes);
public long this[int i]=>Value[i];

public static A019671Inst Instance=new A019671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019672
{
public static readonly long[] Value={ 1L,23L,365L,4975L,62661L,753783L,8811805L,101107775L,1145674421L,12870591943L,143722946445L,1598128085775L,17716831119781L,195984586836503L,2164626279788285L,23881256748106975L,263256769887630741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019672Inst : IEnumerable<long>
{
public static readonly long[] Value=A019672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019672.Bytes);
public long this[int i]=>Value[i];

public static A019672Inst Instance=new A019672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019673
{
public static readonly long[] Value={ 5L,2L,3L,5L,9L,8L,7L,7L,5L,5L,9L,8L,2L,9L,8L,8L,7L,3L,0L,7L,7L,1L,0L,7L,2L,3L,0L,5L,4L,6L,5L,8L,3L,8L,1L,4L,0L,3L,2L,8L,6L,1L,5L,6L,6L,5L,6L,2L,5L,1L,7L,6L,3L,6L,8L,2L,9L,1L,5L,7L,4L,3L,2L,0L,5L,1L,3L,0L,2L,7L,3L,4L,3L,8L,1L,0L,3L,4L,8L,3L,3L,1L,0L,4L,6L,7L,2L,4L,7L,0L,8L,9L,0L,3L,5L,2L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019673Inst : IEnumerable<long>
{
public static readonly long[] Value=A019673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019673.Bytes);
public long this[int i]=>Value[i];

public static A019673Inst Instance=new A019673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019674
{
public static readonly long[] Value={ 4L,4L,8L,7L,9L,8L,9L,5L,0L,5L,1L,2L,8L,2L,7L,6L,0L,5L,4L,9L,4L,6L,6L,3L,3L,4L,0L,4L,6L,8L,5L,0L,0L,4L,1L,2L,0L,2L,8L,1L,6L,7L,0L,5L,7L,0L,5L,3L,5L,8L,6L,5L,4L,5L,8L,5L,3L,5L,6L,3L,5L,1L,3L,1L,8L,6L,8L,3L,0L,9L,1L,5L,1L,8L,3L,7L,4L,4L,1L,4L,2L,6L,6L,1L,1L,4L,7L,8L,3L,2L,1L,9L,1L,7L,3L,1L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019674Inst : IEnumerable<long>
{
public static readonly long[] Value=A019674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019674.Bytes);
public long this[int i]=>Value[i];

public static A019674Inst Instance=new A019674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019675
{
public static readonly long[] Value={ 3L,9L,2L,6L,9L,9L,0L,8L,1L,6L,9L,8L,7L,2L,4L,1L,5L,4L,8L,0L,7L,8L,3L,0L,4L,2L,2L,9L,0L,9L,9L,3L,7L,8L,6L,0L,5L,2L,4L,6L,4L,6L,1L,7L,4L,9L,2L,1L,8L,8L,8L,2L,2L,7L,6L,2L,1L,8L,6L,8L,0L,7L,4L,0L,3L,8L,4L,7L,7L,0L,5L,0L,7L,8L,5L,7L,7L,6L,1L,2L,4L,8L,2L,8L,5L,0L,4L,3L,5L,3L,1L,6L,7L,7L,6L,4L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019675Inst : IEnumerable<long>
{
public static readonly long[] Value=A019675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019675.Bytes);
public long this[int i]=>Value[i];

public static A019675Inst Instance=new A019675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019676
{
public static readonly long[] Value={ 3L,4L,9L,0L,6L,5L,8L,5L,0L,3L,9L,8L,8L,6L,5L,9L,1L,5L,3L,8L,4L,7L,3L,8L,1L,5L,3L,6L,9L,7L,7L,2L,2L,5L,4L,2L,6L,8L,8L,5L,7L,4L,3L,7L,7L,7L,0L,8L,3L,4L,5L,0L,9L,1L,2L,1L,9L,4L,3L,8L,2L,8L,8L,0L,3L,4L,2L,0L,1L,8L,2L,2L,9L,2L,0L,6L,8L,9L,8L,8L,8L,7L,3L,6L,4L,4L,8L,3L,1L,3L,9L,2L,6L,9L,0L,1L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019676Inst : IEnumerable<long>
{
public static readonly long[] Value=A019676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019676.Bytes);
public long this[int i]=>Value[i];

public static A019676Inst Instance=new A019676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019677
{
public static readonly BigInteger[] Value={ 1L,24L,400L,5760L,77056L,989184L,12390400L,152862720L,1867841536L,22682271744L,274333696000L,3309180026880L,39847582498816L,479270434504704L,5760041038643200L,69190860134154240L,830853267268304896L,9974742789667160064UL,BigInteger.Parse("119732942204305408000") };
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
public class A019677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019677Inst Instance=new A019677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019694
{
public static readonly long[] Value={ 1L,2L,5L,6L,6L,3L,7L,0L,6L,1L,4L,3L,5L,9L,1L,7L,2L,9L,5L,3L,8L,5L,0L,5L,7L,3L,5L,3L,3L,1L,1L,8L,0L,1L,1L,5L,3L,6L,7L,8L,8L,6L,7L,7L,5L,9L,7L,5L,0L,0L,4L,2L,3L,2L,8L,3L,8L,9L,9L,7L,7L,8L,3L,6L,9L,2L,3L,1L,2L,6L,5L,6L,2L,5L,1L,4L,4L,8L,3L,5L,9L,9L,4L,5L,1L,2L,1L,3L,9L,3L,0L,1L,3L,6L,8L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019694Inst : IEnumerable<long>
{
public static readonly long[] Value=A019694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019694.Bytes);
public long this[int i]=>Value[i];

public static A019694Inst Instance=new A019694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019695
{
public static readonly long[] Value={ 8L,9L,7L,5L,9L,7L,9L,0L,1L,0L,2L,5L,6L,5L,5L,2L,1L,0L,9L,8L,9L,3L,2L,6L,6L,8L,0L,9L,3L,7L,0L,0L,0L,8L,2L,4L,0L,5L,6L,3L,3L,4L,1L,1L,4L,1L,0L,7L,1L,7L,3L,0L,9L,1L,7L,0L,7L,1L,2L,7L,0L,2L,6L,3L,7L,3L,6L,6L,1L,8L,3L,0L,3L,6L,7L,4L,8L,8L,2L,8L,5L,3L,2L,2L,2L,9L,5L,6L,6L,4L,3L,8L,3L,4L,6L,2L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019695Inst : IEnumerable<long>
{
public static readonly long[] Value=A019695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019695.Bytes);
public long this[int i]=>Value[i];

public static A019695Inst Instance=new A019695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019696
{
public static readonly long[] Value={ 6L,9L,8L,1L,3L,1L,7L,0L,0L,7L,9L,7L,7L,3L,1L,8L,3L,0L,7L,6L,9L,4L,7L,6L,3L,0L,7L,3L,9L,5L,4L,4L,5L,0L,8L,5L,3L,7L,7L,1L,4L,8L,7L,5L,5L,4L,1L,6L,6L,9L,0L,1L,8L,2L,4L,3L,8L,8L,7L,6L,5L,7L,6L,0L,6L,8L,4L,0L,3L,6L,4L,5L,8L,4L,1L,3L,7L,9L,7L,7L,7L,4L,7L,2L,8L,9L,6L,6L,2L,7L,8L,5L,3L,8L,0L,3L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019696Inst : IEnumerable<long>
{
public static readonly long[] Value=A019696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019696.Bytes);
public long this[int i]=>Value[i];

public static A019696Inst Instance=new A019696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019697
{
public static readonly long[] Value={ 5L,7L,1L,1L,9L,8L,6L,6L,4L,2L,8L,9L,0L,5L,3L,3L,1L,6L,0L,8L,4L,1L,1L,6L,9L,7L,8L,7L,7L,8L,0L,9L,1L,4L,3L,3L,4L,9L,0L,3L,9L,4L,4L,3L,6L,2L,5L,0L,0L,1L,9L,2L,4L,0L,1L,7L,7L,2L,6L,2L,6L,5L,3L,1L,4L,6L,8L,7L,5L,7L,1L,0L,2L,3L,3L,8L,5L,6L,1L,8L,1L,5L,6L,8L,7L,3L,3L,6L,0L,4L,6L,0L,7L,6L,5L,7L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019697Inst : IEnumerable<long>
{
public static readonly long[] Value=A019697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019697.Bytes);
public long this[int i]=>Value[i];

public static A019697Inst Instance=new A019697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019698
{
public static readonly long[] Value={ 4L,8L,3L,3L,2L,1L,9L,4L,6L,7L,0L,6L,1L,2L,2L,0L,3L,6L,6L,8L,6L,5L,6L,0L,5L,2L,0L,5L,0L,4L,5L,3L,8L,9L,0L,5L,2L,6L,1L,1L,0L,2L,9L,8L,4L,5L,1L,9L,2L,4L,7L,0L,4L,9L,3L,8L,0L,7L,6L,0L,7L,0L,6L,5L,0L,8L,8L,9L,4L,8L,3L,1L,7L,3L,6L,3L,3L,9L,8L,4L,5L,9L,4L,2L,7L,7L,4L,5L,8L,8L,5L,1L,4L,1L,7L,1L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019698Inst : IEnumerable<long>
{
public static readonly long[] Value=A019698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019698.Bytes);
public long this[int i]=>Value[i];

public static A019698Inst Instance=new A019698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019699
{
public static readonly long[] Value={ 4L,1L,8L,8L,7L,9L,0L,2L,0L,4L,7L,8L,6L,3L,9L,0L,9L,8L,4L,6L,1L,6L,8L,5L,7L,8L,4L,4L,3L,7L,2L,6L,7L,0L,5L,1L,2L,2L,6L,2L,8L,9L,2L,5L,3L,2L,5L,0L,0L,1L,4L,1L,0L,9L,4L,6L,3L,3L,2L,5L,9L,4L,5L,6L,4L,1L,0L,4L,2L,1L,8L,7L,5L,0L,4L,8L,2L,7L,8L,6L,6L,4L,8L,3L,7L,3L,7L,9L,7L,6L,7L,1L,2L,2L,8L,2L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019699Inst : IEnumerable<long>
{
public static readonly long[] Value=A019699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019699.Bytes);
public long this[int i]=>Value[i];

public static A019699Inst Instance=new A019699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019700
{
public static readonly long[] Value={ 3L,6L,9L,5L,9L,9L,1L,3L,5L,7L,1L,6L,4L,4L,6L,2L,6L,3L,3L,4L,8L,5L,4L,6L,2L,8L,0L,3L,8L,5L,8L,2L,3L,8L,6L,8L,7L,2L,9L,0L,7L,8L,7L,5L,2L,8L,6L,7L,6L,5L,9L,5L,0L,8L,3L,4L,9L,9L,9L,3L,4L,8L,1L,4L,4L,7L,9L,7L,8L,4L,0L,0L,7L,3L,9L,5L,5L,3L,9L,9L,9L,8L,3L,8L,5L,9L,2L,3L,3L,2L,3L,9L,3L,1L,9L,0L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019700Inst : IEnumerable<long>
{
public static readonly long[] Value=A019700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019700.Bytes);
public long this[int i]=>Value[i];

public static A019700Inst Instance=new A019700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019701
{
public static readonly long[] Value={ 3L,3L,0L,6L,9L,3L,9L,6L,3L,5L,3L,5L,7L,6L,7L,7L,0L,9L,3L,1L,1L,8L,5L,7L,1L,9L,8L,2L,3L,9L,9L,4L,7L,6L,7L,2L,0L,2L,0L,7L,5L,4L,6L,7L,3L,6L,1L,8L,4L,3L,2L,1L,9L,1L,6L,8L,1L,5L,7L,3L,1L,1L,4L,9L,7L,9L,7L,7L,0L,1L,4L,8L,0L,3L,0L,1L,2L,7L,2L,6L,3L,0L,1L,3L,4L,7L,7L,3L,5L,0L,0L,3L,6L,0L,1L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019701Inst : IEnumerable<long>
{
public static readonly long[] Value=A019701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019701.Bytes);
public long this[int i]=>Value[i];

public static A019701Inst Instance=new A019701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019702
{
public static readonly long[] Value={ 2L,9L,9L,1L,9L,9L,3L,0L,0L,3L,4L,1L,8L,8L,5L,0L,7L,0L,3L,2L,9L,7L,7L,5L,5L,6L,0L,3L,1L,2L,3L,3L,3L,6L,0L,8L,0L,1L,8L,7L,7L,8L,0L,3L,8L,0L,3L,5L,7L,2L,4L,3L,6L,3L,9L,0L,2L,3L,7L,5L,6L,7L,5L,4L,5L,7L,8L,8L,7L,2L,7L,6L,7L,8L,9L,1L,6L,2L,7L,6L,1L,7L,7L,4L,0L,9L,8L,5L,5L,4L,7L,9L,4L,4L,8L,7L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019702Inst : IEnumerable<long>
{
public static readonly long[] Value=A019702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019702.Bytes);
public long this[int i]=>Value[i];

public static A019702Inst Instance=new A019702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019703
{
public static readonly long[] Value={ 2L,7L,3L,1L,8L,1L,9L,6L,9L,8L,7L,7L,3L,7L,3L,3L,2L,5L,0L,8L,3L,7L,0L,8L,1L,2L,0L,2L,8L,5L,1L,7L,4L,1L,6L,3L,8L,4L,3L,2L,3L,2L,1L,2L,1L,6L,8L,4L,7L,9L,1L,8L,1L,0L,5L,1L,9L,5L,6L,0L,3L,9L,9L,3L,3L,1L,1L,1L,4L,4L,7L,0L,1L,1L,1L,8L,4L,4L,2L,6L,0L,7L,5L,0L,2L,6L,3L,8L,9L,7L,8L,5L,5L,8L,3L,6L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019703Inst : IEnumerable<long>
{
public static readonly long[] Value=A019703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019703.Bytes);
public long this[int i]=>Value[i];

public static A019703Inst Instance=new A019703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019704
{
public static readonly long[] Value={ 8L,8L,6L,2L,2L,6L,9L,2L,5L,4L,5L,2L,7L,5L,8L,0L,1L,3L,6L,4L,9L,0L,8L,3L,7L,4L,1L,6L,7L,0L,5L,7L,2L,5L,9L,1L,3L,9L,8L,7L,7L,4L,7L,2L,8L,0L,6L,1L,1L,9L,3L,5L,6L,4L,1L,0L,6L,9L,0L,3L,8L,9L,4L,9L,2L,6L,4L,5L,5L,6L,4L,2L,2L,9L,5L,5L,1L,6L,0L,9L,0L,6L,8L,7L,4L,7L,5L,3L,2L,8L,3L,6L,9L,2L,7L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019704Inst : IEnumerable<long>
{
public static readonly long[] Value=A019704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019704.Bytes);
public long this[int i]=>Value[i];

public static A019704Inst Instance=new A019704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019705
{
public static readonly long[] Value={ 5L,9L,0L,8L,1L,7L,9L,5L,0L,3L,0L,1L,8L,3L,8L,6L,7L,5L,7L,6L,6L,0L,5L,5L,8L,2L,7L,7L,8L,0L,3L,8L,1L,7L,2L,7L,5L,9L,9L,1L,8L,3L,1L,5L,2L,0L,4L,0L,7L,9L,5L,7L,0L,9L,4L,0L,4L,6L,0L,2L,5L,9L,6L,6L,1L,7L,6L,3L,7L,0L,9L,4L,8L,6L,3L,6L,7L,7L,3L,9L,3L,7L,9L,1L,6L,5L,0L,2L,1L,8L,9L,1L,2L,8L,4L,8L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019705Inst : IEnumerable<long>
{
public static readonly long[] Value=A019705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019705.Bytes);
public long this[int i]=>Value[i];

public static A019705Inst Instance=new A019705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019706
{
public static readonly long[] Value={ 4L,4L,3L,1L,1L,3L,4L,6L,2L,7L,2L,6L,3L,7L,9L,0L,0L,6L,8L,2L,4L,5L,4L,1L,8L,7L,0L,8L,3L,5L,2L,8L,6L,2L,9L,5L,6L,9L,9L,3L,8L,7L,3L,6L,4L,0L,3L,0L,5L,9L,6L,7L,8L,2L,0L,5L,3L,4L,5L,1L,9L,4L,7L,4L,6L,3L,2L,2L,7L,8L,2L,1L,1L,4L,7L,7L,5L,8L,0L,4L,5L,3L,4L,3L,7L,3L,7L,6L,6L,4L,1L,8L,4L,6L,3L,6L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019706Inst : IEnumerable<long>
{
public static readonly long[] Value=A019706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019706.Bytes);
public long this[int i]=>Value[i];

public static A019706Inst Instance=new A019706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019707
{
public static readonly long[] Value={ 3L,5L,4L,4L,9L,0L,7L,7L,0L,1L,8L,1L,1L,0L,3L,2L,0L,5L,4L,5L,9L,6L,3L,3L,4L,9L,6L,6L,6L,8L,2L,2L,9L,0L,3L,6L,5L,5L,9L,5L,0L,9L,8L,9L,1L,2L,2L,4L,4L,7L,7L,4L,2L,5L,6L,4L,2L,7L,6L,1L,5L,5L,7L,9L,7L,0L,5L,8L,2L,2L,5L,6L,9L,1L,8L,2L,0L,6L,4L,3L,6L,2L,7L,4L,9L,9L,0L,1L,3L,1L,3L,4L,7L,7L,0L,8L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019707Inst : IEnumerable<long>
{
public static readonly long[] Value=A019707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019707.Bytes);
public long this[int i]=>Value[i];

public static A019707Inst Instance=new A019707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019708
{
public static readonly long[] Value={ 2L,9L,5L,4L,0L,8L,9L,7L,5L,1L,5L,0L,9L,1L,9L,3L,3L,7L,8L,8L,3L,0L,2L,7L,9L,1L,3L,8L,9L,0L,1L,9L,0L,8L,6L,3L,7L,9L,9L,5L,9L,1L,5L,7L,6L,0L,2L,0L,3L,9L,7L,8L,5L,4L,7L,0L,2L,3L,0L,1L,2L,9L,8L,3L,0L,8L,8L,1L,8L,5L,4L,7L,4L,3L,1L,8L,3L,8L,6L,9L,6L,8L,9L,5L,8L,2L,5L,1L,0L,9L,4L,5L,6L,4L,2L,4L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019708Inst : IEnumerable<long>
{
public static readonly long[] Value=A019708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019708.Bytes);
public long this[int i]=>Value[i];

public static A019708Inst Instance=new A019708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019709
{
public static readonly long[] Value={ 2L,5L,3L,2L,0L,7L,6L,9L,2L,9L,8L,6L,5L,0L,2L,2L,8L,9L,6L,1L,4L,0L,2L,3L,9L,2L,6L,1L,9L,1L,5L,9L,2L,1L,6L,8L,9L,7L,1L,0L,7L,8L,4L,9L,3L,7L,3L,1L,7L,6L,9L,5L,8L,9L,7L,4L,4L,8L,2L,9L,6L,8L,4L,2L,6L,4L,7L,0L,1L,6L,1L,2L,0L,8L,4L,4L,3L,3L,1L,6L,8L,7L,6L,7L,8L,5L,0L,0L,9L,3L,8L,1L,9L,7L,9L,2L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019709Inst : IEnumerable<long>
{
public static readonly long[] Value=A019709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019709.Bytes);
public long this[int i]=>Value[i];

public static A019709Inst Instance=new A019709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019726
{
public static readonly long[] Value={ 7L,3L,8L,5L,2L,2L,4L,3L,7L,8L,7L,7L,2L,9L,8L,3L,4L,4L,7L,0L,7L,5L,6L,9L,7L,8L,4L,7L,2L,5L,4L,7L,7L,1L,5L,9L,4L,9L,8L,9L,7L,8L,9L,4L,0L,0L,5L,0L,9L,9L,4L,6L,3L,6L,7L,5L,5L,7L,5L,3L,2L,4L,5L,7L,7L,2L,0L,4L,6L,3L,6L,8L,5L,7L,9L,5L,9L,6L,7L,4L,2L,2L,3L,9L,5L,6L,2L,7L,7L,3L,6L,4L,1L,0L,6L,0L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019726Inst : IEnumerable<long>
{
public static readonly long[] Value=A019726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019726.Bytes);
public long this[int i]=>Value[i];

public static A019726Inst Instance=new A019726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019727
{
public static readonly long[] Value={ 2L,5L,0L,6L,6L,2L,8L,2L,7L,4L,6L,3L,1L,0L,0L,0L,5L,0L,2L,4L,1L,5L,7L,6L,5L,2L,8L,4L,8L,1L,1L,0L,4L,5L,2L,5L,3L,0L,0L,6L,9L,8L,6L,7L,4L,0L,6L,0L,9L,9L,3L,8L,3L,1L,6L,6L,2L,9L,9L,2L,3L,5L,7L,6L,3L,4L,2L,2L,9L,3L,6L,5L,4L,6L,0L,7L,8L,4L,1L,9L,7L,4L,9L,4L,6L,5L,9L,5L,8L,3L,8L,3L,7L,8L,0L,5L,7L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019727Inst : IEnumerable<long>
{
public static readonly long[] Value=A019727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019727.Bytes);
public long this[int i]=>Value[i];

public static A019727Inst Instance=new A019727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019728
{
public static readonly long[] Value={ 8L,3L,5L,5L,4L,2L,7L,5L,8L,2L,1L,0L,3L,3L,3L,5L,0L,0L,8L,0L,5L,2L,5L,5L,0L,9L,4L,9L,3L,7L,0L,1L,5L,0L,8L,4L,3L,3L,5L,6L,6L,2L,2L,4L,6L,8L,6L,9L,9L,7L,9L,4L,3L,8L,8L,7L,6L,6L,4L,1L,1L,9L,2L,1L,1L,4L,0L,9L,7L,8L,8L,4L,8L,6L,9L,2L,8L,0L,6L,5L,8L,3L,1L,5L,5L,3L,1L,9L,4L,6L,1L,2L,6L,0L,1L,9L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019728Inst : IEnumerable<long>
{
public static readonly long[] Value=A019728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019728.Bytes);
public long this[int i]=>Value[i];

public static A019728Inst Instance=new A019728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019729
{
public static readonly long[] Value={ 5L,0L,1L,3L,2L,5L,6L,5L,4L,9L,2L,6L,2L,0L,0L,1L,0L,0L,4L,8L,3L,1L,5L,3L,0L,5L,6L,9L,6L,2L,2L,0L,9L,0L,5L,0L,6L,0L,1L,3L,9L,7L,3L,4L,8L,1L,2L,1L,9L,8L,7L,6L,6L,3L,3L,2L,5L,9L,8L,4L,7L,1L,5L,2L,6L,8L,4L,5L,8L,7L,3L,0L,9L,2L,1L,5L,6L,8L,3L,9L,4L,9L,8L,9L,3L,1L,9L,1L,6L,7L,6L,7L,5L,6L,1L,1L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019729Inst : IEnumerable<long>
{
public static readonly long[] Value=A019729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019729.Bytes);
public long this[int i]=>Value[i];

public static A019729Inst Instance=new A019729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019730
{
public static readonly long[] Value={ 3L,5L,8L,0L,8L,9L,7L,5L,3L,5L,1L,8L,7L,1L,4L,3L,5L,7L,4L,8L,7L,9L,6L,6L,4L,6L,9L,2L,5L,8L,7L,2L,0L,7L,5L,0L,4L,2L,9L,5L,6L,9L,5L,3L,4L,3L,7L,2L,8L,4L,8L,3L,3L,0L,9L,4L,7L,1L,3L,1L,9L,3L,9L,4L,7L,7L,4L,7L,0L,5L,2L,2L,0L,8L,6L,8L,3L,4L,5L,6L,7L,8L,4L,9L,5L,1L,3L,6L,9L,1L,1L,9L,6L,8L,6L,5L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019730Inst : IEnumerable<long>
{
public static readonly long[] Value=A019730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019730.Bytes);
public long this[int i]=>Value[i];

public static A019730Inst Instance=new A019730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019731
{
public static readonly long[] Value={ 2L,7L,8L,5L,1L,4L,2L,5L,2L,7L,3L,6L,7L,7L,7L,8L,3L,3L,6L,0L,1L,7L,5L,1L,6L,9L,8L,3L,1L,2L,3L,3L,8L,3L,6L,1L,4L,4L,5L,2L,2L,0L,7L,4L,8L,9L,5L,6L,6L,5L,9L,8L,1L,2L,9L,5L,8L,8L,8L,0L,3L,9L,7L,3L,7L,1L,3L,6L,5L,9L,6L,1L,6L,2L,3L,0L,9L,3L,5L,5L,2L,7L,7L,1L,8L,4L,3L,9L,8L,2L,0L,4L,2L,0L,0L,6L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019731Inst : IEnumerable<long>
{
public static readonly long[] Value=A019731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019731.Bytes);
public long this[int i]=>Value[i];

public static A019731Inst Instance=new A019731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019732
{
public static readonly long[] Value={ 2L,2L,7L,8L,7L,5L,2L,9L,7L,6L,9L,3L,7L,2L,7L,3L,1L,8L,4L,0L,1L,4L,3L,3L,2L,0L,7L,7L,1L,0L,0L,9L,5L,0L,2L,3L,0L,0L,0L,6L,3L,5L,1L,5L,8L,2L,3L,7L,2L,6L,7L,1L,1L,9L,6L,9L,3L,6L,2L,9L,4L,1L,6L,0L,3L,1L,1L,1L,7L,6L,0L,4L,9L,6L,4L,3L,4L,9L,2L,7L,0L,4L,4L,9L,6L,9L,0L,5L,3L,0L,7L,6L,1L,6L,4L,1L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019732Inst : IEnumerable<long>
{
public static readonly long[] Value=A019732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019732.Bytes);
public long this[int i]=>Value[i];

public static A019732Inst Instance=new A019732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019733
{
public static readonly long[] Value={ 1L,9L,2L,8L,1L,7L,5L,5L,9L,5L,8L,7L,0L,0L,0L,0L,3L,8L,6L,4L,7L,3L,6L,6L,5L,6L,0L,3L,7L,0L,0L,8L,0L,4L,0L,4L,0L,7L,7L,4L,6L,0L,5L,1L,8L,5L,0L,8L,4L,5L,6L,7L,9L,3L,5L,8L,6L,9L,1L,7L,1L,9L,8L,1L,8L,0L,1L,7L,6L,4L,3L,4L,9L,6L,9L,8L,3L,3L,9L,9L,8L,0L,7L,2L,8L,1L,5L,0L,6L,4L,4L,9L,0L,6L,1L,9L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019733Inst : IEnumerable<long>
{
public static readonly long[] Value=A019733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019733.Bytes);
public long this[int i]=>Value[i];

public static A019733Inst Instance=new A019733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019734
{
public static readonly long[] Value={ 1L,6L,7L,1L,0L,8L,5L,5L,1L,6L,4L,2L,0L,6L,6L,7L,0L,0L,1L,6L,1L,0L,5L,1L,0L,1L,8L,9L,8L,7L,4L,0L,3L,0L,1L,6L,8L,6L,7L,1L,3L,2L,4L,4L,9L,3L,7L,3L,9L,9L,5L,8L,8L,7L,7L,7L,5L,3L,2L,8L,2L,3L,8L,4L,2L,2L,8L,1L,9L,5L,7L,6L,9L,7L,3L,8L,5L,6L,1L,3L,1L,6L,6L,3L,1L,0L,6L,3L,8L,9L,2L,2L,5L,2L,0L,3L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019734Inst : IEnumerable<long>
{
public static readonly long[] Value=A019734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019734.Bytes);
public long this[int i]=>Value[i];

public static A019734Inst Instance=new A019734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019735
{
public static readonly long[] Value={ 1L,4L,7L,4L,4L,8L,7L,2L,2L,0L,3L,7L,1L,1L,7L,6L,7L,6L,6L,1L,2L,6L,9L,2L,0L,7L,5L,5L,7L,7L,1L,2L,0L,3L,0L,9L,0L,0L,0L,4L,1L,0L,9L,8L,4L,7L,4L,1L,7L,6L,1L,0L,7L,7L,4L,4L,8L,8L,1L,9L,0L,3L,3L,9L,0L,2L,4L,8L,7L,8L,6L,2L,0L,3L,5L,7L,5L,5L,4L,1L,0L,2L,9L,0L,9L,7L,6L,2L,2L,5L,7L,8L,6L,9L,4L,4L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019735Inst : IEnumerable<long>
{
public static readonly long[] Value=A019735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019735.Bytes);
public long this[int i]=>Value[i];

public static A019735Inst Instance=new A019735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019736
{
public static readonly long[] Value={ 1L,3L,1L,9L,2L,7L,8L,0L,3L,9L,2L,7L,9L,4L,7L,3L,9L,4L,8L,6L,3L,9L,8L,7L,6L,4L,6L,5L,6L,9L,0L,0L,2L,3L,8L,1L,7L,3L,7L,2L,0L,9L,8L,2L,8L,4L,5L,3L,1L,5L,4L,6L,4L,8L,2L,4L,3L,6L,8L,0L,1L,8L,8L,2L,2L,8L,5L,4L,1L,7L,7L,1L,2L,9L,5L,1L,4L,9L,5L,7L,7L,6L,2L,8L,7L,6L,8L,2L,0L,2L,0L,1L,9L,8L,9L,7L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019736Inst : IEnumerable<long>
{
public static readonly long[] Value=A019736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019736.Bytes);
public long this[int i]=>Value[i];

public static A019736Inst Instance=new A019736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019737
{
public static readonly long[] Value={ 1L,1L,9L,3L,6L,3L,2L,5L,1L,1L,7L,2L,9L,0L,4L,7L,8L,5L,8L,2L,9L,3L,2L,2L,1L,5L,6L,4L,1L,9L,5L,7L,3L,5L,8L,3L,4L,7L,6L,5L,2L,3L,1L,7L,8L,1L,2L,4L,2L,8L,2L,7L,7L,6L,9L,8L,2L,3L,7L,7L,3L,1L,3L,1L,5L,9L,1L,5L,6L,8L,4L,0L,6L,9L,5L,6L,1L,1L,5L,2L,2L,6L,1L,6L,5L,0L,4L,5L,6L,3L,7L,3L,2L,2L,8L,8L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019737Inst : IEnumerable<long>
{
public static readonly long[] Value=A019737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019737.Bytes);
public long this[int i]=>Value[i];

public static A019737Inst Instance=new A019737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019738
{
public static readonly long[] Value={ 1L,0L,8L,9L,8L,3L,8L,3L,8L,0L,2L,7L,4L,3L,4L,8L,0L,4L,4L,5L,2L,8L,5L,9L,3L,6L,0L,2L,0L,9L,1L,7L,5L,8L,8L,0L,5L,6L,5L,5L,2L,1L,1L,6L,2L,6L,3L,5L,2L,1L,4L,7L,0L,9L,4L,1L,8L,6L,9L,2L,3L,2L,9L,4L,0L,6L,1L,8L,6L,6L,8L,0L,6L,3L,5L,1L,2L,3L,5L,6L,4L,1L,2L,8L,1L,1L,2L,8L,6L,2L,5L,3L,8L,1L,7L,6L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019738Inst : IEnumerable<long>
{
public static readonly long[] Value=A019738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019738.Bytes);
public long this[int i]=>Value[i];

public static A019738Inst Instance=new A019738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019739
{
public static readonly long[] Value={ 1L,3L,5L,9L,1L,4L,0L,9L,1L,4L,2L,2L,9L,5L,2L,2L,6L,1L,7L,6L,8L,0L,1L,4L,3L,7L,3L,5L,6L,7L,6L,3L,3L,1L,2L,4L,8L,8L,7L,8L,6L,2L,3L,5L,4L,6L,8L,4L,9L,9L,7L,9L,7L,8L,7L,4L,8L,3L,4L,8L,3L,8L,1L,3L,8L,6L,2L,0L,3L,8L,3L,1L,5L,1L,7L,6L,7L,7L,3L,7L,9L,7L,2L,8L,5L,6L,9L,1L,0L,8L,9L,2L,6L,2L,5L,8L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019739Inst : IEnumerable<long>
{
public static readonly long[] Value=A019739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019739.Bytes);
public long this[int i]=>Value[i];

public static A019739Inst Instance=new A019739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019740
{
public static readonly long[] Value={ 9L,0L,6L,0L,9L,3L,9L,4L,2L,8L,1L,9L,6L,8L,1L,7L,4L,5L,1L,2L,0L,0L,9L,5L,8L,2L,3L,7L,8L,4L,2L,2L,0L,8L,3L,2L,5L,8L,5L,7L,4L,9L,0L,3L,1L,2L,3L,3L,3L,1L,9L,8L,5L,8L,3L,2L,2L,3L,2L,2L,5L,4L,2L,5L,7L,4L,6L,9L,2L,2L,1L,0L,1L,1L,7L,8L,4L,9L,1L,9L,8L,1L,9L,0L,4L,6L,0L,7L,2L,6L,1L,7L,5L,0L,5L,5L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019740Inst : IEnumerable<long>
{
public static readonly long[] Value=A019740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019740.Bytes);
public long this[int i]=>Value[i];

public static A019740Inst Instance=new A019740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019741
{
public static readonly long[] Value={ 6L,7L,9L,5L,7L,0L,4L,5L,7L,1L,1L,4L,7L,6L,1L,3L,0L,8L,8L,4L,0L,0L,7L,1L,8L,6L,7L,8L,3L,8L,1L,6L,5L,6L,2L,4L,4L,3L,9L,3L,1L,1L,7L,7L,3L,4L,2L,4L,9L,8L,9L,8L,9L,3L,7L,4L,1L,7L,4L,1L,9L,0L,6L,9L,3L,1L,0L,1L,9L,1L,5L,7L,5L,8L,8L,3L,8L,6L,8L,9L,8L,6L,4L,2L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019741Inst : IEnumerable<long>
{
public static readonly long[] Value=A019741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019741.Bytes);
public long this[int i]=>Value[i];

public static A019741Inst Instance=new A019741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019758
{
public static readonly long[] Value={ 1L,2L,9L,4L,4L,1L,9L,9L,1L,8L,3L,1L,3L,8L,3L,1L,0L,6L,4L,4L,5L,7L,2L,7L,9L,7L,4L,8L,2L,6L,3L,1L,7L,2L,6L,1L,7L,9L,7L,9L,6L,4L,1L,4L,7L,3L,1L,9L,0L,4L,5L,6L,9L,4L,0L,4L,6L,0L,4L,6L,0L,7L,7L,5L,1L,0L,6L,7L,0L,3L,1L,5L,7L,3L,1L,1L,2L,1L,3L,1L,4L,0L,2L,7L,2L,0L,8L,6L,7L,5L,1L,6L,7L,8L,6L,5L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019758Inst : IEnumerable<long>
{
public static readonly long[] Value=A019758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019758.Bytes);
public long this[int i]=>Value[i];

public static A019758Inst Instance=new A019758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019759
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,8L,2L,6L,4L,9L,2L,9L,9L,5L,6L,6L,0L,1L,6L,0L,7L,2L,8L,5L,7L,9L,4L,1L,5L,2L,3L,9L,3L,7L,4L,9L,8L,9L,8L,0L,5L,6L,6L,8L,6L,0L,7L,7L,2L,7L,0L,8L,8L,9L,7L,7L,1L,2L,2L,5L,8L,0L,1L,2L,6L,0L,1L,8L,5L,3L,0L,1L,3L,7L,9L,7L,0L,6L,7L,0L,8L,8L,4L,4L,1L,5L,3L,7L,3L,5L,3L,8L,7L,5L,0L,7L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019759Inst : IEnumerable<long>
{
public static readonly long[] Value=A019759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019759.Bytes);
public long this[int i]=>Value[i];

public static A019759Inst Instance=new A019759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019760
{
public static readonly long[] Value={ 1L,1L,8L,1L,8L,6L,1L,6L,6L,4L,5L,4L,7L,4L,1L,0L,9L,7L,1L,8L,9L,5L,7L,7L,7L,1L,6L,1L,4L,5L,7L,6L,7L,9L,3L,4L,6L,8L,5L,0L,9L,7L,6L,9L,9L,7L,2L,6L,0L,8L,5L,1L,9L,8L,9L,1L,1L,6L,0L,7L,2L,8L,8L,1L,6L,1L,9L,1L,6L,3L,7L,5L,2L,3L,2L,7L,6L,2L,9L,3L,8L,8L,9L,4L,4L,0L,7L,9L,2L,0L,8L,0L,5L,4L,4L,2L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019760Inst : IEnumerable<long>
{
public static readonly long[] Value=A019760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019760.Bytes);
public long this[int i]=>Value[i];

public static A019760Inst Instance=new A019760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019761
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,1L,7L,4L,2L,8L,5L,2L,4L,6L,0L,2L,1L,8L,1L,4L,0L,0L,1L,1L,9L,7L,7L,9L,7L,3L,0L,2L,7L,6L,0L,4L,0L,7L,3L,2L,1L,8L,6L,2L,8L,9L,0L,4L,1L,6L,4L,9L,8L,2L,2L,9L,0L,2L,9L,0L,3L,1L,7L,8L,2L,1L,8L,3L,6L,5L,2L,6L,2L,6L,4L,7L,3L,1L,1L,4L,9L,7L,7L,3L,8L,0L,7L,5L,9L,0L,7L,7L,1L,8L,8L,1L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019761Inst : IEnumerable<long>
{
public static readonly long[] Value=A019761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019761.Bytes);
public long this[int i]=>Value[i];

public static A019761Inst Instance=new A019761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019762
{
public static readonly long[] Value={ 5L,4L,3L,6L,5L,6L,3L,6L,5L,6L,9L,1L,8L,0L,9L,0L,4L,7L,0L,7L,2L,0L,5L,7L,4L,9L,4L,2L,7L,0L,5L,3L,2L,4L,9L,9L,5L,5L,1L,4L,4L,9L,4L,1L,8L,7L,3L,9L,9L,9L,1L,9L,1L,4L,9L,9L,3L,3L,9L,3L,5L,2L,5L,5L,4L,4L,8L,1L,5L,3L,2L,6L,0L,7L,0L,7L,0L,9L,5L,1L,8L,9L,1L,4L,2L,7L,6L,4L,3L,5L,7L,0L,5L,0L,3L,3L,2L,8L,5L,4L,8L,5L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019762Inst : IEnumerable<long>
{
public static readonly long[] Value=A019762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019762.Bytes);
public long this[int i]=>Value[i];

public static A019762Inst Instance=new A019762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019763
{
public static readonly long[] Value={ 1L,8L,1L,2L,1L,8L,7L,8L,8L,5L,6L,3L,9L,3L,6L,3L,4L,9L,0L,2L,4L,0L,1L,9L,1L,6L,4L,7L,5L,6L,8L,4L,4L,1L,6L,6L,5L,1L,7L,1L,4L,9L,8L,0L,6L,2L,4L,6L,6L,6L,3L,9L,7L,1L,6L,6L,4L,4L,6L,4L,5L,0L,8L,5L,1L,4L,9L,3L,8L,4L,4L,2L,0L,2L,3L,5L,6L,9L,8L,3L,9L,6L,3L,8L,0L,9L,2L,1L,4L,5L,2L,3L,5L,0L,1L,1L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019763Inst : IEnumerable<long>
{
public static readonly long[] Value=A019763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019763.Bytes);
public long this[int i]=>Value[i];

public static A019763Inst Instance=new A019763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019764
{
public static readonly long[] Value={ 1L,0L,8L,7L,3L,1L,2L,7L,3L,1L,3L,8L,3L,6L,1L,8L,0L,9L,4L,1L,4L,4L,1L,1L,4L,9L,8L,8L,5L,4L,1L,0L,6L,4L,9L,9L,9L,1L,0L,2L,8L,9L,8L,8L,3L,7L,4L,7L,9L,9L,8L,3L,8L,2L,9L,9L,8L,6L,7L,8L,7L,0L,5L,1L,0L,8L,9L,6L,3L,0L,6L,5L,2L,1L,4L,1L,4L,1L,9L,0L,3L,7L,8L,2L,8L,5L,5L,2L,8L,7L,1L,4L,1L,0L,0L,6L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019764Inst : IEnumerable<long>
{
public static readonly long[] Value=A019764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019764.Bytes);
public long this[int i]=>Value[i];

public static A019764Inst Instance=new A019764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019765
{
public static readonly long[] Value={ 7L,7L,6L,6L,5L,1L,9L,5L,0L,9L,8L,8L,2L,9L,8L,6L,3L,8L,6L,7L,4L,3L,6L,7L,8L,4L,8L,9L,5L,7L,9L,0L,3L,5L,7L,0L,7L,8L,7L,7L,8L,4L,8L,8L,3L,9L,1L,4L,2L,7L,4L,1L,6L,4L,2L,7L,6L,2L,7L,6L,4L,6L,5L,0L,6L,4L,0L,2L,1L,8L,9L,4L,3L,8L,6L,7L,2L,7L,8L,8L,4L,1L,6L,3L,2L,5L,2L,0L,5L,1L,0L,0L,7L,1L,9L,0L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019765Inst : IEnumerable<long>
{
public static readonly long[] Value=A019765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019765.Bytes);
public long this[int i]=>Value[i];

public static A019765Inst Instance=new A019765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019766
{
public static readonly long[] Value={ 6L,0L,4L,0L,6L,2L,6L,2L,8L,5L,4L,6L,4L,5L,4L,4L,9L,6L,7L,4L,6L,7L,3L,0L,5L,4L,9L,1L,8L,9L,4L,8L,0L,5L,5L,5L,0L,5L,7L,1L,6L,6L,0L,2L,0L,8L,2L,2L,2L,1L,3L,2L,3L,8L,8L,8L,1L,5L,4L,8L,3L,6L,1L,7L,1L,6L,4L,6L,1L,4L,7L,3L,4L,1L,1L,8L,9L,9L,4L,6L,5L,4L,6L,0L,3L,0L,7L,1L,5L,0L,7L,8L,3L,3L,7L,0L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019766Inst : IEnumerable<long>
{
public static readonly long[] Value=A019766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019766.Bytes);
public long this[int i]=>Value[i];

public static A019766Inst Instance=new A019766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019767
{
public static readonly long[] Value={ 4L,9L,4L,2L,3L,3L,0L,5L,9L,7L,1L,9L,8L,2L,6L,4L,0L,6L,4L,2L,9L,1L,4L,3L,1L,7L,6L,6L,0L,9L,5L,7L,4L,9L,9L,9L,5L,9L,2L,2L,2L,6L,7L,4L,4L,3L,0L,9L,0L,8L,3L,5L,5L,9L,0L,8L,4L,9L,0L,3L,2L,0L,5L,0L,4L,0L,7L,4L,1L,2L,0L,5L,5L,1L,8L,8L,2L,6L,8L,3L,5L,3L,7L,6L,6L,1L,4L,9L,4L,1L,5L,5L,0L,0L,3L,0L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019767Inst : IEnumerable<long>
{
public static readonly long[] Value=A019767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019767.Bytes);
public long this[int i]=>Value[i];

public static A019767Inst Instance=new A019767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019768
{
public static readonly long[] Value={ 4L,1L,8L,1L,9L,7L,2L,0L,4L,3L,7L,8L,3L,1L,4L,6L,5L,1L,5L,9L,3L,8L,9L,0L,3L,8L,0L,2L,0L,8L,1L,0L,1L,9L,2L,2L,7L,3L,1L,8L,8L,4L,1L,6L,8L,2L,6L,1L,5L,3L,2L,2L,4L,2L,3L,0L,2L,6L,1L,0L,4L,0L,4L,2L,6L,5L,2L,4L,2L,5L,5L,8L,5L,1L,5L,9L,3L,0L,3L,9L,9L,1L,6L,4L,8L,2L,8L,0L,2L,7L,4L,6L,5L,4L,1L,0L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019768Inst : IEnumerable<long>
{
public static readonly long[] Value=A019768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019768.Bytes);
public long this[int i]=>Value[i];

public static A019768Inst Instance=new A019768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019769
{
public static readonly long[] Value={ 3L,6L,2L,4L,3L,7L,5L,7L,7L,1L,2L,7L,8L,7L,2L,6L,9L,8L,0L,4L,8L,0L,3L,8L,3L,2L,9L,5L,1L,3L,6L,8L,8L,3L,3L,3L,0L,3L,4L,2L,9L,9L,6L,1L,2L,4L,9L,3L,3L,2L,7L,9L,4L,3L,3L,2L,8L,9L,2L,9L,0L,1L,7L,0L,2L,9L,8L,7L,6L,8L,8L,4L,0L,4L,7L,1L,3L,9L,6L,7L,9L,2L,7L,6L,1L,8L,4L,2L,9L,0L,4L,7L,0L,0L,2L,2L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019769Inst : IEnumerable<long>
{
public static readonly long[] Value=A019769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019769.Bytes);
public long this[int i]=>Value[i];

public static A019769Inst Instance=new A019769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019770
{
public static readonly long[] Value={ 3L,1L,9L,7L,9L,7L,8L,6L,2L,1L,7L,1L,6L,5L,2L,3L,8L,0L,6L,3L,0L,6L,2L,2L,0L,5L,5L,4L,5L,3L,2L,5L,4L,4L,1L,1L,5L,0L,0L,8L,5L,2L,5L,9L,9L,2L,5L,8L,8L,1L,8L,7L,7L,3L,5L,2L,5L,5L,2L,5L,6L,0L,3L,2L,6L,1L,6L,5L,6L,0L,7L,4L,1L,5L,9L,2L,4L,0L,8L,9L,3L,4L,7L,8L,9L,8L,6L,1L,3L,8L,6L,5L,0L,0L,1L,9L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019770Inst : IEnumerable<long>
{
public static readonly long[] Value=A019770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019770.Bytes);
public long this[int i]=>Value[i];

public static A019770Inst Instance=new A019770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019771
{
public static readonly long[] Value={ 2L,8L,6L,1L,3L,4L,9L,2L,9L,3L,1L,1L,4L,7L,8L,4L,4L,5L,8L,2L,7L,3L,9L,8L,6L,8L,1L,1L,9L,5L,0L,1L,7L,1L,0L,5L,0L,2L,7L,0L,7L,8L,6L,4L,1L,4L,4L,2L,1L,0L,1L,0L,0L,7L,8L,9L,1L,2L,5L,9L,7L,5L,0L,2L,8L,6L,7L,4L,4L,9L,0L,8L,4L,5L,8L,2L,6L,8L,1L,6L,7L,8L,4L,9L,6L,1L,9L,1L,7L,6L,6L,8L,6L,8L,5L,9L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019771Inst : IEnumerable<long>
{
public static readonly long[] Value=A019771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019771.Bytes);
public long this[int i]=>Value[i];

public static A019771Inst Instance=new A019771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019772
{
public static readonly long[] Value={ 2L,5L,8L,8L,8L,3L,9L,8L,3L,6L,6L,2L,7L,6L,6L,2L,1L,2L,8L,9L,1L,4L,5L,5L,9L,4L,9L,6L,5L,2L,6L,3L,4L,5L,2L,3L,5L,9L,5L,9L,2L,8L,2L,9L,4L,6L,3L,8L,0L,9L,1L,3L,8L,8L,0L,9L,2L,0L,9L,2L,1L,5L,5L,0L,2L,1L,3L,4L,0L,6L,3L,1L,4L,6L,2L,2L,4L,2L,6L,2L,8L,0L,5L,4L,4L,1L,7L,3L,5L,0L,3L,3L,5L,7L,3L,0L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019772Inst : IEnumerable<long>
{
public static readonly long[] Value=A019772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019772.Bytes);
public long this[int i]=>Value[i];

public static A019772Inst Instance=new A019772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019773
{
public static readonly long[] Value={ 2L,3L,6L,3L,7L,2L,3L,3L,2L,9L,0L,9L,4L,8L,2L,1L,9L,4L,3L,7L,9L,1L,5L,5L,4L,3L,2L,2L,9L,1L,5L,3L,5L,8L,6L,9L,3L,7L,0L,1L,9L,5L,3L,9L,9L,4L,5L,2L,1L,7L,0L,3L,9L,7L,8L,2L,3L,2L,1L,4L,5L,7L,6L,3L,2L,3L,8L,3L,2L,7L,5L,0L,4L,6L,5L,5L,2L,5L,8L,7L,7L,7L,8L,8L,8L,1L,5L,8L,4L,1L,6L,1L,0L,8L,8L,4L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019773Inst : IEnumerable<long>
{
public static readonly long[] Value=A019773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019773.Bytes);
public long this[int i]=>Value[i];

public static A019773Inst Instance=new A019773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019806
{
public static readonly long[] Value={ 1L,3L,7L,1L,5L,5L,5L,2L,8L,3L,2L,9L,2L,4L,2L,6L,0L,0L,1L,9L,7L,8L,5L,5L,0L,6L,2L,4L,8L,0L,4L,9L,4L,1L,6L,9L,1L,9L,8L,8L,3L,7L,4L,2L,9L,3L,6L,3L,9L,7L,5L,7L,8L,9L,5L,8L,8L,7L,1L,1L,5L,5L,5L,7L,5L,1L,5L,3L,0L,0L,0L,2L,9L,0L,6L,6L,2L,6L,9L,0L,2L,9L,1L,1L,9L,1L,9L,4L,1L,1L,2L,8L,2L,0L,8L,6L,9L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019806Inst : IEnumerable<long>
{
public static readonly long[] Value=A019806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019806.Bytes);
public long this[int i]=>Value[i];

public static A019806Inst Instance=new A019806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019807
{
public static readonly long[] Value={ 1L,2L,2L,7L,1L,8L,1L,0L,4L,2L,9L,4L,5L,8L,5L,4L,8L,4L,3L,8L,7L,5L,5L,4L,5L,2L,9L,5L,8L,7L,8L,1L,0L,5L,7L,2L,4L,4L,1L,0L,6L,5L,0L,6L,8L,3L,7L,8L,2L,9L,4L,1L,2L,7L,5L,2L,6L,7L,4L,1L,9L,1L,8L,3L,0L,4L,0L,0L,0L,5L,2L,8L,9L,1L,6L,4L,5L,5L,6L,4L,9L,9L,7L,3L,8L,2L,2L,6L,3L,1L,1L,4L,7L,1L,3L,0L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019807Inst : IEnumerable<long>
{
public static readonly long[] Value=A019807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019807.Bytes);
public long this[int i]=>Value[i];

public static A019807Inst Instance=new A019807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019808
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,0L,6L,6L,5L,7L,9L,0L,3L,3L,9L,2L,4L,7L,7L,7L,9L,2L,1L,6L,0L,0L,2L,9L,6L,0L,4L,0L,0L,0L,4L,1L,7L,3L,2L,3L,9L,2L,2L,0L,4L,7L,2L,3L,2L,1L,8L,4L,9L,6L,3L,3L,3L,7L,1L,8L,8L,7L,8L,4L,6L,5L,5L,2L,4L,2L,8L,8L,0L,6L,7L,2L,6L,9L,3L,9L,7L,5L,9L,5L,3L,6L,3L,3L,3L,2L,9L,4L,2L,6L,4L,1L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019808Inst : IEnumerable<long>
{
public static readonly long[] Value=A019808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019808.Bytes);
public long this[int i]=>Value[i];

public static A019808Inst Instance=new A019808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019809
{
public static readonly long[] Value={ 1L,0L,1L,3L,7L,5L,8L,2L,5L,2L,8L,6L,8L,3L,1L,4L,8L,7L,1L,0L,2L,7L,6L,2L,4L,3L,7L,4L,8L,5L,5L,8L,2L,6L,4L,6L,7L,9L,9L,1L,4L,0L,7L,0L,8L,6L,6L,0L,3L,2L,9L,9L,3L,1L,4L,3L,5L,1L,3L,4L,6L,2L,8L,1L,6L,4L,1L,7L,4L,3L,4L,9L,9L,7L,4L,4L,6L,3L,3L,6L,3L,0L,2L,1L,8L,5L,3L,4L,7L,7L,9L,0L,4L,1L,5L,1L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019809Inst : IEnumerable<long>
{
public static readonly long[] Value=A019809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019809.Bytes);
public long this[int i]=>Value[i];

public static A019809Inst Instance=new A019809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019810
{
public static readonly long[] Value={ 0L,1L,7L,4L,5L,2L,4L,0L,6L,4L,3L,7L,2L,8L,3L,5L,1L,2L,8L,1L,9L,4L,1L,8L,9L,7L,8L,5L,1L,6L,3L,1L,6L,1L,9L,2L,4L,7L,2L,2L,5L,2L,7L,2L,0L,3L,0L,7L,1L,3L,9L,6L,4L,2L,6L,8L,3L,6L,1L,2L,4L,2L,7L,6L,4L,0L,5L,9L,7L,3L,8L,4L,2L,0L,3L,9L,2L,8L,0L,7L,0L,0L,4L,2L,0L,0L,1L,9L,2L,6L,7L,9L,1L,0L,2L,1L,3L,4L,6L,9L,1L,4L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019810Inst : IEnumerable<long>
{
public static readonly long[] Value=A019810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019810.Bytes);
public long this[int i]=>Value[i];

public static A019810Inst Instance=new A019810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019811
{
public static readonly long[] Value={ 0L,3L,4L,8L,9L,9L,4L,9L,6L,7L,0L,2L,5L,0L,0L,9L,7L,1L,6L,4L,5L,9L,9L,5L,1L,8L,1L,6L,2L,5L,3L,3L,2L,9L,3L,7L,3L,5L,4L,8L,2L,4L,5L,7L,6L,0L,4L,3L,2L,9L,6L,8L,7L,1L,4L,2L,5L,0L,0L,5L,7L,6L,6L,9L,4L,2L,0L,8L,4L,0L,5L,1L,2L,1L,3L,8L,2L,1L,3L,2L,5L,4L,5L,1L,1L,2L,3L,1L,5L,1L,4L,5L,9L,0L,2L,8L,5L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019811Inst : IEnumerable<long>
{
public static readonly long[] Value=A019811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019811.Bytes);
public long this[int i]=>Value[i];

public static A019811Inst Instance=new A019811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019812
{
public static readonly long[] Value={ 0L,5L,2L,3L,3L,5L,9L,5L,6L,2L,4L,2L,9L,4L,3L,8L,3L,2L,7L,2L,2L,1L,1L,8L,6L,2L,9L,6L,0L,9L,0L,7L,8L,4L,1L,8L,7L,3L,1L,0L,1L,8L,2L,5L,3L,9L,4L,0L,1L,6L,4L,9L,2L,0L,4L,8L,3L,5L,0L,9L,3L,8L,1L,5L,9L,9L,8L,5L,7L,1L,0L,4L,6L,4L,1L,7L,5L,4L,5L,4L,6L,8L,6L,4L,4L,6L,4L,5L,9L,8L,8L,1L,1L,8L,8L,6L,9L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019812Inst : IEnumerable<long>
{
public static readonly long[] Value=A019812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019812.Bytes);
public long this[int i]=>Value[i];

public static A019812Inst Instance=new A019812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019813
{
public static readonly long[] Value={ 0L,6L,9L,7L,5L,6L,4L,7L,3L,7L,4L,4L,1L,2L,5L,3L,0L,0L,7L,7L,5L,9L,5L,8L,8L,3L,5L,1L,9L,4L,1L,4L,3L,3L,2L,8L,6L,0L,0L,9L,0L,3L,2L,0L,1L,6L,5L,2L,7L,9L,6L,5L,2L,5L,0L,4L,3L,6L,1L,7L,2L,9L,6L,1L,3L,7L,0L,7L,1L,1L,2L,7L,0L,6L,6L,7L,8L,9L,1L,2L,2L,9L,1L,2L,5L,3L,7L,8L,5L,6L,8L,2L,8L,0L,7L,4L,2L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019813Inst : IEnumerable<long>
{
public static readonly long[] Value=A019813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019813.Bytes);
public long this[int i]=>Value[i];

public static A019813Inst Instance=new A019813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019814
{
public static readonly long[] Value={ 0L,8L,7L,1L,5L,5L,7L,4L,2L,7L,4L,7L,6L,5L,8L,1L,7L,3L,5L,5L,8L,0L,6L,4L,2L,7L,0L,8L,3L,7L,4L,7L,3L,5L,5L,1L,3L,7L,7L,7L,0L,1L,1L,5L,6L,1L,4L,9L,7L,0L,2L,6L,7L,2L,6L,1L,3L,7L,4L,3L,3L,6L,7L,5L,6L,8L,4L,2L,9L,8L,2L,7L,4L,8L,1L,6L,7L,6L,3L,3L,0L,5L,3L,7L,4L,0L,1L,2L,4L,8L,2L,7L,6L,9L,9L,6L,3L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019814Inst : IEnumerable<long>
{
public static readonly long[] Value=A019814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019814.Bytes);
public long this[int i]=>Value[i];

public static A019814Inst Instance=new A019814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019815
{
public static readonly long[] Value={ 1L,0L,4L,5L,2L,8L,4L,6L,3L,2L,6L,7L,6L,5L,3L,4L,7L,1L,3L,9L,9L,8L,3L,4L,1L,5L,4L,8L,0L,2L,4L,9L,8L,1L,1L,9L,0L,8L,0L,6L,5L,5L,8L,6L,9L,4L,7L,4L,5L,9L,3L,1L,1L,3L,9L,9L,3L,2L,7L,5L,4L,7L,6L,7L,1L,2L,4L,8L,4L,6L,5L,0L,6L,9L,3L,1L,8L,0L,0L,4L,6L,8L,2L,8L,1L,8L,0L,3L,9L,8L,7L,9L,8L,6L,0L,4L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019815Inst : IEnumerable<long>
{
public static readonly long[] Value=A019815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019815.Bytes);
public long this[int i]=>Value[i];

public static A019815Inst Instance=new A019815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019816
{
public static readonly long[] Value={ 1L,2L,1L,8L,6L,9L,3L,4L,3L,4L,0L,5L,1L,4L,7L,4L,8L,1L,1L,1L,2L,8L,9L,3L,9L,1L,9L,2L,3L,1L,5L,2L,5L,1L,7L,6L,0L,1L,3L,2L,3L,5L,6L,4L,6L,4L,7L,1L,4L,6L,8L,7L,2L,0L,9L,2L,7L,0L,4L,8L,8L,7L,3L,9L,7L,7L,9L,5L,1L,3L,7L,8L,7L,5L,2L,8L,0L,7L,3L,4L,6L,2L,7L,5L,4L,7L,5L,3L,3L,1L,9L,5L,6L,5L,9L,5L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019816Inst : IEnumerable<long>
{
public static readonly long[] Value=A019816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019816.Bytes);
public long this[int i]=>Value[i];

public static A019816Inst Instance=new A019816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019817
{
public static readonly long[] Value={ 1L,3L,9L,1L,7L,3L,1L,0L,0L,9L,6L,0L,0L,6L,5L,4L,4L,4L,1L,1L,2L,4L,9L,6L,6L,6L,3L,3L,0L,1L,1L,0L,5L,2L,7L,5L,4L,5L,5L,9L,2L,4L,9L,3L,1L,3L,7L,3L,5L,6L,8L,8L,7L,6L,6L,0L,1L,6L,8L,6L,6L,0L,3L,0L,1L,8L,1L,3L,3L,1L,1L,5L,7L,0L,0L,8L,6L,6L,6L,0L,9L,8L,5L,1L,4L,0L,4L,9L,3L,8L,8L,6L,4L,0L,2L,8L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019817Inst : IEnumerable<long>
{
public static readonly long[] Value=A019817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019817.Bytes);
public long this[int i]=>Value[i];

public static A019817Inst Instance=new A019817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019818
{
public static readonly long[] Value={ 1L,5L,6L,4L,3L,4L,4L,6L,5L,0L,4L,0L,2L,3L,0L,8L,6L,9L,0L,1L,0L,1L,0L,5L,3L,1L,9L,4L,6L,7L,1L,6L,6L,8L,9L,2L,3L,1L,3L,8L,9L,9L,8L,9L,2L,0L,8L,5L,6L,6L,0L,7L,9L,0L,0L,8L,4L,6L,4L,1L,3L,4L,6L,0L,5L,7L,7L,5L,8L,7L,9L,3L,3L,0L,5L,6L,2L,3L,5L,7L,9L,3L,3L,6L,6L,9L,5L,8L,7L,2L,6L,7L,6L,8L,4L,8L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019818Inst : IEnumerable<long>
{
public static readonly long[] Value=A019818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019818.Bytes);
public long this[int i]=>Value[i];

public static A019818Inst Instance=new A019818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019819
{
public static readonly long[] Value={ 1L,7L,3L,6L,4L,8L,1L,7L,7L,6L,6L,6L,9L,3L,0L,3L,4L,8L,8L,5L,1L,7L,1L,6L,6L,2L,6L,7L,6L,9L,3L,1L,4L,7L,9L,6L,0L,0L,0L,3L,7L,5L,6L,7L,7L,1L,8L,4L,0L,6L,9L,3L,8L,7L,2L,3L,6L,2L,4L,1L,3L,7L,8L,1L,3L,2L,0L,6L,5L,8L,2L,2L,1L,3L,9L,0L,1L,4L,7L,3L,5L,4L,2L,1L,5L,1L,6L,6L,1L,3L,1L,5L,7L,3L,9L,9L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019819Inst : IEnumerable<long>
{
public static readonly long[] Value=A019819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019819.Bytes);
public long this[int i]=>Value[i];

public static A019819Inst Instance=new A019819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019820
{
public static readonly long[] Value={ 1L,9L,0L,8L,0L,8L,9L,9L,5L,3L,7L,6L,5L,4L,4L,8L,1L,2L,4L,0L,5L,1L,4L,0L,4L,8L,7L,9L,5L,8L,3L,8L,7L,6L,1L,9L,6L,2L,7L,9L,2L,0L,7L,5L,1L,2L,7L,4L,0L,5L,5L,2L,6L,6L,9L,6L,8L,8L,1L,8L,1L,3L,2L,6L,1L,7L,9L,7L,8L,3L,9L,9L,2L,0L,2L,1L,7L,7L,5L,4L,6L,5L,0L,8L,8L,6L,5L,9L,2L,4L,7L,3L,9L,1L,6L,7L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019820Inst : IEnumerable<long>
{
public static readonly long[] Value=A019820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019820.Bytes);
public long this[int i]=>Value[i];

public static A019820Inst Instance=new A019820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019821
{
public static readonly long[] Value={ 2L,0L,7L,9L,1L,1L,6L,9L,0L,8L,1L,7L,7L,5L,9L,3L,3L,7L,1L,0L,1L,7L,4L,2L,2L,8L,4L,4L,0L,5L,1L,2L,5L,1L,6L,6L,2L,1L,6L,5L,8L,4L,7L,6L,0L,6L,2L,7L,7L,2L,3L,8L,3L,6L,4L,0L,7L,1L,8L,1L,9L,7L,3L,8L,8L,2L,3L,8L,2L,8L,2L,5L,6L,6L,4L,0L,7L,4L,3L,7L,6L,3L,0L,4L,6L,2L,8L,7L,5L,6L,7L,2L,2L,7L,2L,7L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019821Inst : IEnumerable<long>
{
public static readonly long[] Value=A019821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019821.Bytes);
public long this[int i]=>Value[i];

public static A019821Inst Instance=new A019821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019838
{
public static readonly long[] Value={ 4L,8L,4L,8L,0L,9L,6L,2L,0L,2L,4L,6L,3L,3L,7L,0L,2L,9L,0L,7L,5L,3L,7L,9L,6L,2L,2L,4L,1L,5L,7L,7L,6L,5L,6L,8L,2L,7L,6L,6L,5L,7L,4L,7L,6L,8L,3L,6L,8L,6L,6L,4L,6L,5L,7L,9L,7L,1L,0L,0L,4L,3L,8L,3L,1L,1L,0L,3L,4L,7L,4L,4L,7L,3L,2L,4L,0L,7L,9L,8L,3L,5L,1L,6L,9L,2L,6L,5L,8L,4L,7L,0L,3L,4L,6L,6L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019838Inst : IEnumerable<long>
{
public static readonly long[] Value=A019838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019838.Bytes);
public long this[int i]=>Value[i];

public static A019838Inst Instance=new A019838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019839
{
public static readonly BigInteger[] Value={ 1L,21L,301L,3681L,41461L,445641L,4658221L,47871201L,486836581L,4919066361L,49504632541L,496978967121L,4981629662101L,49888557269481L,499325240101261L,4995920923029441L,49975372950286021L,499851474762263001L,4999105033876312381L,BigInteger.Parse("49994611129771546161") };
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
public class A019839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019839Inst Instance=new A019839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019840
{
public static readonly long[] Value={ 5L,1L,5L,0L,3L,8L,0L,7L,4L,9L,1L,0L,0L,5L,4L,2L,1L,0L,0L,8L,1L,6L,3L,1L,9L,3L,6L,3L,9L,8L,1L,3L,8L,2L,8L,3L,4L,1L,6L,0L,8L,2L,8L,3L,3L,7L,4L,6L,3L,1L,9L,4L,7L,3L,8L,6L,1L,2L,2L,0L,2L,7L,6L,2L,0L,0L,5L,0L,4L,4L,3L,6L,3L,7L,0L,9L,2L,9L,2L,3L,1L,8L,8L,0L,3L,7L,2L,8L,1L,0L,5L,8L,4L,6L,4L,3L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019840Inst : IEnumerable<long>
{
public static readonly long[] Value=A019840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019840.Bytes);
public long this[int i]=>Value[i];

public static A019840Inst Instance=new A019840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019841
{
public static readonly long[] Value={ 5L,2L,9L,9L,1L,9L,2L,6L,4L,2L,3L,3L,2L,0L,4L,9L,5L,4L,0L,4L,6L,7L,8L,1L,1L,5L,1L,8L,1L,6L,0L,8L,6L,6L,6L,8L,7L,7L,2L,0L,1L,7L,5L,4L,9L,9L,5L,8L,7L,9L,9L,9L,6L,4L,7L,6L,7L,7L,9L,2L,1L,0L,8L,6L,2L,0L,0L,4L,8L,8L,2L,6L,7L,4L,4L,1L,7L,3L,3L,2L,9L,5L,5L,5L,3L,5L,6L,8L,0L,6L,4L,8L,3L,5L,2L,7L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019841Inst : IEnumerable<long>
{
public static readonly long[] Value=A019841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019841.Bytes);
public long this[int i]=>Value[i];

public static A019841Inst Instance=new A019841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019842
{
public static readonly long[] Value={ 5L,4L,4L,6L,3L,9L,0L,3L,5L,0L,1L,5L,0L,2L,7L,0L,8L,2L,2L,2L,4L,0L,8L,3L,6L,9L,2L,0L,8L,1L,5L,6L,5L,3L,8L,1L,6L,0L,7L,9L,0L,4L,5L,8L,7L,7L,1L,8L,7L,6L,3L,9L,7L,5L,4L,5L,6L,1L,2L,5L,2L,4L,9L,0L,0L,9L,6L,2L,2L,1L,8L,9L,6L,0L,1L,6L,2L,5L,8L,8L,9L,8L,8L,0L,8L,5L,8L,5L,8L,9L,0L,1L,1L,3L,2L,8L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019842Inst : IEnumerable<long>
{
public static readonly long[] Value=A019842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019842.Bytes);
public long this[int i]=>Value[i];

public static A019842Inst Instance=new A019842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019843
{
public static readonly long[] Value={ 5L,5L,9L,1L,9L,2L,9L,0L,3L,4L,7L,0L,7L,4L,6L,8L,3L,0L,1L,6L,0L,4L,2L,8L,1L,3L,9L,9L,8L,5L,9L,8L,9L,2L,8L,7L,3L,0L,6L,6L,2L,1L,9L,4L,0L,3L,9L,5L,6L,6L,9L,4L,2L,1L,7L,9L,4L,8L,6L,9L,3L,5L,2L,2L,4L,5L,4L,0L,2L,8L,4L,7L,3L,9L,7L,6L,4L,2L,8L,3L,9L,1L,7L,7L,5L,0L,8L,8L,0L,5L,3L,1L,0L,7L,2L,6L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019843Inst : IEnumerable<long>
{
public static readonly long[] Value=A019843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019843.Bytes);
public long this[int i]=>Value[i];

public static A019843Inst Instance=new A019843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019844
{
public static readonly long[] Value={ 5L,7L,3L,5L,7L,6L,4L,3L,6L,3L,5L,1L,0L,4L,6L,0L,9L,6L,1L,0L,8L,0L,3L,1L,9L,1L,2L,8L,2L,6L,1L,5L,7L,8L,6L,4L,6L,2L,0L,4L,3L,3L,3L,7L,1L,4L,5L,0L,9L,8L,6L,3L,5L,1L,0L,8L,1L,0L,2L,7L,1L,1L,8L,1L,6L,9L,4L,5L,6L,8L,9L,9L,8L,5L,2L,5L,6L,1L,6L,1L,0L,0L,5L,9L,7L,2L,2L,0L,1L,2L,6L,4L,0L,2L,2L,0L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019844Inst : IEnumerable<long>
{
public static readonly long[] Value=A019844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019844.Bytes);
public long this[int i]=>Value[i];

public static A019844Inst Instance=new A019844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019845
{
public static readonly long[] Value={ 5L,8L,7L,7L,8L,5L,2L,5L,2L,2L,9L,2L,4L,7L,3L,1L,2L,9L,1L,6L,8L,7L,0L,5L,9L,5L,4L,6L,3L,9L,0L,7L,2L,7L,6L,8L,5L,9L,7L,6L,5L,2L,4L,3L,7L,6L,4L,3L,1L,4L,5L,9L,9L,1L,0L,7L,2L,2L,7L,2L,4L,8L,0L,7L,5L,7L,2L,7L,8L,4L,7L,4L,1L,6L,2L,3L,5L,1L,9L,5L,7L,5L,0L,8L,5L,0L,4L,0L,4L,9L,8L,6L,2L,7L,4L,1L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019845Inst : IEnumerable<long>
{
public static readonly long[] Value=A019845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019845.Bytes);
public long this[int i]=>Value[i];

public static A019845Inst Instance=new A019845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019846
{
public static readonly long[] Value={ 6L,0L,1L,8L,1L,5L,0L,2L,3L,1L,5L,2L,0L,4L,8L,2L,7L,9L,9L,1L,7L,9L,7L,7L,0L,0L,0L,4L,4L,1L,4L,8L,9L,8L,4L,1L,4L,2L,5L,6L,3L,7L,7L,0L,9L,8L,3L,0L,3L,9L,6L,1L,5L,6L,4L,8L,8L,4L,4L,7L,0L,2L,6L,5L,4L,5L,5L,4L,2L,7L,8L,9L,6L,1L,5L,1L,1L,9L,6L,3L,9L,7L,4L,2L,4L,6L,4L,6L,1L,8L,9L,6L,6L,3L,5L,5L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019846Inst : IEnumerable<long>
{
public static readonly long[] Value=A019846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019846.Bytes);
public long this[int i]=>Value[i];

public static A019846Inst Instance=new A019846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019847
{
public static readonly long[] Value={ 6L,1L,5L,6L,6L,1L,4L,7L,5L,3L,2L,5L,6L,5L,8L,2L,7L,9L,6L,6L,8L,8L,1L,1L,0L,9L,2L,8L,4L,3L,6L,5L,5L,6L,2L,8L,2L,5L,0L,9L,3L,0L,8L,7L,1L,5L,1L,5L,2L,1L,0L,3L,2L,5L,9L,8L,6L,2L,7L,3L,7L,5L,6L,5L,6L,7L,6L,3L,7L,2L,0L,3L,3L,6L,3L,2L,5L,1L,2L,3L,6L,0L,3L,1L,2L,8L,2L,8L,8L,0L,5L,3L,7L,1L,6L,4L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019847Inst : IEnumerable<long>
{
public static readonly long[] Value=A019847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019847.Bytes);
public long this[int i]=>Value[i];

public static A019847Inst Instance=new A019847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019848
{
public static readonly long[] Value={ 6L,2L,9L,3L,2L,0L,3L,9L,1L,0L,4L,9L,8L,3L,7L,4L,5L,2L,7L,0L,5L,9L,0L,2L,4L,5L,8L,2L,7L,9L,9L,7L,0L,4L,2L,6L,5L,6L,6L,8L,6L,2L,4L,1L,2L,1L,2L,9L,8L,6L,6L,6L,3L,9L,4L,6L,0L,3L,2L,8L,0L,2L,5L,7L,8L,0L,7L,5L,3L,0L,0L,9L,9L,8L,7L,2L,1L,3L,6L,3L,6L,7L,2L,4L,6L,4L,6L,9L,4L,6L,6L,0L,6L,8L,9L,9L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019848Inst : IEnumerable<long>
{
public static readonly long[] Value=A019848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019848.Bytes);
public long this[int i]=>Value[i];

public static A019848Inst Instance=new A019848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019849
{
public static readonly long[] Value={ 6L,4L,2L,7L,8L,7L,6L,0L,9L,6L,8L,6L,5L,3L,9L,3L,2L,6L,3L,2L,2L,6L,4L,3L,4L,0L,9L,9L,0L,7L,2L,6L,3L,4L,3L,2L,9L,0L,7L,5L,5L,9L,8L,8L,4L,2L,0L,5L,6L,8L,1L,7L,9L,0L,3L,2L,4L,9L,7L,7L,2L,5L,4L,6L,7L,1L,1L,1L,2L,8L,3L,6L,2L,4L,0L,9L,5L,8L,6L,3L,9L,7L,1L,0L,4L,8L,8L,2L,2L,7L,7L,1L,7L,5L,9L,4L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019849Inst : IEnumerable<long>
{
public static readonly long[] Value=A019849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019849.Bytes);
public long this[int i]=>Value[i];

public static A019849Inst Instance=new A019849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019850
{
public static readonly long[] Value={ 6L,5L,6L,0L,5L,9L,0L,2L,8L,9L,9L,0L,5L,0L,7L,2L,8L,4L,7L,8L,2L,4L,9L,5L,9L,6L,4L,0L,2L,3L,4L,1L,9L,2L,4L,7L,5L,1L,9L,4L,0L,1L,6L,9L,7L,8L,7L,0L,3L,4L,9L,7L,8L,9L,8L,1L,0L,2L,3L,4L,1L,5L,4L,6L,5L,4L,5L,6L,7L,4L,6L,3L,7L,9L,7L,7L,2L,5L,6L,2L,3L,6L,8L,3L,7L,8L,7L,4L,2L,6L,3L,9L,4L,2L,7L,1L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019850Inst : IEnumerable<long>
{
public static readonly long[] Value=A019850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019850.Bytes);
public long this[int i]=>Value[i];

public static A019850Inst Instance=new A019850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019851
{
public static readonly long[] Value={ 6L,6L,9L,1L,3L,0L,6L,0L,6L,3L,5L,8L,8L,5L,8L,2L,1L,3L,8L,2L,6L,2L,7L,3L,3L,3L,0L,6L,8L,6L,7L,8L,0L,4L,7L,3L,5L,9L,9L,5L,8L,3L,2L,1L,8L,9L,5L,9L,7L,9L,5L,6L,7L,6L,8L,1L,7L,4L,5L,3L,3L,5L,2L,2L,8L,7L,9L,6L,6L,6L,0L,1L,7L,1L,0L,6L,4L,3L,8L,9L,7L,1L,4L,6L,1L,5L,4L,9L,2L,3L,3L,6L,0L,0L,9L,0L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019851Inst : IEnumerable<long>
{
public static readonly long[] Value=A019851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019851.Bytes);
public long this[int i]=>Value[i];

public static A019851Inst Instance=new A019851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019852
{
public static readonly long[] Value={ 6L,8L,1L,9L,9L,8L,3L,6L,0L,0L,6L,2L,4L,9L,8L,5L,0L,0L,4L,4L,2L,2L,2L,5L,7L,8L,4L,7L,1L,1L,1L,2L,5L,5L,8L,0L,3L,4L,0L,4L,3L,3L,8L,0L,2L,7L,6L,1L,9L,4L,3L,4L,0L,2L,8L,7L,8L,3L,0L,7L,8L,5L,3L,0L,6L,7L,5L,3L,6L,8L,8L,1L,8L,7L,4L,9L,5L,5L,7L,2L,1L,6L,1L,4L,0L,0L,2L,2L,3L,8L,6L,8L,2L,0L,0L,3L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019852Inst : IEnumerable<long>
{
public static readonly long[] Value=A019852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019852.Bytes);
public long this[int i]=>Value[i];

public static A019852Inst Instance=new A019852Inst();

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