using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278217
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,2L,4L,8L,12L,6L,2L,6L,12L,4L,8L,16L,24L,12L,6L,30L,6L,2L,6L,12L,36L,12L,4L,12L,24L,8L,16L,32L,48L,24L,12L,60L,30L,6L,30L,60L,12L,6L,2L,6L,30L,6L,12L,24L,72L,36L,12L,60L,12L,4L,12L,36L,72L,24L,8L,24L,48L,16L,32L,64L,96L,48L,24L,120L,60L,12L,60L,180L,60L,30L,6L,30L,210L,30L,60L,120L,24L,12L,6L,30L,6L,2L,6L,12L,60L,30L,6L,30L,60L,12L,24L,48L,144L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278217Inst : IEnumerable<long>
{
public static readonly long[] Value=A278217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278217.Bytes);
public long this[int i]=>Value[i];

public static A278217Inst Instance=new A278217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278218
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,4L,6L,4L,1L,1L,2L,6L,6L,2L,1L,1L,6L,6L,12L,6L,6L,1L,1L,2L,6L,6L,6L,6L,2L,1L,1L,8L,12L,24L,30L,24L,12L,8L,1L,1L,4L,36L,60L,60L,60L,60L,36L,4L,1L,1L,6L,12L,120L,210L,180L,210L,120L,12L,6L,1L,1L,2L,6L,30L,210L,210L,210L,210L,30L,6L,2L,1L,1L,12L,30L,60L,60L,360L,420L,360L,60L,60L,30L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278218Inst : IEnumerable<long>
{
public static readonly long[] Value=A278218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278218.Bytes);
public long this[int i]=>Value[i];

public static A278218Inst Instance=new A278218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278219
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,16L,8L,6L,12L,6L,2L,4L,12L,36L,12L,16L,32L,24L,8L,6L,30L,24L,12L,6L,12L,6L,2L,4L,12L,36L,12L,36L,72L,60L,12L,16L,48L,64L,32L,24L,72L,24L,8L,6L,30L,60L,30L,24L,48L,60L,12L,6L,30L,24L,12L,6L,12L,6L,2L,4L,12L,36L,12L,36L,72L,60L,12L,36L,180L,144L,72L,60L,180L,60L,12L,16L,48L,144L,48L,64L,128L,96L,32L,24L,120L,216L,72L,24L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278219Inst : IEnumerable<long>
{
public static readonly long[] Value=A278219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278219.Bytes);
public long this[int i]=>Value[i];

public static A278219Inst Instance=new A278219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278220
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,16L,2L,6L,8L,32L,4L,64L,16L,12L,2L,128L,6L,256L,8L,24L,32L,512L,4L,12L,64L,6L,16L,1024L,12L,2048L,2L,48L,128L,36L,6L,4096L,256L,96L,8L,8192L,24L,16384L,32L,12L,512L,32768L,4L,24L,12L,192L,64L,65536L,6L,72L,16L,384L,1024L,131072L,12L,262144L,2048L,24L,2L,144L,48L,524288L,128L,768L,36L,1048576L,6L,2097152L,4096L,30L,256L,72L,96L,4194304L,8L,6L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278220Inst : IEnumerable<long>
{
public static readonly long[] Value=A278220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278220.Bytes);
public long this[int i]=>Value[i];

public static A278220Inst Instance=new A278220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278221
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,16L,2L,4L,12L,32L,6L,64L,24L,12L,2L,128L,6L,256L,12L,36L,48L,512L,6L,8L,96L,4L,24L,1024L,30L,2048L,2L,72L,192L,24L,6L,4096L,384L,144L,12L,8192L,60L,16384L,48L,12L,768L,32768L,6L,16L,12L,288L,96L,65536L,6L,72L,24L,576L,1536L,131072L,30L,262144L,3072L,36L,2L,216L,120L,524288L,192L,1152L,60L,1048576L,6L,2097152L,6144L,12L,384L,48L,240L,4194304L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278221Inst : IEnumerable<long>
{
public static readonly long[] Value=A278221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278221.Bytes);
public long this[int i]=>Value[i];

public static A278221Inst Instance=new A278221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278222
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,6L,6L,12L,4L,12L,8L,16L,2L,6L,6L,12L,6L,30L,12L,24L,4L,12L,12L,36L,8L,24L,16L,32L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,4L,12L,12L,36L,12L,60L,36L,72L,8L,24L,24L,72L,16L,48L,32L,64L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,6L,30L,30L,60L,30L,210L,60L,120L,12L,60L,60L,180L,24L,120L,48L,96L,4L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278222Inst : IEnumerable<long>
{
public static readonly long[] Value=A278222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278222.Bytes);
public long this[int i]=>Value[i];

public static A278222Inst Instance=new A278222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278223
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,2L,6L,2L,2L,6L,2L,4L,8L,2L,2L,6L,6L,2L,6L,2L,2L,12L,2L,4L,6L,2L,6L,6L,2L,2L,12L,6L,2L,6L,2L,2L,12L,6L,2L,16L,2L,6L,6L,2L,6L,6L,6L,2L,12L,2L,2L,30L,2L,2L,6L,2L,6L,12L,6L,4L,6L,8L,2L,6L,2L,6L,24L,2L,2L,6L,6L,6L,12L,2L,2L,12L,6L,2L,6L,6L,2L,30L,2L,4L,12L,2L,12L,6L,2L,2L,6L,6L,6L,24L,2L,2L,30L,2L,2L,6L,6L,6L,12L,6L,2L,6L,6L,6L,6L,6L,2L,36L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278223Inst : IEnumerable<long>
{
public static readonly long[] Value=A278223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278223.Bytes);
public long this[int i]=>Value[i];

public static A278223Inst Instance=new A278223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278224
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,8L,6L,6L,2L,2L,2L,2L,4L,2L,12L,2L,6L,6L,12L,32L,12L,12L,6L,12L,4L,6L,12L,12L,16L,2L,2L,6L,6L,2L,6L,2L,6L,6L,2L,6L,6L,2L,24L,2L,24L,12L,8L,6L,2L,6L,48L,6L,30L,12L,6L,2L,6L,2L,2L,6L,6L,24L,30L,6L,60L,12L,36L,6L,2L,12L,2L,12L,24L,6L,6L,24L,72L,128L,30L,12L,2L,6L,12L,24L,2L,2L,30L,48L,4L,2L,6L,2L,6L,48L,16L,96L,6L,30L,2L,6L,12L,6L,24L,30L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278224Inst : IEnumerable<long>
{
public static readonly long[] Value=A278224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278224.Bytes);
public long this[int i]=>Value[i];

