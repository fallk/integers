using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021788
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021788Inst : IEnumerable<long>
{
public static readonly long[] Value=A021788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021788.Bytes);
public long this[int i]=>Value[i];

public static A021788Inst Instance=new A021788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021805
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,8L,4L,3L,9L,4L,5L,0L,6L,8L,6L,6L,4L,1L,6L,9L,7L,8L,7L,7L,6L,5L,2L,9L,3L,3L,8L,3L,2L,7L,0L,9L,1L,1L,3L,6L,0L,7L,9L,9L,0L,0L,1L,2L,4L,8L,4L,3L,9L,4L,5L,0L,6L,8L,6L,6L,4L,1L,6L,9L,7L,8L,7L,7L,6L,5L,2L,9L,3L,3L,8L,3L,2L,7L,0L,9L,1L,1L,3L,6L,0L,7L,9L,9L,0L,0L,1L,2L,4L,8L,4L,3L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021805Inst : IEnumerable<long>
{
public static readonly long[] Value=A021805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021805.Bytes);
public long this[int i]=>Value[i];

public static A021805Inst Instance=new A021805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021806
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,8L,8L,2L,7L,9L,3L,0L,1L,7L,4L,5L,6L,3L,5L,9L,1L,0L,2L,2L,4L,4L,3L,8L,9L,0L,2L,7L,4L,3L,1L,4L,2L,1L,4L,4L,6L,3L,8L,4L,0L,3L,9L,9L,0L,0L,2L,4L,9L,3L,7L,6L,5L,5L,8L,6L,0L,3L,4L,9L,1L,2L,7L,1L,8L,2L,0L,4L,4L,8L,8L,7L,7L,8L,0L,5L,4L,8L,6L,2L,8L,4L,2L,8L,9L,2L,7L,6L,8L,0L,7L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021806Inst : IEnumerable<long>
{
public static readonly long[] Value=A021806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021806.Bytes);
public long this[int i]=>Value[i];

public static A021806Inst Instance=new A021806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021807
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021807Inst : IEnumerable<long>
{
public static readonly long[] Value=A021807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021807.Bytes);
public long this[int i]=>Value[i];

public static A021807Inst Instance=new A021807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021808
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021808Inst : IEnumerable<long>
{
public static readonly long[] Value=A021808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021808.Bytes);
public long this[int i]=>Value[i];

public static A021808Inst Instance=new A021808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021809
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L,1L,9L,8L,7L,5L,7L,7L,6L,3L,9L,7L,5L,1L,5L,5L,2L,7L,9L,5L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021809Inst : IEnumerable<long>
{
public static readonly long[] Value=A021809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021809.Bytes);
public long this[int i]=>Value[i];

public static A021809Inst Instance=new A021809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021810
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,0L,6L,9L,4L,7L,8L,9L,0L,8L,1L,8L,8L,5L,8L,5L,6L,0L,7L,9L,4L,0L,4L,4L,6L,6L,5L,0L,1L,2L,4L,0L,6L,9L,4L,7L,8L,9L,0L,8L,1L,8L,8L,5L,8L,5L,6L,0L,7L,9L,4L,0L,4L,4L,6L,6L,5L,0L,1L,2L,4L,0L,6L,9L,4L,7L,8L,9L,0L,8L,1L,8L,8L,5L,8L,5L,6L,0L,7L,9L,4L,0L,4L,4L,6L,6L,5L,0L,1L,2L,4L,0L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021810Inst : IEnumerable<long>
{
public static readonly long[] Value=A021810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021810.Bytes);
public long this[int i]=>Value[i];

public static A021810Inst Instance=new A021810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021811
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,9L,1L,5L,7L,3L,7L,2L,9L,8L,6L,3L,6L,9L,2L,6L,8L,8L,9L,7L,1L,4L,9L,9L,3L,8L,0L,4L,2L,1L,3L,1L,3L,5L,0L,6L,8L,1L,5L,3L,6L,5L,5L,5L,1L,4L,2L,5L,0L,3L,0L,9L,7L,8L,9L,3L,4L,3L,2L,4L,6L,5L,9L,2L,3L,1L,7L,2L,2L,4L,2L,8L,7L,4L,8L,4L,5L,1L,0L,5L,3L,2L,8L,3L,7L,6L,7L,0L,3L,8L,4L,1L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021811Inst : IEnumerable<long>
{
public static readonly long[] Value=A021811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021811.Bytes);
public long this[int i]=>Value[i];

public static A021811Inst Instance=new A021811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021812
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021812Inst : IEnumerable<long>
{
public static readonly long[] Value=A021812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021812.Bytes);
public long this[int i]=>Value[i];

public static A021812Inst Instance=new A021812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021813
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,6L,0L,9L,3L,9L,4L,3L,1L,3L,9L,6L,7L,8L,6L,1L,5L,5L,7L,4L,7L,8L,3L,6L,8L,3L,5L,5L,9L,9L,5L,0L,5L,5L,6L,2L,4L,2L,2L,7L,4L,4L,1L,2L,8L,5L,5L,3L,7L,7L,0L,0L,8L,6L,5L,2L,6L,5L,7L,6L,0L,1L,9L,7L,7L,7L,5L,0L,3L,0L,9L,0L,2L,3L,4L,8L,5L,7L,8L,4L,9L,1L,9L,6L,5L,3L,8L,9L,3L,6L,9L,5L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021813Inst : IEnumerable<long>
{
public static readonly long[] Value=A021813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021813.Bytes);
public long this[int i]=>Value[i];

