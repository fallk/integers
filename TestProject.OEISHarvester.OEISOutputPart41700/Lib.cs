using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A049245
{
public static readonly long[] Value={ 2L,4L,3L,2L,1L,0L,6L,6L,6L,6L,6L,6L,2L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L,0L,6L,6L,6L,6L,1L,6L,6L,6L,6L,6L,6L,6L,2L,6L,6L,6L,6L,6L,6L,6L,6L,2L,1L,6L,5L,4L,3L,2L,1L,0L,6L,6L,6L,6L,6L,6L,2L,6L,6L,6L,6L,6L,6L,6L,3L,6L,1L,6L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L,0L,6L,6L,6L,6L,1L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049245Inst : IEnumerable<long>
{
public static readonly long[] Value=A049245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049245.Bytes);
public long this[int i]=>Value[i];

public static A049245Inst Instance=new A049245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049246
{
public static readonly long[] Value={ 3L,5L,1L,3L,2L,1L,0L,7L,7L,2L,7L,4L,2L,7L,3L,7L,7L,7L,1L,7L,7L,6L,5L,4L,3L,2L,1L,0L,7L,7L,1L,7L,7L,7L,7L,7L,3L,1L,7L,7L,7L,7L,3L,7L,7L,7L,1L,7L,7L,7L,3L,7L,7L,1L,7L,7L,6L,5L,1L,3L,2L,1L,0L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,4L,7L,7L,3L,7L,7L,7L,1L,7L,3L,7L,1L,7L,7L,7L,7L,7L,7L,1L,5L,7L,7L,7L,7L,3L,2L,6L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049246Inst : IEnumerable<long>
{
public static readonly long[] Value=A049246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049246.Bytes);
public long this[int i]=>Value[i];

public static A049246Inst Instance=new A049246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049247
{
public static readonly long[] Value={ 4L,0L,5L,4L,3L,2L,1L,0L,8L,8L,8L,8L,8L,2L,8L,8L,4L,0L,8L,8L,8L,2L,1L,8L,7L,6L,5L,4L,3L,2L,1L,0L,8L,8L,8L,8L,8L,2L,8L,8L,8L,8L,5L,8L,8L,2L,1L,8L,4L,0L,8L,8L,3L,2L,8L,8L,8L,8L,8L,8L,8L,2L,8L,8L,7L,6L,5L,4L,3L,2L,1L,0L,8L,8L,8L,8L,8L,8L,1L,8L,8L,8L,5L,8L,8L,2L,8L,8L,8L,8L,8L,4L,8L,2L,8L,8L,4L,0L,8L,8L,3L,2L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049247Inst : IEnumerable<long>
{
public static readonly long[] Value=A049247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049247.Bytes);
public long this[int i]=>Value[i];

public static A049247Inst Instance=new A049247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049248
{
public static readonly long[] Value={ 0L,1L,6L,0L,1L,3L,2L,1L,0L,9L,9L,9L,9L,1L,9L,0L,1L,9L,5L,1L,9L,9L,1L,9L,0L,1L,9L,8L,1L,6L,2L,4L,3L,2L,1L,0L,9L,9L,9L,9L,1L,9L,9L,9L,9L,2L,1L,9L,0L,1L,9L,9L,1L,9L,5L,1L,9L,9L,9L,9L,5L,1L,9L,0L,1L,9L,9L,1L,3L,9L,1L,9L,8L,1L,6L,5L,1L,3L,2L,1L,0L,9L,9L,9L,9L,9L,9L,9L,1L,9L,9L,4L,9L,2L,1L,9L,8L,1L,9L,0L,1L,9L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049248Inst : IEnumerable<long>
{
public static readonly long[] Value=A049248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049248.Bytes);
public long this[int i]=>Value[i];

public static A049248Inst Instance=new A049248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049249
{
public static readonly long[] Value={ 1L,2L,7L,4L,5L,4L,3L,2L,1L,0L,10L,10L,3L,10L,10L,10L,7L,10L,10L,10L,6L,2L,10L,10L,10L,10L,7L,10L,10L,10L,1L,8L,7L,6L,5L,4L,3L,2L,1L,0L,10L,10L,10L,10L,10L,10L,10L,10L,6L,10L,10L,10L,10L,4L,10L,10L,10L,10L,10L,10L,6L,2L,10L,10L,10L,6L,10L,10L,10L,10L,1L,10L,10L,10L,10L,10L,10L,10L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049249Inst : IEnumerable<long>
{
public static readonly long[] Value=A049249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049249.Bytes);
public long this[int i]=>Value[i];

public static A049249Inst Instance=new A049249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049250
{
public static readonly long[] Value={ 2L,1L,8L,7L,6L,3L,1L,3L,2L,1L,0L,11L,11L,2L,11L,11L,3L,9L,1L,11L,11L,11L,7L,3L,11L,2L,8L,4L,3L,5L,11L,3L,11L,10L,1L,8L,7L,6L,5L,4L,3L,2L,1L,0L,11L,11L,11L,11L,2L,1L,3L,11L,6L,5L,11L,8L,11L,2L,8L,11L,11L,3L,9L,11L,11L,11L,7L,3L,11L,11L,11L,11L,11L,1L,11L,4L,11L,2L,1L,11L,2L,11L,1L,11L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049250Inst : IEnumerable<long>
{
public static readonly long[] Value=A049250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049250.Bytes);
public long this[int i]=>Value[i];

public static A049250Inst Instance=new A049250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049251
{
public static readonly long[] Value={ 3L,4L,0L,8L,3L,6L,5L,4L,3L,2L,1L,0L,12L,12L,12L,12L,3L,12L,12L,12L,3L,12L,1L,12L,3L,4L,0L,12L,3L,12L,12L,12L,3L,12L,12L,12L,11L,10L,9L,8L,3L,6L,5L,4L,3L,2L,1L,0L,12L,12L,12L,12L,3L,12L,5L,12L,3L,2L,1L,12L,12L,12L,12L,12L,3L,12L,5L,12L,3L,12L,1L,12L,3L,4L,0L,12L,3L,12L,12L,12L,3L,12L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049251Inst : IEnumerable<long>
{
public static readonly long[] Value=A049251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049251.Bytes);
public long this[int i]=>Value[i];

public static A049251Inst Instance=new A049251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049252
{
public static readonly long[] Value={ 1L,2L,1L,1L,5L,7L,5L,5L,1L,3L,2L,1L,0L,13L,13L,4L,13L,13L,2L,5L,7L,10L,1L,13L,12L,13L,1L,5L,1L,13L,6L,5L,7L,13L,10L,1L,5L,10L,13L,12L,7L,3L,1L,8L,7L,2L,5L,4L,3L,2L,1L,0L,13L,13L,13L,13L,13L,5L,2L,13L,1L,13L,13L,13L,13L,13L,2L,13L,13L,7L,13L,13L,5L,13L,13L,8L,13L,13L,1L,5L,1L,3L,2L,13L,8L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049252Inst : IEnumerable<long>
{
public static readonly long[] Value=A049252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049252.Bytes);
public long this[int i]=>Value[i];

public static A049252Inst Instance=new A049252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049253
{
public static readonly long[] Value={ 5L,6L,2L,10L,1L,2L,7L,6L,5L,4L,3L,2L,1L,0L,14L,14L,7L,14L,2L,4L,14L,14L,7L,8L,14L,4L,2L,14L,3L,6L,2L,14L,14L,14L,14L,14L,14L,2L,14L,14L,7L,14L,13L,12L,9L,10L,2L,8L,7L,6L,3L,4L,3L,2L,1L,0L,14L,14L,2L,14L,1L,2L,14L,14L,14L,14L,14L,14L,11L,14L,14L,14L,7L,6L,11L,2L,14L,14L,14L,14L,5L,14L,2L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049253Inst : IEnumerable<long>
{
public static readonly long[] Value=A049253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049253.Bytes);
public long this[int i]=>Value[i];

public static A049253Inst Instance=new A049253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049254
{
public static readonly long[] Value={ 6L,7L,3L,11L,10L,6L,8L,7L,6L,5L,1L,3L,2L,1L,0L,15L,15L,15L,15L,15L,15L,15L,7L,15L,15L,6L,15L,15L,10L,15L,11L,7L,3L,15L,15L,15L,2L,10L,15L,15L,6L,15L,15L,4L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,1L,15L,15L,6L,15L,15L,15L,15L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049254Inst : IEnumerable<long>
{
public static readonly long[] Value=A049254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049254.Bytes);
public long this[int i]=>Value[i];

public static A049254Inst Instance=new A049254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049255
{
public static readonly long[] Value={ 0L,8L,4L,0L,11L,10L,1L,8L,0L,6L,4L,4L,3L,2L,1L,0L,16L,16L,4L,16L,16L,16L,1L,16L,0L,16L,4L,4L,16L,16L,1L,16L,12L,8L,4L,0L,16L,16L,16L,16L,16L,16L,4L,4L,16L,2L,1L,16L,0L,14L,4L,12L,11L,10L,9L,8L,7L,6L,4L,4L,3L,2L,1L,0L,16L,16L,4L,16L,3L,16L,1L,16L,12L,16L,4L,4L,11L,16L,1L,16L,0L,16L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049255Inst : IEnumerable<long>
{
public static readonly long[] Value=A049255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049255.Bytes);
public long this[int i]=>Value[i];

public static A049255Inst Instance=new A049255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049256
{
public static readonly long[] Value={ 1L,9L,5L,1L,3L,3L,5L,9L,8L,7L,6L,5L,1L,3L,2L,1L,0L,17L,17L,5L,17L,10L,5L,12L,8L,9L,5L,5L,3L,2L,17L,9L,8L,17L,13L,9L,5L,1L,17L,17L,11L,17L,13L,17L,5L,11L,2L,17L,13L,17L,17L,1L,15L,11L,2L,12L,5L,10L,9L,8L,7L,3L,5L,4L,3L,2L,1L,0L,17L,17L,17L,17L,5L,6L,17L,17L,13L,3L,17L,17L,8L,7L,9L,17L,17L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049256Inst : IEnumerable<long>
{
public static readonly long[] Value=A049256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049256.Bytes);
public long this[int i]=>Value[i];

public static A049256Inst Instance=new A049256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049257
{
public static readonly long[] Value={ 2L,0L,6L,2L,13L,12L,2L,0L,9L,2L,7L,6L,2L,4L,3L,2L,1L,0L,18L,18L,18L,18L,1L,18L,2L,18L,18L,2L,18L,18L,2L,0L,18L,2L,7L,18L,2L,10L,6L,2L,18L,18L,18L,18L,18L,2L,1L,18L,2L,0L,18L,2L,18L,18L,2L,16L,15L,2L,13L,12L,2L,4L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,18L,18L,18L,18L,18L,18L,2L,18L,18L,2L,13L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049257Inst : IEnumerable<long>
{
public static readonly long[] Value=A049257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049257.Bytes);
public long this[int i]=>Value[i];

public static A049257Inst Instance=new A049257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049258
{
public static readonly long[] Value={ 2L,1L,1L,3L,14L,3L,3L,4L,10L,1L,8L,4L,6L,5L,1L,3L,2L,1L,0L,19L,19L,6L,19L,3L,19L,2L,1L,3L,11L,19L,1L,11L,7L,19L,19L,19L,6L,19L,13L,4L,7L,3L,19L,19L,19L,19L,13L,16L,3L,1L,1L,7L,19L,19L,19L,19L,19L,2L,1L,4L,3L,2L,13L,3L,11L,10L,1L,8L,7L,5L,1L,4L,3L,2L,1L,0L,19L,19L,1L,19L,10L,3L,8L,19L,15L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049258Inst : IEnumerable<long>
{
public static readonly long[] Value=A049258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049258.Bytes);
public long this[int i]=>Value[i];

public static A049258Inst Instance=new A049258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049259
{
public static readonly long[] Value={ 4L,2L,5L,4L,0L,14L,5L,8L,11L,10L,4L,8L,7L,6L,5L,4L,3L,2L,1L,0L,20L,20L,5L,20L,20L,6L,5L,20L,20L,20L,4L,20L,3L,14L,5L,20L,20L,20L,5L,20L,4L,12L,5L,4L,0L,20L,5L,20L,19L,20L,5L,20L,3L,14L,5L,20L,20L,20L,1L,20L,4L,2L,17L,16L,15L,14L,5L,12L,11L,10L,4L,8L,7L,6L,5L,4L,3L,2L,1L,0L,20L,20L,5L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049259Inst : IEnumerable<long>
{
public static readonly long[] Value=A049259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049259.Bytes);
public long this[int i]=>Value[i];

public static A049259Inst Instance=new A049259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049260
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,3L,4L,0L,1L,2L,3L,1L,5L,6L,0L,1L,2L,2L,4L,3L,2L,7L,8L,0L,1L,2L,3L,1L,5L,3L,7L,8L,9L,10L,0L,1L,2L,3L,4L,1L,6L,2L,7L,5L,5L,11L,12L,0L,1L,2L,3L,1L,2L,6L,7L,3L,1L,2L,11L,1L,13L,14L,0L,1L,2L,2L,4L,5L,5L,7L,8L,1L,1L,11L,3L,7L,14L,15L,16L,0L,1L,2L,3L,1L,2L,6L,7L,1L,9L,3L,7L,3L,5L,14L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049260Inst : IEnumerable<long>
{
public static readonly long[] Value=A049260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049260.Bytes);
public long this[int i]=>Value[i];

public static A049260Inst Instance=new A049260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049261
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,4L,5L,0L,1L,2L,1L,4L,2L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,2L,2L,1L,10L,2L,12L,13L,0L,1L,2L,3L,4L,2L,4L,7L,8L,2L,6L,1L,4L,13L,14L,5L,16L,17L,0L,1L,2L,2L,4L,5L,6L,1L,2L,1L,10L,2L,6L,7L,14L,2L,16L,1L,18L,19L,20L,21L,0L,1L,2L,3L,4L,3L,6L,7L,8L,1L,2L,1L,12L,2L,4L,10L,14L,1L,10L,19L,10L,3L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049261Inst : IEnumerable<long>
{
public static readonly long[] Value=A049261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049261.Bytes);
public long this[int i]=>Value[i];

public static A049261Inst Instance=new A049261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049262
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,3L,1L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,1L,5L,9L,6L,5L,12L,13L,14L,0L,1L,2L,3L,1L,5L,6L,6L,8L,9L,1L,5L,3L,13L,6L,15L,1L,17L,18L,19L,20L,0L,1L,2L,3L,4L,2L,6L,7L,8L,6L,10L,8L,12L,1L,2L,9L,13L,17L,6L,1L,5L,21L,22L,11L,24L,25L,26L,0L,1L,2L,3L,1L,5L,6L,6L,5L,9L,10L,6L,3L,13L,6L,15L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049262Inst : IEnumerable<long>
{
public static readonly long[] Value=A049262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049262.Bytes);
public long this[int i]=>Value[i];

public static A049262Inst Instance=new A049262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049263
{
public static readonly long[] Value={ 0L,2L,3L,0L,1L,2L,3L,4L,0L,4L,7L,8L,1L,10L,11L,0L,1L,2L,3L,4L,5L,2L,7L,8L,0L,4L,8L,12L,1L,14L,3L,16L,17L,18L,19L,0L,1L,2L,3L,4L,1L,6L,3L,8L,5L,10L,11L,12L,0L,4L,8L,4L,1L,2L,11L,20L,12L,4L,8L,24L,1L,26L,27L,0L,1L,2L,3L,4L,5L,6L,7L,8L,1L,4L,11L,8L,13L,14L,15L,16L,0L,4L,8L,12L,1L,2L,23L,8L,1L,26L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049263Inst : IEnumerable<long>
{
public static readonly long[] Value=A049263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049263.Bytes);
public long this[int i]=>Value[i];

public static A049263Inst Instance=new A049263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049264
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,1L,2L,3L,1L,5L,6L,3L,5L,1L,10L,11L,3L,13L,14L,0L,1L,2L,2L,4L,5L,5L,7L,7L,5L,10L,11L,3L,7L,5L,15L,4L,5L,2L,19L,20L,9L,22L,23L,24L,0L,1L,2L,3L,1L,5L,6L,7L,3L,1L,10L,4L,3L,5L,6L,15L,16L,3L,7L,11L,5L,19L,22L,3L,1L,25L,11L,27L,5L,5L,30L,31L,7L,33L,34L,0L,1L,2L,3L,4L,5L,1L,7L,8L,5L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049264Inst : IEnumerable<long>
{
public static readonly long[] Value=A049264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049264.Bytes);
public long this[int i]=>Value[i];

public static A049264Inst Instance=new A049264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049265
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,3L,6L,7L,2L,6L,10L,3L,12L,3L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,6L,1L,8L,3L,10L,11L,12L,13L,2L,6L,10L,3L,18L,3L,12L,21L,10L,23L,24L,1L,26L,27L,28L,29L,0L,1L,2L,3L,4L,3L,6L,7L,2L,9L,10L,11L,12L,3L,12L,15L,16L,17L,18L,19L,2L,6L,10L,14L,6L,1L,26L,3L,12L,3L,30L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049265Inst : IEnumerable<long>
{
public static readonly long[] Value=A049265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049265.Bytes);
public long this[int i]=>Value[i];

public static A049265Inst Instance=new A049265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049266
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,6L,0L,1L,2L,3L,1L,5L,5L,7L,8L,1L,5L,2L,3L,5L,14L,1L,1L,17L,2L,19L,20L,0L,1L,2L,3L,4L,5L,3L,7L,8L,1L,10L,8L,12L,13L,14L,1L,1L,5L,9L,5L,17L,21L,2L,11L,5L,1L,17L,3L,28L,29L,1L,13L,32L,33L,34L,0L,1L,2L,3L,1L,5L,6L,7L,1L,8L,5L,1L,3L,12L,14L,2L,1L,17L,2L,19L,5L,21L,22L,1L,5L,1L,13L,17L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049266Inst : IEnumerable<long>
{
public static readonly long[] Value=A049266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049266.Bytes);
public long this[int i]=>Value[i];

public static A049266Inst Instance=new A049266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049267
{
public static readonly long[] Value={ 1L,0L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,4L,8L,12L,14L,7L,16L,8L,2L,4L,20L,8L,22L,23L,0L,1L,2L,3L,4L,5L,6L,7L,8L,8L,10L,4L,4L,13L,14L,15L,16L,17L,0L,4L,8L,5L,16L,20L,24L,1L,2L,3L,28L,8L,6L,7L,32L,8L,34L,4L,36L,37L,38L,39L,0L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,12L,8L,6L,15L,16L,1L,10L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049267Inst : IEnumerable<long>
{
public static readonly long[] Value=A049267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049267.Bytes);
public long this[int i]=>Value[i];

public static A049267Inst Instance=new A049267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049268
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,6L,7L,8L,0L,1L,2L,3L,1L,5L,6L,0L,8L,9L,10L,11L,3L,7L,11L,15L,0L,9L,18L,7L,5L,21L,22L,23L,24L,25L,26L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,7L,11L,12L,0L,9L,15L,4L,9L,18L,19L,20L,3L,1L,11L,15L,1L,23L,27L,0L,9L,18L,7L,32L,15L,31L,11L,36L,1L,9L,39L,19L,17L,42L,43L,44L,0L,1L,2L,3L,1L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049268Inst : IEnumerable<long>
{
public static readonly long[] Value=A049268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049268.Bytes);
public long this[int i]=>Value[i];

public static A049268Inst Instance=new A049268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049269
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,6L,2L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,2L,1L,10L,11L,12L,2L,6L,10L,10L,2L,2L,10L,20L,6L,22L,15L,6L,25L,26L,3L,28L,29L,0L,1L,2L,2L,4L,5L,4L,2L,8L,1L,10L,6L,10L,10L,14L,5L,14L,17L,10L,1L,20L,6L,22L,2L,6L,10L,14L,2L,10L,6L,30L,31L,8L,10L,10L,35L,4L,22L,38L,6L,40L,26L,18L,2L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049269Inst : IEnumerable<long>
{
public static readonly long[] Value=A049269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049269.Bytes);
public long this[int i]=>Value[i];

public static A049269Inst Instance=new A049269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049270
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,6L,7L,8L,9L,10L,0L,1L,2L,3L,1L,4L,6L,7L,8L,4L,10L,11L,1L,13L,1L,5L,1L,13L,2L,19L,1L,13L,22L,5L,19L,9L,1L,3L,7L,29L,6L,31L,32L,0L,1L,2L,1L,4L,5L,6L,7L,8L,1L,10L,11L,5L,13L,14L,1L,1L,2L,2L,7L,5L,6L,22L,1L,17L,1L,5L,1L,13L,13L,7L,1L,13L,33L,34L,7L,16L,25L,22L,8L,13L,10L,3L,19L,44L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049270Inst : IEnumerable<long>
{
public static readonly long[] Value=A049270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049270.Bytes);
public long this[int i]=>Value[i];

public static A049270Inst Instance=new A049270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049271
{
public static readonly long[] Value={ 1L,2L,0L,4L,5L,6L,4L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,4L,8L,9L,6L,11L,12L,13L,14L,0L,4L,8L,12L,4L,20L,21L,6L,15L,24L,4L,6L,3L,28L,17L,30L,4L,32L,33L,34L,35L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,2L,15L,16L,17L,6L,4L,20L,21L,22L,11L,24L,25L,26L,0L,4L,8L,12L,4L,20L,24L,6L,15L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049271Inst : IEnumerable<long>
{
public static readonly long[] Value=A049271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049271.Bytes);
public long this[int i]=>Value[i];

public static A049271Inst Instance=new A049271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049272
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,2L,2L,8L,9L,3L,11L,12L,0L,1L,2L,3L,1L,2L,6L,7L,8L,1L,10L,8L,12L,13L,14L,7L,16L,3L,2L,11L,5L,13L,22L,23L,5L,1L,26L,3L,7L,29L,3L,11L,5L,11L,2L,35L,1L,37L,38L,0L,1L,2L,3L,4L,5L,5L,7L,8L,9L,1L,2L,3L,13L,3L,6L,4L,17L,18L,2L,8L,5L,13L,3L,7L,1L,26L,3L,28L,29L,3L,7L,11L,8L,2L,23L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049272Inst : IEnumerable<long>
{
public static readonly long[] Value=A049272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049272.Bytes);
public long this[int i]=>Value[i];

public static A049272Inst Instance=new A049272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049273
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,1L,10L,2L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,2L,9L,10L,1L,10L,13L,14L,2L,16L,17L,2L,6L,10L,14L,4L,2L,6L,1L,10L,19L,28L,2L,2L,31L,2L,33L,34L,35L,4L,37L,38L,2L,40L,41L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,6L,6L,14L,2L,16L,17L,2L,19L,20L,7L,16L,2L,24L,1L,26L,3L,28L,29L,2L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049273Inst : IEnumerable<long>
{
public static readonly long[] Value=A049273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049273.Bytes);
public long this[int i]=>Value[i];

public static A049273Inst Instance=new A049273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049274
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,6L,3L,8L,9L,10L,11L,12L,13L,14L,0L,1L,2L,3L,1L,5L,6L,7L,3L,9L,10L,11L,3L,12L,14L,15L,1L,17L,18L,1L,5L,9L,13L,17L,15L,25L,26L,3L,3L,21L,30L,1L,3L,33L,10L,35L,9L,13L,17L,39L,40L,41L,42L,43L,44L,0L,1L,2L,3L,4L,5L,6L,3L,8L,6L,10L,11L,12L,10L,14L,15L,1L,17L,15L,1L,20L,21L,3L,3L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049274Inst : IEnumerable<long>
{
public static readonly long[] Value=A049274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049274.Bytes);
public long this[int i]=>Value[i];

public static A049274Inst Instance=new A049274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049275
{
public static readonly long[] Value={ 0L,2L,3L,0L,4L,6L,7L,8L,0L,10L,11L,12L,4L,14L,15L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,10L,11L,12L,4L,14L,12L,16L,17L,18L,19L,0L,4L,8L,12L,16L,1L,24L,3L,28L,5L,14L,23L,32L,0L,16L,32L,4L,4L,8L,39L,40L,41L,16L,11L,44L,4L,46L,47L,0L,1L,2L,3L,4L,5L,6L,7L,8L,1L,10L,11L,12L,13L,14L,15L,16L,0L,16L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049275Inst : IEnumerable<long>
{
public static readonly long[] Value=A049275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049275.Bytes);
public long this[int i]=>Value[i];

public static A049275Inst Instance=new A049275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049276
{
public static readonly long[] Value={ 1L,1L,3L,4L,3L,6L,7L,4L,1L,7L,3L,3L,13L,7L,15L,16L,0L,1L,2L,3L,1L,5L,3L,7L,8L,9L,7L,7L,3L,13L,7L,15L,1L,17L,2L,4L,5L,21L,3L,7L,11L,1L,19L,3L,7L,23L,30L,7L,1L,2L,34L,35L,15L,7L,38L,7L,3L,10L,18L,15L,7L,5L,7L,47L,3L,49L,50L,0L,1L,2L,3L,4L,5L,6L,3L,8L,1L,10L,11L,7L,1L,14L,15L,4L,17L,18L,15L,20L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049276Inst : IEnumerable<long>
{
public static readonly long[] Value=A049276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049276.Bytes);
public long this[int i]=>Value[i];

public static A049276Inst Instance=new A049276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049277
{
public static readonly long[] Value={ 1L,0L,3L,4L,2L,6L,7L,0L,9L,10L,9L,12L,13L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,6L,7L,2L,9L,10L,2L,12L,13L,0L,9L,16L,17L,18L,13L,20L,21L,22L,2L,6L,1L,14L,18L,22L,5L,30L,31L,0L,9L,18L,2L,36L,37L,14L,9L,10L,9L,42L,18L,44L,45L,46L,2L,48L,9L,50L,51L,52L,53L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049277Inst : IEnumerable<long>
{
public static readonly long[] Value=A049277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049277.Bytes);
public long this[int i]=>Value[i];

public static A049277Inst Instance=new A049277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049278
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,5L,1L,8L,5L,10L,1L,12L,2L,2L,15L,4L,17L,18L,0L,1L,2L,3L,1L,5L,1L,5L,8L,1L,2L,5L,3L,13L,14L,2L,1L,5L,2L,19L,5L,21L,13L,23L,1L,1L,5L,2L,1L,21L,1L,29L,8L,8L,2L,11L,5L,8L,38L,26L,8L,29L,1L,11L,9L,5L,41L,5L,3L,17L,2L,21L,13L,53L,6L,55L,56L,0L,1L,2L,3L,4L,5L,6L,1L,8L,1L,10L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049278Inst : IEnumerable<long>
{
public static readonly long[] Value=A049278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049278.Bytes);
public long this[int i]=>Value[i];

public static A049278Inst Instance=new A049278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049279
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,4L,7L,8L,1L,10L,11L,12L,5L,4L,15L,16L,5L,18L,19L,0L,1L,2L,3L,4L,5L,6L,7L,8L,5L,10L,11L,12L,13L,14L,15L,4L,5L,2L,19L,20L,9L,22L,23L,24L,0L,4L,8L,12L,1L,20L,24L,20L,5L,4L,35L,4L,12L,20L,11L,40L,41L,12L,28L,44L,5L,30L,23L,12L,1L,50L,31L,52L,5L,6L,55L,56L,28L,58L,59L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049279Inst : IEnumerable<long>
{
public static readonly long[] Value=A049279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049279.Bytes);
public long this[int i]=>Value[i];

public static A049279Inst Instance=new A049279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049280
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,5L,1L,5L,9L,5L,1L,6L,14L,14L,1L,7L,20L,28L,14L,1L,8L,27L,48L,42L,1L,9L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049280Inst : IEnumerable<long>
{
public static readonly long[] Value=A049280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049280.Bytes);
public long this[int i]=>Value[i];

public static A049280Inst Instance=new A049280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049281
{
public static readonly long[] Value={ 1L,5L,47L,319L,1879L,20417L,263111L,52279L,1768477L,33464927L,166770367L,3825136961L,19081066231L,57128792093L,236266661971L,7313175618421L,14606816124167L,102126365345729L,3774664307989373L,3771059091081773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049281Inst : IEnumerable<long>
{
public static readonly long[] Value=A049281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049281.Bytes);
public long this[int i]=>Value[i];

public static A049281Inst Instance=new A049281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049282
{
public static readonly long[] Value={ 3L,5L,13L,17L,19L,31L,37L,41L,53L,59L,67L,71L,89L,103L,107L,109L,113L,131L,139L,157L,163L,179L,181L,193L,197L,199L,211L,229L,233L,239L,251L,257L,269L,271L,283L,293L,307L,311L,337L,347L,379L,383L,397L,401L,409L,419L,431L,433L,449L,463L,467L,487L,491L,499L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049282Inst : IEnumerable<long>
{
public static readonly long[] Value=A049282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049282.Bytes);
public long this[int i]=>Value[i];

public static A049282Inst Instance=new A049282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049283
{
public static readonly long[] Value={ 1L,3L,0L,5L,0L,7L,0L,15L,0L,11L,0L,13L,0L,0L,0L,17L,0L,19L,0L,25L,0L,23L,0L,35L,0L,0L,0L,29L,0L,31L,0L,51L,0L,0L,0L,37L,0L,0L,0L,41L,0L,43L,0L,69L,0L,47L,0L,65L,0L,0L,0L,53L,0L,81L,0L,87L,0L,59L,0L,61L,0L,0L,0L,85L,0L,67L,0L,0L,0L,71L,0L,73L,0L,0L,0L,0L,0L,79L,0L,123L,0L,83L,0L,129L,0L,0L,0L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049283Inst : IEnumerable<long>
{
public static readonly long[] Value=A049283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049283.Bytes);
public long this[int i]=>Value[i];

public static A049283Inst Instance=new A049283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049284
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,7L,13L,24L,43L,78L,140L,251L,452L,812L,1457L,2617L,4697L,8428L,15126L,27142L,48700L,87384L,156787L,281307L,504723L,905562L,1624731L,2915039L,5230040L,9383505L,16835453L,30205347L,54192931L,97230224L,174445475L,312981054L,561534340L,1007475560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049284Inst : IEnumerable<long>
{
public static readonly long[] Value=A049284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049284.Bytes);
public long this[int i]=>Value[i];

public static A049284Inst Instance=new A049284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049285
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,4L,7L,13L,24L,43L,78L,141L,253L,455L,818L,1468L,2637L,4734L,8495L,15247L,27361L,49094L,88093L,158063L,283599L,508840L,912956L,1638003L,2938861L,5272795L,9460227L,16973125L,30452380L,54636174L,98025512L,175872397L,315541228L,566127763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049285Inst : IEnumerable<long>
{
public static readonly long[] Value=A049285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049285.Bytes);
public long this[int i]=>Value[i];

public static A049285Inst Instance=new A049285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049286
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,5L,4L,2L,1L,1L,9L,7L,4L,2L,1L,1L,16L,12L,7L,4L,2L,1L,1L,28L,22L,13L,7L,4L,2L,1L,1L,50L,39L,24L,13L,7L,4L,2L,1L,1L,89L,70L,42L,24L,13L,7L,4L,2L,1L,1L,159L,126L,76L,43L,24L,13L,7L,4L,2L,1L,1L,285L,225L,137L,78L,43L,24L,13L,7L,4L,2L,1L,1L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049286Inst : IEnumerable<long>
{
public static readonly long[] Value=A049286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049286.Bytes);
public long this[int i]=>Value[i];

public static A049286Inst Instance=new A049286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049287
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,8L,4L,12L,8L,20L,8L,48L,14L,48L,44L,84L,36L,192L,60L,336L,200L,416L,188L,1312L,423L,1400L,928L,3104L,1182L,8768L,2192L,8364L,6768L,16460L,11144L,46784L,14602L,58288L,44424L,136128L,52488L,355200L,99880L,432576L,351424L,762608L,364724L,2122944L,798952L,3356408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049287Inst : IEnumerable<long>
{
public static readonly long[] Value=A049287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049287.Bytes);
public long this[int i]=>Value[i];

public static A049287Inst Instance=new A049287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049288
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,16L,16L,30L,88L,94L,205L,457L,586L,1096L,3280L,5472L,7286L,21856L,26216L,49940L,174848L,182362L,399472L,1048576L,1290556L,3355456L,7456600L,9256396L,17895736L,59654816L,89478656L,130150588L,390451576L,490853416L,954437292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049288Inst : IEnumerable<long>
{
public static readonly long[] Value=A049288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049288.Bytes);
public long this[int i]=>Value[i];

public static A049288Inst Instance=new A049288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049289
{
public static readonly long[] Value={ 1L,1L,0L,2L,4L,0L,7L,10L,0L,30L,56L,0L,0L,316L,0L,1096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049289Inst : IEnumerable<long>
{
public static readonly long[] Value=A049289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049289.Bytes);
public long this[int i]=>Value[i];

public static A049289Inst Instance=new A049289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049290
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,13L,1L,1L,15L,97L,71L,1L,1L,31L,625L,2143L,461L,1L,1L,63L,3841L,54335L,68641L,3447L,1L,1L,127L,23233L,1321471L,8563601L,3011263L,29093L,1L,1L,255L,139777L,31817471L,1035045121L,2228419359L,173773153L,273343L,1L,1L,511L,839425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049290Inst : IEnumerable<long>
{
public static readonly long[] Value=A049290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049290.Bytes);
public long this[int i]=>Value[i];

public static A049290Inst Instance=new A049290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049291
{
public static readonly BigInteger[] Value={ 1L,15L,625L,54335L,8563601L,2228419359L,893451975473L,523337983164799L,429463651385469649L,BigInteger.Parse("477364501208149290975"),BigInteger.Parse("699086688951391180496497"),BigInteger.Parse("1318072723102023442664430143"),BigInteger.Parse("3137514636520304660660007679505") };
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
public class A049291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049291Inst Instance=new A049291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049292
{
public static readonly long[] Value={ 1L,31L,1330L,119315L,17543016L,4537258768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049292Inst : IEnumerable<long>
{
public static readonly long[] Value=A049292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049292.Bytes);
public long this[int i]=>Value[i];

public static A049292Inst Instance=new A049292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049293
{
public static readonly long[] Value={ 0L,0L,4L,34L,220L,1330L,7924L,47194L,281740L,1685410L,10095844L,60522154L,362968060L,2177301490L,13062263764L,78368897914L,470199235180L,2821152757570L,16926788191684L,101560343302474L,609360900699100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049293Inst : IEnumerable<long>
{
public static readonly long[] Value=A049293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049293.Bytes);
public long this[int i]=>Value[i];

public static A049293Inst Instance=new A049293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049294
{
public static readonly long[] Value={ 1L,13L,97L,625L,3841L,23233L,139777L,839425L,5038081L,30231553L,181395457L,1088385025L,6530334721L,39182057473L,235092443137L,1410554855425L,8463329525761L,50779977940993L,304679869218817L,1828079218458625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049294Inst : IEnumerable<long>
{
public static readonly long[] Value=A049294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049294.Bytes);
public long this[int i]=>Value[i];

public static A049294Inst Instance=new A049294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049295
{
public static readonly BigInteger[] Value={ 1L,71L,2143L,54335L,1321471L,31817471L,764217343L,18344733695L,440294408191L,10567189327871L,253613279903743L,6086723113107455L,146081381003558911L,3505953301484470271L,BigInteger.Parse("84142880178680889343"),BigInteger.Parse("2019429129941297135615"),BigInteger.Parse("48466299152487396933631") };
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
public class A049295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049295Inst Instance=new A049295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049296
{
public static readonly long[] Value={ 10L,2L,4L,2L,4L,6L,2L,6L,4L,2L,4L,6L,6L,2L,6L,4L,2L,6L,4L,6L,8L,4L,2L,4L,2L,4L,8L,6L,4L,6L,2L,4L,6L,2L,6L,6L,4L,2L,4L,6L,2L,6L,4L,2L,4L,2L,10L,2L,10L,2L,4L,2L,4L,6L,2L,6L,4L,2L,4L,6L,6L,2L,6L,4L,2L,6L,4L,6L,8L,4L,2L,4L,2L,4L,8L,6L,4L,6L,2L,4L,6L,2L,6L,6L,4L,2L,4L,6L,2L,6L,4L,2L,4L,2L,10L,2L,10L,2L,4L,2L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049296Inst : IEnumerable<long>
{
public static readonly long[] Value=A049296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049296.Bytes);
public long this[int i]=>Value[i];

public static A049296Inst Instance=new A049296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049297
{
public static readonly long[] Value={ 1L,2L,3L,6L,6L,20L,14L,46L,51L,140L,108L,624L,352L,1400L,2172L,4262L,4116L,22040L,14602L,68016L,88376L,209936L,190746L,1062592L,839094L,2797000L,3728891L,11276704L,9587580L,67195520L,35792568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049297Inst : IEnumerable<long>
{
public static readonly long[] Value=A049297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049297.Bytes);
public long this[int i]=>Value[i];

public static A049297Inst Instance=new A049297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049298
{
public static readonly long[] Value={ 0L,0L,2L,2L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L,3L,2L,2L,4L,2L,4L,3L,4L,2L,4L,2L,4L,2L,4L,2L,6L,2L,2L,3L,4L,3L,4L,2L,4L,3L,4L,2L,6L,2L,4L,3L,4L,2L,4L,2L,4L,3L,4L,2L,4L,3L,4L,3L,4L,2L,6L,2L,4L,3L,2L,3L,6L,2L,4L,3L,6L,2L,4L,2L,4L,3L,4L,3L,6L,2L,4L,2L,4L,2L,6L,3L,4L,3L,4L,2L,6L,3L,4L,3L,4L,3L,4L,2L,4L,3L,4L,2L,6L,2L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049298Inst : IEnumerable<long>
{
public static readonly long[] Value=A049298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049298.Bytes);
public long this[int i]=>Value[i];

public static A049298Inst Instance=new A049298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049299
{
public static readonly BigInteger[] Value={ 1L,2L,9L,400L,19456921L,BigInteger.Parse("1101216948902114953248") };
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
public class A049299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049299Inst Instance=new A049299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049300
{
public static readonly BigInteger[] Value={ 2L,2L,2L,2L,114L,9440L,217128L,60044L,20332472L,417086648L,74959204292L,187219155594L,79622514581574L,14478292443584L,6002108856728918L,12288083384384462L,5814429911995661690L,BigInteger.Parse("14719192159220252523420") };
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
public class A049300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049300Inst Instance=new A049300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049301
{
public static readonly long[] Value={ 7L,9L,24L,28L,57L,61L,62L,69L,71L,72L,77L,78L,80L,83L,87L,89L,95L,111L,162L,170L,174L,185L,191L,218L,222L,225L,229L,232L,249L,255L,259L,266L,267L,286L,288L,298L,314L,315L,322L,328L,329L,330L,332L,338L,351L,352L,362L,373L,376L,381L,386L,387L,414L,421L,435L,438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049301Inst : IEnumerable<long>
{
public static readonly long[] Value=A049301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049301.Bytes);
public long this[int i]=>Value[i];

public static A049301Inst Instance=new A049301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049302
{
public static readonly long[] Value={ 6L,10L,17L,25L,36L,42L,50L,59L,60L,61L,72L,73L,78L,79L,81L,84L,86L,87L,89L,92L,93L,95L,96L,160L,200L,212L,222L,225L,227L,239L,260L,261L,269L,290L,291L,296L,300L,301L,304L,311L,313L,315L,324L,326L,327L,330L,336L,344L,345L,348L,350L,355L,362L,372L,378L,379L,381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049302Inst : IEnumerable<long>
{
public static readonly long[] Value=A049302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049302.Bytes);
public long this[int i]=>Value[i];

public static A049302Inst Instance=new A049302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049303
{
public static readonly long[] Value={ 2L,5L,6L,7L,9L,19L,25L,32L,34L,36L,41L,54L,55L,56L,59L,62L,64L,67L,69L,70L,71L,75L,80L,81L,82L,84L,86L,87L,89L,92L,93L,95L,96L,111L,115L,125L,128L,140L,163L,166L,177L,178L,189L,192L,205L,212L,219L,221L,226L,233L,236L,242L,258L,259L,267L,294L,303L,309L,323L,327L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049303Inst : IEnumerable<long>
{
public static readonly long[] Value=A049303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049303.Bytes);
public long this[int i]=>Value[i];

public static A049303Inst Instance=new A049303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049304
{
public static readonly long[] Value={ 6L,7L,9L,13L,21L,22L,23L,29L,39L,40L,42L,44L,45L,48L,53L,55L,56L,60L,63L,64L,65L,67L,68L,69L,70L,73L,74L,75L,76L,77L,79L,82L,83L,87L,89L,92L,93L,94L,98L,105L,107L,127L,129L,131L,134L,137L,143L,147L,152L,163L,165L,167L,174L,179L,184L,189L,197L,224L,226L,227L,234L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049304Inst : IEnumerable<long>
{
public static readonly long[] Value=A049304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049304.Bytes);
public long this[int i]=>Value[i];

public static A049304Inst Instance=new A049304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049305
{
public static readonly long[] Value={ 3L,4L,6L,8L,12L,15L,20L,40L,42L,43L,50L,53L,55L,59L,60L,61L,62L,69L,72L,73L,74L,75L,78L,79L,80L,81L,83L,86L,87L,88L,89L,93L,94L,95L,96L,97L,99L,100L,103L,111L,113L,114L,118L,164L,165L,185L,193L,200L,207L,210L,215L,220L,230L,232L,238L,241L,243L,250L,253L,254L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049305Inst : IEnumerable<long>
{
public static readonly long[] Value=A049305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049305.Bytes);
public long this[int i]=>Value[i];

public static A049305Inst Instance=new A049305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049306
{
public static readonly long[] Value={ 4L,6L,7L,10L,13L,17L,18L,28L,31L,33L,36L,38L,42L,44L,47L,48L,49L,52L,54L,56L,58L,60L,63L,64L,67L,68L,69L,76L,77L,79L,81L,82L,83L,85L,86L,89L,90L,91L,94L,97L,112L,115L,124L,130L,135L,165L,173L,176L,178L,189L,193L,195L,206L,208L,215L,221L,225L,249L,251L,252L,253L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049306Inst : IEnumerable<long>
{
public static readonly long[] Value=A049306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049306.Bytes);
public long this[int i]=>Value[i];

public static A049306Inst Instance=new A049306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049307
{
public static readonly long[] Value={ 5L,7L,9L,25L,26L,31L,37L,43L,46L,47L,48L,53L,59L,60L,61L,63L,68L,69L,70L,72L,74L,76L,80L,85L,87L,88L,89L,91L,94L,97L,101L,104L,107L,124L,132L,135L,140L,148L,158L,166L,170L,180L,187L,190L,199L,209L,211L,215L,231L,243L,244L,256L,266L,270L,271L,279L,283L,288L,289L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049307Inst : IEnumerable<long>
{
public static readonly long[] Value=A049307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049307.Bytes);
public long this[int i]=>Value[i];

public static A049307Inst Instance=new A049307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049308
{
public static readonly BigInteger[] Value={ 1L,4L,40L,640L,14080L,394240L,13404160L,536166400L,24663654400L,1282510028800L,74385581670400L,4760677226905600L,333247405883392000L,BigInteger.Parse("25326802847137792000"),BigInteger.Parse("2076797833465298944000"),BigInteger.Parse("182758209344946307072000") };
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
public class A049308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049308Inst Instance=new A049308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049309
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,8L,20L,20L,30L,88L,94L,214L,457L,596L,1096L,3280L,5560L,7316L,21944L,26272L,49940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049309Inst : IEnumerable<long>
{
public static readonly long[] Value=A049309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049309.Bytes);
public long this[int i]=>Value[i];

public static A049309Inst Instance=new A049309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049310
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-2L,0L,1L,1L,0L,-3L,0L,1L,0L,3L,0L,-4L,0L,1L,-1L,0L,6L,0L,-5L,0L,1L,0L,-4L,0L,10L,0L,-6L,0L,1L,1L,0L,-10L,0L,15L,0L,-7L,0L,1L,0L,5L,0L,-20L,0L,21L,0L,-8L,0L,1L,-1L,0L,15L,0L,-35L,0L,28L,0L,-9L,0L,1L,0L,-6L,0L,35L,0L,-56L,0L,36L,0L,-10L,0L,1L,1L,0L,-21L,0L,70L,0L,-84L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049310Inst : IEnumerable<long>
{
public static readonly long[] Value=A049310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049310.Bytes);
public long this[int i]=>Value[i];

public static A049310Inst Instance=new A049310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049311
{
public static readonly long[] Value={ 1L,3L,6L,16L,34L,90L,211L,558L,1430L,3908L,10725L,30825L,90156L,273234L,848355L,2714399L,8909057L,30042866L,103859678L,368075596L,1335537312L,4958599228L,18820993913L,72980867400L,288885080660L,1166541823566L,4802259167367L,20141650236664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049311Inst : IEnumerable<long>
{
public static readonly long[] Value=A049311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049311.Bytes);
public long this[int i]=>Value[i];

public static A049311Inst Instance=new A049311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049312
{
public static readonly BigInteger[] Value={ 1L,2L,4L,8L,17L,38L,94L,258L,815L,3038L,13804L,78760L,580456L,5647602L,73645352L,1297920850L,31031370360L,1007551636038L,44432872400460L,2661065508648436L,216457998880015366L,BigInteger.Parse("23920728651724212120"),BigInteger.Parse("3593384834863975164882"),BigInteger.Parse("734240676501745813835934") };
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
public class A049312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049312Inst Instance=new A049312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049313
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,2L,6L,12L,79L,792L,19576L,886288L,75369960L,11856006240L,3467430423264L,1893448825054528L,1938818712501985736L,BigInteger.Parse("3737086626658278741376"),BigInteger.Parse("13606268915761294708760704"),BigInteger.Parse("93863103860384959101157737728") };
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
public class A049313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049313Inst Instance=new A049313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049314
{
public static readonly long[] Value={ 1L,3L,15L,60L,252L,1005L,4080L,16305L,65460L,261828L,1048260L,4192980L,16775955L,67103520L,268430160L,1073720415L,4294945932L,17179782540L,68719391100L,274877559420L,1099511281260L,4398045120300L,17592184654365L,70368738597600L,281474971147680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049314Inst : IEnumerable<long>
{
public static readonly long[] Value=A049314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049314.Bytes);
public long this[int i]=>Value[i];

public static A049314Inst Instance=new A049314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049315
{
public static readonly long[] Value={ 1L,4L,24L,120L,620L,3096L,15600L,77976L,390480L,1952380L,9764880L,48824280L,244136904L,1220683800L,6103496400L,30517481424L,152587794020L,762938966520L,3814696782120L,19073483892120L,95367429207720L,476837146020720L,2384185778835696L,11920928894086200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049315Inst : IEnumerable<long>
{
public static readonly long[] Value=A049315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049315.Bytes);
public long this[int i]=>Value[i];

public static A049315Inst Instance=new A049315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049316
{
public static readonly long[] Value={ 1L,6L,48L,336L,2394L,16752L,117600L,823152L,5764416L,40350870L,282472512L,1977307248L,13841268048L,96888873648L,678222936384L,4747560552384L,33232929612330L,232630507267536L,1628413591207536L,11398895138319024L,79792266250574640L,558545863753891104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049316Inst : IEnumerable<long>
{
public static readonly long[] Value=A049316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049316.Bytes);
public long this[int i]=>Value[i];

public static A049316Inst Instance=new A049316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049317
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,3L,3L,5L,4L,4L,7L,4L,5L,6L,6L,6L,6L,6L,7L,9L,7L,6L,11L,8L,8L,12L,7L,9L,12L,9L,10L,10L,12L,10L,14L,11L,9L,14L,12L,12L,16L,10L,13L,19L,13L,13L,16L,14L,14L,18L,15L,12L,18L,16L,17L,21L,13L,16L,23L,17L,20L,18L,18L,18L,24L,18L,15L,28L,19L,19L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049317Inst : IEnumerable<long>
{
public static readonly long[] Value=A049317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049317.Bytes);
public long this[int i]=>Value[i];

public static A049317Inst Instance=new A049317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049318
{
public static readonly long[] Value={ 3L,3L,6L,6L,9L,9L,12L,12L,15L,15L,24L,18L,18L,27L,24L,24L,36L,24L,30L,36L,33L,33L,36L,36L,42L,48L,42L,36L,60L,45L,48L,72L,42L,51L,72L,54L,57L,60L,72L,60L,81L,63L,54L,84L,69L,72L,96L,60L,75L,108L,78L,96L,81L,84L,108L,87L,72L,108L,96L,99L,120L,78L,96L,132L,99L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049318Inst : IEnumerable<long>
{
public static readonly long[] Value=A049318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049318.Bytes);
public long this[int i]=>Value[i];

public static A049318Inst Instance=new A049318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049319
{
public static readonly long[] Value={ 6L,24L,24L,48L,72L,72L,72L,96L,96L,120L,192L,144L,120L,216L,168L,192L,288L,192L,216L,288L,240L,264L,288L,288L,336L,384L,312L,288L,480L,360L,360L,576L,288L,408L,576L,432L,432L,480L,576L,648L,504L,384L,672L,528L,576L,768L,480L,576L,864L,600L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049319Inst : IEnumerable<long>
{
public static readonly long[] Value=A049319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049319.Bytes);
public long this[int i]=>Value[i];

public static A049319Inst Instance=new A049319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049320
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049320Inst : IEnumerable<long>
{
public static readonly long[] Value=A049320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049320.Bytes);
public long this[int i]=>Value[i];

public static A049320Inst Instance=new A049320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049321
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049321Inst : IEnumerable<long>
{
public static readonly long[] Value=A049321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049321.Bytes);
public long this[int i]=>Value[i];

public static A049321Inst Instance=new A049321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049322
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,4L,8L,12L,20L,28L,40L,52L,70L,88L,112L,136L,168L,200L,240L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049322Inst : IEnumerable<long>
{
public static readonly long[] Value=A049322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049322.Bytes);
public long this[int i]=>Value[i];

public static A049322Inst Instance=new A049322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049323
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,6L,16L,16L,1L,10L,50L,125L,125L,1L,15L,120L,540L,1296L,1296L,1L,21L,245L,1715L,7203L,16807L,16807L,1L,28L,448L,4480L,28672L,114688L,262144L,262144L,1L,36L,756L,10206L,91854L,551124L,2125764L,4782969L,4782969L,1L,45L,1200L,21000L,252000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049323Inst : IEnumerable<long>
{
public static readonly long[] Value=A049323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049323.Bytes);
public long this[int i]=>Value[i];

public static A049323Inst Instance=new A049323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049324
{
public static readonly long[] Value={ 1L,3L,1L,3L,6L,1L,0L,15L,9L,1L,0L,18L,36L,12L,1L,0L,9L,81L,66L,15L,1L,0L,0L,108L,216L,105L,18L,1L,0L,0L,81L,459L,450L,153L,21L,1L,0L,0L,27L,648L,1305L,810L,210L,24L,1L,0L,0L,0L,594L,2673L,2970L,1323L,276L,27L,1L,0L,0L,0L,324L,3915L,7938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049324Inst : IEnumerable<long>
{
public static readonly long[] Value=A049324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049324.Bytes);
public long this[int i]=>Value[i];

public static A049324Inst Instance=new A049324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049325
{
public static readonly long[] Value={ 1L,6L,1L,16L,12L,1L,16L,68L,18L,1L,0L,224L,156L,24L,1L,0L,448L,840L,280L,30L,1L,0L,512L,3072L,2080L,440L,36L,1L,0L,256L,7872L,10896L,4160L,636L,42L,1L,0L,0L,14080L,42240L,28240L,7296L,868L,48L,1L,0L,0L,16896L,123904L,145376L,60720L,11704L,1136L,54L,1L,0L,0L,12288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049325Inst : IEnumerable<long>
{
public static readonly long[] Value=A049325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049325.Bytes);
public long this[int i]=>Value[i];

public static A049325Inst Instance=new A049325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049326
{
public static readonly long[] Value={ 1L,10L,1L,50L,20L,1L,125L,200L,30L,1L,125L,1250L,450L,40L,1L,0L,5250L,4375L,800L,50L,1L,0L,15000L,30375L,10500L,1250L,60L,1L,0L,28125L,157500L,100500L,20625L,1800L,70L,1L,0L,31250L,621875L,740000L,250625L,35750L,2450L,80L,1L,0L,15625L,1875000L,4318750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049326Inst : IEnumerable<long>
{
public static readonly long[] Value=A049326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049326.Bytes);
public long this[int i]=>Value[i];

public static A049326Inst Instance=new A049326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049327
{
public static readonly long[] Value={ 1L,15L,1L,120L,30L,1L,540L,465L,45L,1L,1296L,4680L,1035L,60L,1L,1296L,33192L,15795L,1830L,75L,1L,0L,171072L,176688L,37260L,2850L,90L,1L,0L,641520L,1521828L,563409L,72450L,4095L,105L,1L,0L,1710720L,10359360L,6686064L,1375605L,124740L,5565L,120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049327Inst : IEnumerable<long>
{
public static readonly long[] Value=A049327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049327.Bytes);
public long this[int i]=>Value[i];

public static A049327Inst Instance=new A049327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049328
{
public static readonly long[] Value={ 51L,91L,130L,154L,156L,220L,297L,441L,525L,560L,625L,630L,672L,750L,756L,800L,900L,960L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049328Inst : IEnumerable<long>
{
public static readonly long[] Value=A049328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049328.Bytes);
public long this[int i]=>Value[i];

public static A049328Inst Instance=new A049328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049329
{
public static readonly long[] Value={ 1L,5L,6L,9L,10L,11L,16L,17L,19L,21L,24L,25L,28L,31L,32L,33L,35L,36L,37L,39L,41L,42L,43L,45L,46L,48L,49L,50L,51L,52L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,86L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,103L,108L,111L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049329Inst : IEnumerable<long>
{
public static readonly long[] Value=A049329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049329.Bytes);
public long this[int i]=>Value[i];

public static A049329Inst Instance=new A049329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049330
{
public static readonly BigInteger[] Value={ 1L,1L,3L,1L,115L,11L,5887L,151L,259723L,15619L,381773117L,655177L,20646903199L,27085381L,467168310097L,2330931341L,75920439315929441L,12157712239L,5278968781483042969L,37307713155613L,BigInteger.Parse("9093099984535515162569") };
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
public class A049330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049330Inst Instance=new A049330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049331
{
public static readonly BigInteger[] Value={ 2L,2L,8L,3L,384L,40L,23040L,630L,1146880L,72576L,1857945600L,3326400L,108999475200L,148262400L,2645053931520L,13621608000L,457065319366656000L,75277762560L,BigInteger.Parse("33566877054287216640"),243290200817664L };
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
public class A049331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049331Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049331.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049331Inst Instance=new A049331Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049332
{
public static readonly long[] Value={ 2L,4L,5L,10L,17L,34L,65L,130L,257L,514L,1025L,2050L,4097L,8194L,16385L,32770L,65537L,131074L,262145L,524290L,1048577L,2097154L,4194305L,8388610L,16777217L,33554434L,67108865L,134217730L,268435457L,536870914L,1073741825L,2147483650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049332Inst : IEnumerable<long>
{
public static readonly long[] Value=A049332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049332.Bytes);
public long this[int i]=>Value[i];

public static A049332Inst Instance=new A049332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049333
{
public static readonly BigInteger[] Value={ 1L,2L,243L,BigInteger.Parse("4951760157141521099596496896") };
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
public class A049333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049333Inst Instance=new A049333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049334
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,2L,2L,1L,1L,0L,0L,0L,0L,3L,5L,5L,4L,2L,1L,0L,0L,0L,0L,0L,6L,13L,19L,22L,19L,13L,5L,2L,0L,0L,0L,0L,0L,0L,11L,33L,67L,107L,130L,130L,96L,51L,16L,5L,0L,0L,0L,0L,0L,0L,0L,23L,89L,236L,486L,804L,1112L,1211L,1026L,626L,275L,72L,14L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049334Inst : IEnumerable<long>
{
public static readonly long[] Value=A049334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049334.Bytes);
public long this[int i]=>Value[i];

public static A049334Inst Instance=new A049334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049335
{
public static readonly long[] Value={ 1L,240L,2160L,6720L,17280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049335Inst : IEnumerable<long>
{
public static readonly long[] Value=A049335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049335.Bytes);
public long this[int i]=>Value[i];

public static A049335Inst Instance=new A049335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049336
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,2L,3L,2L,1L,0L,0L,0L,0L,0L,0L,1L,3L,9L,13L,11L,5L,2L,0L,0L,0L,0L,0L,0L,0L,1L,4L,20L,49L,77L,75L,47L,16L,5L,0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,40L,158L,406L,662L,737L,538L,259L,72L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,7L,70L,426L,1645L,4176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049336Inst : IEnumerable<long>
{
public static readonly long[] Value=A049336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049336.Bytes);
public long this[int i]=>Value[i];

public static A049336Inst Instance=new A049336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049337
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,8L,11L,8L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,11L,42L,74L,76L,38L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,74L,296L,633L,768L,558L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049337Inst : IEnumerable<long>
{
public static readonly long[] Value=A049337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049337.Bytes);
public long this[int i]=>Value[i];

public static A049337Inst Instance=new A049337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049338
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,14L,50L,233L,1249L,7616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049338Inst : IEnumerable<long>
{
public static readonly long[] Value=A049338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049338.Bytes);
public long this[int i]=>Value[i];

public static A049338Inst Instance=new A049338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049339
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,14L,36L,121L,533L,3067L,21798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049339Inst : IEnumerable<long>
{
public static readonly long[] Value=A049339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049339.Bytes);
public long this[int i]=>Value[i];

public static A049339Inst Instance=new A049339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049340
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,3L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,6L,1L,0L,0L,1L,1L,1L,3L,2L,2L,1L,1L,1L,0L,0L,0L,14L,1L,0L,0L,1L,1L,1L,3L,4L,4L,6L,5L,5L,3L,2L,0L,0L,0L,0L,0L,0L,0L,0L,36L,1L,1L,1L,1L,3L,4L,7L,9L,15L,17L,22L,14L,16L,5L,4L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049340Inst : IEnumerable<long>
{
public static readonly long[] Value=A049340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049340.Bytes);
public long this[int i]=>Value[i];

public static A049340Inst Instance=new A049340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049341
{
public static readonly long[] Value={ 3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L,3L,6L,9L,6L,6L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049341Inst : IEnumerable<long>
{
public static readonly long[] Value=A049341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049341.Bytes);
public long this[int i]=>Value[i];

public static A049341Inst Instance=new A049341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049342
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L,1L,3L,1L,1L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049342Inst : IEnumerable<long>
{
public static readonly long[] Value=A049342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049342.Bytes);
public long this[int i]=>Value[i];

public static A049342Inst Instance=new A049342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049343
{
public static readonly long[] Value={ 0L,2L,9L,11L,18L,20L,29L,38L,45L,47L,90L,99L,101L,110L,119L,144L,146L,180L,182L,189L,198L,200L,245L,290L,299L,335L,344L,351L,362L,369L,380L,398L,450L,452L,459L,461L,468L,470L,479L,488L,495L,497L,639L,729L,794L,839L,848L,900L,929L,954L,990L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049343Inst : IEnumerable<long>
{
public static readonly long[] Value=A049343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049343.Bytes);
public long this[int i]=>Value[i];

public static A049343Inst Instance=new A049343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049344
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,8L,14L,39L,96L,297L,915L,3308L,12417L,51347L,222595L,1016975L,4799520L,23301779L,115405815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049344Inst : IEnumerable<long>
{
public static readonly long[] Value=A049344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049344.Bytes);
public long this[int i]=>Value[i];

public static A049344Inst Instance=new A049344Inst();

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