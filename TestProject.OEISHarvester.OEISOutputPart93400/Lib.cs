using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A113041
{
public static readonly long[] Value={ 1L,0L,1L,3L,9L,27L,78L,249L,782L,2574L,8676L,29714L,102162L,356797L,1268990L,4521769L,16134137L,58061535L,210499244L,767154326L,2809323733L,10342098153L,38281849044L,142249547127L,527095215036L,1966843667482L,7368829743507L,27636276043171L,103876045792060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113041Inst : IEnumerable<long>
{
public static readonly long[] Value=A113041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113041.Bytes);
public long this[int i]=>Value[i];

public static A113041Inst Instance=new A113041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113042
{
public static readonly long[] Value={ 0L,2L,1L,7L,15L,45L,139L,438L,1419L,4703L,16019L,55146L,190254L,671215L,2404179L,8534995L,30635448L,110495549L,401418693L,1467388464L,5393131894L,19883104535L,73856058401L,273600682457L,1017557492609L,3803885439979L,14266466901249L,53564801078049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113042Inst : IEnumerable<long>
{
public static readonly long[] Value=A113042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113042.Bytes);
public long this[int i]=>Value[i];

public static A113042Inst Instance=new A113042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113043
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,255L,0L,766L,0L,2342L,0L,0L,0L,23373L,0L,75005L,0L,243824L,0L,800249L,0L,2643880L,0L,8789565L,0L,29396169L,0L,0L,0L,333867426L,0L,1132658742L,0L,3858864902L,0L,13182921033L,0L,0L,0L,0L,0L,537690715092L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113043Inst : IEnumerable<long>
{
public static readonly long[] Value=A113043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113043.Bytes);
public long this[int i]=>Value[i];

public static A113043Inst Instance=new A113043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113044
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,5L,0L,11L,0L,0L,0L,75L,0L,203L,0L,558L,0L,1559L,0L,0L,0L,12786L,0L,37147L,0L,108491L,0L,321551L,0L,964713L,0L,2904950L,0L,8775407L,0L,0L,0L,0L,0L,0L,0L,760875083L,0L,0L,0L,7272292133L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2063638853745109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113044Inst : IEnumerable<long>
{
public static readonly long[] Value=A113044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113044.Bytes);
public long this[int i]=>Value[i];

public static A113044Inst Instance=new A113044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113045
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,0L,0L,0L,0L,1L,1L,2L,2L,0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113045Inst : IEnumerable<long>
{
public static readonly long[] Value=A113045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113045.Bytes);
public long this[int i]=>Value[i];

public static A113045Inst Instance=new A113045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113046
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,5L,5L,6L,3L,3L,3L,3L,3L,3L,1L,1L,9L,11L,11L,12L,5L,5L,15L,16L,10L,12L,6L,6L,9L,9L,6L,6L,3L,3L,9L,9L,9L,9L,3L,3L,9L,9L,6L,6L,3L,3L,3L,3L,3L,3L,1L,1L,27L,29L,29L,30L,11L,11L,33L,34L,22L,24L,12L,12L,15L,15L,12L,12L,5L,5L,45L,46L,28L,30L,16L,16L,30L,32L,23L,24L,12L,12L,18L,18L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113046Inst : IEnumerable<long>
{
public static readonly long[] Value=A113046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113046.Bytes);
public long this[int i]=>Value[i];

public static A113046Inst Instance=new A113046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113047
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113047Inst : IEnumerable<long>
{
public static readonly long[] Value=A113047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113047.Bytes);
public long this[int i]=>Value[i];

public static A113047Inst Instance=new A113047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113048
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113048Inst : IEnumerable<long>
{
public static readonly long[] Value=A113048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113048.Bytes);
public long this[int i]=>Value[i];

public static A113048Inst Instance=new A113048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113049
{
public static readonly long[] Value={ 3L,11L,13L,43L,45L,53L,171L,173L,181L,213L,683L,685L,693L,725L,853L,2731L,2733L,2741L,2773L,2901L,3413L,10923L,10925L,10933L,10965L,11093L,11605L,13653L,43691L,43693L,43701L,43733L,43861L,44373L,46421L,54613L,174763L,174765L,174773L,174805L,174933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113049Inst : IEnumerable<long>
{
public static readonly long[] Value=A113049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113049.Bytes);
public long this[int i]=>Value[i];

public static A113049Inst Instance=new A113049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113050
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,8L,15L,16L,17L,18L,35L,36L,71L,72L,73L,74L,147L,148L,295L,296L,297L,298L,595L,596L,597L,598L,599L,600L,1199L,1200L,2399L,2400L,2401L,2402L,2403L,2404L,4807L,4808L,4809L,4810L,9619L,9620L,19239L,19240L,19241L,19242L,38483L,38484L,38485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113050Inst : IEnumerable<long>
{
public static readonly long[] Value=A113050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113050.Bytes);
public long this[int i]=>Value[i];

public static A113050Inst Instance=new A113050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113051
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,9L,10L,11L,21L,22L,23L,45L,46L,47L,93L,94L,95L,96L,97L,193L,290L,291L,292L,293L,585L,586L,587L,1173L,1174L,1175L,1176L,1177L,1178L,1179L,1180L,1181L,2361L,2362L,2363L,2364L,2365L,2366L,2367L,2368L,2369L,2370L,2371L,4741L,4742L,4743L,4744L,4745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113051Inst : IEnumerable<long>
{
public static readonly long[] Value=A113051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113051.Bytes);
public long this[int i]=>Value[i];

public static A113051Inst Instance=new A113051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113052
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113052Inst : IEnumerable<long>
{
public static readonly long[] Value=A113052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113052.Bytes);
public long this[int i]=>Value[i];

public static A113052Inst Instance=new A113052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113053
{
public static readonly BigInteger[] Value={ 7L,71L,2131L,191791L,5753731L,575373101L,17261193031L,517835790931L,82853726548961L,28998804292136351L,16239330403596356561UL,BigInteger.Parse("4384619208971016271471"),BigInteger.Parse("526154305076521952576521") };
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
public class A113053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113053Inst Instance=new A113053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113054
{
public static readonly BigInteger[] Value={ 61L,1831L,18311L,366221L,21973261L,5273582641L,52735826411L,1054716528221L,158207479233151L,11074523546320571L,1661178531948085651L,BigInteger.Parse("249176779792212847651"),BigInteger.Parse("92195408523118753630871") };
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
public class A113054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113054Inst Instance=new A113054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113055
{
public static readonly BigInteger[] Value={ 5L,59L,599L,29959L,6890579L,551246329L,27562316459L,551246329189L,104736802545919L,1047368025459199L,73315761782143939L,2932630471285757569L,BigInteger.Parse("1114399579088587876229"),BigInteger.Parse("22287991581771757524589") };
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
public class A113055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113055Inst Instance=new A113055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113056
{
public static readonly BigInteger[] Value={ 5L,107L,3217L,96517L,965177L,19303547L,2316425647L,208478308237L,64628275553477L,11633089599625867L,697985375977552027L,BigInteger.Parse("41879122558653121627"),BigInteger.Parse("5444285932624905811517") };
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
public class A113056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113056Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113056.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113056Inst Instance=new A113056Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113057
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,8L,9L,21L,22L,23L,24L,69L,70L,163L,164L,165L,166L,495L,496L,1157L,1158L,1159L,1160L,3477L,3478L,3479L,3480L,3481L,3482L,10443L,10444L,10445L,10446L,10447L,10448L,10449L,10450L,31347L,31348L,31349L,31350L,94047L,94048L,94049L,94050L,94051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113057Inst : IEnumerable<long>
{
public static readonly long[] Value=A113057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113057.Bytes);
public long this[int i]=>Value[i];

public static A113057Inst Instance=new A113057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113058
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,5L,11L,20L,21L,22L,23L,66L,67L,156L,157L,380L,381L,382L,383L,1146L,1147L,1148L,1149L,1150L,1151L,3450L,3451L,3452L,3453L,3454L,3455L,3456L,3457L,10368L,10369L,24194L,24195L,24196L,24197L,72588L,72589L,72590L,72591L,72592L,72593L,72594L,72595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113058Inst : IEnumerable<long>
{
public static readonly long[] Value=A113058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113058.Bytes);
public long this[int i]=>Value[i];

public static A113058Inst Instance=new A113058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113059
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,44L,231L,1427L,10151L,81923L,740732L,7425042L,81773715L,981864897L,12767876941L,178774288331L,2681781213130L,42909715480460L,729474427239587L,13130613291110603L,249482261007109579L,4989650444408388515L,BigInteger.Parse("104782705832468197252"),BigInteger.Parse("2305219956684224457858") };
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
public class A113059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113059Inst Instance=new A113059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113060
{
public static readonly long[] Value={ 1L,3L,11L,48L,244L,1423L,9415L,70045L,581507L,5349538L,54173950L,600127047L,7229169001L,94170096335L,1319764307235L,19806944750672L,316993980880556L,5389579751775611L,97018268274166055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113060Inst : IEnumerable<long>
{
public static readonly long[] Value=A113060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113060.Bytes);
public long this[int i]=>Value[i];

public static A113060Inst Instance=new A113060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113061
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,28L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,28L,1L,9L,1L,1L,1L,1L,1L,1L,1L,73L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L,28L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113061Inst : IEnumerable<long>
{
public static readonly long[] Value=A113061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113061.Bytes);
public long this[int i]=>Value[i];

public static A113061Inst Instance=new A113061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113062
{
public static readonly long[] Value={ 1L,3L,0L,6L,3L,0L,0L,6L,0L,6L,0L,0L,6L,6L,0L,0L,3L,0L,0L,6L,0L,12L,0L,0L,0L,3L,0L,6L,6L,0L,0L,6L,0L,0L,0L,0L,6L,6L,0L,12L,0L,0L,0L,6L,0L,0L,0L,0L,6L,9L,0L,0L,6L,0L,0L,0L,0L,12L,0L,0L,0L,6L,0L,12L,3L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,6L,6L,0L,0L,6L,0L,6L,0L,0L,12L,0L,0L,0L,0L,0L,0L,12L,0L,12L,0L,0L,0L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113062Inst : IEnumerable<long>
{
public static readonly long[] Value=A113062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113062.Bytes);
public long this[int i]=>Value[i];

public static A113062Inst Instance=new A113062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113063
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,0L,2L,0L,2L,0L,0L,2L,2L,0L,0L,1L,0L,0L,2L,0L,4L,0L,0L,0L,1L,0L,2L,2L,0L,0L,2L,0L,0L,0L,0L,2L,2L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,2L,3L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,0L,2L,0L,4L,1L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,2L,0L,0L,2L,0L,2L,0L,0L,4L,0L,0L,0L,0L,0L,0L,4L,0L,4L,0L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113063Inst : IEnumerable<long>
{
public static readonly long[] Value=A113063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113063.Bytes);
public long this[int i]=>Value[i];

public static A113063Inst Instance=new A113063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113064
{
public static readonly BigInteger[] Value={ 1L,5L,67L,2035L,327035L,18466715L,7619115545L,6522042157745L,51871686471116105L,BigInteger.Parse("424282494361851819005"),BigInteger.Parse("39140577420952910465839555"),BigInteger.Parse("3692929600143446269942515952655"),BigInteger.Parse("4623053713106560878635060477474217415") };
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
public class A113064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113064Inst Instance=new A113064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113065
{
public static readonly BigInteger[] Value={ 1L,3L,45L,1341L,216117L,12198933L,5033340279L,4308570125919L,34267321328538951L,BigInteger.Parse("280288242453582014931"),BigInteger.Parse("25856932235044095350623341"),BigInteger.Parse("2439612204830872620697726926561"),BigInteger.Parse("3054068039108858195570513558702127273") };
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
public class A113065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113065Inst Instance=new A113065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113066
{
public static readonly long[] Value={ 1L,-2L,4L,-10L,27L,-72L,189L,-494L,1292L,-3382L,8855L,-23184L,60697L,-158906L,416020L,-1089154L,2851443L,-7465176L,19544085L,-51167078L,133957148L,-350704366L,918155951L,-2403763488L,6293134513L,-16475640050L,43133785636L,-112925716858L,295643364939L,-774004377960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113066Inst : IEnumerable<long>
{
public static readonly long[] Value=A113066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113066.Bytes);
public long this[int i]=>Value[i];

public static A113066Inst Instance=new A113066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113067
{
public static readonly long[] Value={ 0L,-1L,4L,-11L,28L,-72L,188L,-493L,1292L,-3383L,8856L,-23184L,60696L,-158905L,416020L,-1089155L,2851444L,-7465176L,19544084L,-51167077L,133957148L,-350704367L,918155952L,-2403763488L,6293134512L,-16475640049L,43133785636L,-112925716859L,295643364940L,-774004377960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113067Inst : IEnumerable<long>
{
public static readonly long[] Value=A113067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113067.Bytes);
public long this[int i]=>Value[i];

public static A113067Inst Instance=new A113067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113068
{
public static readonly BigInteger[] Value={ 5L,53L,1063L,74413L,5208913L,364623913L,3646239133L,474011087293L,90062106585673L,11708073856137493L,819565169929624513L,8195651699296245133L,BigInteger.Parse("1065434720908511867293"),BigInteger.Parse("42617388836340474691723") };
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
public class A113068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113068Inst Instance=new A113068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113069
{
public static readonly long[] Value={ 1L,0L,3L,0L,2L,4L,0L,8L,9L,1L,3L,6L,11L,12L,1L,13L,7L,14L,3L,14L,2L,15L,16L,15L,17L,7L,18L,19L,4L,12L,22L,3L,22L,24L,23L,25L,14L,25L,25L,3L,26L,26L,30L,30L,11L,32L,33L,19L,34L,33L,34L,35L,6L,10L,35L,35L,23L,4L,35L,35L,36L,37L,38L,36L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113069Inst : IEnumerable<long>
{
public static readonly long[] Value=A113069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113069.Bytes);
public long this[int i]=>Value[i];

public static A113069Inst Instance=new A113069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113070
{
public static readonly long[] Value={ 1L,6L,21L,60L,156L,384L,912L,2112L,4800L,10752L,23808L,52224L,113664L,245760L,528384L,1130496L,2408448L,5111808L,10813440L,22806528L,47972352L,100663296L,210763776L,440401920L,918552576L,1912602624L,3976200192L,8254390272L,17112760320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113070Inst : IEnumerable<long>
{
public static readonly long[] Value=A113070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113070.Bytes);
public long this[int i]=>Value[i];

public static A113070Inst Instance=new A113070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113071
{
public static readonly long[] Value={ 1L,8L,40L,168L,648L,2376L,8424L,29160L,99144L,332424L,1102248L,3621672L,11809800L,38263752L,123294312L,395392104L,1262703816L,4017693960L,12741829416L,40291730856L,127073920392L,399817944648L,1255242384360L,3933092804328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113071Inst : IEnumerable<long>
{
public static readonly long[] Value=A113071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113071.Bytes);
public long this[int i]=>Value[i];

public static A113071Inst Instance=new A113071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113072
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,3L,0L,2L,6L,4L,0L,0L,3L,8L,5L,0L,0L,0L,4L,10L,6L,0L,0L,0L,0L,5L,12L,7L,0L,0L,0L,0L,0L,6L,14L,8L,0L,0L,0L,0L,0L,0L,7L,16L,9L,0L,0L,0L,0L,0L,0L,0L,8L,18L,10L,0L,0L,0L,0L,0L,0L,0L,0L,9L,20L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,22L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,24L,13L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113072Inst : IEnumerable<long>
{
public static readonly long[] Value=A113072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113072.Bytes);
public long this[int i]=>Value[i];

public static A113072Inst Instance=new A113072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113073
{
public static readonly BigInteger[] Value={ 5L,101L,5051L,101021L,9091891L,909189101L,54551346061L,15274376897081L,7637188448540501L,152743768970810021L,3054875379416200421L,BigInteger.Parse("610975075883240084201"),BigInteger.Parse("12219501517664801684021") };
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
public class A113073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113073Inst Instance=new A113073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113074
{
public static readonly BigInteger[] Value={ 3L,37L,1117L,11177L,223547L,26825647L,268256477L,40238471557L,13278695613817L,1195082605243537L,191213216838965927L,BigInteger.Parse("38242643367793185407"),BigInteger.Parse("6883675806202773373267") };
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
public class A113074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113074Inst Instance=new A113074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113075
{
public static readonly BigInteger[] Value={ 3L,31L,311L,6221L,684311L,75274211L,6774678991L,609721109191L,6097211091911L,1463330662058641L,102433146344104871L,18437966341938876781UL,BigInteger.Parse("5531389902581663034301") };
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
public class A113075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113075Inst Instance=new A113075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113076
{
public static readonly BigInteger[] Value={ 17L,277L,37L,47L,577L,67L,877L,97L,107L,11777L,127L,137L,157L,167L,1777L,1877L,197L,20777777L,227L,2377L,2477L,257L,2677L,277L,BigInteger.Parse("29777777777777777777777777777777777777777777777777"),307L,317L,3277777L,337L };
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
public class A113076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113076Inst Instance=new A113076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113077
{
public static readonly BigInteger[] Value={ 1L,3L,15L,123L,1656L,36987L,1391106L,89574978L,10036638270L,1986129275673L,703168200003336L,450303519404234922L,BigInteger.Parse("526421174510139860241"),BigInteger.Parse("1132076561237754405471033"),BigInteger.Parse("4507472672071759672232970720") };
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
public class A113077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113077Inst Instance=new A113077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113078
{
public static readonly BigInteger[] Value={ 1L,4L,26L,274L,4721L,134899L,6501536L,537766009L,77598500096L,19821981700354L,9077118324755246L,7531446638893873684L,BigInteger.Parse("11423775838657143826346"),BigInteger.Parse("31914367054676982206368909"),BigInteger.Parse("165251261153335414813452988541") };
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
public class A113078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113078Inst Instance=new A113078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113079
{
public static readonly BigInteger[] Value={ 1L,5L,40L,515L,10810L,376175L,22099885L,2231417165L,393643922005L,123097221805100L,69087264010363930L,BigInteger.Parse("70321483026073531730"),BigInteger.Parse("130954011392485408662370"),BigInteger.Parse("449450774746306949114288795") };
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
public class A113079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113079Inst Instance=new A113079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113080
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,7L,10L,3L,1L,0L,41L,114L,27L,4L,1L,0L,397L,2970L,693L,56L,5L,1L,0L,6377L,182402L,52812L,2704L,100L,6L,1L,0L,171886L,27392682L,12628008L,481376L,8125L,162L,7L,1L,0L,7892642L,10390564242L,9924266772L,337587520L,2918750L,20502L,245L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113080Inst : IEnumerable<long>
{
public static readonly long[] Value=A113080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113080.Bytes);
public long this[int i]=>Value[i];

public static A113080Inst Instance=new A113080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113081
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,2L,1L,0L,21L,10L,3L,1L,0L,331L,114L,21L,4L,1L,0L,11973L,2970L,331L,36L,5L,1L,0L,1030091L,182402L,11973L,724L,55L,6L,1L,0L,218626341L,27392682L,1030091L,33476L,1345L,78L,7L,1L,0L,118038692523L,10390564242L,218626341L,3697844L,75695L,2246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113081Inst : IEnumerable<long>
{
public static readonly long[] Value=A113081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113081.Bytes);
public long this[int i]=>Value[i];

public static A113081Inst Instance=new A113081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113082
{
public static readonly BigInteger[] Value={ 1L,1L,10L,331L,33476L,10204145L,9378590446L,26026690264407L,218132378185337416L,BigInteger.Parse("5518274388618175447069"),BigInteger.Parse("421034872020570533423509010"),BigInteger.Parse("96809747319527667989371938562883") };
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
public class A113082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113082Inst Instance=new A113082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113083
{
public static readonly BigInteger[] Value={ 1L,2L,21L,724L,75695L,23694838L,22239639177L,62747494950248L,532868670719193651L,BigInteger.Parse("13624738004791751175370"),BigInteger.Parse("1048678107774203901392276461"),BigInteger.Parse("242892250870416811233766661498812") };
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
public class A113083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113083Inst Instance=new A113083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113084
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,21L,33L,13L,1L,331L,586L,294L,40L,1L,11973L,23299L,13768L,2562L,121L,1L,1030091L,2166800L,1447573L,333070L,22569L,364L,1L,218626341L,490872957L,361327779L,97348117L,8466793L,200931L,1093L,1L,118038692523L,280082001078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113084Inst : IEnumerable<long>
{
public static readonly long[] Value=A113084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113084.Bytes);
public long this[int i]=>Value[i];

public static A113084Inst Instance=new A113084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113085
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,331L,11973L,1030091L,218626341L,118038692523L,166013096151621L,619176055256353291L,BigInteger.Parse("6207997057962300681573"),BigInteger.Parse("169117528577725378851523691"),BigInteger.Parse("12626174170113987651028630856581"),BigInteger.Parse("2602022118010488151483064379958957003") };
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
public class A113085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113085Inst Instance=new A113085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113086
{
public static readonly BigInteger[] Value={ 1L,4L,33L,586L,23299L,2166800L,490872957L,280082001078L,412989850899863L,1604627387895595612L,BigInteger.Parse("16673986511766782602033"),BigInteger.Parse("468802076619022792385223170"),BigInteger.Parse("35999655498002937223238590342603") };
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
public class A113086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113086Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113086.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113086Inst Instance=new A113086Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113087
{
public static readonly BigInteger[] Value={ 1L,2L,8L,68L,1252L,51724L,5000468L,1176844012L,696653833108L,1063944196415276L,4273738134967763028L,BigInteger.Parse("45828521528368595280876"),BigInteger.Parse("1327368163105850592309345044"),BigInteger.Parse("104832927462400739554960944906668") };
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
public class A113087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113087Inst Instance=new A113087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113088
{
public static readonly long[] Value={ 1L,2L,1L,10L,8L,1L,114L,118L,26L,1L,2970L,3668L,1108L,80L,1L,182402L,257122L,96416L,9964L,242L,1L,27392682L,42821472L,18871894L,2501468L,89182L,728L,1L,10390564242L,17650889358L,8826033518L,1412198686L,65914154L,799714L,2186L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113088Inst : IEnumerable<long>
{
public static readonly long[] Value=A113088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113088.Bytes);
public long this[int i]=>Value[i];

public static A113088Inst Instance=new A113088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113089
{
public static readonly BigInteger[] Value={ 1L,2L,10L,114L,2970L,182402L,27392682L,10390564242L,10210795262650L,26494519967902114L,BigInteger.Parse("184142934938620227530"),BigInteger.Parse("3466516611360924222460082"),BigInteger.Parse("178346559667060145108789818842"),BigInteger.Parse("25264074391478558474014952210052802") };
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
public class A113089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113089Inst Instance=new A113089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113090
{
public static readonly long[] Value={ 1L,3L,1L,21L,12L,1L,331L,255L,39L,1L,11973L,11326L,2442L,120L,1L,1030091L,1136709L,310864L,22206L,363L,1L,218626341L,272246616L,89081163L,8266954L,199839L,1092L,1L,118038692523L,162043308555L,61099562421L,6923071251L,220482175L,1796349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113090Inst : IEnumerable<long>
{
public static readonly long[] Value=A113090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113090.Bytes);
public long this[int i]=>Value[i];

public static A113090Inst Instance=new A113090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113091
{
public static readonly BigInteger[] Value={ 1L,12L,255L,11326L,1136709L,272246616L,162043308555L,246976754748242L,985451332639242321L,BigInteger.Parse("10465989453804481920460"),BigInteger.Parse("299684548041297413533699479"),BigInteger.Parse("23373481327888949572209959486022"),BigInteger.Parse("5007060652963472122780384849366677469") };
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
public class A113091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113091Inst Instance=new A113091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113092
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,4L,2L,1L,0L,46L,13L,3L,1L,0L,1504L,242L,27L,4L,1L,0L,146821L,13228L,693L,46L,5L,1L,0L,45236404L,2241527L,52812L,1504L,70L,6L,1L,0L,46002427696L,1237069018L,12628008L,146821L,2780L,99L,7L,1L,0L,159443238441379L,2305369985312L,9924266772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113092Inst : IEnumerable<long>
{
public static readonly long[] Value=A113092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113092.Bytes);
public long this[int i]=>Value[i];

public static A113092Inst Instance=new A113092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113093
{
public static readonly BigInteger[] Value={ 1L,1L,13L,693L,146821L,124626530L,426524622399L,5893207147435867L,BigInteger.Parse("328422072384464274577"),BigInteger.Parse("73719657441008064407836359"),BigInteger.Parse("66567306698774377126527799872190") };
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
public class A113093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113093Inst Instance=new A113093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113094
{
public static readonly BigInteger[] Value={ 1L,2L,27L,1504L,330745L,289031301L,1011348629263L,14213347986246578L,BigInteger.Parse("802722082112213275116"),BigInteger.Parse("182118530044524172384716760"),BigInteger.Parse("165892108866362877173717099499469") };
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
public class A113094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113094Inst Instance=new A113094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113095
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,1L,46L,66L,21L,1L,1504L,2398L,978L,85L,1L,146821L,255113L,122914L,14962L,341L,1L,45236404L,84425001L,46001193L,7046354L,235122L,1365L,1L,46002427696L,91159696960L,54661544301L,9933169553L,432627794L,3738738L,5461L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113095Inst : IEnumerable<long>
{
public static readonly long[] Value=A113095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113095.Bytes);
public long this[int i]=>Value[i];

public static A113095Inst Instance=new A113095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113096
{
public static readonly BigInteger[] Value={ 1L,1L,4L,46L,1504L,146821L,45236404L,46002427696L,159443238441379L,1926751765436372746L,BigInteger.Parse("82540801108546193896804"),BigInteger.Parse("12696517688186899788062326096"),BigInteger.Parse("7084402815778394692932546017050054") };
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
public class A113096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113096Inst Instance=new A113096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113097
{
public static readonly long[] Value={ 1L,2L,1L,13L,10L,1L,242L,237L,42L,1L,13228L,15296L,3741L,170L,1L,2241527L,2930006L,893528L,58909L,682L,1L,1237069018L,1775967132L,637702746L,54501208L,935709L,2730L,1L,2305369985312L,3563503353790L,1451785389252L,151058838746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113097Inst : IEnumerable<long>
{
public static readonly long[] Value=A113097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113097.Bytes);
public long this[int i]=>Value[i];

public static A113097Inst Instance=new A113097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113098
{
public static readonly BigInteger[] Value={ 1L,2L,13L,242L,13228L,2241527L,1237069018L,2305369985312L,14874520949557933L,BigInteger.Parse("338242806223319079422"),BigInteger.Parse("27474512329417917714396073"),BigInteger.Parse("8057337874806992183898478061882"),BigInteger.Parse("8607002252619465665736907583406214288") };
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
public class A113098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113098Inst Instance=new A113098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113099
{
public static readonly long[] Value={ 1L,3L,1L,27L,15L,1L,693L,513L,63L,1L,52812L,47619L,8289L,255L,1L,12628008L,13176189L,2920527L,131841L,1023L,1L,9924266772L,11586274263L,3078907929L,181929087L,2101761L,4095L,1L,26507035453923L,33825995695125L,10365262415703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113099Inst : IEnumerable<long>
{
public static readonly long[] Value=A113099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113099.Bytes);
public long this[int i]=>Value[i];

public static A113099Inst Instance=new A113099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113100
{
public static readonly BigInteger[] Value={ 1L,3L,27L,693L,52812L,12628008L,9924266772L,26507035453923L,246323730279500082L,BigInteger.Parse("8100479557816637139288"),BigInteger.Parse("954983717308947379891713642"),BigInteger.Parse("407790020849346203244152231395953") };
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
public class A113100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113100Inst Instance=new A113100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113101
{
public static readonly long[] Value={ 1L,4L,1L,46L,20L,1L,1504L,894L,84L,1L,146821L,108292L,14622L,340L,1L,45236404L,39188597L,6812596L,233758L,1364L,1L,46002427696L,45157269264L,9504275037L,428894516L,3733278L,5460L,1L,159443238441379L,172969059719500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113101Inst : IEnumerable<long>
{
public static readonly long[] Value=A113101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113101.Bytes);
public long this[int i]=>Value[i];

public static A113101Inst Instance=new A113101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113102
{
public static readonly BigInteger[] Value={ 1L,20L,894L,108292L,39188597L,45157269264L,172969059719500L,2268555493366383236L,BigInteger.Parse("104065414379018585400528"),BigInteger.Parse("16965802042440759287849083708"),BigInteger.Parse("9953305892540385313201626908460431") };
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
public class A113102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113102Inst Instance=new A113102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113103
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,5L,2L,1L,0L,85L,16L,3L,1L,0L,4985L,440L,33L,4L,1L,0L,1082905L,43600L,1251L,56L,5L,1L,0L,930005021L,16698560L,173505L,2704L,85L,6L,1L,0L,3306859233805L,26098464448L,94216515L,481376L,4985L,120L,7L,1L,0L,50220281721033905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113103Inst : IEnumerable<long>
{
public static readonly long[] Value=A113103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113103.Bytes);
public long this[int i]=>Value[i];

public static A113103Inst Instance=new A113103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113104
{
public static readonly BigInteger[] Value={ 1L,1L,16L,1251L,481376L,930005021L,9082872004032L,448356882751890343L,BigInteger.Parse("111655372144044770735104"),BigInteger.Parse("140027604270897805074354921849"),BigInteger.Parse("883117855371077265832943940474315776") };
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
public class A113104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113104Inst Instance=new A113104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113105
{
public static readonly BigInteger[] Value={ 1L,2L,33L,2704L,1082905L,2156566656L,21543117605345L,1081795451307347456L,BigInteger.Parse("273019500242348456497329"),BigInteger.Parse("346065491936438505902218920448"),BigInteger.Parse("2201645604139293737199292995777020545") };
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
public class A113105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113105Inst Instance=new A113105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113106
{
public static readonly long[] Value={ 1L,1L,1L,5L,6L,1L,85L,115L,31L,1L,4985L,7420L,2590L,156L,1L,1082905L,1744965L,723370L,62090L,781L,1L,930005021L,1601759426L,752616215L,82390620L,1532715L,3906L,1L,3306859233805L,6024941167511L,3117415999361L,409321203715L,10025307495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113106Inst : IEnumerable<long>
{
public static readonly long[] Value=A113106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113106.Bytes);
public long this[int i]=>Value[i];

public static A113106Inst Instance=new A113106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113107
{
public static readonly BigInteger[] Value={ 1L,1L,5L,85L,4985L,1082905L,930005021L,3306859233805L,50220281721033905L,BigInteger.Parse("3328966349792343354865"),BigInteger.Parse("978820270264589718999911669"),BigInteger.Parse("1292724512951963810375572954693765") };
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
public class A113107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113107Inst Instance=new A113107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113108
{
public static readonly long[] Value={ 1L,2L,1L,16L,12L,1L,440L,416L,62L,1L,43600L,48320L,10016L,312L,1L,16698560L,20765520L,5394320L,246016L,1562L,1L,26098464448L,35382716032L,10854556720L,646408320L,6116016L,7812L,1L,172513149018752L,250136469031744L,87213434633152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113108Inst : IEnumerable<long>
{
public static readonly long[] Value=A113108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113108.Bytes);
public long this[int i]=>Value[i];

public static A113108Inst Instance=new A113108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113109
{
public static readonly BigInteger[] Value={ 1L,2L,16L,440L,43600L,16698560L,26098464448L,172513149018752L,4938593053649344000L,BigInteger.Parse("622793203804403960906240"),BigInteger.Parse("350552003258337075784341271552"),BigInteger.Parse("890153650520295355798989668668129280") };
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
public class A113109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113109Inst Instance=new A113109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113110
{
public static readonly long[] Value={ 1L,3L,1L,33L,18L,1L,1251L,903L,93L,1L,173505L,151716L,22278L,468L,1L,94216515L,94758285L,17789766L,551778L,2343L,1L,210576669921L,235461277878L,53137278735L,2167944516L,13749903L,11718L,1L,2002383115518243L,2432344424403219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113110Inst : IEnumerable<long>
{
public static readonly long[] Value=A113110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113110.Bytes);
public long this[int i]=>Value[i];

public static A113110Inst Instance=new A113110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113111
{
public static readonly BigInteger[] Value={ 1L,3L,33L,1251L,173505L,94216515L,210576669921L,2002383115518243L,BigInteger.Parse("82856383278525698433"),BigInteger.Parse("15166287556997012904054915"),BigInteger.Parse("12437232461209961704387810340769") };
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
public class A113111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113111Inst Instance=new A113111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113112
{
public static readonly long[] Value={ 1L,4L,1L,56L,24L,1L,2704L,1576L,124L,1L,481376L,346624L,39376L,624L,1L,337587520L,284081376L,41686624L,979376L,3124L,1L,978162377600L,927672109184L,165184873376L,5122890624L,24434376L,15624L,1L,12088945462984960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113112Inst : IEnumerable<long>
{
public static readonly long[] Value=A113112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113112.Bytes);
public long this[int i]=>Value[i];

public static A113112Inst Instance=new A113112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113113
{
public static readonly BigInteger[] Value={ 1L,4L,56L,2704L,481376L,337587520L,978162377600L,12088945462984960L,BigInteger.Parse("651451173346940188160"),BigInteger.Parse("155573037664478034394215424"),BigInteger.Parse("166729581953452524706695313356800") };
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
public class A113113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113113Inst Instance=new A113113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113114
{
public static readonly long[] Value={ 1L,5L,1L,85L,30L,1L,4985L,2435L,155L,1L,1082905L,662060L,61310L,780L,1L,930005021L,671754405L,80861810L,1528810L,3905L,1L,3306859233805L,2718081933706L,399334065655L,9987138060L,38169435L,19530L,1L,50220281721033905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113114Inst : IEnumerable<long>
{
public static readonly long[] Value=A113114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113114.Bytes);
public long this[int i]=>Value[i];

public static A113114Inst Instance=new A113114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113115
{
public static readonly long[] Value={ 3L,13L,37L,43L,61L,103L,127L,157L,181L,223L,241L,283L,313L,373L,421L,463L,523L,541L,577L,607L,631L,661L,673L,787L,811L,853L,883L,1021L,1087L,1093L,1153L,1231L,1237L,1297L,1303L,1531L,1567L,1741L,1753L,1777L,1783L,1867L,2113L,2131L,2143L,2161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113115Inst : IEnumerable<long>
{
public static readonly long[] Value=A113115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113115.Bytes);
public long this[int i]=>Value[i];

public static A113115Inst Instance=new A113115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113116
{
public static readonly long[] Value={ 1L,3L,9L,2071723L,6215169L,18645507L,5363222357L,16089667071L,48269001213L,11111111111111111L,33333333333333333L,99999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113116Inst : IEnumerable<long>
{
public static readonly long[] Value=A113116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113116.Bytes);
public long this[int i]=>Value[i];

public static A113116Inst Instance=new A113116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113117
{
public static readonly long[] Value={ 2L,4L,6L,10L,15L,26L,46L,86L,166L,326L,634L,1262L,2518L,5006L,10006L,19946L,39874L,79738L,159398L,318778L,637502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113117Inst : IEnumerable<long>
{
public static readonly long[] Value=A113117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113117.Bytes);
public long this[int i]=>Value[i];

public static A113117Inst Instance=new A113117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113118
{
public static readonly long[] Value={ 2L,4L,6L,10L,14L,26L,46L,86L,166L,326L,634L,1262L,2518L,5006L,10006L,19946L,39874L,79738L,159398L,318778L,637502L,1274998L,2549978L,5099902L,10199786L,20399534L,40799062L,81598082L,163196134L,326392258L,652784498L,1305568942L,2611137838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113118Inst : IEnumerable<long>
{
public static readonly long[] Value=A113118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113118.Bytes);
public long this[int i]=>Value[i];

public static A113118Inst Instance=new A113118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113119
{
public static readonly BigInteger[] Value={ 10L,180L,2700L,36000L,450000L,5400000L,63000000L,720000000L,8100000000L,90000000000L,990000000000L,10800000000000L,117000000000000L,1260000000000000L,13500000000000000L,144000000000000000L,1530000000000000000L,16200000000000000000UL,BigInteger.Parse("171000000000000000000") };
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
public class A113119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113119Inst Instance=new A113119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113120
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,2L,2L,2L,2L,1L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,3L,3L,4L,3L,3L,3L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,1L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113120Inst : IEnumerable<long>
{
public static readonly long[] Value=A113120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113120.Bytes);
public long this[int i]=>Value[i];

public static A113120Inst Instance=new A113120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113121
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113121Inst : IEnumerable<long>
{
public static readonly long[] Value=A113121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113121.Bytes);
public long this[int i]=>Value[i];

public static A113121Inst Instance=new A113121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113122
{
public static readonly BigInteger[] Value={ 1L,2L,4L,7L,14L,32L,107L,724L,18616L,4117597L,28878084584L,53183366452504936L,BigInteger.Parse("794001316484619940422835765"),BigInteger.Parse("25210343943654420841949267608211227900299990") };
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
public class A113122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113122Inst Instance=new A113122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113123
{
public static readonly long[] Value={ 0L,1L,2L,2L,16L,22L,70L,106L,1836L,2639L,14281L,21167L,167857L,87932L,169452L,923889L,3590229L,950596L,40366604L,23213361L,517630L,1391957L,160363133L,222528683L,10125035246L,4324958013L,81828906108L,71315450571L,4320297286472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113123Inst : IEnumerable<long>
{
public static readonly long[] Value=A113123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113123.Bytes);
public long this[int i]=>Value[i];

public static A113123Inst Instance=new A113123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113124
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,9L,27L,39L,649L,901L,4729L,6821L,52783L,27043L,51067L,273281L,1043807L,271979L,11378119L,6452207L,141997L,377141L,42943389L,58933037L,2653340203L,1122077597L,21027833867L,18159496967L,1090528730477L,236529224117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113124Inst : IEnumerable<long>
{
public static readonly long[] Value=A113124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113124.Bytes);
public long this[int i]=>Value[i];

public static A113124Inst Instance=new A113124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113125
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,0L,2L,3L,4L,0L,0L,3L,4L,5L,0L,0L,0L,4L,5L,6L,0L,0L,0L,0L,5L,6L,7L,0L,0L,0L,0L,0L,6L,7L,8L,0L,0L,0L,0L,0L,0L,7L,8L,9L,0L,0L,0L,0L,0L,0L,0L,8L,9L,10L,0L,0L,0L,0L,0L,0L,0L,0L,9L,10L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,11L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,12L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113125Inst : IEnumerable<long>
{
public static readonly long[] Value=A113125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113125.Bytes);
public long this[int i]=>Value[i];

public static A113125Inst Instance=new A113125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113126
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,0L,2L,3L,4L,5L,0L,0L,3L,4L,5L,6L,0L,0L,0L,4L,5L,6L,7L,0L,0L,0L,0L,5L,6L,7L,8L,0L,0L,0L,0L,0L,6L,7L,8L,9L,0L,0L,0L,0L,0L,0L,7L,8L,9L,10L,0L,0L,0L,0L,0L,0L,0L,8L,9L,10L,11L,0L,0L,0L,0L,0L,0L,0L,0L,9L,10L,11L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,11L,12L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113126Inst : IEnumerable<long>
{
public static readonly long[] Value=A113126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113126.Bytes);
public long this[int i]=>Value[i];

public static A113126Inst Instance=new A113126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113127
{
public static readonly long[] Value={ 1L,3L,6L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,70L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113127Inst : IEnumerable<long>
{
public static readonly long[] Value=A113127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113127.Bytes);
public long this[int i]=>Value[i];

public static A113127Inst Instance=new A113127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113128
{
public static readonly long[] Value={ 1L,3L,2L,3L,6L,3L,1L,6L,9L,4L,0L,2L,9L,12L,5L,0L,0L,3L,12L,15L,6L,0L,0L,0L,4L,15L,18L,7L,0L,0L,0L,0L,5L,18L,21L,8L,0L,0L,0L,0L,0L,6L,21L,24L,9L,0L,0L,0L,0L,0L,0L,7L,24L,27L,10L,0L,0L,0L,0L,0L,0L,0L,8L,27L,30L,11L,0L,0L,0L,0L,0L,0L,0L,0L,9L,30L,33L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,33L,36L,13L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113128Inst : IEnumerable<long>
{
public static readonly long[] Value=A113128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113128.Bytes);
public long this[int i]=>Value[i];

public static A113128Inst Instance=new A113128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113129
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,1L,6L,0L,0L,0L,10L,24L,0L,0L,0L,4L,82L,120L,0L,0L,0L,0L,84L,672L,720L,0L,0L,0L,0L,27L,1236L,5820L,5040L,0L,0L,0L,0L,0L,930L,16328L,54288L,40320L,0L,0L,0L,0L,0L,248L,20850L,211080L,548496L,362880L,0L,0L,0L,0L,0L,0L,12452L,396528L,2775432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113129Inst : IEnumerable<long>
{
public static readonly long[] Value=A113129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113129.Bytes);
public long this[int i]=>Value[i];

public static A113129Inst Instance=new A113129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113130
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,171L,2214L,35910L,694980L,15567795L,395396478L,11218141170L,351527039676L,12056563337598L,449255267318844L,18074052522890604L,780881956274215944L,BigInteger.Parse("36062953309417344579"),BigInteger.Parse("1772992806860541951342") };
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
public class A113130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113130Inst Instance=new A113130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113131
{
public static readonly BigInteger[] Value={ 1L,1L,4L,32L,400L,6784L,144128L,3658752L,107686656L,3599697920L,134617038848L,5567255822336L,252278661832704L,12431395516383232L,661885541595873280L,BigInteger.Parse("37869659304097218560"),BigInteger.Parse("2317293119684500193280"),BigInteger.Parse("151022143036329696952320") };
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
public class A113131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113131Inst Instance=new A113131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113132
{
public static readonly BigInteger[] Value={ 1L,1L,5L,50L,775L,16250L,426750L,13402500L,488566875L,20249281250L,939823431250L,48278138937500L,2719288331093750L,166652371531562500L,11040797013538437500UL,BigInteger.Parse("786338134640203125000"),BigInteger.Parse("59916445436152444921875") };
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
public class A113132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113132Inst Instance=new A113132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113133
{
public static readonly BigInteger[] Value={ 1L,1L,6L,72L,1332L,33264L,1040256L,38926656L,1692061488L,83688313536L,4638320578944L,284692939944192L,19169186341398912L,1404935464314299904L,BigInteger.Parse("111348880778746460160"),BigInteger.Parse("9489756817594314049536"),BigInteger.Parse("865470841829802331976448") };
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
public class A113133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113133Inst Instance=new A113133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113134
{
public static readonly BigInteger[] Value={ 1L,1L,7L,98L,2107L,61054L,2215094L,96203268L,4856212179L,279081882086L,17981777803682L,1283631249683804L,100557420457355358L,8577121056958121836L,BigInteger.Parse("791318123914138366924"),BigInteger.Parse("78521346319092948749576") };
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
public class A113134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113134Inst Instance=new A113134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113135
{
public static readonly BigInteger[] Value={ 1L,1L,8L,128L,3136L,103424L,4270080L,211107840L,12135936000L,794618298368L,58355305676800L,4749550536359936L,424336070117163008L,BigInteger.Parse("41287521140173963264"),BigInteger.Parse("4346005245162898325504"),BigInteger.Parse("492102089936714946576384") };
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
public class A113135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A113135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113135Inst Instance=new A113135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113136
{
public static readonly long[] Value={ -1L,0L,1L,-2L,-1L,1L,2L,-3L,-3L,-2L,-1L,1L,2L,3L,3L,-4L,-4L,-3L,-1L,1L,3L,4L,4L,-5L,-5L,-5L,-5L,-4L,-3L,-2L,-1L,1L,2L,3L,4L,5L,5L,5L,5L,-6L,-6L,-5L,-1L,1L,5L,6L,6L,-7L,-7L,-7L,-7L,-7L,-7L,-6L,-5L,-4L,-3L,-2L,-1L,1L,2L,3L,4L,5L,6L,7L,7L,7L,7L,7L,7L,-8L,-8L,-8L,-8L,-7L,-5L,-3L,-1L,1L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113136Inst : IEnumerable<long>
{
public static readonly long[] Value=A113136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113136.Bytes);
public long this[int i]=>Value[i];

public static A113136Inst Instance=new A113136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113137
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,3L,3L,3L,2L,1L,1L,3L,4L,4L,4L,4L,3L,1L,1L,2L,3L,4L,5L,5L,5L,5L,5L,5L,5L,5L,4L,3L,2L,1L,1L,5L,6L,6L,6L,6L,5L,1L,1L,2L,3L,4L,5L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,6L,5L,4L,3L,2L,1L,1L,3L,5L,7L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,3L,1L,1L,2L,4L,5L,7L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113137Inst : IEnumerable<long>
{
public static readonly long[] Value=A113137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113137.Bytes);
public long this[int i]=>Value[i];

public static A113137Inst Instance=new A113137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113138
{
public static readonly long[] Value={ 1L,3L,4L,5L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,3L,4L,1L,2L,3L,1L,2L,3L,4L,1L,3L,4L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,3L,4L,5L,1L,2L,3L,4L,1L,3L,4L,1L,2L,3L,1L,3L,4L,1L,2L,3L,1L,2L,3L,4L,1L,3L,4L,5L,1L,2L,3L,4L,1L,3L,4L,1L,2L,3L,1L,3L,4L,1L,2L,3L,1L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113138Inst : IEnumerable<long>
{
public static readonly long[] Value=A113138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113138.Bytes);
public long this[int i]=>Value[i];

public static A113138Inst Instance=new A113138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113139
{
public static readonly long[] Value={ 1L,3L,1L,13L,5L,1L,63L,25L,7L,1L,321L,129L,41L,9L,1L,1683L,681L,231L,61L,11L,1L,8989L,3653L,1289L,377L,85L,13L,1L,48639L,19825L,7183L,2241L,575L,113L,15L,1L,265729L,108545L,40081L,13073L,3649L,833L,145L,17L,1L,1462563L,598417L,224143L,75517L,22363L,5641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113139Inst : IEnumerable<long>
{
public static readonly long[] Value=A113139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113139.Bytes);
public long this[int i]=>Value[i];

public static A113139Inst Instance=new A113139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113140
{
public static readonly long[] Value={ 1L,3L,14L,68L,347L,1819L,9712L,52532L,286905L,1578679L,8738278L,48601968L,271406347L,1520725095L,8545396208L,48138689272L,271768537793L,1537212749339L,8709732836238L,49423440297324L,280835252080651L,1597731101233763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113140Inst : IEnumerable<long>
{
public static readonly long[] Value=A113140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113140.Bytes);
public long this[int i]=>Value[i];

public static A113140Inst Instance=new A113140Inst();

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