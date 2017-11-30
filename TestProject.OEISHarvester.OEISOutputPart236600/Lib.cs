using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016513
{
public static readonly long[] Value={ 4L,2L,3L,1L,6L,9L,2L,1L,7L,1L,1L,3L,1L,9L,1L,7L,1L,1L,4L,1L,3L,2L,1L,1L,1L,42L,1L,2L,61L,1L,3L,1L,1L,6L,4L,3L,1L,1L,8L,3L,2L,1L,38L,11L,3L,43L,5L,2L,20L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,4L,1L,1L,9L,1L,1L,2L,1L,1L,4L,2L,1L,1L,44L,3L,1L,12L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016513Inst : IEnumerable<long>
{
public static readonly long[] Value=A016513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016513.Bytes);
public long this[int i]=>Value[i];

public static A016513Inst Instance=new A016513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016514
{
public static readonly long[] Value={ 4L,2L,4L,1L,40L,1L,7L,1L,16L,1L,2L,2L,1L,17L,1L,79L,1L,1L,18L,1L,1L,1L,2L,1L,4L,1L,4L,1L,5L,1L,1L,2L,11L,8L,2L,1L,4L,22L,6L,2L,1L,2L,14L,8L,6L,5L,1L,1L,13L,2L,1L,3L,13L,2L,4L,2L,2L,1L,4L,1L,1L,1L,3L,1L,2L,1L,1L,1L,10L,1L,17L,4L,7L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016514Inst : IEnumerable<long>
{
public static readonly long[] Value=A016514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016514.Bytes);
public long this[int i]=>Value[i];

public static A016514Inst Instance=new A016514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016515
{
public static readonly long[] Value={ 4L,2L,6L,1L,4L,1L,131L,1L,80L,1L,3L,53L,5L,1L,6L,1L,1L,2L,6L,4L,3L,2L,20L,1L,1L,1L,16L,1L,16L,1L,2L,1L,3L,1L,2L,4L,7L,1L,4L,9L,1L,37L,1L,1L,1L,20L,3L,19L,1L,31L,3L,1L,2L,1L,15L,1L,2L,1L,2L,1L,4L,743L,4L,1L,2L,4L,1L,1L,3L,1L,2L,1L,2L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016515Inst : IEnumerable<long>
{
public static readonly long[] Value=A016515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016515.Bytes);
public long this[int i]=>Value[i];

public static A016515Inst Instance=new A016515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016516
{
public static readonly long[] Value={ 4L,2L,10L,1L,1L,7L,1L,1L,6L,4L,18L,1L,4L,37L,1L,1L,3L,26L,1L,31L,2L,4L,18L,1L,2L,1L,3L,1L,8L,1L,4L,2L,1L,2L,7L,11L,2L,2L,1L,3L,1L,1L,1L,3L,1L,12L,2L,7L,3L,2L,3L,3L,1L,1L,22L,2L,4L,1L,1L,4L,5L,7L,3L,13L,2L,1L,4L,1L,2L,354L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016516Inst : IEnumerable<long>
{
public static readonly long[] Value=A016516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016516.Bytes);
public long this[int i]=>Value[i];

public static A016516Inst Instance=new A016516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016517
{
public static readonly long[] Value={ 4L,2L,21L,1L,1L,21183L,2L,1L,1L,1L,90L,1L,1L,4L,13L,1L,1L,1L,2L,3L,2L,1L,113L,1L,3L,3L,9L,8L,1L,3L,1L,1L,8L,1L,2L,1L,1L,8L,1L,8L,5L,3L,1L,6L,1L,6L,3L,3L,3L,2L,1L,10L,1L,3L,2L,8L,1L,24L,1L,11L,5L,5L,1L,1L,1L,1L,8L,2L,2L,1L,15L,5L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016517Inst : IEnumerable<long>
{
public static readonly long[] Value=A016517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016517.Bytes);
public long this[int i]=>Value[i];

public static A016517Inst Instance=new A016517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016518
{
public static readonly long[] Value={ 4L,2L,1313L,96L,5L,2L,2L,1L,26L,1L,38L,2L,2L,15L,1L,2L,2L,1L,1L,1L,4L,2L,2L,31L,1L,1L,1L,22L,2L,1L,18L,4L,2L,4L,1L,2L,5L,1L,15L,4L,1L,2L,2L,2L,3L,1L,1L,2L,2L,36L,1L,10L,1L,1L,1L,1L,29L,1L,7L,1L,4L,1L,1L,3L,7L,3L,6L,1L,1L,1L,1L,12L,17L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016518Inst : IEnumerable<long>
{
public static readonly long[] Value=A016518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016518.Bytes);
public long this[int i]=>Value[i];

public static A016518Inst Instance=new A016518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016519
{
public static readonly long[] Value={ 4L,1L,1L,22L,1L,1L,11L,4L,3L,1L,8L,1L,1L,1L,8L,1L,3L,4L,2L,1L,5L,1L,1L,1L,2L,2L,1L,21L,1L,1L,1L,1L,3L,7L,3L,1L,1L,1L,1L,5L,12L,1L,138L,1L,1L,106L,5L,1L,1L,3L,33L,9L,1L,2L,4L,15L,5L,1L,1L,1L,1L,4L,2L,3L,1L,3L,3L,1L,5L,2L,2L,1L,4L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016519Inst : IEnumerable<long>
{
public static readonly long[] Value=A016519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016519.Bytes);
public long this[int i]=>Value[i];

public static A016519Inst Instance=new A016519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016520
{
public static readonly long[] Value={ 4L,1L,1L,10L,1L,37L,3L,6L,1L,1L,2L,1L,1L,1L,1L,2L,3L,8L,1L,20L,1L,71L,6L,1L,82L,4L,4L,2L,13L,1L,20L,1L,6L,1L,1L,1L,3L,1L,2L,2L,4L,1L,2L,1L,4L,7L,2L,2L,12L,1L,4L,7L,1L,1L,1L,1L,1L,1L,1L,2L,5L,1L,1L,1L,1L,1L,8L,1L,5L,4L,1L,1L,4L,3L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016520Inst : IEnumerable<long>
{
public static readonly long[] Value=A016520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016520.Bytes);
public long this[int i]=>Value[i];

public static A016520Inst Instance=new A016520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016521
{
public static readonly long[] Value={ 4L,1L,1L,7L,5L,1L,12L,598L,1L,3L,372L,10L,100L,1L,8L,25L,2L,1L,1L,4L,1L,4L,1L,2L,3L,2L,1L,3L,1L,1L,1L,1L,1L,12L,1L,1L,3L,2L,77L,4L,4L,10L,1L,1L,2L,1L,3L,9L,1L,10L,6L,5L,7L,1L,2L,3L,1L,8L,1L,1L,1L,12L,2L,2L,2L,1L,24L,2L,19L,1L,4L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016521Inst : IEnumerable<long>
{
public static readonly long[] Value=A016521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016521.Bytes);
public long this[int i]=>Value[i];

public static A016521Inst Instance=new A016521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016522
{
public static readonly long[] Value={ 4L,1L,1L,5L,3L,1L,1L,1L,4L,2L,2L,36L,2L,4L,3L,1L,12L,4L,1L,1L,2L,1L,1L,2L,2L,2L,1L,5L,4L,1L,1L,2L,1L,14L,2L,3L,5L,3L,2L,1L,25L,2L,2L,1L,1L,6L,4L,22L,10L,1L,8L,1L,2L,1L,1L,1L,1L,2L,9L,1L,1L,5L,2L,4L,1L,2L,5L,2L,9L,10L,2L,1L,1L,4L,1L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016522Inst : IEnumerable<long>
{
public static readonly long[] Value=A016522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016522.Bytes);
public long this[int i]=>Value[i];

public static A016522Inst Instance=new A016522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016523
{
public static readonly long[] Value={ 4L,1L,1L,4L,7L,7L,1L,1L,3L,1L,1L,4L,2L,7L,25L,1L,1L,5L,1L,1L,1L,58L,1L,7L,1L,1L,6L,1L,39L,1L,3L,11L,2L,2L,1L,3L,1L,1L,41L,31L,4L,1L,3L,1L,1L,1L,5L,12L,1L,3L,1L,2L,2L,26L,1L,3L,6L,2L,1L,1L,1L,1L,1L,1L,9L,5L,1L,1L,1L,5L,2L,1L,22L,2L,2L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016523Inst : IEnumerable<long>
{
public static readonly long[] Value=A016523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016523.Bytes);
public long this[int i]=>Value[i];

public static A016523Inst Instance=new A016523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016524
{
public static readonly long[] Value={ 4L,1L,1L,3L,2L,1L,1L,2L,11L,1L,1L,53L,2L,7L,1L,1L,6L,3L,1L,1L,5L,15L,7L,1L,1L,1L,6L,1L,3L,1L,1L,1L,2L,3L,1L,3L,1L,53L,1L,2L,2L,2L,8L,1L,1L,9L,3L,1L,1L,26L,1L,28L,3L,95L,4L,11L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,4L,19L,1L,6L,4L,1L,1L,1L,1L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016524Inst : IEnumerable<long>
{
public static readonly long[] Value=A016524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016524.Bytes);
public long this[int i]=>Value[i];

public static A016524Inst Instance=new A016524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016525
{
public static readonly long[] Value={ 4L,1L,1L,2L,1L,5L,1L,1L,78L,1L,4L,26L,2L,4L,2L,1L,1L,4L,21L,2L,2L,1L,1L,1L,1L,1L,36L,1L,12L,8L,2L,1L,1L,2L,12L,1L,2L,3L,4L,1L,23L,1L,1L,2L,3L,11L,1L,8L,1L,3L,1L,2L,1L,1L,1L,3L,8L,11L,6L,4L,1L,2L,1L,3L,3L,1L,4L,1L,4L,1L,28L,1L,16L,1L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016525Inst : IEnumerable<long>
{
public static readonly long[] Value=A016525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016525.Bytes);
public long this[int i]=>Value[i];

public static A016525Inst Instance=new A016525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016622
{
public static readonly long[] Value={ 3L,8L,1L,7L,7L,1L,2L,3L,2L,5L,9L,5L,6L,9L,0L,4L,7L,3L,1L,7L,4L,1L,6L,0L,8L,0L,6L,3L,5L,5L,0L,3L,2L,1L,7L,6L,6L,3L,6L,6L,8L,5L,2L,5L,3L,9L,9L,8L,1L,8L,1L,3L,0L,5L,0L,7L,5L,7L,7L,5L,5L,6L,5L,1L,1L,0L,7L,6L,5L,0L,9L,0L,8L,1L,0L,6L,7L,8L,4L,7L,3L,1L,5L,8L,1L,3L,6L,9L,8L,3L,5L,0L,3L,1L,9L,4L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016622Inst : IEnumerable<long>
{
public static readonly long[] Value=A016622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016622.Bytes);
public long this[int i]=>Value[i];

public static A016622Inst Instance=new A016622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016623
{
public static readonly long[] Value={ 3L,8L,3L,9L,4L,5L,2L,3L,1L,2L,5L,9L,3L,3L,1L,0L,6L,2L,7L,9L,0L,7L,1L,7L,7L,4L,4L,0L,0L,0L,6L,7L,0L,6L,3L,4L,7L,0L,2L,1L,9L,2L,9L,3L,5L,3L,9L,4L,3L,0L,8L,6L,1L,6L,9L,3L,7L,0L,7L,3L,2L,3L,9L,6L,6L,1L,9L,0L,8L,2L,0L,8L,7L,8L,4L,6L,4L,6L,5L,4L,8L,3L,4L,8L,1L,6L,1L,7L,2L,5L,9L,1L,5L,3L,4L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016623Inst : IEnumerable<long>
{
public static readonly long[] Value=A016623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016623.Bytes);
public long this[int i]=>Value[i];

public static A016623Inst Instance=new A016623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016624
{
public static readonly long[] Value={ 3L,8L,6L,0L,7L,2L,9L,7L,1L,1L,0L,4L,0L,5L,9L,5L,5L,2L,5L,1L,9L,2L,5L,5L,4L,6L,4L,3L,6L,5L,5L,8L,6L,4L,6L,0L,8L,6L,8L,7L,4L,8L,0L,4L,8L,1L,2L,0L,7L,3L,9L,1L,2L,8L,6L,3L,2L,9L,9L,2L,8L,1L,1L,8L,3L,9L,0L,0L,7L,8L,0L,6L,7L,8L,0L,2L,1L,6L,0L,3L,3L,7L,7L,3L,8L,4L,2L,8L,9L,3L,4L,9L,1L,2L,5L,0L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016624Inst : IEnumerable<long>
{
public static readonly long[] Value=A016624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016624.Bytes);
public long this[int i]=>Value[i];

public static A016624Inst Instance=new A016624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016625
{
public static readonly long[] Value={ 3L,8L,8L,1L,5L,6L,3L,7L,9L,7L,9L,4L,3L,4L,3L,7L,5L,1L,2L,6L,9L,9L,4L,8L,9L,5L,0L,0L,2L,4L,5L,7L,8L,5L,1L,4L,5L,7L,3L,3L,4L,1L,4L,7L,6L,8L,2L,9L,8L,5L,2L,6L,1L,0L,1L,8L,5L,5L,5L,5L,4L,3L,5L,9L,2L,6L,6L,7L,8L,3L,6L,6L,9L,8L,0L,8L,4L,9L,2L,4L,0L,9L,7L,3L,6L,4L,1L,9L,4L,1L,8L,0L,3L,7L,8L,5L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016625Inst : IEnumerable<long>
{
public static readonly long[] Value=A016625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016625.Bytes);
public long this[int i]=>Value[i];

public static A016625Inst Instance=new A016625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016626
{
public static readonly long[] Value={ 3L,9L,0L,1L,9L,7L,2L,6L,6L,9L,5L,7L,4L,6L,4L,4L,6L,1L,7L,4L,3L,5L,2L,0L,1L,9L,3L,0L,3L,5L,2L,0L,0L,4L,1L,4L,1L,0L,4L,1L,1L,8L,7L,8L,3L,5L,2L,2L,2L,6L,6L,0L,8L,2L,4L,5L,6L,7L,2L,7L,6L,3L,6L,6L,9L,1L,2L,1L,6L,8L,5L,8L,8L,3L,8L,0L,7L,5L,9L,9L,3L,1L,2L,1L,6L,4L,2L,2L,8L,9L,0L,6L,3L,3L,6L,8L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016626Inst : IEnumerable<long>
{
public static readonly long[] Value=A016626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016626.Bytes);
public long this[int i]=>Value[i];

public static A016626Inst Instance=new A016626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016627
{
public static readonly long[] Value={ 1L,3L,8L,6L,2L,9L,4L,3L,6L,1L,1L,1L,9L,8L,9L,0L,6L,1L,8L,8L,3L,4L,4L,6L,4L,2L,4L,2L,9L,1L,6L,3L,5L,3L,1L,3L,6L,1L,5L,1L,0L,0L,0L,2L,6L,8L,7L,2L,0L,5L,1L,0L,5L,0L,8L,2L,4L,1L,3L,6L,0L,0L,1L,8L,9L,8L,6L,7L,8L,7L,2L,4L,3L,9L,3L,9L,3L,8L,9L,4L,3L,1L,2L,1L,1L,7L,2L,6L,6L,5L,3L,9L,9L,2L,8L,3L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016627Inst : IEnumerable<long>
{
public static readonly long[] Value=A016627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016627.Bytes);
public long this[int i]=>Value[i];

public static A016627Inst Instance=new A016627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016628
{
public static readonly long[] Value={ 1L,6L,0L,9L,4L,3L,7L,9L,1L,2L,4L,3L,4L,1L,0L,0L,3L,7L,4L,6L,0L,0L,7L,5L,9L,3L,3L,3L,2L,2L,6L,1L,8L,7L,6L,3L,9L,5L,2L,5L,6L,0L,1L,3L,5L,4L,2L,6L,8L,5L,1L,7L,7L,2L,1L,9L,1L,2L,6L,4L,7L,8L,9L,1L,4L,7L,4L,1L,7L,8L,9L,8L,7L,7L,0L,7L,6L,5L,7L,7L,6L,4L,6L,3L,0L,1L,3L,3L,8L,7L,8L,0L,9L,3L,1L,7L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016628Inst : IEnumerable<long>
{
public static readonly long[] Value=A016628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016628.Bytes);
public long this[int i]=>Value[i];

public static A016628Inst Instance=new A016628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016629
{
public static readonly long[] Value={ 1L,7L,9L,1L,7L,5L,9L,4L,6L,9L,2L,2L,8L,0L,5L,5L,0L,0L,0L,8L,1L,2L,4L,7L,7L,3L,5L,8L,3L,8L,0L,7L,0L,2L,2L,7L,2L,7L,2L,2L,9L,9L,0L,6L,9L,2L,1L,8L,3L,0L,0L,4L,7L,0L,5L,8L,5L,5L,3L,7L,4L,3L,4L,3L,1L,3L,0L,8L,8L,7L,9L,1L,5L,1L,8L,8L,3L,0L,3L,6L,8L,2L,4L,7L,9L,4L,7L,9L,0L,8L,1L,8L,1L,0L,1L,5L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016629Inst : IEnumerable<long>
{
public static readonly long[] Value=A016629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016629.Bytes);
public long this[int i]=>Value[i];

public static A016629Inst Instance=new A016629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016630
{
public static readonly long[] Value={ 1L,9L,4L,5L,9L,1L,0L,1L,4L,9L,0L,5L,5L,3L,1L,3L,3L,0L,5L,1L,0L,5L,3L,5L,2L,7L,4L,3L,4L,4L,3L,1L,7L,9L,7L,2L,9L,6L,3L,7L,0L,8L,4L,7L,2L,9L,5L,8L,1L,8L,6L,1L,1L,8L,8L,4L,5L,9L,3L,9L,0L,1L,4L,9L,9L,3L,7L,5L,7L,9L,8L,6L,2L,7L,5L,2L,0L,6L,9L,2L,6L,7L,7L,8L,7L,6L,5L,8L,4L,9L,8L,5L,8L,7L,8L,7L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016630Inst : IEnumerable<long>
{
public static readonly long[] Value=A016630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016630.Bytes);
public long this[int i]=>Value[i];

public static A016630Inst Instance=new A016630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016631
{
public static readonly long[] Value={ 2L,0L,7L,9L,4L,4L,1L,5L,4L,1L,6L,7L,9L,8L,3L,5L,9L,2L,8L,2L,5L,1L,6L,9L,6L,3L,6L,4L,3L,7L,4L,5L,2L,9L,7L,0L,4L,2L,2L,6L,5L,0L,0L,4L,0L,3L,0L,8L,0L,7L,6L,5L,7L,6L,2L,3L,6L,2L,0L,4L,0L,0L,2L,8L,4L,8L,0L,1L,8L,0L,8L,6L,5L,9L,0L,9L,0L,8L,4L,1L,4L,6L,8L,1L,7L,5L,8L,9L,9L,8L,0L,9L,8L,9L,2L,5L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016631Inst : IEnumerable<long>
{
public static readonly long[] Value=A016631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016631.Bytes);
public long this[int i]=>Value[i];

public static A016631Inst Instance=new A016631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016632
{
public static readonly long[] Value={ 2L,1L,9L,7L,2L,2L,4L,5L,7L,7L,3L,3L,6L,2L,1L,9L,3L,8L,2L,7L,9L,0L,4L,9L,0L,4L,7L,3L,8L,4L,5L,0L,5L,1L,4L,0L,9L,2L,9L,4L,9L,8L,1L,1L,1L,5L,6L,4L,5L,4L,9L,8L,9L,0L,3L,4L,6L,9L,3L,8L,8L,6L,6L,7L,2L,7L,4L,9L,8L,8L,5L,8L,6L,4L,3L,7L,2L,1L,7L,9L,3L,3L,7L,4L,7L,2L,3L,1L,5L,0L,9L,6L,2L,7L,4L,6L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016632Inst : IEnumerable<long>
{
public static readonly long[] Value=A016632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016632.Bytes);
public long this[int i]=>Value[i];

public static A016632Inst Instance=new A016632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016633
{
public static readonly long[] Value={ 1L,25L,447L,6989L,101759L,1417941L,19180519L,253983853L,3309800367L,42599540357L,542895780791L,6863463633117L,86197420501375L,1076563471968373L,13382900349107463L,165700329729679181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016633Inst : IEnumerable<long>
{
public static readonly long[] Value=A016633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016633.Bytes);
public long this[int i]=>Value[i];

public static A016633Inst Instance=new A016633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016634
{
public static readonly long[] Value={ 2L,3L,9L,7L,8L,9L,5L,2L,7L,2L,7L,9L,8L,3L,7L,0L,5L,4L,4L,0L,6L,1L,9L,4L,3L,5L,7L,7L,9L,6L,5L,1L,2L,9L,2L,9L,9L,8L,2L,1L,7L,0L,6L,8L,5L,3L,9L,3L,7L,4L,1L,7L,1L,7L,5L,2L,1L,8L,5L,6L,7L,7L,0L,9L,1L,3L,0L,5L,7L,3L,6L,2L,3L,9L,1L,3L,2L,3L,6L,7L,1L,3L,0L,7L,5L,0L,5L,4L,7L,0L,8L,0L,0L,2L,6L,3L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016634Inst : IEnumerable<long>
{
public static readonly long[] Value=A016634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016634.Bytes);
public long this[int i]=>Value[i];

public static A016634Inst Instance=new A016634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016635
{
public static readonly long[] Value={ 2L,4L,8L,4L,9L,0L,6L,6L,4L,9L,7L,8L,8L,0L,0L,0L,3L,1L,0L,2L,2L,9L,7L,0L,9L,4L,7L,9L,8L,3L,8L,8L,7L,8L,8L,4L,0L,7L,9L,8L,4L,9L,0L,8L,2L,6L,5L,4L,3L,2L,5L,9L,9L,5L,9L,9L,7L,6L,0L,5L,4L,3L,5L,2L,6L,2L,4L,2L,8L,1L,5L,3L,7L,1L,5L,7L,9L,9L,8L,3L,9L,8L,0L,8L,5L,3L,4L,2L,4L,0L,8L,8L,0L,6L,5L,6L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016635Inst : IEnumerable<long>
{
public static readonly long[] Value=A016635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016635.Bytes);
public long this[int i]=>Value[i];

public static A016635Inst Instance=new A016635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016636
{
public static readonly long[] Value={ 2L,5L,6L,4L,9L,4L,9L,3L,5L,7L,4L,6L,1L,5L,3L,6L,7L,3L,6L,0L,5L,3L,4L,8L,7L,4L,4L,1L,5L,6L,5L,3L,1L,8L,6L,0L,4L,8L,0L,5L,2L,6L,7L,9L,4L,4L,7L,6L,0L,2L,0L,7L,1L,1L,6L,4L,1L,9L,0L,4L,5L,5L,1L,0L,6L,6L,3L,4L,6L,4L,6L,6L,7L,3L,2L,4L,4L,1L,0L,1L,7L,9L,3L,9L,9L,5L,7L,4L,6L,6L,3L,4L,4L,0L,4L,8L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016636Inst : IEnumerable<long>
{
public static readonly long[] Value=A016636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016636.Bytes);
public long this[int i]=>Value[i];

public static A016636Inst Instance=new A016636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016637
{
public static readonly long[] Value={ 2L,6L,3L,9L,0L,5L,7L,3L,2L,9L,6L,1L,5L,2L,5L,8L,6L,1L,4L,5L,2L,2L,5L,8L,4L,8L,6L,4L,9L,0L,1L,3L,5L,6L,2L,9L,7L,7L,1L,2L,5L,8L,4L,8L,6L,3L,9L,4L,2L,1L,1L,6L,4L,4L,2L,5L,8L,0L,0L,7L,0L,1L,5L,9L,4L,3L,0L,9L,7L,3L,4L,8L,4L,7L,2L,1L,7L,6L,3L,9L,8L,3L,3L,9L,3L,5L,2L,1L,8L,2L,5L,5L,8L,4L,2L,9L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016637Inst : IEnumerable<long>
{
public static readonly long[] Value=A016637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016637.Bytes);
public long this[int i]=>Value[i];

public static A016637Inst Instance=new A016637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016670
{
public static readonly long[] Value={ 3L,8L,5L,0L,1L,4L,7L,6L,0L,1L,7L,1L,0L,0L,5L,8L,5L,8L,6L,8L,2L,0L,9L,5L,0L,6L,6L,9L,7L,7L,2L,1L,7L,3L,7L,0L,8L,8L,9L,6L,0L,5L,0L,5L,0L,2L,0L,2L,0L,2L,2L,4L,0L,3L,3L,2L,0L,0L,5L,0L,8L,3L,4L,6L,8L,0L,6L,8L,1L,8L,2L,1L,3L,5L,0L,5L,8L,0L,1L,0L,7L,2L,6L,1L,0L,6L,8L,9L,7L,5L,3L,4L,3L,4L,7L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016670Inst : IEnumerable<long>
{
public static readonly long[] Value=A016670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016670.Bytes);
public long this[int i]=>Value[i];

public static A016670Inst Instance=new A016670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016671
{
public static readonly long[] Value={ 3L,8L,7L,1L,2L,0L,1L,0L,1L,0L,9L,0L,7L,8L,9L,0L,9L,2L,9L,0L,6L,4L,1L,7L,3L,7L,2L,2L,7L,5L,5L,2L,3L,1L,9L,7L,6L,9L,4L,9L,4L,9L,1L,0L,9L,5L,2L,6L,3L,7L,7L,0L,4L,6L,8L,2L,1L,7L,4L,1L,4L,3L,7L,1L,6L,1L,1L,0L,6L,8L,7L,8L,1L,0L,9L,7L,3L,8L,7L,8L,2L,9L,2L,9L,7L,0L,6L,9L,0L,6L,2L,7L,9L,9L,4L,0L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016671Inst : IEnumerable<long>
{
public static readonly long[] Value=A016671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016671.Bytes);
public long this[int i]=>Value[i];

public static A016671Inst Instance=new A016671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016672
{
public static readonly long[] Value={ 3L,8L,9L,1L,8L,2L,0L,2L,9L,8L,1L,1L,0L,6L,2L,6L,6L,1L,0L,2L,1L,0L,7L,0L,5L,4L,8L,6L,8L,8L,6L,3L,5L,9L,4L,5L,9L,2L,7L,4L,1L,6L,9L,4L,5L,9L,1L,6L,3L,7L,2L,2L,3L,7L,6L,9L,1L,8L,7L,8L,0L,2L,9L,9L,8L,7L,5L,1L,5L,9L,7L,2L,5L,5L,0L,4L,1L,3L,8L,5L,3L,5L,5L,7L,5L,3L,1L,6L,9L,9L,7L,1L,7L,5L,7L,4L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016672Inst : IEnumerable<long>
{
public static readonly long[] Value=A016672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016672.Bytes);
public long this[int i]=>Value[i];

public static A016672Inst Instance=new A016672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016673
{
public static readonly long[] Value={ 3L,9L,1L,2L,0L,2L,3L,0L,0L,5L,4L,2L,8L,1L,4L,6L,0L,5L,8L,6L,1L,8L,7L,5L,0L,7L,8L,7L,9L,1L,0L,5L,5L,1L,8L,4L,7L,1L,2L,6L,7L,0L,2L,8L,4L,2L,8L,9L,7L,2L,9L,0L,6L,9L,7L,9L,4L,5L,9L,7L,5L,7L,9L,2L,4L,4L,1L,7L,5L,1L,5L,9L,7L,3L,8L,5L,0L,1L,0L,2L,4L,4L,8L,6L,6L,1L,3L,1L,0L,8L,3L,1L,8L,2L,7L,7L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016673Inst : IEnumerable<long>
{
public static readonly long[] Value=A016673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016673.Bytes);
public long this[int i]=>Value[i];

public static A016673Inst Instance=new A016673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016674
{
public static readonly long[] Value={ 3L,9L,3L,1L,8L,2L,5L,6L,3L,2L,7L,2L,4L,3L,2L,5L,7L,7L,1L,6L,4L,4L,7L,7L,9L,8L,5L,4L,7L,9L,5L,6L,5L,2L,2L,4L,0L,2L,3L,5L,6L,9L,3L,5L,7L,0L,4L,0L,8L,4L,9L,4L,2L,3L,9L,0L,3L,1L,9L,3L,2L,0L,7L,1L,5L,1L,9L,7L,8L,6L,8L,6L,9L,0L,1L,9L,5L,4L,0L,2L,4L,7L,7L,8L,5L,7L,1L,0L,6L,2L,2L,8L,5L,1L,2L,3L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016674Inst : IEnumerable<long>
{
public static readonly long[] Value=A016674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016674.Bytes);
public long this[int i]=>Value[i];

public static A016674Inst Instance=new A016674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016675
{
public static readonly long[] Value={ 3L,9L,5L,1L,2L,4L,3L,7L,1L,8L,5L,8L,1L,4L,2L,7L,3L,5L,4L,8L,8L,7L,9L,5L,1L,6L,8L,4L,4L,8L,1L,6L,7L,1L,7L,4L,0L,9L,5L,6L,2L,6L,8L,2L,1L,3L,4L,8L,0L,7L,1L,7L,6L,2L,4L,6L,6L,0L,4L,0L,5L,5L,2L,9L,6L,5L,0L,2L,5L,1L,9L,1L,1L,2L,6L,3L,7L,9L,9L,6L,1L,0L,6L,1L,1L,3L,0L,1L,3L,1L,7L,4L,3L,3L,3L,2L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016675Inst : IEnumerable<long>
{
public static readonly long[] Value=A016675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016675.Bytes);
public long this[int i]=>Value[i];

public static A016675Inst Instance=new A016675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016676
{
public static readonly long[] Value={ 3L,9L,7L,0L,2L,9L,1L,9L,1L,3L,5L,5L,2L,1L,2L,1L,8L,3L,4L,1L,4L,4L,4L,6L,9L,1L,3L,9L,0L,2L,9L,0L,5L,7L,7L,7L,0L,3L,5L,9L,9L,7L,7L,7L,5L,2L,9L,1L,1L,2L,1L,7L,6L,0L,3L,0L,4L,8L,1L,2L,9L,4L,7L,0L,0L,1L,8L,0L,0L,4L,6L,3L,3L,9L,4L,3L,4L,8L,9L,8L,5L,8L,5L,3L,4L,6L,5L,9L,9L,4L,4L,4L,8L,5L,9L,2L,1L,2L,2L,9L,8L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016676Inst : IEnumerable<long>
{
public static readonly long[] Value=A016676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016676.Bytes);
public long this[int i]=>Value[i];

public static A016676Inst Instance=new A016676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016677
{
public static readonly long[] Value={ 3L,9L,8L,8L,9L,8L,4L,0L,4L,6L,5L,6L,4L,2L,7L,4L,3L,8L,3L,6L,0L,2L,9L,6L,7L,8L,3L,2L,2L,2L,5L,7L,5L,3L,6L,8L,2L,0L,1L,7L,9L,7L,1L,8L,0L,7L,8L,2L,8L,5L,0L,3L,6L,0L,9L,3L,2L,4L,7L,6L,3L,0L,1L,0L,4L,0L,5L,8L,7L,6L,5L,0L,1L,6L,2L,5L,5L,2L,1L,6L,1L,6L,2L,2L,6L,7L,1L,0L,5L,9L,1L,4L,3L,7L,6L,1L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016677Inst : IEnumerable<long>
{
public static readonly long[] Value=A016677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016677.Bytes);
public long this[int i]=>Value[i];

public static A016677Inst Instance=new A016677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016678
{
public static readonly long[] Value={ 4L,0L,0L,7L,3L,3L,3L,1L,8L,5L,2L,3L,2L,4L,7L,0L,9L,1L,8L,6L,6L,2L,7L,0L,2L,9L,1L,1L,1L,9L,1L,3L,1L,6L,9L,3L,9L,3L,4L,7L,3L,0L,8L,2L,0L,8L,2L,0L,5L,9L,3L,4L,8L,9L,7L,1L,3L,1L,2L,1L,5L,6L,0L,0L,6L,0L,4L,7L,5L,2L,6L,1L,1L,6L,2L,0L,8L,9L,4L,4L,7L,7L,7L,0L,5L,1L,8L,8L,5L,8L,6L,0L,9L,5L,8L,1L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016678Inst : IEnumerable<long>
{
public static readonly long[] Value=A016678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016678.Bytes);
public long this[int i]=>Value[i];

public static A016678Inst Instance=new A016678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016679
{
public static readonly long[] Value={ 4L,0L,2L,5L,3L,5L,1L,6L,9L,0L,7L,3L,5L,1L,4L,9L,2L,3L,3L,3L,5L,7L,0L,4L,9L,1L,0L,7L,8L,1L,7L,7L,0L,9L,4L,3L,3L,8L,6L,3L,5L,8L,5L,1L,3L,2L,6L,6L,2L,6L,2L,6L,9L,5L,0L,8L,2L,1L,4L,3L,0L,1L,7L,8L,4L,1L,7L,7L,6L,0L,7L,2L,8L,6L,6L,1L,1L,5L,3L,4L,1L,4L,6L,0L,5L,2L,4L,8L,4L,7L,9L,5L,7L,7L,1L,2L,7L,5L,8L,9L,6L,1L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016679Inst : IEnumerable<long>
{
public static readonly long[] Value=A016679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016679.Bytes);
public long this[int i]=>Value[i];

public static A016679Inst Instance=new A016679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016680
{
public static readonly long[] Value={ 4L,0L,4L,3L,0L,5L,1L,2L,6L,7L,8L,3L,4L,5L,5L,0L,1L,5L,1L,4L,0L,4L,2L,7L,2L,6L,6L,8L,8L,1L,0L,3L,7L,9L,2L,4L,1L,8L,8L,4L,8L,6L,9L,8L,1L,9L,1L,2L,1L,8L,7L,8L,2L,7L,0L,2L,7L,2L,6L,5L,4L,5L,7L,0L,0L,4L,6L,7L,8L,6L,9L,9L,5L,2L,8L,2L,8L,0L,6L,2L,5L,5L,5L,8L,7L,7L,7L,4L,1L,3L,8L,6L,2L,9L,4L,7L,1L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016680Inst : IEnumerable<long>
{
public static readonly long[] Value=A016680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016680.Bytes);
public long this[int i]=>Value[i];

public static A016680Inst Instance=new A016680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016681
{
public static readonly long[] Value={ 4L,0L,6L,0L,4L,4L,3L,0L,1L,0L,5L,4L,6L,4L,1L,9L,3L,3L,6L,6L,0L,0L,5L,0L,4L,1L,5L,3L,8L,2L,0L,0L,8L,8L,1L,7L,3L,5L,7L,0L,0L,1L,3L,0L,4L,8L,2L,8L,2L,9L,9L,9L,3L,3L,3L,0L,4L,2L,3L,5L,0L,3L,6L,1L,1L,3L,6L,1L,7L,4L,4L,0L,3L,1L,0L,7L,5L,4L,7L,0L,4L,8L,8L,9L,9L,2L,3L,0L,4L,4L,1L,8L,1L,4L,2L,7L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016681Inst : IEnumerable<long>
{
public static readonly long[] Value=A016681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016681.Bytes);
public long this[int i]=>Value[i];

public static A016681Inst Instance=new A016681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016682
{
public static readonly long[] Value={ 4L,0L,7L,7L,5L,3L,7L,4L,4L,3L,9L,0L,5L,7L,1L,9L,4L,5L,0L,6L,1L,6L,0L,5L,0L,3L,7L,3L,7L,1L,9L,6L,9L,7L,6L,2L,4L,0L,6L,3L,3L,4L,6L,7L,8L,9L,3L,3L,0L,4L,5L,4L,5L,2L,9L,5L,1L,2L,0L,3L,6L,6L,9L,7L,0L,5L,9L,2L,0L,0L,1L,1L,4L,2L,6L,5L,4L,2L,7L,4L,7L,7L,3L,5L,9L,3L,3L,9L,9L,5L,9L,8L,0L,2L,6L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016682Inst : IEnumerable<long>
{
public static readonly long[] Value=A016682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016682.Bytes);
public long this[int i]=>Value[i];

public static A016682Inst Instance=new A016682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016683
{
public static readonly long[] Value={ 4L,0L,9L,4L,3L,4L,4L,5L,6L,2L,2L,2L,2L,1L,0L,0L,6L,8L,4L,8L,3L,0L,4L,6L,8L,8L,1L,3L,0L,6L,5L,0L,6L,6L,4L,8L,0L,3L,2L,4L,0L,9L,2L,1L,8L,0L,8L,1L,1L,7L,7L,7L,6L,8L,1L,8L,8L,8L,7L,0L,2L,2L,4L,4L,0L,9L,8L,4L,6L,0L,5L,2L,4L,8L,6L,5L,6L,5L,6L,1L,6L,2L,7L,1L,5L,4L,7L,6L,2L,8L,6L,8L,9L,9L,7L,4L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016683Inst : IEnumerable<long>
{
public static readonly long[] Value=A016683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016683.Bytes);
public long this[int i]=>Value[i];

public static A016683Inst Instance=new A016683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016684
{
public static readonly long[] Value={ 4L,1L,1L,0L,8L,7L,3L,8L,6L,4L,1L,7L,3L,3L,1L,1L,2L,4L,8L,7L,5L,1L,3L,8L,9L,1L,0L,3L,4L,2L,5L,6L,1L,4L,7L,4L,6L,3L,1L,5L,6L,8L,1L,7L,4L,3L,0L,8L,1L,2L,6L,1L,0L,6L,2L,9L,3L,7L,3L,8L,3L,6L,4L,6L,4L,1L,9L,4L,3L,9L,8L,0L,6L,8L,4L,4L,9L,4L,8L,7L,3L,1L,1L,8L,5L,4L,2L,9L,2L,0L,6L,1L,0L,0L,1L,0L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016684Inst : IEnumerable<long>
{
public static readonly long[] Value=A016684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016684.Bytes);
public long this[int i]=>Value[i];

public static A016684Inst Instance=new A016684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016685
{
public static readonly long[] Value={ 4L,1L,2L,7L,1L,3L,4L,3L,8L,5L,0L,4L,5L,0L,9L,1L,5L,5L,5L,3L,4L,6L,3L,9L,6L,4L,4L,6L,0L,0L,0L,5L,3L,3L,7L,7L,8L,5L,2L,5L,4L,3L,9L,0L,6L,4L,8L,4L,0L,8L,4L,7L,2L,2L,5L,8L,7L,7L,3L,9L,8L,0L,8L,1L,9L,6L,8L,3L,7L,5L,0L,3L,8L,5L,6L,7L,2L,4L,5L,9L,4L,7L,8L,1L,9L,7L,2L,8L,1L,5L,8L,3L,3L,2L,5L,0L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016685Inst : IEnumerable<long>
{
public static readonly long[] Value=A016685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016685.Bytes);
public long this[int i]=>Value[i];

public static A016685Inst Instance=new A016685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016718
{
public static readonly long[] Value={ 4L,5L,5L,3L,8L,7L,6L,8L,9L,1L,6L,0L,0L,5L,4L,0L,8L,3L,4L,6L,0L,9L,7L,8L,6L,7L,6L,5L,1L,1L,4L,0L,4L,1L,1L,7L,6L,7L,6L,2L,9L,8L,0L,6L,1L,5L,5L,6L,7L,6L,4L,6L,5L,4L,0L,4L,5L,0L,6L,0L,8L,1L,2L,7L,8L,8L,3L,4L,7L,1L,6L,8L,9L,7L,7L,1L,8L,5L,5L,0L,5L,3L,3L,4L,4L,2L,9L,2L,2L,6L,1L,9L,0L,8L,9L,1L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016718Inst : IEnumerable<long>
{
public static readonly long[] Value=A016718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016718.Bytes);
public long this[int i]=>Value[i];

public static A016718Inst Instance=new A016718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016719
{
public static readonly long[] Value={ 4L,5L,6L,4L,3L,4L,8L,1L,9L,1L,4L,6L,7L,8L,3L,6L,2L,3L,8L,4L,8L,1L,4L,0L,5L,8L,4L,4L,2L,1L,3L,4L,0L,8L,5L,4L,5L,0L,2L,4L,9L,9L,1L,2L,2L,9L,6L,2L,4L,0L,2L,5L,7L,2L,2L,3L,3L,8L,0L,9L,4L,3L,8L,1L,1L,0L,4L,4L,6L,2L,4L,0L,3L,0L,6L,7L,0L,8L,2L,5L,4L,4L,9L,0L,2L,9L,3L,2L,3L,8L,9L,7L,9L,5L,8L,2L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016719Inst : IEnumerable<long>
{
public static readonly long[] Value=A016719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016719.Bytes);
public long this[int i]=>Value[i];

public static A016719Inst Instance=new A016719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016720
{
public static readonly long[] Value={ 4L,5L,7L,4L,7L,1L,0L,9L,7L,8L,5L,0L,3L,3L,8L,2L,8L,2L,2L,1L,1L,6L,7L,2L,1L,6L,2L,1L,7L,0L,3L,9L,6L,1L,7L,1L,3L,8L,0L,8L,9L,1L,4L,9L,0L,2L,6L,5L,8L,7L,8L,1L,3L,5L,5L,9L,7L,6L,2L,3L,4L,3L,6L,8L,7L,6L,0L,1L,7L,7L,2L,9L,1L,7L,7L,8L,1L,8L,7L,1L,2L,5L,3L,4L,2L,2L,8L,2L,7L,4L,5L,0L,3L,4L,2L,7L,4L,5L,4L,9L,9L,2L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016720Inst : IEnumerable<long>
{
public static readonly long[] Value=A016720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016720.Bytes);
public long this[int i]=>Value[i];

public static A016720Inst Instance=new A016720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016721
{
public static readonly long[] Value={ 4L,5L,8L,4L,9L,6L,7L,4L,7L,8L,6L,7L,0L,5L,7L,1L,9L,1L,9L,6L,2L,7L,9L,3L,7L,6L,0L,8L,3L,4L,4L,5L,3L,6L,0L,2L,7L,3L,4L,9L,6L,6L,9L,5L,9L,3L,5L,2L,3L,9L,7L,7L,6L,3L,1L,0L,3L,9L,4L,6L,0L,3L,0L,9L,3L,6L,8L,5L,5L,3L,3L,4L,7L,4L,7L,3L,8L,3L,3L,2L,5L,1L,1L,8L,1L,1L,8L,0L,3L,2L,4L,1L,7L,2L,1L,6L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016721Inst : IEnumerable<long>
{
public static readonly long[] Value=A016721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016721.Bytes);
public long this[int i]=>Value[i];

public static A016721Inst Instance=new A016721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016722
{
public static readonly long[] Value={ 4L,5L,9L,5L,1L,1L,9L,8L,5L,0L,1L,3L,4L,5L,8L,9L,9L,2L,6L,8L,5L,2L,4L,3L,4L,0L,5L,1L,8L,1L,0L,1L,8L,0L,7L,0L,9L,1L,1L,6L,6L,8L,7L,9L,6L,9L,5L,8L,2L,9L,1L,6L,0L,7L,8L,6L,8L,7L,9L,5L,6L,3L,7L,6L,4L,0L,5L,5L,6L,2L,2L,1L,0L,3L,5L,0L,4L,5L,4L,6L,4L,6L,8L,2L,2L,2L,8L,6L,2L,1L,7L,6L,3L,0L,0L,9L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016722Inst : IEnumerable<long>
{
public static readonly long[] Value=A016722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016722.Bytes);
public long this[int i]=>Value[i];

public static A016722Inst Instance=new A016722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016723
{
public static readonly long[] Value={ 4L,6L,0L,5L,1L,7L,0L,1L,8L,5L,9L,8L,8L,0L,9L,1L,3L,6L,8L,0L,3L,5L,9L,8L,2L,9L,0L,9L,3L,6L,8L,7L,2L,8L,4L,1L,5L,2L,0L,2L,2L,0L,2L,9L,7L,7L,2L,5L,7L,5L,4L,5L,9L,5L,2L,0L,6L,6L,6L,5L,5L,8L,0L,1L,9L,3L,5L,1L,4L,5L,2L,1L,9L,3L,5L,4L,7L,0L,4L,9L,6L,0L,4L,7L,1L,9L,9L,4L,4L,1L,0L,1L,7L,9L,1L,9L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016723Inst : IEnumerable<long>
{
public static readonly long[] Value=A016723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016723.Bytes);
public long this[int i]=>Value[i];

public static A016723Inst Instance=new A016723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016724
{
public static readonly long[] Value={ 2L,2L,5L,4L,9L,6L,15L,8L,25L,10L,43L,12L,77L,14L,143L,16L,273L,18L,531L,20L,1045L,22L,2071L,24L,4121L,26L,8219L,28L,16413L,30L,32799L,32L,65569L,34L,131107L,36L,262181L,38L,524327L,40L,1048617L,42L,2097195L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016724Inst : IEnumerable<long>
{
public static readonly long[] Value=A016724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016724.Bytes);
public long this[int i]=>Value[i];

public static A016724Inst Instance=new A016724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016725
{
public static readonly long[] Value={ 1L,6L,6L,30L,6L,30L,30L,54L,6L,102L,30L,78L,30L,78L,54L,150L,6L,102L,102L,126L,30L,270L,78L,150L,30L,150L,78L,318L,54L,174L,150L,198L,6L,390L,102L,270L,102L,222L,126L,390L,30L,246L,270L,270L,78L,510L,150L,294L,30L,390L,150L,510L,78L,318L,318L,390L,54L,630L,174L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016725Inst : IEnumerable<long>
{
public static readonly long[] Value=A016725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016725.Bytes);
public long this[int i]=>Value[i];

public static A016725Inst Instance=new A016725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016726
{
public static readonly long[] Value={ 1L,2L,6L,9L,10L,13L,14L,17L,19L,22L,22L,26L,26L,29L,31L,34L,34L,37L,38L,41L,43L,46L,46L,53L,53L,53L,58L,58L,58L,61L,62L,67L,67L,71L,71L,73L,74L,79L,79L,82L,82L,86L,86L,89L,94L,94L,94L,97L,101L,101L,103L,106L,106L,109L,113L,113L,118L,118L,118L,122L,122L,127L,127L,131L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016726Inst : IEnumerable<long>
{
public static readonly long[] Value=A016726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016726.Bytes);
public long this[int i]=>Value[i];

public static A016726Inst Instance=new A016726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016727
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,1L,4L,2L,3L,2L,3L,2L,5L,1L,4L,4L,4L,2L,7L,3L,4L,2L,5L,3L,9L,2L,5L,5L,5L,1L,11L,4L,7L,4L,6L,4L,10L,2L,7L,7L,7L,3L,13L,4L,7L,2L,9L,5L,14L,3L,8L,9L,10L,2L,16L,5L,9L,5L,9L,5L,21L,1L,11L,11L,10L,4L,17L,7L,10L,4L,11L,6L,18L,4L,16L,10L,11L,2L,23L,7L,12L,7L,14L,7L,20L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016727Inst : IEnumerable<long>
{
public static readonly long[] Value=A016727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016727.Bytes);
public long this[int i]=>Value[i];

public static A016727Inst Instance=new A016727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016728
{
public static readonly long[] Value={ 1L,18L,62L,98L,210L,350L,450L,602L,762L,1142L,1250L,1458L,1814L,2178L,2498L,2622L,3338L,3722L,4170L,4358L,5034L,5714L,5982L,6602L,7130L,8034L,8606L,9066L,9962L,10550L,11226L,12146L,12606L,13802L,14754L,15194L,16454L,17154L,18266L,18750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016728Inst : IEnumerable<long>
{
public static readonly long[] Value=A016728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016728.Bytes);
public long this[int i]=>Value[i];

public static A016728Inst Instance=new A016728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016729
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,3L,4L,4L,4L,5L,6L,5L,6L,6L,6L,7L,8L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016729Inst : IEnumerable<long>
{
public static readonly long[] Value=A016729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016729.Bytes);
public long this[int i]=>Value[i];

public static A016729Inst Instance=new A016729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016730
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,6L,3L,1L,1L,2L,1L,1L,1L,1L,3L,10L,1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,3L,1L,13L,7L,4L,1L,1L,1L,7L,2L,4L,1L,1L,2L,5L,14L,1L,10L,1L,4L,2L,18L,3L,1L,4L,1L,6L,2L,7L,3L,3L,1L,13L,3L,1L,4L,4L,1L,3L,1L,1L,1L,1L,2L,17L,3L,1L,2L,32L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016730Inst : IEnumerable<long>
{
public static readonly long[] Value=A016730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016730.Bytes);
public long this[int i]=>Value[i];

public static A016730Inst Instance=new A016730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016731
{
public static readonly long[] Value={ 1L,10L,7L,9L,2L,2L,1L,3L,1L,32L,2L,17L,1L,15L,1L,1L,7L,3L,1L,35L,1L,1L,1L,2L,5L,3L,2L,1L,4L,2L,1L,3L,1L,5L,3L,13L,1L,1L,1L,6L,2L,3L,1L,152L,1L,2L,3L,1L,7L,9L,2L,1L,3L,19L,2L,2L,2L,3L,2L,5L,1L,1L,4L,1L,19L,5L,4L,2L,1L,2L,7L,4L,2L,1L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016731Inst : IEnumerable<long>
{
public static readonly long[] Value=A016731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016731.Bytes);
public long this[int i]=>Value[i];

public static A016731Inst Instance=new A016731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016732
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,7L,6L,4L,1L,1L,21L,3L,1L,3L,3L,1L,1L,2L,1L,1L,2L,6L,1L,1L,3L,9L,3L,3L,1L,2L,1L,1L,1L,3L,1L,10L,7L,2L,5L,2L,2L,4L,9L,7L,1L,1L,1L,13L,1L,14L,1L,1L,1L,1L,2L,6L,1L,1L,1L,2L,2L,9L,1L,1L,3L,3L,1L,34L,1L,1L,5L,16L,3L,3L,1L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016732Inst : IEnumerable<long>
{
public static readonly long[] Value=A016732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016732.Bytes);
public long this[int i]=>Value[i];

public static A016732Inst Instance=new A016732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016733
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,4L,6L,94L,1L,3L,4L,40L,1L,5L,2L,2L,1L,1L,7L,7L,8L,39L,4L,3L,4L,1L,9L,1L,1L,2L,1L,7L,1L,6L,2L,18L,1L,1L,1L,12L,1L,1L,3L,1L,1L,4L,16L,16L,3L,3L,2L,1L,17L,1L,8L,1L,20L,1L,15L,15L,10L,2L,13L,1L,1L,34L,1L,32L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016733Inst : IEnumerable<long>
{
public static readonly long[] Value=A016733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016733.Bytes);
public long this[int i]=>Value[i];

public static A016733Inst Instance=new A016733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016750
{
public static readonly long[] Value={ 0L,1024L,1048576L,60466176L,1073741824L,10000000000L,61917364224L,289254654976L,1099511627776L,3570467226624L,10240000000000L,26559922791424L,63403380965376L,141167095653376L,296196766695424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016750Inst : IEnumerable<long>
{
public static readonly long[] Value=A016750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016750.Bytes);
public long this[int i]=>Value[i];

public static A016750Inst Instance=new A016750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016751
{
public static readonly long[] Value={ 0L,2048L,4194304L,362797056L,8589934592L,100000000000L,743008370688L,4049565169664L,17592186044416L,64268410079232L,204800000000000L,584318301411328L,1521681143169024L,3670344486987776L,8293509467471872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016751Inst : IEnumerable<long>
{
public static readonly long[] Value=A016751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016751.Bytes);
public long this[int i]=>Value[i];

public static A016751Inst Instance=new A016751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016752
{
public static readonly long[] Value={ 0L,4096L,16777216L,2176782336L,68719476736L,1000000000000L,8916100448256L,56693912375296L,281474976710656L,1156831381426176L,4096000000000000L,12855002631049216L,36520347436056576L,95428956661682176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016752Inst : IEnumerable<long>
{
public static readonly long[] Value=A016752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016752.Bytes);
public long this[int i]=>Value[i];

public static A016752Inst Instance=new A016752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016753
{
public static readonly long[] Value={ 1L,12L,97L,660L,4081L,23772L,133057L,724260L,3863761L,20308332L,105558817L,544039860L,2785713841L,14192221692L,72020501377L,364354427460L,1838822866321L,9262446387852L,46585947584737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016753Inst : IEnumerable<long>
{
public static readonly long[] Value=A016753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016753.Bytes);
public long this[int i]=>Value[i];

public static A016753Inst Instance=new A016753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016754
{
public static readonly long[] Value={ 1L,9L,25L,49L,81L,121L,169L,225L,289L,361L,441L,529L,625L,729L,841L,961L,1089L,1225L,1369L,1521L,1681L,1849L,2025L,2209L,2401L,2601L,2809L,3025L,3249L,3481L,3721L,3969L,4225L,4489L,4761L,5041L,5329L,5625L,5929L,6241L,6561L,6889L,7225L,7569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016754Inst : IEnumerable<long>
{
public static readonly long[] Value=A016754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016754.Bytes);
public long this[int i]=>Value[i];

public static A016754Inst Instance=new A016754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016755
{
public static readonly long[] Value={ 1L,27L,125L,343L,729L,1331L,2197L,3375L,4913L,6859L,9261L,12167L,15625L,19683L,24389L,29791L,35937L,42875L,50653L,59319L,68921L,79507L,91125L,103823L,117649L,132651L,148877L,166375L,185193L,205379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016755Inst : IEnumerable<long>
{
public static readonly long[] Value=A016755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016755.Bytes);
public long this[int i]=>Value[i];

public static A016755Inst Instance=new A016755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016756
{
public static readonly long[] Value={ 1L,81L,625L,2401L,6561L,14641L,28561L,50625L,83521L,130321L,194481L,279841L,390625L,531441L,707281L,923521L,1185921L,1500625L,1874161L,2313441L,2825761L,3418801L,4100625L,4879681L,5764801L,6765201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016756Inst : IEnumerable<long>
{
public static readonly long[] Value=A016756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016756.Bytes);
public long this[int i]=>Value[i];

public static A016756Inst Instance=new A016756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016757
{
public static readonly long[] Value={ 1L,243L,3125L,16807L,59049L,161051L,371293L,759375L,1419857L,2476099L,4084101L,6436343L,9765625L,14348907L,20511149L,28629151L,39135393L,52521875L,69343957L,90224199L,115856201L,147008443L,184528125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016757Inst : IEnumerable<long>
{
public static readonly long[] Value=A016757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016757.Bytes);
public long this[int i]=>Value[i];

public static A016757Inst Instance=new A016757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016758
{
public static readonly long[] Value={ 1L,729L,15625L,117649L,531441L,1771561L,4826809L,11390625L,24137569L,47045881L,85766121L,148035889L,244140625L,387420489L,594823321L,887503681L,1291467969L,1838265625L,2565726409L,3518743761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016758Inst : IEnumerable<long>
{
public static readonly long[] Value=A016758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016758.Bytes);
public long this[int i]=>Value[i];

public static A016758Inst Instance=new A016758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016759
{
public static readonly long[] Value={ 1L,2187L,78125L,823543L,4782969L,19487171L,62748517L,170859375L,410338673L,893871739L,1801088541L,3404825447L,6103515625L,10460353203L,17249876309L,27512614111L,42618442977L,64339296875L,94931877133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016759Inst : IEnumerable<long>
{
public static readonly long[] Value=A016759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016759.Bytes);
public long this[int i]=>Value[i];

public static A016759Inst Instance=new A016759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016760
{
public static readonly long[] Value={ 1L,6561L,390625L,5764801L,43046721L,214358881L,815730721L,2562890625L,6975757441L,16983563041L,37822859361L,78310985281L,152587890625L,282429536481L,500246412961L,852891037441L,1406408618241L,2251875390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016760Inst : IEnumerable<long>
{
public static readonly long[] Value=A016760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016760.Bytes);
public long this[int i]=>Value[i];

public static A016760Inst Instance=new A016760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016761
{
public static readonly long[] Value={ 1L,19683L,1953125L,40353607L,387420489L,2357947691L,10604499373L,38443359375L,118587876497L,322687697779L,794280046581L,1801152661463L,3814697265625L,7625597484987L,14507145975869L,26439622160671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016761Inst : IEnumerable<long>
{
public static readonly long[] Value=A016761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016761.Bytes);
public long this[int i]=>Value[i];

public static A016761Inst Instance=new A016761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016762
{
public static readonly long[] Value={ 1L,59049L,9765625L,282475249L,3486784401L,25937424601L,137858491849L,576650390625L,2015993900449L,6131066257801L,16679880978201L,41426511213649L,95367431640625L,205891132094649L,420707233300201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016762Inst : IEnumerable<long>
{
public static readonly long[] Value=A016762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016762.Bytes);
public long this[int i]=>Value[i];

public static A016762Inst Instance=new A016762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016763
{
public static readonly long[] Value={ 1L,177147L,48828125L,1977326743L,31381059609L,285311670611L,1792160394037L,8649755859375L,34271896307633L,116490258898219L,350277500542221L,952809757913927L,2384185791015625L,5559060566555523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016763Inst : IEnumerable<long>
{
public static readonly long[] Value=A016763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016763.Bytes);
public long this[int i]=>Value[i];

public static A016763Inst Instance=new A016763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016764
{
public static readonly long[] Value={ 1L,531441L,244140625L,13841287201L,282429536481L,3138428376721L,23298085122481L,129746337890625L,582622237229761L,2213314919066161L,7355827511386641L,21914624432020321L,59604644775390625L,150094635296999121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016764Inst : IEnumerable<long>
{
public static readonly long[] Value=A016764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016764.Bytes);
public long this[int i]=>Value[i];

public static A016764Inst Instance=new A016764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016765
{
public static readonly long[] Value={ 1L,13L,115L,865L,5971L,39193L,249355L,1555105L,9573091L,58428073L,354585595L,2143759345L,12928070611L,77832076153L,468051849835L,2812563019585L,16892428846531L,101422905135433L,608811146458075L,3653962903591825L,21928165007708851L,131586550851237913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016765Inst : IEnumerable<long>
{
public static readonly long[] Value=A016765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016765.Bytes);
public long this[int i]=>Value[i];

public static A016765Inst Instance=new A016765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016766
{
public static readonly long[] Value={ 0L,9L,36L,81L,144L,225L,324L,441L,576L,729L,900L,1089L,1296L,1521L,1764L,2025L,2304L,2601L,2916L,3249L,3600L,3969L,4356L,4761L,5184L,5625L,6084L,6561L,7056L,7569L,8100L,8649L,9216L,9801L,10404L,11025L,11664L,12321L,12996L,13689L,14400L,15129L,15876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016766Inst : IEnumerable<long>
{
public static readonly long[] Value=A016766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016766.Bytes);
public long this[int i]=>Value[i];

public static A016766Inst Instance=new A016766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016767
{
public static readonly long[] Value={ 0L,27L,216L,729L,1728L,3375L,5832L,9261L,13824L,19683L,27000L,35937L,46656L,59319L,74088L,91125L,110592L,132651L,157464L,185193L,216000L,250047L,287496L,328509L,373248L,421875L,474552L,531441L,592704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016767Inst : IEnumerable<long>
{
public static readonly long[] Value=A016767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016767.Bytes);
public long this[int i]=>Value[i];

public static A016767Inst Instance=new A016767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016768
{
public static readonly long[] Value={ 0L,81L,1296L,6561L,20736L,50625L,104976L,194481L,331776L,531441L,810000L,1185921L,1679616L,2313441L,3111696L,4100625L,5308416L,6765201L,8503056L,10556001L,12960000L,15752961L,18974736L,22667121L,26873856L,31640625L,37015056L,43046721L,49787136L,57289761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016768Inst : IEnumerable<long>
{
public static readonly long[] Value=A016768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016768.Bytes);
public long this[int i]=>Value[i];

public static A016768Inst Instance=new A016768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016769
{
public static readonly long[] Value={ 0L,243L,7776L,59049L,248832L,759375L,1889568L,4084101L,7962624L,14348907L,24300000L,39135393L,60466176L,90224199L,130691232L,184528125L,254803968L,345025251L,459165024L,601692057L,777600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016769Inst : IEnumerable<long>
{
public static readonly long[] Value=A016769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016769.Bytes);
public long this[int i]=>Value[i];

public static A016769Inst Instance=new A016769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016770
{
public static readonly long[] Value={ 0L,729L,46656L,531441L,2985984L,11390625L,34012224L,85766121L,191102976L,387420489L,729000000L,1291467969L,2176782336L,3518743761L,5489031744L,8303765625L,12230590464L,17596287801L,24794911296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016770Inst : IEnumerable<long>
{
public static readonly long[] Value=A016770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016770.Bytes);
public long this[int i]=>Value[i];

public static A016770Inst Instance=new A016770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016771
{
public static readonly long[] Value={ 0L,2187L,279936L,4782969L,35831808L,170859375L,612220032L,1801088541L,4586471424L,10460353203L,21870000000L,42618442977L,78364164096L,137231006679L,230539333248L,373669453125L,587068342272L,897410677851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016771Inst : IEnumerable<long>
{
public static readonly long[] Value=A016771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016771.Bytes);
public long this[int i]=>Value[i];

public static A016771Inst Instance=new A016771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016772
{
public static readonly long[] Value={ 0L,6561L,1679616L,43046721L,429981696L,2562890625L,11019960576L,37822859361L,110075314176L,282429536481L,656100000000L,1406408618241L,2821109907456L,5352009260481L,9682651996416L,16815125390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016772Inst : IEnumerable<long>
{
public static readonly long[] Value=A016772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016772.Bytes);
public long this[int i]=>Value[i];

public static A016772Inst Instance=new A016772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016773
{
public static readonly long[] Value={ 0L,19683L,10077696L,387420489L,5159780352L,38443359375L,198359290368L,794280046581L,2641807540224L,7625597484987L,19683000000000L,46411484401953L,101559956668416L,208728361158759L,406671383849472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016773Inst : IEnumerable<long>
{
public static readonly long[] Value=A016773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016773.Bytes);
public long this[int i]=>Value[i];

public static A016773Inst Instance=new A016773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016774
{
public static readonly long[] Value={ 0L,59049L,60466176L,3486784401L,61917364224L,576650390625L,3570467226624L,16679880978201L,63403380965376L,205891132094649L,590490000000000L,1531578985264449L,3656158440062976L,8140406085191601L,17080198121677824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016774Inst : IEnumerable<long>
{
public static readonly long[] Value=A016774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016774.Bytes);
public long this[int i]=>Value[i];

public static A016774Inst Instance=new A016774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016775
{
public static readonly long[] Value={ 0L,177147L,362797056L,31381059609L,743008370688L,8649755859375L,64268410079232L,350277500542221L,1521681143169024L,5559060566555523L,17714700000000000L,50542106513726817L,131621703842267136L,317475837322472439L,717368321110468608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016775Inst : IEnumerable<long>
{
public static readonly long[] Value=A016775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016775.Bytes);
public long this[int i]=>Value[i];

public static A016775Inst Instance=new A016775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016776
{
public static readonly long[] Value={ 0L,531441L,2176782336L,282429536481L,8916100448256L,129746337890625L,1156831381426176L,7355827511386641L,36520347436056576L,150094635296999121L,531441000000000000L,1667889514952984961L,4738381338321616896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016776Inst : IEnumerable<long>
{
public static readonly long[] Value=A016776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016776.Bytes);
public long this[int i]=>Value[i];

public static A016776Inst Instance=new A016776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016777
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,16L,19L,22L,25L,28L,31L,34L,37L,40L,43L,46L,49L,52L,55L,58L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,91L,94L,97L,100L,103L,106L,109L,112L,115L,118L,121L,124L,127L,130L,133L,136L,139L,142L,145L,148L,151L,154L,157L,160L,163L,166L,169L,172L,175L,178L,181L,184L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016777Inst : IEnumerable<long>
{
public static readonly long[] Value=A016777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016777.Bytes);
public long this[int i]=>Value[i];

public static A016777Inst Instance=new A016777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016778
{
public static readonly long[] Value={ 1L,16L,49L,100L,169L,256L,361L,484L,625L,784L,961L,1156L,1369L,1600L,1849L,2116L,2401L,2704L,3025L,3364L,3721L,4096L,4489L,4900L,5329L,5776L,6241L,6724L,7225L,7744L,8281L,8836L,9409L,10000L,10609L,11236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016778Inst : IEnumerable<long>
{
public static readonly long[] Value=A016778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016778.Bytes);
public long this[int i]=>Value[i];

public static A016778Inst Instance=new A016778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016779
{
public static readonly long[] Value={ 1L,64L,343L,1000L,2197L,4096L,6859L,10648L,15625L,21952L,29791L,39304L,50653L,64000L,79507L,97336L,117649L,140608L,166375L,195112L,226981L,262144L,300763L,343000L,389017L,438976L,493039L,551368L,614125L,681472L,753571L,830584L,912673L,1000000L,1092727L,1191016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016779Inst : IEnumerable<long>
{
public static readonly long[] Value=A016779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016779.Bytes);
public long this[int i]=>Value[i];

public static A016779Inst Instance=new A016779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016780
{
public static readonly long[] Value={ 1L,256L,2401L,10000L,28561L,65536L,130321L,234256L,390625L,614656L,923521L,1336336L,1874161L,2560000L,3418801L,4477456L,5764801L,7311616L,9150625L,11316496L,13845841L,16777216L,20151121L,24010000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016780Inst : IEnumerable<long>
{
public static readonly long[] Value=A016780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016780.Bytes);
public long this[int i]=>Value[i];

public static A016780Inst Instance=new A016780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016781
{
public static readonly long[] Value={ 1L,1024L,16807L,100000L,371293L,1048576L,2476099L,5153632L,9765625L,17210368L,28629151L,45435424L,69343957L,102400000L,147008443L,205962976L,282475249L,380204032L,503284375L,656356768L,844596301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016781Inst : IEnumerable<long>
{
public static readonly long[] Value=A016781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016781.Bytes);
public long this[int i]=>Value[i];

public static A016781Inst Instance=new A016781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016782
{
public static readonly long[] Value={ 1L,4096L,117649L,1000000L,4826809L,16777216L,47045881L,113379904L,244140625L,481890304L,887503681L,1544804416L,2565726409L,4096000000L,6321363049L,9474296896L,13841287201L,19770609664L,27680640625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016782Inst : IEnumerable<long>
{
public static readonly long[] Value=A016782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016782.Bytes);
public long this[int i]=>Value[i];

public static A016782Inst Instance=new A016782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016783
{
public static readonly long[] Value={ 1L,16384L,823543L,10000000L,62748517L,268435456L,893871739L,2494357888L,6103515625L,13492928512L,27512614111L,52523350144L,94931877133L,163840000000L,271818611107L,435817657216L,678223072849L,1028071702528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016783Inst : IEnumerable<long>
{
public static readonly long[] Value=A016783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016783.Bytes);
public long this[int i]=>Value[i];

public static A016783Inst Instance=new A016783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016784
{
public static readonly long[] Value={ 1L,65536L,5764801L,100000000L,815730721L,4294967296L,16983563041L,54875873536L,152587890625L,377801998336L,852891037441L,1785793904896L,3512479453921L,6553600000000L,11688200277601L,20047612231936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016784Inst : IEnumerable<long>
{
public static readonly long[] Value=A016784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016784.Bytes);
public long this[int i]=>Value[i];

public static A016784Inst Instance=new A016784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016785
{
public static readonly long[] Value={ 1L,262144L,40353607L,1000000000L,10604499373L,68719476736L,322687697779L,1207269217792L,3814697265625L,10578455953408L,26439622160671L,60716992766464L,129961739795077L,262144000000000L,502592611936843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016785Inst : IEnumerable<long>
{
public static readonly long[] Value=A016785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016785.Bytes);
public long this[int i]=>Value[i];

public static A016785Inst Instance=new A016785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016786
{
public static readonly long[] Value={ 1L,1048576L,282475249L,10000000000L,137858491849L,1099511627776L,6131066257801L,26559922791424L,95367431640625L,296196766695424L,819628286980801L,2064377754059776L,4808584372417849L,10485760000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016786Inst : IEnumerable<long>
{
public static readonly long[] Value=A016786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016786.Bytes);
public long this[int i]=>Value[i];

public static A016786Inst Instance=new A016786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016787
{
public static readonly long[] Value={ 1L,4194304L,1977326743L,100000000000L,1792160394037L,17592186044416L,116490258898219L,584318301411328L,2384185791015625L,8293509467471872L,25408476896404831L,70188843638032384L,177917621779460413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016787Inst : IEnumerable<long>
{
public static readonly long[] Value=A016787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016787.Bytes);
public long this[int i]=>Value[i];

public static A016787Inst Instance=new A016787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016788
{
public static readonly long[] Value={ 1L,16777216L,13841287201L,1000000000000L,23298085122481L,281474976710656L,2213314919066161L,12855002631049216L,59604644775390625L,232218265089212416L,787662783788549761L,2386420683693101056L,6582952005840035281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016788Inst : IEnumerable<long>
{
public static readonly long[] Value=A016788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016788.Bytes);
public long this[int i]=>Value[i];

public static A016788Inst Instance=new A016788Inst();

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