public static A278224Inst Instance=new A278224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278225
{
public static readonly long[] Value={ 2L,4L,12L,8L,12L,8L,60L,36L,24L,16L,24L,16L,60L,24L,24L,16L,36L,16L,60L,24L,36L,16L,24L,16L,420L,180L,180L,72L,180L,72L,120L,72L,48L,32L,48L,32L,120L,48L,48L,32L,72L,32L,120L,48L,72L,32L,48L,32L,420L,180L,120L,48L,120L,48L,120L,72L,48L,32L,48L,32L,180L,72L,48L,32L,72L,32L,180L,72L,72L,32L,48L,32L,420L,120L,120L,48L,180L,48L,180L,72L,48L,32L,72L,32L,120L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278225Inst : IEnumerable<long>
{
public static readonly long[] Value=A278225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278225.Bytes);
public long this[int i]=>Value[i];

public static A278225Inst Instance=new A278225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278226
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,12L,2L,6L,6L,30L,12L,60L,4L,12L,12L,60L,36L,180L,8L,24L,24L,120L,72L,360L,16L,48L,48L,240L,144L,720L,2L,6L,6L,30L,12L,60L,6L,30L,30L,210L,60L,420L,12L,60L,60L,420L,180L,1260L,24L,120L,120L,840L,360L,2520L,48L,240L,240L,1680L,720L,5040L,4L,12L,12L,60L,36L,180L,12L,60L,60L,420L,180L,1260L,36L,180L,180L,1260L,900L,6300L,72L,360L,360L,2520L,1800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278226Inst : IEnumerable<long>
{
public static readonly long[] Value=A278226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278226.Bytes);
public long this[int i]=>Value[i];

public static A278226Inst Instance=new A278226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278227
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,12L,16L,12L,6L,12L,30L,36L,24L,30L,6L,12L,6L,60L,30L,30L,72L,30L,6L,24L,96L,36L,30L,6L,72L,48L,60L,30L,24L,30L,12L,60L,60L,48L,6L,12L,6L,180L,30L,192L,36L,60L,210L,30L,6L,60L,24L,30L,240L,24L,256L,6L,12L,120L,60L,120L,30L,12L,60L,30L,120L,12L,210L,240L,6L,60L,96L,6L,30L,60L,120L,6L,12L,180L,144L,120L,30L,420L,30L,432L,30L,30L,192L,120L,60L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278227Inst : IEnumerable<long>
{
public static readonly long[] Value=A278227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278227.Bytes);
public long this[int i]=>Value[i];

public static A278227Inst Instance=new A278227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278260
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,6L,2L,2L,6L,6L,2L,2L,2L,12L,6L,6L,2L,6L,6L,2L,6L,6L,6L,6L,2L,30L,6L,2L,2L,6L,2L,2L,30L,30L,2L,12L,8L,6L,6L,2L,2L,30L,2L,6L,12L,30L,6L,2L,2L,6L,30L,2L,6L,30L,2L,6L,6L,6L,6L,6L,12L,30L,6L,12L,6L,30L,2L,6L,6L,6L,6L,2L,6L,30L,30L,12L,2L,6L,6L,2L,6L,12L,2L,6L,6L,60L,6L,6L,6L,6L,6L,6L,30L,210L,6L,6L,6L,6L,30L,6L,2L,6L,6L,6L,6L,30L,6L,2L,2L,30L,30L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278260Inst : IEnumerable<long>
{
public static readonly long[] Value=A278260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278260.Bytes);
public long this[int i]=>Value[i];

public static A278260Inst Instance=new A278260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278261
{
public static readonly long[] Value={ 1L,8L,2L,8L,24L,24L,2L,64L,24L,24L,192L,72L,24L,24L,4L,8L,24L,96L,24L,72L,96L,24L,72L,192L,24L,3456L,192L,24L,3456L,24L,2L,216L,192L,24L,1080L,72L,24L,8640L,576L,192L,8640L,3456L,24L,1080L,3456L,192L,1080L,120L,72L,96L,120L,24L,96L,360L,72L,576L,360L,24L,192L,120L,24L,72L,6L,8L,24L,1080L,24L,5400L,8640L,24L,72L,1080L,24L,432000L,8640L,24L,3456L,12288L,24L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278261Inst : IEnumerable<long>
{
public static readonly long[] Value=A278261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278261.Bytes);
public long this[int i]=>Value[i];

public static A278261Inst Instance=new A278261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278262
{
public static readonly long[] Value={ 2L,4L,2L,8L,2L,12L,16L,2L,12L,24L,12L,32L,2L,12L,24L,30L,24L,12L,60L,24L,64L,2L,12L,24L,30L,24L,30L,210L,60L,48L,12L,60L,12L,180L,8L,24L,16L,128L,2L,12L,24L,30L,24L,30L,210L,60L,48L,30L,210L,30L,420L,12L,60L,24L,96L,12L,60L,12L,180L,60L,360L,360L,24L,216L,72L,16L,432L,256L,2L,12L,24L,30L,24L,30L,210L,60L,48L,30L,210L,30L,420L,12L,60L,24L,96L,30L,210L,30L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278262Inst : IEnumerable<long>
{
public static readonly long[] Value=A278262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278262.Bytes);
public long this[int i]=>Value[i];

public static A278262Inst Instance=new A278262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278263
{
public static readonly long[] Value={ 1L,2L,4L,6L,2L,4L,12L,8L,6L,2L,6L,12L,6L,2L,6L,24L,16L,12L,6L,2L,6L,8L,30L,4L,6L,12L,6L,2L,6L,36L,32L,6L,2L,6L,30L,6L,2L,6L,12L,24L,12L,6L,2L,6L,48L,12L,12L,24L,24L,4L,12L,60L,6L,6L,30L,6L,2L,6L,30L,6L,2L,6L,72L,64L,12L,6L,2L,6L,12L,30L,12L,48L,6L,2L,6L,16L,60L,6L,24L,6L,2L,6L,60L,6L,6L,36L,12L,6L,2L,6L,96L,12L,6L,24L,30L,12L,30L,72L,6L,2L,6L,30L,30L,48L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278263Inst : IEnumerable<long>
{
public static readonly long[] Value=A278263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278263.Bytes);
public long this[int i]=>Value[i];

public static A278263Inst Instance=new A278263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278264
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,4L,6L,8L,6L,4L,12L,2L,12L,2L,2L,2L,6L,12L,2L,12L,6L,2L,2L,16L,24L,8L,6L,6L,6L,2L,2L,2L,6L,32L,4L,30L,2L,36L,2L,24L,6L,6L,16L,2L,6L,30L,2L,12L,12L,6L,6L,2L,36L,48L,2L,4L,6L,24L,2L,12L,6L,60L,6L,64L,24L,2L,128L,6L,12L,6L,6L,12L,30L,30L,6L,2L,30L,30L,2L,72L,12L,2L,96L,6L,60L,48L,6L,2L,2L,2L,6L,6L,6L,24L,6L,6L,30L,12L,96L,6L,24L,6L,2L,6L,2L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278264Inst : IEnumerable<long>
{
public static readonly long[] Value=A278264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278264.Bytes);
public long this[int i]=>Value[i];

public static A278264Inst Instance=new A278264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278265
{
public static readonly long[] Value={ 3L,3L,1L,3L,3L,1L,9L,9L,3L,27L,3L,1L,3L,3L,1L,3L,9L,3L,3L,1L,3L,3L,27L,1L,3L,3L,9L,3L,3L,1L,3L,1L,3L,9L,9L,3L,27L,3L,9L,27L,3L,3L,9L,3L,3L,27L,1L,3L,3L,1L,3L,3L,9L,27L,1L,3L,3L,3L,1L,81L,9L,9L,27L,1L,3L,3L,3L,9L,81L,3L,3L,27L,1L,3L,27L,9L,9L,27L,3L,1L,3L,3L,27L,1L,3L,3L,243L,9L,3L,3L,3L,1L,3L,9L,9L,3L,27L,1L,3L,1L,3L,3L,3L,9L,3L,27L,1L,1L,9L,3L,9L,9L,3L,27L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278265Inst : IEnumerable<long>
{
public static readonly long[] Value=A278265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278265.Bytes);
public long this[int i]=>Value[i];

public static A278265Inst Instance=new A278265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278266
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,4L,2L,2L,16L,2L,2L,2L,4L,2L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,2L,2L,16L,2L,2L,2L,2L,2L,2L,2L,2L,120L,4L,2L,2L,2L,2L,2L,2L,2L,2L,2L,120L,4L,2L,2L,2L,2L,2L,2L,2L,210L,2L,216L,2L,2L,2L,2L,2L,2L,2L,256L,2L,2L,120L,2L,120L,2L,2L,120L,2L,2L,4L,2L,2L,2L,120L,2L,2L,210L,2L,2L,2L,2L,2L,2L,4L,2L,2L,120L,2L,2L,384L,2L,210L,2L,2L,120L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278266Inst : IEnumerable<long>
{
public static readonly long[] Value=A278266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278266.Bytes);
public long this[int i]=>Value[i];

public static A278266Inst Instance=new A278266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278267
{
public static readonly long[] Value={ 0L,4L,47L,395L,3453L,30475L,268257L,2360984L,20781746L,182923358L,1610107387L,14172312272L,124745996060L,1098025707095L,9664923050975L,85071539806558L,748807501780793L,6591072360831728L,58015223889383283L,510655325670196475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278267Inst : IEnumerable<long>
{
public static readonly long[] Value=A278267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278267.Bytes);
public long this[int i]=>Value[i];

public static A278267Inst Instance=new A278267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278268
{
public static readonly BigInteger[] Value={ 0L,47L,1541L,46669L,1443372L,44653299L,1380961734L,42709293706L,1320881956427L,40851256530478L,1263417354853348L,39074034747765752L,1208452761189472245L,BigInteger.Parse("37374130557309864873"),BigInteger.Parse("1155879385419493659726"),BigInteger.Parse("35748180190801587747636") };
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
public class A278268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278268Inst Instance=new A278268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278269
{
public static readonly BigInteger[] Value={ 0L,395L,46669L,4917221L,534794424L,58169902939L,6324036210246L,687555458611667L,74752174764687123L,8127170663355813491L,BigInteger.Parse("883598453307356693716"),BigInteger.Parse("96066179664937465210288"),BigInteger.Parse("10444462440985215578690505") };
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
public class A278269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278269Inst Instance=new A278269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278270
{
public static readonly BigInteger[] Value={ 0L,3453L,1443372L,534794424L,205381236473L,78878506284185L,30276634666919851L,11621961222234314233UL,BigInteger.Parse("4461215336987162921036"),BigInteger.Parse("1712483772209720814532935"),BigInteger.Parse("657354678207062058219740801"),BigInteger.Parse("252332422484380951660270207305") };
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
public class A278270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278270Inst Instance=new A278270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278271
{
public static readonly BigInteger[] Value={ 0L,30475L,44653299L,58169902939L,78878506284185L,106937880786585233L,BigInteger.Parse("144890411982622214715"),BigInteger.Parse("196324396224795460823590"),BigInteger.Parse("266017816110405604627304812"),BigInteger.Parse("360451345655941579473611590523") };
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
public class A278271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278271Inst Instance=new A278271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278272
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,47L,47L,0L,0L,395L,1541L,395L,0L,0L,3453L,46669L,46669L,3453L,0L,0L,30475L,1443372L,4917221L,1443372L,30475L,0L,0L,268257L,44653299L,534794424L,534794424L,44653299L,268257L,0L,0L,2360984L,1380961734L,58169902939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278272Inst : IEnumerable<long>
{
public static readonly long[] Value=A278272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278272.Bytes);
public long this[int i]=>Value[i];

public static A278272Inst Instance=new A278272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278273
{
public static readonly BigInteger[] Value={ 0L,2L,25L,1461L,350649L,329985827L,1158266740087L,15396080290130290L,BigInteger.Parse("772462850808202305809"),BigInteger.Parse("146439171275776627088638614"),BigInteger.Parse("104845555459822852114388229089230") };
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
public class A278273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278273Inst Instance=new A278273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278274
{
public static readonly long[] Value={ 0L,2L,5L,16L,49L,153L,476L,1483L,4619L,14388L,44817L,139601L,434844L,1354499L,4219139L,13142228L,40936825L,127514425L,397195644L,1237227707L,3853849915L,12004386164L,37392552993L,116474345313L,362806816604L,1130109689139L,3520187193395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278274Inst : IEnumerable<long>
{
public static readonly long[] Value=A278274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278274.Bytes);
public long this[int i]=>Value[i];

public static A278274Inst Instance=new A278274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278275
{
public static readonly long[] Value={ 0L,4L,25L,136L,839L,5013L,30370L,183403L,1108525L,6699034L,40484839L,244664745L,1478598250L,8935711959L,54001778309L,326352531078L,1972267883095L,11919137270093L,72031712514698L,435314024068379L,2630762103695997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278275Inst : IEnumerable<long>
{
public static readonly long[] Value=A278275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278275.Bytes);
public long this[int i]=>Value[i];

public static A278275Inst Instance=new A278275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278308
{
public static readonly BigInteger[] Value={ 504L,197981L,114457714L,69684770828L,38819080346585L,20065923383306483L,10174217016822816668UL,BigInteger.Parse("5193800251722254864596"),BigInteger.Parse("2618709455820562585030428"),BigInteger.Parse("1260058503482337718156082135"),BigInteger.Parse("564882872428920086722942207177") };
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
public class A278308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278308Inst Instance=new A278308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278309
{
public static readonly long[] Value={ 0L,3L,3L,16L,32L,16L,51L,294L,294L,51L,126L,2089L,4558L,2089L,126L,266L,11486L,70795L,70795L,11486L,266L,504L,51562L,986014L,2360544L,986014L,51562L,504L,882L,197981L,11557658L,79562696L,79562696L,11557658L,197981L,882L,1452L,672365L,114457714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278309Inst : IEnumerable<long>
{
public static readonly long[] Value=A278309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278309.Bytes);
public long this[int i]=>Value[i];

public static A278309Inst Instance=new A278309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278310
{
public static readonly BigInteger[] Value={ 3L,143L,4899L,166463L,5654883L,192099599L,6525731523L,221682772223L,7530688524099L,255821727047183L,8690408031080163L,295218051329678399L,10028723337177985443UL,BigInteger.Parse("340681375412721826703"),BigInteger.Parse("11573138040695364122499"),BigInteger.Parse("393146012008229658338303"),BigInteger.Parse("13355391270239113019379843") };
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
public class A278310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278310Inst Instance=new A278310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278311
{
public static readonly long[] Value={ 34L,86L,94L,122L,142L,171L,202L,214L,218L,245L,285L,302L,394L,429L,435L,446L,507L,603L,604L,605L,634L,638L,698L,842L,922L,963L,1042L,1075L,1084L,1085L,1131L,1138L,1245L,1262L,1275L,1310L,1346L,1402L,1413L,1431L,1435L,1449L,1491L,1533L,1557L,1587L,1605L,1635L,1642L,1676L,1762L,1772L,1838L,1886L,1894L,1925L,1942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278311Inst : IEnumerable<long>
{
public static readonly long[] Value=A278311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278311.Bytes);
public long this[int i]=>Value[i];

public static A278311Inst Instance=new A278311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278312
{
public static readonly long[] Value={ 1L,8L,16L,128L,128L,2048L,4096L,32768L,16384L,524288L,1048576L,8388608L,8388608L,134217728L,268435456L,2147483648L,536870912L,34359738368L,68719476736L,549755813888L,549755813888L,8796093022208L,17592186044416L,140737488355328L,70368744177664L,2251799813685248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278312Inst : IEnumerable<long>
{
public static readonly long[] Value=A278312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278312.Bytes);
public long this[int i]=>Value[i];

public static A278312Inst Instance=new A278312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278313
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L,1L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278313Inst : IEnumerable<long>
{
public static readonly long[] Value=A278313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278313.Bytes);
public long this[int i]=>Value[i];

public static A278313Inst Instance=new A278313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278314
{
public static readonly BigInteger[] Value={ 0L,0L,1L,-3L,-5L,-14L,-8L,69L,-435L,2065L,3612L,28888L,-43355L,-2616119L,28076979L,-332513754L,331948240L,8280062505L,641260644409L,18784454671297L,-318128427505160L,10663732503571536L,-66316334575107447L,-8938035295591025771L,BigInteger.Parse("-588310630753491921045") };
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
public class A278314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278314Inst Instance=new A278314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278315
{
public static readonly long[] Value={ 4L,16L,18L,125L,144L,256L,400L,6489L,27559L,42601L,65536L,105800L,110825L,128975L,129600L,145800L,152775L,200025L,208679L,213444L,226033L,298116L,435600L,649800L,761959L,892561L,1076647L,1248961L,1622225L,1851569L,2059175L,2443575L,2668050L,3612672L,3967223L,7890199L,7947833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278315Inst : IEnumerable<long>
{
public static readonly long[] Value=A278315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278315.Bytes);
public long this[int i]=>Value[i];

public static A278315Inst Instance=new A278315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278316
{
public static readonly long[] Value={ 1L,3L,661L,983L,2631L,2893L,12385L,12893L,14661L,18615L,27519L,35383L,36213L,38691L,46215L,49231L,83631L,87291L,92843L,113865L,116683L,123415L,129815L,136423L,139261L,152619L,161683L,162435L,166817L,178119L,194725L,244635L,247941L,254663L,274165L,276941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278316Inst : IEnumerable<long>
{
public static readonly long[] Value=A278316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278316.Bytes);
public long this[int i]=>Value[i];

public static A278316Inst Instance=new A278316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278317
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,2L,4L,3L,2L,2L,4L,4L,3L,2L,2L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278317Inst : IEnumerable<long>
{
public static readonly long[] Value=A278317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278317.Bytes);
public long this[int i]=>Value[i];

public static A278317Inst Instance=new A278317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278318
{
public static readonly BigInteger[] Value={ 0L,3L,236L,19854L,3058990L,1133034160L,1159826452573L,3539023342110534L,BigInteger.Parse("33693644340398789900"),BigInteger.Parse("1032075934040317150939325") };
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
public class A278318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278318.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278318Inst Instance=new A278318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278319
{
public static readonly long[] Value={ 0L,3L,20L,94L,395L,1492L,4991L,14848L,39832L,97835L,223015L,477126L,966849L,1869504L,3470210L,6214384L,10780448L,18178763L,29884150L,48010910L,75541039L,116618372L,176923705L,264148560L,388588200L,563877795L,807899313L,1143890790L,1601794149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278319Inst : IEnumerable<long>
{
public static readonly long[] Value=A278319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278319.Bytes);
public long this[int i]=>Value[i];

public static A278319Inst Instance=new A278319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278320
{
public static readonly long[] Value={ 0L,20L,236L,1678L,9714L,51229L,251892L,1144205L,4762445L,18164685L,63838081L,208288721L,635843575L,1829104046L,4989647446L,12978273537L,32338548895L,77506161543L,179299342255L,401569610694L,873025241923L,1846627291485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278320Inst : IEnumerable<long>
{
public static readonly long[] Value=A278320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278320.Bytes);
public long this[int i]=>Value[i];

public static A278320Inst Instance=new A278320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278321
{
public static readonly long[] Value={ 1L,94L,1678L,19854L,186987L,1548002L,11947350L,87562135L,605431820L,3905165468L,23355599964L,129475795828L,667503759881L,3215875683718L,14555156486463L,62204964640341L,252211338710097L,974245904884957L,3598868691539578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278321Inst : IEnumerable<long>
{
public static readonly long[] Value=A278321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278321.Bytes);
public long this[int i]=>Value[i];

public static A278321Inst Instance=new A278321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278322
{
public static readonly long[] Value={ 6L,395L,9714L,186987L,3058990L,43798840L,570738085L,7010453565L,82490704797L,927749763030L,9874571566773L,98622311006346L,920542037366117L,8028589976371346L,65570255252201804L,503146509213296224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278322Inst : IEnumerable<long>
{
public static readonly long[] Value=A278322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278322.Bytes);
public long this[int i]=>Value[i];

public static A278322Inst Instance=new A278322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278323
{
public static readonly BigInteger[] Value={ 21L,1492L,51229L,1548002L,43798840L,1133034160L,26606146271L,577253086055L,11856994168275L,234252250004719L,4462457602929707L,81437338008292870L,1411665474225016752L,BigInteger.Parse("23098384621606953307"),BigInteger.Parse("355699829714059120732") };
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
public class A278323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278323Inst Instance=new A278323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278356
{
public static readonly BigInteger[] Value={ 0L,6L,142L,4872L,366982L,72941420L,41820621848L,72690257629470L,395626151337242078L,BigInteger.Parse("6904547033525030005268") };
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
public class A278356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278356Inst Instance=new A278356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278357
{
public static readonly long[] Value={ 1L,6L,27L,96L,281L,708L,1590L,3264L,6237L,11242L,19305L,31824L,50661L,78248L,117708L,172992L,249033L,351918L,489079L,669504L,903969L,1205292L,1588610L,2071680L,2675205L,3423186L,4343301L,5467312L,6831501L,8477136L,10450968L,12805760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278357Inst : IEnumerable<long>
{
public static readonly long[] Value=A278357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278357.Bytes);
public long this[int i]=>Value[i];

public static A278357Inst Instance=new A278357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278358
{
public static readonly long[] Value={ 4L,27L,142L,701L,3183L,12875L,46236L,149099L,438091L,1188762L,3012869L,7198373L,16335098L,35425161L,73791748L,148267982L,288389734L,544658465L,1001416052L,1796525377L,3150931185L,5412350915L,9118895376L,15090442305L,24558200485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278358Inst : IEnumerable<long>
{
public static readonly long[] Value=A278358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278358.Bytes);
public long this[int i]=>Value[i];

public static A278358Inst Instance=new A278358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278359
{
public static readonly long[] Value={ 10L,96L,701L,4872L,34038L,229887L,1429751L,8023290L,40628537L,187182375L,792488635L,3112464438L,11433026309L,39553920537L,129642951590L,404588606826L,1207383521600L,3458209486713L,9537445039588L,25399009679008L,65477548087465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278359Inst : IEnumerable<long>
{
public static readonly long[] Value=A278359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278359.Bytes);
public long this[int i]=>Value[i];

public static A278359Inst Instance=new A278359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278360
{
public static readonly long[] Value={ 20L,281L,3183L,34038L,366982L,4058169L,44208465L,451571539L,4213513472L,35702217342L,275765596545L,1955472740426L,12826024056862L,78357459733281L,448627173302773L,2420105832394544L,12358148308045511L,59981333718872012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278360Inst : IEnumerable<long>
{
public static readonly long[] Value=A278360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278360.Bytes);
public long this[int i]=>Value[i];

public static A278360Inst Instance=new A278360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278361
{
public static readonly long[] Value={ 35L,708L,12875L,229887L,4058169L,72941420L,1349344763L,24833319003L,434369879650L,7020524920612L,103836961295947L,1406134058397670L,17515133713282586L,201855377733718709L,2164799756963542782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278361Inst : IEnumerable<long>
{
public static readonly long[] Value=A278361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278361.Bytes);
public long this[int i]=>Value[i];

public static A278361Inst Instance=new A278361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278362
{
public static readonly BigInteger[] Value={ 56L,1590L,46236L,1429751L,44208465L,1349344763L,41820621848L,1335072188627L,42737962734110L,1315545171895930L,37821745334006837L,1003095347536883940L,BigInteger.Parse("24492157793238215600"),BigInteger.Parse("552053288766420787482"),BigInteger.Parse("11538125658500929877976") };
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
public class A278362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278362Inst Instance=new A278362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278363
{
public static readonly long[] Value={ 0L,1L,1L,4L,6L,4L,10L,27L,27L,10L,20L,96L,142L,96L,20L,35L,281L,701L,701L,281L,35L,56L,708L,3183L,4872L,3183L,708L,56L,84L,1590L,12875L,34038L,34038L,12875L,1590L,84L,120L,3264L,46236L,229887L,366982L,229887L,46236L,3264L,120L,165L,6237L,149099L,1429751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278363Inst : IEnumerable<long>
{
public static readonly long[] Value=A278363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278363.Bytes);
public long this[int i]=>Value[i];

public static A278363Inst Instance=new A278363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278364
{
public static readonly BigInteger[] Value={ 5L,375L,46875L,1640625L,123046875L,33837890625L,10997314453125L,1374664306640625L,116846466064453125L,BigInteger.Parse("55502071380615234375") };
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
public class A278364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278364Inst Instance=new A278364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278365
{
public static readonly long[] Value={ 0L,0L,0L,0L,6L,77L,504L,2304L,8350L,25653L,69576L,171106L,388752L,827190L,1665456L,3198312L,5895396L,10483934L,18062160L,30252180L,49402850L,78855339L,123286440L,189147400L,285219090L,423307755L,619109400L,893275110L,1272714300L,1792178076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278365Inst : IEnumerable<long>
{
public static readonly long[] Value=A278365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278365.Bytes);
public long this[int i]=>Value[i];

public static A278365Inst Instance=new A278365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278366
{
public static readonly long[] Value={ 0L,0L,59L,1465L,19047L,194726L,1734714L,13506810L,91496261L,543067118L,2862579656L,13596395709L,58966870090L,236182156566L,882025314222L,3095734502639L,10279759883927L,32476397677376L,98079088190039L,284292946153409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278366Inst : IEnumerable<long>
{
public static readonly long[] Value=A278366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278366.Bytes);
public long this[int i]=>Value[i];

public static A278366Inst Instance=new A278366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278367
{
public static readonly ulong[] Value={ 0L,59L,3766L,184341L,5897660L,138641633L,2705568336L,46817185633L,733865213852L,10436129552575L,134500209406905L,1574376228128520L,16823886495202722L,165209993322147396L,1501159407870244666L,12704143377811774222UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278367Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278367.Bytes);
public ulong this[int i]=>Value[i];

public static A278367Inst Instance=new A278367Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278368
{
public static readonly BigInteger[] Value={ 0L,1465L,184341L,16073852L,1185617520L,71569971497L,3591161445506L,156509651392363L,6152096549069001L,222794729697445622L,7488691646485617892L,BigInteger.Parse("233747568592586647588"),BigInteger.Parse("6769664767684601132112"),BigInteger.Parse("181975875729049004082635") };
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
public class A278368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278368Inst Instance=new A278368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278369
{
public static readonly BigInteger[] Value={ 6L,19047L,5897660L,1185617520L,202543496074L,30875729085512L,4136952690048454L,487193123130350097L,BigInteger.Parse("51331437862178906035"),BigInteger.Parse("4945011895747787547937"),BigInteger.Parse("443153467091368764828266"),BigInteger.Parse("37318809545959754128926920") };
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
public class A278369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278369Inst Instance=new A278369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278370
{
public static readonly BigInteger[] Value={ 77L,194726L,138641633L,71569971497L,30875729085512L,11975306266312114L,4248736162137280596L,BigInteger.Parse("1369281911256465678346"),BigInteger.Parse("399847654202980383002891"),BigInteger.Parse("106575448365556432324891769"),BigInteger.Parse("26256730686462803008566514303") };
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
public class A278370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278370Inst Instance=new A278370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278371
{
public static readonly BigInteger[] Value={ 504L,1734714L,2705568336L,3591161445506L,4136952690048454L,4248736162137280596L,BigInteger.Parse("4011624465030914131298"),BigInteger.Parse("3517606541854514840072201"),BigInteger.Parse("2856064084629269952289923184"),BigInteger.Parse("2141447684516773807277095689406") };
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
public class A278371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278371Inst Instance=new A278371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278388
{
public static readonly long[] Value={ 0L,0L,2L,2L,5L,7L,10L,3L,13L,14L,18L,20L,24L,27L,31L,10L,35L,36L,41L,34L,44L,48L,53L,55L,60L,64L,69L,72L,77L,81L,86L,15L,51L,42L,61L,89L,93L,95L,101L,102L,108L,109L,115L,119L,123L,128L,134L,136L,138L,143L,145L,149L,155L,160L,166L,169L,175L,180L,186L,190L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278388Inst : IEnumerable<long>
{
public static readonly long[] Value=A278388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278388.Bytes);
public long this[int i]=>Value[i];

public static A278388Inst Instance=new A278388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278389
{
public static readonly long[] Value={ 3L,7L,4L,4L,8L,5L,1L,8L,7L,9L,7L,4L,7L,4L,6L,1L,6L,3L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278389Inst : IEnumerable<long>
{
public static readonly long[] Value=A278389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278389.Bytes);
public long this[int i]=>Value[i];

public static A278389Inst Instance=new A278389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278390
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,6L,14L,16L,1L,10L,40L,85L,105L,1L,15L,90L,295L,594L,771L,1L,21L,175L,805L,2331L,4529L,6083L,1L,28L,308L,1876L,7280L,19348L,36644L,50464L,1L,36L,504L,3906L,19404L,66780L,166608L,309537L,434493L,1L,45L,780L,7470L,45990L,197484L,621180L,1476135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278390Inst : IEnumerable<long>
{
public static readonly long[] Value=A278390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278390.Bytes);
public long this[int i]=>Value[i];

public static A278390Inst Instance=new A278390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278391
{
public static readonly long[] Value={ 1L,2L,7L,29L,126L,565L,2583L,11971L,56038L,264345L,1254579L,5983628L,28655047L,137697549L,663621741L,3206344672L,15525816066L,75324830665L,366071485943L,1781794374016L,8684511754535L,42381025041490L,207055067487165L,1012617403658500L,4956924278927910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278391Inst : IEnumerable<long>
{
public static readonly long[] Value=A278391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278391.Bytes);
public long this[int i]=>Value[i];

public static A278391Inst Instance=new A278391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278392
{
public static readonly long[] Value={ 1L,3L,15L,87L,530L,3329L,21316L,138345L,906853L,5989967L,39804817L,265812731L,1782288408L,11991201709L,80911836411L,547334588037L,3710610424765L,25204313298581L,171492983631249L,1168638213247713L,7974592724571446L,54484621312318007L,372671912259214487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278392Inst : IEnumerable<long>
{
public static readonly long[] Value=A278392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278392.Bytes);
public long this[int i]=>Value[i];

public static A278392Inst Instance=new A278392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278393
{
public static readonly ulong[] Value={ 1L,4L,26L,194L,1521L,12289L,101205L,844711L,7120398L,60477913L,516774114L,4437360897L,38256405777L,330948944639L,2871299293535L,24973776734091L,217690276938940L,1901204163460913L,16632544424086901L,145730139895667887L,1278596503973570665L,11231908572986043199UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278393Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278393.Bytes);
public ulong this[int i]=>Value[i];

public static A278393Inst Instance=new A278393Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278394
{
public static readonly long[] Value={ 1L,2L,5L,17L,58L,209L,761L,2823L,10557L,39833L,151147L,576564L,2208163L,8486987L,32714813L,126430229L,489685674L,1900350201L,7387530575L,28763059410L,112142791763L,437774109384L,1710883748796L,6693281604018L,26210038447737L,102724200946467L,402925631267151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278394Inst : IEnumerable<long>
{
public static readonly long[] Value=A278394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278394.Bytes);
public long this[int i]=>Value[i];

public static A278394Inst Instance=new A278394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278395
{
public static readonly long[] Value={ 1L,3L,12L,60L,311L,1674L,9173L,51002L,286384L,1620776L,9228724L,52810792L,303447096L,1749612736L,10117583749L,58656027314L,340806249367L,1984018271850L,11569932938192L,67574451148408L,395214184047366L,2314315680481252L,13567587349336459L,79621279809031310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278395Inst : IEnumerable<long>
{
public static readonly long[] Value=A278395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278395.Bytes);
public long this[int i]=>Value[i];

public static A278395Inst Instance=new A278395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278396
{
public static readonly long[] Value={ 1L,4L,22L,146L,1013L,7269L,53156L,394154L,2951950L,22279439L,169175927L,1290970376L,9891573310L,76050920691L,586426828071L,4533349152056L,35122039919110L,272634162463779L,2119948044144136L,16509519223752380L,128747868290672353L,1005273235488567875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278396Inst : IEnumerable<long>
{
public static readonly long[] Value=A278396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278396.Bytes);
public long this[int i]=>Value[i];

public static A278396Inst Instance=new A278396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278397
{
public static readonly long[] Value={ 5L,11L,16L,21L,37L,83L,94L,299L,318L,467L,622L,707L,1931L,2175L,2189L,2238L,2526L,5202L,10541L,15822L,17407L,19919L,19998L,25407L,96377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278397Inst : IEnumerable<long>
{
public static readonly long[] Value=A278397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278397.Bytes);
public long this[int i]=>Value[i];

public static A278397Inst Instance=new A278397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278398
{
public static readonly long[] Value={ 1L,3L,15L,75L,400L,2169L,11989L,66985L,377718L,2144290L,12240943L,70193305L,404029950L,2332989921L,13508237399L,78399357623L,455959701700L,2656652705422L,15504203678738L,90614205677898L,530288460288008L,3107012752773125L,18223934202102463L,106996319699099591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278398Inst : IEnumerable<long>
{
public static readonly long[] Value=A278398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278398.Bytes);
public long this[int i]=>Value[i];

public static A278398Inst Instance=new A278398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278399
{
public static readonly long[] Value={ 1L,-1L,-1L,-2L,-2L,-3L,-2L,-3L,-2L,-2L,0L,0L,3L,4L,8L,9L,14L,16L,22L,24L,30L,32L,39L,40L,46L,46L,51L,48L,52L,46L,46L,36L,32L,16L,8L,-15L,-30L,-60L,-82L,-122L,-151L,-200L,-238L,-296L,-342L,-412L,-464L,-542L,-602L,-686L,-750L,-841L,-904L,-996L,-1058L,-1146L,-1198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278399Inst : IEnumerable<long>
{
public static readonly long[] Value=A278399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278399.Bytes);
public long this[int i]=>Value[i];

public static A278399Inst Instance=new A278399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278400
{
public static readonly long[] Value={ -1L,-1L,-1L,0L,0L,1L,2L,3L,4L,6L,6L,8L,9L,10L,10L,11L,10L,10L,8L,6L,2L,0L,-7L,-12L,-20L,-28L,-39L,-48L,-62L,-74L,-90L,-104L,-122L,-136L,-156L,-171L,-190L,-204L,-222L,-232L,-247L,-252L,-260L,-258L,-258L,-244L,-232L,-204L,-176L,-130L,-84L,-15L,54L,148L,244L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278400Inst : IEnumerable<long>
{
public static readonly long[] Value=A278400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278400.Bytes);
public long this[int i]=>Value[i];

public static A278400Inst Instance=new A278400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278401
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,-1L,-1L,-1L,1L,2L,2L,2L,4L,5L,5L,5L,6L,7L,5L,3L,4L,3L,0L,-2L,-3L,-5L,-10L,-14L,-16L,-18L,-23L,-28L,-28L,-29L,-35L,-38L,-37L,-37L,-39L,-39L,-35L,-30L,-29L,-26L,-15L,-5L,0L,10L,26L,41L,51L,64L,85L,105L,119L,135L,160L,183L,196L,212L,236L,255L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278401Inst : IEnumerable<long>
{
public static readonly long[] Value=A278401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278401.Bytes);
public long this[int i]=>Value[i];

public static A278401Inst Instance=new A278401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278402
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,-3L,-3L,-2L,-2L,-2L,-2L,-1L,1L,1L,2L,5L,7L,7L,8L,11L,12L,12L,13L,15L,16L,14L,12L,12L,11L,6L,2L,1L,-3L,-10L,-17L,-21L,-27L,-37L,-45L,-50L,-57L,-68L,-77L,-81L,-86L,-96L,-102L,-101L,-103L,-108L,-109L,-103L,-97L,-95L,-88L,-71L,-54L,-42L,-24L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278402Inst : IEnumerable<long>
{
public static readonly long[] Value=A278402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278402.Bytes);
public long this[int i]=>Value[i];

public static A278402Inst Instance=new A278402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278403
{
public static readonly long[] Value={ 1L,7L,19L,47L,76L,151L,197L,335L,424L,632L,727L,1127L,1184L,1673L,1894L,2511L,2602L,3634L,3611L,4872L,5066L,6299L,6349L,8615L,8201L,10316L,10630L,13081L,12616L,16526L,15377L,19407L,19258L,22838L,22322L,28586L,26012L,31775L,31622L,37960L,35302L,44594L,40679L,49899L,48874L,56081L,53017L,67239L,60222L,72507L,70246L,82012L,75844L,94030L,85502L,102745L,97850L,111860L,104431L,131502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278403Inst : IEnumerable<long>
{
public static readonly long[] Value=A278403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278403.Bytes);
public long this[int i]=>Value[i];

public static A278403Inst Instance=new A278403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278436
{
public static readonly long[] Value={ 17L,23L,47L,57L,93L,107L,173L,233L,353L,437L,467L,563L,677L,743L,817L,829L,851L,863L,955L,1037L,1187L,1213L,1277L,1387L,1433L,1487L,1549L,2089L,2147L,2213L,2287L,2293L,2417L,2473L,2689L,2777L,2911L,3083L,3323L,3391L,6691L,9337L,22969L,38557L,47347L,75391L,104999L,130927L,146719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278436Inst : IEnumerable<long>
{
public static readonly long[] Value=A278436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278436.Bytes);
public long this[int i]=>Value[i];

public static A278436Inst Instance=new A278436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278437
{
public static readonly long[] Value={ 2L,4L,1L,5L,6L,8L,9L,10L,20L,11L,13L,15L,17L,22L,21L,19L,24L,29L,31L,33L,35L,37L,39L,40L,41L,42L,47L,48L,49L,50L,52L,53L,56L,58L,59L,62L,67L,68L,69L,70L,72L,73L,76L,78L,79L,82L,87L,88L,89L,90L,92L,93L,96L,98L,99L,102L,104L,105L,106L,110L,111L,113L,114L,115L,117L,118L,120L,122L,124L,126L,127L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278437Inst : IEnumerable<long>
{
public static readonly long[] Value=A278437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278437.Bytes);
public long this[int i]=>Value[i];

public static A278437Inst Instance=new A278437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278438
{
public static readonly BigInteger[] Value={ 7L,799L,78407L,7683199L,752875207L,73774087199L,7229107670407L,708378777612799L,69413891098384007L,6801852948864019999L,BigInteger.Parse("666512175097575576007"),BigInteger.Parse("65311391306613542428799"),BigInteger.Parse("6399849835873029582446407"),BigInteger.Parse("627119972524250285537319199"),BigInteger.Parse("61451357457540654953074835207") };
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
public class A278438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278438Inst Instance=new A278438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278439
{
public static readonly long[] Value={ 1L,2L,5L,22L,105L,188L,258L,327L,663L,15425L,16654L,27848L,40324L,80328L,481263L,10213223L,10311233L,10313314L,10313315L,10313316L,10313317L,10313318L,10313319L,21322314L,21322315L,21322316L,21322317L,21322318L,21322319L,31123314L,31123315L,1123316L,31123317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278439Inst : IEnumerable<long>
{
public static readonly long[] Value=A278439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278439.Bytes);
public long this[int i]=>Value[i];

public static A278439Inst Instance=new A278439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278440
{
public static readonly long[] Value={ 22L,777L,4444L,68868L,200000L,303030L,333000L,333333L,555555L,660000L,660660L,666666L,700000L,2332200L,3131313L,4444400L,6060600L,7007000L,7700000L,9009790L,9656955L,9885585L,11517771L,14233221L,14331231L,14333110L,14411040L,15143331L,15233221L,15331231L,15333110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278440Inst : IEnumerable<long>
{
public static readonly long[] Value=A278440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278440.Bytes);
public long this[int i]=>Value[i];

public static A278440Inst Instance=new A278440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278441
{
public static readonly long[] Value={ 1L,2L,5L,10L,22L,26L,32L,62L,91L,330L,370L,519L,575L,710L,1060L,4055L,29377L,79554L,108690L,150320L,306440L,2510048L,3605570L,14233221L,14331231L,14333110L,14509410L,15143331L,15233221L,15331231L,15333110L,16143331L,16153331L,16233221L,16331231L,16333110L,17143331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278441Inst : IEnumerable<long>
{
public static readonly long[] Value=A278441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278441.Bytes);
public long this[int i]=>Value[i];

public static A278441Inst Instance=new A278441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278442
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,14L,16L,47L,68L,103L,127L,341L,523L,562L,1259L,2206L,3164L,3335L,5450L,7700L,7822L,8902L,23237L,36431L,39874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278442Inst : IEnumerable<long>
{
public static readonly long[] Value=A278442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278442.Bytes);
public long this[int i]=>Value[i];

public static A278442Inst Instance=new A278442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278443
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1101L,101L,110101L,101L,11110101L,10101L,1111010101L,10101L,111111010101L,1010101L,11111101010101L,1010101L,1111111101010101L,101010101L,111111110101010101L,101010101L,11111111110101010101UL,10101010101L,BigInteger.Parse("1111111111010101010101"),10101010101L };
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
public class A278443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278443Inst Instance=new A278443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278444
{
public static readonly ulong[] Value={ 1L,10L,100L,1011L,10100L,101011L,1010000L,10101111L,101010000L,1010101111L,10101000000L,101010111111L,1010101000000L,10101010111111L,101010100000000L,1010101011111111L,10101010100000000L,101010101011111111L,1010101010000000000L,10101010101111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278444Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278444.Bytes);
public ulong this[int i]=>Value[i];

public static A278444Inst Instance=new A278444Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278445
{
public static readonly long[] Value={ 1L,1L,1L,13L,5L,53L,5L,245L,21L,981L,21L,4053L,85L,16213L,85L,65365L,341L,261461L,341L,1047893L,1365L,4191573L,1365L,16774485L,5461L,67097941L,5461L,268424533L,21845L,1073698133L,21845L,4294923605L,87381L,17179694421L,87381L,68719301973L,349525L,274877207893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278445Inst : IEnumerable<long>
{
public static readonly long[] Value=A278445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278445.Bytes);
public long this[int i]=>Value[i];

public static A278445Inst Instance=new A278445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278446
{
public static readonly long[] Value={ 1L,2L,4L,11L,20L,43L,80L,175L,336L,687L,1344L,2751L,5440L,10943L,21760L,43775L,87296L,174847L,349184L,699391L,1397760L,2796543L,5591040L,11186175L,22368256L,44740607L,89473024L,178962431L,357908480L,715833343L,1431633920L,2863333375L,5726601216L,11453267967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278446Inst : IEnumerable<long>
{
public static readonly long[] Value=A278446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278446.Bytes);
public long this[int i]=>Value[i];

public static A278446Inst Instance=new A278446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278447
{
public static readonly long[] Value={ 2L,4L,3L,3L,8L,4L,4L,12L,5L,5L,16L,6L,4L,6L,10L,10L,7L,7L,24L,8L,8L,13L,13L,9L,8L,9L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278447Inst : IEnumerable<long>
{
public static readonly long[] Value=A278447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278447.Bytes);
public long this[int i]=>Value[i];

public static A278447Inst Instance=new A278447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278448
{
public static readonly long[] Value={ 3L,7L,13L,19L,25L,32L,39L,46L,53L,61L,69L,77L,85L,93L,102L,110L,119L,128L,136L,145L,154L,163L,173L,182L,191L,201L,210L,220L,229L,239L,248L,258L,268L,278L,288L,298L,307L,318L,328L,338L,348L,358L,368L,379L,389L,399L,410L,420L,430L,441L,451L,462L,473L,483L,494L,505L,515L,526L,537L,547L,558L,569L,580L,591L,602L,613L,624L,635L,646L,657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278448Inst : IEnumerable<long>
{
public static readonly long[] Value=A278448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278448.Bytes);
public long this[int i]=>Value[i];

public static A278448Inst Instance=new A278448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278449
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,16L,20L,24L,29L,33L,37L,42L,47L,51L,56L,61L,66L,71L,76L,81L,86L,92L,97L,102L,108L,113L,118L,124L,129L,135L,141L,146L,152L,158L,163L,169L,175L,181L,187L,193L,199L,205L,210L,216L,222L,229L,235L,241L,247L,253L,259L,265L,271L,278L,284L,290L,296L,303L,309L,315L,322L,328L,334L,341L,347L,354L,360L,367L,373L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278449Inst : IEnumerable<long>
{
public static readonly long[] Value=A278449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278449.Bytes);
public long this[int i]=>Value[i];

public static A278449Inst Instance=new A278449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278450
{
public static readonly long[] Value={ 0L,2L,4L,6L,9L,12L,14L,17L,21L,24L,27L,31L,34L,38L,41L,45L,49L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,101L,105L,109L,114L,118L,122L,127L,131L,135L,140L,144L,149L,153L,158L,162L,167L,172L,176L,181L,185L,190L,195L,200L,204L,209L,214L,218L,223L,228L,233L,238L,242L,247L,252L,257L,262L,267L,272L,277L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278450Inst : IEnumerable<long>
{
public static readonly long[] Value=A278450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278450.Bytes);
public long this[int i]=>Value[i];

public static A278450Inst Instance=new A278450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278451
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,14L,17L,19L,22L,25L,28L,31L,34L,37L,40L,43L,46L,49L,52L,56L,59L,62L,66L,69L,73L,76L,80L,83L,87L,90L,94L,98L,101L,105L,109L,112L,116L,120L,123L,127L,131L,135L,139L,143L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,231L,235L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278451Inst : IEnumerable<long>
{
public static readonly long[] Value=A278451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278451.Bytes);
public long this[int i]=>Value[i];

public static A278451Inst Instance=new A278451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278484
{
public static readonly long[] Value={ 0L,2L,6L,12L,18L,26L,38L,48L,62L,78L,90L,108L,132L,146L,180L,206L,222L,252L,288L,306L,348L,386L,398L,458L,480L,528L,566L,612L,648L,708L,762L,806L,842L,926L,948L,1008L,1092L,1110L,1188L,1260L,1320L,1358L,1470L,1482L,1578L,1692L,1718L,1806L,1898L,1932L,2022L,2160L,2186L,2268L,2366L,2478L,2532L,2702L,2738L,2798L,2966L,3018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278484Inst : IEnumerable<long>
{
public static readonly long[] Value=A278484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278484.Bytes);
public long this[int i]=>Value[i];

public static A278484Inst Instance=new A278484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278485
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,11L,12L,14L,18L,27L,30L,34L,38L,40L,47L,56L,58L,62L,70L,72L,73L,81L,86L,95L,97L,98L,106L,113L,115L,123L,131L,134L,139L,141L,153L,157L,159L,160L,162L,166L,167L,173L,176L,181L,183L,188L,195L,214L,216L,219L,223L,227L,233L,235L,244L,255L,259L,262L,270L,278L,286L,291L,296L,301L,307L,309L,315L,317L,326L,329L,346L,352L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278485Inst : IEnumerable<long>
{
public static readonly long[] Value=A278485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278485.Bytes);
public long this[int i]=>Value[i];

public static A278485Inst Instance=new A278485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278486
{
public static readonly long[] Value={ 3L,6L,8L,18L,24L,30L,32L,38L,48L,72L,80L,90L,102L,108L,128L,152L,158L,168L,192L,198L,200L,224L,240L,264L,270L,272L,294L,312L,318L,338L,360L,368L,384L,390L,422L,434L,440L,444L,450L,462L,464L,480L,488L,504L,510L,522L,542L,594L,600L,608L,620L,632L,648L,654L,678L,710L,720L,728L,752L,774L,798L,810L,824L,840L,858L,864L,882L,888L,912L,920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278486Inst : IEnumerable<long>
{
public static readonly long[] Value=A278486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278486.Bytes);
public long this[int i]=>Value[i];

public static A278486Inst Instance=new A278486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278487
{
public static readonly long[] Value={ 2L,5L,7L,17L,23L,29L,31L,37L,47L,71L,79L,89L,101L,107L,127L,151L,157L,167L,191L,197L,199L,223L,239L,263L,269L,271L,293L,311L,317L,337L,359L,367L,383L,389L,421L,433L,439L,443L,449L,461L,463L,479L,487L,503L,509L,521L,541L,593L,599L,607L,619L,631L,647L,653L,677L,709L,719L,727L,751L,773L,797L,809L,823L,839L,857L,863L,881L,887L,911L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278487Inst : IEnumerable<long>
{
public static readonly long[] Value=A278487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278487.Bytes);
public long this[int i]=>Value[i];

public static A278487Inst Instance=new A278487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278488
{
public static readonly long[] Value={ 0L,3L,6L,0L,3L,7L,0L,2L,5L,0L,3L,6L,0L,3L,6L,0L,3L,5L,0L,3L,5L,0L,3L,7L,0L,3L,6L,0L,3L,6L,0L,3L,5L,0L,2L,5L,0L,3L,6L,1L,4L,0L,3L,5L,0L,3L,6L,0L,3L,6L,0L,3L,7L,0L,3L,5L,0L,3L,6L,0L,2L,5L,0L,3L,5L,0L,3L,7L,2L,5L,0L,3L,6L,0L,3L,7L,2L,5L,0L,3L,5L,0L,3L,7L,1L,4L,0L,3L,5L,0L,3L,7L,0L,3L,5L,0L,3L,6L,0L,3L,5L,0L,3L,6L,0L,3L,6L,0L,2L,5L,0L,2L,5L,0L,3L,6L,0L,3L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278488Inst : IEnumerable<long>
{
public static readonly long[] Value=A278488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278488.Bytes);
public long this[int i]=>Value[i];

public static A278488Inst Instance=new A278488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278489
{
public static readonly long[] Value={ 0L,3L,6L,8L,9L,11L,15L,16L,18L,19L,21L,24L,27L,30L,32L,35L,38L,39L,40L,41L,43L,45L,48L,50L,51L,53L,54L,56L,59L,63L,64L,66L,67L,70L,71L,72L,73L,74L,75L,78L,80L,81L,83L,85L,87L,88L,90L,91L,93L,95L,96L,99L,102L,104L,105L,107L,108L,111L,112L,114L,115L,117L,120L,123L,126L,128L,129L,130L,131L,134L,135L,136L,137L,138L,139L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278489Inst : IEnumerable<long>
{
public static readonly long[] Value=A278489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278489.Bytes);
public long this[int i]=>Value[i];

public static A278489Inst Instance=new A278489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278490
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,12L,13L,14L,17L,20L,22L,23L,25L,26L,28L,29L,31L,33L,34L,36L,37L,42L,44L,46L,47L,49L,52L,55L,57L,58L,60L,61L,62L,65L,68L,69L,76L,77L,79L,82L,84L,86L,89L,92L,94L,97L,98L,100L,101L,103L,106L,109L,110L,113L,116L,118L,119L,121L,122L,124L,125L,127L,132L,133L,140L,141L,142L,145L,148L,150L,153L,154L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278490Inst : IEnumerable<long>
{
public static readonly long[] Value=A278490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278490.Bytes);
public long this[int i]=>Value[i];

public static A278490Inst Instance=new A278490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278491
{
public static readonly long[] Value={ 0L,3L,24L,35L,99L,120L,195L,323L,440L,483L,675L,728L,899L,1155L,1368L,1443L,1763L,1848L,2115L,2499L,2808L,2915L,3363L,3480L,3843L,4355L,4760L,4899L,5475L,5624L,6083L,6723L,7224L,7395L,8099L,8280L,8835L,9603L,10200L,10403L,11235L,11448L,12099L,12995L,13688L,13923L,14883L,15128L,15875L,16899L,17688L,17955L,19043L,19320L,20163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278491Inst : IEnumerable<long>
{
public static readonly long[] Value=A278491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278491.Bytes);
public long this[int i]=>Value[i];

public static A278491Inst Instance=new A278491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278492
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,3L,1L,5L,7L,7L,3L,1L,6L,9L,9L,7L,3L,1L,7L,11L,13L,13L,7L,3L,1L,8L,13L,15L,15L,13L,7L,3L,1L,9L,15L,19L,19L,19L,13L,7L,3L,1L,10L,17L,21L,25L,25L,19L,13L,7L,3L,1L,11L,19L,25L,27L,27L,27L,19L,13L,7L,3L,1L,12L,21L,27L,31L,31L,31L,27L,19L,13L,7L,3L,1L,13L,23L,31L,37L,39L,39L,39L,27L,19L,13L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278492Inst : IEnumerable<long>
{
public static readonly long[] Value=A278492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278492.Bytes);
public long this[int i]=>Value[i];

public static A278492Inst Instance=new A278492Inst();

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