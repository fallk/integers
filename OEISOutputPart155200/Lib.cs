using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198305
{
public static readonly long[] Value={ 1L,3L,7L,19L,51L,159L,519L,1867L,7234L,30243L,135125L,642307L,3231047L,17138845L,95554662L,558384955L,3411049542L,21730279218L,144048688538L,991665854999L,7077433997172L,52283785492733L,399238054300828L,3147127294177099L,25579801627862301L,214139186144996635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198305Inst : IEnumerable<long>
{
public static readonly long[] Value=A198305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198305.Bytes);
public long this[int i]=>Value[i];

public static A198305Inst Instance=new A198305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198306
{
public static readonly long[] Value={ 7L,12L,37L,62L,187L,312L,937L,1562L,4687L,7812L,23437L,39062L,117187L,195312L,585937L,976562L,2929687L,4882812L,14648437L,24414062L,73242187L,122070312L,366210937L,610351562L,1831054687L,3051757812L,9155273437L,15258789062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198306Inst : IEnumerable<long>
{
public static readonly long[] Value=A198306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198306.Bytes);
public long this[int i]=>Value[i];

public static A198306Inst Instance=new A198306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198307
{
public static readonly long[] Value={ 8L,14L,50L,86L,302L,518L,1814L,3110L,10886L,18662L,65318L,111974L,391910L,671846L,2351462L,4031078L,14108774L,24186470L,84652646L,145118822L,507915878L,870712934L,3047495270L,5224277606L,18284971622L,31345665638L,109709829734L,188073993830L,658258978406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198307Inst : IEnumerable<long>
{
public static readonly long[] Value=A198307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198307.Bytes);
public long this[int i]=>Value[i];

public static A198307Inst Instance=new A198307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198308
{
public static readonly long[] Value={ 9L,16L,65L,114L,457L,800L,3201L,5602L,22409L,39216L,156865L,274514L,1098057L,1921600L,7686401L,13451202L,53804809L,94158416L,376633665L,659108914L,2636435657L,4613762400L,18455049601L,32296336802L,129185347209L,226074357616L,904297430465L,1582520503314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198308Inst : IEnumerable<long>
{
public static readonly long[] Value=A198308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198308.Bytes);
public long this[int i]=>Value[i];

public static A198308Inst Instance=new A198308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198309
{
public static readonly long[] Value={ 10L,18L,82L,146L,658L,1170L,5266L,9362L,42130L,74898L,337042L,599186L,2696338L,4793490L,21570706L,38347922L,172565650L,306783378L,1380525202L,2454267026L,11044201618L,19634136210L,88353612946L,157073089682L,706828903570L,1256584717458L,5654631228562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198309Inst : IEnumerable<long>
{
public static readonly long[] Value=A198309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198309.Bytes);
public long this[int i]=>Value[i];

public static A198309Inst Instance=new A198309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198310
{
public static readonly long[] Value={ 11L,20L,101L,182L,911L,1640L,8201L,14762L,73811L,132860L,664301L,1195742L,5978711L,10761680L,53808401L,96855122L,484275611L,871696100L,4358480501L,7845264902L,39226324511L,70607384120L,353036920601L,635466457082L,3177332285411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198310Inst : IEnumerable<long>
{
public static readonly long[] Value=A198310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198310.Bytes);
public long this[int i]=>Value[i];

public static A198310Inst Instance=new A198310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198311
{
public static readonly long[] Value={ 12L,70L,98L,448L,1170L,2340L,11700L,84630L,142912L,441784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198311Inst : IEnumerable<long>
{
public static readonly long[] Value=A198311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198311.Bytes);
public long this[int i]=>Value[i];

public static A198311Inst Instance=new A198311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198312
{
public static readonly long[] Value={ 2L,19L,154L,1147L,8542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198312Inst : IEnumerable<long>
{
public static readonly long[] Value=A198312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198312.Bytes);
public long this[int i]=>Value[i];

public static A198312Inst Instance=new A198312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198313
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,4L,4L,15L,23L,162L,540L,18958L,389417L,50314520L,2942196930L,1698517018988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198313Inst : IEnumerable<long>
{
public static readonly long[] Value=A198313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198313.Bytes);
public long this[int i]=>Value[i];

public static A198313Inst Instance=new A198313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198314
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,4L,1L,8L,3L,37L,33L,335L,1610L,17985L,193911L,2867313L,32674066L,1581626531L,6705889862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198314Inst : IEnumerable<long>
{
public static readonly long[] Value=A198314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198314.Bytes);
public long this[int i]=>Value[i];

public static A198314Inst Instance=new A198314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198315
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,3L,1L,9L,2L,50L,3L,453L,5L,5759L,14L,90693L,3926L,1736786L,4132004L,163458044L,4018022167L,119021971966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198315Inst : IEnumerable<long>
{
public static readonly long[] Value=A198315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198315.Bytes);
public long this[int i]=>Value[i];

public static A198315Inst Instance=new A198315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198316
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,2L,1L,2L,1L,7L,2L,35L,3L,389L,4L,7579L,6L,181233L,9L,4624493L,12L,122090019L,17L,3328899632L,24L,93988911093L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198316Inst : IEnumerable<long>
{
public static readonly long[] Value=A198316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198316.Bytes);
public long this[int i]=>Value[i];

public static A198316Inst Instance=new A198316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198317
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,4L,7L,5L,27L,7L,553L,10L,30379L,13L,1782854L,18L,95079100L,24L,4686063134L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198317Inst : IEnumerable<long>
{
public static readonly long[] Value=A198317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198317.Bytes);
public long this[int i]=>Value[i];

public static A198317Inst Instance=new A198317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198318
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,6L,5L,7L,7L,10L,10L,15L,13L,29L,17L,176L,23L,4364L,30L,266398L,39L,20807734L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198318Inst : IEnumerable<long>
{
public static readonly long[] Value=A198318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198318.Bytes);
public long this[int i]=>Value[i];

public static A198318Inst Instance=new A198318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198319
{
public static readonly long[] Value={ 113L,139L,23L,19L,37L,7L,19L,13L,67L,43L,3L,3L,3L,5L,11L,59L,5L,17L,59L,107L,17L,29L,71L,2L,2L,2L,239L,101L,191L,2L,2L,41L,227L,137L,179L,239L,419L,281L,149L,179L,227L,137L,1151L,239L,347L,809L,569L,1091L,1289L,1427L,191L,827L,1697L,1721L,1049L,1049L,3299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198319Inst : IEnumerable<long>
{
public static readonly long[] Value=A198319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198319.Bytes);
public long this[int i]=>Value[i];

public static A198319Inst Instance=new A198319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198320
{
public static readonly long[] Value={ 3L,32L,275L,2240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198320Inst : IEnumerable<long>
{
public static readonly long[] Value=A198320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198320.Bytes);
public long this[int i]=>Value[i];

public static A198320Inst Instance=new A198320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198321
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,3L,3L,0L,1L,4L,6L,4L,0L,1L,5L,10L,10L,5L,0L,1L,6L,15L,20L,15L,6L,0L,1L,7L,21L,35L,35L,21L,7L,0L,1L,8L,28L,56L,70L,56L,28L,8L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,0L,1L,10L,45L,120L,210L,252L,210L,120L,45L,10L,0L,1L,11L,55L,165L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198321Inst : IEnumerable<long>
{
public static readonly long[] Value=A198321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198321.Bytes);
public long this[int i]=>Value[i];

public static A198321Inst Instance=new A198321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198322
{
public static readonly long[] Value={ 1L,2L,7L,8L,56L,76L,107L,147L,163L,292L,454L,839L,1433L,4221L,5833L,6137L,7987L,8626L,16216L,17059L,17128L,17764L,23438L,25672L,36812L,41203L,45952L,46428L,51768L,60635L,83009L,86716L,86908L,88321L,91951L,93534L,94542L,99141L,100142L,108848L,120357L,124783L,133741L,136768L,137941L,140079L,142424L,145404L,145654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198322Inst : IEnumerable<long>
{
public static readonly long[] Value=A198322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198322.Bytes);
public long this[int i]=>Value[i];

public static A198322Inst Instance=new A198322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198323
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,16L,19L,22L,25L,28L,31L,32L,33L,43L,53L,55L,62L,64L,93L,98L,121L,127L,128L,131L,152L,155L,172L,227L,254L,256L,311L,341L,343L,381L,383L,443L,512L,602L,635L,709L,719L,848L,908L,961L,1024L,1397L,1418L,1444L,1619L,1772L,1993L,2048L,2107L,2127L,2939L,3064L,3178L,3209L,3545L,3671L,3698L,3937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198323Inst : IEnumerable<long>
{
public static readonly long[] Value=A198323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198323.Bytes);
public long this[int i]=>Value[i];

public static A198323Inst Instance=new A198323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198324
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,10L,35L,116L,427L,1584L,6146L,24216L,97754L,400080L,1662645L,6986127L,29669872L,127101015L,548839687L,2386211664L,10439207266L,45920497075L,203004397362L,901459381683L,4019351034816L,17987665701788L,80773320086286L,363842478143834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198324Inst : IEnumerable<long>
{
public static readonly long[] Value=A198324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198324.Bytes);
public long this[int i]=>Value[i];

public static A198324Inst Instance=new A198324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198325
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,3L,1L,3L,2L,3L,4L,2L,4L,2L,1L,4L,3L,2L,1L,4L,1L,4L,3L,1L,4L,2L,5L,3L,1L,4L,4L,3L,2L,5L,2L,4L,3L,5L,2L,1L,5L,3L,5L,3L,2L,1L,5L,4L,2L,5L,1L,6L,4L,2L,5L,3L,1L,6L,3L,5L,2L,5L,4L,2L,1L,6L,3L,1L,5L,4L,3L,2L,1L,5L,6L,4L,2L,1L,5L,3L,2L,6L,4L,1L,6L,2L,5L,4L,1L,5L,3L,6L,4L,1L,6L,2L,1L,5L,4L,3L,1L,6L,3L,5L,4L,2L,6L,3L,2L,1L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198325Inst : IEnumerable<long>
{
public static readonly long[] Value=A198325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198325.Bytes);
public long this[int i]=>Value[i];

public static A198325Inst Instance=new A198325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198326
{
public static readonly long[] Value={ 0L,1L,4L,2L,10L,5L,7L,3L,8L,11L,20L,6L,13L,8L,14L,4L,16L,9L,10L,12L,11L,21L,19L,7L,20L,14L,12L,9L,23L,15L,35L,5L,24L,17L,17L,10L,16L,11L,17L,13L,26L,12L,19L,22L,18L,20L,29L,8L,14L,21L,20L,15L,13L,13L,30L,10L,14L,24L,30L,16L,22L,36L,15L,6L,23L,25L,22L,18L,23L,18L,26L,11L,25L,17L,24L,12L,27L,18L,38L,14L,16L,27L,36L,13L,26L,20L,27L,23L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198326Inst : IEnumerable<long>
{
public static readonly long[] Value=A198326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198326.Bytes);
public long this[int i]=>Value[i];

public static A198326Inst Instance=new A198326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198327
{
public static readonly long[] Value={ 6L,35L,51L,57L,87L,93L,95L,121L,123L,143L,145L,161L,185L,187L,203L,205L,215L,217L,219L,221L,237L,249L,267L,289L,291L,301L,303L,305L,321L,323L,329L,341L,393L,395L,413L,415L,417L,447L,453L,471L,473L,517L,519L,529L,535L,537L,545L,553L,581L,583L,591L,635L,669L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198327Inst : IEnumerable<long>
{
public static readonly long[] Value=A198327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198327.Bytes);
public long this[int i]=>Value[i];

public static A198327Inst Instance=new A198327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198328
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,2L,1L,4L,3L,5L,2L,3L,2L,6L,1L,3L,4L,2L,3L,4L,5L,7L,2L,9L,3L,8L,2L,5L,6L,11L,1L,10L,3L,6L,4L,3L,2L,6L,3L,5L,4L,3L,5L,12L,7L,13L,2L,4L,9L,6L,3L,2L,8L,15L,2L,4L,5L,5L,6L,7L,11L,8L,1L,9L,10L,3L,3L,14L,6L,5L,4L,7L,3L,18L,2L,10L,6L,11L,3L,16L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198328Inst : IEnumerable<long>
{
public static readonly long[] Value=A198328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198328.Bytes);
public long this[int i]=>Value[i];

public static A198328Inst Instance=new A198328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198329
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,4L,3L,3L,2L,2L,2L,6L,1L,2L,4L,1L,3L,4L,5L,4L,2L,9L,3L,8L,2L,3L,6L,5L,1L,10L,3L,6L,4L,2L,2L,6L,3L,3L,4L,2L,5L,12L,7L,6L,2L,4L,9L,6L,3L,1L,8L,15L,2L,4L,5L,3L,6L,4L,11L,8L,1L,9L,10L,2L,3L,14L,6L,3L,4L,4L,3L,18L,2L,10L,6L,5L,3L,16L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198329Inst : IEnumerable<long>
{
public static readonly long[] Value=A198329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198329.Bytes);
public long this[int i]=>Value[i];

public static A198329Inst Instance=new A198329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198330
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,10L,11L,16L,18L,19L,20L,21L,23L,25L,26L,27L,29L,32L,33L,34L,36L,40L,41L,42L,46L,49L,50L,52L,53L,54L,57L,59L,61L,62L,63L,64L,65L,66L,68L,71L,72L,73L,74L,75L,77L,80L,81L,83L,84L,85L,86L,87L,92L,97L,98L,99L,100L,101L,103L,104L,108L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198330Inst : IEnumerable<long>
{
public static readonly long[] Value=A198330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198330.Bytes);
public long this[int i]=>Value[i];

public static A198330Inst Instance=new A198330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198331
{
public static readonly long[] Value={ 2L,5L,6L,12L,13L,14L,15L,17L,22L,24L,28L,30L,31L,35L,37L,38L,39L,43L,44L,45L,47L,48L,51L,55L,56L,58L,60L,67L,69L,70L,76L,78L,79L,82L,88L,89L,90L,91L,93L,94L,95L,96L,102L,105L,106L,107L,109L,110L,111L,112L,113L,116L,117L,118L,119L,120L,129L,135L,138L,140L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198331Inst : IEnumerable<long>
{
public static readonly long[] Value=A198331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198331.Bytes);
public long this[int i]=>Value[i];

public static A198331Inst Instance=new A198331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198332
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,4L,6L,6L,6L,6L,6L,8L,8L,8L,8L,12L,8L,10L,12L,10L,10L,8L,10L,14L,10L,10L,12L,12L,10L,12L,8L,20L,10L,10L,12L,16L,14L,14L,12L,16L,10L,14L,12L,12L,14L,12L,12L,22L,14L,14L,12L,14L,20L,18L,12L,18L,16L,12L,10L,18L,16L,10L,16L,30L,14L,14L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198332Inst : IEnumerable<long>
{
public static readonly long[] Value=A198332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198332.Bytes);
public long this[int i]=>Value[i];

public static A198332Inst Instance=new A198332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198333
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,3L,1L,3L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,1L,4L,2L,3L,1L,2L,3L,1L,4L,1L,2L,3L,1L,2L,3L,2L,2L,2L,1L,2L,3L,2L,4L,1L,2L,2L,2L,1L,2L,3L,1L,3L,3L,2L,4L,1L,2L,3L,2L,2L,3L,2L,2L,2L,1L,5L,1L,2L,2L,2L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198333Inst : IEnumerable<long>
{
public static readonly long[] Value=A198333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198333.Bytes);
public long this[int i]=>Value[i];

public static A198333Inst Instance=new A198333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198334
{
public static readonly long[] Value={ 1L,4L,5L,5L,8L,8L,10L,10L,9L,9L,9L,13L,13L,13L,12L,17L,13L,14L,17L,14L,14L,12L,14L,20L,13L,14L,19L,20L,14L,17L,12L,26L,13L,14L,17L,21L,20L,20L,17L,21L,14L,21L,20L,17L,22L,19L,17L,29L,21L,18L,17L,21L,26L,26L,16L,29L,21L,17L,14L,24L,21L,13L,26L,37L,18L,18L,20L,21L,22L,24L,21L,30L,21L,21L,23L,29L,18L,24L,17L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198334Inst : IEnumerable<long>
{
public static readonly long[] Value=A198334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198334.Bytes);
public long this[int i]=>Value[i];

public static A198334Inst Instance=new A198334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198335
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,8L,4L,7L,12L,21L,5L,9L,16L,29L,52L,6L,11L,20L,37L,68L,126L,7L,13L,24L,45L,84L,158L,296L,8L,15L,28L,53L,100L,190L,360L,685L,9L,17L,32L,61L,116L,222L,424L,813L,1556L,10L,19L,36L,69L,132L,254L,488L,941L,1812L,3498L,11L,21L,40L,77L,148L,286L,552L,1069L,2068L,4010L,7768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198335Inst : IEnumerable<long>
{
public static readonly long[] Value=A198335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198335.Bytes);
public long this[int i]=>Value[i];

public static A198335Inst Instance=new A198335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198336
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,5L,2L,1L,6L,2L,1L,7L,1L,8L,1L,9L,4L,1L,10L,3L,1L,11L,3L,1L,12L,2L,1L,13L,2L,1L,14L,2L,1L,15L,6L,2L,1L,16L,1L,17L,2L,1L,18L,4L,1L,19L,1L,20L,3L,1L,21L,4L,1L,22L,5L,2L,1L,23L,4L,1L,24L,2L,1L,25L,9L,4L,1L,26L,3L,1L,27L,8L,1L,28L,2L,1L,29L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198336Inst : IEnumerable<long>
{
public static readonly long[] Value=A198336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198336.Bytes);
public long this[int i]=>Value[i];

public static A198336Inst Instance=new A198336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198337
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,1L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,3L,3L,1L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,3L,3L,2L,1L,2L,4L,2L,2L,3L,2L,3L,2L,3L,2L,1L,3L,3L,2L,2L,3L,3L,2L,2L,2L,2L,3L,2L,3L,3L,3L,2L,2L,3L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198337Inst : IEnumerable<long>
{
public static readonly long[] Value=A198337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198337.Bytes);
public long this[int i]=>Value[i];

public static A198337Inst Instance=new A198337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198338
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,2L,4L,1L,2L,3L,5L,1L,2L,2L,3L,4L,6L,1L,2L,3L,3L,7L,1L,2L,2L,2L,4L,4L,4L,8L,1L,2L,2L,3L,3L,4L,6L,6L,9L,1L,2L,2L,3L,4L,5L,6L,10L,1L,2L,3L,5L,11L,1L,2L,2L,2L,3L,4L,4L,4L,6L,6L,8L,12L,1L,2L,3L,3L,4L,6L,6L,7L,15L,1L,2L,2L,3L,3L,4L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198338Inst : IEnumerable<long>
{
public static readonly long[] Value=A198338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198338.Bytes);
public long this[int i]=>Value[i];

public static A198338Inst Instance=new A198338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198339
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,1L,1L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,3L,3L,5L,1L,1L,1L,1L,2L,2L,2L,3L,4L,6L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,7L,1L,1L,1L,1L,2L,2L,2L,4L,4L,4L,8L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,6L,6L,9L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,5L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198339Inst : IEnumerable<long>
{
public static readonly long[] Value=A198339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198339.Bytes);
public long this[int i]=>Value[i];

public static A198339Inst Instance=new A198339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198340
{
public static readonly long[] Value={ 0L,1L,6L,6L,21L,21L,24L,24L,56L,56L,56L,67L,67L,67L,126L,80L,67L,161L,80L,154L,154L,126L,161L,197L,252L,161L,354L,188L,154L,333L,126L,240L,252L,154L,311L,440L,197L,197L,333L,414L,161L,411L,188L,311L,683L,354L,333L,545L,384L,636L,311L,411L,240L,921L,462L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198340Inst : IEnumerable<long>
{
public static readonly long[] Value=A198340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198340.Bytes);
public long this[int i]=>Value[i];

public static A198340Inst Instance=new A198340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198341
{
public static readonly long[] Value={ 0L,1L,7L,7L,28L,28L,30L,30L,84L,84L,84L,94L,94L,94L,210L,104L,94L,247L,104L,243L,243L,210L,247L,283L,462L,247L,579L,278L,243L,565L,210L,320L,462L,243L,547L,681L,283L,283L,565L,667L,247L,661L,278L,547L,1216L,579L,565L,793L,644L,1174L,547L,661L,320L,1506L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198341Inst : IEnumerable<long>
{
public static readonly long[] Value=A198341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198341.Bytes);
public long this[int i]=>Value[i];

public static A198341Inst Instance=new A198341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198342
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,4L,3L,5L,4L,21L,4L,36L,3L,27L,40L,49L,5L,91L,2L,358L,56L,27L,3L,807L,79L,26L,64L,617L,2L,1896L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198342Inst : IEnumerable<long>
{
public static readonly long[] Value=A198342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198342.Bytes);
public long this[int i]=>Value[i];

public static A198342Inst Instance=new A198342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198343
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,20L,21L,24L,26L,27L,28L,30L,35L,36L,39L,40L,42L,45L,48L,52L,54L,56L,60L,63L,65L,70L,72L,78L,80L,84L,90L,91L,104L,105L,108L,112L,117L,120L,126L,130L,135L,140L,144L,156L,168L,180L,182L,189L,195L,208L,210L,216L,234L,240L,252L,260L,270L,273L,280L,312L,315L,336L,351L,360L,364L,378L,390L,420L,432L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198343Inst : IEnumerable<long>
{
public static readonly long[] Value=A198343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198343.Bytes);
public long this[int i]=>Value[i];

public static A198343Inst Instance=new A198343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198344
{
public static readonly long[] Value={ 1L,1L,8L,3L,2L,1L,4L,34L,30L,5L,15L,2L,6L,17L,36L,82L,12L,87L,26L,12L,25L,215L,35L,18L,17L,3L,41L,17L,234L,17L,167L,92L,251L,15L,9L,12L,31L,1L,57L,290L,4L,99L,218L,502L,48L,164L,198L,201L,128L,7L,363L,143L,11L,138L,487L,32L,230L,82L,355L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198344Inst : IEnumerable<long>
{
public static readonly long[] Value=A198344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198344.Bytes);
public long this[int i]=>Value[i];

public static A198344Inst Instance=new A198344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198345
{
public static readonly long[] Value={ 3L,1L,0L,2L,5L,9L,1L,9L,1L,9L,1L,8L,5L,1L,0L,9L,6L,0L,7L,8L,1L,5L,9L,5L,5L,5L,9L,0L,4L,4L,2L,4L,2L,4L,4L,3L,9L,0L,2L,4L,3L,5L,6L,2L,4L,7L,4L,9L,9L,6L,9L,6L,4L,9L,6L,7L,1L,4L,2L,4L,6L,2L,1L,0L,0L,0L,7L,7L,5L,1L,5L,3L,2L,2L,5L,9L,1L,1L,4L,0L,6L,9L,7L,0L,4L,5L,7L,2L,9L,4L,8L,7L,0L,4L,9L,3L,9L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198345Inst : IEnumerable<long>
{
public static readonly long[] Value=A198345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198345.Bytes);
public long this[int i]=>Value[i];

public static A198345Inst Instance=new A198345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198346
{
public static readonly long[] Value={ 1L,2L,4L,8L,8L,9L,2L,2L,6L,4L,6L,3L,6L,2L,1L,5L,2L,6L,8L,8L,1L,6L,8L,4L,2L,2L,5L,4L,1L,9L,7L,9L,4L,9L,2L,4L,4L,4L,9L,2L,3L,3L,4L,2L,5L,5L,8L,9L,3L,6L,7L,3L,6L,0L,9L,9L,4L,7L,8L,6L,3L,4L,6L,0L,5L,0L,7L,2L,9L,6L,7L,0L,7L,9L,5L,1L,7L,7L,1L,3L,2L,1L,0L,5L,3L,3L,6L,8L,5L,9L,6L,3L,6L,2L,7L,0L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198346Inst : IEnumerable<long>
{
public static readonly long[] Value=A198346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198346.Bytes);
public long this[int i]=>Value[i];

public static A198346Inst Instance=new A198346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198347
{
public static readonly long[] Value={ 4L,7L,1L,8L,8L,7L,6L,4L,8L,2L,4L,7L,7L,8L,4L,3L,4L,4L,7L,0L,6L,5L,7L,4L,4L,4L,7L,6L,8L,6L,5L,6L,7L,7L,7L,7L,4L,8L,1L,0L,2L,9L,8L,7L,6L,0L,7L,2L,2L,7L,0L,7L,9L,4L,3L,0L,5L,8L,8L,1L,6L,6L,0L,0L,5L,9L,1L,2L,4L,9L,8L,8L,7L,3L,0L,2L,3L,6L,4L,2L,9L,5L,8L,6L,7L,0L,8L,2L,4L,3L,9L,5L,3L,5L,4L,3L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198347Inst : IEnumerable<long>
{
public static readonly long[] Value=A198347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198347.Bytes);
public long this[int i]=>Value[i];

public static A198347Inst Instance=new A198347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198348
{
public static readonly long[] Value={ 7L,4L,3L,1L,4L,1L,8L,4L,7L,6L,1L,2L,8L,7L,2L,4L,2L,2L,0L,8L,0L,4L,3L,0L,6L,9L,5L,5L,5L,9L,9L,6L,8L,2L,9L,7L,9L,0L,5L,0L,5L,0L,9L,0L,0L,3L,0L,3L,1L,8L,4L,0L,3L,0L,2L,9L,8L,3L,8L,9L,8L,5L,6L,8L,4L,4L,3L,7L,3L,5L,6L,1L,1L,5L,8L,9L,4L,2L,2L,8L,2L,7L,6L,9L,8L,9L,5L,8L,8L,9L,8L,6L,2L,0L,3L,5L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198348Inst : IEnumerable<long>
{
public static readonly long[] Value=A198348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198348.Bytes);
public long this[int i]=>Value[i];

public static A198348Inst Instance=new A198348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198349
{
public static readonly long[] Value={ 5L,9L,6L,6L,2L,8L,6L,9L,4L,8L,2L,8L,1L,2L,2L,2L,0L,9L,7L,7L,2L,0L,7L,1L,5L,5L,3L,4L,8L,4L,9L,6L,6L,0L,8L,8L,1L,7L,4L,2L,1L,7L,7L,5L,4L,0L,6L,1L,7L,2L,3L,8L,8L,0L,0L,6L,4L,3L,6L,0L,0L,9L,1L,7L,8L,3L,5L,1L,5L,9L,5L,6L,7L,8L,7L,3L,4L,9L,2L,3L,6L,7L,4L,7L,3L,5L,1L,9L,8L,0L,8L,8L,9L,9L,4L,2L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198349Inst : IEnumerable<long>
{
public static readonly long[] Value=A198349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198349.Bytes);
public long this[int i]=>Value[i];

public static A198349Inst Instance=new A198349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198350
{
public static readonly long[] Value={ 3L,7L,3L,3L,9L,5L,9L,1L,6L,0L,1L,9L,3L,9L,6L,9L,6L,8L,8L,9L,6L,8L,3L,2L,1L,5L,1L,9L,8L,1L,8L,4L,7L,6L,3L,1L,5L,9L,9L,6L,4L,4L,5L,8L,2L,7L,2L,7L,2L,9L,8L,8L,8L,9L,5L,4L,7L,1L,5L,6L,2L,9L,0L,9L,6L,4L,5L,2L,5L,2L,1L,1L,0L,8L,3L,2L,2L,5L,5L,5L,8L,6L,0L,2L,5L,0L,1L,6L,0L,5L,3L,7L,6L,8L,6L,3L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198350Inst : IEnumerable<long>
{
public static readonly long[] Value=A198350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198350.Bytes);
public long this[int i]=>Value[i];

public static A198350Inst Instance=new A198350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198351
{
public static readonly long[] Value={ 7L,4L,4L,2L,1L,9L,8L,9L,8L,5L,2L,7L,0L,6L,2L,4L,6L,8L,7L,3L,2L,7L,5L,8L,2L,8L,0L,0L,6L,3L,7L,0L,2L,8L,8L,5L,9L,7L,2L,5L,6L,8L,0L,7L,4L,5L,1L,0L,0L,1L,7L,4L,3L,0L,9L,4L,0L,6L,3L,6L,4L,2L,7L,1L,1L,7L,1L,2L,5L,8L,7L,0L,8L,7L,3L,8L,6L,9L,7L,0L,1L,5L,4L,8L,7L,0L,1L,4L,2L,1L,8L,2L,7L,1L,8L,3L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198351Inst : IEnumerable<long>
{
public static readonly long[] Value=A198351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198351.Bytes);
public long this[int i]=>Value[i];

public static A198351Inst Instance=new A198351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198352
{
public static readonly long[] Value={ 5L,4L,1L,4L,1L,8L,9L,0L,3L,1L,7L,2L,9L,0L,6L,7L,1L,1L,2L,9L,6L,9L,2L,1L,9L,6L,7L,2L,0L,6L,2L,4L,0L,6L,8L,8L,1L,3L,3L,0L,1L,8L,0L,6L,2L,4L,3L,1L,5L,2L,0L,5L,6L,5L,0L,4L,8L,8L,9L,6L,6L,8L,2L,9L,7L,8L,2L,6L,1L,4L,2L,2L,3L,2L,8L,8L,0L,0L,0L,9L,7L,6L,7L,7L,5L,3L,2L,3L,7L,8L,4L,3L,1L,9L,8L,9L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198352Inst : IEnumerable<long>
{
public static readonly long[] Value=A198352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198352.Bytes);
public long this[int i]=>Value[i];

public static A198352Inst Instance=new A198352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198353
{
public static readonly long[] Value={ 8L,4L,2L,5L,0L,9L,0L,7L,4L,1L,5L,9L,6L,1L,5L,5L,7L,6L,6L,9L,1L,0L,9L,3L,5L,9L,9L,0L,1L,4L,9L,0L,9L,1L,1L,9L,8L,2L,9L,9L,6L,0L,2L,0L,0L,3L,7L,6L,2L,1L,2L,8L,2L,1L,7L,8L,5L,2L,9L,0L,5L,0L,6L,1L,5L,6L,6L,0L,7L,4L,9L,9L,8L,1L,0L,2L,1L,8L,5L,9L,6L,5L,1L,2L,5L,2L,4L,3L,6L,9L,6L,7L,1L,3L,1L,3L,6L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198353Inst : IEnumerable<long>
{
public static readonly long[] Value=A198353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198353.Bytes);
public long this[int i]=>Value[i];

public static A198353Inst Instance=new A198353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198354
{
public static readonly long[] Value={ 6L,5L,5L,9L,9L,6L,4L,2L,4L,4L,5L,2L,3L,9L,1L,5L,4L,8L,0L,7L,3L,1L,0L,7L,1L,3L,0L,8L,6L,9L,5L,9L,7L,5L,3L,4L,3L,6L,2L,2L,5L,1L,1L,8L,1L,0L,8L,9L,5L,4L,2L,1L,0L,3L,4L,8L,3L,4L,8L,2L,4L,0L,6L,8L,3L,3L,7L,7L,2L,5L,6L,3L,0L,6L,8L,6L,8L,4L,6L,5L,6L,9L,0L,5L,6L,9L,8L,8L,7L,7L,5L,5L,8L,7L,5L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198354Inst : IEnumerable<long>
{
public static readonly long[] Value=A198354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198354.Bytes);
public long this[int i]=>Value[i];

public static A198354Inst Instance=new A198354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198355
{
public static readonly long[] Value={ 9L,1L,5L,5L,5L,4L,3L,2L,6L,5L,7L,3L,5L,8L,7L,0L,5L,2L,9L,2L,7L,0L,6L,9L,6L,6L,7L,5L,0L,1L,3L,6L,9L,5L,1L,4L,0L,5L,6L,0L,6L,2L,7L,2L,8L,6L,0L,1L,9L,5L,8L,2L,7L,6L,6L,0L,8L,8L,9L,5L,7L,8L,5L,8L,4L,2L,0L,8L,5L,0L,2L,7L,0L,4L,3L,9L,7L,6L,3L,7L,5L,1L,6L,6L,9L,9L,2L,3L,9L,5L,2L,2L,5L,5L,0L,5L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198355Inst : IEnumerable<long>
{
public static readonly long[] Value=A198355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198355.Bytes);
public long this[int i]=>Value[i];

public static A198355Inst Instance=new A198355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198356
{
public static readonly long[] Value={ 7L,4L,2L,4L,3L,7L,4L,8L,8L,9L,6L,5L,6L,0L,3L,3L,7L,8L,5L,1L,7L,2L,4L,5L,5L,3L,0L,1L,6L,4L,3L,2L,6L,3L,5L,3L,2L,0L,2L,8L,5L,6L,2L,4L,8L,9L,8L,5L,8L,2L,2L,6L,9L,0L,9L,3L,8L,1L,9L,4L,5L,2L,2L,9L,3L,3L,6L,2L,8L,9L,1L,7L,9L,5L,7L,6L,0L,6L,0L,6L,8L,0L,2L,1L,5L,9L,5L,3L,1L,4L,5L,8L,7L,7L,4L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198356Inst : IEnumerable<long>
{
public static readonly long[] Value=A198356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198356.Bytes);
public long this[int i]=>Value[i];

public static A198356Inst Instance=new A198356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198357
{
public static readonly long[] Value={ 7L,4L,6L,0L,7L,4L,3L,6L,2L,1L,2L,8L,5L,6L,4L,4L,6L,1L,7L,3L,2L,5L,7L,4L,1L,8L,9L,8L,5L,6L,5L,3L,0L,6L,7L,3L,5L,6L,8L,5L,1L,9L,0L,1L,4L,6L,8L,5L,0L,2L,7L,8L,5L,6L,9L,0L,8L,2L,2L,9L,6L,4L,8L,7L,6L,6L,2L,2L,9L,3L,3L,0L,9L,6L,2L,0L,1L,6L,5L,1L,3L,7L,8L,3L,6L,3L,0L,2L,6L,7L,3L,7L,8L,0L,4L,5L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198357Inst : IEnumerable<long>
{
public static readonly long[] Value=A198357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198357.Bytes);
public long this[int i]=>Value[i];

public static A198357Inst Instance=new A198357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198358
{
public static readonly long[] Value={ 2L,9L,9L,0L,0L,5L,8L,7L,4L,5L,5L,0L,3L,1L,7L,3L,5L,7L,0L,3L,7L,4L,6L,8L,3L,5L,0L,7L,2L,4L,5L,4L,1L,9L,3L,9L,3L,2L,7L,5L,7L,6L,1L,9L,1L,7L,0L,1L,7L,3L,6L,6L,4L,0L,3L,0L,6L,4L,6L,5L,8L,6L,5L,0L,6L,8L,3L,1L,7L,8L,6L,7L,7L,0L,8L,4L,2L,8L,0L,2L,3L,5L,9L,0L,7L,3L,6L,2L,5L,6L,6L,1L,7L,4L,9L,4L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198358Inst : IEnumerable<long>
{
public static readonly long[] Value=A198358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198358.Bytes);
public long this[int i]=>Value[i];

public static A198358Inst Instance=new A198358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198359
{
public static readonly long[] Value={ 9L,5L,4L,3L,4L,7L,7L,7L,6L,6L,0L,8L,7L,5L,5L,6L,7L,2L,1L,2L,0L,9L,0L,0L,9L,5L,4L,7L,9L,3L,3L,9L,1L,3L,7L,3L,2L,9L,4L,4L,2L,8L,2L,7L,1L,3L,8L,3L,6L,2L,0L,7L,0L,8L,3L,5L,8L,2L,4L,7L,6L,5L,0L,6L,4L,0L,9L,9L,8L,5L,6L,9L,4L,5L,8L,2L,9L,1L,3L,1L,7L,6L,9L,1L,7L,4L,3L,5L,0L,6L,3L,4L,2L,2L,2L,0L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198359Inst : IEnumerable<long>
{
public static readonly long[] Value=A198359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198359.Bytes);
public long this[int i]=>Value[i];

public static A198359Inst Instance=new A198359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198360
{
public static readonly long[] Value={ 5L,8L,0L,4L,5L,7L,1L,2L,4L,4L,4L,5L,9L,3L,3L,1L,6L,1L,7L,9L,7L,2L,1L,9L,6L,5L,1L,4L,2L,8L,8L,1L,9L,0L,7L,5L,8L,9L,3L,8L,9L,8L,1L,1L,3L,7L,0L,7L,3L,9L,1L,2L,4L,9L,1L,2L,2L,4L,0L,8L,6L,1L,6L,7L,8L,2L,2L,5L,7L,9L,9L,5L,6L,9L,8L,9L,0L,1L,5L,7L,4L,9L,7L,7L,1L,6L,1L,8L,5L,9L,2L,6L,3L,4L,7L,2L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198360Inst : IEnumerable<long>
{
public static readonly long[] Value=A198360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198360.Bytes);
public long this[int i]=>Value[i];

public static A198360Inst Instance=new A198360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198361
{
public static readonly long[] Value={ 9L,1L,6L,1L,5L,1L,0L,6L,1L,0L,9L,6L,8L,3L,5L,7L,7L,0L,0L,0L,1L,3L,5L,0L,7L,2L,8L,0L,3L,9L,4L,6L,3L,9L,1L,8L,9L,1L,2L,6L,5L,1L,0L,6L,8L,0L,9L,3L,7L,1L,6L,1L,7L,1L,8L,8L,4L,2L,5L,1L,7L,8L,5L,3L,2L,1L,3L,7L,6L,0L,0L,8L,0L,0L,5L,1L,4L,4L,9L,3L,8L,7L,1L,5L,7L,8L,9L,2L,0L,1L,9L,0L,1L,3L,3L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198361Inst : IEnumerable<long>
{
public static readonly long[] Value=A198361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198361.Bytes);
public long this[int i]=>Value[i];

public static A198361Inst Instance=new A198361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198362
{
public static readonly long[] Value={ 2L,4L,4L,0L,4L,5L,3L,2L,2L,6L,2L,9L,1L,3L,5L,5L,9L,1L,4L,6L,6L,8L,5L,8L,2L,8L,2L,9L,3L,9L,4L,4L,8L,0L,7L,9L,4L,9L,3L,2L,8L,4L,3L,7L,5L,3L,3L,7L,6L,0L,8L,7L,5L,4L,6L,7L,2L,2L,2L,3L,1L,3L,5L,5L,5L,6L,1L,9L,0L,4L,2L,7L,8L,6L,2L,9L,9L,9L,9L,7L,3L,4L,9L,3L,8L,4L,1L,6L,5L,2L,3L,1L,4L,6L,8L,5L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198362Inst : IEnumerable<long>
{
public static readonly long[] Value=A198362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198362.Bytes);
public long this[int i]=>Value[i];

public static A198362Inst Instance=new A198362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198363
{
public static readonly long[] Value={ 1L,0L,1L,1L,9L,6L,4L,0L,7L,1L,9L,5L,4L,1L,5L,9L,6L,5L,5L,1L,6L,4L,3L,9L,2L,2L,5L,1L,6L,8L,6L,8L,1L,0L,4L,7L,8L,4L,3L,1L,4L,0L,0L,1L,4L,0L,3L,1L,8L,0L,2L,4L,9L,9L,0L,9L,8L,2L,2L,2L,2L,1L,0L,5L,2L,6L,4L,8L,1L,9L,8L,6L,2L,5L,9L,0L,1L,3L,6L,4L,3L,3L,5L,8L,7L,3L,1L,1L,1L,5L,1L,0L,7L,8L,2L,1L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198363Inst : IEnumerable<long>
{
public static readonly long[] Value=A198363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198363.Bytes);
public long this[int i]=>Value[i];

public static A198363Inst Instance=new A198363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198364
{
public static readonly long[] Value={ 4L,0L,0L,3L,0L,3L,9L,9L,5L,2L,5L,5L,1L,8L,5L,9L,1L,4L,6L,3L,0L,6L,3L,7L,1L,8L,6L,8L,3L,4L,2L,0L,3L,5L,7L,2L,4L,6L,4L,1L,5L,2L,9L,6L,5L,1L,0L,7L,0L,7L,9L,4L,9L,2L,4L,4L,3L,2L,3L,2L,8L,6L,3L,4L,2L,8L,9L,9L,3L,8L,5L,5L,3L,3L,2L,2L,1L,0L,4L,0L,7L,9L,7L,1L,9L,7L,5L,3L,3L,2L,5L,6L,9L,3L,1L,9L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198364Inst : IEnumerable<long>
{
public static readonly long[] Value=A198364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198364.Bytes);
public long this[int i]=>Value[i];

public static A198364Inst Instance=new A198364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198365
{
public static readonly long[] Value={ 1L,0L,7L,8L,5L,9L,7L,1L,0L,9L,5L,6L,8L,8L,5L,8L,1L,1L,1L,7L,1L,8L,0L,8L,5L,4L,1L,8L,6L,3L,3L,0L,1L,1L,1L,6L,6L,7L,3L,5L,9L,6L,9L,2L,8L,3L,0L,7L,4L,9L,8L,8L,8L,0L,6L,3L,6L,7L,3L,4L,7L,6L,2L,1L,9L,2L,7L,5L,0L,2L,2L,0L,9L,4L,3L,8L,5L,3L,7L,7L,2L,3L,7L,1L,1L,8L,9L,7L,0L,5L,1L,5L,9L,6L,7L,2L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198365Inst : IEnumerable<long>
{
public static readonly long[] Value=A198365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198365.Bytes);
public long this[int i]=>Value[i];

public static A198365Inst Instance=new A198365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198366
{
public static readonly long[] Value={ 5L,1L,5L,5L,7L,8L,8L,1L,1L,1L,6L,4L,6L,6L,2L,3L,2L,2L,9L,1L,6L,7L,6L,0L,6L,2L,2L,0L,0L,9L,0L,9L,2L,1L,8L,3L,1L,2L,9L,5L,9L,3L,7L,5L,7L,1L,8L,7L,5L,1L,0L,0L,0L,1L,4L,2L,6L,2L,7L,6L,0L,4L,3L,6L,4L,4L,5L,3L,7L,8L,8L,4L,6L,1L,0L,7L,2L,5L,0L,0L,9L,0L,1L,0L,9L,5L,2L,5L,3L,0L,7L,6L,1L,7L,4L,6L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198366Inst : IEnumerable<long>
{
public static readonly long[] Value=A198366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198366.Bytes);
public long this[int i]=>Value[i];

public static A198366Inst Instance=new A198366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198367
{
public static readonly long[] Value={ 1L,1L,2L,8L,8L,6L,4L,4L,2L,0L,5L,2L,3L,9L,8L,6L,1L,3L,9L,4L,7L,7L,0L,0L,4L,6L,6L,3L,0L,6L,1L,8L,8L,9L,5L,7L,3L,6L,9L,5L,9L,7L,3L,2L,4L,1L,1L,0L,7L,6L,5L,2L,1L,7L,0L,0L,9L,7L,5L,6L,1L,3L,7L,9L,9L,7L,7L,1L,6L,8L,9L,1L,6L,9L,3L,8L,1L,2L,9L,9L,6L,0L,9L,6L,8L,4L,1L,0L,2L,9L,1L,6L,3L,7L,6L,9L,9L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198367Inst : IEnumerable<long>
{
public static readonly long[] Value=A198367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198367.Bytes);
public long this[int i]=>Value[i];

public static A198367Inst Instance=new A198367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198368
{
public static readonly long[] Value={ 6L,0L,6L,0L,7L,7L,7L,8L,3L,6L,4L,8L,6L,2L,6L,4L,5L,3L,6L,6L,5L,7L,9L,7L,7L,5L,7L,9L,9L,0L,5L,6L,2L,9L,1L,0L,5L,7L,8L,9L,9L,1L,3L,1L,8L,1L,7L,8L,8L,5L,7L,2L,2L,2L,5L,3L,4L,2L,4L,7L,5L,8L,6L,3L,2L,8L,9L,9L,8L,4L,2L,0L,5L,8L,9L,6L,2L,9L,7L,9L,1L,6L,6L,8L,0L,4L,3L,0L,9L,4L,1L,8L,4L,6L,8L,0L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198368Inst : IEnumerable<long>
{
public static readonly long[] Value=A198368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198368.Bytes);
public long this[int i]=>Value[i];

public static A198368Inst Instance=new A198368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198369
{
public static readonly long[] Value={ 1L,1L,0L,2L,3L,8L,4L,7L,4L,6L,2L,7L,9L,4L,3L,9L,5L,9L,5L,8L,0L,5L,8L,1L,8L,3L,6L,5L,8L,6L,7L,8L,8L,1L,3L,9L,4L,4L,9L,1L,9L,2L,4L,8L,4L,6L,4L,3L,3L,1L,7L,4L,9L,1L,7L,4L,3L,6L,5L,7L,0L,7L,8L,7L,4L,1L,5L,7L,9L,8L,0L,2L,0L,1L,8L,1L,3L,2L,9L,9L,5L,9L,2L,5L,9L,7L,1L,9L,5L,8L,2L,4L,5L,4L,1L,1L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198369Inst : IEnumerable<long>
{
public static readonly long[] Value=A198369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198369.Bytes);
public long this[int i]=>Value[i];

public static A198369Inst Instance=new A198369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198370
{
public static readonly long[] Value={ 2L,0L,3L,4L,5L,1L,3L,2L,5L,5L,3L,1L,9L,2L,5L,0L,4L,1L,5L,5L,5L,1L,1L,6L,8L,0L,5L,0L,6L,0L,6L,1L,1L,9L,9L,5L,6L,1L,1L,6L,1L,8L,6L,7L,7L,8L,9L,0L,3L,4L,4L,6L,3L,3L,3L,3L,1L,5L,2L,7L,0L,3L,1L,3L,9L,3L,5L,5L,9L,1L,7L,6L,0L,6L,0L,1L,6L,8L,6L,0L,1L,3L,4L,9L,1L,7L,1L,6L,3L,2L,3L,1L,6L,6L,3L,3L,7L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198370Inst : IEnumerable<long>
{
public static readonly long[] Value=A198370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198370.Bytes);
public long this[int i]=>Value[i];

public static A198370Inst Instance=new A198370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198371
{
public static readonly long[] Value={ 1L,2L,1L,5L,0L,1L,2L,9L,8L,4L,2L,6L,4L,3L,5L,2L,4L,5L,7L,0L,4L,8L,8L,7L,1L,2L,8L,4L,9L,9L,1L,5L,0L,2L,5L,4L,8L,7L,5L,7L,7L,7L,4L,5L,5L,1L,7L,6L,4L,2L,1L,2L,8L,7L,0L,7L,3L,1L,8L,8L,3L,5L,3L,0L,9L,4L,3L,4L,5L,6L,6L,3L,5L,5L,5L,9L,7L,9L,3L,2L,3L,0L,6L,9L,0L,0L,6L,0L,6L,1L,6L,6L,4L,1L,0L,2L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198371Inst : IEnumerable<long>
{
public static readonly long[] Value=A198371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198371.Bytes);
public long this[int i]=>Value[i];

public static A198371Inst Instance=new A198371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198372
{
public static readonly long[] Value={ 4L,6L,0L,1L,9L,4L,9L,9L,7L,7L,5L,0L,9L,3L,0L,9L,7L,1L,4L,2L,4L,7L,9L,7L,2L,7L,7L,9L,6L,4L,5L,5L,8L,8L,6L,1L,6L,5L,4L,5L,0L,0L,5L,1L,8L,5L,7L,4L,4L,9L,2L,0L,1L,8L,4L,8L,3L,1L,1L,1L,0L,4L,0L,7L,7L,7L,4L,6L,4L,8L,7L,8L,7L,8L,6L,5L,8L,1L,6L,3L,2L,7L,1L,7L,8L,9L,2L,8L,3L,6L,1L,8L,1L,4L,4L,0L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198372Inst : IEnumerable<long>
{
public static readonly long[] Value=A198372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198372.Bytes);
public long this[int i]=>Value[i];

public static A198372Inst Instance=new A198372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198373
{
public static readonly long[] Value={ 3L,6L,9L,9L,4L,8L,1L,7L,0L,5L,8L,9L,8L,6L,6L,5L,2L,8L,6L,9L,1L,6L,0L,2L,0L,8L,8L,6L,2L,0L,2L,9L,5L,2L,2L,3L,4L,7L,7L,1L,8L,4L,0L,7L,6L,5L,5L,2L,3L,8L,5L,9L,0L,0L,3L,7L,1L,8L,4L,1L,4L,6L,5L,1L,5L,5L,7L,4L,0L,2L,7L,9L,2L,0L,1L,4L,5L,2L,4L,1L,6L,9L,0L,1L,6L,1L,6L,5L,5L,9L,1L,3L,0L,6L,1L,6L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198373Inst : IEnumerable<long>
{
public static readonly long[] Value=A198373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198373.Bytes);
public long this[int i]=>Value[i];

public static A198373Inst Instance=new A198373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198374
{
public static readonly long[] Value={ 7L,6L,3L,3L,9L,4L,5L,3L,8L,2L,1L,0L,1L,9L,2L,3L,3L,6L,9L,9L,2L,6L,7L,4L,5L,3L,6L,3L,8L,4L,8L,3L,7L,6L,1L,4L,5L,3L,2L,9L,5L,7L,8L,9L,0L,4L,0L,5L,6L,9L,1L,4L,2L,3L,6L,4L,4L,7L,5L,5L,0L,5L,1L,4L,0L,8L,4L,3L,9L,2L,8L,3L,4L,2L,2L,7L,0L,1L,7L,1L,3L,8L,3L,7L,8L,4L,3L,6L,3L,3L,4L,0L,4L,1L,3L,5L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198374Inst : IEnumerable<long>
{
public static readonly long[] Value=A198374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198374.Bytes);
public long this[int i]=>Value[i];

public static A198374Inst Instance=new A198374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198375
{
public static readonly BigInteger[] Value={ 1L,12L,113L,1114L,11115L,111116L,1111117L,11111118L,111111119L,1111111125L,0L,111111111126L,0L,11111111111127L,111111111111135L,1111111111111128L,0L,111111111111111129L,0L,11111111111111111145UL,BigInteger.Parse("111111111111111111137"),0L,0L,BigInteger.Parse("111111111111111111111138") };
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
public class A198375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198375Inst Instance=new A198375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198376
{
public static readonly BigInteger[] Value={ 1L,21L,311L,4111L,51111L,611111L,7111111L,81111111L,911111111L,5211111111L,0L,621111111111L,0L,72111111111111L,531111111111111L,8211111111111111L,0L,921111111111111111L,0L,BigInteger.Parse("54111111111111111111"),BigInteger.Parse("731111111111111111111"),0L,0L,BigInteger.Parse("831111111111111111111111") };
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
public class A198376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198376Inst Instance=new A198376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198377
{
public static readonly long[] Value={ 0L,10L,25L,39L,77L,679L,6788L,68889L,2677889L,26888999L,3778889989L,277777788888899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198377Inst : IEnumerable<long>
{
public static readonly long[] Value=A198377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198377.Bytes);
public long this[int i]=>Value[i];

public static A198377Inst Instance=new A198377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198378
{
public static readonly long[] Value={ 59L,11L,2L,3L,41L,5L,23L,7L,29L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198378Inst : IEnumerable<long>
{
public static readonly long[] Value=A198378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198378.Bytes);
public long this[int i]=>Value[i];

public static A198378Inst Instance=new A198378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198379
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,2L,1L,0L,0L,0L,3L,1L,0L,0L,-1L,0L,4L,1L,0L,0L,0L,-4L,0L,5L,1L,0L,0L,0L,0L,-10L,0L,6L,1L,0L,0L,0L,2L,0L,-20L,0L,7L,1L,0L,0L,0L,0L,12L,0L,-35L,0L,8L,1L,0L,0L,0L,0L,0L,42L,0L,-56L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198379Inst : IEnumerable<long>
{
public static readonly long[] Value=A198379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198379.Bytes);
public long this[int i]=>Value[i];

public static A198379Inst Instance=new A198379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198380
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,1L,3L,2L,4L,4L,2L,2L,4L,1L,2L,3L,4L,4L,2L,2L,1L,4L,3L,1L,3L,3L,5L,5L,3L,2L,5L,4L,6L,6L,4L,4L,6L,2L,4L,5L,6L,6L,4L,4L,2L,6L,5L,2L,5L,4L,6L,6L,4L,1L,3L,2L,4L,4L,2L,3L,5L,4L,6L,6L,5L,5L,3L,6L,4L,5L,6L,4L,6L,2L,4L,5L,6L,2L,4L,1L,2L,3L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198380Inst : IEnumerable<long>
{
public static readonly long[] Value=A198380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198380.Bytes);
public long this[int i]=>Value[i];

public static A198380Inst Instance=new A198380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198381
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,6L,10L,20L,32L,54L,81L,128L,184L,273L,385L,549L,754L,1048L,1412L,1917L,2547L,3392L,4444L,5837L,7556L,9791L,12553L,16086L,20429L,25935L,32665L,41108L,51404L,64190L,79721L,98882L,122043L,150417L,184618L,226239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198381Inst : IEnumerable<long>
{
public static readonly long[] Value=A198381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198381.Bytes);
public long this[int i]=>Value[i];

public static A198381Inst Instance=new A198381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198382
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,10L,12L,14L,17L,18L,19L,22L,25L,26L,27L,28L,29L,32L,35L,38L,39L,40L,41L,43L,46L,48L,49L,55L,56L,57L,59L,60L,61L,67L,69L,70L,71L,73L,77L,78L,80L,82L,83L,85L,87L,92L,96L,101L,104L,116L,117L,118L,120L,124L,125L,127L,131L,133L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198382Inst : IEnumerable<long>
{
public static readonly long[] Value=A198382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198382.Bytes);
public long this[int i]=>Value[i];

public static A198382Inst Instance=new A198382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198383
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,10L,20L,22L,37L,40L,80L,72L,144L,158L,278L,283L,566L,548L,1096L,1120L,2106L,2162L,4324L,4210L,8389L,8584L,16650L,16772L,33544L,33194L,66388L,66968L,131882L,132690L,265222L,263607L,527214L,530138L,1052078L,1054254L,2108508L,2103282L,4206564L,4216760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198383Inst : IEnumerable<long>
{
public static readonly long[] Value=A198383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198383.Bytes);
public long this[int i]=>Value[i];

public static A198383Inst Instance=new A198383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198384
{
public static readonly long[] Value={ 1L,4L,49L,9L,49L,16L,289L,196L,25L,1L,36L,196L,529L,49L,961L,441L,64L,1156L,81L,784L,441L,100L,2401L,289L,121L,2209L,4L,144L,1225L,529L,169L,784L,2601L,2116L,5041L,196L,3844L,1764L,49L,225L,256L,1681L,1225L,289L,1681L,2401L,6241L,9L,4624L,324L,9409L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198384Inst : IEnumerable<long>
{
public static readonly long[] Value=A198384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198384.Bytes);
public long this[int i]=>Value[i];

public static A198384Inst Instance=new A198384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198385
{
public static readonly long[] Value={ 25L,100L,169L,225L,289L,400L,625L,676L,625L,841L,900L,1156L,1369L,1225L,1681L,1521L,1600L,2500L,2025L,2704L,2601L,2500L,3721L,2809L,3025L,4225L,3364L,3600L,4225L,4225L,4225L,4624L,5625L,5476L,7225L,4900L,6724L,6084L,5329L,5625L,6400L,7225L,7225L,7225L,7921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198385Inst : IEnumerable<long>
{
public static readonly long[] Value=A198385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198385.Bytes);
public long this[int i]=>Value[i];

public static A198385Inst Instance=new A198385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198386
{
public static readonly long[] Value={ 49L,196L,289L,441L,529L,784L,961L,1156L,1225L,1681L,1764L,2116L,2209L,2401L,2401L,2601L,3136L,3844L,3969L,4624L,4761L,4900L,5041L,5329L,5929L,6241L,6724L,7056L,7225L,7921L,8281L,8464L,8649L,8836L,9409L,9604L,9604L,10404L,10609L,11025L,12544L,12769L,13225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198386Inst : IEnumerable<long>
{
public static readonly long[] Value=A198386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198386.Bytes);
public long this[int i]=>Value[i];

public static A198386Inst Instance=new A198386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198387
{
public static readonly long[] Value={ 24L,96L,120L,216L,240L,384L,336L,480L,600L,840L,864L,960L,840L,1176L,720L,1080L,1536L,1344L,1944L,1920L,2160L,2400L,1320L,2520L,2904L,2016L,3360L,3456L,3000L,3696L,4056L,3840L,3024L,3360L,2184L,4704L,2880L,4320L,5280L,5400L,6144L,5544L,6000L,6936L,6240L,5880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198387Inst : IEnumerable<long>
{
public static readonly long[] Value=A198387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198387.Bytes);
public long this[int i]=>Value[i];

public static A198387Inst Instance=new A198387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198388
{
public static readonly long[] Value={ 1L,2L,7L,3L,7L,4L,17L,14L,5L,1L,6L,14L,23L,7L,31L,21L,8L,34L,9L,28L,21L,10L,49L,17L,11L,47L,2L,12L,35L,23L,13L,28L,51L,46L,71L,14L,62L,42L,7L,15L,16L,41L,35L,17L,41L,49L,79L,3L,68L,18L,97L,19L,56L,7L,42L,20L,69L,98L,34L,21L,93L,31L,63L,22L,85L,94L,23L,49L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198388Inst : IEnumerable<long>
{
public static readonly long[] Value=A198388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198388.Bytes);
public long this[int i]=>Value[i];

public static A198388Inst Instance=new A198388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198389
{
public static readonly long[] Value={ 5L,10L,13L,15L,17L,20L,25L,26L,25L,29L,30L,34L,37L,35L,41L,39L,40L,50L,45L,52L,51L,50L,61L,53L,55L,65L,58L,60L,65L,65L,65L,68L,75L,74L,85L,70L,82L,78L,73L,75L,80L,85L,85L,85L,89L,91L,101L,87L,100L,90L,113L,95L,104L,97L,102L,100L,111L,122L,106L,105L,123L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198389Inst : IEnumerable<long>
{
public static readonly long[] Value=A198389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198389.Bytes);
public long this[int i]=>Value[i];

public static A198389Inst Instance=new A198389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198390
{
public static readonly long[] Value={ 7L,14L,17L,21L,23L,28L,31L,34L,35L,41L,42L,46L,47L,49L,49L,51L,56L,62L,63L,68L,69L,70L,71L,73L,77L,79L,82L,84L,85L,89L,91L,92L,93L,94L,97L,98L,98L,102L,103L,105L,112L,113L,115L,119L,119L,119L,119L,123L,124L,126L,127L,133L,136L,137L,138L,140L,141L,142L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198390Inst : IEnumerable<long>
{
public static readonly long[] Value=A198390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198390.Bytes);
public long this[int i]=>Value[i];

public static A198390Inst Instance=new A198390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198391
{
public static readonly long[] Value={ 2L,15L,20L,272L,476L,19024L,47425L,65792L,125172L,216900L,539280L,1222976L,1372736L,2770496L,3494336L,5321808L,5844528L,6177168L,7032528L,8885808L,20670768L,60727876L,69081344L,82724356L,95579136L,544382208L,907440192L,1657497600L,4295032832L,5048574976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198391Inst : IEnumerable<long>
{
public static readonly long[] Value=A198391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198391.Bytes);
public long this[int i]=>Value[i];

public static A198391Inst Instance=new A198391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198392
{
public static readonly long[] Value={ 2L,4L,12L,18L,31L,41L,59L,73L,96L,114L,142L,164L,197L,223L,261L,291L,334L,368L,416L,454L,507L,549L,607L,653L,716L,766L,834L,888L,961L,1019L,1097L,1159L,1242L,1308L,1396L,1466L,1559L,1633L,1731L,1809L,1912L,1994L,2102L,2188L,2301L,2391L,2509L,2603L,2726L,2824L,2952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198392Inst : IEnumerable<long>
{
public static readonly long[] Value=A198392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198392.Bytes);
public long this[int i]=>Value[i];

public static A198392Inst Instance=new A198392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198393
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,1L,1L,1L,1L,1L,2L,0L,0L,1L,1L,1L,1L,0L,0L,2L,2L,0L,1L,1L,1L,2L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,2L,1L,0L,1L,1L,2L,2L,1L,0L,2L,1L,3L,1L,2L,1L,0L,0L,1L,0L,2L,3L,1L,0L,2L,1L,1L,0L,1L,1L,2L,1L,1L,3L,1L,0L,1L,2L,0L,0L,1L,2L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198393Inst : IEnumerable<long>
{
public static readonly long[] Value=A198393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198393.Bytes);
public long this[int i]=>Value[i];

public static A198393Inst Instance=new A198393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198394
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,11L,15L,20L,29L,30L,35L,36L,39L,49L,51L,52L,56L,62L,69L,70L,72L,76L,80L,88L,91L,92L,96L,102L,104L,105L,106L,108L,111L,113L,115L,117L,121L,126L,129L,130L,135L,137L,138L,139L,140L,148L,151L,152L,153L,170L,173L,176L,192L,199L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198394Inst : IEnumerable<long>
{
public static readonly long[] Value=A198394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198394.Bytes);
public long this[int i]=>Value[i];

public static A198394Inst Instance=new A198394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198395
{
public static readonly long[] Value={ 0L,5L,9L,13L,17L,21L,25L,29L,33L,38L,42L,46L,50L,54L,58L,62L,66L,71L,75L,79L,83L,87L,91L,95L,99L,104L,108L,112L,116L,120L,124L,128L,132L,137L,141L,145L,149L,153L,157L,161L,165L,170L,174L,178L,182L,186L,190L,194L,198L,203L,207L,211L,215L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198395Inst : IEnumerable<long>
{
public static readonly long[] Value=A198395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198395.Bytes);
public long this[int i]=>Value[i];

public static A198395Inst Instance=new A198395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198396
{
public static readonly long[] Value={ 1L,0L,24L,198L,1272L,7746L,46620L,279894L,1679568L,10077642L,60466116L,362796990L,2176782264L,13060693938L,78364164012L,470184984486L,2821109907360L,16926659444634L,101559956668308L,609359740010382L,3656158440062856L,21936950640377730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198396Inst : IEnumerable<long>
{
public static readonly long[] Value=A198396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198396.Bytes);
public long this[int i]=>Value[i];

public static A198396Inst Instance=new A198396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198397
{
public static readonly long[] Value={ 1L,0L,35L,322L,2373L,16772L,117607L,823494L,5764745L,40353544L,282475179L,1977326666L,13841287117L,96889010316L,678223072751L,4747561509838L,33232930569489L,232630513987088L,1628413597910323L,11398895185373010L,79792266297611861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198397Inst : IEnumerable<long>
{
public static readonly long[] Value=A198397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198397.Bytes);
public long this[int i]=>Value[i];

public static A198397Inst Instance=new A198397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198398
{
public static readonly long[] Value={ 1L,0L,48L,488L,4064L,32728L,262096L,2097096L,16777152L,134217656L,1073741744L,8589934504L,68719476640L,549755813784L,4398046510992L,35184372088712L,281474976710528L,2251799813685112L,18014398509481840L,144115188075855720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198398Inst : IEnumerable<long>
{
public static readonly long[] Value=A198398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198398.Bytes);
public long this[int i]=>Value[i];

public static A198398Inst Instance=new A198398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198399
{
public static readonly long[] Value={ 1L,0L,63L,702L,6525L,59004L,531387L,4782906L,43046649L,387420408L,3486784311L,31381059510L,282429536373L,2541865828212L,22876792454835L,205891132094514L,1853020188851697L,16677181699666416L,150094635296998959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198399Inst : IEnumerable<long>
{
public static readonly long[] Value=A198399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198399.Bytes);
public long this[int i]=>Value[i];

public static A198399Inst Instance=new A198399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198400
{
public static readonly long[] Value={ 1L,0L,80L,970L,9960L,99950L,999940L,9999930L,99999920L,999999910L,9999999900L,99999999890L,999999999880L,9999999999870L,99999999999860L,999999999999850L,9999999999999840L,99999999999999830L,999999999999999820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198400Inst : IEnumerable<long>
{
public static readonly long[] Value=A198400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198400.Bytes);
public long this[int i]=>Value[i];

public static A198400Inst Instance=new A198400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198401
{
public static readonly long[] Value={ 1L,9L,320L,7073L,69632L,423393L,1941760L,7861953L,33554432L,177264449L,1173741824L,8804293473L,69149458432L,550571544609L,4399522300160L,35186934979457L,281479271677952L,2251806789442689L,18014409529442560L,144115205059418913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198401Inst : IEnumerable<long>
{
public static readonly long[] Value=A198401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198401.Bytes);
public long this[int i]=>Value[i];

public static A198401Inst Instance=new A198401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198402
{
public static readonly long[] Value={ 0L,5L,800L,30375L,640000L,9765625L,121500000L,1313046875L,12800000000L,115330078125L,976562500000L,7863818359375L,60750000000000L,453238525390625L,3282617187500000L,23174285888671875L,160000000000000000L,1083264923095703125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198402Inst : IEnumerable<long>
{
public static readonly long[] Value=A198402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198402.Bytes);
public long this[int i]=>Value[i];

public static A198402Inst Instance=new A198402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198403
{
public static readonly long[] Value={ 0L,6L,2304L,157464L,5308416L,121500000L,2176782336L,32934190464L,440301256704L,5355700839936L,60466176000000L,642717115324416L,6499837226778624L,63041475422674944L,590045794670739456L,5355700839936000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198403Inst : IEnumerable<long>
{
public static readonly long[] Value=A198403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198403.Bytes);
public long this[int i]=>Value[i];

public static A198403Inst Instance=new A198403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198404
{
public static readonly BigInteger[] Value={ 0L,8L,16384L,3359232L,268435456L,12800000000L,440301256704L,12089663946752L,281474976710656L,5777633090469888L,107374182400000000L,1841328767004311552L,BigInteger.Parse("29548117155177824256"),BigInteger.Parse("448452706436800053248"),BigInteger.Parse("6490588908866265677824"),BigInteger.Parse("90173697372979200000000") };
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
public class A198404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198404Inst Instance=new A198404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}