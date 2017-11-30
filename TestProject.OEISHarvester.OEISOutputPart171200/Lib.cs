using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201657
{
public static readonly long[] Value={ 3L,1L,2L,8L,8L,2L,3L,5L,7L,1L,9L,0L,1L,6L,5L,4L,9L,3L,7L,2L,7L,5L,7L,5L,2L,4L,8L,4L,7L,2L,5L,0L,2L,8L,8L,3L,2L,9L,3L,5L,6L,2L,6L,0L,4L,0L,3L,6L,8L,4L,2L,0L,1L,5L,6L,6L,1L,4L,6L,1L,4L,9L,2L,7L,1L,4L,3L,3L,7L,0L,1L,9L,7L,0L,0L,7L,8L,0L,2L,5L,0L,1L,7L,3L,4L,0L,2L,6L,9L,9L,5L,3L,8L,2L,2L,6L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201657Inst : IEnumerable<long>
{
public static readonly long[] Value=A201657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201657.Bytes);
public long this[int i]=>Value[i];

public static A201657Inst Instance=new A201657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201658
{
public static readonly long[] Value={ 4L,8L,7L,1L,8L,2L,5L,7L,2L,5L,4L,6L,1L,3L,4L,3L,6L,0L,7L,6L,7L,5L,4L,2L,4L,3L,0L,0L,4L,3L,0L,6L,4L,2L,2L,0L,7L,8L,2L,6L,9L,9L,4L,2L,5L,6L,4L,3L,6L,3L,7L,9L,2L,2L,0L,6L,4L,9L,1L,8L,6L,8L,7L,1L,6L,1L,6L,4L,4L,1L,1L,2L,2L,6L,7L,3L,6L,5L,8L,8L,1L,0L,1L,3L,7L,2L,0L,6L,4L,4L,3L,8L,3L,5L,5L,6L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201658Inst : IEnumerable<long>
{
public static readonly long[] Value=A201658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201658.Bytes);
public long this[int i]=>Value[i];

public static A201658Inst Instance=new A201658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201659
{
public static readonly long[] Value={ 3L,1L,3L,0L,2L,5L,2L,7L,8L,6L,1L,7L,3L,5L,3L,6L,0L,3L,5L,0L,0L,3L,7L,0L,1L,2L,2L,7L,7L,7L,5L,4L,0L,3L,1L,6L,3L,6L,9L,2L,7L,7L,5L,4L,0L,1L,2L,3L,7L,9L,0L,9L,2L,2L,3L,2L,0L,4L,2L,7L,8L,8L,9L,1L,6L,2L,7L,6L,5L,5L,0L,4L,1L,7L,3L,6L,7L,9L,6L,3L,0L,5L,0L,2L,1L,9L,0L,5L,4L,6L,7L,0L,4L,3L,8L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201659Inst : IEnumerable<long>
{
public static readonly long[] Value=A201659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201659.Bytes);
public long this[int i]=>Value[i];

public static A201659Inst Instance=new A201659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201660
{
public static readonly long[] Value={ 4L,6L,9L,9L,3L,1L,6L,0L,6L,0L,0L,0L,5L,8L,8L,9L,2L,2L,8L,6L,8L,6L,5L,3L,5L,3L,5L,0L,6L,1L,8L,9L,1L,3L,0L,6L,3L,8L,8L,3L,0L,0L,1L,3L,8L,0L,3L,5L,1L,8L,7L,1L,7L,7L,1L,9L,5L,5L,5L,3L,2L,2L,0L,6L,5L,8L,3L,1L,9L,3L,9L,2L,9L,8L,6L,4L,9L,6L,1L,7L,2L,5L,3L,0L,5L,5L,7L,6L,3L,7L,9L,3L,3L,3L,7L,8L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201660Inst : IEnumerable<long>
{
public static readonly long[] Value=A201660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201660.Bytes);
public long this[int i]=>Value[i];

public static A201660Inst Instance=new A201660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201661
{
public static readonly long[] Value={ 1L,4L,1L,8L,3L,5L,5L,6L,1L,8L,5L,4L,4L,9L,4L,2L,6L,5L,6L,3L,3L,5L,3L,0L,6L,2L,3L,6L,8L,7L,2L,0L,8L,1L,9L,1L,9L,3L,3L,6L,0L,8L,6L,0L,7L,1L,9L,4L,4L,2L,3L,1L,8L,8L,8L,4L,1L,9L,9L,5L,2L,7L,3L,9L,8L,4L,1L,1L,0L,9L,3L,7L,8L,2L,6L,9L,7L,4L,6L,2L,0L,7L,9L,6L,9L,2L,0L,3L,5L,0L,8L,7L,4L,1L,3L,1L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201661Inst : IEnumerable<long>
{
public static readonly long[] Value=A201661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201661.Bytes);
public long this[int i]=>Value[i];

public static A201661Inst Instance=new A201661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201662
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,9L,4L,2L,5L,3L,9L,2L,0L,6L,8L,9L,9L,3L,5L,4L,4L,4L,0L,2L,8L,6L,2L,2L,2L,3L,8L,7L,4L,7L,0L,2L,5L,1L,2L,2L,6L,9L,2L,6L,3L,5L,3L,4L,1L,8L,2L,7L,3L,1L,3L,6L,8L,5L,9L,4L,6L,4L,8L,3L,8L,3L,0L,4L,0L,3L,1L,1L,3L,7L,1L,5L,0L,1L,9L,1L,2L,0L,1L,8L,7L,9L,9L,5L,5L,4L,2L,2L,5L,3L,4L,0L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201662Inst : IEnumerable<long>
{
public static readonly long[] Value=A201662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201662.Bytes);
public long this[int i]=>Value[i];

public static A201662Inst Instance=new A201662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201663
{
public static readonly long[] Value={ 3L,0L,1L,7L,9L,4L,2L,4L,7L,4L,5L,3L,6L,1L,5L,1L,2L,2L,7L,8L,5L,2L,5L,7L,2L,0L,8L,3L,2L,7L,7L,1L,6L,7L,2L,5L,2L,8L,9L,4L,2L,8L,4L,3L,4L,1L,4L,3L,6L,2L,0L,0L,3L,3L,1L,9L,5L,6L,9L,9L,8L,3L,6L,0L,1L,0L,5L,7L,5L,6L,1L,5L,5L,3L,1L,4L,4L,6L,0L,8L,3L,8L,7L,2L,3L,6L,5L,8L,4L,5L,3L,2L,1L,8L,4L,8L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201663Inst : IEnumerable<long>
{
public static readonly long[] Value=A201663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201663.Bytes);
public long this[int i]=>Value[i];

public static A201663Inst Instance=new A201663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201664
{
public static readonly long[] Value={ 1L,0L,3L,9L,2L,4L,5L,6L,5L,0L,7L,9L,7L,2L,4L,7L,7L,9L,3L,2L,3L,1L,9L,2L,9L,3L,2L,7L,2L,4L,2L,4L,8L,3L,7L,3L,0L,0L,0L,0L,8L,0L,9L,3L,7L,9L,8L,9L,5L,8L,9L,7L,9L,8L,3L,3L,6L,4L,4L,7L,1L,6L,0L,5L,2L,3L,5L,7L,4L,2L,6L,8L,0L,3L,4L,7L,4L,2L,1L,1L,9L,0L,7L,0L,0L,8L,4L,2L,0L,0L,0L,4L,3L,2L,9L,1L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201664Inst : IEnumerable<long>
{
public static readonly long[] Value=A201664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201664.Bytes);
public long this[int i]=>Value[i];

public static A201664Inst Instance=new A201664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201665
{
public static readonly long[] Value={ 3L,0L,8L,6L,1L,5L,8L,7L,7L,4L,3L,7L,7L,1L,2L,7L,1L,8L,1L,2L,2L,5L,9L,4L,8L,2L,8L,6L,3L,5L,8L,2L,1L,4L,5L,2L,4L,9L,8L,5L,3L,3L,6L,2L,2L,2L,6L,5L,7L,2L,2L,3L,1L,2L,0L,5L,5L,0L,0L,3L,9L,9L,0L,9L,2L,5L,4L,4L,4L,8L,6L,8L,6L,5L,9L,4L,8L,8L,2L,3L,8L,2L,7L,4L,4L,0L,4L,8L,0L,4L,6L,9L,4L,9L,0L,8L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201665Inst : IEnumerable<long>
{
public static readonly long[] Value=A201665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201665.Bytes);
public long this[int i]=>Value[i];

public static A201665Inst Instance=new A201665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201666
{
public static readonly long[] Value={ 8L,7L,5L,9L,4L,3L,7L,3L,8L,7L,2L,4L,3L,5L,6L,4L,4L,1L,5L,4L,9L,4L,6L,2L,8L,6L,7L,9L,5L,5L,3L,0L,3L,8L,7L,6L,3L,2L,3L,3L,7L,0L,6L,0L,9L,4L,6L,0L,1L,1L,0L,6L,5L,5L,1L,5L,3L,7L,4L,4L,6L,4L,2L,5L,8L,2L,0L,8L,7L,3L,4L,0L,1L,5L,9L,7L,0L,3L,5L,4L,4L,2L,8L,6L,7L,8L,8L,9L,5L,6L,9L,7L,2L,2L,4L,6L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201666Inst : IEnumerable<long>
{
public static readonly long[] Value=A201666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201666.Bytes);
public long this[int i]=>Value[i];

public static A201666Inst Instance=new A201666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201667
{
public static readonly long[] Value={ 3L,1L,0L,5L,7L,9L,1L,2L,2L,9L,3L,6L,3L,0L,8L,2L,2L,7L,7L,9L,2L,8L,9L,6L,7L,9L,3L,1L,6L,1L,4L,3L,1L,4L,3L,0L,3L,5L,9L,5L,3L,6L,9L,7L,6L,5L,5L,5L,2L,9L,1L,7L,0L,3L,3L,2L,2L,8L,1L,2L,7L,8L,5L,1L,1L,4L,2L,9L,5L,2L,0L,6L,7L,4L,2L,4L,0L,0L,2L,7L,5L,4L,0L,8L,2L,0L,1L,2L,1L,2L,0L,0L,3L,9L,9L,4L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201667Inst : IEnumerable<long>
{
public static readonly long[] Value=A201667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201667.Bytes);
public long this[int i]=>Value[i];

public static A201667Inst Instance=new A201667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201668
{
public static readonly long[] Value={ 7L,7L,8L,4L,7L,6L,7L,7L,7L,2L,7L,7L,5L,9L,4L,2L,3L,1L,2L,9L,0L,0L,3L,5L,2L,7L,9L,9L,8L,6L,7L,2L,6L,8L,7L,7L,9L,8L,6L,1L,2L,4L,8L,6L,5L,6L,2L,6L,2L,4L,6L,1L,1L,5L,6L,8L,0L,0L,6L,2L,0L,9L,6L,5L,7L,7L,6L,3L,2L,2L,1L,7L,5L,3L,8L,6L,6L,8L,9L,4L,8L,6L,1L,4L,6L,8L,3L,7L,2L,9L,9L,1L,2L,4L,5L,4L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201668Inst : IEnumerable<long>
{
public static readonly long[] Value=A201668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201668.Bytes);
public long this[int i]=>Value[i];

public static A201668Inst Instance=new A201668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201669
{
public static readonly long[] Value={ 3L,1L,1L,5L,1L,4L,6L,1L,1L,6L,0L,4L,0L,3L,6L,1L,2L,6L,7L,1L,5L,1L,9L,3L,1L,5L,4L,7L,4L,5L,0L,3L,2L,5L,8L,9L,2L,0L,0L,2L,1L,8L,5L,9L,2L,8L,9L,5L,2L,8L,0L,5L,4L,1L,6L,1L,9L,3L,4L,0L,5L,8L,9L,2L,4L,4L,2L,1L,3L,9L,6L,5L,0L,1L,1L,7L,1L,2L,4L,8L,6L,6L,3L,9L,9L,7L,8L,0L,0L,3L,8L,5L,3L,4L,9L,5L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201669Inst : IEnumerable<long>
{
public static readonly long[] Value=A201669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201669.Bytes);
public long this[int i]=>Value[i];

public static A201669Inst Instance=new A201669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201670
{
public static readonly long[] Value={ 7L,1L,1L,5L,3L,3L,8L,8L,8L,3L,6L,7L,1L,5L,1L,4L,9L,9L,2L,4L,6L,7L,9L,6L,3L,0L,7L,4L,2L,8L,2L,1L,2L,5L,5L,6L,7L,7L,2L,7L,9L,9L,2L,0L,5L,9L,3L,7L,5L,3L,9L,0L,7L,5L,8L,0L,6L,0L,8L,8L,5L,4L,9L,8L,9L,2L,8L,4L,1L,5L,5L,0L,8L,2L,3L,4L,4L,8L,5L,4L,3L,7L,4L,6L,3L,2L,1L,8L,4L,5L,9L,7L,9L,8L,6L,8L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201670Inst : IEnumerable<long>
{
public static readonly long[] Value=A201670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201670.Bytes);
public long this[int i]=>Value[i];

public static A201670Inst Instance=new A201670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201671
{
public static readonly long[] Value={ 3L,1L,2L,0L,6L,2L,2L,9L,9L,3L,0L,8L,6L,9L,1L,8L,8L,0L,5L,1L,4L,1L,2L,7L,3L,4L,2L,4L,6L,2L,3L,0L,6L,6L,0L,0L,2L,1L,7L,0L,0L,3L,5L,6L,2L,4L,5L,2L,7L,7L,9L,7L,3L,7L,1L,1L,0L,9L,8L,7L,8L,5L,9L,1L,2L,2L,8L,1L,0L,3L,9L,7L,7L,4L,6L,4L,5L,3L,7L,4L,0L,0L,1L,4L,8L,8L,0L,6L,3L,0L,8L,4L,4L,1L,1L,7L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201671Inst : IEnumerable<long>
{
public static readonly long[] Value=A201671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201671.Bytes);
public long this[int i]=>Value[i];

public static A201671Inst Instance=new A201671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201672
{
public static readonly long[] Value={ 6L,6L,1L,7L,3L,6L,5L,5L,7L,1L,6L,9L,7L,4L,4L,2L,2L,6L,2L,4L,1L,8L,2L,9L,8L,3L,7L,0L,9L,4L,0L,0L,2L,6L,0L,7L,7L,4L,7L,4L,7L,9L,8L,8L,1L,3L,8L,2L,5L,3L,8L,4L,1L,0L,2L,5L,2L,2L,4L,5L,7L,7L,6L,0L,7L,8L,5L,2L,8L,6L,9L,1L,9L,6L,5L,1L,3L,1L,9L,6L,9L,6L,0L,3L,3L,1L,1L,1L,0L,9L,3L,6L,1L,5L,6L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201672Inst : IEnumerable<long>
{
public static readonly long[] Value=A201672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201672.Bytes);
public long this[int i]=>Value[i];

public static A201672Inst Instance=new A201672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201673
{
public static readonly long[] Value={ 3L,1L,2L,4L,2L,1L,9L,9L,6L,2L,7L,0L,6L,0L,8L,1L,5L,9L,4L,8L,9L,8L,9L,0L,6L,2L,1L,0L,9L,2L,0L,2L,8L,5L,4L,6L,6L,3L,5L,1L,1L,0L,2L,3L,7L,1L,5L,8L,1L,0L,4L,2L,3L,4L,1L,4L,5L,4L,2L,2L,1L,2L,3L,6L,0L,3L,6L,9L,3L,1L,5L,6L,3L,5L,3L,5L,6L,3L,8L,9L,6L,0L,0L,3L,7L,0L,8L,8L,0L,2L,3L,5L,9L,8L,9L,9L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201673Inst : IEnumerable<long>
{
public static readonly long[] Value=A201673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201673.Bytes);
public long this[int i]=>Value[i];

public static A201673Inst Instance=new A201673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201674
{
public static readonly long[] Value={ 6L,2L,2L,7L,2L,7L,0L,9L,4L,3L,1L,3L,6L,9L,5L,1L,0L,3L,7L,9L,5L,0L,3L,9L,9L,3L,9L,2L,8L,6L,5L,2L,2L,8L,9L,0L,1L,3L,8L,6L,1L,8L,3L,1L,8L,7L,7L,3L,8L,7L,6L,7L,8L,7L,6L,6L,7L,6L,5L,5L,3L,8L,3L,7L,6L,3L,8L,3L,2L,5L,8L,1L,7L,2L,4L,1L,3L,6L,6L,9L,8L,0L,6L,9L,0L,3L,0L,9L,2L,9L,6L,2L,6L,6L,8L,6L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201674Inst : IEnumerable<long>
{
public static readonly long[] Value=A201674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201674.Bytes);
public long this[int i]=>Value[i];

public static A201674Inst Instance=new A201674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201675
{
public static readonly long[] Value={ 3L,1L,2L,6L,7L,6L,3L,3L,5L,4L,8L,1L,7L,8L,4L,3L,9L,5L,8L,3L,2L,4L,7L,1L,0L,5L,4L,3L,0L,4L,1L,3L,9L,3L,5L,0L,0L,8L,6L,9L,5L,6L,0L,6L,7L,8L,0L,4L,2L,4L,0L,6L,1L,3L,9L,9L,3L,3L,0L,3L,2L,1L,0L,4L,5L,3L,3L,0L,3L,9L,5L,9L,0L,7L,3L,7L,1L,4L,3L,9L,0L,9L,5L,1L,1L,5L,5L,1L,5L,2L,7L,8L,9L,8L,4L,2L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201675Inst : IEnumerable<long>
{
public static readonly long[] Value=A201675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201675.Bytes);
public long this[int i]=>Value[i];

public static A201675Inst Instance=new A201675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201676
{
public static readonly long[] Value={ 5L,9L,1L,0L,3L,8L,4L,5L,6L,3L,4L,1L,7L,9L,2L,3L,5L,6L,7L,5L,1L,1L,9L,5L,4L,8L,1L,8L,2L,5L,4L,6L,8L,7L,4L,6L,7L,5L,9L,3L,3L,3L,7L,2L,2L,1L,8L,8L,2L,7L,7L,1L,7L,2L,8L,0L,7L,2L,3L,4L,1L,2L,8L,2L,6L,1L,1L,6L,7L,4L,3L,3L,0L,0L,3L,1L,5L,1L,9L,7L,1L,8L,0L,8L,7L,5L,5L,4L,1L,5L,4L,6L,9L,6L,5L,4L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201676Inst : IEnumerable<long>
{
public static readonly long[] Value=A201676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201676.Bytes);
public long this[int i]=>Value[i];

public static A201676Inst Instance=new A201676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201677
{
public static readonly long[] Value={ 3L,1L,2L,8L,6L,5L,7L,0L,1L,3L,8L,5L,7L,7L,3L,5L,9L,2L,9L,9L,8L,3L,4L,0L,4L,0L,4L,8L,4L,4L,0L,2L,8L,6L,7L,8L,1L,6L,5L,0L,0L,8L,6L,5L,6L,6L,6L,3L,7L,0L,4L,3L,3L,7L,2L,8L,4L,3L,8L,9L,4L,3L,9L,1L,0L,7L,2L,2L,4L,4L,1L,9L,4L,4L,2L,4L,5L,7L,5L,1L,9L,4L,0L,5L,4L,9L,2L,2L,4L,4L,3L,1L,5L,6L,4L,1L,0L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201677Inst : IEnumerable<long>
{
public static readonly long[] Value=A201677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201677.Bytes);
public long this[int i]=>Value[i];

public static A201677Inst Instance=new A201677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201678
{
public static readonly long[] Value={ 5L,6L,4L,5L,9L,4L,5L,2L,3L,3L,9L,4L,6L,0L,4L,5L,6L,0L,3L,4L,5L,4L,1L,7L,0L,5L,0L,8L,7L,9L,3L,5L,2L,6L,3L,2L,1L,6L,2L,2L,5L,7L,5L,4L,9L,8L,7L,9L,6L,9L,6L,8L,8L,2L,2L,4L,7L,1L,9L,5L,3L,0L,8L,7L,5L,9L,4L,9L,2L,5L,6L,3L,9L,7L,7L,8L,6L,7L,4L,0L,3L,4L,1L,3L,0L,6L,8L,3L,8L,6L,8L,7L,2L,9L,9L,0L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201678Inst : IEnumerable<long>
{
public static readonly long[] Value=A201678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201678.Bytes);
public long this[int i]=>Value[i];

public static A201678Inst Instance=new A201678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201679
{
public static readonly long[] Value={ 3L,1L,3L,0L,1L,2L,1L,7L,4L,4L,3L,2L,7L,9L,1L,0L,3L,1L,7L,3L,8L,6L,1L,9L,3L,8L,0L,6L,4L,2L,2L,8L,0L,4L,6L,4L,6L,8L,7L,3L,8L,2L,7L,3L,1L,0L,5L,6L,8L,6L,3L,4L,8L,6L,1L,1L,4L,2L,4L,1L,0L,1L,2L,3L,8L,5L,4L,7L,6L,3L,5L,5L,9L,9L,3L,5L,9L,7L,7L,8L,2L,7L,4L,2L,0L,6L,1L,6L,3L,8L,9L,3L,5L,2L,0L,2L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201679Inst : IEnumerable<long>
{
public static readonly long[] Value=A201679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201679.Bytes);
public long this[int i]=>Value[i];

public static A201679Inst Instance=new A201679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201680
{
public static readonly long[] Value={ 5L,4L,2L,0L,6L,4L,4L,8L,2L,6L,8L,2L,1L,6L,0L,4L,8L,3L,7L,5L,5L,0L,4L,3L,1L,5L,2L,1L,6L,9L,4L,7L,6L,5L,3L,3L,5L,7L,0L,2L,8L,4L,4L,3L,5L,7L,3L,5L,4L,2L,6L,4L,7L,6L,8L,9L,4L,9L,1L,7L,4L,5L,8L,1L,3L,7L,9L,5L,8L,0L,4L,9L,3L,7L,6L,5L,5L,6L,3L,1L,9L,0L,1L,5L,3L,8L,3L,4L,5L,9L,3L,2L,1L,4L,3L,7L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201680Inst : IEnumerable<long>
{
public static readonly long[] Value=A201680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201680.Bytes);
public long this[int i]=>Value[i];

public static A201680Inst Instance=new A201680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201681
{
public static readonly long[] Value={ 3L,1L,3L,1L,2L,8L,8L,4L,6L,9L,6L,9L,3L,5L,6L,2L,4L,9L,3L,8L,0L,4L,5L,8L,5L,0L,5L,2L,0L,4L,7L,5L,3L,5L,8L,7L,7L,4L,0L,4L,4L,0L,0L,2L,4L,9L,2L,7L,1L,8L,5L,5L,6L,9L,0L,5L,3L,8L,6L,1L,2L,3L,0L,1L,6L,4L,4L,7L,2L,9L,1L,9L,2L,1L,8L,1L,3L,4L,8L,1L,9L,0L,2L,4L,9L,1L,8L,9L,9L,5L,3L,7L,0L,9L,1L,6L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201681Inst : IEnumerable<long>
{
public static readonly long[] Value=A201681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201681.Bytes);
public long this[int i]=>Value[i];

public static A201681Inst Instance=new A201681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201682
{
public static readonly long[] Value={ 1L,7L,3L,6L,0L,3L,2L,4L,0L,9L,7L,3L,9L,9L,9L,5L,0L,6L,5L,4L,1L,8L,3L,1L,1L,0L,7L,7L,4L,0L,4L,2L,8L,5L,2L,3L,1L,2L,7L,7L,2L,6L,5L,8L,9L,8L,1L,9L,9L,8L,4L,6L,3L,6L,6L,4L,4L,7L,4L,4L,7L,6L,3L,7L,1L,9L,2L,1L,9L,4L,3L,1L,8L,7L,3L,3L,2L,6L,5L,0L,3L,8L,5L,1L,7L,0L,1L,7L,2L,1L,4L,3L,4L,4L,6L,9L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201682Inst : IEnumerable<long>
{
public static readonly long[] Value=A201682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201682.Bytes);
public long this[int i]=>Value[i];

public static A201682Inst Instance=new A201682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201683
{
public static readonly long[] Value={ 2L,9L,9L,7L,9L,9L,6L,9L,2L,0L,1L,8L,1L,6L,9L,5L,2L,6L,0L,6L,6L,1L,8L,2L,3L,3L,3L,1L,2L,5L,4L,1L,2L,5L,8L,8L,7L,6L,5L,4L,9L,8L,3L,3L,6L,8L,1L,2L,0L,0L,3L,2L,4L,7L,4L,8L,8L,3L,6L,5L,9L,5L,1L,9L,3L,1L,0L,9L,4L,8L,3L,3L,2L,2L,1L,8L,8L,5L,2L,1L,7L,8L,8L,0L,8L,7L,8L,1L,3L,6L,3L,4L,0L,8L,0L,2L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201683Inst : IEnumerable<long>
{
public static readonly long[] Value=A201683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201683.Bytes);
public long this[int i]=>Value[i];

public static A201683Inst Instance=new A201683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201684
{
public static readonly long[] Value={ 1L,-1L,0L,0L,4L,34L,274L,2312L,21034L,207790L,2228892L,25890642L,324477994L,4370180744L,63007469346L,968847653702L,15834053988732L,274170226919434L,5015004366420178L,96645631069563928L,1957433140982004026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201684Inst : IEnumerable<long>
{
public static readonly long[] Value=A201684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201684.Bytes);
public long this[int i]=>Value[i];

public static A201684Inst Instance=new A201684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201685
{
public static readonly long[] Value={ 1L,2L,1L,9L,6L,2L,64L,48L,24L,6L,625L,500L,300L,120L,24L,7776L,6480L,4320L,2160L,720L,120L,117649L,100842L,72030L,41160L,17640L,5040L,720L,2097152L,1835008L,1376256L,860160L,430080L,161280L,40320L,5040L,43046721L,38263752L,29760696L,19840464L,11022480L,4898880L,1632960L,362880L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201685Inst : IEnumerable<long>
{
public static readonly long[] Value=A201685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201685.Bytes);
public long this[int i]=>Value[i];

public static A201685Inst Instance=new A201685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201686
{
public static readonly long[] Value={ -1L,-1L,0L,1L,4L,8L,18L,33L,68L,124L,250L,460L,922L,1714L,3430L,6433L,12868L,24308L,48618L,92376L,184754L,352714L,705430L,1352076L,2704154L,5200298L,10400598L,20058298L,40116598L,77558758L,155117518L,300540193L,601080388L,1166803108L,2333606218L,4537567648L,9075135298L,17672631898L,35345263798L,68923264408L,137846528818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201686Inst : IEnumerable<long>
{
public static readonly long[] Value=A201686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201686.Bytes);
public long this[int i]=>Value[i];

public static A201686Inst Instance=new A201686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201687
{
public static readonly long[] Value={ 0L,2L,2L,6L,14L,44L,134L,462L,1616L,6062L,23306L,93996L,389102L,1671158L,7360256L,33418374L,155359922L,741476492L,3617591462L,18065875422L,92087408048L,479382896030L,2543670789962L,13759520646636L,75769638724382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201687Inst : IEnumerable<long>
{
public static readonly long[] Value=A201687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201687.Bytes);
public long this[int i]=>Value[i];

public static A201687Inst Instance=new A201687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201688
{
public static readonly long[] Value={ 43L,67L,139L,307L,379L,547L,859L,1699L,1867L,3499L,3739L,4507L,5059L,5347L,6907L,10627L,11467L,18787L,29947L,32059L,32779L,39619L,49747L,57139L,58099L,66067L,72379L,73459L,78979L,80107L,96739L,97987L,109579L,120427L,134707L,151339L,157627L,187507L,218107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201688Inst : IEnumerable<long>
{
public static readonly long[] Value=A201688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201688.Bytes);
public long this[int i]=>Value[i];

public static A201688Inst Instance=new A201688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201689
{
public static readonly long[] Value={ 0L,1L,1L,4L,9L,31L,94L,337L,1185L,4540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201689Inst : IEnumerable<long>
{
public static readonly long[] Value=A201689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201689.Bytes);
public long this[int i]=>Value[i];

public static A201689Inst Instance=new A201689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201690
{
public static readonly long[] Value={ 2L,7L,35L,218L,1598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201690Inst : IEnumerable<long>
{
public static readonly long[] Value=A201690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201690.Bytes);
public long this[int i]=>Value[i];

public static A201690Inst Instance=new A201690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201691
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,58L,299L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201691Inst : IEnumerable<long>
{
public static readonly long[] Value=A201691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201691.Bytes);
public long this[int i]=>Value[i];

public static A201691Inst Instance=new A201691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201692
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,631L,4218L,32221L,276896L,2643883L,27768955L,318174363L,3949415431L,52794067318L,756137263377L,11551672922816L,187507250145806L,3222662529113641L,58464560588277289L,1116469710152742025L,BigInteger.Parse("22386721651323946628"),BigInteger.Parse("470259350616967829363") };
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
public class A201692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201692Inst Instance=new A201692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201693
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,632L,4237L,32465L,279828L,2679950L,28232972L,324470844L,4039771856L,54165468774L,778128659247L,11923645252411L,194131328012012L,3346615262190736L,60897160676005110L,1166446154857250412L,BigInteger.Parse("23459656378909613446"),BigInteger.Parse("494290181112325561351") };
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
public class A201693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201693Inst Instance=new A201693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201694
{
public static readonly long[] Value={ 3L,10L,116L,4998L,930564L,795339012L,3262897246338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201694Inst : IEnumerable<long>
{
public static readonly long[] Value=A201694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201694.Bytes);
public long this[int i]=>Value[i];

public static A201694Inst Instance=new A201694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201695
{
public static readonly long[] Value={ 3L,18L,116L,395L,989L,2068L,3838L,6541L,10455L,15894L,23208L,32783L,45041L,60440L,79474L,102673L,130603L,163866L,203100L,248979L,302213L,363548L,433766L,513685L,604159L,706078L,820368L,947991L,1089945L,1247264L,1421018L,1612313L,1822291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201695Inst : IEnumerable<long>
{
public static readonly long[] Value=A201695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201695.Bytes);
public long this[int i]=>Value[i];

public static A201695Inst Instance=new A201695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201696
{
public static readonly long[] Value={ 3L,27L,395L,4998L,35390L,167625L,607919L,1826778L,4775228L,11211034L,24167306L,48600665L,92261185L,166831642L,289389192L,484248471L,785251265L,1238574341L,1906133765L,2869671064L,4235613920L,6140811719L,8759254221L,12309889872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201696Inst : IEnumerable<long>
{
public static readonly long[] Value=A201696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201696.Bytes);
public long this[int i]=>Value[i];

public static A201696Inst Instance=new A201696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201697
{
public static readonly long[] Value={ 3L,37L,989L,35390L,930564L,14268351L,142436489L,1034563890L,5898023820L,27803725006L,112491133042L,401503571755L,1290797861479L,3798580774670L,10363168825912L,26478119492263L,63883865534377L,146539437113683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201697Inst : IEnumerable<long>
{
public static readonly long[] Value=A201697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201697.Bytes);
public long this[int i]=>Value[i];

public static A201697Inst Instance=new A201697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201698
{
public static readonly long[] Value={ 3L,48L,2068L,167625L,14268351L,795339012L,27102769900L,615440785548L,10106227864338L,127441635892627L,1290114077123683L,10846768837607450L,77797729805055016L,486398599750167133L,2697872438447793007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201698Inst : IEnumerable<long>
{
public static readonly long[] Value=A201698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201698.Bytes);
public long this[int i]=>Value[i];

public static A201698Inst Instance=new A201698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201699
{
public static readonly BigInteger[] Value={ 3L,60L,3838L,607919L,142436489L,27102769900L,3262897246338L,253484699853930L,13657827589827288L,542530203631847499L,16634470482072064655UL,BigInteger.Parse("407700696414920035296"),BigInteger.Parse("8211702473582080609860"),BigInteger.Parse("139013768818199221546289") };
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
public class A201699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201699Inst Instance=new A201699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201700
{
public static readonly long[] Value={ 3L,3L,3L,3L,10L,3L,3L,18L,18L,3L,3L,27L,116L,27L,3L,3L,37L,395L,395L,37L,3L,3L,48L,989L,4998L,989L,48L,3L,3L,60L,2068L,35390L,35390L,2068L,60L,3L,3L,73L,3838L,167625L,930564L,167625L,3838L,73L,3L,3L,87L,6541L,607919L,14268351L,14268351L,607919L,6541L,87L,3L,3L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201700Inst : IEnumerable<long>
{
public static readonly long[] Value=A201700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201700.Bytes);
public long this[int i]=>Value[i];

public static A201700Inst Instance=new A201700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201701
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,4L,3L,0L,0L,8L,8L,1L,0L,0L,16L,20L,5L,0L,0L,0L,32L,48L,18L,1L,0L,0L,0L,64L,112L,56L,7L,0L,0L,0L,0L,128L,256L,160L,32L,1L,0L,0L,0L,0L,256L,576L,432L,120L,9L,0L,0L,0L,0L,0L,512L,1280L,1120L,400L,50L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201701Inst : IEnumerable<long>
{
public static readonly long[] Value=A201701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201701.Bytes);
public long this[int i]=>Value[i];

public static A201701Inst Instance=new A201701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201702
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,5L,15L,64L,342L,2321L,18578L,168287L,1656209L,17288336L,188006362L,2105867058L,24108331027L,280638347609L,3310098377912L,39462525169310L,474697793413215L,5754095507495584L,70216415130786725L,861924378411516159L,10636562125193377459UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201702Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A201702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201702.Bytes);
public ulong this[int i]=>Value[i];

public static A201702Inst Instance=new A201702Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201703
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,2L,8L,4L,4L,2L,16L,8L,8L,5L,4L,32L,16L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201703Inst : IEnumerable<long>
{
public static readonly long[] Value=A201703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201703.Bytes);
public long this[int i]=>Value[i];

public static A201703Inst Instance=new A201703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201704
{
public static readonly long[] Value={ 7L,79L,5839L,7207L,8719L,18439L,25999L,28807L,41479L,45007L,48679L,93319L,109519L,121039L,145807L,180007L,209959L,294919L,313639L,342799L,415879L,472399L,583207L,720007L,734479L,778759L,935719L,952207L,1216807L,1331719L,1391119L,1431439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201704Inst : IEnumerable<long>
{
public static readonly long[] Value=A201704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201704.Bytes);
public long this[int i]=>Value[i];

public static A201704Inst Instance=new A201704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201705
{
public static readonly long[] Value={ 17L,41L,137L,401L,521L,809L,977L,1361L,2897L,3209L,3881L,4241L,5009L,5417L,6737L,9257L,12809L,13457L,15497L,16937L,17681L,22481L,25097L,26921L,33809L,39209L,42641L,47441L,49937L,57809L,61961L,63377L,89897L,100361L,102161L,123017L,135209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201705Inst : IEnumerable<long>
{
public static readonly long[] Value=A201705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201705.Bytes);
public long this[int i]=>Value[i];

public static A201705Inst Instance=new A201705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201706
{
public static readonly long[] Value={ 13L,229L,733L,1093L,2029L,3253L,7573L,13693L,18229L,21613L,31333L,33493L,42853L,59053L,65029L,71293L,91813L,127453L,140629L,178933L,189229L,199813L,205213L,227533L,233293L,245029L,257053L,328333L,378229L,439573L,514093L,567013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201706Inst : IEnumerable<long>
{
public static readonly long[] Value=A201706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201706.Bytes);
public long this[int i]=>Value[i];

public static A201706Inst Instance=new A201706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201707
{
public static readonly long[] Value={ 7L,43L,151L,331L,907L,1303L,2311L,3607L,4363L,6091L,13003L,14407L,17431L,19051L,20743L,26251L,34603L,36871L,46663L,51991L,66571L,72907L,79531L,90007L,108907L,129607L,133963L,156823L,161611L,166471L,171403L,219031L,224683L,311371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201707Inst : IEnumerable<long>
{
public static readonly long[] Value=A201707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201707.Bytes);
public long this[int i]=>Value[i];

public static A201707Inst Instance=new A201707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201708
{
public static readonly long[] Value={ 19L,739L,1531L,3259L,6571L,9811L,15139L,16651L,19891L,29251L,35731L,42859L,56179L,62011L,84691L,110899L,131779L,154459L,178939L,199819L,281971L,294859L,349291L,363619L,370891L,431659L,447571L,488611L,549091L,603739L,613099L,804619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201708Inst : IEnumerable<long>
{
public static readonly long[] Value=A201708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201708.Bytes);
public long this[int i]=>Value[i];

public static A201708Inst Instance=new A201708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201709
{
public static readonly long[] Value={ 11L,41L,251L,491L,641L,811L,2251L,4001L,6761L,7841L,9001L,10891L,12251L,13691L,16001L,16811L,22091L,23041L,32491L,33641L,40961L,50411L,68891L,72251L,73961L,81001L,82811L,86491L,98011L,108161L,110251L,112361L,121001L,125441L,127691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201709Inst : IEnumerable<long>
{
public static readonly long[] Value=A201709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201709.Bytes);
public long this[int i]=>Value[i];

public static A201709Inst Instance=new A201709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201710
{
public static readonly long[] Value={ 3L,13L,43L,163L,643L,1213L,1693L,3613L,4003L,6763L,9613L,10243L,12253L,13693L,18493L,21163L,22093L,27043L,30253L,44893L,49003L,72253L,82813L,96043L,100003L,102013L,112363L,114493L,141613L,153763L,156253L,169003L,179563L,196003L,228013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201710Inst : IEnumerable<long>
{
public static readonly long[] Value=A201710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201710.Bytes);
public long this[int i]=>Value[i];

public static A201710Inst Instance=new A201710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201711
{
public static readonly long[] Value={ 19L,499L,1009L,1699L,8419L,9619L,14449L,21169L,24019L,28099L,30259L,34819L,38449L,49009L,53299L,68899L,84649L,94099L,102019L,118819L,141619L,156259L,169009L,176899L,184969L,187699L,240259L,259219L,268969L,306259L,309769L,327619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201711Inst : IEnumerable<long>
{
public static readonly long[] Value=A201711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201711.Bytes);
public long this[int i]=>Value[i];

public static A201711Inst Instance=new A201711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201712
{
public static readonly long[] Value={ 5L,29L,47L,197L,239L,389L,509L,719L,797L,2309L,2447L,3359L,4229L,4799L,6047L,6269L,6959L,8447L,10079L,10949L,11549L,12479L,14447L,17669L,18047L,19997L,20399L,22469L,24197L,28319L,31247L,33797L,34319L,38639L,45599L,51197L,51839L,55109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201712Inst : IEnumerable<long>
{
public static readonly long[] Value=A201712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201712.Bytes);
public long this[int i]=>Value[i];

public static A201712Inst Instance=new A201712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201713
{
public static readonly long[] Value={ 3L,13L,67L,157L,283L,643L,877L,1453L,3037L,4603L,5197L,5827L,7933L,8707L,12163L,14107L,17293L,18427L,19597L,30253L,34843L,38083L,41467L,56443L,58477L,62653L,66973L,71437L,83227L,93307L,95917L,98563L,103963L,109507L,118093L,123997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201713Inst : IEnumerable<long>
{
public static readonly long[] Value=A201713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201713.Bytes);
public long this[int i]=>Value[i];

public static A201713Inst Instance=new A201713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201714
{
public static readonly long[] Value={ 11L,43L,193L,281L,331L,443L,571L,641L,1051L,1451L,2731L,3691L,4993L,6043L,6491L,7193L,7681L,8443L,8971L,9241L,10651L,11243L,12161L,13441L,15131L,16193L,16921L,17291L,18043L,19993L,21211L,23321L,28793L,29761L,32251L,34841L,42043L,43801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201714Inst : IEnumerable<long>
{
public static readonly long[] Value=A201714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201714.Bytes);
public long this[int i]=>Value[i];

public static A201714Inst Instance=new A201714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201715
{
public static readonly long[] Value={ 73L,241L,673L,1321L,1873L,2521L,3673L,4561L,6073L,11161L,14281L,15121L,19681L,21673L,23761L,24841L,27073L,29401L,33073L,49921L,51481L,54673L,63073L,66601L,72073L,77761L,87721L,91873L,102673L,109441L,114073L,118801L,131041L,143881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201715Inst : IEnumerable<long>
{
public static readonly long[] Value=A201715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201715.Bytes);
public long this[int i]=>Value[i];

public static A201715Inst Instance=new A201715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201716
{
public static readonly long[] Value={ 23L,71L,239L,359L,503L,863L,1319L,1583L,1871L,2879L,3671L,5039L,8423L,9743L,11159L,11903L,12671L,13463L,16871L,17783L,18719L,20663L,25943L,29399L,33071L,38303L,39671L,48383L,49919L,51479L,61343L,68399L,70223L,73943L,81671L,83663L,87719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201716Inst : IEnumerable<long>
{
public static readonly long[] Value=A201716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201716.Bytes);
public long this[int i]=>Value[i];

public static A201716Inst Instance=new A201716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201717
{
public static readonly long[] Value={ 7L,43L,103L,967L,1447L,1723L,2347L,3067L,3463L,4327L,6343L,6907L,9403L,11527L,13063L,21163L,23227L,28807L,32443L,33703L,44647L,47623L,52267L,65707L,71143L,74887L,80683L,88747L,90823L,99367L,110587L,137383L,142567L,150523L,175687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201717Inst : IEnumerable<long>
{
public static readonly long[] Value=A201717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201717.Bytes);
public long this[int i]=>Value[i];

public static A201717Inst Instance=new A201717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201718
{
public static readonly long[] Value={ 5L,41L,101L,293L,761L,1193L,1721L,2693L,3461L,3881L,4793L,5801L,8741L,12281L,16421L,17321L,26501L,32441L,36293L,40361L,53861L,62201L,67493L,80681L,86693L,90821L,92921L,101561L,108293L,112901L,119993L,127301L,145193L,167081L,178601L,193541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201718Inst : IEnumerable<long>
{
public static readonly long[] Value=A201718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201718.Bytes);
public long this[int i]=>Value[i];

public static A201718Inst Instance=new A201718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201719
{
public static readonly long[] Value={ 11L,19L,43L,59L,67L,83L,107L,139L,163L,179L,211L,251L,307L,331L,419L,443L,467L,491L,563L,571L,587L,619L,643L,811L,883L,907L,947L,971L,1019L,1091L,1123L,1171L,1259L,1291L,1307L,1427L,1531L,1571L,1579L,1667L,1699L,1747L,1787L,1811L,1907L,1979L,1987L,2003L,2011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201719Inst : IEnumerable<long>
{
public static readonly long[] Value=A201719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201719.Bytes);
public long this[int i]=>Value[i];

public static A201719Inst Instance=new A201719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201720
{
public static readonly BigInteger[] Value={ 0L,1L,3L,12L,64L,420L,3246L,28798L,288072L,3205044L,39234340L,523821936L,7572221328L,117792884872L,1961516974704L,34807390821960L,655594811020096L,13060711726818768L,274358217793164912L,6060159633360214144L,BigInteger.Parse("140404595387426964480") };
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
public class A201720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201720Inst Instance=new A201720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201721
{
public static readonly long[] Value={ 4L,90L,19827L,56836178L,1692459595971L,545947219624185244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201721Inst : IEnumerable<long>
{
public static readonly long[] Value=A201721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201721.Bytes);
public long this[int i]=>Value[i];

public static A201721Inst Instance=new A201721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201722
{
public static readonly long[] Value={ 4L,10L,20L,35L,56L,83L,116L,155L,200L,251L,308L,371L,440L,515L,596L,683L,776L,875L,980L,1091L,1208L,1331L,1460L,1595L,1736L,1883L,2036L,2195L,2360L,2531L,2708L,2891L,3080L,3275L,3476L,3683L,3896L,4115L,4340L,4571L,4808L,5051L,5300L,5555L,5816L,6083L,6356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201722Inst : IEnumerable<long>
{
public static readonly long[] Value=A201722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201722.Bytes);
public long this[int i]=>Value[i];

public static A201722Inst Instance=new A201722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201723
{
public static readonly long[] Value={ 10L,90L,631L,3567L,16493L,64018L,213013L,621757L,1626046L,3878550L,8560638L,17688966L,34541082L,64226182L,114429139L,196357695L,325924563L,525198174L,824157734L,1262790173L,1893568514L,2784353134L,4021759333L,5715036571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201723Inst : IEnumerable<long>
{
public static readonly long[] Value=A201723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201723.Bytes);
public long this[int i]=>Value[i];

public static A201723Inst Instance=new A201723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201724
{
public static readonly long[] Value={ 20L,631L,19827L,499474L,9603489L,144262866L,1757594146L,17915547783L,156619023957L,1198133817532L,8153980411514L,50035648469991L,279906963092730L,1440489290975090L,6871449852708897L,30577097006475471L,127620952939695332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201724Inst : IEnumerable<long>
{
public static readonly long[] Value=A201724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201724.Bytes);
public long this[int i]=>Value[i];

public static A201724Inst Instance=new A201724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201725
{
public static readonly BigInteger[] Value={ 35L,3567L,499474L,56836178L,4720850001L,299927801278L,15249209002599L,640855702702745L,22831719167592564L,703807755707555744L,BigInteger.Parse("19083627099219491070"),BigInteger.Parse("461269189538111185232"),BigInteger.Parse("10047567066462239739922") };
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
public class A201725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201725Inst Instance=new A201725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201726
{
public static readonly BigInteger[] Value={ 56L,16493L,9603489L,4720850001L,1692459595971L,463016032498283L,100953294298736546L,18122671914754530341UL,BigInteger.Parse("2749005920875643617934"),BigInteger.Parse("359691065136570782416660"),BigInteger.Parse("41268528292416431754552427") };
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
public class A201726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201726Inst Instance=new A201726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201727
{
public static readonly long[] Value={ 83L,64018L,144262866L,299927801278L,463016032498283L,545947219624185244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201727Inst : IEnumerable<long>
{
public static readonly long[] Value=A201727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201727.Bytes);
public long this[int i]=>Value[i];

public static A201727Inst Instance=new A201727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201728
{
public static readonly long[] Value={ 116L,213013L,1757594146L,15249209002599L,100953294298736546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201728Inst : IEnumerable<long>
{
public static readonly long[] Value=A201728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201728.Bytes);
public long this[int i]=>Value[i];

public static A201728Inst Instance=new A201728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201729
{
public static readonly long[] Value={ 4L,10L,10L,20L,90L,20L,35L,631L,631L,35L,56L,3567L,19827L,3567L,56L,83L,16493L,499474L,499474L,16493L,83L,116L,64018L,9603489L,56836178L,9603489L,64018L,116L,155L,213013L,144262866L,4720850001L,4720850001L,144262866L,213013L,155L,200L,621757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201729Inst : IEnumerable<long>
{
public static readonly long[] Value=A201729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201729.Bytes);
public long this[int i]=>Value[i];

public static A201729Inst Instance=new A201729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201730
{
public static readonly long[] Value={ 1L,2L,0L,5L,1L,0L,14L,6L,0L,0L,41L,26L,1L,0L,0L,122L,100L,10L,0L,0L,0L,365L,363L,63L,1L,0L,0L,0L,1094L,1274L,322L,14L,0L,0L,0L,0L,3281L,4372L,1462L,116L,1L,0L,0L,0L,0L,9842L,14760L,6156L,744L,18L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201730Inst : IEnumerable<long>
{
public static readonly long[] Value=A201730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201730.Bytes);
public long this[int i]=>Value[i];

public static A201730Inst Instance=new A201730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201731
{
public static readonly BigInteger[] Value={ 1L,4L,54L,1544L,75750L,5676492L,603041334L,86210654224L,15958892198070L,3713676157320020L,1061084890984465446L,BigInteger.Parse("365202873520507832856"),BigInteger.Parse("149027843082185351506950"),BigInteger.Parse("71144948740332156241755868"),BigInteger.Parse("39282974873393643411310747350"),BigInteger.Parse("24840594864924259316810487005216") };
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
public class A201731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201731Inst Instance=new A201731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201732
{
public static readonly BigInteger[] Value={ 1L,2L,18L,386L,15150L,946082L,86148762L,10776331778L,1773210244230L,371367615732002L,96462262816769586L,BigInteger.Parse("30433572793375652738"),BigInteger.Parse("11463680237091180885150"),BigInteger.Parse("5081782052880868302982562"),BigInteger.Parse("2618864991559576227420716490"),BigInteger.Parse("1552537179057766207300655437826") };
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
public class A201732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201732Inst Instance=new A201732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201733
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,5L,2L,2L,1L,5L,1L,2L,1L,14L,1L,5L,1L,5L,2L,2L,1L,15L,2L,2L,5L,4L,1L,4L,1L,51L,1L,2L,1L,14L,1L,2L,2L,14L,1L,6L,1L,4L,2L,2L,1L,52L,2L,5L,1L,5L,1L,15L,2L,13L,2L,2L,1L,12L,1L,2L,4L,267L,1L,4L,1L,5L,1L,4L,1L,50L,1L,2L,3L,4L,1L,6L,1L,52L,15L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201733Inst : IEnumerable<long>
{
public static readonly long[] Value=A201733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201733.Bytes);
public long this[int i]=>Value[i];

public static A201733Inst Instance=new A201733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201734
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,9L,10L,13L,14L,16L,18L,20L,22L,24L,25L,27L,29L,31L,32L,38L,39L,43L,44L,49L,50L,51L,53L,56L,63L,64L,65L,66L,69L,77L,80L,83L,84L,87L,90L,91L,95L,98L,101L,102L,105L,106L,107L,108L,109L,111L,116L,118L,120L,121L,122L,123L,129L,132L,134L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201734Inst : IEnumerable<long>
{
public static readonly long[] Value=A201734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201734.Bytes);
public long this[int i]=>Value[i];

public static A201734Inst Instance=new A201734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201735
{
public static readonly long[] Value={ 2L,0L,2L,8L,4L,7L,9L,6L,1L,0L,6L,8L,5L,8L,1L,5L,7L,3L,6L,5L,9L,5L,8L,3L,9L,4L,0L,5L,8L,4L,0L,7L,4L,1L,9L,6L,0L,3L,3L,0L,1L,0L,6L,7L,3L,2L,3L,1L,8L,4L,9L,2L,2L,9L,6L,3L,9L,7L,0L,7L,7L,8L,1L,6L,0L,4L,3L,2L,4L,8L,1L,1L,9L,1L,7L,0L,0L,5L,7L,5L,3L,8L,3L,2L,3L,7L,7L,0L,4L,8L,3L,3L,3L,7L,3L,3L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201735Inst : IEnumerable<long>
{
public static readonly long[] Value=A201735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201735.Bytes);
public long this[int i]=>Value[i];

public static A201735Inst Instance=new A201735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201736
{
public static readonly long[] Value={ 2L,9L,6L,8L,7L,1L,1L,9L,8L,1L,1L,6L,1L,4L,1L,2L,4L,4L,6L,7L,5L,5L,4L,0L,4L,3L,9L,2L,7L,2L,3L,9L,4L,3L,5L,0L,6L,7L,7L,5L,0L,7L,0L,0L,7L,7L,8L,9L,2L,3L,2L,6L,2L,9L,2L,3L,9L,0L,3L,1L,2L,1L,2L,3L,6L,6L,6L,1L,0L,5L,9L,8L,6L,6L,3L,4L,1L,4L,8L,9L,1L,2L,6L,0L,8L,0L,6L,5L,8L,5L,6L,2L,5L,1L,6L,6L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201736Inst : IEnumerable<long>
{
public static readonly long[] Value=A201736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201736.Bytes);
public long this[int i]=>Value[i];

public static A201736Inst Instance=new A201736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201737
{
public static readonly long[] Value={ 2L,3L,1L,5L,0L,4L,6L,9L,3L,3L,6L,1L,7L,3L,7L,4L,8L,1L,7L,6L,7L,1L,5L,7L,6L,2L,6L,2L,7L,1L,9L,1L,9L,4L,3L,5L,0L,8L,0L,8L,1L,6L,2L,2L,4L,1L,0L,9L,8L,6L,8L,7L,3L,2L,8L,6L,1L,0L,7L,3L,8L,5L,8L,9L,6L,0L,4L,4L,1L,8L,1L,1L,4L,9L,2L,2L,8L,2L,2L,3L,1L,2L,8L,4L,3L,4L,1L,5L,6L,7L,9L,7L,4L,2L,5L,3L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201737Inst : IEnumerable<long>
{
public static readonly long[] Value=A201737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201737.Bytes);
public long this[int i]=>Value[i];

public static A201737Inst Instance=new A201737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201738
{
public static readonly long[] Value={ 2L,9L,1L,8L,3L,4L,3L,6L,9L,9L,0L,1L,8L,2L,0L,1L,3L,8L,7L,6L,5L,9L,8L,3L,6L,9L,9L,2L,0L,7L,6L,0L,5L,8L,7L,6L,7L,2L,1L,0L,5L,9L,1L,6L,3L,5L,4L,8L,7L,2L,2L,2L,8L,8L,1L,3L,4L,7L,2L,0L,4L,0L,6L,7L,8L,4L,2L,0L,1L,0L,6L,9L,8L,9L,3L,9L,1L,9L,7L,2L,7L,1L,2L,6L,0L,3L,0L,2L,6L,3L,1L,7L,2L,7L,7L,6L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201738Inst : IEnumerable<long>
{
public static readonly long[] Value=A201738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201738.Bytes);
public long this[int i]=>Value[i];

public static A201738Inst Instance=new A201738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201739
{
public static readonly long[] Value={ 0L,4L,5L,6L,7L,9L,10L,11L,12L,14L,17L,23L,27L,28L,30L,31L,32L,33L,34L,37L,38L,39L,41L,44L,45L,47L,48L,53L,54L,61L,65L,70L,73L,74L,75L,76L,77L,80L,83L,84L,88L,89L,91L,96L,98L,100L,102L,105L,108L,109L,110L,114L,117L,119L,125L,126L,128L,132L,136L,139L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201739Inst : IEnumerable<long>
{
public static readonly long[] Value=A201739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201739.Bytes);
public long this[int i]=>Value[i];

public static A201739Inst Instance=new A201739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201740
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,4L,39L,-158L,211L,-186L,-33722L,55130L,192039L,-4032991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201740Inst : IEnumerable<long>
{
public static readonly long[] Value=A201740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201740.Bytes);
public long this[int i]=>Value[i];

public static A201740Inst Instance=new A201740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201741
{
public static readonly long[] Value={ 1L,3L,1L,9L,0L,7L,3L,6L,7L,6L,8L,5L,7L,3L,6L,5L,3L,5L,4L,4L,1L,7L,8L,9L,9L,1L,0L,9L,5L,2L,0L,8L,4L,8L,4L,6L,4L,4L,2L,1L,9L,6L,6L,7L,8L,0L,8L,2L,5L,4L,9L,7L,6L,6L,9L,2L,5L,6L,0L,8L,9L,0L,0L,4L,9L,0L,5L,1L,2L,7L,0L,7L,6L,3L,4L,6L,1L,0L,7L,3L,1L,6L,7L,2L,5L,1L,0L,4L,0L,6L,3L,8L,4L,4L,9L,4L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201741Inst : IEnumerable<long>
{
public static readonly long[] Value=A201741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201741.Bytes);
public long this[int i]=>Value[i];

public static A201741Inst Instance=new A201741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201742
{
public static readonly long[] Value={ 1L,8L,7L,3L,1L,2L,2L,5L,4L,7L,7L,1L,3L,0L,4L,3L,3L,2L,1L,7L,2L,0L,5L,9L,7L,0L,9L,6L,7L,5L,4L,2L,5L,7L,1L,0L,4L,0L,8L,3L,5L,2L,7L,4L,0L,2L,6L,5L,0L,3L,9L,2L,5L,1L,4L,2L,8L,0L,1L,7L,1L,8L,7L,2L,9L,4L,1L,3L,2L,0L,4L,2L,4L,5L,8L,0L,2L,0L,6L,1L,7L,4L,9L,3L,7L,4L,7L,9L,3L,8L,4L,6L,4L,8L,1L,6L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201742Inst : IEnumerable<long>
{
public static readonly long[] Value=A201742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201742.Bytes);
public long this[int i]=>Value[i];

public static A201742Inst Instance=new A201742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201743
{
public static readonly long[] Value={ 2L,1L,5L,8L,7L,2L,6L,0L,6L,4L,4L,8L,1L,2L,2L,4L,6L,2L,4L,1L,4L,0L,2L,4L,0L,7L,5L,4L,8L,1L,3L,8L,5L,6L,7L,1L,7L,7L,5L,5L,9L,0L,7L,4L,1L,5L,7L,7L,7L,6L,7L,1L,4L,4L,8L,1L,8L,8L,9L,1L,8L,6L,8L,7L,0L,6L,0L,8L,7L,1L,9L,1L,2L,4L,9L,3L,2L,1L,3L,0L,0L,3L,1L,3L,3L,2L,4L,6L,9L,2L,4L,2L,5L,8L,6L,0L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201743Inst : IEnumerable<long>
{
public static readonly long[] Value=A201743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201743.Bytes);
public long this[int i]=>Value[i];

public static A201743Inst Instance=new A201743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201744
{
public static readonly long[] Value={ 2L,3L,5L,6L,3L,5L,3L,4L,8L,9L,8L,5L,7L,1L,5L,4L,3L,6L,2L,4L,2L,0L,2L,5L,9L,2L,3L,5L,5L,6L,8L,1L,4L,8L,9L,7L,8L,8L,6L,9L,7L,2L,1L,5L,1L,5L,0L,5L,4L,4L,6L,8L,0L,3L,2L,0L,4L,3L,9L,2L,1L,8L,0L,9L,8L,8L,5L,9L,0L,3L,0L,8L,9L,3L,8L,9L,9L,3L,6L,5L,5L,6L,4L,7L,4L,2L,0L,7L,3L,8L,1L,7L,4L,2L,8L,0L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201744Inst : IEnumerable<long>
{
public static readonly long[] Value=A201744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201744.Bytes);
public long this[int i]=>Value[i];

public static A201744Inst Instance=new A201744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201745
{
public static readonly long[] Value={ 2L,5L,0L,9L,3L,3L,6L,6L,6L,8L,0L,2L,5L,0L,3L,6L,3L,2L,4L,5L,4L,6L,4L,1L,0L,2L,6L,7L,8L,6L,9L,8L,5L,2L,7L,3L,8L,4L,2L,0L,3L,6L,9L,5L,7L,9L,0L,3L,4L,4L,0L,4L,1L,3L,1L,6L,9L,8L,7L,7L,3L,5L,6L,7L,0L,7L,5L,2L,2L,2L,6L,1L,2L,1L,0L,4L,6L,8L,3L,5L,9L,8L,7L,1L,6L,4L,2L,8L,2L,2L,0L,1L,6L,2L,8L,6L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201745Inst : IEnumerable<long>
{
public static readonly long[] Value=A201745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201745.Bytes);
public long this[int i]=>Value[i];

public static A201745Inst Instance=new A201745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201746
{
public static readonly long[] Value={ 2L,6L,3L,4L,9L,8L,9L,9L,1L,5L,7L,5L,9L,3L,4L,7L,9L,1L,8L,3L,9L,4L,7L,4L,7L,7L,4L,3L,7L,3L,8L,5L,9L,6L,5L,4L,3L,7L,3L,6L,2L,5L,4L,5L,6L,0L,2L,7L,0L,1L,4L,0L,7L,8L,9L,1L,4L,4L,9L,4L,6L,0L,8L,3L,4L,5L,9L,3L,3L,4L,7L,6L,4L,5L,6L,3L,8L,5L,6L,6L,9L,2L,3L,6L,4L,4L,5L,1L,8L,3L,4L,9L,0L,4L,9L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201746Inst : IEnumerable<long>
{
public static readonly long[] Value=A201746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201746.Bytes);
public long this[int i]=>Value[i];

public static A201746Inst Instance=new A201746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201747
{
public static readonly long[] Value={ 2L,7L,4L,2L,0L,5L,7L,1L,9L,7L,2L,5L,8L,6L,5L,1L,5L,9L,5L,5L,1L,9L,1L,6L,7L,3L,7L,8L,7L,9L,0L,0L,2L,3L,5L,8L,5L,1L,6L,8L,0L,2L,5L,4L,9L,1L,4L,3L,6L,1L,4L,1L,9L,6L,5L,8L,3L,5L,0L,3L,4L,4L,2L,5L,5L,8L,2L,5L,1L,3L,3L,8L,6L,4L,2L,9L,5L,0L,1L,5L,2L,3L,3L,6L,2L,7L,0L,1L,5L,3L,4L,1L,5L,0L,7L,2L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201747Inst : IEnumerable<long>
{
public static readonly long[] Value=A201747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201747.Bytes);
public long this[int i]=>Value[i];

public static A201747Inst Instance=new A201747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201748
{
public static readonly long[] Value={ 2L,8L,3L,5L,6L,0L,0L,5L,0L,6L,0L,3L,5L,9L,7L,9L,9L,6L,7L,6L,2L,5L,3L,5L,9L,1L,9L,5L,8L,7L,6L,2L,7L,1L,6L,0L,8L,5L,3L,2L,8L,0L,8L,5L,4L,2L,5L,0L,4L,3L,9L,0L,4L,1L,0L,9L,0L,6L,1L,5L,4L,4L,8L,1L,6L,2L,3L,9L,8L,9L,1L,1L,3L,9L,8L,7L,6L,5L,2L,0L,1L,1L,0L,3L,6L,0L,4L,1L,9L,6L,7L,3L,2L,8L,2L,2L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201748Inst : IEnumerable<long>
{
public static readonly long[] Value=A201748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201748.Bytes);
public long this[int i]=>Value[i];

public static A201748Inst Instance=new A201748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201749
{
public static readonly long[] Value={ 2L,9L,1L,8L,8L,2L,6L,9L,8L,2L,3L,0L,6L,3L,4L,5L,3L,4L,3L,6L,5L,1L,7L,4L,6L,4L,8L,0L,5L,4L,0L,9L,7L,6L,2L,4L,9L,9L,4L,9L,0L,9L,4L,7L,6L,8L,1L,0L,7L,5L,4L,5L,8L,9L,8L,0L,6L,0L,7L,0L,7L,6L,5L,2L,1L,3L,8L,3L,0L,5L,8L,3L,0L,4L,9L,6L,7L,5L,8L,6L,5L,8L,2L,8L,3L,3L,0L,5L,7L,0L,1L,9L,6L,1L,1L,6L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201749Inst : IEnumerable<long>
{
public static readonly long[] Value=A201749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201749.Bytes);
public long this[int i]=>Value[i];

public static A201749Inst Instance=new A201749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201750
{
public static readonly long[] Value={ 7L,1L,4L,5L,5L,6L,3L,8L,4L,7L,4L,3L,0L,0L,9L,6L,8L,1L,6L,0L,1L,4L,4L,9L,1L,2L,6L,4L,3L,4L,3L,6L,2L,8L,8L,7L,5L,9L,6L,4L,9L,7L,9L,3L,8L,6L,6L,3L,8L,3L,0L,8L,2L,6L,9L,5L,5L,9L,1L,7L,6L,9L,5L,3L,2L,2L,4L,5L,9L,4L,5L,5L,2L,9L,0L,1L,6L,8L,9L,7L,1L,8L,1L,2L,6L,3L,6L,6L,2L,2L,7L,8L,6L,3L,9L,1L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201750Inst : IEnumerable<long>
{
public static readonly long[] Value=A201750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201750.Bytes);
public long this[int i]=>Value[i];

public static A201750Inst Instance=new A201750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201751
{
public static readonly long[] Value={ 1L,3L,1L,5L,9L,7L,3L,7L,7L,7L,7L,9L,6L,2L,9L,0L,1L,8L,7L,8L,8L,7L,1L,7L,7L,3L,8L,7L,3L,0L,1L,2L,7L,1L,0L,4L,8L,0L,1L,8L,9L,3L,7L,8L,5L,6L,0L,5L,1L,1L,5L,2L,5L,1L,3L,8L,4L,8L,7L,8L,1L,5L,9L,7L,3L,3L,6L,8L,8L,0L,0L,4L,3L,3L,5L,4L,6L,2L,5L,1L,1L,2L,1L,4L,4L,0L,1L,5L,4L,4L,0L,8L,3L,8L,5L,5L,4L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201751Inst : IEnumerable<long>
{
public static readonly long[] Value=A201751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201751.Bytes);
public long this[int i]=>Value[i];

public static A201751Inst Instance=new A201751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201752
{
public static readonly long[] Value={ 5L,3L,7L,2L,7L,4L,4L,4L,9L,1L,7L,3L,8L,5L,6L,6L,0L,4L,2L,5L,6L,7L,6L,2L,9L,8L,9L,7L,7L,9L,6L,7L,5L,3L,8L,1L,4L,2L,7L,5L,2L,4L,0L,1L,4L,0L,0L,0L,1L,0L,4L,1L,0L,7L,7L,7L,6L,6L,8L,1L,9L,9L,6L,5L,4L,7L,3L,3L,7L,7L,3L,2L,7L,5L,1L,1L,3L,7L,7L,2L,9L,9L,1L,5L,2L,4L,7L,5L,6L,9L,1L,5L,5L,4L,3L,6L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201752Inst : IEnumerable<long>
{
public static readonly long[] Value=A201752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201752.Bytes);
public long this[int i]=>Value[i];

public static A201752Inst Instance=new A201752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201753
{
public static readonly long[] Value={ 1L,6L,7L,7L,2L,3L,2L,7L,0L,8L,5L,3L,2L,5L,3L,7L,9L,9L,8L,8L,9L,2L,7L,0L,1L,0L,1L,1L,7L,7L,9L,4L,2L,1L,7L,6L,9L,4L,5L,1L,2L,8L,9L,8L,5L,8L,1L,4L,2L,5L,6L,2L,3L,3L,9L,0L,2L,0L,0L,5L,9L,7L,0L,7L,0L,3L,6L,6L,6L,4L,7L,9L,1L,7L,1L,8L,0L,7L,4L,4L,3L,2L,0L,2L,8L,0L,5L,2L,2L,3L,4L,1L,2L,6L,7L,0L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201753Inst : IEnumerable<long>
{
public static readonly long[] Value=A201753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201753.Bytes);
public long this[int i]=>Value[i];

public static A201753Inst Instance=new A201753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201754
{
public static readonly long[] Value={ 8L,3L,4L,4L,8L,6L,8L,6L,5L,3L,0L,8L,7L,5L,8L,7L,8L,6L,0L,9L,1L,1L,0L,1L,6L,8L,0L,1L,2L,7L,3L,3L,7L,7L,8L,9L,8L,3L,5L,7L,0L,3L,0L,3L,8L,0L,7L,9L,9L,2L,5L,9L,1L,2L,5L,9L,7L,5L,0L,6L,4L,1L,0L,8L,7L,8L,7L,0L,4L,2L,2L,0L,8L,0L,0L,5L,2L,3L,6L,6L,5L,4L,6L,8L,2L,1L,0L,9L,5L,1L,3L,5L,6L,5L,6L,3L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201754Inst : IEnumerable<long>
{
public static readonly long[] Value=A201754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201754.Bytes);
public long this[int i]=>Value[i];

public static A201754Inst Instance=new A201754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201755
{
public static readonly long[] Value={ 1L,9L,6L,4L,6L,3L,5L,5L,9L,7L,4L,8L,8L,8L,6L,4L,5L,0L,7L,6L,2L,2L,6L,5L,9L,6L,9L,2L,1L,1L,0L,9L,7L,7L,5L,8L,8L,3L,7L,5L,3L,0L,7L,5L,0L,6L,3L,7L,9L,4L,2L,2L,8L,1L,1L,5L,2L,1L,9L,7L,9L,5L,8L,3L,2L,3L,5L,7L,0L,1L,6L,4L,3L,2L,2L,0L,8L,8L,1L,3L,2L,7L,7L,9L,0L,4L,8L,2L,1L,7L,3L,5L,1L,7L,0L,4L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201755Inst : IEnumerable<long>
{
public static readonly long[] Value=A201755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201755.Bytes);
public long this[int i]=>Value[i];

public static A201755Inst Instance=new A201755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201756
{
public static readonly long[] Value={ 1L,0L,5L,8L,0L,0L,6L,4L,0L,1L,0L,9L,0L,6L,3L,6L,3L,0L,8L,6L,2L,1L,3L,8L,7L,4L,4L,6L,1L,2L,3L,1L,6L,1L,3L,5L,1L,4L,3L,2L,6L,8L,2L,8L,8L,6L,3L,5L,8L,9L,4L,8L,6L,6L,0L,5L,4L,4L,5L,9L,4L,4L,3L,0L,2L,2L,7L,5L,3L,2L,7L,6L,6L,3L,5L,8L,3L,0L,9L,3L,6L,6L,4L,1L,6L,0L,6L,8L,5L,0L,9L,8L,0L,5L,5L,8L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201756Inst : IEnumerable<long>
{
public static readonly long[] Value=A201756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201756.Bytes);
public long this[int i]=>Value[i];

public static A201756Inst Instance=new A201756Inst();

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