public static A021813Inst Instance=new A021813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021814
{
public static readonly long[] Value={ 1L,19L,239L,2519L,24135L,218343L,1903783L,16194343L,135426599L,1118993447L,9166829607L,74629521447L,604827848743L,4885462331431L,39365093814311L,316610553147431L,2543028967600167L,20405121901817895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021814Inst : IEnumerable<long>
{
public static readonly long[] Value=A021814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021814.Bytes);
public long this[int i]=>Value[i];

public static A021814Inst Instance=new A021814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021815
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,0L,4L,5L,6L,2L,2L,6L,8L,8L,0L,3L,9L,4L,5L,7L,4L,5L,9L,9L,2L,6L,0L,1L,7L,2L,6L,2L,6L,3L,8L,7L,1L,7L,6L,3L,2L,5L,5L,2L,4L,0L,4L,4L,3L,8L,9L,6L,4L,2L,4L,1L,6L,7L,6L,9L,4L,2L,0L,4L,6L,8L,5L,5L,7L,3L,3L,6L,6L,2L,1L,4L,5L,4L,9L,9L,3L,8L,3L,4L,7L,7L,1L,8L,8L,6L,5L,5L,9L,8L,0L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021815Inst : IEnumerable<long>
{
public static readonly long[] Value=A021815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021815.Bytes);
public long this[int i]=>Value[i];

public static A021815Inst Instance=new A021815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021816
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,1L,5L,2L,7L,0L,9L,3L,5L,9L,6L,0L,5L,9L,1L,1L,3L,3L,0L,0L,4L,9L,2L,6L,1L,0L,8L,3L,7L,4L,3L,8L,4L,2L,3L,6L,4L,5L,3L,2L,0L,1L,9L,7L,0L,4L,4L,3L,3L,4L,9L,7L,5L,3L,6L,9L,4L,5L,8L,1L,2L,8L,0L,7L,8L,8L,1L,7L,7L,3L,3L,9L,9L,0L,1L,4L,7L,7L,8L,3L,2L,5L,1L,2L,3L,1L,5L,2L,7L,0L,9L,3L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021816Inst : IEnumerable<long>
{
public static readonly long[] Value=A021816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021816.Bytes);
public long this[int i]=>Value[i];

public static A021816Inst Instance=new A021816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021817
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021817Inst : IEnumerable<long>
{
public static readonly long[] Value=A021817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021817.Bytes);
public long this[int i]=>Value[i];

public static A021817Inst Instance=new A021817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021818
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021818Inst : IEnumerable<long>
{
public static readonly long[] Value=A021818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021818.Bytes);
public long this[int i]=>Value[i];

public static A021818Inst Instance=new A021818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021819
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,6L,9L,9L,3L,8L,6L,5L,0L,3L,0L,6L,7L,4L,8L,4L,6L,6L,2L,5L,7L,6L,6L,8L,7L,1L,1L,6L,5L,6L,4L,4L,1L,7L,1L,7L,7L,9L,1L,4L,1L,1L,0L,4L,2L,9L,4L,4L,7L,8L,5L,2L,7L,6L,0L,7L,3L,6L,1L,9L,6L,3L,1L,9L,0L,1L,8L,4L,0L,4L,9L,0L,7L,9L,7L,5L,4L,6L,0L,1L,2L,2L,6L,9L,9L,3L,8L,6L,5L,0L,3L,0L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021819Inst : IEnumerable<long>
{
public static readonly long[] Value=A021819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021819.Bytes);
public long this[int i]=>Value[i];

public static A021819Inst Instance=new A021819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021820
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021820Inst : IEnumerable<long>
{
public static readonly long[] Value=A021820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021820.Bytes);
public long this[int i]=>Value[i];

public static A021820Inst Instance=new A021820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021885
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,5L,0L,7L,3L,7L,7L,9L,7L,9L,5L,6L,8L,6L,7L,1L,9L,6L,3L,6L,7L,7L,6L,3L,9L,0L,4L,6L,5L,3L,8L,0L,2L,4L,9L,7L,1L,6L,2L,3L,1L,5L,5L,5L,0L,5L,1L,0L,7L,8L,3L,2L,0L,0L,9L,0L,8L,0L,5L,9L,0L,2L,3L,8L,3L,6L,5L,4L,9L,3L,7L,5L,7L,0L,9L,4L,2L,1L,1L,1L,2L,3L,7L,2L,3L,0L,4L,1L,9L,9L,7L,7L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021885Inst : IEnumerable<long>
{
public static readonly long[] Value=A021885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021885.Bytes);
public long this[int i]=>Value[i];

public static A021885Inst Instance=new A021885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021886
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,7L,8L,6L,8L,4L,8L,0L,7L,2L,5L,6L,2L,3L,5L,8L,2L,7L,6L,6L,4L,3L,9L,9L,0L,9L,2L,9L,7L,0L,5L,2L,1L,5L,4L,1L,9L,5L,0L,1L,1L,3L,3L,7L,8L,6L,8L,4L,8L,0L,7L,2L,5L,6L,2L,3L,5L,8L,2L,7L,6L,6L,4L,3L,9L,9L,0L,9L,2L,9L,7L,0L,5L,2L,1L,5L,4L,1L,9L,5L,0L,1L,1L,3L,3L,7L,8L,6L,8L,4L,8L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021886Inst : IEnumerable<long>
{
public static readonly long[] Value=A021886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021886.Bytes);
public long this[int i]=>Value[i];

public static A021886Inst Instance=new A021886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021887
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,5L,0L,2L,8L,3L,1L,2L,5L,7L,0L,7L,8L,1L,4L,2L,6L,9L,5L,3L,5L,6L,7L,3L,8L,3L,9L,1L,8L,4L,5L,9L,7L,9L,6L,1L,4L,9L,4L,9L,0L,3L,7L,3L,7L,2L,5L,9L,3L,4L,3L,1L,4L,8L,3L,5L,7L,8L,7L,0L,8L,9L,4L,6L,7L,7L,2L,3L,6L,6L,9L,3L,0L,9L,1L,7L,3L,2L,7L,2L,9L,3L,3L,1L,8L,2L,3L,3L,2L,9L,5L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021887Inst : IEnumerable<long>
{
public static readonly long[] Value=A021887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021887.Bytes);
public long this[int i]=>Value[i];

public static A021887Inst Instance=new A021887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021888
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,1L,2L,2L,1L,7L,1L,9L,4L,5L,7L,0L,1L,3L,5L,7L,4L,6L,6L,0L,6L,3L,3L,4L,8L,4L,1L,6L,2L,8L,9L,5L,9L,2L,7L,6L,0L,1L,8L,0L,9L,9L,5L,4L,7L,5L,1L,1L,3L,1L,2L,2L,1L,7L,1L,9L,4L,5L,7L,0L,1L,3L,5L,7L,4L,6L,6L,0L,6L,3L,3L,4L,8L,4L,1L,6L,2L,8L,9L,5L,9L,2L,7L,6L,0L,1L,8L,0L,9L,9L,5L,4L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021888Inst : IEnumerable<long>
{
public static readonly long[] Value=A021888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021888.Bytes);
public long this[int i]=>Value[i];

public static A021888Inst Instance=new A021888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021889
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,9L,9L,4L,3L,5L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L,8L,4L,1L,8L,0L,7L,9L,0L,9L,6L,0L,4L,5L,1L,9L,7L,7L,4L,0L,1L,1L,2L,9L,9L,4L,3L,5L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021889Inst : IEnumerable<long>
{
public static readonly long[] Value=A021889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021889.Bytes);
public long this[int i]=>Value[i];

public static A021889Inst Instance=new A021889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021890
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,8L,6L,6L,8L,1L,7L,1L,5L,5L,7L,5L,6L,2L,0L,7L,6L,7L,4L,9L,4L,3L,5L,6L,6L,5L,9L,1L,4L,2L,2L,1L,2L,1L,8L,9L,6L,1L,6L,2L,5L,2L,8L,2L,1L,6L,7L,0L,4L,2L,8L,8L,9L,3L,9L,0L,5L,1L,9L,1L,8L,7L,3L,5L,8L,9L,1L,6L,4L,7L,8L,5L,5L,5L,3L,0L,4L,7L,4L,0L,4L,0L,6L,3L,2L,0L,5L,4L,1L,7L,6L,0L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021890Inst : IEnumerable<long>
{
public static readonly long[] Value=A021890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021890.Bytes);
public long this[int i]=>Value[i];

public static A021890Inst Instance=new A021890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021891
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,7L,3L,9L,5L,7L,1L,5L,8L,9L,6L,2L,7L,9L,5L,9L,4L,1L,3L,7L,5L,4L,2L,2L,7L,7L,3L,3L,9L,3L,4L,6L,1L,1L,0L,4L,8L,4L,7L,8L,0L,1L,5L,7L,8L,3L,5L,4L,0L,0L,2L,2L,5L,4L,7L,9L,1L,4L,3L,1L,7L,9L,2L,5L,5L,9L,1L,8L,8L,2L,7L,5L,0L,8L,4L,5L,5L,4L,6L,7L,8L,6L,9L,2L,2L,2L,0L,9L,6L,9L,5L,6L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021891Inst : IEnumerable<long>
{
public static readonly long[] Value=A021891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021891.Bytes);
public long this[int i]=>Value[i];

public static A021891Inst Instance=new A021891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021892
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021892Inst : IEnumerable<long>
{
public static readonly long[] Value=A021892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021892.Bytes);
public long this[int i]=>Value[i];

public static A021892Inst Instance=new A021892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021893
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,8L,5L,9L,3L,9L,2L,5L,7L,5L,9L,2L,8L,0L,0L,8L,9L,9L,8L,8L,7L,5L,1L,4L,0L,6L,0L,7L,4L,2L,4L,0L,7L,1L,9L,9L,1L,0L,0L,1L,1L,2L,4L,8L,5L,9L,3L,9L,2L,5L,7L,5L,9L,2L,8L,0L,0L,8L,9L,9L,8L,8L,7L,5L,1L,4L,0L,6L,0L,7L,4L,2L,4L,0L,7L,1L,9L,9L,1L,0L,0L,1L,1L,2L,4L,8L,5L,9L,3L,9L,2L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021893Inst : IEnumerable<long>
{
public static readonly long[] Value=A021893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021893.Bytes);
public long this[int i]=>Value[i];

public static A021893Inst Instance=new A021893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021894
{
public static readonly long[] Value={ 1L,24L,393L,5536L,72513L,914088L,11282041L,137597232L,1666743345L,20110305592L,242090763369L,2910464426688L,34963222353697L,419822302356936L,5039713424985177L,60489483108391504L,725964257087306769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021894Inst : IEnumerable<long>
{
public static readonly long[] Value=A021894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021894.Bytes);
public long this[int i]=>Value[i];

public static A021894Inst Instance=new A021894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021895
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021895Inst : IEnumerable<long>
{
public static readonly long[] Value=A021895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021895.Bytes);
public long this[int i]=>Value[i];

public static A021895Inst Instance=new A021895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021896
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,0L,7L,6L,2L,3L,3L,1L,8L,3L,8L,5L,6L,5L,0L,2L,2L,4L,2L,1L,5L,2L,4L,6L,6L,3L,6L,7L,7L,1L,3L,0L,0L,4L,4L,8L,4L,3L,0L,4L,9L,3L,2L,7L,3L,5L,4L,2L,6L,0L,0L,8L,9L,6L,8L,6L,0L,9L,8L,6L,5L,4L,7L,0L,8L,5L,2L,0L,1L,7L,9L,3L,7L,2L,1L,9L,7L,3L,0L,9L,4L,1L,7L,0L,4L,0L,3L,5L,8L,7L,4L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021896Inst : IEnumerable<long>
{
public static readonly long[] Value=A021896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021896.Bytes);
public long this[int i]=>Value[i];

public static A021896Inst Instance=new A021896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021897
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,9L,8L,2L,0L,8L,2L,8L,6L,6L,7L,4L,1L,3L,2L,1L,3L,8L,8L,5L,7L,7L,8L,2L,7L,5L,4L,7L,5L,9L,2L,3L,8L,5L,2L,1L,8L,3L,6L,5L,0L,6L,1L,5L,9L,0L,1L,4L,5L,5L,7L,6L,7L,0L,7L,7L,2L,6L,7L,6L,3L,7L,1L,7L,8L,0L,5L,1L,5L,1L,1L,7L,5L,8L,1L,1L,8L,7L,0L,1L,0L,0L,7L,8L,3L,8L,7L,4L,5L,8L,0L,0L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021897Inst : IEnumerable<long>
{
public static readonly long[] Value=A021897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021897.Bytes);
public long this[int i]=>Value[i];

public static A021897Inst Instance=new A021897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021898
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,8L,5L,6L,8L,2L,3L,2L,6L,6L,2L,1L,9L,2L,3L,9L,3L,7L,3L,6L,0L,1L,7L,8L,9L,7L,0L,9L,1L,7L,2L,2L,5L,9L,5L,0L,7L,8L,2L,9L,9L,7L,7L,6L,2L,8L,6L,3L,5L,3L,4L,6L,7L,5L,6L,1L,5L,2L,1L,2L,5L,2L,7L,9L,6L,4L,2L,0L,5L,8L,1L,6L,5L,5L,4L,8L,0L,9L,8L,4L,3L,4L,0L,0L,4L,4L,7L,4L,2L,7L,2L,9L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021898Inst : IEnumerable<long>
{
public static readonly long[] Value=A021898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021898.Bytes);
public long this[int i]=>Value[i];

public static A021898Inst Instance=new A021898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021899
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,7L,3L,1L,8L,4L,3L,5L,7L,5L,4L,1L,8L,9L,9L,4L,4L,1L,3L,4L,0L,7L,8L,2L,1L,2L,2L,9L,0L,5L,0L,2L,7L,9L,3L,2L,9L,6L,0L,8L,9L,3L,8L,5L,4L,7L,4L,8L,6L,0L,3L,3L,5L,1L,9L,5L,5L,3L,0L,7L,2L,6L,2L,5L,6L,9L,8L,3L,2L,4L,0L,2L,2L,3L,4L,6L,3L,6L,8L,7L,1L,5L,0L,8L,3L,7L,9L,8L,8L,8L,2L,6L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021899Inst : IEnumerable<long>
{
public static readonly long[] Value=A021899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021899.Bytes);
public long this[int i]=>Value[i];

public static A021899Inst Instance=new A021899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021900
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,6L,0L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021900Inst : IEnumerable<long>
{
public static readonly long[] Value=A021900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021900.Bytes);
public long this[int i]=>Value[i];

public static A021900Inst Instance=new A021900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021917
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,5L,2L,9L,0L,2L,5L,1L,9L,1L,6L,7L,5L,7L,9L,4L,0L,8L,5L,4L,3L,2L,6L,3L,9L,6L,4L,9L,5L,0L,7L,1L,1L,9L,3L,8L,6L,6L,3L,7L,4L,5L,8L,9L,2L,6L,6L,1L,5L,5L,5L,3L,1L,2L,1L,5L,7L,7L,2L,1L,7L,9L,6L,2L,7L,6L,0L,1L,3L,1L,4L,3L,4L,8L,3L,0L,2L,3L,0L,0L,1L,0L,9L,5L,2L,9L,0L,2L,5L,1L,9L,1L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021917Inst : IEnumerable<long>
{
public static readonly long[] Value=A021917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021917.Bytes);
public long this[int i]=>Value[i];

public static A021917Inst Instance=new A021917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021918
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,4L,0L,9L,1L,9L,0L,3L,7L,1L,9L,9L,1L,2L,4L,7L,2L,6L,4L,7L,7L,0L,2L,4L,0L,7L,0L,0L,2L,1L,8L,8L,1L,8L,3L,8L,0L,7L,4L,3L,9L,8L,2L,4L,9L,4L,5L,2L,9L,5L,4L,0L,4L,8L,1L,4L,0L,0L,4L,3L,7L,6L,3L,6L,7L,6L,1L,4L,8L,7L,9L,6L,4L,9L,8L,9L,0L,5L,9L,0L,8L,0L,9L,6L,2L,8L,0L,0L,8L,7L,5L,2L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021918Inst : IEnumerable<long>
{
public static readonly long[] Value=A021918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021918.Bytes);
public long this[int i]=>Value[i];

public static A021918Inst Instance=new A021918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021919
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,2L,8L,9L,6L,1L,7L,4L,8L,6L,3L,3L,8L,7L,9L,7L,8L,1L,4L,2L,0L,7L,6L,5L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L,1L,5L,8L,4L,6L,9L,9L,4L,5L,3L,5L,5L,1L,9L,1L,2L,5L,6L,8L,3L,0L,6L,0L,1L,0L,9L,2L,8L,9L,6L,1L,7L,4L,8L,6L,3L,3L,8L,7L,9L,7L,8L,1L,4L,2L,0L,7L,6L,5L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021919Inst : IEnumerable<long>
{
public static readonly long[] Value=A021919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021919.Bytes);
public long this[int i]=>Value[i];

public static A021919Inst Instance=new A021919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021920
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,1L,7L,0L,3L,0L,5L,6L,7L,6L,8L,5L,5L,8L,9L,5L,1L,9L,6L,5L,0L,6L,5L,5L,0L,2L,1L,8L,3L,4L,0L,6L,1L,1L,3L,5L,3L,7L,1L,1L,7L,9L,0L,3L,9L,3L,0L,1L,3L,1L,0L,0L,4L,3L,6L,6L,8L,1L,2L,2L,2L,7L,0L,7L,4L,2L,3L,5L,8L,0L,7L,8L,6L,0L,2L,6L,2L,0L,0L,8L,7L,3L,3L,6L,2L,4L,4L,5L,4L,1L,4L,8L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021920Inst : IEnumerable<long>
{
public static readonly long[] Value=A021920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021920.Bytes);
public long this[int i]=>Value[i];

public static A021920Inst Instance=new A021920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021921
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,0L,5L,1L,2L,5L,4L,0L,8L,9L,4L,2L,2L,0L,2L,8L,3L,5L,3L,3L,2L,6L,0L,6L,3L,2L,4L,9L,7L,2L,7L,3L,7L,1L,8L,6L,4L,7L,7L,6L,4L,4L,4L,9L,2L,9L,1L,1L,6L,6L,8L,4L,8L,4L,1L,8L,7L,5L,6L,8L,1L,5L,7L,0L,3L,3L,8L,0L,5L,8L,8L,8L,7L,6L,7L,7L,2L,0L,8L,2L,8L,7L,8L,9L,5L,3L,1L,0L,7L,9L,6L,0L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021921Inst : IEnumerable<long>
{
public static readonly long[] Value=A021921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021921.Bytes);
public long this[int i]=>Value[i];

public static A021921Inst Instance=new A021921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021922
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,9L,3L,2L,4L,6L,1L,8L,7L,3L,6L,3L,8L,3L,4L,4L,2L,2L,6L,5L,7L,9L,5L,2L,0L,6L,9L,7L,1L,6L,7L,7L,5L,5L,9L,9L,1L,2L,8L,5L,4L,0L,3L,0L,5L,0L,1L,0L,8L,9L,3L,2L,4L,6L,1L,8L,7L,3L,6L,3L,8L,3L,4L,4L,2L,2L,6L,5L,7L,9L,5L,2L,0L,6L,9L,7L,1L,6L,7L,7L,5L,5L,9L,9L,1L,2L,8L,5L,4L,0L,3L,0L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021922Inst : IEnumerable<long>
{
public static readonly long[] Value=A021922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021922.Bytes);
public long this[int i]=>Value[i];

public static A021922Inst Instance=new A021922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021923
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,8L,1L,3L,9L,2L,8L,1L,8L,2L,8L,0L,7L,3L,9L,9L,3L,4L,7L,1L,1L,6L,4L,3L,0L,9L,0L,3L,1L,5L,5L,6L,0L,3L,9L,1L,7L,3L,0L,1L,4L,1L,4L,5L,8L,1L,0L,6L,6L,3L,7L,6L,4L,9L,6L,1L,9L,1L,5L,1L,2L,5L,1L,3L,6L,0L,1L,7L,4L,1L,0L,2L,2L,8L,5L,0L,9L,2L,4L,9L,1L,8L,3L,8L,9L,5L,5L,3L,8L,6L,2L,8L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021923Inst : IEnumerable<long>
{
public static readonly long[] Value=A021923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021923.Bytes);
public long this[int i]=>Value[i];

public static A021923Inst Instance=new A021923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021924
{
public static readonly long[] Value={ 1L,24L,389L,5364L,68025L,821808L,9633613L,110741388L,1256415809L,14127007752L,157849954197L,1755978039972L,19472809159753L,215457395996256L,2380083675784541L,26261340423891516L,289518110311522257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021924Inst : IEnumerable<long>
{
public static readonly long[] Value=A021924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021924.Bytes);
public long this[int i]=>Value[i];

public static A021924Inst Instance=new A021924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021925
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,5L,7L,7L,6L,3L,3L,0L,0L,7L,6L,0L,0L,4L,3L,4L,3L,1L,0L,5L,3L,2L,0L,3L,0L,4L,0L,1L,7L,3L,7L,2L,4L,2L,1L,2L,8L,1L,2L,1L,6L,0L,6L,9L,4L,8L,9L,6L,8L,5L,1L,2L,4L,8L,6L,4L,2L,7L,7L,9L,5L,8L,7L,4L,0L,4L,9L,9L,4L,5L,7L,1L,1L,1L,8L,3L,4L,9L,6L,1L,9L,9L,7L,8L,2L,8L,4L,4L,7L,3L,3L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021925Inst : IEnumerable<long>
{
public static readonly long[] Value=A021925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021925.Bytes);
public long this[int i]=>Value[i];

public static A021925Inst Instance=new A021925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021926
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,4L,5L,9L,8L,6L,9L,8L,4L,8L,1L,5L,6L,1L,8L,2L,2L,1L,2L,5L,8L,1L,3L,4L,4L,9L,0L,2L,3L,8L,6L,1L,1L,7L,1L,3L,6L,6L,5L,9L,4L,3L,6L,0L,0L,8L,6L,7L,6L,7L,8L,9L,5L,8L,7L,8L,5L,2L,4L,9L,4L,5L,7L,7L,0L,0L,6L,5L,0L,7L,5L,9L,2L,1L,9L,0L,8L,8L,9L,3L,7L,0L,9L,3L,2L,7L,5L,4L,8L,8L,0L,6L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021926Inst : IEnumerable<long>
{
public static readonly long[] Value=A021926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021926.Bytes);
public long this[int i]=>Value[i];

public static A021926Inst Instance=new A021926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021927
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,3L,4L,2L,3L,6L,1L,8L,6L,3L,4L,8L,8L,6L,2L,4L,0L,5L,2L,0L,0L,4L,3L,3L,3L,6L,9L,4L,4L,7L,4L,5L,3L,9L,5L,4L,4L,9L,6L,2L,0L,8L,0L,1L,7L,3L,3L,4L,7L,7L,7L,8L,9L,8L,1L,5L,8L,1L,7L,9L,8L,4L,8L,3L,2L,0L,6L,9L,3L,3L,9L,1L,1L,1L,5L,9L,2L,6L,3L,2L,7L,1L,9L,3L,9L,3L,2L,8L,2L,7L,7L,3L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021927Inst : IEnumerable<long>
{
public static readonly long[] Value=A021927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021927.Bytes);
public long this[int i]=>Value[i];

public static A021927Inst Instance=new A021927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021928
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021928Inst : IEnumerable<long>
{
public static readonly long[] Value=A021928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021928.Bytes);
public long this[int i]=>Value[i];

public static A021928Inst Instance=new A021928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021929
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021929Inst : IEnumerable<long>
{
public static readonly long[] Value=A021929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021929.Bytes);
public long this[int i]=>Value[i];

public static A021929Inst Instance=new A021929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021930
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,9L,9L,1L,3L,6L,0L,6L,9L,1L,1L,4L,4L,7L,0L,8L,4L,2L,3L,3L,2L,6L,1L,3L,3L,9L,0L,9L,2L,8L,7L,2L,5L,7L,0L,1L,9L,4L,3L,8L,4L,4L,4L,9L,2L,4L,4L,0L,6L,0L,4L,7L,5L,1L,6L,1L,9L,8L,7L,0L,4L,1L,0L,3L,6L,7L,1L,7L,0L,6L,2L,6L,3L,4L,9L,8L,9L,2L,0L,0L,8L,6L,3L,9L,3L,0L,8L,8L,5L,5L,2L,9L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021930Inst : IEnumerable<long>
{
public static readonly long[] Value=A021930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021930.Bytes);
public long this[int i]=>Value[i];

public static A021930Inst Instance=new A021930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021931
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,8L,7L,4L,8L,6L,5L,1L,5L,6L,4L,1L,8L,5L,5L,4L,4L,7L,6L,8L,0L,6L,9L,0L,3L,9L,9L,1L,3L,7L,0L,0L,1L,0L,7L,8L,7L,4L,8L,6L,5L,1L,5L,6L,4L,1L,8L,5L,5L,4L,4L,7L,6L,8L,0L,6L,9L,0L,3L,9L,9L,1L,3L,7L,0L,0L,1L,0L,7L,8L,7L,4L,8L,6L,5L,1L,5L,6L,4L,1L,8L,5L,5L,4L,4L,7L,6L,8L,0L,6L,9L,0L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021931Inst : IEnumerable<long>
{
public static readonly long[] Value=A021931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021931.Bytes);
public long this[int i]=>Value[i];

public static A021931Inst Instance=new A021931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021932
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021932Inst : IEnumerable<long>
{
public static readonly long[] Value=A021932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021932.Bytes);
public long this[int i]=>Value[i];

public static A021932Inst Instance=new A021932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021949
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021949Inst : IEnumerable<long>
{
public static readonly long[] Value=A021949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021949.Bytes);
public long this[int i]=>Value[i];

public static A021949Inst Instance=new A021949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021950
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,7L,0L,8L,2L,4L,5L,2L,4L,3L,1L,2L,8L,9L,6L,4L,0L,5L,9L,1L,9L,6L,6L,1L,7L,3L,3L,6L,1L,5L,2L,2L,1L,9L,8L,7L,3L,1L,5L,0L,1L,0L,5L,7L,0L,8L,2L,4L,5L,2L,4L,3L,1L,2L,8L,9L,6L,4L,0L,5L,9L,1L,9L,6L,6L,1L,7L,3L,3L,6L,1L,5L,2L,2L,1L,9L,8L,7L,3L,1L,5L,0L,1L,0L,5L,7L,0L,8L,2L,4L,5L,2L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021950Inst : IEnumerable<long>
{
public static readonly long[] Value=A021950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021950.Bytes);
public long this[int i]=>Value[i];

public static A021950Inst Instance=new A021950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021951
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,5L,9L,6L,6L,2L,0L,9L,0L,8L,1L,3L,0L,9L,3L,9L,8L,0L,9L,9L,2L,6L,0L,8L,2L,3L,6L,5L,3L,6L,4L,3L,0L,8L,3L,4L,2L,1L,3L,3L,0L,5L,1L,7L,4L,2L,3L,4L,4L,2L,4L,4L,9L,8L,4L,1L,6L,0L,5L,0L,6L,8L,6L,3L,7L,8L,0L,3L,5L,9L,0L,2L,8L,5L,1L,1L,0L,8L,7L,6L,4L,5L,1L,9L,5L,3L,5L,3L,7L,4L,8L,6L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021951Inst : IEnumerable<long>
{
public static readonly long[] Value=A021951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021951.Bytes);
public long this[int i]=>Value[i];

public static A021951Inst Instance=new A021951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021952
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021952Inst : IEnumerable<long>
{
public static readonly long[] Value=A021952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021952.Bytes);
public long this[int i]=>Value[i];

public static A021952Inst Instance=new A021952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021953
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021953Inst : IEnumerable<long>
{
public static readonly long[] Value=A021953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021953.Bytes);
public long this[int i]=>Value[i];

public static A021953Inst Instance=new A021953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021954
{
public static readonly long[] Value={ 1L,24L,387L,5278L,65793L,776412L,8835919L,98027226L,1067371965L,11457966520L,121639285131L,1279935023094L,13371252146617L,138859728185748L,1434922500247623L,14766153399643282L,151413895297559349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021954Inst : IEnumerable<long>
{
public static readonly long[] Value=A021954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021954.Bytes);
public long this[int i]=>Value[i];

public static A021954Inst Instance=new A021954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021955
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,1L,5L,2L,4L,7L,1L,0L,8L,3L,0L,7L,0L,4L,5L,2L,1L,5L,5L,6L,2L,5L,6L,5L,7L,2L,0L,2L,9L,4L,4L,2L,6L,9L,1L,9L,0L,3L,2L,5L,9L,7L,2L,6L,6L,0L,3L,5L,7L,5L,1L,8L,4L,0L,1L,6L,8L,2L,4L,3L,9L,5L,3L,7L,3L,2L,9L,1L,2L,7L,2L,3L,4L,4L,9L,0L,0L,1L,0L,5L,1L,5L,2L,4L,7L,1L,0L,8L,3L,0L,7L,0L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021955Inst : IEnumerable<long>
{
public static readonly long[] Value=A021955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021955.Bytes);
public long this[int i]=>Value[i];

public static A021955Inst Instance=new A021955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021956
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021956Inst : IEnumerable<long>
{
public static readonly long[] Value=A021956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021956.Bytes);
public long this[int i]=>Value[i];

public static A021956Inst Instance=new A021956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021957
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,9L,3L,1L,7L,9L,4L,3L,3L,3L,6L,8L,3L,1L,0L,5L,9L,8L,1L,1L,1L,2L,2L,7L,7L,0L,1L,9L,9L,3L,7L,0L,4L,0L,9L,2L,3L,3L,9L,9L,7L,9L,0L,1L,3L,6L,4L,1L,1L,3L,3L,2L,6L,3L,3L,7L,8L,8L,0L,3L,7L,7L,7L,5L,4L,4L,5L,9L,6L,0L,1L,2L,5L,9L,1L,8L,1L,5L,3L,2L,0L,0L,4L,1L,9L,7L,2L,7L,1L,7L,7L,3L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021957Inst : IEnumerable<long>
{
public static readonly long[] Value=A021957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021957.Bytes);
public long this[int i]=>Value[i];

public static A021957Inst Instance=new A021957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021958
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021958Inst : IEnumerable<long>
{
public static readonly long[] Value=A021958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021958.Bytes);
public long this[int i]=>Value[i];

public static A021958Inst Instance=new A021958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021959
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L,0L,8L,9L,0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L,1L,7L,8L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021959Inst : IEnumerable<long>
{
public static readonly long[] Value=A021959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021959.Bytes);
public long this[int i]=>Value[i];

public static A021959Inst Instance=new A021959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021960
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021960Inst : IEnumerable<long>
{
public static readonly long[] Value=A021960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021960.Bytes);
public long this[int i]=>Value[i];

public static A021960Inst Instance=new A021960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021961
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L,8L,3L,8L,0L,3L,5L,5L,2L,7L,6L,9L,0L,7L,0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L,8L,3L,8L,0L,3L,5L,5L,2L,7L,6L,9L,0L,7L,0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L,8L,3L,8L,0L,3L,5L,5L,2L,7L,6L,9L,0L,7L,0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021961Inst : IEnumerable<long>
{
public static readonly long[] Value=A021961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021961.Bytes);
public long this[int i]=>Value[i];

public static A021961Inst Instance=new A021961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021962
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,3L,8L,4L,1L,3L,3L,6L,1L,1L,6L,9L,1L,0L,2L,2L,9L,6L,4L,5L,0L,9L,3L,9L,4L,5L,7L,2L,0L,2L,5L,0L,5L,2L,1L,9L,2L,0L,6L,6L,8L,0L,5L,8L,4L,5L,5L,1L,1L,4L,8L,2L,2L,5L,4L,6L,9L,7L,2L,8L,6L,0L,1L,2L,5L,2L,6L,0L,9L,6L,0L,3L,3L,4L,0L,2L,9L,2L,2L,7L,5L,5L,7L,4L,1L,1L,2L,7L,3L,4L,8L,6L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021962Inst : IEnumerable<long>
{
public static readonly long[] Value=A021962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021962.Bytes);
public long this[int i]=>Value[i];

public static A021962Inst Instance=new A021962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021963
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021963Inst : IEnumerable<long>
{
public static readonly long[] Value=A021963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021963.Bytes);
public long this[int i]=>Value[i];

public static A021963Inst Instance=new A021963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021964
{
public static readonly long[] Value={ 1L,25L,422L,6050L,79563L,993675L,12002224L,141692500L,1645717205L,18887136125L,214818117306L,2426541462150L,27263857999327L,305049644712175L,3401871310224068L,37837512809631800L,419965002207076329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021964Inst : IEnumerable<long>
{
public static readonly long[] Value=A021964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021964.Bytes);
public long this[int i]=>Value[i];

public static A021964Inst Instance=new A021964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021981
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,3L,5L,4L,1L,4L,5L,3L,4L,2L,8L,8L,6L,3L,8L,6L,8L,9L,8L,6L,6L,9L,3L,9L,6L,1L,1L,0L,5L,4L,2L,4L,7L,6L,9L,7L,0L,3L,1L,7L,2L,9L,7L,8L,5L,0L,5L,6L,2L,9L,4L,7L,7L,9L,9L,3L,8L,5L,8L,7L,5L,1L,2L,7L,9L,4L,2L,6L,8L,1L,6L,7L,8L,6L,0L,7L,9L,8L,3L,6L,2L,3L,3L,3L,6L,7L,4L,5L,1L,3L,8L,1L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021981Inst : IEnumerable<long>
{
public static readonly long[] Value=A021981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021981.Bytes);
public long this[int i]=>Value[i];

public static A021981Inst Instance=new A021981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021982
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,4L,9L,4L,8L,8L,7L,5L,2L,5L,5L,6L,2L,3L,7L,2L,1L,8L,8L,1L,3L,9L,0L,5L,9L,3L,0L,4L,7L,0L,3L,4L,7L,6L,4L,8L,2L,6L,1L,7L,5L,8L,6L,9L,1L,2L,0L,6L,5L,4L,3L,9L,6L,7L,2L,8L,0L,1L,6L,3L,5L,9L,9L,1L,8L,2L,0L,0L,4L,0L,8L,9L,9L,7L,9L,5L,5L,0L,1L,0L,2L,2L,4L,9L,4L,8L,8L,7L,5L,2L,5L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021982Inst : IEnumerable<long>
{
public static readonly long[] Value=A021982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021982.Bytes);
public long this[int i]=>Value[i];

public static A021982Inst Instance=new A021982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021983
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,4L,5L,0L,4L,5L,9L,6L,5L,2L,7L,0L,6L,8L,4L,3L,7L,1L,8L,0L,7L,9L,6L,7L,3L,1L,3L,5L,8L,5L,2L,9L,1L,1L,1L,3L,3L,8L,1L,0L,0L,1L,0L,2L,1L,4L,5L,0L,4L,5L,9L,6L,5L,2L,7L,0L,6L,8L,4L,3L,7L,1L,8L,0L,7L,9L,6L,7L,3L,1L,3L,5L,8L,5L,2L,9L,1L,1L,1L,3L,3L,8L,1L,0L,0L,1L,0L,2L,1L,4L,5L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021983Inst : IEnumerable<long>
{
public static readonly long[] Value=A021983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021983.Bytes);
public long this[int i]=>Value[i];

public static A021983Inst Instance=new A021983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021984
{
public static readonly long[] Value={ 1L,26L,457L,6822L,93333L,1210938L,15168529L,185357774L,2224062445L,26316305730L,307996949481L,3573147901206L,41156463852037L,471239561238602L,5368820120200513L,60908872219620318L,688516109116593309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021984Inst : IEnumerable<long>
{
public static readonly long[] Value=A021984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021984.Bytes);
public long this[int i]=>Value[i];

public static A021984Inst Instance=new A021984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021985
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,9L,3L,6L,7L,9L,9L,1L,8L,4L,5L,0L,5L,6L,0L,6L,5L,2L,3L,9L,5L,5L,1L,4L,7L,8L,0L,8L,3L,5L,8L,8L,1L,7L,5L,3L,3L,1L,2L,9L,4L,5L,9L,7L,3L,4L,9L,6L,4L,3L,2L,2L,1L,2L,0L,2L,8L,5L,4L,2L,3L,0L,3L,7L,7L,1L,6L,6L,1L,5L,6L,9L,8L,2L,6L,7L,0L,7L,4L,4L,1L,3L,8L,6L,3L,4L,0L,4L,6L,8L,9L,0L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021985Inst : IEnumerable<long>
{
public static readonly long[] Value=A021985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021985.Bytes);
public long this[int i]=>Value[i];

public static A021985Inst Instance=new A021985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021986
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,8L,3L,2L,9L,9L,3L,8L,9L,0L,0L,2L,0L,3L,6L,6L,5L,9L,8L,7L,7L,8L,0L,0L,4L,0L,7L,3L,3L,1L,9L,7L,5L,5L,6L,0L,0L,8L,1L,4L,6L,6L,3L,9L,5L,1L,1L,2L,0L,1L,6L,2L,9L,3L,2L,7L,9L,0L,2L,2L,4L,0L,3L,2L,5L,8L,6L,5L,5L,8L,0L,4L,4L,8L,0L,6L,5L,1L,7L,3L,1L,1L,6L,0L,8L,9L,6L,1L,3L,0L,3L,4L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021986Inst : IEnumerable<long>
{
public static readonly long[] Value=A021986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021986.Bytes);
public long this[int i]=>Value[i];

public static A021986Inst Instance=new A021986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021987
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,7L,2L,9L,3L,9L,9L,7L,9L,6L,5L,4L,1L,2L,0L,0L,4L,0L,6L,9L,1L,7L,5L,9L,9L,1L,8L,6L,1L,6L,4L,8L,0L,1L,6L,2L,7L,6L,7L,0L,3L,9L,6L,7L,4L,4L,6L,5L,9L,2L,0L,6L,5L,1L,0L,6L,8L,1L,5L,8L,6L,9L,7L,8L,6L,3L,6L,8L,2L,6L,0L,4L,2L,7L,2L,6L,3L,4L,7L,9L,1L,4L,5L,4L,7L,3L,0L,4L,1L,7L,0L,9L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021987Inst : IEnumerable<long>
{
public static readonly long[] Value=A021987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021987.Bytes);
public long this[int i]=>Value[i];

public static A021987Inst Instance=new A021987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021988
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021988Inst : IEnumerable<long>
{
public static readonly long[] Value=A021988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021988.Bytes);
public long this[int i]=>Value[i];

public static A021988Inst Instance=new A021988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021989
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,5L,2L,2L,8L,4L,2L,6L,3L,9L,5L,9L,3L,9L,0L,8L,6L,2L,9L,4L,4L,1L,6L,2L,4L,3L,6L,5L,4L,8L,2L,2L,3L,3L,5L,0L,2L,5L,3L,8L,0L,7L,1L,0L,6L,5L,9L,8L,9L,8L,4L,7L,7L,1L,5L,7L,3L,6L,0L,4L,0L,6L,0L,9L,1L,3L,7L,0L,5L,5L,8L,3L,7L,5L,6L,3L,4L,5L,1L,7L,7L,6L,6L,4L,9L,7L,4L,6L,1L,9L,2L,8L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021989Inst : IEnumerable<long>
{
public static readonly long[] Value=A021989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021989.Bytes);
public long this[int i]=>Value[i];

public static A021989Inst Instance=new A021989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021990
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,4L,1L,9L,8L,7L,8L,2L,9L,6L,1L,4L,6L,0L,4L,4L,6L,2L,4L,7L,4L,6L,4L,5L,0L,3L,0L,4L,2L,5L,9L,6L,3L,4L,8L,8L,8L,4L,3L,8L,1L,3L,3L,8L,7L,4L,2L,3L,9L,3L,5L,0L,9L,1L,2L,7L,7L,8L,9L,0L,4L,6L,6L,5L,3L,1L,4L,4L,0L,1L,6L,2L,2L,7L,1L,8L,0L,5L,2L,7L,3L,8L,3L,3L,6L,7L,1L,3L,9L,9L,5L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021990Inst : IEnumerable<long>
{
public static readonly long[] Value=A021990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021990.Bytes);
public long this[int i]=>Value[i];

public static A021990Inst Instance=new A021990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021991
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,1L,7L,1L,2L,2L,5L,9L,3L,7L,1L,8L,3L,3L,8L,3L,9L,9L,1L,8L,9L,4L,6L,3L,0L,1L,9L,2L,5L,0L,2L,5L,3L,2L,9L,2L,8L,0L,6L,4L,8L,4L,2L,9L,5L,8L,4L,5L,9L,9L,7L,9L,7L,3L,6L,5L,7L,5L,4L,8L,1L,2L,5L,6L,3L,3L,2L,3L,2L,0L,1L,6L,2L,1L,0L,7L,3L,9L,6L,1L,4L,9L,9L,4L,9L,3L,4L,1L,4L,3L,8L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021991Inst : IEnumerable<long>
{
public static readonly long[] Value=A021991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021991.Bytes);
public long this[int i]=>Value[i];

public static A021991Inst Instance=new A021991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021992
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021992Inst : IEnumerable<long>
{
public static readonly long[] Value=A021992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021992.Bytes);
public long this[int i]=>Value[i];

public static A021992Inst Instance=new A021992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021993
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,8L,0L,3L,8L,4L,2L,2L,6L,4L,9L,1L,4L,0L,5L,4L,6L,0L,0L,6L,0L,6L,6L,7L,3L,4L,0L,7L,4L,8L,2L,3L,0L,5L,3L,5L,8L,9L,4L,8L,4L,3L,2L,7L,6L,0L,3L,6L,4L,0L,0L,4L,0L,4L,4L,4L,8L,9L,3L,8L,3L,2L,1L,5L,3L,6L,9L,0L,5L,9L,6L,5L,6L,2L,1L,8L,4L,0L,2L,4L,2L,6L,6L,9L,3L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021993Inst : IEnumerable<long>
{
public static readonly long[] Value=A021993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021993.Bytes);
public long this[int i]=>Value[i];

public static A021993Inst Instance=new A021993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021994
{
public static readonly long[] Value={ 1L,27L,495L,7735L,111111L,1517607L,20059495L,259217895L,3295741671L,41400518887L,515323813095L,6369067214055L,78280643507431L,957886180955367L,11679819118040295L,142009680313898215L,1722634678467548391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021994Inst : IEnumerable<long>
{
public static readonly long[] Value=A021994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021994.Bytes);
public long this[int i]=>Value[i];

public static A021994Inst Instance=new A021994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021995
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,9L,0L,8L,1L,7L,3L,5L,6L,2L,0L,5L,8L,5L,2L,6L,7L,4L,0L,6L,6L,5L,9L,9L,3L,9L,4L,5L,5L,0L,9L,5L,8L,6L,2L,7L,6L,4L,8L,8L,3L,9L,5L,5L,6L,0L,0L,4L,0L,3L,6L,3L,2L,6L,9L,4L,2L,4L,8L,2L,3L,4L,1L,0L,6L,9L,6L,2L,6L,6L,3L,9L,7L,5L,7L,8L,2L,0L,3L,8L,3L,4L,5L,1L,0L,5L,9L,5L,3L,5L,8L,2L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021995Inst : IEnumerable<long>
{
public static readonly long[] Value=A021995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021995.Bytes);
public long this[int i]=>Value[i];

public static A021995Inst Instance=new A021995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021996
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021996Inst : IEnumerable<long>
{
public static readonly long[] Value=A021996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021996.Bytes);
public long this[int i]=>Value[i];

public static A021996Inst Instance=new A021996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022093
{
public static readonly long[] Value={ 0L,10L,10L,20L,30L,50L,80L,130L,210L,340L,550L,890L,1440L,2330L,3770L,6100L,9870L,15970L,25840L,41810L,67650L,109460L,177110L,286570L,463680L,750250L,1213930L,1964180L,3178110L,5142290L,8320400L,13462690L,21783090L,35245780L,57028870L,92274650L,149303520L,241578170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022093Inst : IEnumerable<long>
{
public static readonly long[] Value=A022093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022093.Bytes);
public long this[int i]=>Value[i];

public static A022093Inst Instance=new A022093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022094
{
public static readonly long[] Value={ 5L,10L,28L,58L,160L,238L,440L,568L,874L,1480L,1720L,2584L,3266L,3638L,4438L,5830L,7418L,7982L,9854L,11240L,11966L,14288L,15968L,18650L,22548L,24680L,25800L,28104L,29296L,31734L,41022L,43940L,48494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022094Inst : IEnumerable<long>
{
public static readonly long[] Value=A022094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022094.Bytes);
public long this[int i]=>Value[i];

public static A022094Inst Instance=new A022094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022095
{
public static readonly long[] Value={ 1L,5L,6L,11L,17L,28L,45L,73L,118L,191L,309L,500L,809L,1309L,2118L,3427L,5545L,8972L,14517L,23489L,38006L,61495L,99501L,160996L,260497L,421493L,681990L,1103483L,1785473L,2888956L,4674429L,7563385L,12237814L,19801199L,32039013L,51840212L,83879225L,135719437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022095Inst : IEnumerable<long>
{
public static readonly long[] Value=A022095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022095.Bytes);
public long this[int i]=>Value[i];

public static A022095Inst Instance=new A022095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022096
{
public static readonly long[] Value={ 1L,6L,7L,13L,20L,33L,53L,86L,139L,225L,364L,589L,953L,1542L,2495L,4037L,6532L,10569L,17101L,27670L,44771L,72441L,117212L,189653L,306865L,496518L,803383L,1299901L,2103284L,3403185L,5506469L,8909654L,14416123L,23325777L,37741900L,61067677L,98809577L,159877254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022096Inst : IEnumerable<long>
{
public static readonly long[] Value=A022096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022096.Bytes);
public long this[int i]=>Value[i];

public static A022096Inst Instance=new A022096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022097
{
public static readonly long[] Value={ 1L,7L,8L,15L,23L,38L,61L,99L,160L,259L,419L,678L,1097L,1775L,2872L,4647L,7519L,12166L,19685L,31851L,51536L,83387L,134923L,218310L,353233L,571543L,924776L,1496319L,2421095L,3917414L,6338509L,10255923L,16594432L,26850355L,43444787L,70295142L,113739929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022097Inst : IEnumerable<long>
{
public static readonly long[] Value=A022097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022097.Bytes);
public long this[int i]=>Value[i];

public static A022097Inst Instance=new A022097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022098
{
public static readonly long[] Value={ 1L,8L,9L,17L,26L,43L,69L,112L,181L,293L,474L,767L,1241L,2008L,3249L,5257L,8506L,13763L,22269L,36032L,58301L,94333L,152634L,246967L,399601L,646568L,1046169L,1692737L,2738906L,4431643L,7170549L,11602192L,18772741L,30374933L,49147674L,79522607L,128670281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022098Inst : IEnumerable<long>
{
public static readonly long[] Value=A022098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022098.Bytes);
public long this[int i]=>Value[i];

public static A022098Inst Instance=new A022098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022099
{
public static readonly long[] Value={ 1L,9L,10L,19L,29L,48L,77L,125L,202L,327L,529L,856L,1385L,2241L,3626L,5867L,9493L,15360L,24853L,40213L,65066L,105279L,170345L,275624L,445969L,721593L,1167562L,1889155L,3056717L,4945872L,8002589L,12948461L,20951050L,33899511L,54850561L,88750072L,143600633L,232350705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022099Inst : IEnumerable<long>
{
public static readonly long[] Value=A022099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022099.Bytes);
public long this[int i]=>Value[i];

public static A022099Inst Instance=new A022099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022100
{
public static readonly long[] Value={ 1L,10L,11L,21L,32L,53L,85L,138L,223L,361L,584L,945L,1529L,2474L,4003L,6477L,10480L,16957L,27437L,44394L,71831L,116225L,188056L,304281L,492337L,796618L,1288955L,2085573L,3374528L,5460101L,8834629L,14294730L,23129359L,37424089L,60553448L,97977537L,158530985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022100Inst : IEnumerable<long>
{
public static readonly long[] Value=A022100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022100.Bytes);
public long this[int i]=>Value[i];

public static A022100Inst Instance=new A022100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022101
{
public static readonly long[] Value={ 1L,11L,12L,23L,35L,58L,93L,151L,244L,395L,639L,1034L,1673L,2707L,4380L,7087L,11467L,18554L,30021L,48575L,78596L,127171L,205767L,332938L,538705L,871643L,1410348L,2281991L,3692339L,5974330L,9666669L,15640999L,25307668L,40948667L,66256335L,107205002L,173461337L,280666339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022101Inst : IEnumerable<long>
{
public static readonly long[] Value=A022101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022101.Bytes);
public long this[int i]=>Value[i];

public static A022101Inst Instance=new A022101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022102
{
public static readonly long[] Value={ 1L,12L,13L,25L,38L,63L,101L,164L,265L,429L,694L,1123L,1817L,2940L,4757L,7697L,12454L,20151L,32605L,52756L,85361L,138117L,223478L,361595L,585073L,946668L,1531741L,2478409L,4010150L,6488559L,10498709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022102Inst : IEnumerable<long>
{
public static readonly long[] Value=A022102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022102.Bytes);
public long this[int i]=>Value[i];

public static A022102Inst Instance=new A022102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022103
{
public static readonly long[] Value={ 1L,13L,14L,27L,41L,68L,109L,177L,286L,463L,749L,1212L,1961L,3173L,5134L,8307L,13441L,21748L,35189L,56937L,92126L,149063L,241189L,390252L,631441L,1021693L,1653134L,2674827L,4327961L,7002788L,11330749L,18333537L,29664286L,47997823L,77662109L,125659932L,203322041L,328981973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022103Inst : IEnumerable<long>
{
public static readonly long[] Value=A022103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022103.Bytes);
public long this[int i]=>Value[i];

public static A022103Inst Instance=new A022103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022104
{
public static readonly long[] Value={ 1L,14L,15L,29L,44L,73L,117L,190L,307L,497L,804L,1301L,2105L,3406L,5511L,8917L,14428L,23345L,37773L,61118L,98891L,160009L,258900L,418909L,677809L,1096718L,1774527L,2871245L,4645772L,7517017L,12162789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022104Inst : IEnumerable<long>
{
public static readonly long[] Value=A022104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022104.Bytes);
public long this[int i]=>Value[i];

public static A022104Inst Instance=new A022104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022105
{
public static readonly long[] Value={ 1L,15L,16L,31L,47L,78L,125L,203L,328L,531L,859L,1390L,2249L,3639L,5888L,9527L,15415L,24942L,40357L,65299L,105656L,170955L,276611L,447566L,724177L,1171743L,1895920L,3067663L,4963583L,8031246L,12994829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022105Inst : IEnumerable<long>
{
public static readonly long[] Value=A022105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022105.Bytes);
public long this[int i]=>Value[i];

public static A022105Inst Instance=new A022105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022106
{
public static readonly long[] Value={ 1L,16L,17L,33L,50L,83L,133L,216L,349L,565L,914L,1479L,2393L,3872L,6265L,10137L,16402L,26539L,42941L,69480L,112421L,181901L,294322L,476223L,770545L,1246768L,2017313L,3264081L,5281394L,8545475L,13826869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022106Inst : IEnumerable<long>
{
public static readonly long[] Value=A022106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022106.Bytes);
public long this[int i]=>Value[i];

public static A022106Inst Instance=new A022106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022107
{
public static readonly long[] Value={ 1L,17L,18L,35L,53L,88L,141L,229L,370L,599L,969L,1568L,2537L,4105L,6642L,10747L,17389L,28136L,45525L,73661L,119186L,192847L,312033L,504880L,816913L,1321793L,2138706L,3460499L,5599205L,9059704L,14658909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022107Inst : IEnumerable<long>
{
public static readonly long[] Value=A022107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022107.Bytes);
public long this[int i]=>Value[i];

public static A022107Inst Instance=new A022107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022108
{
public static readonly long[] Value={ 1L,18L,19L,37L,56L,93L,149L,242L,391L,633L,1024L,1657L,2681L,4338L,7019L,11357L,18376L,29733L,48109L,77842L,125951L,203793L,329744L,533537L,863281L,1396818L,2260099L,3656917L,5917016L,9573933L,15490949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022108Inst : IEnumerable<long>
{
public static readonly long[] Value=A022108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022108.Bytes);
public long this[int i]=>Value[i];

public static A022108Inst Instance=new A022108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022493
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,15L,53L,217L,1014L,5335L,31240L,201608L,1422074L,10886503L,89903100L,796713190L,7541889195L,75955177642L,810925547354L,9148832109645L,108759758865725L,1358836180945243L,17801039909762186L,243992799075850037L,3492329741309417600L,BigInteger.Parse("52105418376516869150"),BigInteger.Parse("809029109658971635142") };
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
public class A022493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022493Inst Instance=new A022493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022494
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,16L,63L,293L,1561L,9321L,61436L,442134L,3446077L,28905485L,259585900L,2485120780L,25267283367L,271949606805L,3089330120711L,36943477086287L,463943009361687L,6105064699310785L,84011389289865102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022494Inst : IEnumerable<long>
{
public static readonly long[] Value=A022494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022494.Bytes);
public long this[int i]=>Value[i];

public static A022494Inst Instance=new A022494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022495
{
public static readonly long[] Value={ 1L,4L,11L,23L,48L,85L,147L,239L,375L,564L,834L,1190L,1672L,2300L,3113L,4143L,5455L,7073L,9085L,11542L,14529L,18119L,22439L,27550L,33615L,40738L,49076L,58769L,70034L,82995L,97922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022495Inst : IEnumerable<long>
{
public static readonly long[] Value=A022495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022495.Bytes);
public long this[int i]=>Value[i];

public static A022495Inst Instance=new A022495Inst();

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