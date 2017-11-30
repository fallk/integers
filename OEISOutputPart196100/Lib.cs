using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A246762
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,2L,-3L,4L,-6L,7L,-9L,12L,-14L,18L,-22L,28L,-34L,41L,-50L,60L,-72L,86L,-105L,124L,-146L,174L,-204L,240L,-282L,332L,-386L,450L,-524L,606L,-703L,812L,-940L,1082L,-1243L,1428L,-1636L,1873L,-2140L,2448L,-2788L,3172L,-3610L,4096L,-4646L,5264L,-5962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246762Inst : IEnumerable<long>
{
public static readonly long[] Value=A246762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246762.Bytes);
public long this[int i]=>Value[i];

public static A246762Inst Instance=new A246762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246763
{
public static readonly long[] Value={ 1L,1L,0L,0L,4L,4L,16L,6L,12L,25L,7L,4L,31L,15L,8L,11L,7L,41L,23L,45L,69L,72L,29L,11L,2L,85L,4L,16L,73L,64L,2L,62L,69L,5L,29L,144L,16L,145L,157L,40L,9L,82L,75L,96L,88L,9L,100L,144L,36L,118L,8L,163L,212L,38L,9L,27L,185L,242L,203L,231L,11L,189L,250L,137L,116L,34L,91L,289L,10L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246763Inst : IEnumerable<long>
{
public static readonly long[] Value=A246763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246763.Bytes);
public long this[int i]=>Value[i];

public static A246763Inst Instance=new A246763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246764
{
public static readonly long[] Value={ 1L,1L,3L,7L,17L,78L,247L,916L,3301L,11272L,41854L,150485L,538585L,1954912L,6978464L,25170446L,90851829L,326048198L,1176355862L,4230352602L,15222263126L,54855015353L,197302183497L,710556528403L,2557837610375L,9205575728179L,33148388282116L,119307072980025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246764Inst : IEnumerable<long>
{
public static readonly long[] Value=A246764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246764.Bytes);
public long this[int i]=>Value[i];

public static A246764Inst Instance=new A246764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246765
{
public static readonly long[] Value={ 9L,5L,8L,8L,5L,4L,1L,9L,0L,8L,2L,4L,7L,6L,7L,3L,8L,3L,2L,0L,9L,0L,9L,4L,3L,0L,4L,2L,0L,3L,6L,5L,9L,2L,9L,5L,7L,4L,8L,6L,8L,2L,9L,9L,1L,0L,0L,5L,8L,5L,6L,9L,1L,4L,9L,1L,0L,0L,1L,9L,6L,7L,9L,2L,5L,9L,6L,5L,1L,8L,4L,0L,2L,1L,2L,3L,0L,7L,9L,6L,0L,1L,6L,9L,0L,3L,4L,9L,0L,7L,2L,2L,5L,7L,2L,5L,2L,8L,5L,8L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246765Inst : IEnumerable<long>
{
public static readonly long[] Value=A246765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246765.Bytes);
public long this[int i]=>Value[i];

public static A246765Inst Instance=new A246765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246766
{
public static readonly long[] Value={ 30L,120L,194L,282L,870L,1322L,1220L,1442L,2240L,3128L,3842L,3812L,5288L,5378L,6662L,7592L,8408L,6722L,10448L,10922L,12098L,10592L,15248L,17618L,16112L,18722L,20738L,21842L,26888L,29138L,26408L,20162L,28802L,27458L,36758L,30608L,44258L,44072L,33728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246766Inst : IEnumerable<long>
{
public static readonly long[] Value=A246766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246766.Bytes);
public long this[int i]=>Value[i];

public static A246766Inst Instance=new A246766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246767
{
public static readonly long[] Value={ 0L,-1L,12L,75L,248L,615L,1284L,2387L,4080L,6543L,9980L,14619L,20712L,28535L,38388L,50595L,65504L,83487L,104940L,130283L,159960L,194439L,234212L,279795L,331728L,390575L,456924L,531387L,614600L,707223L,809940L,923459L,1048512L,1185855L,1336268L,1500555L,1679544L,1874087L,2085060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246767Inst : IEnumerable<long>
{
public static readonly long[] Value=A246767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246767.Bytes);
public long this[int i]=>Value[i];

public static A246767Inst Instance=new A246767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246768
{
public static readonly long[] Value={ 8L,6L,8L,8L,7L,6L,6L,5L,2L,6L,5L,8L,5L,5L,4L,9L,9L,8L,1L,5L,3L,1L,2L,7L,8L,0L,1L,3L,1L,3L,8L,3L,7L,7L,8L,5L,0L,9L,2L,5L,8L,0L,0L,6L,8L,4L,9L,9L,8L,6L,6L,7L,9L,6L,4L,0L,1L,2L,6L,5L,7L,2L,7L,7L,9L,8L,2L,2L,5L,4L,1L,7L,0L,8L,8L,0L,5L,0L,4L,6L,4L,3L,7L,4L,9L,1L,5L,9L,9L,7L,9L,3L,6L,6L,3L,5L,0L,0L,6L,3L,8L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246768Inst : IEnumerable<long>
{
public static readonly long[] Value=A246768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246768.Bytes);
public long this[int i]=>Value[i];

public static A246768Inst Instance=new A246768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246769
{
public static readonly long[] Value={ 10L,14L,1234L,9302L,15621L,45069L,275825L,1496771L,3901747L,3965572L,4800842L,12089923L,13725353L,60247178L,86123531L,141164047L,400351433L,577144967L,733863869L,797811821L,1107698663L,1230427279L,1745874461L,1963869823L,2069222929L,2568664561L,3288702721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246769Inst : IEnumerable<long>
{
public static readonly long[] Value=A246769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246769.Bytes);
public long this[int i]=>Value[i];

public static A246769Inst Instance=new A246769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246770
{
public static readonly long[] Value={ 3L,4L,0L,4L,9L,5L,3L,4L,6L,6L,3L,7L,4L,2L,8L,2L,9L,1L,0L,2L,0L,9L,2L,5L,5L,8L,9L,3L,8L,7L,0L,2L,3L,7L,9L,5L,2L,7L,3L,6L,9L,5L,0L,7L,2L,5L,2L,1L,5L,7L,4L,5L,0L,3L,1L,8L,7L,5L,7L,0L,1L,8L,1L,3L,3L,2L,7L,2L,6L,3L,5L,1L,9L,2L,2L,9L,3L,7L,7L,1L,3L,6L,0L,5L,0L,7L,6L,0L,9L,7L,5L,3L,3L,8L,4L,6L,1L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246770Inst : IEnumerable<long>
{
public static readonly long[] Value=A246770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246770.Bytes);
public long this[int i]=>Value[i];

public static A246770Inst Instance=new A246770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246771
{
public static readonly long[] Value={ 6L,1L,9L,2L,5L,2L,2L,7L,0L,9L,8L,4L,8L,8L,4L,9L,0L,8L,6L,6L,3L,2L,8L,0L,7L,1L,8L,1L,9L,3L,7L,5L,2L,6L,6L,7L,4L,2L,3L,0L,8L,8L,7L,7L,1L,9L,0L,2L,4L,0L,9L,5L,0L,1L,0L,3L,4L,0L,4L,7L,8L,5L,2L,1L,7L,1L,5L,0L,3L,7L,3L,2L,6L,9L,2L,1L,8L,7L,7L,3L,7L,8L,1L,3L,9L,8L,3L,6L,6L,3L,0L,3L,8L,4L,9L,3L,7L,0L,0L,5L,8L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246771Inst : IEnumerable<long>
{
public static readonly long[] Value=A246771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246771.Bytes);
public long this[int i]=>Value[i];

public static A246771Inst Instance=new A246771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246772
{
public static readonly long[] Value={ 1L,8L,0L,9L,1L,5L,5L,0L,1L,8L,8L,1L,5L,6L,0L,6L,0L,9L,5L,1L,5L,8L,9L,5L,7L,7L,3L,0L,1L,0L,0L,0L,1L,8L,0L,0L,4L,9L,4L,4L,2L,9L,1L,0L,3L,3L,9L,9L,8L,8L,1L,0L,0L,0L,4L,9L,9L,5L,9L,4L,8L,3L,2L,4L,4L,3L,8L,9L,8L,1L,7L,8L,0L,8L,2L,4L,5L,6L,3L,2L,8L,6L,5L,8L,4L,2L,9L,4L,6L,2L,4L,4L,0L,7L,4L,9L,0L,4L,9L,1L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246772Inst : IEnumerable<long>
{
public static readonly long[] Value=A246772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246772.Bytes);
public long this[int i]=>Value[i];

public static A246772Inst Instance=new A246772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246773
{
public static readonly long[] Value={ 3L,2L,0L,5L,5L,6L,9L,4L,3L,0L,4L,0L,0L,5L,9L,0L,3L,1L,1L,7L,0L,2L,0L,2L,8L,6L,1L,7L,7L,8L,3L,8L,2L,3L,4L,2L,6L,3L,7L,7L,1L,0L,8L,9L,1L,9L,5L,9L,7L,6L,9L,9L,4L,4L,0L,4L,7L,0L,5L,5L,2L,2L,0L,3L,5L,5L,1L,8L,3L,4L,7L,9L,0L,3L,5L,9L,1L,6L,7L,4L,6L,9L,1L,7L,6L,4L,1L,8L,2L,6L,9L,5L,7L,8L,0L,5L,2L,5L,0L,7L,8L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246773Inst : IEnumerable<long>
{
public static readonly long[] Value=A246773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246773.Bytes);
public long this[int i]=>Value[i];

public static A246773Inst Instance=new A246773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246774
{
public static readonly long[] Value={ 60L,482L,3903L,5667L,175L,68951L,11039L,76939L,1157L,22746L,19847L,16195L,23806L,345855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246774Inst : IEnumerable<long>
{
public static readonly long[] Value=A246774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246774.Bytes);
public long this[int i]=>Value[i];

public static A246774Inst Instance=new A246774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246775
{
public static readonly long[] Value={ 2L,104L,15L,2565L,4947L,2827L,2834L,153L,3462L,16109L,3201L,7413L,31842L,24541L,66563L,15111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246775Inst : IEnumerable<long>
{
public static readonly long[] Value=A246775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246775.Bytes);
public long this[int i]=>Value[i];

public static A246775Inst Instance=new A246775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246776
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,2L,6L,4L,3L,9L,5L,8L,11L,9L,7L,8L,13L,9L,12L,14L,10L,13L,11L,10L,15L,17L,15L,17L,15L,5L,17L,15L,20L,11L,20L,16L,16L,19L,17L,17L,22L,13L,22L,20L,22L,12L,13L,22L,24L,22L,20L,24L,16L,21L,21L,21L,25L,21L,23L,25L,17L,14L,25L,27L,24L,14L,23L,20L,28L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246776Inst : IEnumerable<long>
{
public static readonly long[] Value=A246776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246776.Bytes);
public long this[int i]=>Value[i];

public static A246776Inst Instance=new A246776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246777
{
public static readonly long[] Value={ 1L,0L,0L,3L,10L,5L,16L,19L,20L,10L,38L,38L,35L,24L,43L,53L,38L,43L,66L,52L,46L,65L,79L,55L,73L,104L,109L,95L,120L,92L,130L,130L,121L,127L,114L,127L,155L,148L,92L,109L,159L,171L,173L,180L,171L,157L,171L,161L,174L,178L,168L,165L,169L,135L,171L,168L,138L,174L,195L,234L,149L,253L,269L,61L,244L,248L,255L,323L,304L,307L,262L,245L,234L,215L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246777Inst : IEnumerable<long>
{
public static readonly long[] Value=A246777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246777.Bytes);
public long this[int i]=>Value[i];

public static A246777Inst Instance=new A246777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246778
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,6L,8L,8L,9L,11L,11L,12L,13L,13L,13L,14L,15L,15L,16L,16L,16L,17L,17L,18L,19L,19L,19L,19L,19L,19L,21L,21L,22L,21L,22L,22L,22L,23L,23L,23L,24L,23L,24L,24L,24L,24L,25L,26L,26L,26L,26L,26L,26L,27L,27L,27L,27L,27L,27L,27L,27L,28L,29L,29L,28L,28L,29L,30L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246778Inst : IEnumerable<long>
{
public static readonly long[] Value=A246778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246778.Bytes);
public long this[int i]=>Value[i];

public static A246778Inst Instance=new A246778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246779
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,11L,13L,14L,15L,17L,20L,22L,24L,25L,27L,28L,30L,32L,33L,34L,37L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246779Inst : IEnumerable<long>
{
public static readonly long[] Value=A246779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246779.Bytes);
public long this[int i]=>Value[i];

public static A246779Inst Instance=new A246779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246780
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246780Inst : IEnumerable<long>
{
public static readonly long[] Value=A246780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246780.Bytes);
public long this[int i]=>Value[i];

public static A246780Inst Instance=new A246780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246781
{
public static readonly long[] Value={ 12L,13L,16L,18L,20L,21L,27L,31L,34L,39L,44L,53L,59L,60L,65L,96L,97L,98L,99L,136L,154L,202L,214L,215L,220L,221L,280L,324L,325L,326L,365L,366L,736L,780L,2146L,2225L,3792L,5946L,5947L,5948L,6902L,6903L,18524L,22078L,23510L,23511L,23512L,31542L,31544L,33606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246781Inst : IEnumerable<long>
{
public static readonly long[] Value=A246781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246781.Bytes);
public long this[int i]=>Value[i];

public static A246781Inst Instance=new A246781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246782
{
public static readonly long[] Value={ 5L,6L,7L,9L,10L,11L,14L,15L,22L,23L,28L,29L,30L,45L,46L,61L,66L,216L,217L,367L,3793L,1319945L,1576499L,8040877L,17567976L,44405858L,445538764L,1478061204L,3643075047L,17440041685L,190836014732L,714573709895L,714573709896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246782Inst : IEnumerable<long>
{
public static readonly long[] Value=A246782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246782.Bytes);
public long this[int i]=>Value[i];

public static A246782Inst Instance=new A246782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246783
{
public static readonly long[] Value={ 1L,1L,1L,1L,67L,67L,67L,67L,67L,54412L,161342L,161342L,1214143L,9915018L,9915018L,68964006L,68964006L,810832784L,19867608968L,52415066804L,119937255921L,272007811177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246783Inst : IEnumerable<long>
{
public static readonly long[] Value=A246783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246783.Bytes);
public long this[int i]=>Value[i];

public static A246783Inst Instance=new A246783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246784
{
public static readonly long[] Value={ 5L,6L,9L,10L,14L,22L,28L,29L,45L,216L,714573709895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246784Inst : IEnumerable<long>
{
public static readonly long[] Value=A246784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246784.Bytes);
public long this[int i]=>Value[i];

public static A246784Inst Instance=new A246784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246785
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,2L,1L,0L,2L,2L,2L,0L,3L,2L,2L,0L,3L,0L,3L,0L,3L,2L,2L,0L,0L,4L,0L,2L,2L,2L,0L,3L,0L,4L,3L,0L,4L,4L,4L,3L,0L,4L,0L,4L,2L,2L,0L,0L,4L,0L,5L,4L,4L,3L,0L,0L,5L,0L,5L,3L,2L,0L,0L,4L,4L,2L,0L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246785Inst : IEnumerable<long>
{
public static readonly long[] Value=A246785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246785.Bytes);
public long this[int i]=>Value[i];

public static A246785Inst Instance=new A246785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246786
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,23L,25L,26L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,47L,48L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246786Inst : IEnumerable<long>
{
public static readonly long[] Value=A246786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246786.Bytes);
public long this[int i]=>Value[i];

public static A246786Inst Instance=new A246786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246787
{
public static readonly long[] Value={ 1L,5L,12L,17L,25L,55L,83L,169L,206L,384L,953L,1615L,2192L,2197L,3023L,10709L,10935L,29508L,62735L,94332L,196966L,314940L,608777L,1258688L,1767259L,2448973L,7939362L,9373134L,16854966L,16854967L,32881913L,41084049L,83715318L,90288054L,151449026L,315082003L,327952702L,384935466L,720004431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246787Inst : IEnumerable<long>
{
public static readonly long[] Value=A246787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246787.Bytes);
public long this[int i]=>Value[i];

public static A246787Inst Instance=new A246787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246788
{
public static readonly long[] Value={ 1L,-3L,2L,9L,-10L,3L,-23L,38L,-21L,4L,57L,-122L,99L,-36L,5L,-135L,358L,-381L,204L,-55L,6L,313L,-986L,1299L,-916L,365L,-78L,7L,-711L,2598L,-4077L,3564L,-1875L,594L,-105L,8L,1593L,-6618L,12051L,-12564L,8205L,-3438L,903L,-136L,9L,-3527L,16422L,-34029L,41196L,-32115L,16722L,-5817L,1304L,-171L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246788Inst : IEnumerable<long>
{
public static readonly long[] Value=A246788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246788.Bytes);
public long this[int i]=>Value[i];

public static A246788Inst Instance=new A246788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246789
{
public static readonly long[] Value={ 2L,2L,4L,9L,18L,19L,34L,39L,42L,44L,74L,82L,87L,96L,129L,149L,150L,157L,184L,184L,194L,219L,259L,265L,293L,326L,343L,343L,370L,374L,418L,422L,441L,463L,468L,509L,539L,542L,548L,573L,627L,645L,659L,670L,671L,671L,687L,693L,708L,718L,750L,753L,771L,787L,845L,884L,904L,952L,999L,1040L,1055L,1169L,1193L,1193L,1428L,1446L,1475L,1547L,1552L,1579L,1590L,1601L,1604L,1657L,1704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246789Inst : IEnumerable<long>
{
public static readonly long[] Value=A246789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246789.Bytes);
public long this[int i]=>Value[i];

public static A246789Inst Instance=new A246789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246790
{
public static readonly long[] Value={ 2L,7L,15L,28L,53L,90L,177L,213L,216L,393L,395L,1628L,2206L,2212L,7075L,10364L,10727L,10954L,43444L,46099L,62758L,94347L,196989L,214629L,214631L,608803L,889740L,1353804L,2010048L,2449005L,7939395L,9373169L,16855002L,16855008L,41084086L,80005684L,113726074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246790Inst : IEnumerable<long>
{
public static readonly long[] Value=A246790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246790.Bytes);
public long this[int i]=>Value[i];

public static A246790Inst Instance=new A246790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246791
{
public static readonly long[] Value={ 1L,4L,15L,136L,2128L,15453L,479403L,1184231L,10975072L,27112368L,175600366L,2304656281L,14896902677L,59331462112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246791Inst : IEnumerable<long>
{
public static readonly long[] Value=A246791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246791.Bytes);
public long this[int i]=>Value[i];

public static A246791Inst Instance=new A246791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246792
{
public static readonly long[] Value={ 1L,7L,25L,25L,181L,208L,208L,1867L,14345L,19609L,40918L,40918L,620326L,2552265L,2552265L,7225612L,7225612L,16679492L,33772734L,33772734L,33772734L,620326386L,1516416904L,1516416904L,4764006481L,5272314878L,21423652192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246792Inst : IEnumerable<long>
{
public static readonly long[] Value=A246792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246792.Bytes);
public long this[int i]=>Value[i];

public static A246792Inst Instance=new A246792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246793
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,2L,2L,0L,2L,2L,2L,0L,3L,3L,2L,0L,3L,0L,4L,0L,4L,3L,2L,0L,0L,4L,0L,5L,2L,2L,0L,3L,0L,4L,4L,0L,4L,4L,4L,4L,0L,4L,0L,5L,4L,2L,0L,0L,4L,0L,5L,5L,4L,4L,0L,0L,5L,0L,6L,5L,3L,0L,0L,4L,4L,4L,0L,0L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,4L,4L,0L,5L,0L,6L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246793Inst : IEnumerable<long>
{
public static readonly long[] Value=A246793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246793.Bytes);
public long this[int i]=>Value[i];

public static A246793Inst Instance=new A246793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246794
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,3L,5L,7L,5L,5L,4L,4L,3L,4L,4L,4L,5L,5L,5L,4L,7L,11L,8L,7L,8L,5L,10L,3L,4L,6L,9L,6L,8L,12L,8L,4L,10L,6L,9L,10L,7L,9L,4L,6L,7L,10L,7L,8L,5L,8L,10L,9L,8L,8L,4L,6L,7L,8L,9L,2L,10L,7L,6L,9L,8L,6L,4L,4L,7L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246794Inst : IEnumerable<long>
{
public static readonly long[] Value=A246794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246794.Bytes);
public long this[int i]=>Value[i];

public static A246794Inst Instance=new A246794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246795
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,5L,7L,8L,9L,8L,12L,10L,11L,12L,9L,12L,15L,10L,11L,15L,10L,17L,13L,16L,20L,17L,21L,19L,19L,24L,13L,23L,18L,21L,17L,26L,26L,29L,19L,23L,23L,25L,27L,27L,29L,24L,26L,25L,33L,28L,32L,32L,31L,36L,35L,37L,42L,33L,28L,35L,30L,36L,30L,34L,44L,29L,32L,34L,33L,30L,40L,38L,34L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246795Inst : IEnumerable<long>
{
public static readonly long[] Value=A246795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246795.Bytes);
public long this[int i]=>Value[i];

public static A246795Inst Instance=new A246795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246796
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,4L,5L,7L,4L,6L,6L,7L,9L,6L,10L,12L,7L,8L,11L,6L,13L,10L,10L,10L,10L,15L,12L,15L,15L,11L,20L,13L,13L,12L,19L,15L,22L,16L,14L,18L,17L,18L,21L,21L,21L,21L,19L,24L,22L,25L,28L,24L,27L,27L,30L,35L,30L,23L,29L,23L,28L,29L,25L,38L,24L,24L,27L,28L,27L,37L,32L,31L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246796Inst : IEnumerable<long>
{
public static readonly long[] Value=A246796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246796.Bytes);
public long this[int i]=>Value[i];

public static A246796Inst Instance=new A246796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246797
{
public static readonly long[] Value={ 1L,5L,2L,17L,14L,3L,49L,62L,27L,4L,129L,222L,147L,44L,5L,321L,702L,627L,284L,65L,6L,769L,2046L,2307L,1404L,485L,90L,7L,1793L,5630L,7683L,5884L,2725L,762L,119L,8L,4097L,14846L,23811L,22012L,12805L,4794L,1127L,152L,9L,9217L,37886L,69891L,75772L,53125L,24954L,7847L,1592L,189L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246797Inst : IEnumerable<long>
{
public static readonly long[] Value=A246797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246797.Bytes);
public long this[int i]=>Value[i];

public static A246797Inst Instance=new A246797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246798
{
public static readonly long[] Value={ 1L,-5L,2L,22L,-16L,3L,-86L,92L,-33L,4L,319L,-448L,237L,-56L,5L,-1139L,1982L,-1383L,484L,-85L,6L,3964L,-8224L,7122L,-3296L,860L,-120L,7L,-13532L,32600L,-33702L,19384L,-6700L,1392L,-161L,8L,45517L,-124864L,150006L,-103088L,44330L,-12216L,2107L,-208L,9L,-151313L,465626L,-637314L,509272L,-261850L,89844L,-20573L,3032L,-261L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246798Inst : IEnumerable<long>
{
public static readonly long[] Value=A246798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246798.Bytes);
public long this[int i]=>Value[i];

public static A246798Inst Instance=new A246798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246799
{
public static readonly long[] Value={ 1L,7L,2L,34L,20L,3L,142L,128L,39L,4L,547L,668L,309L,64L,5L,2005L,3098L,1929L,604L,95L,6L,7108L,13304L,10434L,4384L,1040L,132L,7L,24604L,54128L,51258L,27064L,8600L,1644L,175L,8L,83653L,211592L,234966L,149536L,59630L,15252L,2443L,224L,9L,280483L,802082L,1022286L,761896L,365810L,117312L,25123L,3464L,279L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246799Inst : IEnumerable<long>
{
public static readonly long[] Value=A246799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246799.Bytes);
public long this[int i]=>Value[i];

public static A246799Inst Instance=new A246799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246800
{
public static readonly long[] Value={ 6L,10L,84L,186L,1276L,3172L,19816L,52666L,310764L,863820L,4899736L,14073060L,77509464L,228318856L,1228859344L,3693886906L,19513475404L,59644341436L,310223170744L,961665098956L,4936304385544L,15488087080696L,78602174905264L,249227373027556L,1252310513280376L,4007681094422392L,19961337935130096L,64408903437167496L,318297642651252784L,1034656923041985552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246800Inst : IEnumerable<long>
{
public static readonly long[] Value=A246800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246800.Bytes);
public long this[int i]=>Value[i];

public static A246800Inst Instance=new A246800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246801
{
public static readonly long[] Value={ 4057L,4463L,4969L,5881L,6691L,86117L,90121L,129169L,131171L,136177L,160207L,162209L,169217L,193247L,225287L,252319L,265333L,272341L,280351L,288361L,297371L,327407L,346429L,355441L,388481L,410507L,429529L,451553L,456559L,474581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246801Inst : IEnumerable<long>
{
public static readonly long[] Value=A246801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246801.Bytes);
public long this[int i]=>Value[i];

public static A246801Inst Instance=new A246801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246802
{
public static readonly long[] Value={ 92L,368L,712L,1472L,94208L,1507328L,6029312L,37412864L,24696061952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246802Inst : IEnumerable<long>
{
public static readonly long[] Value=A246802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246802.Bytes);
public long this[int i]=>Value[i];

public static A246802Inst Instance=new A246802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246803
{
public static readonly long[] Value={ 6L,10L,14L,20L,22L,24L,34L,40L,44L,46L,56L,62L,68L,88L,92L,94L,106L,136L,142L,152L,164L,184L,188L,212L,214L,232L,248L,254L,284L,332L,376L,382L,384L,424L,428L,464L,472L,568L,632L,640L,668L,712L,764L,766L,856L,862L,864L,896L,944L,1004L,1016L,1172L,1192L,1294L,1408L,1424L,1432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246803Inst : IEnumerable<long>
{
public static readonly long[] Value=A246803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246803.Bytes);
public long this[int i]=>Value[i];

public static A246803Inst Instance=new A246803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246804
{
public static readonly long[] Value={ 1L,3L,15L,135L,645L,1373L,195317L,237249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246804Inst : IEnumerable<long>
{
public static readonly long[] Value=A246804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246804.Bytes);
public long this[int i]=>Value[i];

public static A246804Inst Instance=new A246804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246805
{
public static readonly long[] Value={ 1L,3L,4L,7L,19L,31L,67L,391L,583L,4549L,917467L,6777061L,86794921L,1421517037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246805Inst : IEnumerable<long>
{
public static readonly long[] Value=A246805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246805.Bytes);
public long this[int i]=>Value[i];

public static A246805Inst Instance=new A246805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246806
{
public static readonly long[] Value={ 1L,4L,33L,285L,2643L,24920L,239543L,2327458L,22801065L,224608236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246806Inst : IEnumerable<long>
{
public static readonly long[] Value=A246806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246806.Bytes);
public long this[int i]=>Value[i];

public static A246806Inst Instance=new A246806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246807
{
public static readonly long[] Value={ 1L,0L,2L,2L,5L,8L,15L,33L,59L,126L,246L,494L,978L,1971L,3930L,7845L,15749L,31527L,63349L,126986L,254880L,511468L,1026348L,2060633L,4135808L,8303940L,16669925L,33472231L,67201664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246807Inst : IEnumerable<long>
{
public static readonly long[] Value=A246807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246807.Bytes);
public long this[int i]=>Value[i];

public static A246807Inst Instance=new A246807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246808
{
public static readonly long[] Value={ 2112L,4803443084L,6992662996L,180461164081L,214591195412L,409473374904L,563715517365L,4163019339103614L,1050417996997140501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246808Inst : IEnumerable<long>
{
public static readonly long[] Value=A246808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246808.Bytes);
public long this[int i]=>Value[i];

public static A246808Inst Instance=new A246808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246809
{
public static readonly long[] Value={ 12801L,136497879001L,422240040001L,18677955240001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246809Inst : IEnumerable<long>
{
public static readonly long[] Value=A246809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246809.Bytes);
public long this[int i]=>Value[i];

public static A246809Inst Instance=new A246809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246810
{
public static readonly long[] Value={ 1L,5L,12L,17L,25L,55L,83L,169L,207L,206L,384L,953L,1615L,2192L,2197L,3024L,3023L,10709L,10935L,29509L,29508L,62736L,62735L,94333L,94332L,196966L,314940L,608777L,1258688L,1767259L,2448975L,2448973L,7939362L,9373136L,9373134L,16854966L,16854967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246810Inst : IEnumerable<long>
{
public static readonly long[] Value=A246810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246810.Bytes);
public long this[int i]=>Value[i];

public static A246810Inst Instance=new A246810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246811
{
public static readonly long[] Value={ 1L,4L,4L,0L,5L,12L,4L,0L,8L,12L,8L,0L,5L,16L,12L,0L,8L,24L,4L,0L,16L,12L,12L,0L,9L,24L,12L,0L,8L,36L,12L,0L,16L,12L,16L,0L,8L,28L,16L,0L,17L,36L,8L,0L,24L,24L,8L,0L,8L,36L,28L,0L,16L,36L,12L,0L,16L,24L,20L,0L,13L,24L,24L,0L,24L,60L,8L,0L,16L,36L,16L,0L,16L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246811Inst : IEnumerable<long>
{
public static readonly long[] Value=A246811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246811.Bytes);
public long this[int i]=>Value[i];

public static A246811Inst Instance=new A246811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246812
{
public static readonly long[] Value={ 1L,2L,9L,44L,241L,1374L,8145L,49512L,306729L,1927802L,12256753L,78661620L,508786129L,3312561638L,21688815729L,142699137072L,942873631497L,6253352120322L,41611854129585L,277723513754364L,1858529465302329L,12467403845702526L,83817799189753785L,564633483609422808L,3810607016379076521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246812Inst : IEnumerable<long>
{
public static readonly long[] Value=A246812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246812.Bytes);
public long this[int i]=>Value[i];

public static A246812Inst Instance=new A246812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246813
{
public static readonly BigInteger[] Value={ 1L,4L,23L,152L,1085L,8156L,63579L,509136L,4161649L,34566580L,290798551L,2471871784L,21191824645L,182984610220L,1589620392835L,13881368684128L,121767703088377L,1072382299895428L,9477296423786207L,84017470425706040L,746903374745524629L,6656552616997851036L,BigInteger.Parse("59459592374756968323") };
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
public class A246813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A246813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246813Inst Instance=new A246813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246814
{
public static readonly long[] Value={ 1L,-2L,0L,0L,-2L,8L,0L,0L,-4L,-10L,0L,0L,8L,8L,0L,0L,6L,-16L,0L,0L,-8L,16L,0L,0L,-8L,-10L,0L,0L,0L,24L,0L,0L,12L,-16L,0L,0L,-10L,8L,0L,0L,-8L,-32L,0L,0L,24L,24L,0L,0L,8L,-18L,0L,0L,-8L,24L,0L,0L,-16L,-16L,0L,0L,0L,24L,0L,0L,6L,-32L,0L,0L,-16L,32L,0L,0L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246814Inst : IEnumerable<long>
{
public static readonly long[] Value=A246814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246814.Bytes);
public long this[int i]=>Value[i];

public static A246814Inst Instance=new A246814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246815
{
public static readonly long[] Value={ 1L,-2L,-2L,4L,3L,-2L,-6L,4L,4L,-6L,-4L,4L,7L,-8L,-2L,8L,8L,-4L,-10L,4L,4L,-10L,-10L,8L,9L,-4L,-6L,12L,8L,-6L,-10L,12L,4L,-14L,-8L,4L,16L,-10L,-8L,8L,9L,-10L,-12L,12L,8L,-12L,-12L,4L,20L,-10L,-6L,20L,8L,-6L,-10L,12L,8L,-20L,-18L,8L,11L,-12L,-12L,16L,8L,-6L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246815Inst : IEnumerable<long>
{
public static readonly long[] Value=A246815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246815.Bytes);
public long this[int i]=>Value[i];

public static A246815Inst Instance=new A246815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246816
{
public static readonly long[] Value={ 1L,2L,-2L,-4L,0L,-4L,0L,8L,-2L,6L,8L,-4L,0L,-12L,0L,8L,-4L,8L,-10L,-12L,0L,-8L,0L,8L,8L,14L,8L,-16L,0L,-4L,0L,16L,6L,16L,-16L,-8L,0L,-20L,0L,8L,-8L,8L,16L,-20L,0L,-20L,0L,16L,-8L,18L,-10L,-8L,0L,-12L,0L,24L,0L,16L,24L,-12L,0L,-20L,0L,24L,12L,8L,-16L,-28L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246816Inst : IEnumerable<long>
{
public static readonly long[] Value=A246816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246816.Bytes);
public long this[int i]=>Value[i];

public static A246816Inst Instance=new A246816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246817
{
public static readonly long[] Value={ 0L,5L,15L,30L,50L,100L,130L,165L,205L,250L,350L,405L,465L,530L,600L,750L,830L,915L,1005L,1100L,1300L,1405L,1515L,1630L,1750L,2125L,2255L,2390L,2530L,2675L,2975L,3130L,3290L,3455L,3625L,3975L,4155L,4340L,4530L,4725L,5125L,5330L,5540L,5755L,5975L,6425L,6655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246817Inst : IEnumerable<long>
{
public static readonly long[] Value=A246817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246817.Bytes);
public long this[int i]=>Value[i];

public static A246817Inst Instance=new A246817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246818
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,32L,277L,3179L,41799L,632365L,10922385L,210953381L,4498975425L,105131807571L,2672061475343L,73358721633794L,2163013965362752L,68174082537113173L,2287395123402364673L,BigInteger.Parse("81397403660409278779"),BigInteger.Parse("3061825168335759481187"),BigInteger.Parse("121385088042529743488517"),BigInteger.Parse("5058460899905730365609710") };
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
public class A246818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A246818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246818Inst Instance=new A246818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246819
{
public static readonly long[] Value={ 0L,0L,0L,4L,2L,4L,2L,13L,7L,13L,7L,4L,2L,0L,17L,11L,9L,6L,2L,24L,21L,17L,11L,12L,8L,6L,2L,18L,29L,15L,11L,5L,3L,16L,14L,8L,18L,14L,8L,22L,20L,10L,30L,29L,27L,15L,3L,6L,8L,4L,0L,30L,20L,14L,60L,54L,52L,46L,42L,40L,30L,16L,12L,10L,41L,27L,21L,11L,20L,16L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246819Inst : IEnumerable<long>
{
public static readonly long[] Value=A246819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246819.Bytes);
public long this[int i]=>Value[i];

public static A246819Inst Instance=new A246819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246820
{
public static readonly long[] Value={ 3L,4L,3L,3L,7L,7L,9L,6L,1L,5L,5L,6L,4L,2L,7L,0L,3L,2L,8L,3L,2L,5L,3L,3L,0L,0L,3L,8L,5L,8L,3L,1L,2L,4L,3L,4L,0L,0L,1L,2L,4L,4L,0L,1L,9L,4L,9L,9L,9L,0L,7L,5L,1L,9L,2L,0L,5L,7L,6L,7L,1L,8L,1L,6L,3L,8L,7L,0L,4L,6L,4L,2L,2L,9L,8L,1L,1L,7L,5L,7L,2L,6L,2L,8L,3L,3L,3L,2L,7L,6L,2L,9L,6L,8L,6L,0L,1L,2L,1L,2L,4L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246820Inst : IEnumerable<long>
{
public static readonly long[] Value=A246820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246820.Bytes);
public long this[int i]=>Value[i];

public static A246820Inst Instance=new A246820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246821
{
public static readonly long[] Value={ 1L,2L,4L,8L,6L,8L,6L,14L,14L,16L,10L,14L,12L,26L,26L,20L,18L,12L,26L,37L,31L,27L,50L,42L,38L,36L,32L,30L,41L,27L,23L,27L,25L,15L,16L,22L,16L,26L,20L,14L,29L,19L,34L,30L,40L,40L,28L,24L,22L,18L,12L,10L,20L,20L,14L,8L,16L,10L,26L,41L,31L,17L,13L,11L,45L,31L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246821Inst : IEnumerable<long>
{
public static readonly long[] Value=A246821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246821.Bytes);
public long this[int i]=>Value[i];

public static A246821Inst Instance=new A246821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246822
{
public static readonly long[] Value={ 0L,8L,3L,3L,1L,5L,4L,7L,0L,5L,8L,7L,6L,8L,6L,2L,9L,8L,3L,8L,3L,0L,6L,2L,7L,3L,8L,5L,6L,7L,5L,9L,8L,5L,7L,7L,3L,0L,6L,5L,8L,4L,9L,3L,7L,4L,6L,4L,0L,3L,9L,4L,1L,6L,4L,7L,4L,9L,4L,9L,5L,3L,4L,5L,2L,4L,0L,9L,1L,5L,0L,5L,5L,5L,7L,2L,8L,8L,1L,2L,4L,0L,0L,9L,1L,9L,6L,2L,1L,3L,0L,9L,9L,5L,8L,1L,7L,3L,2L,2L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246822Inst : IEnumerable<long>
{
public static readonly long[] Value=A246822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246822.Bytes);
public long this[int i]=>Value[i];

public static A246822Inst Instance=new A246822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246823
{
public static readonly long[] Value={ 1L,4L,5L,5L,9L,3L,8L,0L,9L,2L,6L,7L,6L,4L,0L,4L,1L,9L,4L,0L,1L,2L,1L,4L,8L,9L,4L,0L,9L,5L,7L,3L,2L,4L,9L,8L,2L,1L,8L,0L,2L,8L,3L,6L,0L,2L,3L,2L,3L,2L,0L,4L,8L,3L,0L,6L,5L,3L,5L,6L,0L,9L,9L,3L,1L,9L,6L,7L,7L,7L,6L,6L,5L,2L,3L,7L,6L,8L,1L,6L,5L,7L,5L,9L,8L,8L,7L,4L,2L,0L,2L,8L,8L,5L,9L,5L,7L,9L,9L,6L,5L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246823Inst : IEnumerable<long>
{
public static readonly long[] Value=A246823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246823.Bytes);
public long this[int i]=>Value[i];

public static A246823Inst Instance=new A246823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246824
{
public static readonly long[] Value={ 3L,35L,41L,52L,57L,81L,104L,209L,215L,343L,373L,398L,473L,477L,584L,628L,768L,774L,828L,872L,1117L,1145L,1189L,1287L,1324L,1435L,1615L,1634L,1653L,1704L,1886L,1925L,2070L,2075L,2123L,2171L,2193L,2425L,2449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246824Inst : IEnumerable<long>
{
public static readonly long[] Value=A246824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246824.Bytes);
public long this[int i]=>Value[i];

public static A246824Inst Instance=new A246824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246825
{
public static readonly long[] Value={ 2L,3L,9L,8L,3L,8L,4L,3L,8L,2L,7L,8L,1L,6L,1L,1L,4L,2L,9L,3L,9L,3L,8L,7L,6L,8L,4L,7L,5L,2L,3L,8L,7L,4L,1L,9L,1L,8L,0L,6L,9L,9L,1L,7L,7L,5L,1L,6L,2L,5L,6L,2L,8L,2L,8L,1L,9L,6L,9L,1L,1L,1L,0L,7L,9L,4L,4L,8L,7L,7L,9L,7L,4L,1L,2L,1L,6L,4L,1L,6L,2L,3L,4L,6L,4L,1L,4L,5L,1L,5L,4L,4L,6L,6L,1L,6L,5L,9L,5L,3L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246825Inst : IEnumerable<long>
{
public static readonly long[] Value=A246825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246825.Bytes);
public long this[int i]=>Value[i];

public static A246825Inst Instance=new A246825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246826
{
public static readonly long[] Value={ 0L,10L,26L,30L,36L,136L,156L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246826Inst : IEnumerable<long>
{
public static readonly long[] Value=A246826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246826.Bytes);
public long this[int i]=>Value[i];

public static A246826Inst Instance=new A246826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246827
{
public static readonly long[] Value={ 6L,120L,84L,4320L,30L,30240L,42L,293760L,252L,3360L,66L,208565280L,78L,840L,420L,760320L,102L,18506880L,114L,131040L,1890L,1320L,138L,14182439040L,150L,1560L,756L,30240L,174L,668304000L,186L,1272960L,924L,2040L,210L,2068967577600L,222L,2280L,1092L,8910720L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246827Inst : IEnumerable<long>
{
public static readonly long[] Value=A246827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246827.Bytes);
public long this[int i]=>Value[i];

public static A246827Inst Instance=new A246827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246828
{
public static readonly long[] Value={ 2L,6L,9L,8L,3L,2L,9L,1L,0L,6L,4L,7L,4L,2L,1L,1L,2L,3L,1L,2L,6L,3L,9L,9L,8L,6L,6L,6L,1L,8L,8L,3L,7L,6L,3L,3L,0L,7L,1L,3L,4L,6L,5L,1L,2L,5L,9L,1L,3L,9L,8L,6L,3L,5L,6L,7L,6L,9L,0L,1L,2L,3L,1L,1L,7L,8L,1L,9L,8L,6L,5L,9L,3L,6L,6L,9L,5L,0L,5L,5L,9L,4L,5L,1L,3L,6L,6L,4L,7L,6L,6L,5L,2L,0L,2L,2L,0L,3L,5L,5L,8L,0L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246828Inst : IEnumerable<long>
{
public static readonly long[] Value=A246828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246828.Bytes);
public long this[int i]=>Value[i];

public static A246828Inst Instance=new A246828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246829
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,16L,45L,111L,318L,881L,2686L,8033L,25470L,80480L,263977L,862865L,2891344L,9706757L,33178076L,113784968L,395303480L,1379160685L,4859274472L,17195407935L,61310096228L,219520467207L,790749207801L,2859542098634L,10391610220375L,37897965144166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246829Inst : IEnumerable<long>
{
public static readonly long[] Value=A246829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246829.Bytes);
public long this[int i]=>Value[i];

public static A246829Inst Instance=new A246829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246830
{
public static readonly long[] Value={ 0L,3L,2L,10L,7L,4L,15L,20L,13L,6L,36L,29L,22L,15L,8L,45L,38L,31L,40L,25L,10L,54L,47L,72L,57L,42L,27L,12L,63L,104L,89L,74L,59L,44L,29L,14L,136L,121L,106L,91L,76L,61L,46L,31L,16L,153L,138L,123L,108L,93L,78L,63L,80L,49L,18L,170L,155L,140L,125L,110L,95L,144L,113L,82L,51L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246830Inst : IEnumerable<long>
{
public static readonly long[] Value=A246830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246830.Bytes);
public long this[int i]=>Value[i];

public static A246830Inst Instance=new A246830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246831
{
public static readonly long[] Value={ 0L,7L,22L,57L,76L,95L,210L,245L,280L,315L,350L,737L,804L,871L,938L,1005L,1072L,1139L,1206L,1273L,1340L,1407L,2882L,3013L,3144L,3275L,3406L,3537L,3668L,3799L,3930L,4061L,4192L,4323L,4454L,4585L,4716L,4847L,4978L,5109L,5240L,5371L,5502L,11137L,11396L,11655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246831Inst : IEnumerable<long>
{
public static readonly long[] Value=A246831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246831.Bytes);
public long this[int i]=>Value[i];

public static A246831Inst Instance=new A246831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246832
{
public static readonly long[] Value={ 1L,1L,3L,4L,2L,5L,2L,3L,7L,5L,5L,6L,5L,3L,10L,6L,3L,7L,7L,4L,11L,9L,3L,14L,8L,8L,5L,4L,7L,10L,13L,7L,8L,10L,7L,15L,8L,4L,17L,10L,8L,11L,10L,5L,16L,11L,4L,11L,15L,8L,14L,10L,7L,22L,8L,9L,14L,8L,13L,21L,12L,5L,13L,15L,6L,21L,15L,9L,13L,8L,11L,9L,12L,15L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246832Inst : IEnumerable<long>
{
public static readonly long[] Value=A246832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246832.Bytes);
public long this[int i]=>Value[i];

public static A246832Inst Instance=new A246832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246833
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,3L,-2L,4L,-4L,2L,-2L,5L,-4L,2L,-6L,3L,-6L,7L,-2L,5L,-4L,5L,-6L,6L,-2L,5L,-10L,3L,-6L,10L,-4L,6L,-8L,3L,-8L,7L,-6L,7L,-6L,4L,-6L,11L,-6L,9L,-10L,3L,-6L,14L,-4L,8L,-10L,8L,-10L,5L,-6L,4L,-16L,7L,-4L,10L,-4L,13L,-14L,7L,-8L,8L,-6L,10L,-12L,7L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246833Inst : IEnumerable<long>
{
public static readonly long[] Value=A246833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246833.Bytes);
public long this[int i]=>Value[i];

public static A246833Inst Instance=new A246833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246834
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,2L,0L,6L,10L,3L,0L,7L,20L,15L,4L,0L,12L,22L,30L,36L,5L,0L,13L,40L,57L,72L,45L,6L,0L,14L,42L,60L,76L,90L,54L,7L,0L,15L,44L,63L,144L,95L,108L,63L,8L,0L,24L,46L,114L,148L,180L,210L,126L,136L,9L,0L,25L,80L,117L,152L,185L,216L,245L,272L,153L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246834Inst : IEnumerable<long>
{
public static readonly long[] Value=A246834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246834.Bytes);
public long this[int i]=>Value[i];

public static A246834Inst Instance=new A246834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246835
{
public static readonly long[] Value={ 1L,-2L,3L,-6L,4L,-4L,7L,-2L,8L,-10L,4L,-10L,9L,-6L,8L,-10L,4L,-8L,16L,-8L,9L,-12L,8L,-12L,20L,-6L,8L,-10L,8L,-18L,11L,-12L,8L,-20L,12L,-8L,20L,-6L,20L,-26L,8L,-8L,15L,-10L,16L,-18L,12L,-16L,20L,-10L,16L,-16L,8L,-24L,24L,-8L,21L,-26L,8L,-20L,20L,-14L,8L,-28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246835Inst : IEnumerable<long>
{
public static readonly long[] Value=A246835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246835.Bytes);
public long this[int i]=>Value[i];

public static A246835Inst Instance=new A246835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246836
{
public static readonly long[] Value={ 1L,2L,-2L,-4L,3L,2L,-6L,-4L,4L,6L,-4L,-4L,7L,8L,-2L,-8L,8L,4L,-10L,-4L,4L,10L,-10L,-8L,9L,4L,-6L,-12L,8L,6L,-10L,-12L,4L,14L,-8L,-4L,16L,10L,-8L,-8L,9L,10L,-12L,-12L,8L,12L,-12L,-4L,20L,10L,-6L,-20L,8L,6L,-10L,-12L,8L,20L,-18L,-8L,11L,12L,-12L,-16L,8L,6L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246836Inst : IEnumerable<long>
{
public static readonly long[] Value=A246836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246836.Bytes);
public long this[int i]=>Value[i];

public static A246836Inst Instance=new A246836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246837
{
public static readonly long[] Value={ 1L,3L,2L,1L,5L,5L,3L,5L,4L,4L,6L,6L,3L,5L,9L,6L,10L,4L,3L,13L,4L,5L,9L,8L,5L,8L,12L,4L,13L,10L,7L,14L,5L,5L,11L,8L,9L,12L,6L,7L,15L,15L,6L,13L,12L,6L,13L,6L,7L,21L,17L,6L,13L,8L,10L,12L,14L,9L,8L,15L,6L,22L,8L,9L,22L,14L,10L,11L,15L,11L,22L,16L,6L,8L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246837Inst : IEnumerable<long>
{
public static readonly long[] Value=A246837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246837.Bytes);
public long this[int i]=>Value[i];

public static A246837Inst Instance=new A246837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246838
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-1L,0L,1L,-1L,0L,2L,-1L,0L,0L,0L,0L,2L,-1L,0L,1L,-1L,0L,0L,-2L,0L,0L,-1L,0L,2L,0L,0L,0L,-1L,0L,0L,-1L,0L,3L,-1L,0L,0L,-1L,0L,2L,-1L,0L,2L,0L,0L,0L,-1L,0L,0L,-1L,0L,2L,-1L,0L,0L,0L,0L,1L,-2L,0L,0L,-2L,0L,0L,-1L,0L,2L,-1L,0L,2L,0L,0L,0L,-1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246838Inst : IEnumerable<long>
{
public static readonly long[] Value=A246838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246838.Bytes);
public long this[int i]=>Value[i];

public static A246838Inst Instance=new A246838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246839
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,5L,5L,5L,5L,5L,15L,15L,15L,15L,15L,30L,30L,30L,30L,30L,50L,50L,50L,50L,50L,100L,100L,100L,100L,100L,130L,130L,130L,130L,130L,165L,165L,165L,165L,165L,205L,205L,205L,205L,205L,250L,250L,250L,250L,250L,350L,350L,350L,350L,350L,405L,405L,405L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246839Inst : IEnumerable<long>
{
public static readonly long[] Value=A246839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246839.Bytes);
public long this[int i]=>Value[i];

public static A246839Inst Instance=new A246839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246840
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,10L,18L,35L,73L,151L,306L,623L,1286L,2668L,5531L,11477L,23889L,49852L,104175L,217936L,456534L,957609L,2010839L,4226417L,8891022L,18719637L,39443860L,83170162L,175484915L,370491775L,782648333L,1654197568L,3498049053L,7400639286L,15664103420L,33168342557L,70260909811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246840Inst : IEnumerable<long>
{
public static readonly long[] Value=A246840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246840.Bytes);
public long this[int i]=>Value[i];

public static A246840Inst Instance=new A246840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246841
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,4L,10L,8L,8L,14L,12L,13L,19L,16L,9L,5L,19L,19L,9L,15L,13L,27L,25L,14L,21L,15L,24L,28L,15L,9L,24L,31L,21L,12L,16L,14L,23L,34L,25L,28L,23L,30L,29L,22L,32L,22L,24L,20L,27L,26L,15L,40L,34L,16L,20L,20L,29L,42L,45L,35L,12L,24L,40L,10L,21L,32L,60L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246841Inst : IEnumerable<long>
{
public static readonly long[] Value=A246841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246841.Bytes);
public long this[int i]=>Value[i];

public static A246841Inst Instance=new A246841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246842
{
public static readonly long[] Value={ 37L,163L,56893L,409333L,1483087L,1867783L,10101463L,18292957L,31284493L,52896517L,58048057L,157861663L,175933717L,180336193L,222640867L,258001837L,276739747L,349693117L,371305267L,445890307L,543764323L,613305067L,678551833L,748576753L,828497443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246842Inst : IEnumerable<long>
{
public static readonly long[] Value=A246842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246842.Bytes);
public long this[int i]=>Value[i];

public static A246842Inst Instance=new A246842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246843
{
public static readonly long[] Value={ 0L,8L,9L,3L,2L,6L,5L,2L,2L,3L,4L,3L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246843Inst : IEnumerable<long>
{
public static readonly long[] Value=A246843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246843.Bytes);
public long this[int i]=>Value[i];

public static A246843Inst Instance=new A246843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246844
{
public static readonly long[] Value={ 6L,8L,2L,1L,1L,2L,8L,9L,1L,3L,3L,8L,2L,3L,9L,9L,4L,1L,1L,5L,9L,5L,5L,6L,8L,2L,8L,8L,0L,4L,4L,3L,0L,0L,3L,4L,7L,1L,1L,7L,7L,7L,7L,5L,6L,1L,3L,7L,8L,7L,5L,3L,0L,9L,2L,0L,4L,2L,5L,9L,2L,8L,4L,4L,1L,0L,0L,0L,3L,5L,4L,7L,4L,4L,7L,5L,1L,8L,7L,0L,0L,0L,1L,2L,1L,0L,9L,2L,7L,1L,3L,8L,9L,3L,2L,8L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246844Inst : IEnumerable<long>
{
public static readonly long[] Value=A246844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246844.Bytes);
public long this[int i]=>Value[i];

public static A246844Inst Instance=new A246844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246845
{
public static readonly long[] Value={ 6L,8L,2L,1L,1L,2L,9L,4L,4L,2L,5L,0L,4L,9L,1L,7L,6L,2L,4L,3L,9L,0L,2L,2L,6L,7L,4L,3L,9L,4L,9L,3L,6L,9L,0L,7L,3L,8L,2L,8L,5L,6L,4L,4L,8L,1L,1L,0L,3L,4L,9L,1L,5L,1L,5L,0L,5L,8L,0L,5L,3L,5L,1L,5L,9L,0L,4L,0L,0L,6L,8L,9L,7L,6L,5L,0L,2L,3L,3L,5L,3L,6L,1L,8L,7L,7L,1L,8L,7L,0L,3L,6L,9L,0L,1L,6L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246845Inst : IEnumerable<long>
{
public static readonly long[] Value=A246845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246845.Bytes);
public long this[int i]=>Value[i];

public static A246845Inst Instance=new A246845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246846
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,4L,0L,2L,0L,21L,46L,76L,96L,2L,115L,369L,330L,1804L,481L,330L,8632L,6184L,18226L,35100L,42702L,17098L,108120L,249950L,342721L,433224L,1118854L,760977L,2881920L,566378L,4113707L,2229460L,2634351L,19518945L,48149442L,41302415L,97296382L,35211640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246846Inst : IEnumerable<long>
{
public static readonly long[] Value=A246846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246846.Bytes);
public long this[int i]=>Value[i];

public static A246846Inst Instance=new A246846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246847
{
public static readonly long[] Value={ 3L,4L,7L,8L,7L,5L,0L,7L,8L,5L,7L,3L,3L,9L,6L,0L,2L,6L,0L,6L,7L,1L,4L,8L,7L,2L,6L,1L,3L,9L,0L,3L,3L,5L,4L,0L,4L,3L,4L,3L,1L,2L,6L,3L,0L,2L,5L,7L,2L,5L,9L,8L,8L,5L,8L,6L,2L,4L,2L,0L,6L,6L,5L,5L,5L,9L,2L,0L,6L,6L,4L,6L,5L,8L,7L,3L,0L,3L,7L,9L,3L,3L,4L,0L,9L,8L,0L,8L,5L,3L,8L,0L,8L,8L,5L,8L,7L,4L,5L,1L,8L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246847Inst : IEnumerable<long>
{
public static readonly long[] Value=A246847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246847.Bytes);
public long this[int i]=>Value[i];

public static A246847Inst Instance=new A246847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246848
{
public static readonly long[] Value={ 3L,7L,7L,5L,4L,0L,6L,6L,8L,7L,9L,8L,1L,4L,5L,4L,3L,5L,3L,6L,1L,0L,9L,9L,4L,3L,4L,2L,5L,4L,4L,9L,1L,5L,2L,1L,2L,4L,6L,7L,2L,0L,6L,3L,4L,6L,9L,1L,0L,8L,9L,8L,3L,6L,9L,4L,0L,5L,6L,2L,8L,3L,7L,3L,4L,1L,4L,5L,5L,0L,0L,4L,3L,5L,9L,9L,7L,5L,3L,2L,0L,4L,9L,7L,4L,1L,6L,3L,0L,5L,2L,7L,5L,2L,5L,7L,6L,2L,6L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246848Inst : IEnumerable<long>
{
public static readonly long[] Value=A246848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246848.Bytes);
public long this[int i]=>Value[i];

public static A246848Inst Instance=new A246848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246849
{
public static readonly long[] Value={ 8L,2L,8L,4L,9L,9L,5L,0L,6L,8L,5L,8L,4L,6L,3L,9L,3L,4L,1L,3L,9L,5L,6L,0L,0L,2L,8L,4L,4L,4L,7L,8L,7L,8L,9L,0L,3L,7L,7L,7L,3L,7L,0L,9L,5L,7L,7L,0L,4L,4L,9L,1L,5L,8L,2L,8L,5L,7L,8L,8L,9L,0L,8L,1L,7L,6L,3L,0L,1L,3L,9L,4L,4L,0L,5L,6L,9L,1L,4L,2L,2L,0L,1L,2L,0L,2L,8L,8L,0L,1L,9L,1L,3L,1L,9L,9L,1L,8L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246849Inst : IEnumerable<long>
{
public static readonly long[] Value=A246849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246849.Bytes);
public long this[int i]=>Value[i];

public static A246849Inst Instance=new A246849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246850
{
public static readonly long[] Value={ 2L,4L,8L,12L,20L,36L,44L,60L,84L,116L,140L,156L,204L,260L,380L,420L,660L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246850Inst : IEnumerable<long>
{
public static readonly long[] Value=A246850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246850.Bytes);
public long this[int i]=>Value[i];

public static A246850Inst Instance=new A246850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246851
{
public static readonly long[] Value={ 1L,1L,7L,1L,3577L,1L,25L,8L,13L,1L,403668223L,1L,833L,262L,19L,1L,27L,1L,793L,5L,45L,1L,1795L,66L,8L,9L,31L,1L,2005L,1L,309L,32L,261L,4238L,22490141L,1L,21L,40L,43L,1L,399L,1L,1897L,262L,193L,1L,27L,1252907952L,711L,49L,1158765L,1L,271259L,27L,129L,20518072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246851Inst : IEnumerable<long>
{
public static readonly long[] Value=A246851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246851.Bytes);
public long this[int i]=>Value[i];

public static A246851Inst Instance=new A246851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246852
{
public static readonly long[] Value={ 1L,2L,22L,14926L,31048L,69106L,246262L,5860168L,307164670L,881198662L,1489455646L,2386555630L,8225563702L,14311679062L,111494234182L,154357775302L,299004519622L,870455062822L,970388922262L,991817878342L,1677028870822L,1782783762502L,1830446935222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246852Inst : IEnumerable<long>
{
public static readonly long[] Value=A246852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246852.Bytes);
public long this[int i]=>Value[i];

public static A246852Inst Instance=new A246852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246853
{
public static readonly long[] Value={ 7L,6285L,4693485L,54028959L,75898473L,724416741L,2359059709L,4901493769L,321212249593L,511578306649L,534245763769L,6158645822473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246853Inst : IEnumerable<long>
{
public static readonly long[] Value=A246853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246853.Bytes);
public long this[int i]=>Value[i];

public static A246853Inst Instance=new A246853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246854
{
public static readonly long[] Value={ 1L,4L,26L,122L,146L,458L,746L,3746L,47612L,16065500L,388978292L,5313509288L,64278616556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246854Inst : IEnumerable<long>
{
public static readonly long[] Value=A246854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246854.Bytes);
public long this[int i]=>Value[i];

public static A246854Inst Instance=new A246854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246855
{
public static readonly long[] Value={ 3577L,14773L,2843579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246855Inst : IEnumerable<long>
{
public static readonly long[] Value=A246855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246855.Bytes);
public long this[int i]=>Value[i];

public static A246855Inst Instance=new A246855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246856
{
public static readonly long[] Value={ 4L,8L,5L,6L,0L,5L,5L,3L,2L,0L,9L,3L,1L,6L,6L,2L,0L,3L,8L,6L,2L,6L,4L,3L,5L,3L,4L,8L,9L,0L,5L,2L,9L,3L,9L,8L,5L,5L,1L,9L,5L,3L,7L,8L,3L,1L,0L,2L,0L,8L,8L,0L,2L,5L,8L,3L,8L,3L,4L,6L,2L,1L,2L,4L,3L,6L,0L,6L,2L,2L,7L,9L,0L,2L,3L,6L,5L,5L,0L,5L,9L,2L,8L,0L,6L,9L,8L,2L,6L,2L,7L,2L,6L,5L,7L,8L,9L,6L,2L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246856Inst : IEnumerable<long>
{
public static readonly long[] Value=A246856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246856.Bytes);
public long this[int i]=>Value[i];

public static A246856Inst Instance=new A246856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246857
{
public static readonly long[] Value={ 2L,3L,5L,11L,23L,29L,41L,53L,83L,89L,113L,131L,173L,179L,191L,233L,239L,251L,281L,293L,329L,359L,413L,419L,431L,443L,491L,509L,593L,623L,641L,653L,659L,683L,719L,743L,761L,809L,869L,911L,953L,979L,1013L,1019L,1031L,1049L,1103L,1223L,1229L,1289L,1409L,1439L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246857Inst : IEnumerable<long>
{
public static readonly long[] Value=A246857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246857.Bytes);
public long this[int i]=>Value[i];

public static A246857Inst Instance=new A246857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246858
{
public static readonly long[] Value={ 329L,413L,623L,869L,979L,1819L,2585L,3107L,3173L,3197L,3887L,4235L,4997L,5771L,6149L,6187L,6443L,7409L,8399L,8759L,14429L,15323L,18515L,19019L,21181L,21413L,23989L,26491L,29749L,30355L,31043L,32623L,34009L,34177L,39737L,47321L,47845L,51389L,53311L,56419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246858Inst : IEnumerable<long>
{
public static readonly long[] Value=A246858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246858.Bytes);
public long this[int i]=>Value[i];

public static A246858Inst Instance=new A246858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246859
{
public static readonly long[] Value={ 3L,4L,6L,1L,1L,8L,9L,6L,5L,6L,0L,5L,9L,3L,3L,4L,5L,0L,9L,9L,6L,0L,9L,0L,5L,4L,2L,0L,6L,8L,7L,6L,5L,9L,1L,5L,9L,8L,3L,9L,5L,2L,8L,1L,3L,8L,5L,9L,7L,4L,8L,6L,4L,0L,1L,6L,3L,8L,0L,5L,8L,7L,7L,3L,1L,1L,3L,5L,8L,2L,9L,0L,2L,6L,8L,1L,8L,2L,6L,3L,6L,4L,6L,1L,5L,2L,8L,7L,9L,5L,5L,1L,0L,8L,9L,7L,3L,4L,2L,3L,8L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246859Inst : IEnumerable<long>
{
public static readonly long[] Value=A246859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246859.Bytes);
public long this[int i]=>Value[i];

public static A246859Inst Instance=new A246859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246860
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,903L,8778L,92235L,1023165L,11821953L,141061206L,1727926291L,21634600078L,275950576450L,3576315994020L,46995014634435L,625082431593285L,8403885851894445L,114069364107664350L,1561609592248119645L,BigInteger.Parse("21543838447412548410"),BigInteger.Parse("299299110959202973710") };
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
public class A246860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A246860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246860Inst Instance=new A246860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246861
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,21L,54L,141L,407L,1231L,3691L,10990L,33144L,101674L,314679L,977289L,3047527L,9557503L,30133759L,95390622L,302960929L,965282651L,3085146472L,9888455045L,31774215928L,102334358736L,330298415136L,1068242904256L,3461372341327L,11235251353747L,36527859658661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246861Inst : IEnumerable<long>
{
public static readonly long[] Value=A246861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246861.Bytes);
public long this[int i]=>Value[i];

public static A246861Inst Instance=new A246861Inst();

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