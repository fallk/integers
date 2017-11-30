using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199757
{
public static readonly long[] Value={ 4L,39L,424L,4659L,51244L,563679L,6200464L,68205099L,750256084L,8252816919L,90780986104L,998590847139L,10984499318524L,120829492503759L,1329124417541344L,14620368592954779L,160824054522502564L,1769064599747528199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199757Inst : IEnumerable<long>
{
public static readonly long[] Value=A199757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199757.Bytes);
public long this[int i]=>Value[i];

public static A199757Inst Instance=new A199757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199758
{
public static readonly long[] Value={ 8L,78L,848L,9318L,102488L,1127358L,12400928L,136410198L,1500512168L,16505633838L,181561972208L,1997181694278L,21968998637048L,241658985007518L,2658248835082688L,29240737185909558L,321648109045005128L,3538129199495056398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199758Inst : IEnumerable<long>
{
public static readonly long[] Value=A199758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199758.Bytes);
public long this[int i]=>Value[i];

public static A199758Inst Instance=new A199758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199759
{
public static readonly long[] Value={ 9L,89L,969L,10649L,117129L,1288409L,14172489L,155897369L,1714871049L,18863581529L,207499396809L,2282493364889L,25107427013769L,276181697151449L,3037998668665929L,33417985355325209L,367597838908577289L,4043576227994350169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199759Inst : IEnumerable<long>
{
public static readonly long[] Value=A199759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199759.Bytes);
public long this[int i]=>Value[i];

public static A199759Inst Instance=new A199759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199760
{
public static readonly long[] Value={ 1L,10L,109L,1198L,13177L,144946L,1594405L,17538454L,192922993L,2122152922L,23343682141L,256780503550L,2824585539049L,31070440929538L,341774850224917L,3759523352474086L,41354756877214945L,454902325649364394L,5003925582143008333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199760Inst : IEnumerable<long>
{
public static readonly long[] Value=A199760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199760.Bytes);
public long this[int i]=>Value[i];

public static A199760Inst Instance=new A199760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199761
{
public static readonly ulong[] Value={ 2L,20L,218L,2396L,26354L,289892L,3188810L,35076908L,385845986L,4244305844L,46687364282L,513561007100L,5649171078098L,62140881859076L,683549700449834L,7519046704948172L,82709513754429890L,909804651298728788L,10007851164286016666UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199761Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199761.Bytes);
public ulong this[int i]=>Value[i];

public static A199761Inst Instance=new A199761Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199762
{
public static readonly long[] Value={ 5L,50L,545L,5990L,65885L,724730L,7972025L,87692270L,964614965L,10610764610L,116718410705L,1283902517750L,14122927695245L,155352204647690L,1708874251124585L,18797616762370430L,206773784386074725L,2274511628246821970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199762Inst : IEnumerable<long>
{
public static readonly long[] Value=A199762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199762.Bytes);
public long this[int i]=>Value[i];

public static A199762Inst Instance=new A199762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199763
{
public static readonly long[] Value={ 10L,100L,1090L,11980L,131770L,1449460L,15944050L,175384540L,1929229930L,21221529220L,233436821410L,2567805035500L,28245855390490L,310704409295380L,3417748502249170L,37595233524740860L,413547568772149450L,4549023256493643940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199763Inst : IEnumerable<long>
{
public static readonly long[] Value=A199763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199763.Bytes);
public long this[int i]=>Value[i];

public static A199763Inst Instance=new A199763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199764
{
public static readonly long[] Value={ 11L,111L,1211L,13311L,146411L,1610511L,17715611L,194871711L,2143588811L,23579476911L,259374246011L,2853116706111L,31384283767211L,345227121439311L,3797498335832411L,41772481694156511L,459497298635721611L,5054470284992937711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199764Inst : IEnumerable<long>
{
public static readonly long[] Value=A199764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199764.Bytes);
public long this[int i]=>Value[i];

public static A199764Inst Instance=new A199764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199765
{
public static readonly long[] Value={ 1L,4L,10L,12L,18L,26L,30L,34L,38L,42L,48L,50L,58L,68L,76L,72L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199765Inst : IEnumerable<long>
{
public static readonly long[] Value=A199765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199765.Bytes);
public long this[int i]=>Value[i];

public static A199765Inst Instance=new A199765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199766
{
public static readonly long[] Value={ 1L,6L,8L,14L,22L,24L,28L,36L,44L,48L,52L,52L,62L,70L,72L,76L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199766Inst : IEnumerable<long>
{
public static readonly long[] Value=A199766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199766.Bytes);
public long this[int i]=>Value[i];

public static A199766Inst Instance=new A199766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199767
{
public static readonly long[] Value={ 21L,45L,432L,740L,1728L,3456L,3888L,5616L,12096L,23760L,46656L,52164L,131328L,152064L,186624L,195656L,233280L,311472L,606528L,618192L,746496L,926208L,933120L,979776L,1273536L,1403136L,2985984L,3221456L,3732480L,5178816L,5412096L,5971968L,9704448L,13651200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199767Inst : IEnumerable<long>
{
public static readonly long[] Value=A199767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199767.Bytes);
public long this[int i]=>Value[i];

public static A199767Inst Instance=new A199767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199768
{
public static readonly long[] Value={ 4L,6L,8L,12L,16L,18L,20L,24L,27L,30L,32L,36L,40L,42L,45L,48L,50L,54L,56L,60L,64L,70L,72L,75L,80L,81L,84L,90L,96L,100L,105L,108L,112L,120L,126L,128L,132L,135L,140L,144L,150L,160L,162L,168L,180L,189L,192L,196L,198L,200L,210L,216L,220L,224L,225L,240L,243L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199768Inst : IEnumerable<long>
{
public static readonly long[] Value=A199768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199768.Bytes);
public long this[int i]=>Value[i];

public static A199768Inst Instance=new A199768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199769
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199769Inst : IEnumerable<long>
{
public static readonly long[] Value=A199769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199769.Bytes);
public long this[int i]=>Value[i];

public static A199769Inst Instance=new A199769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199770
{
public static readonly long[] Value={ 1L,0L,2L,6L,18L,50L,146L,426L,1282L,3810L,11394L,34082L,102338L,306658L,919874L,2759154L,8276898L,24828386L,74484386L,223444258L,670326242L,2010964770L,6032902242L,18098635298L,54295809826L,162887261410L,488661978274L,1465985458850L,4397955924386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199770Inst : IEnumerable<long>
{
public static readonly long[] Value=A199770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199770.Bytes);
public long this[int i]=>Value[i];

public static A199770Inst Instance=new A199770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199771
{
public static readonly long[] Value={ 1L,5L,12L,26L,45L,75L,112L,164L,225L,305L,396L,510L,637L,791L,960L,1160L,1377L,1629L,1900L,2210L,2541L,2915L,3312L,3756L,4225L,4745L,5292L,5894L,6525L,7215L,7936L,8720L,9537L,10421L,11340L,12330L,13357L,14459L,15600L,16820L,18081L,19425L,20812L,22286L,23805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199771Inst : IEnumerable<long>
{
public static readonly long[] Value=A199771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199771.Bytes);
public long this[int i]=>Value[i];

public static A199771Inst Instance=new A199771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199772
{
public static readonly long[] Value={ 1L,4L,25L,41L,260L,1649L,2705L,17156L,108809L,178489L,1132036L,7179745L,11777569L,74697220L,473754361L,777141065L,4928884484L,31260608081L,51279532721L,325231678724L,2062726378985L,3383672018521L,21460361911300L,136108680404929L,223271073689665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199772Inst : IEnumerable<long>
{
public static readonly long[] Value=A199772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199772.Bytes);
public long this[int i]=>Value[i];

public static A199772Inst Instance=new A199772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199773
{
public static readonly long[] Value={ 1L,16L,103L,169L,1072L,6799L,11153L,70736L,448631L,735929L,4667504L,29602847L,48560161L,307984528L,1953339271L,3204234697L,20322311344L,128890789039L,211430929841L,1340964564176L,8504838737303L,13951237134809L,88483338924272L,561190465872959L,920570219967553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199773Inst : IEnumerable<long>
{
public static readonly long[] Value=A199773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199773.Bytes);
public long this[int i]=>Value[i];

public static A199773Inst Instance=new A199773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199774
{
public static readonly long[] Value={ 0L,3L,5L,32L,203L,333L,2112L,13395L,21973L,139360L,883867L,1449885L,9195648L,58321827L,95670437L,606773408L,3848356715L,6312798957L,40037849280L,253933221363L,416549060725L,2641891279072L,16755744253243L,27485925208893L,174324786569472L,1105625187492675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199774Inst : IEnumerable<long>
{
public static readonly long[] Value=A199774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199774.Bytes);
public long this[int i]=>Value[i];

public static A199774Inst Instance=new A199774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199775
{
public static readonly long[] Value={ 1L,3L,3L,1L,4L,8L,6L,9L,5L,9L,3L,3L,5L,0L,4L,0L,5L,0L,3L,3L,2L,7L,3L,6L,3L,0L,6L,9L,9L,1L,7L,3L,3L,9L,5L,4L,3L,0L,2L,5L,8L,7L,5L,9L,3L,3L,5L,7L,9L,9L,5L,1L,5L,0L,9L,6L,9L,6L,3L,2L,6L,4L,2L,5L,4L,4L,8L,5L,8L,5L,9L,0L,2L,5L,5L,4L,7L,7L,3L,3L,3L,0L,2L,3L,5L,2L,2L,9L,3L,3L,0L,2L,9L,4L,9L,4L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199775Inst : IEnumerable<long>
{
public static readonly long[] Value=A199775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199775.Bytes);
public long this[int i]=>Value[i];

public static A199775Inst Instance=new A199775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199776
{
public static readonly long[] Value={ 9L,8L,0L,3L,7L,6L,8L,4L,1L,9L,0L,9L,5L,6L,1L,4L,5L,1L,7L,1L,1L,7L,1L,7L,8L,8L,0L,2L,6L,9L,3L,9L,6L,3L,0L,3L,3L,7L,7L,0L,0L,5L,9L,2L,1L,1L,8L,0L,7L,6L,9L,9L,5L,2L,0L,9L,7L,3L,5L,8L,9L,2L,5L,6L,1L,0L,5L,5L,1L,5L,0L,3L,4L,9L,7L,4L,0L,4L,8L,2L,7L,3L,3L,7L,9L,2L,9L,0L,8L,2L,4L,6L,8L,5L,7L,6L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199776Inst : IEnumerable<long>
{
public static readonly long[] Value=A199776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199776.Bytes);
public long this[int i]=>Value[i];

public static A199776Inst Instance=new A199776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199777
{
public static readonly long[] Value={ 1L,4L,8L,0L,5L,4L,6L,3L,3L,1L,7L,5L,4L,9L,1L,2L,0L,3L,7L,7L,6L,7L,6L,4L,3L,0L,5L,7L,9L,2L,3L,2L,7L,5L,8L,7L,3L,2L,9L,8L,5L,3L,8L,3L,0L,2L,7L,5L,8L,0L,3L,5L,3L,7L,3L,4L,1L,7L,0L,4L,6L,2L,9L,8L,7L,3L,8L,9L,1L,5L,6L,6L,9L,3L,9L,7L,3L,7L,1L,1L,7L,9L,3L,1L,8L,4L,7L,5L,2L,0L,5L,7L,3L,9L,5L,4L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199777Inst : IEnumerable<long>
{
public static readonly long[] Value=A199777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199777.Bytes);
public long this[int i]=>Value[i];

public static A199777Inst Instance=new A199777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199778
{
public static readonly long[] Value={ 1L,3L,7L,0L,6L,8L,0L,9L,7L,2L,6L,0L,4L,8L,9L,3L,4L,8L,5L,7L,9L,1L,1L,2L,0L,8L,0L,6L,8L,8L,0L,2L,9L,0L,4L,3L,2L,9L,8L,3L,6L,4L,6L,0L,2L,7L,1L,3L,0L,0L,5L,1L,0L,3L,9L,5L,0L,8L,9L,7L,8L,5L,0L,7L,0L,4L,2L,4L,5L,6L,7L,8L,3L,5L,4L,6L,2L,7L,6L,4L,3L,4L,1L,4L,5L,8L,4L,8L,6L,1L,9L,2L,2L,1L,7L,3L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199778Inst : IEnumerable<long>
{
public static readonly long[] Value=A199778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199778.Bytes);
public long this[int i]=>Value[i];

public static A199778Inst Instance=new A199778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199779
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,8L,5L,2L,1L,1L,0L,7L,1L,3L,5L,0L,4L,6L,9L,9L,4L,5L,7L,6L,2L,0L,0L,7L,1L,7L,9L,5L,5L,7L,8L,8L,1L,3L,2L,0L,0L,1L,5L,4L,2L,2L,5L,8L,5L,7L,3L,9L,1L,4L,2L,2L,7L,9L,4L,5L,7L,5L,9L,2L,9L,6L,4L,5L,1L,7L,7L,8L,4L,0L,2L,5L,7L,6L,5L,5L,7L,3L,2L,8L,6L,6L,8L,3L,6L,1L,8L,4L,8L,1L,4L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199779Inst : IEnumerable<long>
{
public static readonly long[] Value=A199779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199779.Bytes);
public long this[int i]=>Value[i];

public static A199779Inst Instance=new A199779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199780
{
public static readonly long[] Value={ 1L,0L,9L,4L,1L,8L,7L,4L,5L,1L,4L,7L,9L,3L,4L,4L,8L,8L,1L,8L,5L,5L,5L,6L,0L,8L,9L,0L,9L,0L,2L,4L,8L,5L,1L,6L,6L,2L,7L,3L,2L,0L,4L,4L,6L,6L,3L,0L,2L,8L,6L,6L,4L,8L,4L,1L,4L,5L,0L,6L,8L,6L,7L,5L,0L,1L,0L,6L,7L,9L,0L,0L,1L,6L,6L,7L,3L,2L,8L,8L,2L,2L,8L,6L,4L,7L,5L,0L,6L,2L,5L,4L,7L,3L,3L,9L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199780Inst : IEnumerable<long>
{
public static readonly long[] Value=A199780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199780.Bytes);
public long this[int i]=>Value[i];

public static A199780Inst Instance=new A199780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199781
{
public static readonly long[] Value={ 1L,3L,9L,8L,8L,0L,6L,8L,9L,3L,8L,9L,4L,9L,0L,3L,2L,5L,9L,7L,9L,1L,2L,3L,8L,1L,1L,8L,9L,8L,3L,7L,9L,1L,3L,8L,4L,0L,2L,8L,5L,1L,9L,8L,5L,7L,0L,6L,5L,0L,4L,7L,1L,7L,1L,7L,2L,5L,2L,4L,0L,7L,5L,2L,9L,7L,8L,9L,2L,2L,8L,5L,1L,5L,2L,4L,5L,5L,8L,2L,5L,5L,9L,1L,7L,2L,4L,8L,0L,9L,4L,0L,3L,7L,0L,1L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199781Inst : IEnumerable<long>
{
public static readonly long[] Value=A199781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199781.Bytes);
public long this[int i]=>Value[i];

public static A199781Inst Instance=new A199781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199782
{
public static readonly long[] Value={ 1L,1L,7L,1L,2L,5L,7L,3L,0L,0L,3L,4L,2L,5L,6L,2L,9L,5L,6L,1L,8L,4L,6L,1L,2L,5L,0L,0L,5L,3L,9L,2L,0L,6L,8L,9L,4L,0L,5L,9L,3L,7L,3L,6L,4L,3L,4L,6L,9L,1L,8L,6L,8L,8L,3L,7L,6L,7L,5L,5L,8L,2L,7L,7L,1L,2L,6L,3L,9L,1L,8L,5L,7L,2L,1L,0L,7L,8L,6L,7L,7L,1L,5L,3L,0L,7L,8L,7L,5L,7L,3L,6L,3L,3L,4L,3L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199782Inst : IEnumerable<long>
{
public static readonly long[] Value=A199782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199782.Bytes);
public long this[int i]=>Value[i];

public static A199782Inst Instance=new A199782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199783
{
public static readonly long[] Value={ 1L,3L,1L,6L,1L,8L,8L,8L,7L,0L,7L,7L,3L,5L,2L,8L,4L,8L,6L,8L,5L,0L,0L,1L,0L,8L,0L,6L,8L,9L,9L,2L,2L,1L,1L,4L,5L,2L,8L,1L,0L,0L,1L,6L,5L,0L,0L,5L,0L,7L,2L,9L,0L,0L,8L,3L,0L,7L,1L,3L,9L,9L,6L,0L,5L,6L,4L,2L,3L,9L,5L,3L,4L,1L,3L,2L,2L,8L,0L,5L,3L,4L,0L,7L,2L,8L,1L,2L,1L,7L,3L,4L,8L,6L,3L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199783Inst : IEnumerable<long>
{
public static readonly long[] Value=A199783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199783.Bytes);
public long this[int i]=>Value[i];

public static A199783Inst Instance=new A199783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199784
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,5L,4L,0L,6L,5L,5L,1L,1L,1L,0L,2L,5L,7L,1L,3L,5L,0L,4L,8L,0L,4L,9L,4L,7L,2L,1L,9L,2L,8L,6L,9L,1L,7L,4L,0L,2L,7L,3L,8L,8L,0L,5L,8L,3L,4L,0L,0L,1L,0L,9L,7L,3L,4L,3L,6L,4L,6L,8L,8L,3L,7L,6L,6L,4L,9L,6L,6L,5L,1L,4L,5L,7L,5L,8L,5L,2L,5L,0L,3L,7L,8L,0L,7L,8L,9L,2L,1L,2L,4L,6L,1L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199784Inst : IEnumerable<long>
{
public static readonly long[] Value=A199784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199784.Bytes);
public long this[int i]=>Value[i];

public static A199784Inst Instance=new A199784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199785
{
public static readonly long[] Value={ 1L,1L,1L,8L,6L,2L,8L,9L,9L,9L,6L,3L,4L,8L,7L,2L,1L,4L,0L,6L,5L,4L,9L,6L,1L,6L,6L,3L,2L,4L,7L,1L,8L,1L,0L,4L,7L,8L,1L,7L,0L,9L,4L,6L,7L,8L,4L,0L,6L,5L,8L,1L,6L,8L,3L,4L,4L,1L,4L,7L,4L,3L,6L,0L,9L,9L,5L,6L,2L,8L,7L,6L,8L,5L,9L,4L,3L,8L,5L,2L,4L,0L,0L,1L,5L,4L,4L,9L,5L,9L,4L,9L,2L,3L,1L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199785Inst : IEnumerable<long>
{
public static readonly long[] Value=A199785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199785.Bytes);
public long this[int i]=>Value[i];

public static A199785Inst Instance=new A199785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199786
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,0L,1L,9L,7L,8L,8L,8L,6L,3L,4L,9L,0L,7L,2L,5L,7L,6L,8L,0L,0L,1L,8L,2L,2L,0L,1L,2L,1L,2L,2L,7L,9L,6L,5L,9L,7L,9L,1L,5L,5L,3L,4L,2L,1L,3L,2L,2L,2L,1L,8L,3L,2L,6L,4L,0L,9L,7L,1L,7L,5L,4L,3L,0L,3L,7L,5L,8L,2L,5L,3L,0L,3L,8L,2L,5L,2L,0L,8L,1L,2L,5L,9L,1L,4L,5L,8L,6L,1L,2L,9L,9L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199786Inst : IEnumerable<long>
{
public static readonly long[] Value=A199786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199786.Bytes);
public long this[int i]=>Value[i];

public static A199786Inst Instance=new A199786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199787
{
public static readonly long[] Value={ 1L,2L,8L,1L,9L,0L,5L,4L,7L,3L,9L,8L,3L,4L,0L,5L,3L,7L,7L,3L,8L,4L,5L,5L,4L,8L,5L,6L,8L,3L,4L,7L,5L,8L,5L,2L,2L,4L,3L,9L,7L,4L,4L,3L,0L,2L,8L,9L,4L,1L,7L,5L,2L,9L,5L,4L,5L,5L,4L,6L,3L,7L,5L,6L,6L,6L,9L,7L,1L,1L,2L,7L,7L,7L,3L,4L,3L,9L,8L,3L,9L,6L,7L,1L,8L,8L,3L,5L,4L,6L,8L,5L,6L,6L,5L,0L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199787Inst : IEnumerable<long>
{
public static readonly long[] Value=A199787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199787.Bytes);
public long this[int i]=>Value[i];

public static A199787Inst Instance=new A199787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199788
{
public static readonly long[] Value={ 1L,0L,4L,9L,1L,8L,8L,7L,0L,8L,2L,0L,0L,4L,3L,4L,2L,1L,3L,4L,2L,7L,2L,0L,7L,6L,6L,5L,0L,0L,3L,9L,2L,6L,6L,0L,8L,2L,9L,4L,3L,9L,0L,2L,2L,5L,2L,1L,7L,1L,6L,7L,1L,4L,5L,2L,0L,4L,5L,1L,3L,7L,6L,6L,6L,9L,0L,4L,4L,5L,3L,3L,1L,2L,1L,1L,4L,9L,3L,0L,9L,0L,6L,6L,9L,8L,5L,1L,3L,7L,0L,9L,0L,5L,0L,4L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199788Inst : IEnumerable<long>
{
public static readonly long[] Value=A199788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199788.Bytes);
public long this[int i]=>Value[i];

public static A199788Inst Instance=new A199788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199789
{
public static readonly long[] Value={ 9L,0L,6L,2L,4L,7L,6L,9L,1L,6L,3L,5L,6L,4L,4L,0L,7L,9L,9L,1L,8L,6L,2L,3L,6L,3L,1L,0L,2L,9L,6L,4L,6L,7L,4L,1L,4L,2L,5L,1L,9L,2L,7L,7L,4L,8L,0L,8L,0L,0L,3L,6L,7L,8L,6L,9L,4L,0L,0L,0L,9L,6L,1L,3L,7L,2L,9L,8L,7L,2L,0L,1L,3L,0L,7L,6L,3L,3L,7L,9L,1L,9L,7L,9L,6L,3L,5L,8L,5L,8L,3L,4L,5L,6L,4L,9L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199789Inst : IEnumerable<long>
{
public static readonly long[] Value=A199789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199789.Bytes);
public long this[int i]=>Value[i];

public static A199789Inst Instance=new A199789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199790
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,0L,7L,1L,4L,9L,1L,2L,2L,4L,4L,1L,6L,1L,2L,8L,5L,9L,3L,2L,5L,7L,6L,3L,7L,3L,4L,5L,1L,5L,2L,8L,6L,1L,1L,7L,5L,0L,1L,9L,6L,9L,5L,2L,9L,0L,2L,4L,3L,9L,7L,1L,0L,9L,9L,5L,1L,1L,3L,8L,5L,4L,8L,7L,5L,6L,0L,3L,7L,1L,5L,4L,5L,5L,2L,2L,1L,8L,6L,1L,5L,3L,7L,4L,4L,0L,4L,4L,9L,6L,2L,2L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199790Inst : IEnumerable<long>
{
public static readonly long[] Value=A199790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199790.Bytes);
public long this[int i]=>Value[i];

public static A199790Inst Instance=new A199790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199791
{
public static readonly long[] Value={ 1L,1L,0L,6L,5L,5L,5L,0L,9L,2L,4L,6L,9L,1L,8L,0L,9L,7L,0L,2L,4L,4L,6L,4L,6L,1L,1L,4L,9L,7L,3L,3L,0L,2L,4L,7L,1L,5L,9L,9L,9L,6L,1L,2L,7L,2L,7L,7L,6L,6L,2L,6L,1L,4L,8L,9L,4L,4L,2L,9L,4L,0L,2L,1L,7L,6L,2L,4L,2L,3L,9L,9L,0L,1L,7L,1L,3L,6L,9L,5L,6L,5L,9L,9L,8L,1L,6L,3L,4L,6L,7L,6L,7L,7L,4L,9L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199791Inst : IEnumerable<long>
{
public static readonly long[] Value=A199791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199791.Bytes);
public long this[int i]=>Value[i];

public static A199791Inst Instance=new A199791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199792
{
public static readonly long[] Value={ 9L,5L,4L,9L,5L,6L,8L,5L,5L,8L,6L,2L,7L,9L,1L,4L,3L,4L,7L,2L,5L,7L,1L,4L,1L,1L,1L,6L,0L,9L,9L,5L,6L,1L,5L,7L,9L,6L,4L,9L,1L,2L,2L,5L,0L,6L,0L,6L,8L,6L,8L,6L,0L,5L,7L,5L,9L,6L,8L,5L,7L,5L,2L,9L,0L,3L,4L,9L,7L,4L,5L,9L,0L,1L,2L,0L,6L,4L,9L,1L,6L,2L,6L,2L,7L,1L,6L,3L,6L,5L,7L,7L,8L,1L,2L,8L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199792Inst : IEnumerable<long>
{
public static readonly long[] Value=A199792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199792.Bytes);
public long this[int i]=>Value[i];

public static A199792Inst Instance=new A199792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199793
{
public static readonly long[] Value={ 7L,7L,6L,4L,4L,3L,1L,0L,8L,9L,0L,3L,8L,3L,8L,1L,0L,1L,9L,0L,9L,6L,6L,9L,9L,4L,9L,1L,6L,2L,9L,8L,2L,8L,8L,7L,9L,1L,8L,0L,0L,5L,1L,4L,7L,8L,0L,9L,6L,9L,7L,4L,8L,0L,0L,4L,9L,6L,7L,4L,3L,2L,3L,2L,8L,0L,2L,5L,3L,5L,0L,0L,9L,6L,6L,9L,9L,4L,8L,0L,5L,6L,9L,3L,4L,9L,4L,0L,5L,2L,8L,4L,9L,8L,9L,3L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199793Inst : IEnumerable<long>
{
public static readonly long[] Value=A199793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199793.Bytes);
public long this[int i]=>Value[i];

public static A199793Inst Instance=new A199793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199794
{
public static readonly long[] Value={ 1L,1L,7L,5L,3L,0L,5L,6L,3L,4L,8L,9L,1L,9L,4L,3L,1L,0L,3L,8L,5L,3L,1L,1L,5L,2L,1L,6L,2L,8L,7L,2L,0L,2L,9L,4L,9L,7L,2L,0L,4L,5L,9L,1L,7L,8L,4L,5L,1L,0L,4L,9L,8L,0L,8L,4L,0L,3L,5L,5L,9L,9L,1L,2L,2L,7L,8L,0L,4L,5L,5L,5L,5L,3L,6L,2L,8L,7L,2L,8L,5L,0L,0L,8L,3L,9L,3L,8L,4L,5L,8L,6L,2L,6L,8L,1L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199794Inst : IEnumerable<long>
{
public static readonly long[] Value=A199794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199794.Bytes);
public long this[int i]=>Value[i];

public static A199794Inst Instance=new A199794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199795
{
public static readonly long[] Value={ 1L,0L,1L,3L,6L,1L,4L,2L,4L,5L,6L,5L,0L,4L,0L,0L,9L,4L,5L,3L,6L,8L,8L,5L,8L,7L,8L,9L,7L,2L,4L,4L,7L,6L,7L,1L,2L,1L,1L,4L,4L,9L,0L,1L,5L,1L,0L,0L,5L,2L,0L,9L,9L,7L,6L,7L,2L,6L,6L,8L,0L,7L,6L,1L,7L,2L,9L,5L,7L,1L,2L,7L,8L,5L,0L,4L,9L,3L,2L,6L,3L,4L,8L,7L,6L,6L,6L,4L,7L,0L,0L,4L,0L,6L,0L,3L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199795Inst : IEnumerable<long>
{
public static readonly long[] Value=A199795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199795.Bytes);
public long this[int i]=>Value[i];

public static A199795Inst Instance=new A199795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199796
{
public static readonly long[] Value={ 8L,2L,1L,2L,9L,7L,2L,1L,5L,5L,5L,5L,7L,4L,6L,2L,4L,9L,3L,2L,3L,2L,7L,1L,2L,7L,6L,5L,3L,2L,9L,1L,5L,9L,2L,1L,8L,0L,7L,9L,1L,5L,5L,7L,7L,6L,3L,7L,3L,4L,0L,8L,0L,9L,1L,3L,2L,3L,6L,8L,5L,9L,7L,6L,1L,7L,8L,6L,4L,2L,0L,7L,8L,4L,0L,9L,9L,2L,3L,5L,4L,5L,4L,6L,0L,0L,4L,5L,9L,1L,3L,6L,1L,5L,7L,2L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199796Inst : IEnumerable<long>
{
public static readonly long[] Value=A199796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199796.Bytes);
public long this[int i]=>Value[i];

public static A199796Inst Instance=new A199796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199797
{
public static readonly long[] Value={ 5L,9L,1L,0L,4L,7L,6L,6L,8L,0L,7L,2L,5L,4L,9L,5L,8L,7L,3L,9L,7L,8L,0L,9L,8L,4L,5L,4L,6L,4L,2L,1L,2L,4L,7L,3L,0L,5L,1L,6L,9L,0L,1L,3L,6L,4L,2L,8L,0L,1L,9L,8L,6L,6L,1L,9L,8L,3L,5L,2L,5L,6L,0L,1L,2L,6L,2L,6L,2L,3L,5L,7L,9L,0L,3L,0L,4L,5L,0L,7L,2L,7L,3L,2L,0L,7L,5L,4L,2L,5L,6L,1L,5L,9L,2L,7L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199797Inst : IEnumerable<long>
{
public static readonly long[] Value=A199797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199797.Bytes);
public long this[int i]=>Value[i];

public static A199797Inst Instance=new A199797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199798
{
public static readonly long[] Value={ 4L,13L,21L,132L,837L,1373L,8708L,55229L,90597L,574596L,3644277L,5978029L,37914628L,240467053L,394459317L,2501790852L,15867181221L,26028336893L,165080281604L,1046993493533L,1717475775621L,10892796795012L,69085703391957L,113327372854093L,718759508189188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199798Inst : IEnumerable<long>
{
public static readonly long[] Value=A199798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199798.Bytes);
public long this[int i]=>Value[i];

public static A199798Inst Instance=new A199798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199799
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,16L,17L,19L,20L,23L,25L,29L,31L,32L,34L,38L,40L,41L,43L,46L,47L,50L,53L,58L,59L,61L,62L,64L,67L,68L,71L,73L,76L,79L,80L,82L,83L,85L,86L,89L,92L,94L,95L,97L,100L,101L,103L,106L,107L,109L,113L,115L,116L,118L,122L,124L,125L,127L,128L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199799Inst : IEnumerable<long>
{
public static readonly long[] Value=A199799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199799.Bytes);
public long this[int i]=>Value[i];

public static A199799Inst Instance=new A199799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199800
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,2L,3L,2L,3L,0L,4L,2L,4L,3L,2L,2L,3L,3L,5L,3L,3L,3L,4L,4L,3L,2L,4L,3L,5L,3L,4L,3L,5L,5L,6L,3L,4L,3L,5L,5L,5L,6L,5L,4L,5L,5L,6L,7L,5L,4L,5L,4L,7L,6L,4L,4L,4L,5L,6L,6L,5L,6L,7L,4L,5L,2L,4L,7L,5L,7L,4L,5L,6L,7L,7L,7L,5L,6L,4L,7L,4L,7L,7L,6L,5L,3L,5L,8L,7L,7L,5L,5L,6L,4L,5L,4L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199800Inst : IEnumerable<long>
{
public static readonly long[] Value=A199800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199800.Bytes);
public long this[int i]=>Value[i];

public static A199800Inst Instance=new A199800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199801
{
public static readonly long[] Value={ 8L,675L,9800L,12167L,235224L,465124L,11309768L,4931691075L,5425069447L,13051463048L,8192480787000L,11968683934831L,15061377048200L,28821995554247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199801Inst : IEnumerable<long>
{
public static readonly long[] Value=A199801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199801.Bytes);
public long this[int i]=>Value[i];

public static A199801Inst Instance=new A199801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199802
{
public static readonly long[] Value={ 1L,2L,2L,1L,-1L,-4L,-7L,-8L,-5L,3L,15L,27L,32L,22L,-8L,-55L,-104L,-128L,-95L,17L,200L,399L,510L,405L,-11L,-721L,-1525L,-2024L,-1708L,-172L,2573L,5806L,8002L,7137L,1503L,-9072L,-22015L,-31520L,-29585L,-9073L,31519L,83119L,123712L,121778L,47732L,-107499L,-312396L,-483840L,-498119L,-233455L,357884L,1168399L,1885694L,2025929L,1090985L,-1152593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199802Inst : IEnumerable<long>
{
public static readonly long[] Value=A199802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199802.Bytes);
public long this[int i]=>Value[i];

public static A199802Inst Instance=new A199802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199803
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,2L,-1L,-1L,4L,-8L,12L,-15L,15L,-10L,-2L,22L,-49L,79L,-104L,112L,-88L,17L,111L,-294L,510L,-710L,815L,-721L,316L,488L,-1708L,3233L,-4769L,5806L,-5634L,3438L,1503L,-9505L,20080L,-31520L,40592L,-42527L,31519L,-1934L,-49666L,121778L,-204897L,278943L,-312396L,264664L,-93220L,-233455L,717295L,-1308634L,1885694L,-2243578L,2103343L,-1152593L,-873336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199803Inst : IEnumerable<long>
{
public static readonly long[] Value=A199803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199803.Bytes);
public long this[int i]=>Value[i];

public static A199803Inst Instance=new A199803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199804
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,3L,-4L,6L,-9L,13L,-19L,28L,-41L,60L,-88L,129L,-189L,277L,-406L,595L,-872L,1278L,-1873L,2745L,-4023L,5896L,-8641L,12664L,-18560L,27201L,-39865L,58425L,-85626L,125491L,-183916L,269542L,-395033L,578949L,-848491L,1243524L,-1822473L,2670964L,-3914488L,5736961L,-8407925L,12322413L,-18059374L,26467299L,-38789712L,56849086L,-83316385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199804Inst : IEnumerable<long>
{
public static readonly long[] Value=A199804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199804.Bytes);
public long this[int i]=>Value[i];

public static A199804Inst Instance=new A199804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199805
{
public static readonly long[] Value={ 1L,-1L,-4L,10L,8L,-61L,35L,268L,-512L,-732L,3525L,-645L,-17200L,24682L,57148L,-197113L,-46745L,1064776L,-1085312L,-4088200L,10626281L,7664631L,-63798924L,40190250L,275842720L,-548257525L,-726966901L,3703906996L,-893172736L,-17805071620L,26701809197L,57726469171L,-208147414040L,-35978050998L,1107739781172L,-1193723409393L,-4172806133425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199805Inst : IEnumerable<long>
{
public static readonly long[] Value=A199805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199805.Bytes);
public long this[int i]=>Value[i];

public static A199805Inst Instance=new A199805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199806
{
public static readonly long[] Value={ 1L,0L,0L,8L,-5L,18L,-14L,80L,-9L,100L,-44L,204L,-65L,294L,30L,672L,-119L,540L,-152L,1040L,63L,1210L,-230L,1752L,-75L,2028L,-54L,2996L,-377L,2190L,-434L,5440L,165L,4624L,280L,5472L,-629L,6498L,234L,8800L,-779L,6300L,-860L,12188L,225L,11638L,-1034L,14256L,-245L,13000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199806Inst : IEnumerable<long>
{
public static readonly long[] Value=A199806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199806.Bytes);
public long this[int i]=>Value[i];

public static A199806Inst Instance=new A199806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199807
{
public static readonly long[] Value={ 40L,120L,128L,192L,384L,600L,960L,960L,960L,1920L,2880L,3072L,4800L,4800L,7680L,14400L,14400L,15360L,23040L,23040L,36000L,46080L,72000L,115200L,115200L,115200L,288000L,4320000L,576000L,864000L,921600L,1728000L,2764800L,6912000L,13824000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199807Inst : IEnumerable<long>
{
public static readonly long[] Value=A199807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199807.Bytes);
public long this[int i]=>Value[i];

public static A199807Inst Instance=new A199807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199808
{
public static readonly long[] Value={ 480L,1536L,1920L,4608L,5760L,14400L,18432L,34560L,46080L,57600L,72000L,92160L,138240L,230400L,276480L,691200L,691200L,884736L,1105920L,1728000L,2211840L,2764800L,3456000L,6635520L,8294400L,11059200L,13824000L,26542080L,33177600L,41472000L,82944000L,103680000L,132710400L,331776000L,995328000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199808Inst : IEnumerable<long>
{
public static readonly long[] Value=A199808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199808.Bytes);
public long this[int i]=>Value[i];

public static A199808Inst Instance=new A199808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199809
{
public static readonly long[] Value={ 16L,50L,211L,384L,470L,1053L,1500L,2242L,3197L,3277L,5501L,6780L,8710L,9896L,10584L,15198L,15395L,21237L,23346L,28696L,33596L,37725L,40795L,48474L,55369L,54146L,69113L,75732L,84962L,92541L,95623L,98672L,123575L,127317L,146639L,141066L,154975L,173416L,201032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199809Inst : IEnumerable<long>
{
public static readonly long[] Value=A199809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199809.Bytes);
public long this[int i]=>Value[i];

public static A199809Inst Instance=new A199809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199810
{
public static readonly long[] Value={ 40L,120L,128L,192L,384L,600L,960L,960L,960L,1920L,2880L,3072L,4800L,4800L,7680L,14400L,14400L,15360L,23040L,23040L,36000L,46080L,72000L,115200L,115200L,115200L,288000L,4320000L,576000L,864000L,921600L,1728000L,2764800L,6912000L,13824000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199810Inst : IEnumerable<long>
{
public static readonly long[] Value=A199810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199810.Bytes);
public long this[int i]=>Value[i];

public static A199810Inst Instance=new A199810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199811
{
public static readonly long[] Value={ 23040L,23040L,69120L,73728L,221184L,221184L,864000L,864000L,2764800L,2764800L,2764800L,2764800L,4423680L,8294400L,8294400L,13271040L,13271040L,42467328L,103680000L,165888000L,165888000L,165888000L,165888000L,497664000L,497664000L,530841600L,530841600L,1592524800L,1592524800L,1592524800L,1592524800L,6220800000L,19906560000L,19906560000L,59719680000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199811Inst : IEnumerable<long>
{
public static readonly long[] Value=A199811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199811.Bytes);
public long this[int i]=>Value[i];

public static A199811Inst Instance=new A199811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199812
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,32L,79L,193L,478L,1196L,3037L,7802L,20287L,53259L,141069L,376449L,1011295L,2732453L,7421128L,20247355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199812Inst : IEnumerable<long>
{
public static readonly long[] Value=A199812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199812.Bytes);
public long this[int i]=>Value[i];

public static A199812Inst Instance=new A199812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199813
{
public static readonly BigInteger[] Value={ 1L,4L,38L,504L,8249L,154036L,3149326L,68741880L,1576163328L,37548785408L,922252542128L,23222906277952L,596981991939677L,15616173859832740L,414621835401615110L,11150969618415168280UL,BigInteger.Parse("303278916800906999191"),BigInteger.Parse("8330190277527648516572"),BigInteger.Parse("230814933905555392525290") };
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
public class A199813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199813Inst Instance=new A199813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199814
{
public static readonly long[] Value={ 4L,2L,8L,0L,1L,1L,0L,3L,7L,9L,6L,4L,7L,2L,9L,9L,2L,3L,9L,0L,2L,0L,4L,1L,6L,9L,3L,9L,1L,7L,5L,1L,2L,6L,5L,5L,3L,3L,7L,6L,7L,1L,0L,7L,3L,7L,8L,0L,3L,9L,3L,9L,2L,9L,2L,8L,5L,6L,7L,5L,4L,5L,9L,1L,3L,3L,3L,3L,9L,2L,4L,7L,5L,0L,2L,3L,3L,2L,9L,3L,1L,5L,9L,1L,0L,8L,1L,6L,7L,6L,4L,4L,2L,5L,0L,3L,0L,6L,7L,1L,9L,6L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199814Inst : IEnumerable<long>
{
public static readonly long[] Value=A199814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199814.Bytes);
public long this[int i]=>Value[i];

public static A199814Inst Instance=new A199814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199815
{
public static readonly long[] Value={ 6L,4L,8L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199815Inst : IEnumerable<long>
{
public static readonly long[] Value=A199815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199815.Bytes);
public long this[int i]=>Value[i];

public static A199815Inst Instance=new A199815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199816
{
public static readonly BigInteger[] Value={ 1L,1L,8L,101L,1639L,30665L,630225L,13836981L,319062453L,7640441894L,188534274850L,4767113222750L,122998902095908L,3228067183537455L,85960229675478804L,2317956019913480326L,BigInteger.Parse("63193008693741620771"),BigInteger.Parse("1739473925024629613227"),BigInteger.Parse("48292271242981605779173") };
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
public class A199816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199816Inst Instance=new A199816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199817
{
public static readonly long[] Value={ 11L,35L,113L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199817Inst : IEnumerable<long>
{
public static readonly long[] Value=A199817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199817.Bytes);
public long this[int i]=>Value[i];

public static A199817Inst Instance=new A199817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199818
{
public static readonly long[] Value={ 43L,131L,133L,397L,405L,433L,435L,441L,475L,1237L,1251L,1285L,1301L,1313L,1325L,1339L,1425L,1427L,1431L,1433L,3861L,3925L,3939L,3941L,3981L,4017L,4019L,4043L,4277L,4293L,4297L,4301L,11605L,11829L,12053L,12131L,12133L,12853L,12885L,12893L,12913L,12931L,36181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199818Inst : IEnumerable<long>
{
public static readonly long[] Value=A199818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199818.Bytes);
public long this[int i]=>Value[i];

public static A199818Inst Instance=new A199818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199819
{
public static readonly BigInteger[] Value={ 19L,271L,5217031L,68618940391L,8649148282327007911L,BigInteger.Parse("95289871302753755165078396311") };
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
public class A199819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199819Inst Instance=new A199819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199820
{
public static readonly BigInteger[] Value={ 331L,61051L,BigInteger.Parse("51159090448414546291") };
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
public class A199820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199820Inst Instance=new A199820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199821
{
public static readonly long[] Value={ 23L,397L,16344637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199821Inst : IEnumerable<long>
{
public static readonly long[] Value=A199821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199821.Bytes);
public long this[int i]=>Value[i];

public static A199821Inst Instance=new A199821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199822
{
public static readonly long[] Value={ 1L,2L,6L,22L,90L,392L,1772L,8202L,38646L,185076L,900212L,4434356L,22009980L,109780044L,552560376L,2822976810L,14485344790L,72643772868L,361862583908L,2016493563604L,12216275226412L,46909968927072L,-57894718593752L,1891831831407844L,70615065586770972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199822Inst : IEnumerable<long>
{
public static readonly long[] Value=A199822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199822.Bytes);
public long this[int i]=>Value[i];

public static A199822Inst Instance=new A199822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199823
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,2L,20L,4L,-10L,334L,-864L,236L,8356L,22252L,-450052L,-347224L,30131822L,-54733650L,-2300158256L,10315132412L,221235097892L,-1741162058468L,-25836213977848L,319542298035704L,3570412755518780L,-66526876971287412L,-567916947391285280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199823Inst : IEnumerable<long>
{
public static readonly long[] Value=A199823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199823.Bytes);
public long this[int i]=>Value[i];

public static A199823Inst Instance=new A199823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199824
{
public static readonly long[] Value={ 67L,167L,587L,719L,751L,769L,1129L,1163L,1531L,1913L,2099L,2153L,2543L,2819L,3049L,3079L,3709L,3967L,4691L,4861L,4909L,5147L,5347L,5749L,5813L,5939L,6121L,6151L,6397L,6473L,6563L,6709L,6883L,6899L,6911L,7247L,7393L,7451L,7703L,7829L,7919L,8093L,8171L,8447L,8707L,8807L,8963L,9157L,9161L,9209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199824Inst : IEnumerable<long>
{
public static readonly long[] Value=A199824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199824.Bytes);
public long this[int i]=>Value[i];

public static A199824Inst Instance=new A199824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199825
{
public static readonly long[] Value={ 2L,4L,4L,10L,22L,34L,66L,138L,250L,472L,944L,1806L,3450L,6772L,13172L,25478L,49794L,97348L,189772L,371246L,727506L,1424586L,2793034L,5483342L,10766950L,21154424L,41599648L,81840866L,161080918L,317230034L,625030514L,1231964394L,2429323642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199825Inst : IEnumerable<long>
{
public static readonly long[] Value=A199825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199825.Bytes);
public long this[int i]=>Value[i];

public static A199825Inst Instance=new A199825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199826
{
public static readonly long[] Value={ 10L,40L,114L,426L,1650L,6126L,23206L,88636L,337866L,1295566L,4992364L,19269156L,74529210L,288954786L,1122363984L,4366362420L,17011617426L,66365823648L,259213619826L,1013542247970L,3966939195402L,15540399135516L,60929935280508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199826Inst : IEnumerable<long>
{
public static readonly long[] Value=A199826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199826.Bytes);
public long this[int i]=>Value[i];

public static A199826Inst Instance=new A199826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199827
{
public static readonly long[] Value={ 24L,140L,646L,3556L,20240L,113884L,645780L,3685550L,21117750L,121503530L,701432670L,4060132070L,23557575574L,136975281374L,797920002262L,4655761528566L,27205829211568L,159187551327960L,932560727269722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199827Inst : IEnumerable<long>
{
public static readonly long[] Value=A199827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199827.Bytes);
public long this[int i]=>Value[i];

public static A199827Inst Instance=new A199827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199828
{
public static readonly long[] Value={ 44L,336L,2146L,15708L,118280L,888420L,6715618L,51077518L,390278378L,2993722414L,23038998514L,177794832922L,1375379617514L,10662124449466L,82808224932874L,644200988262616L,5018935818153796L,39154328577073846L,305823285072243150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199828Inst : IEnumerable<long>
{
public static readonly long[] Value=A199828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199828.Bytes);
public long this[int i]=>Value[i];

public static A199828Inst Instance=new A199828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199829
{
public static readonly long[] Value={ 70L,660L,5390L,49302L,462234L,4340094L,41008804L,389832124L,3723199342L,35697026718L,343371074564L,3312138136660L,32026131818486L,310327172410762L,3012628449222084L,29294846427926718L,285286085845772334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199829Inst : IEnumerable<long>
{
public static readonly long[] Value=A199829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199829.Bytes);
public long this[int i]=>Value[i];

public static A199829Inst Instance=new A199829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199830
{
public static readonly long[] Value={ 102L,1144L,11384L,124982L,1402934L,15805218L,179213048L,2044221894L,23427591518L,269528370904L,3111004900884L,36009192415678L,417810425670462L,4858093196583212L,56593178356427376L,660363780853262084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199830Inst : IEnumerable<long>
{
public static readonly long[] Value=A199830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199830.Bytes);
public long this[int i]=>Value[i];

public static A199830Inst Instance=new A199830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199831
{
public static readonly long[] Value={ 140L,1820L,21364L,273728L,3579520L,47040968L,622300326L,8281149188L,110718596524L,1486040082748L,20010711643976L,270217094416868L,3657780168834780L,49618552941019396L,674346504318284036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199831Inst : IEnumerable<long>
{
public static readonly long[] Value=A199831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199831.Bytes);
public long this[int i]=>Value[i];

public static A199831Inst Instance=new A199831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199832
{
public static readonly long[] Value={ 2L,10L,4L,24L,40L,4L,44L,140L,114L,10L,70L,336L,646L,426L,22L,102L,660L,2146L,3556L,1650L,34L,140L,1144L,5390L,15708L,20240L,6126L,66L,184L,1820L,11384L,49302L,118280L,113884L,23206L,138L,234L,2720L,21364L,124982L,462234L,888420L,645780L,88636L,250L,290L,3876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199832Inst : IEnumerable<long>
{
public static readonly long[] Value=A199832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199832.Bytes);
public long this[int i]=>Value[i];

public static A199832Inst Instance=new A199832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199833
{
public static readonly long[] Value={ 4L,40L,140L,336L,660L,1144L,1820L,2720L,3876L,5320L,7084L,9200L,11700L,14616L,17980L,21824L,26180L,31080L,36556L,42640L,49364L,56760L,64860L,73696L,83300L,93704L,104940L,117040L,130036L,143960L,158844L,174720L,191620L,209576L,228620L,248784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199833Inst : IEnumerable<long>
{
public static readonly long[] Value=A199833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199833.Bytes);
public long this[int i]=>Value[i];

public static A199833Inst Instance=new A199833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199834
{
public static readonly long[] Value={ 4L,114L,646L,2146L,5390L,11384L,21364L,36796L,59376L,91030L,133914L,190414L,263146L,354956L,468920L,608344L,776764L,977946L,1215886L,1494810L,1819174L,2193664L,2623196L,3112916L,3668200L,4294654L,4998114L,5784646L,6660546L,7632340L,8706784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199834Inst : IEnumerable<long>
{
public static readonly long[] Value=A199834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199834.Bytes);
public long this[int i]=>Value[i];

public static A199834Inst Instance=new A199834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199835
{
public static readonly long[] Value={ 10L,426L,3556L,15708L,49302L,124982L,273728L,538968L,978690L,1667554L,2699004L,4187380L,6270030L,9109422L,12895256L,17846576L,24213882L,32281242L,42368404L,54832908L,70072198L,88525734L,110677104L,137056136L,168241010L,204860370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199835Inst : IEnumerable<long>
{
public static readonly long[] Value=A199835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199835.Bytes);
public long this[int i]=>Value[i];

public static A199835Inst Instance=new A199835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199836
{
public static readonly long[] Value={ 22L,1650L,20240L,118280L,462234L,1402934L,3579520L,8046928L,16426926L,31082698L,55316976L,93593720L,151783346L,237431502L,360051392L,531439648L,766015750L,1081184994L,1497725008L,2040195816L,2737373450L,3622707110L,4734799872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199836Inst : IEnumerable<long>
{
public static readonly long[] Value=A199836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199836.Bytes);
public long this[int i]=>Value[i];

public static A199836Inst Instance=new A199836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199837
{
public static readonly long[] Value={ 34L,6126L,113884L,888420L,4340094L,15805218L,47040968L,120843752L,277500282L,583380598L,1141982292L,2107735180L,3702875670L,6237700074L,10134506112L,15955531856L,24435201362L,36516986238L,53395192396L,76561981236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199837Inst : IEnumerable<long>
{
public static readonly long[] Value=A199837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199837.Bytes);
public long this[int i]=>Value[i];

public static A199837Inst Instance=new A199837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199838
{
public static readonly long[] Value={ 66L,23206L,645780L,6715618L,41008804L,179213048L,622300326L,1827026482L,4719970500L,11025201168L,23740333870L,47800415256L,90973748554L,165038447302L,287293180292L,482460245532L,785043786046L,1242210635346L,1917265955424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199838Inst : IEnumerable<long>
{
public static readonly long[] Value=A199838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199838.Bytes);
public long this[int i]=>Value[i];

public static A199838Inst Instance=new A199838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199839
{
public static readonly long[] Value={ 138L,88636L,3685550L,51077518L,389832124L,2044221894L,8281149188L,27785393300L,80752300406L,209581305608L,496408914210L,1090354976530L,2248071267000L,4391976524034L,8191437222152L,14673108432136L,25367684178562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199839Inst : IEnumerable<long>
{
public static readonly long[] Value=A199839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199839.Bytes);
public long this[int i]=>Value[i];

public static A199839Inst Instance=new A199839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199840
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,3L,5L,8L,9L,12L,9L,8L,5L,3L,1L,1L,1L,1L,3L,6L,14L,24L,43L,62L,87L,100L,110L,100L,87L,62L,43L,24L,14L,6L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199840Inst : IEnumerable<long>
{
public static readonly long[] Value=A199840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199840.Bytes);
public long this[int i]=>Value[i];

public static A199840Inst Instance=new A199840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199841
{
public static readonly long[] Value={ 1L,3L,8L,23L,66L,192L,575L,1739L,5307L,16304L,50381L,156408L,487398L,1523663L,4776107L,15006513L,47247134L,149023605L,470794024L,1489462276L,4718330397L,14964219411L,47509518289L,150982994162L,480243297965L,1528796563830L,4870415108094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199841Inst : IEnumerable<long>
{
public static readonly long[] Value=A199841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199841.Bytes);
public long this[int i]=>Value[i];

public static A199841Inst Instance=new A199841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199842
{
public static readonly long[] Value={ 1L,4L,13L,42L,132L,428L,1393L,4561L,15032L,49889L,166542L,558744L,1883028L,6370957L,21628455L,73641852L,251385571L,860067894L,2948380732L,10124956970L,34823894885L,119940097035L,413612099138L,1427945022753L,4934850614704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199842Inst : IEnumerable<long>
{
public static readonly long[] Value=A199842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199842.Bytes);
public long this[int i]=>Value[i];

public static A199842Inst Instance=new A199842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199843
{
public static readonly long[] Value={ 1L,5L,18L,68L,239L,845L,2958L,10349L,36111L,126121L,441161L,1546353L,5432430L,19130949L,67536934L,238991556L,847646318L,3012890719L,10730694626L,38289978058L,136865206035L,489995352710L,1756812943841L,6307268945198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199843Inst : IEnumerable<long>
{
public static readonly long[] Value=A199843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199843.Bytes);
public long this[int i]=>Value[i];

public static A199843Inst Instance=new A199843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199844
{
public static readonly long[] Value={ 1L,6L,25L,103L,399L,1532L,5754L,21383L,78735L,288580L,1053894L,3840866L,13981403L,50874249L,185128907L,673970102L,2455319377L,8952722626L,32676307483L,119391572211L,436711281979L,1599194641093L,5862625449021L,21515851244159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199844Inst : IEnumerable<long>
{
public static readonly long[] Value=A199844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199844.Bytes);
public long this[int i]=>Value[i];

public static A199844Inst Instance=new A199844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199845
{
public static readonly long[] Value={ 1L,7L,32L,149L,630L,2600L,10426L,41079L,159330L,611698L,2329458L,8818874L,33234990L,124835120L,467743203L,1749482957L,6535398559L,24393753898L,91006458115L,339442473410L,1266045976128L,4722720042212L,17621749081077L,65775214030886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199845Inst : IEnumerable<long>
{
public static readonly long[] Value=A199845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199845.Bytes);
public long this[int i]=>Value[i];

public static A199845Inst Instance=new A199845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199846
{
public static readonly long[] Value={ 1L,8L,41L,206L,944L,4188L,17879L,74424L,303400L,1218440L,4833416L,18992142L,74057460L,287035502L,1107086841L,4253339267L,16289667330L,62230152461L,237255014892L,903101912666L,3433312226666L,13039708953325L,49488269035164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199846Inst : IEnumerable<long>
{
public static readonly long[] Value=A199846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199846.Bytes);
public long this[int i]=>Value[i];

public static A199846Inst Instance=new A199846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199847
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,1L,4L,8L,11L,1L,5L,13L,23L,26L,1L,6L,18L,42L,66L,63L,1L,7L,25L,68L,132L,192L,153L,1L,8L,32L,103L,239L,428L,575L,376L,1L,9L,41L,149L,399L,845L,1393L,1739L,931L,1L,10L,50L,206L,630L,1532L,2958L,4561L,5307L,2317L,1L,11L,61L,276L,944L,2600L,5754L,10349L,15032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199847Inst : IEnumerable<long>
{
public static readonly long[] Value=A199847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199847.Bytes);
public long this[int i]=>Value[i];

public static A199847Inst Instance=new A199847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199848
{
public static readonly long[] Value={ 11L,23L,42L,68L,103L,149L,206L,276L,361L,461L,578L,714L,869L,1045L,1244L,1466L,1713L,1987L,2288L,2618L,2979L,3371L,3796L,4256L,4751L,5283L,5854L,6464L,7115L,7809L,8546L,9328L,10157L,11033L,11958L,12934L,13961L,15041L,16176L,17366L,18613L,19919L,21284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199848Inst : IEnumerable<long>
{
public static readonly long[] Value=A199848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199848.Bytes);
public long this[int i]=>Value[i];

public static A199848Inst Instance=new A199848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199849
{
public static readonly long[] Value={ 26L,66L,132L,239L,399L,630L,944L,1367L,1913L,2612L,3482L,4557L,5857L,7424L,9278L,11465L,14011L,16966L,20356L,24239L,28643L,33630L,39232L,45515L,52513L,60300L,68910L,78421L,88873L,100348L,112886L,126577L,141463L,157638L,175148L,194091L,214515L,236526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199849Inst : IEnumerable<long>
{
public static readonly long[] Value=A199849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199849.Bytes);
public long this[int i]=>Value[i];

public static A199849Inst Instance=new A199849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199850
{
public static readonly long[] Value={ 63L,192L,428L,845L,1532L,2600L,4188L,6465L,9634L,13932L,19636L,27065L,36582L,48598L,63576L,82029L,104530L,131710L,164262L,202945L,248586L,302082L,364406L,436607L,519814L,615238L,724178L,848019L,988240L,1146414L,1324210L,1523399L,1745856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199850Inst : IEnumerable<long>
{
public static readonly long[] Value=A199850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199850.Bytes);
public long this[int i]=>Value[i];

public static A199850Inst Instance=new A199850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199851
{
public static readonly long[] Value={ 153L,575L,1393L,2958L,5754L,10426L,17879L,29268L,46126L,70322L,104253L,150764L,213380L,296204L,404213L,543086L,719592L,941366L,1217343L,1557506L,1973400L,2477778L,3085247L,3811830L,4675676L,5696580L,6896795L,8300422L,9934376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199851Inst : IEnumerable<long>
{
public static readonly long[] Value=A199851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199851.Bytes);
public long this[int i]=>Value[i];

public static A199851Inst Instance=new A199851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199852
{
public static readonly BigInteger[] Value={ 1L,2L,0L,4L,-20L,36L,2296L,-71280L,1347984L,-9104480L,-566853584L,26068456800L,-109901066912L,-42816208726368L,1570246237628160L,105861151925191936L,BigInteger.Parse("-11551468847311923968"),BigInteger.Parse("-237265887931262530560"),BigInteger.Parse("104987271408023239754752"),BigInteger.Parse("-2079616585958181891671040") };
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
public class A199852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199852Inst Instance=new A199852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199853
{
public static readonly long[] Value={ 1L,-1L,-1L,-3L,-6L,-14L,-31L,-70L,-157L,-353L,-793L,-1782L,-4004L,-8997L,-20216L,-45425L,-102069L,-229347L,-515338L,-1157954L,-2601899L,-5846414L,-13136773L,-29518061L,-66326481L,-149034250L,-334876920L,-752461609L,-1690765888L,-3799116465L,-8536537209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199853Inst : IEnumerable<long>
{
public static readonly long[] Value=A199853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199853.Bytes);
public long this[int i]=>Value[i];

public static A199853Inst Instance=new A199853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199854
{
public static readonly long[] Value={ 3L,11L,59L,83L,107L,131L,179L,227L,251L,347L,443L,467L,563L,587L,971L,1019L,1091L,1187L,1259L,1283L,1307L,1451L,1523L,1571L,1619L,1811L,1907L,1931L,2027L,2099L,2411L,2459L,2579L,2819L,2939L,2963L,3203L,3251L,3299L,3371L,3467L,3491L,3539L,3779L,3803L,3923L,3947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199854Inst : IEnumerable<long>
{
public static readonly long[] Value=A199854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199854.Bytes);
public long this[int i]=>Value[i];

public static A199854Inst Instance=new A199854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199855
{
public static readonly long[] Value={ 1L,4L,2L,5L,3L,6L,11L,7L,12L,8L,13L,9L,14L,10L,15L,22L,16L,23L,17L,24L,18L,25L,19L,26L,20L,27L,21L,28L,37L,29L,38L,30L,39L,31L,40L,32L,41L,33L,42L,34L,43L,35L,44L,36L,45L,56L,46L,57L,47L,58L,48L,59L,49L,60L,50L,61L,51L,62L,52L,63L,53L,64L,54L,65L,55L,66L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199855Inst : IEnumerable<long>
{
public static readonly long[] Value=A199855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199855.Bytes);
public long this[int i]=>Value[i];

public static A199855Inst Instance=new A199855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199856
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,1L,1L,-4L,1L,2L,1L,-8L,0L,4L,3L,1L,-16L,-4L,7L,8L,4L,1L,-32L,-16L,10L,19L,13L,5L,1L,-64L,-48L,8L,41L,37L,19L,6L,1L,-128L,-128L,-16L,80L,96L,62L,26L,7L,1L,-256L,-320L,-112L,136L,231L,183L,95L,34L,8L,1L,-512L,-768L,-416L,176L,518L,501L,311L,137L,43L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199856Inst : IEnumerable<long>
{
public static readonly long[] Value=A199856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199856.Bytes);
public long this[int i]=>Value[i];

public static A199856Inst Instance=new A199856Inst();

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