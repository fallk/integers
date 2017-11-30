using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112041
{
public static readonly long[] Value={ 4L,60L,180L,760L,910L,1020L,1230L,1600L,1860L,2160L,2280L,2440L,3850L,5800L,7320L,8680L,12940L,13780L,14740L,17350L,17400L,21840L,22720L,22960L,26040L,27010L,31050L,33870L,34060L,35200L,39900L,40030L,44350L,45280L,45540L,45750L,50460L,52050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112041Inst : IEnumerable<long>
{
public static readonly long[] Value=A112041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112041.Bytes);
public long this[int i]=>Value[i];

public static A112041Inst Instance=new A112041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112042
{
public static readonly long[] Value={ 60L,760L,2440L,5800L,8680L,17350L,21840L,27010L,40030L,84060L,108010L,109890L,131110L,222940L,277750L,309120L,313030L,334170L,346140L,348660L,356500L,358330L,387160L,419230L,470880L,553410L,578820L,604030L,683340L,729820L,799890L,801630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112042Inst : IEnumerable<long>
{
public static readonly long[] Value=A112042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112042.Bytes);
public long this[int i]=>Value[i];

public static A112042Inst Instance=new A112042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112043
{
public static readonly long[] Value={ 1171240L,1197630L,2023140L,3592890L,4132590L,4151910L,4254250L,4484760L,5167050L,5486110L,7121590L,7279930L,12524820L,13527640L,13595470L,15998640L,17211040L,17269000L,18570370L,20040300L,20402760L,21135310L,21735420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112043Inst : IEnumerable<long>
{
public static readonly long[] Value=A112043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112043.Bytes);
public long this[int i]=>Value[i];

public static A112043Inst Instance=new A112043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112044
{
public static readonly long[] Value={ 1L,5L,17L,57L,169L,521L,1353L,3529L,8393L,20169L,49865L,113353L,264905L,600777L,1305289L,2845385L,6318793L,14052041L,30042825L,65170121L,139619017L,292711113L,624061129L,1320315593L,2813487817L,6068267721L,12846262985L,26670688969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112044Inst : IEnumerable<long>
{
public static readonly long[] Value=A112044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112044.Bytes);
public long this[int i]=>Value[i];

public static A112044Inst Instance=new A112044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112045
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,10L,13L,15L,19L,24L,26L,31L,35L,37L,41L,46L,52L,54L,59L,63L,65L,71L,74L,80L,88L,91L,93L,97L,99L,103L,116L,120L,126L,128L,137L,139L,145L,151L,155L,160L,166L,168L,178L,180L,183L,185L,197L,209L,212L,214L,218L,224L,226L,236L,241L,247L,253L,255L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112045Inst : IEnumerable<long>
{
public static readonly long[] Value=A112045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112045.Bytes);
public long this[int i]=>Value[i];

public static A112045Inst Instance=new A112045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112046
{
public static readonly long[] Value={ 2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,5L,7L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,7L,5L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,7L,11L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,5L,5L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,5L,13L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,7L,5L,2L,2L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112046Inst : IEnumerable<long>
{
public static readonly long[] Value=A112046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112046.Bytes);
public long this[int i]=>Value[i];

public static A112046Inst Instance=new A112046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112047
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,11L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112047Inst : IEnumerable<long>
{
public static readonly long[] Value=A112047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112047.Bytes);
public long this[int i]=>Value[i];

public static A112047Inst Instance=new A112047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112048
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,11L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,13L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,17L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,19L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112048Inst : IEnumerable<long>
{
public static readonly long[] Value=A112048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112048.Bytes);
public long this[int i]=>Value[i];

public static A112048Inst Instance=new A112048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112049
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,3L,4L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,3L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,5L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,3L,6L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,3L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112049Inst : IEnumerable<long>
{
public static readonly long[] Value=A112049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112049.Bytes);
public long this[int i]=>Value[i];

public static A112049Inst Instance=new A112049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112050
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,6L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,6L,4L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,6L,10L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,12L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,6L,4L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112050Inst : IEnumerable<long>
{
public static readonly long[] Value=A112050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112050.Bytes);
public long this[int i]=>Value[i];

public static A112050Inst Instance=new A112050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112051
{
public static readonly long[] Value={ 1L,3L,11L,24L,60L,84L,144L,180L,264L,420L,480L,684L,840L,924L,1104L,1404L,1740L,1860L,2244L,2520L,2664L,3120L,3444L,3960L,4704L,5100L,5304L,5724L,5940L,6384L,8064L,8580L,9384L,9660L,11100L,11400L,12324L,13284L,13944L,14964L,16020L,16380L,18240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112051Inst : IEnumerable<long>
{
public static readonly long[] Value=A112051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112051.Bytes);
public long this[int i]=>Value[i];

public static A112051Inst Instance=new A112051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112052
{
public static readonly long[] Value={ 3L,7L,23L,49L,121L,169L,289L,361L,529L,841L,961L,1369L,1681L,1849L,2209L,2809L,3481L,3721L,4489L,5041L,5329L,6241L,6889L,7921L,9409L,10201L,10609L,11449L,11881L,12769L,16129L,17161L,18769L,19321L,22201L,22801L,24649L,26569L,27889L,29929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112052Inst : IEnumerable<long>
{
public static readonly long[] Value=A112052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112052.Bytes);
public long this[int i]=>Value[i];

public static A112052Inst Instance=new A112052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112053
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,-6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112053Inst : IEnumerable<long>
{
public static readonly long[] Value=A112053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112053.Bytes);
public long this[int i]=>Value[i];

public static A112053Inst Instance=new A112053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112054
{
public static readonly long[] Value={ 12L,18L,30L,42L,48L,72L,78L,90L,102L,108L,120L,132L,138L,162L,168L,180L,192L,198L,210L,222L,228L,240L,252L,258L,282L,288L,300L,312L,318L,330L,342L,348L,372L,378L,390L,402L,408L,420L,432L,438L,450L,462L,468L,492L,498L,510L,522L,528L,540L,552L,558L,582L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112054Inst : IEnumerable<long>
{
public static readonly long[] Value=A112054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112054.Bytes);
public long this[int i]=>Value[i];

public static A112054Inst Instance=new A112054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112055
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,12L,13L,15L,17L,18L,20L,22L,23L,27L,28L,30L,32L,33L,35L,37L,38L,40L,42L,43L,47L,48L,50L,52L,53L,55L,57L,58L,62L,63L,65L,67L,68L,70L,72L,73L,75L,77L,78L,82L,83L,85L,87L,88L,90L,92L,93L,97L,98L,100L,102L,103L,107L,108L,110L,112L,113L,117L,118L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112055Inst : IEnumerable<long>
{
public static readonly long[] Value=A112055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112055.Bytes);
public long this[int i]=>Value[i];

public static A112055Inst Instance=new A112055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112056
{
public static readonly long[] Value={ 47L,71L,119L,167L,191L,287L,311L,359L,407L,431L,479L,527L,551L,647L,671L,719L,767L,791L,839L,887L,911L,959L,1007L,1031L,1127L,1151L,1199L,1247L,1271L,1319L,1367L,1391L,1487L,1511L,1559L,1607L,1631L,1679L,1727L,1751L,1799L,1847L,1871L,1967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112056Inst : IEnumerable<long>
{
public static readonly long[] Value=A112056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112056.Bytes);
public long this[int i]=>Value[i];

public static A112056Inst Instance=new A112056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112057
{
public static readonly long[] Value={ 49L,73L,121L,169L,193L,289L,313L,361L,409L,433L,481L,529L,553L,649L,673L,721L,769L,793L,841L,889L,913L,961L,1009L,1033L,1129L,1153L,1201L,1249L,1273L,1321L,1369L,1393L,1489L,1513L,1561L,1609L,1633L,1681L,1729L,1753L,1801L,1849L,1873L,1969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112057Inst : IEnumerable<long>
{
public static readonly long[] Value=A112057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112057.Bytes);
public long this[int i]=>Value[i];

public static A112057Inst Instance=new A112057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112058
{
public static readonly long[] Value={ 48L,72L,120L,168L,192L,288L,312L,360L,408L,432L,480L,528L,552L,648L,672L,720L,768L,792L,840L,888L,912L,960L,1008L,1032L,1128L,1152L,1200L,1248L,1272L,1320L,1368L,1392L,1488L,1512L,1560L,1608L,1632L,1680L,1728L,1752L,1800L,1848L,1872L,1968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112058Inst : IEnumerable<long>
{
public static readonly long[] Value=A112058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112058.Bytes);
public long this[int i]=>Value[i];

public static A112058Inst Instance=new A112058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112059
{
public static readonly long[] Value={ 2L,-2L,4L,8L,-2L,12L,-6L,12L,2L,-2L,-6L,18L,-6L,2L,-6L,-4L,2L,-2L,18L,2L,-2L,24L,6L,-2L,6L,-8L,4L,2L,-2L,-6L,32L,-6L,2L,-6L,-10L,2L,-2L,28L,2L,-2L,4L,38L,-2L,6L,-6L,4L,2L,-2L,-4L,42L,-6L,2L,-8L,-4L,2L,-2L,2L,-2L,6L,8L,-2L,48L,-6L,4L,2L,-2L,-10L,6L,-12L,2L,-6L,-4L,2L,-2L,2L,-2L,52L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112059Inst : IEnumerable<long>
{
public static readonly long[] Value=A112059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112059.Bytes);
public long this[int i]=>Value[i];

public static A112059Inst Instance=new A112059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112060
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,11L,6L,7L,12L,24L,9L,8L,23L,35L,60L,10L,15L,36L,59L,155L,84L,13L,16L,47L,95L,275L,239L,144L,14L,19L,48L,119L,335L,575L,779L,180L,17L,20L,71L,120L,359L,659L,1499L,2855L,264L,18L,27L,72L,179L,419L,839L,1535L,4199L,5279L,420L,21L,28L,83L,204L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112060Inst : IEnumerable<long>
{
public static readonly long[] Value=A112060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112060.Bytes);
public long this[int i]=>Value[i];

public static A112060Inst Instance=new A112060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112061
{
public static readonly long[] Value={ 1L,3L,2L,11L,4L,5L,24L,12L,7L,6L,60L,35L,23L,8L,9L,84L,155L,59L,36L,15L,10L,144L,239L,275L,95L,47L,16L,13L,180L,779L,575L,335L,119L,48L,19L,14L,264L,2855L,1499L,659L,359L,120L,71L,20L,17L,420L,5279L,4199L,1535L,839L,419L,179L,72L,27L,18L,480L,9095L,7895L,4619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112061Inst : IEnumerable<long>
{
public static readonly long[] Value=A112061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112061.Bytes);
public long this[int i]=>Value[i];

public static A112061Inst Instance=new A112061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112062
{
public static readonly long[] Value={ 3L,4L,7L,8L,15L,16L,19L,20L,27L,28L,31L,32L,39L,40L,43L,44L,51L,52L,55L,56L,63L,64L,67L,68L,75L,76L,79L,80L,87L,88L,91L,92L,99L,100L,103L,104L,111L,112L,115L,116L,123L,124L,127L,128L,135L,136L,139L,140L,147L,148L,151L,152L,159L,160L,163L,164L,171L,172L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112062Inst : IEnumerable<long>
{
public static readonly long[] Value=A112062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112062.Bytes);
public long this[int i]=>Value[i];

public static A112062Inst Instance=new A112062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112063
{
public static readonly long[] Value={ 11L,12L,23L,36L,47L,48L,71L,72L,83L,96L,107L,108L,131L,132L,143L,156L,167L,168L,191L,192L,203L,216L,227L,228L,251L,252L,263L,276L,287L,288L,311L,312L,323L,336L,347L,348L,371L,372L,383L,396L,407L,408L,431L,432L,443L,456L,467L,468L,491L,492L,503L,516L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112063Inst : IEnumerable<long>
{
public static readonly long[] Value=A112063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112063.Bytes);
public long this[int i]=>Value[i];

public static A112063Inst Instance=new A112063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112064
{
public static readonly long[] Value={ 24L,35L,59L,95L,119L,120L,179L,204L,215L,240L,299L,300L,324L,360L,384L,395L,444L,455L,479L,515L,539L,540L,599L,624L,635L,660L,719L,720L,744L,780L,804L,815L,864L,875L,899L,935L,959L,960L,1019L,1044L,1055L,1080L,1139L,1140L,1164L,1200L,1224L,1235L,1284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112064Inst : IEnumerable<long>
{
public static readonly long[] Value=A112064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112064.Bytes);
public long this[int i]=>Value[i];

public static A112064Inst Instance=new A112064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112065
{
public static readonly long[] Value={ 60L,155L,275L,335L,359L,419L,504L,564L,600L,695L,755L,900L,984L,995L,1020L,1079L,1115L,1199L,1259L,1260L,1415L,1440L,1524L,1595L,1619L,1679L,1680L,1824L,1919L,1944L,2015L,2039L,2100L,2184L,2255L,2280L,2339L,2364L,2435L,2519L,2580L,2604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112065Inst : IEnumerable<long>
{
public static readonly long[] Value=A112065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112065.Bytes);
public long this[int i]=>Value[i];

public static A112065Inst Instance=new A112065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112066
{
public static readonly long[] Value={ 84L,239L,575L,659L,839L,1175L,1320L,1344L,1764L,1835L,1955L,2099L,2160L,2375L,2459L,2759L,2784L,2879L,3084L,3299L,3515L,3695L,3779L,3780L,3840L,3935L,4139L,4439L,4475L,4620L,4764L,4800L,4859L,4884L,5040L,5544L,5795L,5964L,6024L,6119L,6155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112066Inst : IEnumerable<long>
{
public static readonly long[] Value=A112066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112066.Bytes);
public long this[int i]=>Value[i];

public static A112066Inst Instance=new A112066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112067
{
public static readonly long[] Value={ 144L,779L,1499L,1535L,3215L,3275L,4044L,4355L,4380L,4535L,5459L,5460L,6864L,6995L,7284L,7379L,7499L,7704L,8315L,8399L,9059L,9420L,9504L,10079L,10164L,10560L,10775L,10980L,11075L,11699L,11760L,11999L,12024L,12455L,12935L,13715L,13775L,14040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112067Inst : IEnumerable<long>
{
public static readonly long[] Value=A112067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112067.Bytes);
public long this[int i]=>Value[i];

public static A112067Inst Instance=new A112067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112068
{
public static readonly long[] Value={ 180L,2855L,4199L,4619L,5195L,5399L,6719L,7475L,8555L,9000L,9815L,10739L,13859L,14340L,16235L,16319L,16524L,17159L,18299L,18564L,18744L,20015L,20579L,21359L,22320L,22524L,22619L,23759L,24275L,24504L,24960L,25884L,26544L,27455L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112068Inst : IEnumerable<long>
{
public static readonly long[] Value=A112068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112068.Bytes);
public long this[int i]=>Value[i];

public static A112068Inst Instance=new A112068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112069
{
public static readonly long[] Value={ 264L,5279L,7895L,17135L,19979L,25475L,26615L,26940L,32579L,34799L,41435L,42900L,43320L,44039L,44459L,46019L,46284L,48959L,51000L,56939L,58560L,61595L,64259L,64595L,65364L,69155L,71135L,72084L,76295L,78624L,79379L,82320L,83159L,83304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112069Inst : IEnumerable<long>
{
public static readonly long[] Value=A112069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112069.Bytes);
public long this[int i]=>Value[i];

public static A112069Inst Instance=new A112069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112070
{
public static readonly long[] Value={ 3L,5L,7L,11L,9L,23L,13L,15L,25L,49L,19L,17L,47L,71L,121L,21L,31L,73L,119L,311L,169L,27L,33L,95L,191L,551L,479L,289L,29L,39L,97L,239L,671L,1151L,1559L,361L,35L,41L,143L,241L,719L,1319L,2999L,5711L,529L,37L,55L,145L,359L,839L,1679L,3071L,8399L,10559L,841L,43L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112070Inst : IEnumerable<long>
{
public static readonly long[] Value=A112070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112070.Bytes);
public long this[int i]=>Value[i];

public static A112070Inst Instance=new A112070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112071
{
public static readonly long[] Value={ 3L,7L,5L,23L,9L,11L,49L,25L,15L,13L,121L,71L,47L,17L,19L,169L,311L,119L,73L,31L,21L,289L,479L,551L,191L,95L,33L,27L,361L,1559L,1151L,671L,239L,97L,39L,29L,529L,5711L,2999L,1319L,719L,241L,143L,41L,35L,841L,10559L,8399L,3071L,1679L,839L,359L,145L,55L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112071Inst : IEnumerable<long>
{
public static readonly long[] Value=A112071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112071.Bytes);
public long this[int i]=>Value[i];

public static A112071Inst Instance=new A112071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112072
{
public static readonly long[] Value={ 7L,9L,15L,17L,31L,33L,39L,41L,55L,57L,63L,65L,79L,81L,87L,89L,103L,105L,111L,113L,127L,129L,135L,137L,151L,153L,159L,161L,175L,177L,183L,185L,199L,201L,207L,209L,223L,225L,231L,233L,247L,249L,255L,257L,271L,273L,279L,281L,295L,297L,303L,305L,319L,321L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112072Inst : IEnumerable<long>
{
public static readonly long[] Value=A112072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112072.Bytes);
public long this[int i]=>Value[i];

public static A112072Inst Instance=new A112072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112073
{
public static readonly long[] Value={ 23L,25L,47L,73L,95L,97L,143L,145L,167L,193L,215L,217L,263L,265L,287L,313L,335L,337L,383L,385L,407L,433L,455L,457L,503L,505L,527L,553L,575L,577L,623L,625L,647L,673L,695L,697L,743L,745L,767L,793L,815L,817L,863L,865L,887L,913L,935L,937L,983L,985L,1007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112073Inst : IEnumerable<long>
{
public static readonly long[] Value=A112073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112073.Bytes);
public long this[int i]=>Value[i];

public static A112073Inst Instance=new A112073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112074
{
public static readonly long[] Value={ 49L,71L,119L,191L,239L,241L,359L,409L,431L,481L,599L,601L,649L,721L,769L,791L,889L,911L,959L,1031L,1079L,1081L,1199L,1249L,1271L,1321L,1439L,1441L,1489L,1561L,1609L,1631L,1729L,1751L,1799L,1871L,1919L,1921L,2039L,2089L,2111L,2161L,2279L,2281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112074Inst : IEnumerable<long>
{
public static readonly long[] Value=A112074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112074.Bytes);
public long this[int i]=>Value[i];

public static A112074Inst Instance=new A112074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112075
{
public static readonly long[] Value={ 121L,311L,551L,671L,719L,839L,1009L,1129L,1201L,1391L,1511L,1801L,1969L,1991L,2041L,2159L,2231L,2399L,2519L,2521L,2831L,2881L,3049L,3191L,3239L,3359L,3361L,3649L,3839L,3889L,4031L,4079L,4201L,4369L,4511L,4561L,4679L,4729L,4871L,5039L,5161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112075Inst : IEnumerable<long>
{
public static readonly long[] Value=A112075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112075.Bytes);
public long this[int i]=>Value[i];

public static A112075Inst Instance=new A112075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112076
{
public static readonly long[] Value={ 169L,479L,1151L,1319L,1679L,2351L,2641L,2689L,3529L,3671L,3911L,4199L,4321L,4751L,4919L,5519L,5569L,5759L,6169L,6599L,7031L,7391L,7559L,7561L,7681L,7871L,8279L,8879L,8951L,9241L,9529L,9601L,9719L,9769L,10081L,11089L,11591L,11929L,12049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112076Inst : IEnumerable<long>
{
public static readonly long[] Value=A112076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112076.Bytes);
public long this[int i]=>Value[i];

public static A112076Inst Instance=new A112076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112077
{
public static readonly long[] Value={ 289L,1559L,2999L,3071L,6431L,6551L,8089L,8711L,8761L,9071L,10919L,10921L,13729L,13991L,14569L,14759L,14999L,15409L,16631L,16799L,18119L,18841L,19009L,20159L,20329L,21121L,21551L,21961L,22151L,23399L,23521L,23999L,24049L,24911L,25871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112077Inst : IEnumerable<long>
{
public static readonly long[] Value=A112077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112077.Bytes);
public long this[int i]=>Value[i];

public static A112077Inst Instance=new A112077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112078
{
public static readonly long[] Value={ 361L,5711L,8399L,9239L,10391L,10799L,13439L,14951L,17111L,18001L,19631L,21479L,27719L,28681L,32471L,32639L,33049L,34319L,36599L,37129L,37489L,40031L,41159L,42719L,44641L,45049L,45239L,47519L,48551L,49009L,49921L,51769L,53089L,54911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112078Inst : IEnumerable<long>
{
public static readonly long[] Value=A112078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112078.Bytes);
public long this[int i]=>Value[i];

public static A112078Inst Instance=new A112078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112079
{
public static readonly long[] Value={ 529L,10559L,15791L,34271L,39959L,50951L,53231L,53881L,65159L,69599L,82871L,85801L,86641L,88079L,88919L,92039L,92569L,97919L,102001L,113879L,117121L,123191L,128519L,129191L,130729L,138311L,142271L,144169L,152591L,157249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112079Inst : IEnumerable<long>
{
public static readonly long[] Value=A112079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112079.Bytes);
public long this[int i]=>Value[i];

public static A112079Inst Instance=new A112079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112080
{
public static readonly long[] Value={ 0L,2L,-2L,0L,4L,0L,8L,-2L,0L,0L,0L,12L,-6L,0L,12L,0L,2L,-2L,0L,-6L,0L,18L,-6L,0L,0L,0L,2L,-6L,0L,-4L,0L,2L,-2L,0L,18L,0L,2L,-2L,0L,24L,0L,6L,-2L,0L,0L,0L,6L,-8L,0L,4L,0L,2L,-2L,0L,-6L,0L,32L,-6L,0L,0L,0L,2L,-6L,0L,-10L,0L,2L,-2L,0L,28L,0L,2L,-2L,0L,4L,0L,38L,-2L,0L,0L,0L,6L,-6L,0L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112080Inst : IEnumerable<long>
{
public static readonly long[] Value=A112080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112080.Bytes);
public long this[int i]=>Value[i];

public static A112080Inst Instance=new A112080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112081
{
public static readonly long[] Value={ 0L,1L,-1L,0L,2L,0L,4L,-1L,0L,0L,0L,6L,-3L,0L,6L,0L,1L,-1L,0L,-3L,0L,9L,-3L,0L,0L,0L,1L,-3L,0L,-2L,0L,1L,-1L,0L,9L,0L,1L,-1L,0L,12L,0L,3L,-1L,0L,0L,0L,3L,-4L,0L,2L,0L,1L,-1L,0L,-3L,0L,16L,-3L,0L,0L,0L,1L,-3L,0L,-5L,0L,1L,-1L,0L,14L,0L,1L,-1L,0L,2L,0L,19L,-1L,0L,0L,0L,3L,-3L,0L,2L,0L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112081Inst : IEnumerable<long>
{
public static readonly long[] Value=A112081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112081.Bytes);
public long this[int i]=>Value[i];

public static A112081Inst Instance=new A112081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112082
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,11L,14L,16L,19L,21L,24L,25L,26L,29L,31L,34L,36L,39L,41L,44L,45L,46L,49L,51L,54L,56L,59L,60L,61L,64L,66L,69L,71L,74L,76L,79L,80L,81L,84L,86L,89L,91L,94L,95L,96L,99L,101L,104L,105L,106L,109L,111L,114L,115L,116L,119L,121L,124L,126L,129L,130L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112082Inst : IEnumerable<long>
{
public static readonly long[] Value=A112082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112082.Bytes);
public long this[int i]=>Value[i];

public static A112082Inst Instance=new A112082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112083
{
public static readonly long[] Value={ 2L,4L,12L,35L,155L,239L,779L,2855L,5279L,9095L,15695L,59135L,350699L,183395L,1352339L,1477295L,1077959L,6922920L,3038555L,12705840L,14199120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112083Inst : IEnumerable<long>
{
public static readonly long[] Value=A112083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112083.Bytes);
public long this[int i]=>Value[i];

public static A112083Inst Instance=new A112083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112084
{
public static readonly long[] Value={ 5L,9L,25L,71L,311L,479L,1559L,5711L,10559L,18191L,31391L,118271L,701399L,366791L,2704679L,2954591L,2155919L,13845841L,6077111L,25411681L,28398241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112084Inst : IEnumerable<long>
{
public static readonly long[] Value=A112084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112084.Bytes);
public long this[int i]=>Value[i];

public static A112084Inst Instance=new A112084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112085
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112085Inst : IEnumerable<long>
{
public static readonly long[] Value=A112085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112085.Bytes);
public long this[int i]=>Value[i];

public static A112085Inst Instance=new A112085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112086
{
public static readonly long[] Value={ 2L,4L,6L,16L,72L,420L,3240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112086Inst : IEnumerable<long>
{
public static readonly long[] Value=A112086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112086.Bytes);
public long this[int i]=>Value[i];

public static A112086Inst Instance=new A112086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112087
{
public static readonly long[] Value={ 4L,12L,28L,52L,84L,124L,172L,228L,292L,364L,444L,532L,628L,732L,844L,964L,1092L,1228L,1372L,1524L,1684L,1852L,2028L,2212L,2404L,2604L,2812L,3028L,3252L,3484L,3724L,3972L,4228L,4492L,4764L,5044L,5332L,5628L,5932L,6244L,6564L,6892L,7228L,7572L,7924L,8284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112087Inst : IEnumerable<long>
{
public static readonly long[] Value=A112087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112087.Bytes);
public long this[int i]=>Value[i];

public static A112087Inst Instance=new A112087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112088
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,16L,24L,36L,54L,81L,122L,183L,274L,411L,617L,925L,1388L,2082L,3123L,4684L,7026L,10539L,15809L,23713L,35570L,53355L,80032L,120048L,180072L,270108L,405162L,607743L,911615L,1367422L,2051133L,3076700L,4615050L,6922575L,10383862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112088Inst : IEnumerable<long>
{
public static readonly long[] Value=A112088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112088.Bytes);
public long this[int i]=>Value[i];

public static A112088Inst Instance=new A112088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112089
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112089Inst : IEnumerable<long>
{
public static readonly long[] Value=A112089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112089.Bytes);
public long this[int i]=>Value[i];

public static A112089Inst Instance=new A112089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112090
{
public static readonly long[] Value={ 7L,11L,13L,15L,21L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112090Inst : IEnumerable<long>
{
public static readonly long[] Value=A112090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112090.Bytes);
public long this[int i]=>Value[i];

public static A112090Inst Instance=new A112090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112091
{
public static readonly long[] Value={ 1L,2L,6L,21L,76L,276L,1001L,3626L,13126L,47501L,171876L,621876L,2250001L,8140626L,29453126L,106562501L,385546876L,1394921876L,5046875001L,18259765626L,66064453126L,239023437501L,864794921876L,3128857421876L,11320312500001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112091Inst : IEnumerable<long>
{
public static readonly long[] Value=A112091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112091.Bytes);
public long this[int i]=>Value[i];

public static A112091Inst Instance=new A112091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112092
{
public static readonly long[] Value={ 3L,5L,7L,17L,11L,13L,43L,257L,19L,41L,23L,241L,2731L,29L,151L,65537L,43691L,37L,174763L,61681L,337L,397L,47L,97L,251L,53L,87211L,15790321L,59L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112092Inst : IEnumerable<long>
{
public static readonly long[] Value=A112092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112092.Bytes);
public long this[int i]=>Value[i];

public static A112092Inst Instance=new A112092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112093
{
public static readonly BigInteger[] Value={ 0L,3L,13L,197L,1105L,9211L,130277L,82987349L,331950131L,16929464521L,29241805241L,3538258509761L,6259995854281L,1057939300471201L,1057939300716589L,51133732870640471L,372975463296151087L,BigInteger.Parse("107789908892879155343"),BigInteger.Parse("51058377896658637853"),BigInteger.Parse("681986753565766904623961") };
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
public class A112093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112093Inst Instance=new A112093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112094
{
public static readonly BigInteger[] Value={ 1L,2L,8L,120L,672L,5600L,79200L,50450400L,201801600L,10291881600L,17776886400L,2151003254400L,3805621142400L,643149973065600L,643149973065600L,31085582031504000L,226741892465088000L,BigInteger.Parse("65528406922410432000"),BigInteger.Parse("31039771700089152000"),BigInteger.Parse("414598230598090803264000"),BigInteger.Parse("16583929223923632130560") };
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
public class A112094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112094Inst Instance=new A112094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112095
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,6L,5L,7L,8L,16L,12L,18L,13L,23L,25L,27L,49L,64L,81L,512L,10L,14L,11L,17L,19L,32L,53L,128L,256L,65536L,36L,37L,61L,125L,169L,343L,529L,625L,729L,2401L,4096L,19683L,262144L,15L,20L,21L,24L,26L,28L,46L,48L,50L,54L,98L,162L,29L,41L,43L,83L,97L,103L,121L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112095Inst : IEnumerable<long>
{
public static readonly long[] Value=A112095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112095.Bytes);
public long this[int i]=>Value[i];

public static A112095Inst Instance=new A112095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112096
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,4L,2L,8L,2L,8L,1L,12L,12L,28L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112096Inst : IEnumerable<long>
{
public static readonly long[] Value=A112096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112096.Bytes);
public long this[int i]=>Value[i];

public static A112096Inst Instance=new A112096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112097
{
public static readonly long[] Value={ 0L,1L,2L,43L,307L,463L,10201L,24121L,88453L,1503743L,28571327L,680271L,54761843L,156462429L,111170677L,245020174253L,7595625419003L,2531875141141L,17723125990639L,655755661678837L,655755661685297L,867289746102097L,1156097231554841431L,1734145847332548163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112097Inst : IEnumerable<long>
{
public static readonly long[] Value=A112097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112097.Bytes);
public long this[int i]=>Value[i];

public static A112097Inst Instance=new A112097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112098
{
public static readonly long[] Value={ 1L,2L,3L,60L,420L,630L,13860L,32760L,120120L,2042040L,38798760L,923780L,74364290L,212469400L,150965100L,332727080400L,10314539492400L,3438179830800L,24067258815600L,890488576177200L,890488576177200L,1177742955589200L,1569931359800403600L,2354897039700605400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112098Inst : IEnumerable<long>
{
public static readonly long[] Value=A112098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112098.Bytes);
public long this[int i]=>Value[i];

public static A112098Inst Instance=new A112098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112099
{
public static readonly long[] Value={ 0L,1L,7L,3L,169L,1523L,133L,72623L,87149L,823077L,15638477L,46915441L,13834041L,224803169L,6936783521L,5587964507L,4157445593923L,12472336782289L,170187831339L,71785227258967L,153825486983593L,4905323862699739L,21820233734078929L,5695081004594650211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112099Inst : IEnumerable<long>
{
public static readonly long[] Value=A112099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112099.Bytes);
public long this[int i]=>Value[i];

public static A112099Inst Instance=new A112099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112100
{
public static readonly ulong[] Value={ 1L,2L,12L,5L,280L,2520L,220L,120120L,144144L,1361360L,25865840L,77597520L,22881320L,371821450L,11473347600L,9242418900L,6876359661600L,20629078984800L,281488407200L,118731810156960L,254425307479200L,8113340360725600L,36090376087365600L,9419588158802421600UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112100Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A112100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112100.Bytes);
public ulong this[int i]=>Value[i];

public static A112100Inst Instance=new A112100Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112101
{
public static readonly BigInteger[] Value={ 1L,3L,10L,58L,722L,19826L,1161882L,141436842L,35192653666L,17733070720738L,17997787816364330L,BigInteger.Parse("36678689328450847514"),BigInteger.Parse("149831453090755680149490"),BigInteger.Parse("1225618861520566592060441682"),BigInteger.Parse("20064594684596858150355969600442"),BigInteger.Parse("657195622713393693107201875915723402") };
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
public class A112101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112101Inst Instance=new A112101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112102
{
public static readonly BigInteger[] Value={ 0L,1L,25L,1129L,63251L,1581371L,52185743L,33242372291L,24176277773L,40688677687159L,2378722720177L,3741730846458901L,86059809503772983L,BigInteger.Parse("72720539036773885963"),BigInteger.Parse("72720539038037143387"),BigInteger.Parse("52722390802769505531767"),BigInteger.Parse("13075152919096992777263341") };
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
public class A112102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112102Inst Instance=new A112102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112103
{
public static readonly BigInteger[] Value={ 1L,2L,48L,2160L,120960L,3024000L,99792000L,63567504000L,46230912000L,77806624896000L,4548694993920L,7155097225436160L,164567236185031680L,BigInteger.Parse("139059314576351769600"),BigInteger.Parse("139059314576351769600"),BigInteger.Parse("100818003067855032960000"),BigInteger.Parse("25002864760828048174080000") };
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
public class A112103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112103Inst Instance=new A112103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112104
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112104Inst : IEnumerable<long>
{
public static readonly long[] Value=A112104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112104.Bytes);
public long this[int i]=>Value[i];

public static A112104Inst Instance=new A112104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112105
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,-3L,7L,-10L,-5L,84L,-248L,90L,2160L,-7541L,-5846L,122824L,-186259L,-2036532L,8665409L,36714511L,-345711246L,-517802065L,14415153844L,-9423161197L,-653074772917L,1896978939457L,32374651932128L,-184814895196023L,-1733326272860598L,16839263882542991L,96742403684106435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112105Inst : IEnumerable<long>
{
public static readonly long[] Value=A112105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112105.Bytes);
public long this[int i]=>Value[i];

public static A112105Inst Instance=new A112105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112106
{
public static readonly long[] Value={ 1L,3L,3L,3L,2L,2L,1L,2L,1L,3L,1L,1L,3L,3L,3L,2L,3L,3L,2L,2L,2L,1L,2L,2L,3L,1L,2L,1L,1L,2L,3L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,1L,1L,1L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,1L,3L,2L,1L,3L,2L,2L,1L,2L,3L,1L,3L,1L,3L,1L,1L,1L,3L,1L,2L,3L,3L,3L,3L,3L,3L,1L,1L,2L,2L,3L,3L,1L,3L,2L,1L,2L,2L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112106Inst : IEnumerable<long>
{
public static readonly long[] Value=A112106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112106.Bytes);
public long this[int i]=>Value[i];

public static A112106Inst Instance=new A112106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112107
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-10L,35L,-119L,360L,-792L,-33L,12779L,-82525L,305861L,-552011L,-126321L,-8385020L,138177591L,-433073834L,-5366414982L,51203452090L,123835509276L,-4174647911014L,5274854624423L,373574363131841L,-2054088594386738L,-34047892948849106L,391005463740951942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112107Inst : IEnumerable<long>
{
public static readonly long[] Value=A112107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112107.Bytes);
public long this[int i]=>Value[i];

public static A112107Inst Instance=new A112107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112108
{
public static readonly long[] Value={ 1L,4L,4L,2L,4L,2L,4L,4L,2L,4L,4L,2L,2L,4L,4L,2L,2L,4L,4L,3L,4L,3L,2L,4L,1L,2L,4L,2L,3L,1L,4L,2L,4L,3L,1L,4L,4L,4L,2L,2L,2L,3L,3L,2L,3L,2L,2L,4L,1L,4L,2L,2L,1L,4L,3L,3L,3L,1L,1L,3L,3L,4L,4L,3L,3L,3L,3L,1L,4L,4L,3L,2L,4L,2L,2L,2L,1L,3L,4L,2L,3L,3L,1L,4L,2L,3L,1L,1L,3L,3L,4L,2L,4L,3L,1L,4L,3L,2L,1L,1L,1L,2L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112108Inst : IEnumerable<long>
{
public static readonly long[] Value=A112108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112108.Bytes);
public long this[int i]=>Value[i];

public static A112108Inst Instance=new A112108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112109
{
public static readonly long[] Value={ 1L,1L,-2L,8L,-38L,194L,-992L,4777L,-19831L,56116L,48008L,-2062286L,16053636L,-70193968L,155216743L,-968038798L,23817048561L,-233579083166L,333773365L,21684104628935L,-121906541882294L,-2171063003748135L,30425707365005935L,192144123118329872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112109Inst : IEnumerable<long>
{
public static readonly long[] Value=A112109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112109.Bytes);
public long this[int i]=>Value[i];

public static A112109Inst Instance=new A112109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112110
{
public static readonly long[] Value={ 1L,5L,5L,5L,5L,5L,4L,4L,4L,4L,3L,1L,1L,1L,5L,3L,1L,1L,5L,3L,4L,3L,2L,1L,5L,4L,1L,4L,1L,5L,1L,4L,5L,4L,2L,1L,5L,2L,5L,4L,5L,5L,4L,1L,1L,5L,4L,3L,5L,1L,5L,2L,2L,3L,1L,3L,2L,5L,2L,5L,3L,2L,3L,5L,2L,1L,2L,3L,1L,5L,1L,4L,5L,4L,3L,3L,2L,4L,2L,3L,4L,5L,2L,5L,5L,2L,4L,2L,3L,5L,3L,2L,4L,2L,2L,1L,1L,2L,3L,4L,5L,3L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112110Inst : IEnumerable<long>
{
public static readonly long[] Value=A112110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112110.Bytes);
public long this[int i]=>Value[i];

public static A112110Inst Instance=new A112110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112111
{
public static readonly long[] Value={ 1L,1L,-3L,17L,-115L,841L,-6288L,46174L,-320366L,1997348L,-10216611L,32418767L,68603755L,-1909624513L,15239954041L,-103620859984L,1499179409198L,-25808959095992L,258001631302410L,-239530586418995L,-25424691109062239L,84868851253494310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112111Inst : IEnumerable<long>
{
public static readonly long[] Value=A112111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112111.Bytes);
public long this[int i]=>Value[i];

public static A112111Inst Instance=new A112111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112112
{
public static readonly long[] Value={ 1L,6L,6L,3L,4L,4L,6L,2L,5L,3L,3L,5L,3L,2L,5L,3L,3L,4L,5L,4L,3L,2L,6L,4L,3L,6L,2L,5L,6L,4L,2L,5L,4L,5L,1L,1L,1L,4L,4L,2L,3L,6L,6L,5L,5L,4L,3L,5L,5L,2L,2L,1L,3L,6L,1L,5L,2L,6L,5L,4L,3L,4L,6L,6L,5L,5L,6L,1L,5L,6L,6L,3L,3L,1L,5L,4L,5L,1L,5L,2L,2L,4L,3L,4L,2L,1L,6L,1L,3L,2L,4L,1L,3L,5L,3L,1L,3L,2L,6L,2L,5L,1L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112112Inst : IEnumerable<long>
{
public static readonly long[] Value=A112112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112112.Bytes);
public long this[int i]=>Value[i];

public static A112112Inst Instance=new A112112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112113
{
public static readonly long[] Value={ 1L,1L,-4L,28L,-236L,2159L,-20309L,189387L,-1696165L,14092143L,-103605487L,621674576L,-2503235595L,1311059747L,58857366823L,-625935119621L,20416246154579L,-595556154741631L,9331660766550500L,-50486760747953952L,-816026626910008666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112113Inst : IEnumerable<long>
{
public static readonly long[] Value=A112113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112113.Bytes);
public long this[int i]=>Value[i];

public static A112113Inst Instance=new A112113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112114
{
public static readonly long[] Value={ 1L,7L,7L,7L,7L,7L,7L,7L,6L,6L,6L,6L,6L,6L,5L,3L,3L,3L,3L,3L,2L,2L,1L,1L,1L,1L,7L,4L,7L,4L,4L,4L,3L,2L,5L,3L,1L,1L,7L,5L,2L,4L,2L,2L,1L,2L,6L,5L,1L,5L,7L,7L,7L,7L,5L,6L,5L,6L,4L,1L,6L,1L,2L,7L,1L,5L,3L,7L,2L,4L,4L,4L,3L,2L,4L,5L,7L,7L,3L,1L,2L,3L,5L,5L,6L,4L,7L,6L,1L,6L,5L,2L,1L,1L,6L,1L,4L,3L,1L,2L,3L,3L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112114Inst : IEnumerable<long>
{
public static readonly long[] Value=A112114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112114.Bytes);
public long this[int i]=>Value[i];

public static A112114Inst Instance=new A112114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112115
{
public static readonly long[] Value={ 1L,1L,-5L,43L,-443L,4957L,-57281L,661375L,-7430526L,79197417L,-778914398L,6845802239L,-52074744048L,345158019601L,-2374391391323L,20218882229451L,-34682204747638L,-6385759551091470L,180067413599721613L,-2110513020510554883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112115Inst : IEnumerable<long>
{
public static readonly long[] Value=A112115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112115.Bytes);
public long this[int i]=>Value[i];

public static A112115Inst Instance=new A112115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112116
{
public static readonly long[] Value={ 1L,8L,8L,4L,8L,4L,8L,8L,4L,8L,8L,4L,4L,8L,8L,4L,4L,8L,8L,2L,4L,6L,4L,6L,2L,4L,8L,8L,2L,2L,8L,4L,8L,2L,2L,8L,8L,6L,4L,4L,6L,2L,4L,3L,8L,5L,8L,8L,7L,5L,4L,3L,4L,6L,6L,2L,1L,7L,2L,7L,8L,8L,8L,2L,8L,8L,4L,2L,7L,8L,8L,5L,3L,4L,2L,6L,5L,1L,8L,7L,4L,1L,5L,4L,4L,7L,4L,2L,4L,7L,6L,4L,6L,2L,6L,3L,5L,6L,7L,2L,5L,7L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112116Inst : IEnumerable<long>
{
public static readonly long[] Value=A112116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112116.Bytes);
public long this[int i]=>Value[i];

public static A112116Inst Instance=new A112116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112117
{
public static readonly BigInteger[] Value={ 1L,1L,-6L,60L,-720L,9398L,-126958L,1719439L,-22778647L,288721672L,-3426131120L,37291873546L,-368633930696L,3421668183648L,-33763691015949L,382711017377914L,-3403489111329505L,-22613095886515578L,1672401759052466166L,BigInteger.Parse("-27936127591842262118"),BigInteger.Parse("-15637150116164531317") };
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
public class A112117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112117Inst Instance=new A112117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112118
{
public static readonly long[] Value={ 1L,9L,9L,9L,6L,6L,3L,9L,6L,3L,9L,3L,3L,1L,7L,5L,9L,1L,8L,6L,2L,6L,4L,6L,7L,6L,4L,6L,3L,2L,5L,7L,2L,5L,7L,8L,1L,4L,9L,6L,3L,7L,6L,9L,1L,7L,7L,3L,7L,8L,7L,5L,7L,8L,9L,3L,8L,7L,9L,5L,3L,9L,9L,1L,5L,4L,5L,1L,7L,3L,1L,7L,8L,6L,1L,8L,4L,6L,8L,6L,5L,5L,9L,2L,6L,1L,5L,9L,8L,7L,2L,8L,8L,3L,2L,3L,9L,8L,2L,8L,4L,6L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112118Inst : IEnumerable<long>
{
public static readonly long[] Value=A112118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112118.Bytes);
public long this[int i]=>Value[i];

public static A112118Inst Instance=new A112118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112119
{
public static readonly BigInteger[] Value={ 1L,1L,-7L,81L,-1122L,16906L,-264109L,4150081L,-64119406L,955386299L,-13491950523L,178108552187L,-2193288809125L,25965294143459L,-320197330438145L,4331428366450929L,-54509980572007649L,309687851858995853L,8841175049606909354L,BigInteger.Parse("-260481122023484957344"),BigInteger.Parse("727627679068983588258") };
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
public class A112119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112119Inst Instance=new A112119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112120
{
public static readonly long[] Value={ 1L,10L,10L,5L,10L,5L,8L,3L,4L,3L,2L,1L,9L,2L,8L,1L,7L,4L,9L,4L,7L,8L,2L,4L,5L,5L,6L,5L,6L,6L,6L,5L,6L,7L,3L,1L,2L,10L,10L,10L,5L,7L,10L,1L,4L,7L,1L,1L,5L,7L,2L,8L,9L,4L,3L,7L,5L,10L,4L,4L,9L,8L,7L,8L,4L,6L,7L,1L,2L,2L,3L,5L,9L,1L,10L,2L,5L,4L,5L,9L,3L,4L,10L,1L,1L,10L,4L,2L,6L,4L,8L,2L,2L,4L,9L,2L,10L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112120Inst : IEnumerable<long>
{
public static readonly long[] Value=A112120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112120.Bytes);
public long this[int i]=>Value[i];

public static A112120Inst Instance=new A112120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112121
{
public static readonly BigInteger[] Value={ 1L,1L,-8L,104L,-1619L,27437L,-482626L,8553639L,-149434331L,2527339944L,-40748011084L,619534898788L,-8892967520397L,124088656925363L,-1797865061490547L,28140512084643142L,-424643873334235802L,4269156014010214570L,BigInteger.Parse("19251023484926369328"),BigInteger.Parse("-1456780704021544219838") };
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
public class A112121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112121Inst Instance=new A112121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112122
{
public static readonly long[] Value={ 1L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,9L,7L,7L,7L,7L,7L,7L,7L,7L,7L,6L,10L,11L,11L,11L,11L,11L,11L,11L,11L,10L,2L,7L,1L,1L,1L,1L,1L,1L,1L,11L,1L,10L,1L,3L,3L,3L,3L,3L,3L,2L,2L,10L,11L,11L,3L,3L,3L,3L,3L,2L,6L,9L,5L,3L,2L,4L,4L,4L,4L,3L,5L,11L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112122Inst : IEnumerable<long>
{
public static readonly long[] Value=A112122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112122.Bytes);
public long this[int i]=>Value[i];

public static A112122Inst Instance=new A112122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112123
{
public static readonly BigInteger[] Value={ 1L,1L,-9L,131L,-2279L,43161L,-849269L,16866851L,-331093879L,6316647841L,-115528321709L,2007845708091L,-33238536213650L,537616162919975L,-8956186512464320L,158920634214746905L,-2786226293720310297L,BigInteger.Parse("38547971903938600271"),BigInteger.Parse("-198392033014273765511") };
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
public class A112123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112123Inst Instance=new A112123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112124
{
public static readonly long[] Value={ 1L,12L,12L,6L,8L,8L,12L,2L,8L,2L,10L,9L,10L,10L,4L,5L,4L,7L,10L,10L,12L,7L,12L,8L,8L,9L,10L,7L,11L,12L,2L,9L,12L,10L,11L,7L,6L,5L,4L,5L,10L,7L,9L,1L,9L,5L,12L,12L,2L,10L,6L,9L,9L,6L,2L,1L,9L,3L,7L,10L,4L,11L,10L,3L,6L,10L,6L,10L,12L,11L,8L,1L,2L,4L,7L,2L,8L,6L,9L,12L,8L,2L,3L,2L,4L,3L,6L,12L,6L,11L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112124Inst : IEnumerable<long>
{
public static readonly long[] Value=A112124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112124.Bytes);
public long this[int i]=>Value[i];

public static A112124Inst Instance=new A112124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112125
{
public static readonly BigInteger[] Value={ 1L,1L,-10L,160L,-3061L,63775L,-1381434L,30233546L,-654989371L,13821523157L,-280493565375L,5432981693533L,-100769609590332L,1833421110751790L,-34286913831217395L,678578947805323394L,BigInteger.Parse("-13377225136748683778"),BigInteger.Parse("221000164094797572734"),BigInteger.Parse("-2119677884300620846621") };
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
public class A112125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112125Inst Instance=new A112125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112126
{
public static readonly long[] Value={ 1L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,11L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,8L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,8L,9L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,10L,3L,5L,13L,13L,13L,13L,13L,13L,13L,13L,12L,12L,3L,4L,4L,7L,7L,7L,7L,7L,7L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112126Inst : IEnumerable<long>
{
public static readonly long[] Value=A112126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112126.Bytes);
public long this[int i]=>Value[i];

public static A112126Inst Instance=new A112126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112127
{
public static readonly BigInteger[] Value={ 1L,1L,-11L,193L,-4043L,92233L,-2188907L,52544305L,-1250612651L,29060631481L,-651497950667L,13997025548641L,-289196932607819L,5873067677083177L,-122109541297984368L,2669034419647762122L,BigInteger.Parse("-58550172867811577842"),BigInteger.Parse("1127335101086707607932") };
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
public class A112127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A112127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112127Inst Instance=new A112127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112128
{
public static readonly long[] Value={ 1L,-2L,4L,-8L,16L,-28L,48L,-80L,128L,-202L,312L,-472L,704L,-1036L,1504L,-2160L,3072L,-4324L,6036L,-8360L,11488L,-15680L,21264L,-28656L,38400L,-51182L,67864L,-89552L,117632L,-153836L,200352L,-259904L,335872L,-432480L,554952L,-709728L,904784L,-1149916L,1457136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112128Inst : IEnumerable<long>
{
public static readonly long[] Value=A112128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112128.Bytes);
public long this[int i]=>Value[i];

public static A112128Inst Instance=new A112128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112129
{
public static readonly long[] Value={ 1197630L,20402760L,25451790L,29445850L,43830780L,44898210L,52214050L,76355370L,84234990L,88337550L,99495550L,123074070L,135740430L,155333920L,156954700L,165098290L,216858460L,218715490L,229066110L,232590400L,234109120L,236536510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112129Inst : IEnumerable<long>
{
public static readonly long[] Value=A112129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112129.Bytes);
public long this[int i]=>Value[i];

public static A112129Inst Instance=new A112129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112130
{
public static readonly long[] Value={ 25451790L,29445850L,76355370L,218715490L,236862990L,380011170L,514144750L,628241740L,777146230L,882792120L,930646080L,944173860L,1105472340L,1349221230L,1542434250L,1564227910L,1832212270L,1898927100L,1994085030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112130Inst : IEnumerable<long>
{
public static readonly long[] Value=A112130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112130.Bytes);
public long this[int i]=>Value[i];

public static A112130Inst Instance=new A112130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112131
{
public static readonly long[] Value={ 12L,23L,34L,45L,56L,67L,78L,89L,910L,101112L,12131415161718L,181920L,2021L,21222324L,24252627L,27282930L,30313233343536L,3637383940L,404142L,42434445L,45464748L,484950L,5051525354L,54555657585960L,60616263L,6364656667686970L,707172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112131Inst : IEnumerable<long>
{
public static readonly long[] Value=A112131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112131.Bytes);
public long this[int i]=>Value[i];

public static A112131Inst Instance=new A112131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112132
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L,7L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112132Inst : IEnumerable<long>
{
public static readonly long[] Value=A112132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112132.Bytes);
public long this[int i]=>Value[i];

public static A112132Inst Instance=new A112132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112133
{
public static readonly long[] Value={ 1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L,23L,1L,11L,13L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112133Inst : IEnumerable<long>
{
public static readonly long[] Value=A112133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112133.Bytes);
public long this[int i]=>Value[i];

public static A112133Inst Instance=new A112133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112134
{
public static readonly long[] Value={ 11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L,25L,59L,1L,24L,36L,24L,11L,49L,11L,24L,36L,24L,1L,59L,25L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112134Inst : IEnumerable<long>
{
public static readonly long[] Value=A112134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112134.Bytes);
public long this[int i]=>Value[i];

public static A112134Inst Instance=new A112134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112135
{
public static readonly long[] Value={ 95L,120L,60L,24L,60L,85L,60L,36L,95L,60L,145L,84L,11L,25L,59L,36L,84L,60L,1L,155L,25L,84L,71L,24L,60L,1L,144L,95L,25L,71L,24L,61L,84L,71L,25L,59L,25L,71L,84L,61L,24L,71L,25L,95L,144L,1L,60L,24L,71L,84L,25L,155L,1L,60L,84L,36L,59L,25L,11L,84L,145L,60L,95L,36L,60L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112135Inst : IEnumerable<long>
{
public static readonly long[] Value=A112135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112135.Bytes);
public long this[int i]=>Value[i];

public static A112135Inst Instance=new A112135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112136
{
public static readonly long[] Value={ 155L,336L,84L,180L,336L,145L,24L,420L,71L,120L,144L,61L,215L,84L,300L,25L,95L,205L,215L,216L,180L,84L,1L,60L,95L,204L,300L,36L,145L,144L,36L,59L,25L,156L,504L,251L,169L,60L,95L,36L,205L,95L,25L,95L,205L,299L,61L,264L,336L,95L,84L,216L,265L,60L,204L,95L,60L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112136Inst : IEnumerable<long>
{
public static readonly long[] Value=A112136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112136.Bytes);
public long this[int i]=>Value[i];

public static A112136Inst Instance=new A112136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112137
{
public static readonly long[] Value={ 635L,720L,36L,1680L,60L,769L,311L,25L,155L,924L,1L,1404L,131L,289L,95L,120L,205L,611L,84L,660L,361L,84L,575L,85L,396L,215L,205L,95L,624L,61L,239L,25L,431L,480L,780L,60L,265L,479L,120L,961L,24L,335L,685L,95L,565L,336L,155L,600L,324L,181L,755L,169L,516L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112137Inst : IEnumerable<long>
{
public static readonly long[] Value=A112137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112137.Bytes);
public long this[int i]=>Value[i];

public static A112137Inst Instance=new A112137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112138
{
public static readonly long[] Value={ 2675L,1344L,420L,576L,204L,1320L,756L,1080L,445L,815L,924L,3120L,481L,1895L,84L,205L,635L,1140L,265L,180L,1271L,564L,780L,961L,204L,95L,1140L,516L,229L,456L,924L,660L,911L,265L,659L,180L,925L,480L,611L,360L,745L,1140L,864L,155L,456L,205L,1115L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112138Inst : IEnumerable<long>
{
public static readonly long[] Value=A112138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112138.Bytes);
public long this[int i]=>Value[i];

public static A112138Inst Instance=new A112138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112139
{
public static readonly long[] Value={ 5015L,2616L,9240L,2844L,5496L,1140L,325L,5639L,2220L,6636L,1465L,420L,719L,420L,1560L,265L,2675L,2041L,5939L,1621L,3035L,2664L,336L,769L,3791L,1980L,949L,4211L,2329L,755L,2941L,839L,145L,635L,2665L,71L,420L,204L,216L,685L,1824L,3060L,420L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112139Inst : IEnumerable<long>
{
public static readonly long[] Value=A112139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112139.Bytes);
public long this[int i]=>Value[i];

public static A112139Inst Instance=new A112139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112140
{
public static readonly long[] Value={ 0L,0L,1L,0L,1729L,494L,1984L,744L,2500L,2450L,2500L,2550L,1984L,5288L,1729L,6048L,1L,9998L,0L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112140Inst : IEnumerable<long>
{
public static readonly long[] Value=A112140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112140.Bytes);
public long this[int i]=>Value[i];

public static A112140Inst Instance=new A112140Inst();

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